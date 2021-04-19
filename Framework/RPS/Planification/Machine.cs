    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.Planification.Machine
{
    //RPS VERSION 1.0.0.0
    public partial class Machine:Screen
    {
        public Machine():base()
        {
            this.URL = "planification.machine";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            MachineCollectionView  = new MachineCollectionView(this); 
            MachineEntityView  = new MachineEntityView(this); 
            MachineCollectionView.InitializeControls(); 
            MachineEntityView.InitializeControls(); 
           
        }
      
            public MachineCollectionView MachineCollectionView {get; set; } 
            public MachineEntityView MachineEntityView {get; set; } 
    }
            
    public partial class MachineCollectionView : View
    {
        public MachineCollectionView(Machine screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            NewButton = RPSControlFactory.RPSNewButton<MachineCollectionView,MachineEntityView>( this,Screen.MachineEntityView);
 
            CollectionInit params_MainConsult = new CollectionInit(){IDDescriptor = "0fbc9103-e68c-4dc4-8406-bc76d53116a7",CSSSelectorDescriptor = "",XPathDescriptor = ""};
            MainConsult = RPSControlFactory.RPSCreateCollection<MachineCollectionView,MachineEntityView>( params_MainConsult,this,Screen.MachineEntityView);
 

        }
        public IRPSButton<MachineCollectionView,MachineEntityView> NewButton { get; set; } 
        public IRPSCollectionEditor<MachineCollectionView,MachineEntityView> MainConsult { get; set; } 
        public Machine Screen { get; set; }
        public MachineCollectionView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class MachineEntityView : View
    {
        public MachineEntityView(Machine screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            SaveButton = RPSControlFactory.RPSSaveButton<MachineEntityView>( this);
 
            DeleteButton = RPSControlFactory.RPSDeleteButton<MachineEntityView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<MachineEntityView,MachineCollectionView>( this,Screen.MachineCollectionView);
 
            BackButton = RPSControlFactory.RPSBackButton<MachineEntityView,MachineCollectionView>( this,Screen.MachineCollectionView);
 
            CodMachine = RPSControlFactory.CreateRPSTextBox<MachineEntityView>("0ebe9306-768d-4d85-a862-824b59afd93f","","",true, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<MachineEntityView>("d28f90b8-f87e-42ca-bf61-22339cd61261","","",false, this);
 
            IDCalendar = RPSControlFactory.CreateRPSComboBox<MachineEntityView>("c5d068e8-f68e-457f-a632-16d1b54b6dc1","","",false, this);
 
            IDSite = RPSControlFactory.CreateRPSComboBox<MachineEntityView>("1bb88783-69f3-46b0-b3c3-0432a59518ea","","",false, this);
 
            Fictitious = RPSControlFactory.CreateRPSCheckBox<MachineEntityView>("229d5fc3-8a20-4ece-9ea0-dec50e0b8c43","","",true, this);
 
            BottleNeck = RPSControlFactory.CreateRPSCheckBox<MachineEntityView>("23600df8-b3c5-4f9e-8b78-1805c44fc023","","",false, this);
 
            InactivateDate = RPSControlFactory.CreateRPSTextBox<MachineEntityView>("5b2699e9-2b48-4e16-ad9f-dc1811366ed0","","",false, this);
 
            DisplayOrder = RPSControlFactory.CreateRPSFormattedTextBox<MachineEntityView>("2101558b-b65b-4c21-9a95-911e6474fb8f","","",true, this);
 

        }
        public IRPSSaveButton<MachineEntityView> SaveButton { get; set; } 
        public IRPSButton<MachineEntityView> DeleteButton { get; set; } 
        public IRPSButton<MachineEntityView,MachineCollectionView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<MachineEntityView,MachineCollectionView> BackButton { get; set; } 
        public IRPSTextBox<MachineEntityView> CodMachine { get; set; } 
        public IRPSTextBox<MachineEntityView> Description { get; set; } 
        public IRPSComboBox<MachineEntityView> IDCalendar { get; set; } 
        public IRPSComboBox<MachineEntityView> IDSite { get; set; } 
        public IRPSCheckbox<MachineEntityView> Fictitious { get; set; } 
        public IRPSCheckbox<MachineEntityView> BottleNeck { get; set; } 
        public IRPSTextBox<MachineEntityView> InactivateDate { get; set; } 
        public IRPSTextBox<MachineEntityView> DisplayOrder { get; set; } 
        public Machine Screen { get; set; }
        public MachineEntityView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}