    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.Manufacturing.CostComponentSTR
{
    //RPS VERSION 1.0.0.0
    public partial class CostComponentSTR:Screen
    {
        public CostComponentSTR():base()
        {
            this.URL = "manufacturing.costcomponentstr";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            CostComponentSTRCollectionView  = new CostComponentSTRCollectionView(this); 
            CostComponentSTREntityView  = new CostComponentSTREntityView(this); 
            CostComponentCostSTRView  = new CostComponentCostSTRView(this); 
            CostComponentSTRCollectionView.InitializeControls(); 
            CostComponentSTREntityView.InitializeControls(); 
            CostComponentCostSTRView.InitializeControls(); 
           
        }
      
            public CostComponentSTRCollectionView CostComponentSTRCollectionView {get; set; } 
            public CostComponentSTREntityView CostComponentSTREntityView {get; set; } 
            public CostComponentCostSTRView CostComponentCostSTRView {get; set; } 
    }
            
    public partial class CostComponentSTRCollectionView : View
    {
        public CostComponentSTRCollectionView(CostComponentSTR screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            NewButton = RPSControlFactory.RPSNewButton<CostComponentSTRCollectionView,CostComponentSTREntityView>( this,Screen.CostComponentSTREntityView);
 
            CollectionInit params_MainConsult = new CollectionInit(){IDDescriptor = "8e22d633-4104-49c6-9dc0-d005fc0be277",CSSSelectorDescriptor = "",XPathDescriptor = ""};
            MainConsult = RPSControlFactory.RPSCreateCollection<CostComponentSTRCollectionView,CostComponentSTREntityView>( params_MainConsult,this,Screen.CostComponentSTREntityView);
 

        }
        public IRPSButton<CostComponentSTRCollectionView,CostComponentSTREntityView> NewButton { get; set; } 
        public IRPSCollectionEditor<CostComponentSTRCollectionView,CostComponentSTREntityView> MainConsult { get; set; } 
        public CostComponentSTR Screen { get; set; }
        public CostComponentSTRCollectionView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class CostComponentSTREntityView : View
    {
        public CostComponentSTREntityView(CostComponentSTR screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            SaveButton = RPSControlFactory.RPSSaveButton<CostComponentSTREntityView>( this);
 
            DeleteButton = RPSControlFactory.RPSDeleteButton<CostComponentSTREntityView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<CostComponentSTREntityView,CostComponentSTRCollectionView>( this,Screen.CostComponentSTRCollectionView);
 
            BackButton = RPSControlFactory.RPSBackButton<CostComponentSTREntityView,CostComponentSTRCollectionView>( this,Screen.CostComponentSTRCollectionView);
 
            CodCostComponent = RPSControlFactory.CreateRPSTextBox<CostComponentSTREntityView>("88cc3fba-76d0-4288-aa95-38f72d176635","","",true, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<CostComponentSTREntityView>("181bdb60-9c38-401e-b8b3-d508e1eb3369","","",false, this);
 
            Abreviature = RPSControlFactory.CreateRPSTextBox<CostComponentSTREntityView>("a7b72d53-e69d-4e6d-8f7d-4f0e07d6d9b8","","",false, this);
 
            CollectionInit params_CostComponentCosts = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="78d26c71-2f6c-4fc5-8097-91c4e533c249",CSSSelectorGrid="",XPathGrid=""};
            CostComponentCosts = RPSControlFactory.RPSCreateCollectionWithGrid<CostComponentCostsCollectionEditor<CostComponentSTREntityView,CostComponentCostSTRView>,CostComponentSTREntityView,CostComponentCostSTRView>( params_CostComponentCosts,this,Screen.CostComponentCostSTRView);
 

        }
        public IRPSSaveButton<CostComponentSTREntityView> SaveButton { get; set; } 
        public IRPSButton<CostComponentSTREntityView> DeleteButton { get; set; } 
        public IRPSButton<CostComponentSTREntityView,CostComponentSTRCollectionView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<CostComponentSTREntityView,CostComponentSTRCollectionView> BackButton { get; set; } 
        public IRPSTextBox<CostComponentSTREntityView> CodCostComponent { get; set; } 
        public IRPSTextBox<CostComponentSTREntityView> Description { get; set; } 
        public IRPSTextBox<CostComponentSTREntityView> Abreviature { get; set; } 
        public CostComponentCostsCollectionEditor<CostComponentSTREntityView,CostComponentCostSTRView> CostComponentCosts { get; set; } 
        public CostComponentSTR Screen { get; set; }
        public CostComponentSTREntityView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class CostComponentCostsCollectionEditor<CostComponentSTREntityView,CostComponentCostSTRView>:RPSCollectionEditor<CostComponentSTREntityView,CostComponentCostSTRView> where CostComponentSTREntityView : class, IView where CostComponentCostSTRView : class, IView
    {
        public  CostComponentCostsGridView<CostComponentSTREntityView,CostComponentCostSTRView> GridView {get;set;}
    }
    public partial class CostComponentCostsGridView <CostComponentSTREntityView,CostComponentCostSTRView> :  RPSGridView<CostComponentSTREntityView,CostComponentCostSTRView> where CostComponentSTREntityView : class, IView where CostComponentCostSTRView : class, IView
    {
        public CostComponentCostsGridView(CostComponentSTREntityView currentView,CostComponentCostSTRView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            DateFrom = RPSControlFactory.CreateRPSGridTextBox<CostComponentSTREntityView>("","#78d26c71-2f6c-4fc5-8097-91c4e533c249 .ag-row[role='row']@ROWINDEX [col-id='cDateFrom']","",true, this.CurrentView);
 
            CostPrice = RPSControlFactory.CreateRPSGridFormattedTextBox<CostComponentSTREntityView>("","#78d26c71-2f6c-4fc5-8097-91c4e533c249 .ag-row[role='row']@ROWINDEX [col-id='cCostPrice']","",true, this.CurrentView);
 

        }
        public IRPSGridTextBox<CostComponentSTREntityView> DateFrom { get; set; } 
        public IRPSGridTextBox<CostComponentSTREntityView> CostPrice { get; set; } 
                     
    }
 
    }
  
            
    public partial class CostComponentCostSTRView : View
    {
        public CostComponentCostSTRView(CostComponentSTR screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            DeleteButton = RPSControlFactory.RPSDeleteButton<CostComponentCostSTRView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<CostComponentCostSTRView,CostComponentSTREntityView>( this,Screen.CostComponentSTREntityView);
 
            BackButton = RPSControlFactory.RPSBackButton<CostComponentCostSTRView,CostComponentSTREntityView>( this,Screen.CostComponentSTREntityView);
 
            AcceptButton = RPSControlFactory.RPSAcceptButton<CostComponentCostSTRView,CostComponentSTREntityView>( this,Screen.CostComponentSTREntityView);
 
            DateFrom = RPSControlFactory.CreateRPSTextBox<CostComponentCostSTRView>("0b778c2f-7c54-45ab-86c5-a65f8208b9df","","",true, this);
 
            CostPrice = RPSControlFactory.CreateRPSFormattedTextBox<CostComponentCostSTRView>("5cfc287b-ad21-4c2a-a2c3-b74b30cb9817","","",true, this);
 

        }
        public IRPSButton<CostComponentCostSTRView> DeleteButton { get; set; } 
        public IRPSButton<CostComponentCostSTRView,CostComponentSTREntityView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<CostComponentCostSTRView,CostComponentSTREntityView> BackButton { get; set; } 
        public IRPSAcceptButton<CostComponentCostSTRView,CostComponentSTREntityView> AcceptButton { get; set; } 
        public IRPSTextBox<CostComponentCostSTRView> DateFrom { get; set; } 
        public IRPSTextBox<CostComponentCostSTRView> CostPrice { get; set; } 
        public CostComponentSTR Screen { get; set; }
        public CostComponentCostSTRView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}