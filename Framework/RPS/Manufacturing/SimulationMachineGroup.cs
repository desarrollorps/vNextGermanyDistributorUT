    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.Manufacturing.SimulationMachineGroup
{
    //RPS VERSION 1.0.0.0
    public partial class SimulationMachineGroup:Screen
    {
        public SimulationMachineGroup():base()
        {
            this.URL = "manufacturing.simulationmachinegroup";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            MachineGroupCostSimVMQueryView  = new MachineGroupCostSimVMQueryView(this); 
            MachineGroupCostSimVMEntityView  = new MachineGroupCostSimVMEntityView(this); 
            MachineGroupCostSimDetailView  = new MachineGroupCostSimDetailView(this); 
            SimulationMachineGroupDialogView  = new SimulationMachineGroupDialogView(this); 
            MachineGroupCostSimVMQueryView.InitializeControls(); 
            MachineGroupCostSimVMEntityView.InitializeControls(); 
            MachineGroupCostSimDetailView.InitializeControls(); 
            SimulationMachineGroupDialogView.InitializeControls(); 
           
        }
      
            public MachineGroupCostSimVMQueryView MachineGroupCostSimVMQueryView {get; set; } 
            public MachineGroupCostSimVMEntityView MachineGroupCostSimVMEntityView {get; set; } 
            public MachineGroupCostSimDetailView MachineGroupCostSimDetailView {get; set; } 
            public SimulationMachineGroupDialogView SimulationMachineGroupDialogView {get; set; } 
    }
            
    public partial class MachineGroupCostSimVMQueryView : View
    {
        public MachineGroupCostSimVMQueryView(SimulationMachineGroup screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            NewButton = RPSControlFactory.RPSNewButton<MachineGroupCostSimVMQueryView,MachineGroupCostSimVMEntityView>( this,Screen.MachineGroupCostSimVMEntityView);
 
            ConsultButton = RPSControlFactory.RPSConsultButton<MachineGroupCostSimVMQueryView>( this);
 
            Site = RPSControlFactory.CreateRPSComboBox<MachineGroupCostSimVMQueryView>("2bc2a4ec-72d6-48c2-87e3-aae325a6079d","","",false, this);
 
            DeleteCommandButton = RPSControlFactory.CreateRPSButton<MachineGroupCostSimVMQueryView>( "9426839c-f544-4f6d-b09e-02c45a75adb2","","",this);
 
            SimulationMachineGroupNavigationCommandButton = RPSControlFactory.CreateRPSButtonToView<MachineGroupCostSimVMQueryView,SimulationMachineGroupDialogView>("eb9c0f52-f84e-472b-9bcb-a25307d5f3a0","","", this,Screen.SimulationMachineGroupDialogView);
 
            CollectionInit params_MachineGroupCostSim = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="a2f53bbe-a27a-4888-9937-0762e9098439",CSSSelectorGrid="",XPathGrid=""};
            MachineGroupCostSim = RPSControlFactory.RPSCreateCollectionWithGrid<MachineGroupCostSimCollectionEditor<MachineGroupCostSimVMQueryView,MachineGroupCostSimVMEntityView>,MachineGroupCostSimVMQueryView,MachineGroupCostSimVMEntityView>( params_MachineGroupCostSim,this,Screen.MachineGroupCostSimVMEntityView);
 

        }
        public IRPSButton<MachineGroupCostSimVMQueryView,MachineGroupCostSimVMEntityView> NewButton { get; set; } 
        public IRPSButton<MachineGroupCostSimVMQueryView> ConsultButton { get; set; } 
        public IRPSComboBox<MachineGroupCostSimVMQueryView> Site { get; set; } 
        public IRPSButton<MachineGroupCostSimVMQueryView> DeleteCommandButton { get; set; } 
        public IRPSButton<MachineGroupCostSimVMQueryView,SimulationMachineGroupDialogView> SimulationMachineGroupNavigationCommandButton { get; set; } 
        public MachineGroupCostSimCollectionEditor<MachineGroupCostSimVMQueryView,MachineGroupCostSimVMEntityView> MachineGroupCostSim { get; set; } 
        public SimulationMachineGroup Screen { get; set; }
        public MachineGroupCostSimVMQueryView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class MachineGroupCostSimCollectionEditor<MachineGroupCostSimVMQueryView,MachineGroupCostSimVMEntityView>:RPSCollectionEditor<MachineGroupCostSimVMQueryView,MachineGroupCostSimVMEntityView> where MachineGroupCostSimVMQueryView : class, IView where MachineGroupCostSimVMEntityView : class, IView
    {
        public  MachineGroupCostSimGridView<MachineGroupCostSimVMQueryView,MachineGroupCostSimVMEntityView> GridView {get;set;}
    }
    public partial class MachineGroupCostSimGridView <MachineGroupCostSimVMQueryView,MachineGroupCostSimVMEntityView> :  RPSGridView<MachineGroupCostSimVMQueryView,MachineGroupCostSimVMEntityView> where MachineGroupCostSimVMQueryView : class, IView where MachineGroupCostSimVMEntityView : class, IView
    {
        public MachineGroupCostSimGridView(MachineGroupCostSimVMQueryView currentView,MachineGroupCostSimVMEntityView newView)
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
  
            
    public partial class MachineGroupCostSimVMEntityView : View
    {
        public MachineGroupCostSimVMEntityView(SimulationMachineGroup screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            SaveButton = RPSControlFactory.RPSSaveButton<MachineGroupCostSimVMEntityView>( this);
 
            DeleteButton = RPSControlFactory.RPSDeleteButton<MachineGroupCostSimVMEntityView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<MachineGroupCostSimVMEntityView,MachineGroupCostSimVMQueryView>( this,Screen.MachineGroupCostSimVMQueryView);
 
            BackButton = RPSControlFactory.RPSBackButton<MachineGroupCostSimVMEntityView,MachineGroupCostSimVMQueryView>( this,Screen.MachineGroupCostSimVMQueryView);
 
            IDSite = RPSControlFactory.CreateRPSComboBox<MachineGroupCostSimVMEntityView>("dd3ada63-b7fa-44ec-a98d-79fdcd575cea","","",true, this);
 
            IDMachineGroup = RPSControlFactory.CreateRPSComboBox<MachineGroupCostSimVMEntityView>("74de5338-9a81-4242-8c3d-6ebd8f1effde","","",true, this);
 
            CollectionInit params_MachineGroupCostSimDetails = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="31868521-cb34-4386-8999-c5cd485db244",CSSSelectorGrid="",XPathGrid=""};
            MachineGroupCostSimDetails = RPSControlFactory.RPSCreateCollectionWithGrid<MachineGroupCostSimDetailsCollectionEditor<MachineGroupCostSimVMEntityView,MachineGroupCostSimDetailView>,MachineGroupCostSimVMEntityView,MachineGroupCostSimDetailView>( params_MachineGroupCostSimDetails,this,Screen.MachineGroupCostSimDetailView);
 

        }
        public IRPSSaveButton<MachineGroupCostSimVMEntityView> SaveButton { get; set; } 
        public IRPSButton<MachineGroupCostSimVMEntityView> DeleteButton { get; set; } 
        public IRPSButton<MachineGroupCostSimVMEntityView,MachineGroupCostSimVMQueryView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<MachineGroupCostSimVMEntityView,MachineGroupCostSimVMQueryView> BackButton { get; set; } 
        public IRPSComboBox<MachineGroupCostSimVMEntityView> IDSite { get; set; } 
        public IRPSComboBox<MachineGroupCostSimVMEntityView> IDMachineGroup { get; set; } 
        public MachineGroupCostSimDetailsCollectionEditor<MachineGroupCostSimVMEntityView,MachineGroupCostSimDetailView> MachineGroupCostSimDetails { get; set; } 
        public SimulationMachineGroup Screen { get; set; }
        public MachineGroupCostSimVMEntityView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class MachineGroupCostSimDetailsCollectionEditor<MachineGroupCostSimVMEntityView,MachineGroupCostSimDetailView>:RPSCollectionEditor<MachineGroupCostSimVMEntityView,MachineGroupCostSimDetailView> where MachineGroupCostSimVMEntityView : class, IView where MachineGroupCostSimDetailView : class, IView
    {
        public  MachineGroupCostSimDetailsGridView<MachineGroupCostSimVMEntityView,MachineGroupCostSimDetailView> GridView {get;set;}
    }
    public partial class MachineGroupCostSimDetailsGridView <MachineGroupCostSimVMEntityView,MachineGroupCostSimDetailView> :  RPSGridView<MachineGroupCostSimVMEntityView,MachineGroupCostSimDetailView> where MachineGroupCostSimVMEntityView : class, IView where MachineGroupCostSimDetailView : class, IView
    {
        public MachineGroupCostSimDetailsGridView(MachineGroupCostSimVMEntityView currentView,MachineGroupCostSimDetailView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            IDCostDetailType = RPSControlFactory.CreateRPSGridComboBox<MachineGroupCostSimVMEntityView>("","#31868521-cb34-4386-8999-c5cd485db244 .ag-row[role='row']@ROWINDEX [col-id='cIDCostDetailType']","",true, this.CurrentView);
 
            CostPrice = RPSControlFactory.CreateRPSGridFormattedTextBox<MachineGroupCostSimVMEntityView>("","#31868521-cb34-4386-8999-c5cd485db244 .ag-row[role='row']@ROWINDEX [col-id='cCostPrice']","",true, this.CurrentView);
 

        }
        public IRPSGridComboBox<MachineGroupCostSimVMEntityView> IDCostDetailType { get; set; } 
        public IRPSGridTextBox<MachineGroupCostSimVMEntityView> CostPrice { get; set; } 
                     
    }
 
    }
  
            
    public partial class MachineGroupCostSimDetailView : View
    {
        public MachineGroupCostSimDetailView(SimulationMachineGroup screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            DeleteButton = RPSControlFactory.RPSDeleteButton<MachineGroupCostSimDetailView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<MachineGroupCostSimDetailView,MachineGroupCostSimVMEntityView>( this,Screen.MachineGroupCostSimVMEntityView);
 
            BackButton = RPSControlFactory.RPSBackButton<MachineGroupCostSimDetailView,MachineGroupCostSimVMEntityView>( this,Screen.MachineGroupCostSimVMEntityView);
 
            AcceptButton = RPSControlFactory.RPSAcceptButton<MachineGroupCostSimDetailView,MachineGroupCostSimVMEntityView>( this,Screen.MachineGroupCostSimVMEntityView);
 
            IDCostDetailType = RPSControlFactory.CreateRPSComboBox<MachineGroupCostSimDetailView>("bda162ac-a48e-4826-baf5-2e6cd12ec7db","","",true, this);
 
            CostPrice = RPSControlFactory.CreateRPSFormattedTextBox<MachineGroupCostSimDetailView>("e738e0ab-e067-489e-aa92-db410d67acb6","","",true, this);
 

        }
        public IRPSButton<MachineGroupCostSimDetailView> DeleteButton { get; set; } 
        public IRPSButton<MachineGroupCostSimDetailView,MachineGroupCostSimVMEntityView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<MachineGroupCostSimDetailView,MachineGroupCostSimVMEntityView> BackButton { get; set; } 
        public IRPSAcceptButton<MachineGroupCostSimDetailView,MachineGroupCostSimVMEntityView> AcceptButton { get; set; } 
        public IRPSComboBox<MachineGroupCostSimDetailView> IDCostDetailType { get; set; } 
        public IRPSTextBox<MachineGroupCostSimDetailView> CostPrice { get; set; } 
        public SimulationMachineGroup Screen { get; set; }
        public MachineGroupCostSimDetailView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class SimulationMachineGroupDialogView : View
    {
        public SimulationMachineGroupDialogView(SimulationMachineGroup screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            MachineGroup = RPSControlFactory.CreateRPSCollectionComboBox<SimulationMachineGroupDialogView>("8b6e4556-4480-48ef-aae2-d2e98d0a25f6","","",false, this);
 
            HourType = RPSControlFactory.CreateRPSComboBox<SimulationMachineGroupDialogView>("9a84e5b3-c0e0-4921-9d16-45dbf47c0c86","","",false, this);
 
            CostDetailType = RPSControlFactory.CreateRPSCollectionComboBox<SimulationMachineGroupDialogView>("20593235-98c1-4cc9-afc1-5d45a87ad965","","",false, this);
 
            Percentage = RPSControlFactory.CreateRPSFormattedTextBox<SimulationMachineGroupDialogView>("862d8cf5-7ad0-457e-b64a-3c3f76ba58e3","","",false, this);
 

        }
        public IRPSCollectionComboBox<SimulationMachineGroupDialogView> MachineGroup { get; set; } 
        public IRPSComboBox<SimulationMachineGroupDialogView> HourType { get; set; } 
        public IRPSCollectionComboBox<SimulationMachineGroupDialogView> CostDetailType { get; set; } 
        public IRPSTextBox<SimulationMachineGroupDialogView> Percentage { get; set; } 
        public SimulationMachineGroup Screen { get; set; }
        public SimulationMachineGroupDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}