    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.Manufacturing.CostGroup
{
    //RPS VERSION 1.0.0.0
    public partial class CostGroup:Screen
    {
        public CostGroup():base()
        {
            this.URL = "manufacturing.costgroup";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            CostGroupSTRCollectionView  = new CostGroupSTRCollectionView(this); 
            CostGroupSTREntityView  = new CostGroupSTREntityView(this); 
            CostGroupSTRCollectionView.InitializeControls(); 
            CostGroupSTREntityView.InitializeControls(); 
           
        }
      
            public CostGroupSTRCollectionView CostGroupSTRCollectionView {get; set; } 
            public CostGroupSTREntityView CostGroupSTREntityView {get; set; } 
    }
            
    public partial class CostGroupSTRCollectionView : View
    {
        public CostGroupSTRCollectionView(CostGroup screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            NewButton = RPSControlFactory.RPSNewButton<CostGroupSTRCollectionView,CostGroupSTREntityView>( this,Screen.CostGroupSTREntityView);
 
            CollectionInit params_MainConsult = new CollectionInit(){IDDescriptor = "f600afa0-9c80-4798-bf25-86636eab69d9",CSSSelectorDescriptor = "",XPathDescriptor = ""};
            MainConsult = RPSControlFactory.RPSCreateCollection<CostGroupSTRCollectionView,CostGroupSTREntityView>( params_MainConsult,this,Screen.CostGroupSTREntityView);
 

        }
        public IRPSButton<CostGroupSTRCollectionView,CostGroupSTREntityView> NewButton { get; set; } 
        public IRPSCollectionEditor<CostGroupSTRCollectionView,CostGroupSTREntityView> MainConsult { get; set; } 
        public CostGroup Screen { get; set; }
        public CostGroupSTRCollectionView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class CostGroupSTREntityView : View
    {
        public CostGroupSTREntityView(CostGroup screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            SaveButton = RPSControlFactory.RPSSaveButton<CostGroupSTREntityView>( this);
 
            DeleteButton = RPSControlFactory.RPSDeleteButton<CostGroupSTREntityView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<CostGroupSTREntityView,CostGroupSTRCollectionView>( this,Screen.CostGroupSTRCollectionView);
 
            BackButton = RPSControlFactory.RPSBackButton<CostGroupSTREntityView,CostGroupSTRCollectionView>( this,Screen.CostGroupSTRCollectionView);
 
            CODCostGroup = RPSControlFactory.CreateRPSTextBox<CostGroupSTREntityView>("17fb9a8e-4149-4c77-800a-44c427355f35","","",true, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<CostGroupSTREntityView>("5e702239-8f37-4f42-b7d7-d185f6ddb0d3","","",false, this);
 

        }
        public IRPSSaveButton<CostGroupSTREntityView> SaveButton { get; set; } 
        public IRPSButton<CostGroupSTREntityView> DeleteButton { get; set; } 
        public IRPSButton<CostGroupSTREntityView,CostGroupSTRCollectionView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<CostGroupSTREntityView,CostGroupSTRCollectionView> BackButton { get; set; } 
        public IRPSTextBox<CostGroupSTREntityView> CODCostGroup { get; set; } 
        public IRPSTextBox<CostGroupSTREntityView> Description { get; set; } 
        public CostGroup Screen { get; set; }
        public CostGroupSTREntityView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}