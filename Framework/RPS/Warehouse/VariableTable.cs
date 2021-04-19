    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.Warehouse.VariableTable
{
    //RPS VERSION 1.0.0.0
    public partial class VariableTable:Screen
    {
        public VariableTable():base()
        {
            this.URL = "warehouse.variabletable";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            VariableTableCollectionView  = new VariableTableCollectionView(this); 
            VariableTableEntityView  = new VariableTableEntityView(this); 
            VariableTableValueView  = new VariableTableValueView(this); 
            VariableTableByLangView  = new VariableTableByLangView(this); 
            VariableTableCollectionView.InitializeControls(); 
            VariableTableEntityView.InitializeControls(); 
            VariableTableValueView.InitializeControls(); 
            VariableTableByLangView.InitializeControls(); 
           
        }
      
            public VariableTableCollectionView VariableTableCollectionView {get; set; } 
            public VariableTableEntityView VariableTableEntityView {get; set; } 
            public VariableTableValueView VariableTableValueView {get; set; } 
            public VariableTableByLangView VariableTableByLangView {get; set; } 
    }
            
    public partial class VariableTableCollectionView : View
    {
        public VariableTableCollectionView(VariableTable screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            NewButton = RPSControlFactory.RPSNewButton<VariableTableCollectionView,VariableTableEntityView>( this,Screen.VariableTableEntityView);
 
            CollectionInit params_MainConsult = new CollectionInit(){IDDescriptor = "54513acf-5523-48a2-8350-15e207ea28f1",CSSSelectorDescriptor = "",XPathDescriptor = ""};
            MainConsult = RPSControlFactory.RPSCreateCollection<VariableTableCollectionView,VariableTableEntityView>( params_MainConsult,this,Screen.VariableTableEntityView);
 

        }
        public IRPSButton<VariableTableCollectionView,VariableTableEntityView> NewButton { get; set; } 
        public IRPSCollectionEditor<VariableTableCollectionView,VariableTableEntityView> MainConsult { get; set; } 
        public VariableTable Screen { get; set; }
        public VariableTableCollectionView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class VariableTableEntityView : View
    {
        public VariableTableEntityView(VariableTable screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            SaveButton = RPSControlFactory.RPSSaveButton<VariableTableEntityView>( this);
 
            DeleteButton = RPSControlFactory.RPSDeleteButton<VariableTableEntityView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<VariableTableEntityView,VariableTableCollectionView>( this,Screen.VariableTableCollectionView);
 
            BackButton = RPSControlFactory.RPSBackButton<VariableTableEntityView,VariableTableCollectionView>( this,Screen.VariableTableCollectionView);
 
            CodTable = RPSControlFactory.CreateRPSTextBox<VariableTableEntityView>("32bd89de-ff89-487e-b2e7-f097074f3cc5","","",true, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<VariableTableEntityView>("055e6e79-2e50-4efa-8aec-dea4340aa3fc","","",false, this);
 
            CollectionInit params_Values = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="4a64f9a4-a12f-4e06-8df7-ee3162a7cf80",CSSSelectorGrid="",XPathGrid=""};
            Values = RPSControlFactory.RPSCreateCollectionWithGrid<ValuesCollectionEditor<VariableTableEntityView,VariableTableValueView>,VariableTableEntityView,VariableTableValueView>( params_Values,this,Screen.VariableTableValueView);
 
            CollectionInit params_VariableTableByLangs = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="18f00545-de29-4707-9cc6-17283a9517c2",CSSSelectorGrid="",XPathGrid=""};
            VariableTableByLangs = RPSControlFactory.RPSCreateCollectionWithGrid<VariableTableByLangsCollectionEditor<VariableTableEntityView,VariableTableValueView>,VariableTableEntityView,VariableTableValueView>( params_VariableTableByLangs,this,Screen.VariableTableValueView);
 
            Section1 = RPSControlFactory.CreateRPSSection<VariableTableEntityView>( "","ul li[rpsid='af6e3919-44f6-427d-b542-a729f1dc8e15']","",this);
 
            Section = RPSControlFactory.CreateRPSSection<VariableTableEntityView>( "","ul li[rpsid='9ed638d2-728d-46e0-a3a3-0edcb51358d8']","",this);
 

        }
        public IRPSSaveButton<VariableTableEntityView> SaveButton { get; set; } 
        public IRPSButton<VariableTableEntityView> DeleteButton { get; set; } 
        public IRPSButton<VariableTableEntityView,VariableTableCollectionView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<VariableTableEntityView,VariableTableCollectionView> BackButton { get; set; } 
        public IRPSTextBox<VariableTableEntityView> CodTable { get; set; } 
        public IRPSTextBox<VariableTableEntityView> Description { get; set; } 
        public ValuesCollectionEditor<VariableTableEntityView,VariableTableValueView> Values { get; set; } 
        public VariableTableByLangsCollectionEditor<VariableTableEntityView,VariableTableValueView> VariableTableByLangs { get; set; } 
        public IRPSSection<VariableTableEntityView> Section1 { get; set; } 
        public IRPSSection<VariableTableEntityView> Section { get; set; } 
        public VariableTable Screen { get; set; }
        public VariableTableEntityView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class ValuesCollectionEditor<VariableTableEntityView,VariableTableValueView>:RPSCollectionEditor<VariableTableEntityView,VariableTableValueView> where VariableTableEntityView : class, IView where VariableTableValueView : class, IView
    {
        public  ValuesGridView<VariableTableEntityView,VariableTableValueView> GridView {get;set;}
    }
    public partial class ValuesGridView <VariableTableEntityView,VariableTableValueView> :  RPSGridView<VariableTableEntityView,VariableTableValueView> where VariableTableEntityView : class, IView where VariableTableValueView : class, IView
    {
        public ValuesGridView(VariableTableEntityView currentView,VariableTableValueView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            Value = RPSControlFactory.CreateRPSGridTextBox<VariableTableEntityView>("","#4a64f9a4-a12f-4e06-8df7-ee3162a7cf80 .ag-row[role='row']@ROWINDEX [col-id='cValue']","",true, this.CurrentView);
 

        }
        public IRPSGridTextBox<VariableTableEntityView> Value { get; set; } 
                     
    }
 
        public partial class VariableTableByLangsCollectionEditor<VariableTableEntityView,VariableTableValueView>:RPSCollectionEditor<VariableTableEntityView,VariableTableValueView> where VariableTableEntityView : class, IView where VariableTableValueView : class, IView
    {
        public  VariableTableByLangsGridView<VariableTableEntityView,VariableTableValueView> GridView {get;set;}
    }
    public partial class VariableTableByLangsGridView <VariableTableEntityView,VariableTableValueView> :  RPSGridView<VariableTableEntityView,VariableTableValueView> where VariableTableEntityView : class, IView where VariableTableValueView : class, IView
    {
        public VariableTableByLangsGridView(VariableTableEntityView currentView,VariableTableValueView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            CodLanguage = RPSControlFactory.CreateRPSGridComboBox<VariableTableEntityView>("","#18f00545-de29-4707-9cc6-17283a9517c2 .ag-row[role='row']@ROWINDEX [col-id='cCodLanguage']","",true, this.CurrentView);
 
            Description = RPSControlFactory.CreateRPSGridTextBox<VariableTableEntityView>("","#18f00545-de29-4707-9cc6-17283a9517c2 .ag-row[role='row']@ROWINDEX [col-id='cDescription']","",false, this.CurrentView);
 

        }
        public IRPSGridComboBox<VariableTableEntityView> CodLanguage { get; set; } 
        public IRPSGridTextBox<VariableTableEntityView> Description { get; set; } 
                     
    }
 
    }
  
            
    public partial class VariableTableValueView : View
    {
        public VariableTableValueView(VariableTable screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            DeleteButton = RPSControlFactory.RPSDeleteButton<VariableTableValueView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<VariableTableValueView,VariableTableEntityView>( this,Screen.VariableTableEntityView);
 
            BackButton = RPSControlFactory.RPSBackButton<VariableTableValueView,VariableTableEntityView>( this,Screen.VariableTableEntityView);
 
            AcceptButton = RPSControlFactory.RPSAcceptButton<VariableTableValueView,VariableTableEntityView>( this,Screen.VariableTableEntityView);
 
            Value = RPSControlFactory.CreateRPSTextBox<VariableTableValueView>("f3551329-2da7-406c-ae2c-b69e2e8141b3","","",true, this);
 

        }
        public IRPSButton<VariableTableValueView> DeleteButton { get; set; } 
        public IRPSButton<VariableTableValueView,VariableTableEntityView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<VariableTableValueView,VariableTableEntityView> BackButton { get; set; } 
        public IRPSAcceptButton<VariableTableValueView,VariableTableEntityView> AcceptButton { get; set; } 
        public IRPSTextBox<VariableTableValueView> Value { get; set; } 
        public VariableTable Screen { get; set; }
        public VariableTableValueView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class VariableTableByLangView : View
    {
        public VariableTableByLangView(VariableTable screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            DeleteButton = RPSControlFactory.RPSDeleteButton<VariableTableByLangView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<VariableTableByLangView,VariableTableEntityView>( this,Screen.VariableTableEntityView);
 
            BackButton = RPSControlFactory.RPSBackButton<VariableTableByLangView,VariableTableEntityView>( this,Screen.VariableTableEntityView);
 
            AcceptButton = RPSControlFactory.RPSAcceptButton<VariableTableByLangView,VariableTableEntityView>( this,Screen.VariableTableEntityView);
 
            CodLanguage = RPSControlFactory.CreateRPSComboBox<VariableTableByLangView>("2dad7477-54d3-460d-ade5-5e178e49f1d9","","",true, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<VariableTableByLangView>("afcaceaa-cb2c-4cc0-ae07-99c981e13ab9","","",false, this);
 

        }
        public IRPSButton<VariableTableByLangView> DeleteButton { get; set; } 
        public IRPSButton<VariableTableByLangView,VariableTableEntityView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<VariableTableByLangView,VariableTableEntityView> BackButton { get; set; } 
        public IRPSAcceptButton<VariableTableByLangView,VariableTableEntityView> AcceptButton { get; set; } 
        public IRPSComboBox<VariableTableByLangView> CodLanguage { get; set; } 
        public IRPSTextBox<VariableTableByLangView> Description { get; set; } 
        public VariableTable Screen { get; set; }
        public VariableTableByLangView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}