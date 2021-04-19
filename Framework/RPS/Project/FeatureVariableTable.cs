    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.Project.FeatureVariableTable
{
    //RPS VERSION 1.0.0.0
    public partial class FeatureVariableTable:Screen
    {
        public FeatureVariableTable():base()
        {
            this.URL = "project.featurevariabletable";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            FeatureVariableTableCollectionView  = new FeatureVariableTableCollectionView(this); 
            FeatureVariableTableEntityView  = new FeatureVariableTableEntityView(this); 
            FeatureVariableTableValueView  = new FeatureVariableTableValueView(this); 
            FeatureVariableTableCollectionView.InitializeControls(); 
            FeatureVariableTableEntityView.InitializeControls(); 
            FeatureVariableTableValueView.InitializeControls(); 
           
        }
      
            public FeatureVariableTableCollectionView FeatureVariableTableCollectionView {get; set; } 
            public FeatureVariableTableEntityView FeatureVariableTableEntityView {get; set; } 
            public FeatureVariableTableValueView FeatureVariableTableValueView {get; set; } 
    }
            
    public partial class FeatureVariableTableCollectionView : View
    {
        public FeatureVariableTableCollectionView(FeatureVariableTable screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            NewButton = RPSControlFactory.RPSNewButton<FeatureVariableTableCollectionView,FeatureVariableTableEntityView>( this,Screen.FeatureVariableTableEntityView);
 
            CollectionInit params_MainConsult = new CollectionInit(){IDDescriptor = "ffb1c21b-c4ae-40c4-ad83-7276b9c860c2",CSSSelectorDescriptor = "",XPathDescriptor = ""};
            MainConsult = RPSControlFactory.RPSCreateCollection<FeatureVariableTableCollectionView,FeatureVariableTableEntityView>( params_MainConsult,this,Screen.FeatureVariableTableEntityView);
 

        }
        public IRPSButton<FeatureVariableTableCollectionView,FeatureVariableTableEntityView> NewButton { get; set; } 
        public IRPSCollectionEditor<FeatureVariableTableCollectionView,FeatureVariableTableEntityView> MainConsult { get; set; } 
        public FeatureVariableTable Screen { get; set; }
        public FeatureVariableTableCollectionView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class FeatureVariableTableEntityView : View
    {
        public FeatureVariableTableEntityView(FeatureVariableTable screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            SaveButton = RPSControlFactory.RPSSaveButton<FeatureVariableTableEntityView>( this);
 
            DeleteButton = RPSControlFactory.RPSDeleteButton<FeatureVariableTableEntityView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<FeatureVariableTableEntityView,FeatureVariableTableCollectionView>( this,Screen.FeatureVariableTableCollectionView);
 
            BackButton = RPSControlFactory.RPSBackButton<FeatureVariableTableEntityView,FeatureVariableTableCollectionView>( this,Screen.FeatureVariableTableCollectionView);
 
            CodTable = RPSControlFactory.CreateRPSTextBox<FeatureVariableTableEntityView>("a3449dec-5e8d-460e-9eae-211f660d3026","","",true, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<FeatureVariableTableEntityView>("a9ebb46c-58c3-46fa-bfd3-4ead8462fce3","","",false, this);
 
            CollectionInit params_FeatureVariableTableValues = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="eace1450-d68e-4d49-89ee-dfc5a062873c",CSSSelectorGrid="",XPathGrid=""};
            FeatureVariableTableValues = RPSControlFactory.RPSCreateCollectionWithGrid<FeatureVariableTableValuesCollectionEditor<FeatureVariableTableEntityView,FeatureVariableTableValueView>,FeatureVariableTableEntityView,FeatureVariableTableValueView>( params_FeatureVariableTableValues,this,Screen.FeatureVariableTableValueView);
 

        }
        public IRPSSaveButton<FeatureVariableTableEntityView> SaveButton { get; set; } 
        public IRPSButton<FeatureVariableTableEntityView> DeleteButton { get; set; } 
        public IRPSButton<FeatureVariableTableEntityView,FeatureVariableTableCollectionView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<FeatureVariableTableEntityView,FeatureVariableTableCollectionView> BackButton { get; set; } 
        public IRPSTextBox<FeatureVariableTableEntityView> CodTable { get; set; } 
        public IRPSTextBox<FeatureVariableTableEntityView> Description { get; set; } 
        public FeatureVariableTableValuesCollectionEditor<FeatureVariableTableEntityView,FeatureVariableTableValueView> FeatureVariableTableValues { get; set; } 
        public FeatureVariableTable Screen { get; set; }
        public FeatureVariableTableEntityView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class FeatureVariableTableValuesCollectionEditor<FeatureVariableTableEntityView,FeatureVariableTableValueView>:RPSCollectionEditor<FeatureVariableTableEntityView,FeatureVariableTableValueView> where FeatureVariableTableEntityView : class, IView where FeatureVariableTableValueView : class, IView
    {
        public  FeatureVariableTableValuesGridView<FeatureVariableTableEntityView,FeatureVariableTableValueView> GridView {get;set;}
    }
    public partial class FeatureVariableTableValuesGridView <FeatureVariableTableEntityView,FeatureVariableTableValueView> :  RPSGridView<FeatureVariableTableEntityView,FeatureVariableTableValueView> where FeatureVariableTableEntityView : class, IView where FeatureVariableTableValueView : class, IView
    {
        public FeatureVariableTableValuesGridView(FeatureVariableTableEntityView currentView,FeatureVariableTableValueView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            Value = RPSControlFactory.CreateRPSGridTextBox<FeatureVariableTableEntityView>("","#eace1450-d68e-4d49-89ee-dfc5a062873c .ag-row[role='row']@ROWINDEX [col-id='cValue']","",true, this.CurrentView);
 

        }
        public IRPSGridTextBox<FeatureVariableTableEntityView> Value { get; set; } 
                     
    }
 
    }
  
            
    public partial class FeatureVariableTableValueView : View
    {
        public FeatureVariableTableValueView(FeatureVariableTable screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            DeleteButton = RPSControlFactory.RPSDeleteButton<FeatureVariableTableValueView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<FeatureVariableTableValueView,FeatureVariableTableEntityView>( this,Screen.FeatureVariableTableEntityView);
 
            BackButton = RPSControlFactory.RPSBackButton<FeatureVariableTableValueView,FeatureVariableTableEntityView>( this,Screen.FeatureVariableTableEntityView);
 
            AcceptButton = RPSControlFactory.RPSAcceptButton<FeatureVariableTableValueView,FeatureVariableTableEntityView>( this,Screen.FeatureVariableTableEntityView);
 
            Value = RPSControlFactory.CreateRPSTextBox<FeatureVariableTableValueView>("62d7d9c1-de9f-45f2-ba4c-143571babfa0","","",true, this);
 

        }
        public IRPSButton<FeatureVariableTableValueView> DeleteButton { get; set; } 
        public IRPSButton<FeatureVariableTableValueView,FeatureVariableTableEntityView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<FeatureVariableTableValueView,FeatureVariableTableEntityView> BackButton { get; set; } 
        public IRPSAcceptButton<FeatureVariableTableValueView,FeatureVariableTableEntityView> AcceptButton { get; set; } 
        public IRPSTextBox<FeatureVariableTableValueView> Value { get; set; } 
        public FeatureVariableTable Screen { get; set; }
        public FeatureVariableTableValueView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}