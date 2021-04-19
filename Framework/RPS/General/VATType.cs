    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.General.VATType
{
    //RPS VERSION 1.0.0.0
    public partial class VATType:Screen
    {
        public VATType():base()
        {
            this.URL = "general.vattype";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            VATTypeCollectionView  = new VATTypeCollectionView(this); 
            VATTypeEntityView  = new VATTypeEntityView(this); 
            VATTypeRelationView  = new VATTypeRelationView(this); 
            VATTypeCollectionView.InitializeControls(); 
            VATTypeEntityView.InitializeControls(); 
            VATTypeRelationView.InitializeControls(); 
           
        }
      
            public VATTypeCollectionView VATTypeCollectionView {get; set; } 
            public VATTypeEntityView VATTypeEntityView {get; set; } 
            public VATTypeRelationView VATTypeRelationView {get; set; } 
    }
            
    public partial class VATTypeCollectionView : View
    {
        public VATTypeCollectionView(VATType screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            NewButton = RPSControlFactory.RPSNewButton<VATTypeCollectionView,VATTypeEntityView>( this,Screen.VATTypeEntityView);
 
            CollectionInit params_MainConsult = new CollectionInit(){IDDescriptor = "f6dc4fb7-9c01-4aa9-a583-c4365bf73b7b",CSSSelectorDescriptor = "",XPathDescriptor = ""};
            MainConsult = RPSControlFactory.RPSCreateCollection<VATTypeCollectionView,VATTypeEntityView>( params_MainConsult,this,Screen.VATTypeEntityView);
 

        }
        public IRPSButton<VATTypeCollectionView,VATTypeEntityView> NewButton { get; set; } 
        public IRPSCollectionEditor<VATTypeCollectionView,VATTypeEntityView> MainConsult { get; set; } 
        public VATType Screen { get; set; }
        public VATTypeCollectionView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class VATTypeEntityView : View
    {
        public VATTypeEntityView(VATType screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            SaveButton = RPSControlFactory.RPSSaveButton<VATTypeEntityView>( this);
 
            DeleteButton = RPSControlFactory.RPSDeleteButton<VATTypeEntityView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<VATTypeEntityView,VATTypeCollectionView>( this,Screen.VATTypeCollectionView);
 
            BackButton = RPSControlFactory.RPSBackButton<VATTypeEntityView,VATTypeCollectionView>( this,Screen.VATTypeCollectionView);
 
            CodVATType = RPSControlFactory.CreateRPSTextBox<VATTypeEntityView>("345d6a6b-f6b1-494a-9840-e45316f62a83","","",true, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<VATTypeEntityView>("f4592bca-259f-4ee6-9cca-1f4528f8c68d","","",false, this);
 
            Type = RPSControlFactory.CreateRPSEnumComboBox<VATTypeEntityView>("42977403-22f4-449a-aa15-6261a2e5ee25","","",true, this);
 
            CollectionInit params_VATTypeRelations = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="349c3adb-45e4-4242-9c99-a65945e574ff",CSSSelectorGrid="",XPathGrid=""};
            VATTypeRelations = RPSControlFactory.RPSCreateCollectionWithGrid<VATTypeRelationsCollectionEditor<VATTypeEntityView,VATTypeRelationView>,VATTypeEntityView,VATTypeRelationView>( params_VATTypeRelations,this,Screen.VATTypeRelationView);
 

        }
        public IRPSSaveButton<VATTypeEntityView> SaveButton { get; set; } 
        public IRPSButton<VATTypeEntityView> DeleteButton { get; set; } 
        public IRPSButton<VATTypeEntityView,VATTypeCollectionView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<VATTypeEntityView,VATTypeCollectionView> BackButton { get; set; } 
        public IRPSTextBox<VATTypeEntityView> CodVATType { get; set; } 
        public IRPSTextBox<VATTypeEntityView> Description { get; set; } 
        public IRPSComboBox<VATTypeEntityView> Type { get; set; } 
        public VATTypeRelationsCollectionEditor<VATTypeEntityView,VATTypeRelationView> VATTypeRelations { get; set; } 
        public VATType Screen { get; set; }
        public VATTypeEntityView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class VATTypeRelationsCollectionEditor<VATTypeEntityView,VATTypeRelationView>:RPSCollectionEditor<VATTypeEntityView,VATTypeRelationView> where VATTypeEntityView : class, IView where VATTypeRelationView : class, IView
    {
        public  VATTypeRelationsGridView<VATTypeEntityView,VATTypeRelationView> GridView {get;set;}
    }
    public partial class VATTypeRelationsGridView <VATTypeEntityView,VATTypeRelationView> :  RPSGridView<VATTypeEntityView,VATTypeRelationView> where VATTypeEntityView : class, IView where VATTypeRelationView : class, IView
    {
        public VATTypeRelationsGridView(VATTypeEntityView currentView,VATTypeRelationView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            IDVATTypeA = RPSControlFactory.CreateRPSGridComboBox<VATTypeEntityView>("","#349c3adb-45e4-4242-9c99-a65945e574ff .ag-row[role='row']@ROWINDEX [col-id='cIDVATTypeA']","",true, this.CurrentView);
 
            IDVAT = RPSControlFactory.CreateRPSGridComboBox<VATTypeEntityView>("","#349c3adb-45e4-4242-9c99-a65945e574ff .ag-row[role='row']@ROWINDEX [col-id='cIDVAT']","",true, this.CurrentView);
 

        }
        public IRPSGridComboBox<VATTypeEntityView> IDVATTypeA { get; set; } 
        public IRPSGridComboBox<VATTypeEntityView> IDVAT { get; set; } 
                     
    }
 
    }
  
            
    public partial class VATTypeRelationView : View
    {
        public VATTypeRelationView(VATType screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            DeleteButton = RPSControlFactory.RPSDeleteButton<VATTypeRelationView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<VATTypeRelationView,VATTypeEntityView>( this,Screen.VATTypeEntityView);
 
            BackButton = RPSControlFactory.RPSBackButton<VATTypeRelationView,VATTypeEntityView>( this,Screen.VATTypeEntityView);
 
            AcceptButton = RPSControlFactory.RPSAcceptButton<VATTypeRelationView,VATTypeEntityView>( this,Screen.VATTypeEntityView);
 
            IDVATTypeA = RPSControlFactory.CreateRPSComboBox<VATTypeRelationView>("f8c8e1c5-ee88-4380-b1a0-4d58e68c427e","","",true, this);
 
            IDVAT = RPSControlFactory.CreateRPSComboBox<VATTypeRelationView>("d8ce3a45-64e0-4fd9-b1eb-89bff0353a94","","",true, this);
 

        }
        public IRPSButton<VATTypeRelationView> DeleteButton { get; set; } 
        public IRPSButton<VATTypeRelationView,VATTypeEntityView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<VATTypeRelationView,VATTypeEntityView> BackButton { get; set; } 
        public IRPSAcceptButton<VATTypeRelationView,VATTypeEntityView> AcceptButton { get; set; } 
        public IRPSComboBox<VATTypeRelationView> IDVATTypeA { get; set; } 
        public IRPSComboBox<VATTypeRelationView> IDVAT { get; set; } 
        public VATType Screen { get; set; }
        public VATTypeRelationView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}