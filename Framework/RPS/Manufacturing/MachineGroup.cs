    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.Manufacturing.MachineGroup
{
    //RPS VERSION 1.0.0.0
    public partial class MachineGroup:Screen
    {
        public MachineGroup():base()
        {
            this.URL = "manufacturing.machinegroup";
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
 
            CollectionInit params_MainConsult = new CollectionInit(){IDDescriptor = "ae1df6af-6828-41f7-9ca4-11f7745507df",CSSSelectorDescriptor = "",XPathDescriptor = ""};
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
 
            CodMachineGroup = RPSControlFactory.CreateRPSTextBox<MachineGroupEntityView>("b9bf6c6f-7375-4aad-aa80-5891cc6b0c41","","",true, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<MachineGroupEntityView>("f5488892-bda9-4f33-a414-d24dc60a29bc","","",false, this);
 
            BottleNeck = RPSControlFactory.CreateRPSCheckBox<MachineGroupEntityView>("5e213584-d895-445a-a051-ba797837c334","","",true, this);
 
            Infinite = RPSControlFactory.CreateRPSCheckBox<MachineGroupEntityView>("21916fd3-8834-44b7-961b-79ba861e13ce","","",true, this);
 
            IDCalendar = RPSControlFactory.CreateRPSComboBox<MachineGroupEntityView>("b11a3c3f-bef5-4981-b072-b08d2310f0ee","","",false, this);
 
            IDSite = RPSControlFactory.CreateRPSComboBox<MachineGroupEntityView>("69f6cb6d-52b0-43ab-a1d2-cb5802d10bb9","","",false, this);
 
            KeepResource = RPSControlFactory.CreateRPSCheckBox<MachineGroupEntityView>("a8544165-43d2-411a-a715-b7057283fcca","","",true, this);
 
            CollectionInit params_MachineGroupElements = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="373e911f-dda6-4487-af7b-7d7d585d5286",CSSSelectorGrid="",XPathGrid=""};
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
            IDMachine = RPSControlFactory.CreateRPSGridComboBox<MachineGroupEntityView>("","#373e911f-dda6-4487-af7b-7d7d585d5286 .ag-row[role='row']@ROWINDEX [col-id='cIDMachine']","",true, this.CurrentView);
 
            Priority = RPSControlFactory.CreateRPSGridFormattedTextBox<MachineGroupEntityView>("","#373e911f-dda6-4487-af7b-7d7d585d5286 .ag-row[role='row']@ROWINDEX [col-id='cPriority']","",true, this.CurrentView);
 
            Alternative = RPSControlFactory.CreateRPSGridCheckBox<MachineGroupEntityView>("","#373e911f-dda6-4487-af7b-7d7d585d5286 .ag-row[role='row']@ROWINDEX [col-id='cAlternative']","",true, this.CurrentView);
 

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
 
            IDMachine = RPSControlFactory.CreateRPSComboBox<MachineGroupElementView>("2c6e2ef7-5738-4d37-938a-314756bfba7f","","",true, this);
 
            Priority = RPSControlFactory.CreateRPSFormattedTextBox<MachineGroupElementView>("a59d174a-3373-4455-af92-7d6bf2de4d72","","",true, this);
 
            Alternative = RPSControlFactory.CreateRPSCheckBox<MachineGroupElementView>("54d19c91-9e91-4a17-81fa-075f8281a8c8","","",true, this);
 

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