    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.Manufacturing.SimulationTool
{
    //RPS VERSION 1.0.0.0
    public partial class SimulationTool:Screen
    {
        public SimulationTool():base()
        {
            this.URL = "manufacturing.simulationtool";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            ToolCostSimVMQueryView  = new ToolCostSimVMQueryView(this); 
            ToolCostSimVMEntityView  = new ToolCostSimVMEntityView(this); 
            SimulationToolDialogView  = new SimulationToolDialogView(this); 
            ToolCostSimVMQueryView.InitializeControls(); 
            ToolCostSimVMEntityView.InitializeControls(); 
            SimulationToolDialogView.InitializeControls(); 
           
        }
      
            public ToolCostSimVMQueryView ToolCostSimVMQueryView {get; set; } 
            public ToolCostSimVMEntityView ToolCostSimVMEntityView {get; set; } 
            public SimulationToolDialogView SimulationToolDialogView {get; set; } 
    }
            
    public partial class ToolCostSimVMQueryView : View
    {
        public ToolCostSimVMQueryView(SimulationTool screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            NewButton = RPSControlFactory.RPSNewButton<ToolCostSimVMQueryView,ToolCostSimVMEntityView>( this,Screen.ToolCostSimVMEntityView);
 
            ConsultButton = RPSControlFactory.RPSConsultButton<ToolCostSimVMQueryView>( this);
 
            Site = RPSControlFactory.CreateRPSComboBox<ToolCostSimVMQueryView>("7df62e5a-3938-4bba-bdd9-ed53440515e6","","",false, this);
 
            DeleteCommandButton = RPSControlFactory.CreateRPSButton<ToolCostSimVMQueryView>( "6d33d5cd-debd-4ab7-a680-734cc7fdd51e","","",this);
 
            SimulationToolNavigationCommandButton = RPSControlFactory.CreateRPSButtonToView<ToolCostSimVMQueryView,SimulationToolDialogView>("d90faab0-9a46-46ae-a017-4f9b311d1cde","","", this,Screen.SimulationToolDialogView);
 
            CollectionInit params_ToolCostSim = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="7b70fac4-55af-4b0a-af60-f06003bbc2ee",CSSSelectorGrid="",XPathGrid=""};
            ToolCostSim = RPSControlFactory.RPSCreateCollectionWithGrid<ToolCostSimCollectionEditor<ToolCostSimVMQueryView,ToolCostSimVMEntityView>,ToolCostSimVMQueryView,ToolCostSimVMEntityView>( params_ToolCostSim,this,Screen.ToolCostSimVMEntityView);
 

        }
        public IRPSButton<ToolCostSimVMQueryView,ToolCostSimVMEntityView> NewButton { get; set; } 
        public IRPSButton<ToolCostSimVMQueryView> ConsultButton { get; set; } 
        public IRPSComboBox<ToolCostSimVMQueryView> Site { get; set; } 
        public IRPSButton<ToolCostSimVMQueryView> DeleteCommandButton { get; set; } 
        public IRPSButton<ToolCostSimVMQueryView,SimulationToolDialogView> SimulationToolNavigationCommandButton { get; set; } 
        public ToolCostSimCollectionEditor<ToolCostSimVMQueryView,ToolCostSimVMEntityView> ToolCostSim { get; set; } 
        public SimulationTool Screen { get; set; }
        public ToolCostSimVMQueryView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class ToolCostSimCollectionEditor<ToolCostSimVMQueryView,ToolCostSimVMEntityView>:RPSCollectionEditor<ToolCostSimVMQueryView,ToolCostSimVMEntityView> where ToolCostSimVMQueryView : class, IView where ToolCostSimVMEntityView : class, IView
    {
        public  ToolCostSimGridView<ToolCostSimVMQueryView,ToolCostSimVMEntityView> GridView {get;set;}
    }
    public partial class ToolCostSimGridView <ToolCostSimVMQueryView,ToolCostSimVMEntityView> :  RPSGridView<ToolCostSimVMQueryView,ToolCostSimVMEntityView> where ToolCostSimVMQueryView : class, IView where ToolCostSimVMEntityView : class, IView
    {
        public ToolCostSimGridView(ToolCostSimVMQueryView currentView,ToolCostSimVMEntityView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            ToolCostSim_CostPrice = RPSControlFactory.CreateRPSGridFormattedTextBox<ToolCostSimVMQueryView>("","#7b70fac4-55af-4b0a-af60-f06003bbc2ee .ag-row[role='row']@ROWINDEX [col-id='cToolCostSim_CostPrice']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<ToolCostSimVMQueryView> ToolCostSim_CostPrice { get; set; } 
                     
    }
 
    }
  
            
    public partial class ToolCostSimVMEntityView : View
    {
        public ToolCostSimVMEntityView(SimulationTool screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            SaveButton = RPSControlFactory.RPSSaveButton<ToolCostSimVMEntityView>( this);
 
            DeleteButton = RPSControlFactory.RPSDeleteButton<ToolCostSimVMEntityView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<ToolCostSimVMEntityView,ToolCostSimVMQueryView>( this,Screen.ToolCostSimVMQueryView);
 
            BackButton = RPSControlFactory.RPSBackButton<ToolCostSimVMEntityView,ToolCostSimVMQueryView>( this,Screen.ToolCostSimVMQueryView);
 
            IDSite = RPSControlFactory.CreateRPSComboBox<ToolCostSimVMEntityView>("88befa83-cd9b-44d0-9584-2168745bfbe7","","",true, this);
 
            IDTool = RPSControlFactory.CreateRPSComboBox<ToolCostSimVMEntityView>("db047401-c9df-42e1-b29d-1c38ceb1bcf0","","",false, this);
 
            CostPrice = RPSControlFactory.CreateRPSFormattedTextBox<ToolCostSimVMEntityView>("59d42435-c930-4643-abf7-0c71d58af099","","",false, this);
 

        }
        public IRPSSaveButton<ToolCostSimVMEntityView> SaveButton { get; set; } 
        public IRPSButton<ToolCostSimVMEntityView> DeleteButton { get; set; } 
        public IRPSButton<ToolCostSimVMEntityView,ToolCostSimVMQueryView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<ToolCostSimVMEntityView,ToolCostSimVMQueryView> BackButton { get; set; } 
        public IRPSComboBox<ToolCostSimVMEntityView> IDSite { get; set; } 
        public IRPSComboBox<ToolCostSimVMEntityView> IDTool { get; set; } 
        public IRPSTextBox<ToolCostSimVMEntityView> CostPrice { get; set; } 
        public SimulationTool Screen { get; set; }
        public ToolCostSimVMEntityView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class SimulationToolDialogView : View
    {
        public SimulationToolDialogView(SimulationTool screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            Tool = RPSControlFactory.CreateRPSCollectionComboBox<SimulationToolDialogView>("731cedb9-6379-44f2-b78a-cbb945466619","","",false, this);
 
            HourType = RPSControlFactory.CreateRPSComboBox<SimulationToolDialogView>("1f72e12f-bea3-472f-bab9-4951527b09a9","","",false, this);
 
            CostDetailType = RPSControlFactory.CreateRPSCollectionComboBox<SimulationToolDialogView>("62431c96-c1e2-40f5-9dcc-fb26f3a1e4a7","","",false, this);
 
            Percentage = RPSControlFactory.CreateRPSFormattedTextBox<SimulationToolDialogView>("e3daf733-54e8-4d83-a0ab-dd983656d9c3","","",false, this);
 

        }
        public IRPSCollectionComboBox<SimulationToolDialogView> Tool { get; set; } 
        public IRPSComboBox<SimulationToolDialogView> HourType { get; set; } 
        public IRPSCollectionComboBox<SimulationToolDialogView> CostDetailType { get; set; } 
        public IRPSTextBox<SimulationToolDialogView> Percentage { get; set; } 
        public SimulationTool Screen { get; set; }
        public SimulationToolDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}