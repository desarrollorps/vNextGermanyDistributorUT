    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.Project.Machine
{
    //RPS VERSION 1.0.0.0
    public partial class Machine:Screen
    {
        public Machine():base()
        {
            this.URL = "project.machine";
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
 
            CollectionInit params_MainConsult = new CollectionInit(){IDDescriptor = "32949489-0e4f-4516-8896-8c23abf99714",CSSSelectorDescriptor = "",XPathDescriptor = ""};
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
 
            CodMachine = RPSControlFactory.CreateRPSTextBox<MachineEntityView>("bbfe98eb-46b9-4aa5-8052-d5d893eeb764","","",true, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<MachineEntityView>("608b4d2f-d007-4d9e-8cbe-2afdee4ec5da","","",false, this);
 
            InactivateDate = RPSControlFactory.CreateRPSTextBox<MachineEntityView>("3993f12b-c55b-41cf-b4a5-f6797af82112","","",false, this);
 
            IDCalendar = RPSControlFactory.CreateRPSComboBox<MachineEntityView>("c69fe949-9e80-4514-b5ca-14fd4aedaa00","","",false, this);
 
            IDSite = RPSControlFactory.CreateRPSComboBox<MachineEntityView>("89e3faf3-720b-407e-ad58-8e6bb80ba803","","",false, this);
 
            CostType = RPSControlFactory.CreateRPSEnumComboBox<MachineEntityView>("d7bc8e50-e6dd-49a7-a2c0-e68792f4e714","","",true, this);
 
            IDMeasureUnit = RPSControlFactory.CreateRPSComboBox<MachineEntityView>("6d1ee825-cf34-4977-9e17-2b0a74867f24","","",false, this);
 
            Fictitious = RPSControlFactory.CreateRPSCheckBox<MachineEntityView>("f91e4b2c-2121-4db5-adb6-932ed4242330","","",true, this);
 
            BottleNeck = RPSControlFactory.CreateRPSCheckBox<MachineEntityView>("75a307bf-03d7-4990-941e-519b02fa0e50","","",true, this);
 
            ImputationOnLineUnique = RPSControlFactory.CreateRPSCheckBox<MachineEntityView>("2c94d5fc-4b5b-4ee3-bb77-48e11206b092","","",true, this);
 
            DisplayOrder = RPSControlFactory.CreateRPSFormattedTextBox<MachineEntityView>("468fa1a2-1ada-49b8-97a0-5fbc7f6b5294","","",true, this);
 

        }
        public IRPSSaveButton<MachineEntityView> SaveButton { get; set; } 
        public IRPSButton<MachineEntityView> DeleteButton { get; set; } 
        public IRPSButton<MachineEntityView,MachineCollectionView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<MachineEntityView,MachineCollectionView> BackButton { get; set; } 
        public IRPSTextBox<MachineEntityView> CodMachine { get; set; } 
        public IRPSTextBox<MachineEntityView> Description { get; set; } 
        public IRPSTextBox<MachineEntityView> InactivateDate { get; set; } 
        public IRPSComboBox<MachineEntityView> IDCalendar { get; set; } 
        public IRPSComboBox<MachineEntityView> IDSite { get; set; } 
        public IRPSComboBox<MachineEntityView> CostType { get; set; } 
        public IRPSComboBox<MachineEntityView> IDMeasureUnit { get; set; } 
        public IRPSCheckbox<MachineEntityView> Fictitious { get; set; } 
        public IRPSCheckbox<MachineEntityView> BottleNeck { get; set; } 
        public IRPSCheckbox<MachineEntityView> ImputationOnLineUnique { get; set; } 
        public IRPSTextBox<MachineEntityView> DisplayOrder { get; set; } 
        public Machine Screen { get; set; }
        public MachineEntityView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}