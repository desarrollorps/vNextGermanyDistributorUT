    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.Manufacturing.Machine
{
    //RPS VERSION 1.0.0.0
    public partial class Machine:Screen
    {
        public Machine():base()
        {
            this.URL = "manufacturing.machine";
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
 
            CollectionInit params_MainConsult = new CollectionInit(){IDDescriptor = "88444593-e47e-4f44-820c-4385848d0941",CSSSelectorDescriptor = "",XPathDescriptor = ""};
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
 
            CodMachine = RPSControlFactory.CreateRPSTextBox<MachineEntityView>("0dc91118-3400-4e16-948d-283859042e64","","",true, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<MachineEntityView>("5d1e8791-fbfd-433e-a9f7-21ce6fe04952","","",false, this);
 
            InactivateDate = RPSControlFactory.CreateRPSTextBox<MachineEntityView>("c8b9ddc8-d304-4dde-8105-9199b04e8f6f","","",false, this);
 
            IDCalendar = RPSControlFactory.CreateRPSComboBox<MachineEntityView>("e279818a-d6b3-4c23-9b3b-9275a8b99cbe","","",false, this);
 
            IDSite = RPSControlFactory.CreateRPSComboBox<MachineEntityView>("1749286e-2e46-48a5-9fee-5eeeb7728c3f","","",false, this);
 
            CostType = RPSControlFactory.CreateRPSEnumComboBox<MachineEntityView>("02cda806-b3a2-4ef0-b23a-ff133f60db1c","","",true, this);
 
            IDMeasureUnit = RPSControlFactory.CreateRPSComboBox<MachineEntityView>("c089a31d-d3c2-4ed4-b122-37c0311df762","","",false, this);
 
            Fictitious = RPSControlFactory.CreateRPSCheckBox<MachineEntityView>("133b4077-527e-44fd-9181-acee5c908f65","","",true, this);
 
            BottleNeck = RPSControlFactory.CreateRPSCheckBox<MachineEntityView>("a21400a5-e17c-4e5d-8869-d6a8c94e2982","","",true, this);
 
            DisplayOrder = RPSControlFactory.CreateRPSFormattedTextBox<MachineEntityView>("3f89dcd5-f001-44b7-a2f1-4158892d4cc8","","",true, this);
 
            ImputationOnLineUnique = RPSControlFactory.CreateRPSCheckBox<MachineEntityView>("b97b65e6-ff49-4830-b9d8-3542a3e86249","","",true, this);
 
            AllowMultiImputation = RPSControlFactory.CreateRPSCheckBox<MachineEntityView>("93180cda-9c11-4ed4-93b9-aaedd16ac58b","","",false, this);
 

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
        public IRPSTextBox<MachineEntityView> DisplayOrder { get; set; } 
        public IRPSCheckbox<MachineEntityView> ImputationOnLineUnique { get; set; } 
        public IRPSCheckbox<MachineEntityView> AllowMultiImputation { get; set; } 
        public Machine Screen { get; set; }
        public MachineEntityView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}