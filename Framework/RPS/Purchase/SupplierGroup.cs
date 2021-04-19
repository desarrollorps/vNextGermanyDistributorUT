    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.Purchase.SupplierGroup
{
    //RPS VERSION 1.0.0.0
    public partial class SupplierGroup:Screen
    {
        public SupplierGroup():base()
        {
            this.URL = "purchase.suppliergroup";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            SupplierGroupCollectionView  = new SupplierGroupCollectionView(this); 
            SupplierGroupEntityView  = new SupplierGroupEntityView(this); 
            SupplierGroupDetailView  = new SupplierGroupDetailView(this); 
            SupplierGroupCollectionView.InitializeControls(); 
            SupplierGroupEntityView.InitializeControls(); 
            SupplierGroupDetailView.InitializeControls(); 
           
        }
      
            public SupplierGroupCollectionView SupplierGroupCollectionView {get; set; } 
            public SupplierGroupEntityView SupplierGroupEntityView {get; set; } 
            public SupplierGroupDetailView SupplierGroupDetailView {get; set; } 
    }
            
    public partial class SupplierGroupCollectionView : View
    {
        public SupplierGroupCollectionView(SupplierGroup screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            NewButton = RPSControlFactory.RPSNewButton<SupplierGroupCollectionView,SupplierGroupEntityView>( this,Screen.SupplierGroupEntityView);
 
            CollectionInit params_MainConsult = new CollectionInit(){IDDescriptor = "8bfaf3ba-9705-46fb-ac8c-9a0098b68c81",CSSSelectorDescriptor = "",XPathDescriptor = ""};
            MainConsult = RPSControlFactory.RPSCreateCollection<SupplierGroupCollectionView,SupplierGroupEntityView>( params_MainConsult,this,Screen.SupplierGroupEntityView);
 

        }
        public IRPSButton<SupplierGroupCollectionView,SupplierGroupEntityView> NewButton { get; set; } 
        public IRPSCollectionEditor<SupplierGroupCollectionView,SupplierGroupEntityView> MainConsult { get; set; } 
        public SupplierGroup Screen { get; set; }
        public SupplierGroupCollectionView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class SupplierGroupEntityView : View
    {
        public SupplierGroupEntityView(SupplierGroup screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            SaveButton = RPSControlFactory.RPSSaveButton<SupplierGroupEntityView>( this);
 
            DeleteButton = RPSControlFactory.RPSDeleteButton<SupplierGroupEntityView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<SupplierGroupEntityView,SupplierGroupCollectionView>( this,Screen.SupplierGroupCollectionView);
 
            BackButton = RPSControlFactory.RPSBackButton<SupplierGroupEntityView,SupplierGroupCollectionView>( this,Screen.SupplierGroupCollectionView);
 
            CodSupplierGroup = RPSControlFactory.CreateRPSTextBox<SupplierGroupEntityView>("f99d82c6-cedc-45e5-b4a6-55b7d222228a","","",true, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<SupplierGroupEntityView>("89d5b82e-3d95-4198-a9de-b406e06dd8ac","","",false, this);
 
            CollectionInit params_SupplierGroupDetails = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="75c919b1-3aac-4a85-96c0-abaf943e5db9",CSSSelectorGrid="",XPathGrid=""};
            SupplierGroupDetails = RPSControlFactory.RPSCreateCollectionWithGrid<SupplierGroupDetailsCollectionEditor<SupplierGroupEntityView,SupplierGroupDetailView>,SupplierGroupEntityView,SupplierGroupDetailView>( params_SupplierGroupDetails,this,Screen.SupplierGroupDetailView);
 

        }
        public IRPSSaveButton<SupplierGroupEntityView> SaveButton { get; set; } 
        public IRPSButton<SupplierGroupEntityView> DeleteButton { get; set; } 
        public IRPSButton<SupplierGroupEntityView,SupplierGroupCollectionView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<SupplierGroupEntityView,SupplierGroupCollectionView> BackButton { get; set; } 
        public IRPSTextBox<SupplierGroupEntityView> CodSupplierGroup { get; set; } 
        public IRPSTextBox<SupplierGroupEntityView> Description { get; set; } 
        public SupplierGroupDetailsCollectionEditor<SupplierGroupEntityView,SupplierGroupDetailView> SupplierGroupDetails { get; set; } 
        public SupplierGroup Screen { get; set; }
        public SupplierGroupEntityView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class SupplierGroupDetailsCollectionEditor<SupplierGroupEntityView,SupplierGroupDetailView>:RPSCollectionEditor<SupplierGroupEntityView,SupplierGroupDetailView> where SupplierGroupEntityView : class, IView where SupplierGroupDetailView : class, IView
    {
        public  SupplierGroupDetailsGridView<SupplierGroupEntityView,SupplierGroupDetailView> GridView {get;set;}
    }
    public partial class SupplierGroupDetailsGridView <SupplierGroupEntityView,SupplierGroupDetailView> :  RPSGridView<SupplierGroupEntityView,SupplierGroupDetailView> where SupplierGroupEntityView : class, IView where SupplierGroupDetailView : class, IView
    {
        public SupplierGroupDetailsGridView(SupplierGroupEntityView currentView,SupplierGroupDetailView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            IDSupplier = RPSControlFactory.CreateRPSGridComboBox<SupplierGroupEntityView>("","#75c919b1-3aac-4a85-96c0-abaf943e5db9 .ag-row[role='row']@ROWINDEX [col-id='cIDSupplier']","",false, this.CurrentView);
 
            Priority = RPSControlFactory.CreateRPSGridFormattedTextBox<SupplierGroupEntityView>("","#75c919b1-3aac-4a85-96c0-abaf943e5db9 .ag-row[role='row']@ROWINDEX [col-id='cPriority']","",true, this.CurrentView);
 

        }
        public IRPSGridComboBox<SupplierGroupEntityView> IDSupplier { get; set; } 
        public IRPSGridTextBox<SupplierGroupEntityView> Priority { get; set; } 
                     
    }
 
    }
  
            
    public partial class SupplierGroupDetailView : View
    {
        public SupplierGroupDetailView(SupplierGroup screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            DeleteButton = RPSControlFactory.RPSDeleteButton<SupplierGroupDetailView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<SupplierGroupDetailView,SupplierGroupEntityView>( this,Screen.SupplierGroupEntityView);
 
            BackButton = RPSControlFactory.RPSBackButton<SupplierGroupDetailView,SupplierGroupEntityView>( this,Screen.SupplierGroupEntityView);
 
            AcceptButton = RPSControlFactory.RPSAcceptButton<SupplierGroupDetailView,SupplierGroupEntityView>( this,Screen.SupplierGroupEntityView);
 
            IDSupplier = RPSControlFactory.CreateRPSComboBox<SupplierGroupDetailView>("a5ac7e6e-f258-4f52-897b-a353c68d9c72","","",false, this);
 
            Priority = RPSControlFactory.CreateRPSFormattedTextBox<SupplierGroupDetailView>("4e9a1ace-d32c-43a3-9a05-a1414d8eb70d","","",true, this);
 

        }
        public IRPSButton<SupplierGroupDetailView> DeleteButton { get; set; } 
        public IRPSButton<SupplierGroupDetailView,SupplierGroupEntityView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<SupplierGroupDetailView,SupplierGroupEntityView> BackButton { get; set; } 
        public IRPSAcceptButton<SupplierGroupDetailView,SupplierGroupEntityView> AcceptButton { get; set; } 
        public IRPSComboBox<SupplierGroupDetailView> IDSupplier { get; set; } 
        public IRPSTextBox<SupplierGroupDetailView> Priority { get; set; } 
        public SupplierGroup Screen { get; set; }
        public SupplierGroupDetailView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}