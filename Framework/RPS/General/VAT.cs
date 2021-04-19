    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.General.VAT
{
    //RPS VERSION 1.0.0.0
    public partial class VAT:Screen
    {
        public VAT():base()
        {
            this.URL = "general.vat";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            VATCollectionView  = new VATCollectionView(this); 
            VATEntityView  = new VATEntityView(this); 
            VATDetailView  = new VATDetailView(this); 
            VATCollectionView.InitializeControls(); 
            VATEntityView.InitializeControls(); 
            VATDetailView.InitializeControls(); 
           
        }
      
            public VATCollectionView VATCollectionView {get; set; } 
            public VATEntityView VATEntityView {get; set; } 
            public VATDetailView VATDetailView {get; set; } 
    }
            
    public partial class VATCollectionView : View
    {
        public VATCollectionView(VAT screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            NewButton = RPSControlFactory.RPSNewButton<VATCollectionView,VATEntityView>( this,Screen.VATEntityView);
 
            CollectionInit params_MainConsult = new CollectionInit(){IDDescriptor = "0c6e3ca2-996a-438e-a78a-7ecf2540030d",CSSSelectorDescriptor = "",XPathDescriptor = ""};
            MainConsult = RPSControlFactory.RPSCreateCollection<VATCollectionView,VATEntityView>( params_MainConsult,this,Screen.VATEntityView);
 

        }
        public IRPSButton<VATCollectionView,VATEntityView> NewButton { get; set; } 
        public IRPSCollectionEditor<VATCollectionView,VATEntityView> MainConsult { get; set; } 
        public VAT Screen { get; set; }
        public VATCollectionView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class VATEntityView : View
    {
        public VATEntityView(VAT screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            SaveButton = RPSControlFactory.RPSSaveButton<VATEntityView>( this);
 
            DeleteButton = RPSControlFactory.RPSDeleteButton<VATEntityView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<VATEntityView,VATCollectionView>( this,Screen.VATCollectionView);
 
            BackButton = RPSControlFactory.RPSBackButton<VATEntityView,VATCollectionView>( this,Screen.VATCollectionView);
 
            CodVAT = RPSControlFactory.CreateRPSTextBox<VATEntityView>("696bba40-f52c-49db-b0ef-1939ce09fe21","","",true, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<VATEntityView>("9da0bb12-0ac7-4700-9d43-6d21ad272a88","","",false, this);
 
            NoTaxableVAT = RPSControlFactory.CreateRPSCheckBox<VATEntityView>("fa169f32-c8be-409d-8115-5b32e28caaa2","","",true, this);
 
            VATNotDeducToCost = RPSControlFactory.CreateRPSCheckBox<VATEntityView>("948f1c07-e55b-47c3-9026-18b196e53ce1","","",true, this);
 
            Surcharge = RPSControlFactory.CreateRPSCheckBox<VATEntityView>("b5d0d32e-004b-45fa-9b58-83d22a04d24e","","",true, this);
 
            IDVATFrom = RPSControlFactory.CreateRPSComboBox<VATEntityView>("d1143b6c-4250-4b9f-8d09-a8e2b2a05502","","",false, this);
 
            CollectionInit params_GENVATDetails = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="435ee109-59bf-488c-b2f6-290c9868ae44",CSSSelectorGrid="",XPathGrid=""};
            GENVATDetails = RPSControlFactory.RPSCreateCollectionWithGrid<GENVATDetailsCollectionEditor<VATEntityView,VATDetailView>,VATEntityView,VATDetailView>( params_GENVATDetails,this,Screen.VATDetailView);
 

        }
        public IRPSSaveButton<VATEntityView> SaveButton { get; set; } 
        public IRPSButton<VATEntityView> DeleteButton { get; set; } 
        public IRPSButton<VATEntityView,VATCollectionView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<VATEntityView,VATCollectionView> BackButton { get; set; } 
        public IRPSTextBox<VATEntityView> CodVAT { get; set; } 
        public IRPSTextBox<VATEntityView> Description { get; set; } 
        public IRPSCheckbox<VATEntityView> NoTaxableVAT { get; set; } 
        public IRPSCheckbox<VATEntityView> VATNotDeducToCost { get; set; } 
        public IRPSCheckbox<VATEntityView> Surcharge { get; set; } 
        public IRPSComboBox<VATEntityView> IDVATFrom { get; set; } 
        public GENVATDetailsCollectionEditor<VATEntityView,VATDetailView> GENVATDetails { get; set; } 
        public VAT Screen { get; set; }
        public VATEntityView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class GENVATDetailsCollectionEditor<VATEntityView,VATDetailView>:RPSCollectionEditor<VATEntityView,VATDetailView> where VATEntityView : class, IView where VATDetailView : class, IView
    {
        public  GENVATDetailsGridView<VATEntityView,VATDetailView> GridView {get;set;}
    }
    public partial class GENVATDetailsGridView <VATEntityView,VATDetailView> :  RPSGridView<VATEntityView,VATDetailView> where VATEntityView : class, IView where VATDetailView : class, IView
    {
        public GENVATDetailsGridView(VATEntityView currentView,VATDetailView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            DateFrom = RPSControlFactory.CreateRPSGridTextBox<VATEntityView>("","#435ee109-59bf-488c-b2f6-290c9868ae44 .ag-row[role='row']@ROWINDEX [col-id='cDateFrom']","",true, this.CurrentView);
 
            Percent = RPSControlFactory.CreateRPSGridFormattedTextBox<VATEntityView>("","#435ee109-59bf-488c-b2f6-290c9868ae44 .ag-row[role='row']@ROWINDEX [col-id='cPercent']","",true, this.CurrentView);
 
            PercentDeductible = RPSControlFactory.CreateRPSGridFormattedTextBox<VATEntityView>("","#435ee109-59bf-488c-b2f6-290c9868ae44 .ag-row[role='row']@ROWINDEX [col-id='cPercentDeductible']","",true, this.CurrentView);
 

        }
        public IRPSGridTextBox<VATEntityView> DateFrom { get; set; } 
        public IRPSGridTextBox<VATEntityView> Percent { get; set; } 
        public IRPSGridTextBox<VATEntityView> PercentDeductible { get; set; } 
                     
    }
 
    }
  
            
    public partial class VATDetailView : View
    {
        public VATDetailView(VAT screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            DeleteButton = RPSControlFactory.RPSDeleteButton<VATDetailView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<VATDetailView,VATEntityView>( this,Screen.VATEntityView);
 
            BackButton = RPSControlFactory.RPSBackButton<VATDetailView,VATEntityView>( this,Screen.VATEntityView);
 
            AcceptButton = RPSControlFactory.RPSAcceptButton<VATDetailView,VATEntityView>( this,Screen.VATEntityView);
 
            DateFrom = RPSControlFactory.CreateRPSTextBox<VATDetailView>("6d99dedc-dbac-4d78-bb5a-09c64197b0d4","","",true, this);
 
            Percent = RPSControlFactory.CreateRPSFormattedTextBox<VATDetailView>("5dbb9414-3ca9-4995-bdd1-4dd01346fc0a","","",true, this);
 
            PercentDeductible = RPSControlFactory.CreateRPSFormattedTextBox<VATDetailView>("79cdfbe8-d43e-4c9a-bad4-3cc4192248cd","","",true, this);
 

        }
        public IRPSButton<VATDetailView> DeleteButton { get; set; } 
        public IRPSButton<VATDetailView,VATEntityView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<VATDetailView,VATEntityView> BackButton { get; set; } 
        public IRPSAcceptButton<VATDetailView,VATEntityView> AcceptButton { get; set; } 
        public IRPSTextBox<VATDetailView> DateFrom { get; set; } 
        public IRPSTextBox<VATDetailView> Percent { get; set; } 
        public IRPSTextBox<VATDetailView> PercentDeductible { get; set; } 
        public VAT Screen { get; set; }
        public VATDetailView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}