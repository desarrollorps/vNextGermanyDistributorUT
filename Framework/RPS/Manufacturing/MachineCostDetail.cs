    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.Manufacturing.MachineCostDetail
{
    //RPS VERSION 1.0.0.0
    public partial class MachineCostDetail:Screen
    {
        public MachineCostDetail():base()
        {
            this.URL = "manufacturing.machinecostdetail";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            MachineCostDetailCollectionView  = new MachineCostDetailCollectionView(this); 
            MachineCostDetailEntityView  = new MachineCostDetailEntityView(this); 
            MachineCostDetailCollectionView.InitializeControls(); 
            MachineCostDetailEntityView.InitializeControls(); 
           
        }
      
            public MachineCostDetailCollectionView MachineCostDetailCollectionView {get; set; } 
            public MachineCostDetailEntityView MachineCostDetailEntityView {get; set; } 
    }
            
    public partial class MachineCostDetailCollectionView : View
    {
        public MachineCostDetailCollectionView(MachineCostDetail screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            NewButton = RPSControlFactory.RPSNewButton<MachineCostDetailCollectionView,MachineCostDetailEntityView>( this,Screen.MachineCostDetailEntityView);
 
            CollectionInit params_MainConsult = new CollectionInit(){IDDescriptor = "ed5b7530-3f59-41e4-ab3f-64050066edf7",CSSSelectorDescriptor = "",XPathDescriptor = ""};
            MainConsult = RPSControlFactory.RPSCreateCollection<MachineCostDetailCollectionView,MachineCostDetailEntityView>( params_MainConsult,this,Screen.MachineCostDetailEntityView);
 

        }
        public IRPSButton<MachineCostDetailCollectionView,MachineCostDetailEntityView> NewButton { get; set; } 
        public IRPSCollectionEditor<MachineCostDetailCollectionView,MachineCostDetailEntityView> MainConsult { get; set; } 
        public MachineCostDetail Screen { get; set; }
        public MachineCostDetailCollectionView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class MachineCostDetailEntityView : View
    {
        public MachineCostDetailEntityView(MachineCostDetail screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            SaveButton = RPSControlFactory.RPSSaveButton<MachineCostDetailEntityView>( this);
 
            DeleteButton = RPSControlFactory.RPSDeleteButton<MachineCostDetailEntityView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<MachineCostDetailEntityView,MachineCostDetailCollectionView>( this,Screen.MachineCostDetailCollectionView);
 
            BackButton = RPSControlFactory.RPSBackButton<MachineCostDetailEntityView,MachineCostDetailCollectionView>( this,Screen.MachineCostDetailCollectionView);
 
            IDCostDetailType = RPSControlFactory.CreateRPSComboBox<MachineCostDetailEntityView>("8cabdfaa-903d-4626-b6b2-7c5e56320ca5","","",false, this);
 
            CostPrice = RPSControlFactory.CreateRPSFormattedTextBox<MachineCostDetailEntityView>("cff443d4-e1f0-486b-ba73-8595aa7fcb57","","",false, this);
 

        }
        public IRPSSaveButton<MachineCostDetailEntityView> SaveButton { get; set; } 
        public IRPSButton<MachineCostDetailEntityView> DeleteButton { get; set; } 
        public IRPSButton<MachineCostDetailEntityView,MachineCostDetailCollectionView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<MachineCostDetailEntityView,MachineCostDetailCollectionView> BackButton { get; set; } 
        public IRPSComboBox<MachineCostDetailEntityView> IDCostDetailType { get; set; } 
        public IRPSTextBox<MachineCostDetailEntityView> CostPrice { get; set; } 
        public MachineCostDetail Screen { get; set; }
        public MachineCostDetailEntityView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}