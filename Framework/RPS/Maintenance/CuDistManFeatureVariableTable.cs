    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.Maintenance.CuDistManFeatureVariableTable
{
    //RPS VERSION 1.0.0.0
    public partial class CuDistManFeatureVariableTable:Screen
    {
        public CuDistManFeatureVariableTable():base()
        {
            this.URL = "maintenance.cudistmanfeaturevariabletable";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            CuDistManFeatureVariableTableCollectionView  = new CuDistManFeatureVariableTableCollectionView(this); 
            CuDistManFeatureVariableTableEntityView  = new CuDistManFeatureVariableTableEntityView(this); 
            CuDistManFeatureVariableTableValueView  = new CuDistManFeatureVariableTableValueView(this); 
            CuDistManFeatureVariableTableCollectionView.InitializeControls(); 
            CuDistManFeatureVariableTableEntityView.InitializeControls(); 
            CuDistManFeatureVariableTableValueView.InitializeControls(); 
           
        }
      
            public CuDistManFeatureVariableTableCollectionView CuDistManFeatureVariableTableCollectionView {get; set; } 
            public CuDistManFeatureVariableTableEntityView CuDistManFeatureVariableTableEntityView {get; set; } 
            public CuDistManFeatureVariableTableValueView CuDistManFeatureVariableTableValueView {get; set; } 
    }
            
    public partial class CuDistManFeatureVariableTableCollectionView : View
    {
        public CuDistManFeatureVariableTableCollectionView(CuDistManFeatureVariableTable screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            NewButton = RPSControlFactory.RPSNewButton<CuDistManFeatureVariableTableCollectionView,CuDistManFeatureVariableTableEntityView>( this,Screen.CuDistManFeatureVariableTableEntityView);
 
            CollectionInit params_MainConsult = new CollectionInit(){IDDescriptor = "e2e1df78-336e-4602-9359-c48789d831ff",CSSSelectorDescriptor = "",XPathDescriptor = ""};
            MainConsult = RPSControlFactory.RPSCreateCollection<CuDistManFeatureVariableTableCollectionView,CuDistManFeatureVariableTableEntityView>( params_MainConsult,this,Screen.CuDistManFeatureVariableTableEntityView);
 

        }
        public IRPSButton<CuDistManFeatureVariableTableCollectionView,CuDistManFeatureVariableTableEntityView> NewButton { get; set; } 
        public IRPSCollectionEditor<CuDistManFeatureVariableTableCollectionView,CuDistManFeatureVariableTableEntityView> MainConsult { get; set; } 
        public CuDistManFeatureVariableTable Screen { get; set; }
        public CuDistManFeatureVariableTableCollectionView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class CuDistManFeatureVariableTableEntityView : View
    {
        public CuDistManFeatureVariableTableEntityView(CuDistManFeatureVariableTable screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            SaveButton = RPSControlFactory.RPSSaveButton<CuDistManFeatureVariableTableEntityView>( this);
 
            DeleteButton = RPSControlFactory.RPSDeleteButton<CuDistManFeatureVariableTableEntityView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<CuDistManFeatureVariableTableEntityView,CuDistManFeatureVariableTableCollectionView>( this,Screen.CuDistManFeatureVariableTableCollectionView);
 
            BackButton = RPSControlFactory.RPSBackButton<CuDistManFeatureVariableTableEntityView,CuDistManFeatureVariableTableCollectionView>( this,Screen.CuDistManFeatureVariableTableCollectionView);
 
            CodTable = RPSControlFactory.CreateRPSTextBox<CuDistManFeatureVariableTableEntityView>("bc363743-201c-4314-a3d2-3474a015474e","","",true, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<CuDistManFeatureVariableTableEntityView>("2efb8bed-31d6-42f2-863d-09660724d17b","","",false, this);
 
            CollectionInit params_CuDistManFeatureVariableTableValues = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="1228340f-eb89-4506-81f7-ab2cd4487089",CSSSelectorGrid="",XPathGrid=""};
            CuDistManFeatureVariableTableValues = RPSControlFactory.RPSCreateCollectionWithGrid<CuDistManFeatureVariableTableValuesCollectionEditor<CuDistManFeatureVariableTableEntityView,CuDistManFeatureVariableTableValueView>,CuDistManFeatureVariableTableEntityView,CuDistManFeatureVariableTableValueView>( params_CuDistManFeatureVariableTableValues,this,Screen.CuDistManFeatureVariableTableValueView);
 

        }
        public IRPSSaveButton<CuDistManFeatureVariableTableEntityView> SaveButton { get; set; } 
        public IRPSButton<CuDistManFeatureVariableTableEntityView> DeleteButton { get; set; } 
        public IRPSButton<CuDistManFeatureVariableTableEntityView,CuDistManFeatureVariableTableCollectionView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<CuDistManFeatureVariableTableEntityView,CuDistManFeatureVariableTableCollectionView> BackButton { get; set; } 
        public IRPSTextBox<CuDistManFeatureVariableTableEntityView> CodTable { get; set; } 
        public IRPSTextBox<CuDistManFeatureVariableTableEntityView> Description { get; set; } 
        public CuDistManFeatureVariableTableValuesCollectionEditor<CuDistManFeatureVariableTableEntityView,CuDistManFeatureVariableTableValueView> CuDistManFeatureVariableTableValues { get; set; } 
        public CuDistManFeatureVariableTable Screen { get; set; }
        public CuDistManFeatureVariableTableEntityView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class CuDistManFeatureVariableTableValuesCollectionEditor<CuDistManFeatureVariableTableEntityView,CuDistManFeatureVariableTableValueView>:RPSCollectionEditor<CuDistManFeatureVariableTableEntityView,CuDistManFeatureVariableTableValueView> where CuDistManFeatureVariableTableEntityView : class, IView where CuDistManFeatureVariableTableValueView : class, IView
    {
        public  CuDistManFeatureVariableTableValuesGridView<CuDistManFeatureVariableTableEntityView,CuDistManFeatureVariableTableValueView> GridView {get;set;}
    }
    public partial class CuDistManFeatureVariableTableValuesGridView <CuDistManFeatureVariableTableEntityView,CuDistManFeatureVariableTableValueView> :  RPSGridView<CuDistManFeatureVariableTableEntityView,CuDistManFeatureVariableTableValueView> where CuDistManFeatureVariableTableEntityView : class, IView where CuDistManFeatureVariableTableValueView : class, IView
    {
        public CuDistManFeatureVariableTableValuesGridView(CuDistManFeatureVariableTableEntityView currentView,CuDistManFeatureVariableTableValueView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            Value = RPSControlFactory.CreateRPSGridTextBox<CuDistManFeatureVariableTableEntityView>("","#1228340f-eb89-4506-81f7-ab2cd4487089 .ag-row[role='row']@ROWINDEX [col-id='cValue']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<CuDistManFeatureVariableTableEntityView> Value { get; set; } 
                     
    }
 
    }
  
            
    public partial class CuDistManFeatureVariableTableValueView : View
    {
        public CuDistManFeatureVariableTableValueView(CuDistManFeatureVariableTable screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            DeleteButton = RPSControlFactory.RPSDeleteButton<CuDistManFeatureVariableTableValueView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<CuDistManFeatureVariableTableValueView,CuDistManFeatureVariableTableEntityView>( this,Screen.CuDistManFeatureVariableTableEntityView);
 
            BackButton = RPSControlFactory.RPSBackButton<CuDistManFeatureVariableTableValueView,CuDistManFeatureVariableTableEntityView>( this,Screen.CuDistManFeatureVariableTableEntityView);
 
            AcceptButton = RPSControlFactory.RPSAcceptButton<CuDistManFeatureVariableTableValueView,CuDistManFeatureVariableTableEntityView>( this,Screen.CuDistManFeatureVariableTableEntityView);
 
            Value = RPSControlFactory.CreateRPSTextBox<CuDistManFeatureVariableTableValueView>("837d325c-b625-431a-b50a-3fd1c21f1e9d","","",false, this);
 

        }
        public IRPSButton<CuDistManFeatureVariableTableValueView> DeleteButton { get; set; } 
        public IRPSButton<CuDistManFeatureVariableTableValueView,CuDistManFeatureVariableTableEntityView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<CuDistManFeatureVariableTableValueView,CuDistManFeatureVariableTableEntityView> BackButton { get; set; } 
        public IRPSAcceptButton<CuDistManFeatureVariableTableValueView,CuDistManFeatureVariableTableEntityView> AcceptButton { get; set; } 
        public IRPSTextBox<CuDistManFeatureVariableTableValueView> Value { get; set; } 
        public CuDistManFeatureVariableTable Screen { get; set; }
        public CuDistManFeatureVariableTableValueView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}