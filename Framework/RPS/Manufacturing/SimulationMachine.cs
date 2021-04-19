    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.Manufacturing.SimulationMachine
{
    //RPS VERSION 1.0.0.0
    public partial class SimulationMachine:Screen
    {
        public SimulationMachine():base()
        {
            this.URL = "manufacturing.simulationmachine";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            MachineCostSimVMQueryView  = new MachineCostSimVMQueryView(this); 
            MachineCostSimVMEntityView  = new MachineCostSimVMEntityView(this); 
            MachineCostSimDetailView  = new MachineCostSimDetailView(this); 
            SimulationMachineDialogView  = new SimulationMachineDialogView(this); 
            MachineCostSimVMQueryView.InitializeControls(); 
            MachineCostSimVMEntityView.InitializeControls(); 
            MachineCostSimDetailView.InitializeControls(); 
            SimulationMachineDialogView.InitializeControls(); 
           
        }
      
            public MachineCostSimVMQueryView MachineCostSimVMQueryView {get; set; } 
            public MachineCostSimVMEntityView MachineCostSimVMEntityView {get; set; } 
            public MachineCostSimDetailView MachineCostSimDetailView {get; set; } 
            public SimulationMachineDialogView SimulationMachineDialogView {get; set; } 
    }
            
    public partial class MachineCostSimVMQueryView : View
    {
        public MachineCostSimVMQueryView(SimulationMachine screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            NewButton = RPSControlFactory.RPSNewButton<MachineCostSimVMQueryView,MachineCostSimVMEntityView>( this,Screen.MachineCostSimVMEntityView);
 
            ConsultButton = RPSControlFactory.RPSConsultButton<MachineCostSimVMQueryView>( this);
 
            Site = RPSControlFactory.CreateRPSComboBox<MachineCostSimVMQueryView>("5d0481ed-efd1-4a79-a088-9550271fdb1d","","",false, this);
 
            DeleteCommandButton = RPSControlFactory.CreateRPSButton<MachineCostSimVMQueryView>( "f1fb9d64-9087-4162-8d16-46977f04fab8","","",this);
 
            SimulationMachineNavigationCommandButton = RPSControlFactory.CreateRPSButtonToView<MachineCostSimVMQueryView,SimulationMachineDialogView>("f3b5fb61-71c4-42b1-aa6c-f43f0488217e","","", this,Screen.SimulationMachineDialogView);
 
            CollectionInit params_MachineCostSim = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="4761eef1-38c0-4502-a9b6-3b430ef8810b",CSSSelectorGrid="",XPathGrid=""};
            MachineCostSim = RPSControlFactory.RPSCreateCollectionWithGrid<MachineCostSimCollectionEditor<MachineCostSimVMQueryView,MachineCostSimVMEntityView>,MachineCostSimVMQueryView,MachineCostSimVMEntityView>( params_MachineCostSim,this,Screen.MachineCostSimVMEntityView);
 

        }
        public IRPSButton<MachineCostSimVMQueryView,MachineCostSimVMEntityView> NewButton { get; set; } 
        public IRPSButton<MachineCostSimVMQueryView> ConsultButton { get; set; } 
        public IRPSComboBox<MachineCostSimVMQueryView> Site { get; set; } 
        public IRPSButton<MachineCostSimVMQueryView> DeleteCommandButton { get; set; } 
        public IRPSButton<MachineCostSimVMQueryView,SimulationMachineDialogView> SimulationMachineNavigationCommandButton { get; set; } 
        public MachineCostSimCollectionEditor<MachineCostSimVMQueryView,MachineCostSimVMEntityView> MachineCostSim { get; set; } 
        public SimulationMachine Screen { get; set; }
        public MachineCostSimVMQueryView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class MachineCostSimCollectionEditor<MachineCostSimVMQueryView,MachineCostSimVMEntityView>:RPSCollectionEditor<MachineCostSimVMQueryView,MachineCostSimVMEntityView> where MachineCostSimVMQueryView : class, IView where MachineCostSimVMEntityView : class, IView
    {
        public  MachineCostSimGridView<MachineCostSimVMQueryView,MachineCostSimVMEntityView> GridView {get;set;}
    }
    public partial class MachineCostSimGridView <MachineCostSimVMQueryView,MachineCostSimVMEntityView> :  RPSGridView<MachineCostSimVMQueryView,MachineCostSimVMEntityView> where MachineCostSimVMQueryView : class, IView where MachineCostSimVMEntityView : class, IView
    {
        public MachineCostSimGridView(MachineCostSimVMQueryView currentView,MachineCostSimVMEntityView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {

        }
                     
    }
 
    }
  
            
    public partial class MachineCostSimVMEntityView : View
    {
        public MachineCostSimVMEntityView(SimulationMachine screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            SaveButton = RPSControlFactory.RPSSaveButton<MachineCostSimVMEntityView>( this);
 
            DeleteButton = RPSControlFactory.RPSDeleteButton<MachineCostSimVMEntityView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<MachineCostSimVMEntityView,MachineCostSimVMQueryView>( this,Screen.MachineCostSimVMQueryView);
 
            BackButton = RPSControlFactory.RPSBackButton<MachineCostSimVMEntityView,MachineCostSimVMQueryView>( this,Screen.MachineCostSimVMQueryView);
 
            IDSite = RPSControlFactory.CreateRPSComboBox<MachineCostSimVMEntityView>("54c37a9f-ac7b-4efe-b94d-0555cf79073a","","",true, this);
 
            IDMachine = RPSControlFactory.CreateRPSComboBox<MachineCostSimVMEntityView>("d9d1f116-b66a-4f38-839f-1392a9c3a2b7","","",false, this);
 
            CollectionInit params_MachineCostSimDetails = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="ee003621-0854-4cae-9b1f-eef071ea0a49",CSSSelectorGrid="",XPathGrid=""};
            MachineCostSimDetails = RPSControlFactory.RPSCreateCollectionWithGrid<MachineCostSimDetailsCollectionEditor<MachineCostSimVMEntityView,MachineCostSimDetailView>,MachineCostSimVMEntityView,MachineCostSimDetailView>( params_MachineCostSimDetails,this,Screen.MachineCostSimDetailView);
 

        }
        public IRPSSaveButton<MachineCostSimVMEntityView> SaveButton { get; set; } 
        public IRPSButton<MachineCostSimVMEntityView> DeleteButton { get; set; } 
        public IRPSButton<MachineCostSimVMEntityView,MachineCostSimVMQueryView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<MachineCostSimVMEntityView,MachineCostSimVMQueryView> BackButton { get; set; } 
        public IRPSComboBox<MachineCostSimVMEntityView> IDSite { get; set; } 
        public IRPSComboBox<MachineCostSimVMEntityView> IDMachine { get; set; } 
        public MachineCostSimDetailsCollectionEditor<MachineCostSimVMEntityView,MachineCostSimDetailView> MachineCostSimDetails { get; set; } 
        public SimulationMachine Screen { get; set; }
        public MachineCostSimVMEntityView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class MachineCostSimDetailsCollectionEditor<MachineCostSimVMEntityView,MachineCostSimDetailView>:RPSCollectionEditor<MachineCostSimVMEntityView,MachineCostSimDetailView> where MachineCostSimVMEntityView : class, IView where MachineCostSimDetailView : class, IView
    {
        public  MachineCostSimDetailsGridView<MachineCostSimVMEntityView,MachineCostSimDetailView> GridView {get;set;}
    }
    public partial class MachineCostSimDetailsGridView <MachineCostSimVMEntityView,MachineCostSimDetailView> :  RPSGridView<MachineCostSimVMEntityView,MachineCostSimDetailView> where MachineCostSimVMEntityView : class, IView where MachineCostSimDetailView : class, IView
    {
        public MachineCostSimDetailsGridView(MachineCostSimVMEntityView currentView,MachineCostSimDetailView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            IDCostDetailType = RPSControlFactory.CreateRPSGridComboBox<MachineCostSimVMEntityView>("","#ee003621-0854-4cae-9b1f-eef071ea0a49 .ag-row[role='row']@ROWINDEX [col-id='cIDCostDetailType']","",true, this.CurrentView);
 
            CostPrice = RPSControlFactory.CreateRPSGridFormattedTextBox<MachineCostSimVMEntityView>("","#ee003621-0854-4cae-9b1f-eef071ea0a49 .ag-row[role='row']@ROWINDEX [col-id='cCostPrice']","",true, this.CurrentView);
 

        }
        public IRPSGridComboBox<MachineCostSimVMEntityView> IDCostDetailType { get; set; } 
        public IRPSGridTextBox<MachineCostSimVMEntityView> CostPrice { get; set; } 
                     
    }
 
    }
  
            
    public partial class MachineCostSimDetailView : View
    {
        public MachineCostSimDetailView(SimulationMachine screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            DeleteButton = RPSControlFactory.RPSDeleteButton<MachineCostSimDetailView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<MachineCostSimDetailView,MachineCostSimVMEntityView>( this,Screen.MachineCostSimVMEntityView);
 
            BackButton = RPSControlFactory.RPSBackButton<MachineCostSimDetailView,MachineCostSimVMEntityView>( this,Screen.MachineCostSimVMEntityView);
 
            AcceptButton = RPSControlFactory.RPSAcceptButton<MachineCostSimDetailView,MachineCostSimVMEntityView>( this,Screen.MachineCostSimVMEntityView);
 
            IDCostDetailType = RPSControlFactory.CreateRPSComboBox<MachineCostSimDetailView>("f5137e54-a288-4ed4-888a-42efe0fbd2ad","","",true, this);
 
            CostPrice = RPSControlFactory.CreateRPSFormattedTextBox<MachineCostSimDetailView>("8aa566ce-c21d-4103-913f-de3c08188d68","","",true, this);
 

        }
        public IRPSButton<MachineCostSimDetailView> DeleteButton { get; set; } 
        public IRPSButton<MachineCostSimDetailView,MachineCostSimVMEntityView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<MachineCostSimDetailView,MachineCostSimVMEntityView> BackButton { get; set; } 
        public IRPSAcceptButton<MachineCostSimDetailView,MachineCostSimVMEntityView> AcceptButton { get; set; } 
        public IRPSComboBox<MachineCostSimDetailView> IDCostDetailType { get; set; } 
        public IRPSTextBox<MachineCostSimDetailView> CostPrice { get; set; } 
        public SimulationMachine Screen { get; set; }
        public MachineCostSimDetailView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class SimulationMachineDialogView : View
    {
        public SimulationMachineDialogView(SimulationMachine screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            Machine = RPSControlFactory.CreateRPSCollectionComboBox<SimulationMachineDialogView>("84586ed6-7409-4fe5-ab96-d0922515717f","","",false, this);
 
            HourType = RPSControlFactory.CreateRPSComboBox<SimulationMachineDialogView>("406eb193-74c8-41b5-803c-27db5ef567ab","","",false, this);
 
            CostDetailType = RPSControlFactory.CreateRPSCollectionComboBox<SimulationMachineDialogView>("7cd7913d-4539-4220-a369-799be32f62f4","","",false, this);
 
            Percentage = RPSControlFactory.CreateRPSFormattedTextBox<SimulationMachineDialogView>("c1426d5c-3bc8-4a63-865c-bd2a568f6180","","",false, this);
 

        }
        public IRPSCollectionComboBox<SimulationMachineDialogView> Machine { get; set; } 
        public IRPSComboBox<SimulationMachineDialogView> HourType { get; set; } 
        public IRPSCollectionComboBox<SimulationMachineDialogView> CostDetailType { get; set; } 
        public IRPSTextBox<SimulationMachineDialogView> Percentage { get; set; } 
        public SimulationMachine Screen { get; set; }
        public SimulationMachineDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}