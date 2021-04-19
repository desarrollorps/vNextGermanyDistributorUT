    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.Project.MachineGroup
{
    //RPS VERSION 1.0.0.0
    public partial class MachineGroup:Screen
    {
        public MachineGroup():base()
        {
            this.URL = "project.machinegroup";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            MachineGroupCollectionView  = new MachineGroupCollectionView(this); 
            MachineGroupEntityView  = new MachineGroupEntityView(this); 
            MachineGroupElementView  = new MachineGroupElementView(this); 
            MachineGroupCollectionView.InitializeControls(); 
            MachineGroupEntityView.InitializeControls(); 
            MachineGroupElementView.InitializeControls(); 
           
        }
      
            public MachineGroupCollectionView MachineGroupCollectionView {get; set; } 
            public MachineGroupEntityView MachineGroupEntityView {get; set; } 
            public MachineGroupElementView MachineGroupElementView {get; set; } 
    }
            
    public partial class MachineGroupCollectionView : View
    {
        public MachineGroupCollectionView(MachineGroup screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            NewButton = RPSControlFactory.RPSNewButton<MachineGroupCollectionView,MachineGroupEntityView>( this,Screen.MachineGroupEntityView);
 
            CollectionInit params_MainConsult = new CollectionInit(){IDDescriptor = "b3d26323-6bb5-4a1e-89bb-841d0d909ef4",CSSSelectorDescriptor = "",XPathDescriptor = ""};
            MainConsult = RPSControlFactory.RPSCreateCollection<MachineGroupCollectionView,MachineGroupEntityView>( params_MainConsult,this,Screen.MachineGroupEntityView);
 

        }
        public IRPSButton<MachineGroupCollectionView,MachineGroupEntityView> NewButton { get; set; } 
        public IRPSCollectionEditor<MachineGroupCollectionView,MachineGroupEntityView> MainConsult { get; set; } 
        public MachineGroup Screen { get; set; }
        public MachineGroupCollectionView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class MachineGroupEntityView : View
    {
        public MachineGroupEntityView(MachineGroup screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            SaveButton = RPSControlFactory.RPSSaveButton<MachineGroupEntityView>( this);
 
            DeleteButton = RPSControlFactory.RPSDeleteButton<MachineGroupEntityView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<MachineGroupEntityView,MachineGroupCollectionView>( this,Screen.MachineGroupCollectionView);
 
            BackButton = RPSControlFactory.RPSBackButton<MachineGroupEntityView,MachineGroupCollectionView>( this,Screen.MachineGroupCollectionView);
 
            CodMachineGroup = RPSControlFactory.CreateRPSTextBox<MachineGroupEntityView>("53865369-d1c3-4e15-bf17-dba028a6e4f2","","",true, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<MachineGroupEntityView>("41f27b38-9b3a-4ca4-a2e6-ce33ae278b7a","","",false, this);
 
            BottleNeck = RPSControlFactory.CreateRPSCheckBox<MachineGroupEntityView>("b9aadd01-3eb8-4544-9b37-39ff0156bdb7","","",true, this);
 
            IDCalendar = RPSControlFactory.CreateRPSComboBox<MachineGroupEntityView>("917adc46-1611-4201-ad48-3e309296fb94","","",false, this);
 
            IDSite = RPSControlFactory.CreateRPSComboBox<MachineGroupEntityView>("54d56578-6023-44e8-9e56-b439f3796df4","","",false, this);
 
            KeepResource = RPSControlFactory.CreateRPSCheckBox<MachineGroupEntityView>("b11d3de2-00fa-4e05-aaee-a2c2443c410d","","",true, this);
 
            CollectionInit params_MachineGroupElements = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="bf24eaf4-3800-4d7c-a10f-b043d6d9e760",CSSSelectorGrid="",XPathGrid=""};
            MachineGroupElements = RPSControlFactory.RPSCreateCollectionWithGrid<MachineGroupElementsCollectionEditor<MachineGroupEntityView,MachineGroupElementView>,MachineGroupEntityView,MachineGroupElementView>( params_MachineGroupElements,this,Screen.MachineGroupElementView);
 

        }
        public IRPSSaveButton<MachineGroupEntityView> SaveButton { get; set; } 
        public IRPSButton<MachineGroupEntityView> DeleteButton { get; set; } 
        public IRPSButton<MachineGroupEntityView,MachineGroupCollectionView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<MachineGroupEntityView,MachineGroupCollectionView> BackButton { get; set; } 
        public IRPSTextBox<MachineGroupEntityView> CodMachineGroup { get; set; } 
        public IRPSTextBox<MachineGroupEntityView> Description { get; set; } 
        public IRPSCheckbox<MachineGroupEntityView> BottleNeck { get; set; } 
        public IRPSComboBox<MachineGroupEntityView> IDCalendar { get; set; } 
        public IRPSComboBox<MachineGroupEntityView> IDSite { get; set; } 
        public IRPSCheckbox<MachineGroupEntityView> KeepResource { get; set; } 
        public MachineGroupElementsCollectionEditor<MachineGroupEntityView,MachineGroupElementView> MachineGroupElements { get; set; } 
        public MachineGroup Screen { get; set; }
        public MachineGroupEntityView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class MachineGroupElementsCollectionEditor<MachineGroupEntityView,MachineGroupElementView>:RPSCollectionEditor<MachineGroupEntityView,MachineGroupElementView> where MachineGroupEntityView : class, IView where MachineGroupElementView : class, IView
    {
        public  MachineGroupElementsGridView<MachineGroupEntityView,MachineGroupElementView> GridView {get;set;}
    }
    public partial class MachineGroupElementsGridView <MachineGroupEntityView,MachineGroupElementView> :  RPSGridView<MachineGroupEntityView,MachineGroupElementView> where MachineGroupEntityView : class, IView where MachineGroupElementView : class, IView
    {
        public MachineGroupElementsGridView(MachineGroupEntityView currentView,MachineGroupElementView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            IDMachine = RPSControlFactory.CreateRPSGridComboBox<MachineGroupEntityView>("","#bf24eaf4-3800-4d7c-a10f-b043d6d9e760 .ag-row[role='row']@ROWINDEX [col-id='cIDMachine']","",true, this.CurrentView);
 
            Priority = RPSControlFactory.CreateRPSGridFormattedTextBox<MachineGroupEntityView>("","#bf24eaf4-3800-4d7c-a10f-b043d6d9e760 .ag-row[role='row']@ROWINDEX [col-id='cPriority']","",true, this.CurrentView);
 
            Alternative = RPSControlFactory.CreateRPSGridCheckBox<MachineGroupEntityView>("","#bf24eaf4-3800-4d7c-a10f-b043d6d9e760 .ag-row[role='row']@ROWINDEX [col-id='cAlternative']","",true, this.CurrentView);
 

        }
        public IRPSGridComboBox<MachineGroupEntityView> IDMachine { get; set; } 
        public IRPSGridTextBox<MachineGroupEntityView> Priority { get; set; } 
        public IRPSGridCheckbox<MachineGroupEntityView> Alternative { get; set; } 
                     
    }
 
    }
  
            
    public partial class MachineGroupElementView : View
    {
        public MachineGroupElementView(MachineGroup screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            DeleteButton = RPSControlFactory.RPSDeleteButton<MachineGroupElementView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<MachineGroupElementView,MachineGroupEntityView>( this,Screen.MachineGroupEntityView);
 
            BackButton = RPSControlFactory.RPSBackButton<MachineGroupElementView,MachineGroupEntityView>( this,Screen.MachineGroupEntityView);
 
            AcceptButton = RPSControlFactory.RPSAcceptButton<MachineGroupElementView,MachineGroupEntityView>( this,Screen.MachineGroupEntityView);
 
            IDMachine = RPSControlFactory.CreateRPSComboBox<MachineGroupElementView>("350cc817-a76e-4b11-893a-8ed2d286b62b","","",true, this);
 
            Priority = RPSControlFactory.CreateRPSFormattedTextBox<MachineGroupElementView>("46ee477d-9616-491d-a558-4fc19ccdb4e2","","",true, this);
 
            Alternative = RPSControlFactory.CreateRPSCheckBox<MachineGroupElementView>("2c443f66-d78b-4602-8651-3bf6527dab86","","",true, this);
 

        }
        public IRPSButton<MachineGroupElementView> DeleteButton { get; set; } 
        public IRPSButton<MachineGroupElementView,MachineGroupEntityView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<MachineGroupElementView,MachineGroupEntityView> BackButton { get; set; } 
        public IRPSAcceptButton<MachineGroupElementView,MachineGroupEntityView> AcceptButton { get; set; } 
        public IRPSComboBox<MachineGroupElementView> IDMachine { get; set; } 
        public IRPSTextBox<MachineGroupElementView> Priority { get; set; } 
        public IRPSCheckbox<MachineGroupElementView> Alternative { get; set; } 
        public MachineGroup Screen { get; set; }
        public MachineGroupElementView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}