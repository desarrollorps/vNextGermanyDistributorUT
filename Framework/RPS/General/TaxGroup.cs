    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.General.TaxGroup
{
    //RPS VERSION 1.0.0.0
    public partial class TaxGroup:Screen
    {
        public TaxGroup():base()
        {
            this.URL = "general.taxgroup";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            TaxGroupCollectionView  = new TaxGroupCollectionView(this); 
            TaxGroupEntityView  = new TaxGroupEntityView(this); 
            TaxGroupRelationView  = new TaxGroupRelationView(this); 
            TaxGroupCollectionView.InitializeControls(); 
            TaxGroupEntityView.InitializeControls(); 
            TaxGroupRelationView.InitializeControls(); 
           
        }
      
            public TaxGroupCollectionView TaxGroupCollectionView {get; set; } 
            public TaxGroupEntityView TaxGroupEntityView {get; set; } 
            public TaxGroupRelationView TaxGroupRelationView {get; set; } 
    }
            
    public partial class TaxGroupCollectionView : View
    {
        public TaxGroupCollectionView(TaxGroup screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            NewButton = RPSControlFactory.RPSNewButton<TaxGroupCollectionView,TaxGroupEntityView>( this,Screen.TaxGroupEntityView);
 
            CollectionInit params_MainConsult = new CollectionInit(){IDDescriptor = "13bcdf6a-fa9d-4a0d-9457-da5d5c8e6564",CSSSelectorDescriptor = "",XPathDescriptor = ""};
            MainConsult = RPSControlFactory.RPSCreateCollection<TaxGroupCollectionView,TaxGroupEntityView>( params_MainConsult,this,Screen.TaxGroupEntityView);
 

        }
        public IRPSButton<TaxGroupCollectionView,TaxGroupEntityView> NewButton { get; set; } 
        public IRPSCollectionEditor<TaxGroupCollectionView,TaxGroupEntityView> MainConsult { get; set; } 
        public TaxGroup Screen { get; set; }
        public TaxGroupCollectionView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class TaxGroupEntityView : View
    {
        public TaxGroupEntityView(TaxGroup screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            SaveButton = RPSControlFactory.RPSSaveButton<TaxGroupEntityView>( this);
 
            DeleteButton = RPSControlFactory.RPSDeleteButton<TaxGroupEntityView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<TaxGroupEntityView,TaxGroupCollectionView>( this,Screen.TaxGroupCollectionView);
 
            BackButton = RPSControlFactory.RPSBackButton<TaxGroupEntityView,TaxGroupCollectionView>( this,Screen.TaxGroupCollectionView);
 
            CodTaxGroup = RPSControlFactory.CreateRPSTextBox<TaxGroupEntityView>("d2d9e467-d934-4740-8ca4-ba2e570921c5","","",true, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<TaxGroupEntityView>("a28b435b-1a24-4d07-a104-98479fb634de","","",false, this);
 
            Type = RPSControlFactory.CreateRPSEnumComboBox<TaxGroupEntityView>("26f95275-43bb-4bd7-b50f-f103382a9739","","",true, this);
 
            CollectionInit params_TaxGroupRelations = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="16ce4da2-28e1-4064-b633-c1f4df8b5f9c",CSSSelectorGrid="",XPathGrid=""};
            TaxGroupRelations = RPSControlFactory.RPSCreateCollectionWithGrid<TaxGroupRelationsCollectionEditor<TaxGroupEntityView,TaxGroupRelationView>,TaxGroupEntityView,TaxGroupRelationView>( params_TaxGroupRelations,this,Screen.TaxGroupRelationView);
 

        }
        public IRPSSaveButton<TaxGroupEntityView> SaveButton { get; set; } 
        public IRPSButton<TaxGroupEntityView> DeleteButton { get; set; } 
        public IRPSButton<TaxGroupEntityView,TaxGroupCollectionView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<TaxGroupEntityView,TaxGroupCollectionView> BackButton { get; set; } 
        public IRPSTextBox<TaxGroupEntityView> CodTaxGroup { get; set; } 
        public IRPSTextBox<TaxGroupEntityView> Description { get; set; } 
        public IRPSComboBox<TaxGroupEntityView> Type { get; set; } 
        public TaxGroupRelationsCollectionEditor<TaxGroupEntityView,TaxGroupRelationView> TaxGroupRelations { get; set; } 
        public TaxGroup Screen { get; set; }
        public TaxGroupEntityView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class TaxGroupRelationsCollectionEditor<TaxGroupEntityView,TaxGroupRelationView>:RPSCollectionEditor<TaxGroupEntityView,TaxGroupRelationView> where TaxGroupEntityView : class, IView where TaxGroupRelationView : class, IView
    {
        public  TaxGroupRelationsGridView<TaxGroupEntityView,TaxGroupRelationView> GridView {get;set;}
    }
    public partial class TaxGroupRelationsGridView <TaxGroupEntityView,TaxGroupRelationView> :  RPSGridView<TaxGroupEntityView,TaxGroupRelationView> where TaxGroupEntityView : class, IView where TaxGroupRelationView : class, IView
    {
        public TaxGroupRelationsGridView(TaxGroupEntityView currentView,TaxGroupRelationView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            IDTaxValue = RPSControlFactory.CreateRPSGridComboBox<TaxGroupEntityView>("","#16ce4da2-28e1-4064-b633-c1f4df8b5f9c .ag-row[role='row']@ROWINDEX [col-id='cIDTaxValue']","",true, this.CurrentView);
 

        }
        public IRPSGridComboBox<TaxGroupEntityView> IDTaxValue { get; set; } 
                     
    }
 
    }
  
            
    public partial class TaxGroupRelationView : View
    {
        public TaxGroupRelationView(TaxGroup screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            DeleteButton = RPSControlFactory.RPSDeleteButton<TaxGroupRelationView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<TaxGroupRelationView,TaxGroupEntityView>( this,Screen.TaxGroupEntityView);
 
            BackButton = RPSControlFactory.RPSBackButton<TaxGroupRelationView,TaxGroupEntityView>( this,Screen.TaxGroupEntityView);
 
            AcceptButton = RPSControlFactory.RPSAcceptButton<TaxGroupRelationView,TaxGroupEntityView>( this,Screen.TaxGroupEntityView);
 
            IDTaxValue = RPSControlFactory.CreateRPSComboBox<TaxGroupRelationView>("98ee8945-b958-4644-911a-3a1465b12b35","","",true, this);
 

        }
        public IRPSButton<TaxGroupRelationView> DeleteButton { get; set; } 
        public IRPSButton<TaxGroupRelationView,TaxGroupEntityView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<TaxGroupRelationView,TaxGroupEntityView> BackButton { get; set; } 
        public IRPSAcceptButton<TaxGroupRelationView,TaxGroupEntityView> AcceptButton { get; set; } 
        public IRPSComboBox<TaxGroupRelationView> IDTaxValue { get; set; } 
        public TaxGroup Screen { get; set; }
        public TaxGroupRelationView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}