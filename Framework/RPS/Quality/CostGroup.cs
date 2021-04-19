    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.Quality.CostGroup
{
    //RPS VERSION 1.0.0.0
    public partial class CostGroup:Screen
    {
        public CostGroup():base()
        {
            this.URL = "quality.costgroup";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            CostGroupCollectionView  = new CostGroupCollectionView(this); 
            CostGroupEntityView  = new CostGroupEntityView(this); 
            CostGroupCollectionView.InitializeControls(); 
            CostGroupEntityView.InitializeControls(); 
           
        }
      
            public CostGroupCollectionView CostGroupCollectionView {get; set; } 
            public CostGroupEntityView CostGroupEntityView {get; set; } 
    }
            
    public partial class CostGroupCollectionView : View
    {
        public CostGroupCollectionView(CostGroup screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            NewButton = RPSControlFactory.RPSNewButton<CostGroupCollectionView,CostGroupEntityView>( this,Screen.CostGroupEntityView);
 
            CollectionInit params_MainConsult = new CollectionInit(){IDDescriptor = "d25dce6e-bc88-4e11-87a6-01abfa35a55e",CSSSelectorDescriptor = "",XPathDescriptor = ""};
            MainConsult = RPSControlFactory.RPSCreateCollection<CostGroupCollectionView,CostGroupEntityView>( params_MainConsult,this,Screen.CostGroupEntityView);
 

        }
        public IRPSButton<CostGroupCollectionView,CostGroupEntityView> NewButton { get; set; } 
        public IRPSCollectionEditor<CostGroupCollectionView,CostGroupEntityView> MainConsult { get; set; } 
        public CostGroup Screen { get; set; }
        public CostGroupCollectionView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class CostGroupEntityView : View
    {
        public CostGroupEntityView(CostGroup screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            SaveButton = RPSControlFactory.RPSSaveButton<CostGroupEntityView>( this);
 
            DeleteButton = RPSControlFactory.RPSDeleteButton<CostGroupEntityView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<CostGroupEntityView,CostGroupCollectionView>( this,Screen.CostGroupCollectionView);
 
            BackButton = RPSControlFactory.RPSBackButton<CostGroupEntityView,CostGroupCollectionView>( this,Screen.CostGroupCollectionView);
 
            CodCostGroup = RPSControlFactory.CreateRPSTextBox<CostGroupEntityView>("3064594f-98e0-49ea-95e2-0cb134f9dfbf","","",true, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<CostGroupEntityView>("6d3b398d-c31c-4cef-badc-63db7819f6da","","",false, this);
 
            Type = RPSControlFactory.CreateRPSEnumComboBox<CostGroupEntityView>("a8a1d25d-b36e-4e20-bb85-3e4d6bfb6bf1","","",true, this);
 

        }
        public IRPSSaveButton<CostGroupEntityView> SaveButton { get; set; } 
        public IRPSButton<CostGroupEntityView> DeleteButton { get; set; } 
        public IRPSButton<CostGroupEntityView,CostGroupCollectionView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<CostGroupEntityView,CostGroupCollectionView> BackButton { get; set; } 
        public IRPSTextBox<CostGroupEntityView> CodCostGroup { get; set; } 
        public IRPSTextBox<CostGroupEntityView> Description { get; set; } 
        public IRPSComboBox<CostGroupEntityView> Type { get; set; } 
        public CostGroup Screen { get; set; }
        public CostGroupEntityView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}