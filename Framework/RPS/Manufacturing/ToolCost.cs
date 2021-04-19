    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.Manufacturing.ToolCost
{
    //RPS VERSION 1.0.0.0
    public partial class ToolCost:Screen
    {
        public ToolCost():base()
        {
            this.URL = "manufacturing.toolcost";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            ToolCostCollectionView  = new ToolCostCollectionView(this); 
            ToolCostEntityView  = new ToolCostEntityView(this); 
            ToolCostCollectionView.InitializeControls(); 
            ToolCostEntityView.InitializeControls(); 
           
        }
      
            public ToolCostCollectionView ToolCostCollectionView {get; set; } 
            public ToolCostEntityView ToolCostEntityView {get; set; } 
    }
            
    public partial class ToolCostCollectionView : View
    {
        public ToolCostCollectionView(ToolCost screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            NewButton = RPSControlFactory.RPSNewButton<ToolCostCollectionView,ToolCostEntityView>( this,Screen.ToolCostEntityView);
 
            CollectionInit params_MainConsult = new CollectionInit(){IDDescriptor = "c6c47bbf-081b-4b3b-9267-4f6e56e125ee",CSSSelectorDescriptor = "",XPathDescriptor = ""};
            MainConsult = RPSControlFactory.RPSCreateCollection<ToolCostCollectionView,ToolCostEntityView>( params_MainConsult,this,Screen.ToolCostEntityView);
 

        }
        public IRPSButton<ToolCostCollectionView,ToolCostEntityView> NewButton { get; set; } 
        public IRPSCollectionEditor<ToolCostCollectionView,ToolCostEntityView> MainConsult { get; set; } 
        public ToolCost Screen { get; set; }
        public ToolCostCollectionView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class ToolCostEntityView : View
    {
        public ToolCostEntityView(ToolCost screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            SaveButton = RPSControlFactory.RPSSaveButton<ToolCostEntityView>( this);
 
            DeleteButton = RPSControlFactory.RPSDeleteButton<ToolCostEntityView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<ToolCostEntityView,ToolCostCollectionView>( this,Screen.ToolCostCollectionView);
 
            BackButton = RPSControlFactory.RPSBackButton<ToolCostEntityView,ToolCostCollectionView>( this,Screen.ToolCostCollectionView);
 
            IDTool = RPSControlFactory.CreateRPSComboBox<ToolCostEntityView>("2f796b34-871e-4d1e-99aa-02804c8290ec","","",true, this);
 
            IDHourType = RPSControlFactory.CreateRPSComboBox<ToolCostEntityView>("d85da621-5e70-4d55-b802-a8133560c260","","",true, this);
 
            DateFrom = RPSControlFactory.CreateRPSTextBox<ToolCostEntityView>("06227424-0cf1-4c3a-b1ee-f82cb1777718","","",true, this);
 
            CostPrice = RPSControlFactory.CreateRPSFormattedTextBox<ToolCostEntityView>("3b75e195-e57f-4827-9583-0012f8de4977","","",true, this);
 

        }
        public IRPSSaveButton<ToolCostEntityView> SaveButton { get; set; } 
        public IRPSButton<ToolCostEntityView> DeleteButton { get; set; } 
        public IRPSButton<ToolCostEntityView,ToolCostCollectionView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<ToolCostEntityView,ToolCostCollectionView> BackButton { get; set; } 
        public IRPSComboBox<ToolCostEntityView> IDTool { get; set; } 
        public IRPSComboBox<ToolCostEntityView> IDHourType { get; set; } 
        public IRPSTextBox<ToolCostEntityView> DateFrom { get; set; } 
        public IRPSTextBox<ToolCostEntityView> CostPrice { get; set; } 
        public ToolCost Screen { get; set; }
        public ToolCostEntityView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}