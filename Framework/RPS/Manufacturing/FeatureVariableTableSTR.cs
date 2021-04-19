    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.Manufacturing.FeatureVariableTableSTR
{
    //RPS VERSION 1.0.0.0
    public partial class FeatureVariableTableSTR:Screen
    {
        public FeatureVariableTableSTR():base()
        {
            this.URL = "manufacturing.featurevariabletablestr";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            FeatureVariableTableSTRCollectionView  = new FeatureVariableTableSTRCollectionView(this); 
            FeatureVariableTableSTREntityView  = new FeatureVariableTableSTREntityView(this); 
            FeatureVariableTableValueSTRView  = new FeatureVariableTableValueSTRView(this); 
            FeatureVariableTableSTRCollectionView.InitializeControls(); 
            FeatureVariableTableSTREntityView.InitializeControls(); 
            FeatureVariableTableValueSTRView.InitializeControls(); 
           
        }
      
            public FeatureVariableTableSTRCollectionView FeatureVariableTableSTRCollectionView {get; set; } 
            public FeatureVariableTableSTREntityView FeatureVariableTableSTREntityView {get; set; } 
            public FeatureVariableTableValueSTRView FeatureVariableTableValueSTRView {get; set; } 
    }
            
    public partial class FeatureVariableTableSTRCollectionView : View
    {
        public FeatureVariableTableSTRCollectionView(FeatureVariableTableSTR screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            NewButton = RPSControlFactory.RPSNewButton<FeatureVariableTableSTRCollectionView,FeatureVariableTableSTREntityView>( this,Screen.FeatureVariableTableSTREntityView);
 
            CollectionInit params_MainConsult = new CollectionInit(){IDDescriptor = "19d43aa6-ea65-4741-af64-4d725f11e35a",CSSSelectorDescriptor = "",XPathDescriptor = ""};
            MainConsult = RPSControlFactory.RPSCreateCollection<FeatureVariableTableSTRCollectionView,FeatureVariableTableSTREntityView>( params_MainConsult,this,Screen.FeatureVariableTableSTREntityView);
 

        }
        public IRPSButton<FeatureVariableTableSTRCollectionView,FeatureVariableTableSTREntityView> NewButton { get; set; } 
        public IRPSCollectionEditor<FeatureVariableTableSTRCollectionView,FeatureVariableTableSTREntityView> MainConsult { get; set; } 
        public FeatureVariableTableSTR Screen { get; set; }
        public FeatureVariableTableSTRCollectionView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class FeatureVariableTableSTREntityView : View
    {
        public FeatureVariableTableSTREntityView(FeatureVariableTableSTR screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            SaveButton = RPSControlFactory.RPSSaveButton<FeatureVariableTableSTREntityView>( this);
 
            DeleteButton = RPSControlFactory.RPSDeleteButton<FeatureVariableTableSTREntityView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<FeatureVariableTableSTREntityView,FeatureVariableTableSTRCollectionView>( this,Screen.FeatureVariableTableSTRCollectionView);
 
            BackButton = RPSControlFactory.RPSBackButton<FeatureVariableTableSTREntityView,FeatureVariableTableSTRCollectionView>( this,Screen.FeatureVariableTableSTRCollectionView);
 
            CodTable = RPSControlFactory.CreateRPSTextBox<FeatureVariableTableSTREntityView>("fd02b6b6-7f6b-4e7b-97fe-8a0a6c4d2b89","","",true, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<FeatureVariableTableSTREntityView>("cd4e2936-0f21-4c98-a69b-5bac432464b4","","",false, this);
 
            CollectionInit params_FeatureVariableTableValues = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="2a2aa32c-9595-4c18-9af4-54ea99963448",CSSSelectorGrid="",XPathGrid=""};
            FeatureVariableTableValues = RPSControlFactory.RPSCreateCollectionWithGrid<FeatureVariableTableValuesCollectionEditor<FeatureVariableTableSTREntityView,FeatureVariableTableValueSTRView>,FeatureVariableTableSTREntityView,FeatureVariableTableValueSTRView>( params_FeatureVariableTableValues,this,Screen.FeatureVariableTableValueSTRView);
 

        }
        public IRPSSaveButton<FeatureVariableTableSTREntityView> SaveButton { get; set; } 
        public IRPSButton<FeatureVariableTableSTREntityView> DeleteButton { get; set; } 
        public IRPSButton<FeatureVariableTableSTREntityView,FeatureVariableTableSTRCollectionView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<FeatureVariableTableSTREntityView,FeatureVariableTableSTRCollectionView> BackButton { get; set; } 
        public IRPSTextBox<FeatureVariableTableSTREntityView> CodTable { get; set; } 
        public IRPSTextBox<FeatureVariableTableSTREntityView> Description { get; set; } 
        public FeatureVariableTableValuesCollectionEditor<FeatureVariableTableSTREntityView,FeatureVariableTableValueSTRView> FeatureVariableTableValues { get; set; } 
        public FeatureVariableTableSTR Screen { get; set; }
        public FeatureVariableTableSTREntityView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class FeatureVariableTableValuesCollectionEditor<FeatureVariableTableSTREntityView,FeatureVariableTableValueSTRView>:RPSCollectionEditor<FeatureVariableTableSTREntityView,FeatureVariableTableValueSTRView> where FeatureVariableTableSTREntityView : class, IView where FeatureVariableTableValueSTRView : class, IView
    {
        public  FeatureVariableTableValuesGridView<FeatureVariableTableSTREntityView,FeatureVariableTableValueSTRView> GridView {get;set;}
    }
    public partial class FeatureVariableTableValuesGridView <FeatureVariableTableSTREntityView,FeatureVariableTableValueSTRView> :  RPSGridView<FeatureVariableTableSTREntityView,FeatureVariableTableValueSTRView> where FeatureVariableTableSTREntityView : class, IView where FeatureVariableTableValueSTRView : class, IView
    {
        public FeatureVariableTableValuesGridView(FeatureVariableTableSTREntityView currentView,FeatureVariableTableValueSTRView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            Value = RPSControlFactory.CreateRPSGridTextBox<FeatureVariableTableSTREntityView>("","#2a2aa32c-9595-4c18-9af4-54ea99963448 .ag-row[role='row']@ROWINDEX [col-id='cValue']","",true, this.CurrentView);
 

        }
        public IRPSGridTextBox<FeatureVariableTableSTREntityView> Value { get; set; } 
                     
    }
 
    }
  
            
    public partial class FeatureVariableTableValueSTRView : View
    {
        public FeatureVariableTableValueSTRView(FeatureVariableTableSTR screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            DeleteButton = RPSControlFactory.RPSDeleteButton<FeatureVariableTableValueSTRView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<FeatureVariableTableValueSTRView,FeatureVariableTableSTREntityView>( this,Screen.FeatureVariableTableSTREntityView);
 
            BackButton = RPSControlFactory.RPSBackButton<FeatureVariableTableValueSTRView,FeatureVariableTableSTREntityView>( this,Screen.FeatureVariableTableSTREntityView);
 
            AcceptButton = RPSControlFactory.RPSAcceptButton<FeatureVariableTableValueSTRView,FeatureVariableTableSTREntityView>( this,Screen.FeatureVariableTableSTREntityView);
 
            Value = RPSControlFactory.CreateRPSTextBox<FeatureVariableTableValueSTRView>("1be20e8e-14d5-45ec-837a-11b6b5f6072e","","",true, this);
 

        }
        public IRPSButton<FeatureVariableTableValueSTRView> DeleteButton { get; set; } 
        public IRPSButton<FeatureVariableTableValueSTRView,FeatureVariableTableSTREntityView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<FeatureVariableTableValueSTRView,FeatureVariableTableSTREntityView> BackButton { get; set; } 
        public IRPSAcceptButton<FeatureVariableTableValueSTRView,FeatureVariableTableSTREntityView> AcceptButton { get; set; } 
        public IRPSTextBox<FeatureVariableTableValueSTRView> Value { get; set; } 
        public FeatureVariableTableSTR Screen { get; set; }
        public FeatureVariableTableValueSTRView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}