    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.Planification.MachineGroup
{
    //RPS VERSION 1.0.0.0
    public partial class MachineGroup:Screen
    {
        public MachineGroup():base()
        {
            this.URL = "planification.machinegroup";
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
 
            CollectionInit params_MainConsult = new CollectionInit(){IDDescriptor = "1b9e4902-90b3-4105-b729-b06299939232",CSSSelectorDescriptor = "",XPathDescriptor = ""};
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
 
            CodMachineGroup = RPSControlFactory.CreateRPSTextBox<MachineGroupEntityView>("2b7d0255-540e-4e40-aa9f-a8b8c4e29370","","",true, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<MachineGroupEntityView>("1b4f0f93-bb65-434f-bd44-1b2e5bb38e16","","",false, this);
 
            BottleNeck = RPSControlFactory.CreateRPSCheckBox<MachineGroupEntityView>("088ce02d-0675-4a02-934e-395870e70283","","",true, this);
 
            Infinite = RPSControlFactory.CreateRPSCheckBox<MachineGroupEntityView>("45eb1c2e-0466-4562-8645-3b3dc731aa18","","",true, this);
 
            IDCalendar = RPSControlFactory.CreateRPSComboBox<MachineGroupEntityView>("38e697e3-a7bc-49d6-940d-11db2aa47ac4","","",false, this);
 
            IDSite = RPSControlFactory.CreateRPSComboBox<MachineGroupEntityView>("a4e787af-5676-4eda-b97b-abeeed1625fd","","",false, this);
 
            KeepResource = RPSControlFactory.CreateRPSCheckBox<MachineGroupEntityView>("ac9aad75-1dbf-438f-80ba-27295062d132","","",true, this);
 
            CollectionInit params_MachineGroupElements = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="d0ef598a-b7b0-40e8-8726-ad69984c9680",CSSSelectorGrid="",XPathGrid=""};
            MachineGroupElements = RPSControlFactory.RPSCreateCollectionWithGrid<MachineGroupElementsCollectionEditor<MachineGroupEntityView,MachineGroupElementView>,MachineGroupEntityView,MachineGroupElementView>( params_MachineGroupElements,this,Screen.MachineGroupElementView);
 

        }
        public IRPSSaveButton<MachineGroupEntityView> SaveButton { get; set; } 
        public IRPSButton<MachineGroupEntityView> DeleteButton { get; set; } 
        public IRPSButton<MachineGroupEntityView,MachineGroupCollectionView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<MachineGroupEntityView,MachineGroupCollectionView> BackButton { get; set; } 
        public IRPSTextBox<MachineGroupEntityView> CodMachineGroup { get; set; } 
        public IRPSTextBox<MachineGroupEntityView> Description { get; set; } 
        public IRPSCheckbox<MachineGroupEntityView> BottleNeck { get; set; } 
        public IRPSCheckbox<MachineGroupEntityView> Infinite { get; set; } 
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
            IDMachine = RPSControlFactory.CreateRPSGridComboBox<MachineGroupEntityView>("","#d0ef598a-b7b0-40e8-8726-ad69984c9680 .ag-row[role='row']@ROWINDEX [col-id='cIDMachine']","",true, this.CurrentView);
 
            Priority = RPSControlFactory.CreateRPSGridFormattedTextBox<MachineGroupEntityView>("","#d0ef598a-b7b0-40e8-8726-ad69984c9680 .ag-row[role='row']@ROWINDEX [col-id='cPriority']","",true, this.CurrentView);
 
            Alternative = RPSControlFactory.CreateRPSGridCheckBox<MachineGroupEntityView>("","#d0ef598a-b7b0-40e8-8726-ad69984c9680 .ag-row[role='row']@ROWINDEX [col-id='cAlternative']","",true, this.CurrentView);
 

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
 
            IDMachine = RPSControlFactory.CreateRPSComboBox<MachineGroupElementView>("3e4dff16-7f87-4b84-a33d-4bb05b847a47","","",true, this);
 
            Priority = RPSControlFactory.CreateRPSFormattedTextBox<MachineGroupElementView>("97a2438d-32ca-4cc2-b5da-39f95769139e","","",true, this);
 
            Alternative = RPSControlFactory.CreateRPSCheckBox<MachineGroupElementView>("f029fc03-2a04-4ce8-8ec6-7d8016aaa5bd","","",true, this);
 

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