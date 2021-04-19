    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.Manufacturing.MachineGroupCostDetail
{
    //RPS VERSION 1.0.0.0
    public partial class MachineGroupCostDetail:Screen
    {
        public MachineGroupCostDetail():base()
        {
            this.URL = "manufacturing.machinegroupcostdetail";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            MachineGroupCostDetailCollectionView  = new MachineGroupCostDetailCollectionView(this); 
            MachineGroupCostDetailEntityView  = new MachineGroupCostDetailEntityView(this); 
            MachineGroupCostDetailCollectionView.InitializeControls(); 
            MachineGroupCostDetailEntityView.InitializeControls(); 
           
        }
      
            public MachineGroupCostDetailCollectionView MachineGroupCostDetailCollectionView {get; set; } 
            public MachineGroupCostDetailEntityView MachineGroupCostDetailEntityView {get; set; } 
    }
            
    public partial class MachineGroupCostDetailCollectionView : View
    {
        public MachineGroupCostDetailCollectionView(MachineGroupCostDetail screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            NewButton = RPSControlFactory.RPSNewButton<MachineGroupCostDetailCollectionView,MachineGroupCostDetailEntityView>( this,Screen.MachineGroupCostDetailEntityView);
 
            CollectionInit params_MainConsult = new CollectionInit(){IDDescriptor = "da879f1b-d3c6-4206-a6f4-7e27604ce6c2",CSSSelectorDescriptor = "",XPathDescriptor = ""};
            MainConsult = RPSControlFactory.RPSCreateCollection<MachineGroupCostDetailCollectionView,MachineGroupCostDetailEntityView>( params_MainConsult,this,Screen.MachineGroupCostDetailEntityView);
 

        }
        public IRPSButton<MachineGroupCostDetailCollectionView,MachineGroupCostDetailEntityView> NewButton { get; set; } 
        public IRPSCollectionEditor<MachineGroupCostDetailCollectionView,MachineGroupCostDetailEntityView> MainConsult { get; set; } 
        public MachineGroupCostDetail Screen { get; set; }
        public MachineGroupCostDetailCollectionView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class MachineGroupCostDetailEntityView : View
    {
        public MachineGroupCostDetailEntityView(MachineGroupCostDetail screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            SaveButton = RPSControlFactory.RPSSaveButton<MachineGroupCostDetailEntityView>( this);
 
            DeleteButton = RPSControlFactory.RPSDeleteButton<MachineGroupCostDetailEntityView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<MachineGroupCostDetailEntityView,MachineGroupCostDetailCollectionView>( this,Screen.MachineGroupCostDetailCollectionView);
 
            BackButton = RPSControlFactory.RPSBackButton<MachineGroupCostDetailEntityView,MachineGroupCostDetailCollectionView>( this,Screen.MachineGroupCostDetailCollectionView);
 
            IDCostDetailType = RPSControlFactory.CreateRPSComboBox<MachineGroupCostDetailEntityView>("f4c1b49d-547c-42c9-9efa-f156fa87784d","","",true, this);
 
            CostPrice = RPSControlFactory.CreateRPSFormattedTextBox<MachineGroupCostDetailEntityView>("deab3654-0b45-400c-b16f-0675e75920d8","","",true, this);
 

        }
        public IRPSSaveButton<MachineGroupCostDetailEntityView> SaveButton { get; set; } 
        public IRPSButton<MachineGroupCostDetailEntityView> DeleteButton { get; set; } 
        public IRPSButton<MachineGroupCostDetailEntityView,MachineGroupCostDetailCollectionView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<MachineGroupCostDetailEntityView,MachineGroupCostDetailCollectionView> BackButton { get; set; } 
        public IRPSComboBox<MachineGroupCostDetailEntityView> IDCostDetailType { get; set; } 
        public IRPSTextBox<MachineGroupCostDetailEntityView> CostPrice { get; set; } 
        public MachineGroupCostDetail Screen { get; set; }
        public MachineGroupCostDetailEntityView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}