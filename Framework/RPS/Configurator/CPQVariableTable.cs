    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.Configurator.CPQVariableTable
{
    //RPS VERSION 1.0.0.0
    public partial class CPQVariableTable:Screen
    {
        public CPQVariableTable():base()
        {
            this.URL = "configurator.cpqvariabletable";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            CPQVariableTableCollectionView  = new CPQVariableTableCollectionView(this); 
            CPQVariableTableEntityView  = new CPQVariableTableEntityView(this); 
            CPQVariableTableValueView  = new CPQVariableTableValueView(this); 
            CPQVariableTableValueByLangView  = new CPQVariableTableValueByLangView(this); 
            CPQVariableTableCollectionView.InitializeControls(); 
            CPQVariableTableEntityView.InitializeControls(); 
            CPQVariableTableValueView.InitializeControls(); 
            CPQVariableTableValueByLangView.InitializeControls(); 
           
        }
      
            public CPQVariableTableCollectionView CPQVariableTableCollectionView {get; set; } 
            public CPQVariableTableEntityView CPQVariableTableEntityView {get; set; } 
            public CPQVariableTableValueView CPQVariableTableValueView {get; set; } 
            public CPQVariableTableValueByLangView CPQVariableTableValueByLangView {get; set; } 
    }
            
    public partial class CPQVariableTableCollectionView : View
    {
        public CPQVariableTableCollectionView(CPQVariableTable screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            NewButton = RPSControlFactory.RPSNewButton<CPQVariableTableCollectionView,CPQVariableTableEntityView>( this,Screen.CPQVariableTableEntityView);
 
            CollectionInit params_MainConsult = new CollectionInit(){IDDescriptor = "6bd4494e-5b3b-4056-bc00-aec3378116a8",CSSSelectorDescriptor = "",XPathDescriptor = ""};
            MainConsult = RPSControlFactory.RPSCreateCollection<CPQVariableTableCollectionView,CPQVariableTableEntityView>( params_MainConsult,this,Screen.CPQVariableTableEntityView);
 

        }
        public IRPSButton<CPQVariableTableCollectionView,CPQVariableTableEntityView> NewButton { get; set; } 
        public IRPSCollectionEditor<CPQVariableTableCollectionView,CPQVariableTableEntityView> MainConsult { get; set; } 
        public CPQVariableTable Screen { get; set; }
        public CPQVariableTableCollectionView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class CPQVariableTableEntityView : View
    {
        public CPQVariableTableEntityView(CPQVariableTable screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            SaveButton = RPSControlFactory.RPSSaveButton<CPQVariableTableEntityView>( this);
 
            DeleteButton = RPSControlFactory.RPSDeleteButton<CPQVariableTableEntityView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<CPQVariableTableEntityView,CPQVariableTableCollectionView>( this,Screen.CPQVariableTableCollectionView);
 
            BackButton = RPSControlFactory.RPSBackButton<CPQVariableTableEntityView,CPQVariableTableCollectionView>( this,Screen.CPQVariableTableCollectionView);
 
            CodTable = RPSControlFactory.CreateRPSTextBox<CPQVariableTableEntityView>("69b3ca92-6fed-42f3-9d1d-a90f8ab46ece","","",true, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<CPQVariableTableEntityView>("07344955-05cb-4df7-addf-c849915ddb30","","",false, this);
 
            CollectionInit params_CPQVariableTableValues = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="c8d781df-ce3d-4e5b-b117-5ddb334689b8",CSSSelectorGrid="",XPathGrid=""};
            CPQVariableTableValues = RPSControlFactory.RPSCreateCollectionWithGrid<CPQVariableTableValuesCollectionEditor<CPQVariableTableEntityView,CPQVariableTableValueView>,CPQVariableTableEntityView,CPQVariableTableValueView>( params_CPQVariableTableValues,this,Screen.CPQVariableTableValueView);
 

        }
        public IRPSSaveButton<CPQVariableTableEntityView> SaveButton { get; set; } 
        public IRPSButton<CPQVariableTableEntityView> DeleteButton { get; set; } 
        public IRPSButton<CPQVariableTableEntityView,CPQVariableTableCollectionView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<CPQVariableTableEntityView,CPQVariableTableCollectionView> BackButton { get; set; } 
        public IRPSTextBox<CPQVariableTableEntityView> CodTable { get; set; } 
        public IRPSTextBox<CPQVariableTableEntityView> Description { get; set; } 
        public CPQVariableTableValuesCollectionEditor<CPQVariableTableEntityView,CPQVariableTableValueView> CPQVariableTableValues { get; set; } 
        public CPQVariableTable Screen { get; set; }
        public CPQVariableTableEntityView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class CPQVariableTableValuesCollectionEditor<CPQVariableTableEntityView,CPQVariableTableValueView>:RPSCollectionEditor<CPQVariableTableEntityView,CPQVariableTableValueView> where CPQVariableTableEntityView : class, IView where CPQVariableTableValueView : class, IView
    {
        public  CPQVariableTableValuesGridView<CPQVariableTableEntityView,CPQVariableTableValueView> GridView {get;set;}
    }
    public partial class CPQVariableTableValuesGridView <CPQVariableTableEntityView,CPQVariableTableValueView> :  RPSGridView<CPQVariableTableEntityView,CPQVariableTableValueView> where CPQVariableTableEntityView : class, IView where CPQVariableTableValueView : class, IView
    {
        public CPQVariableTableValuesGridView(CPQVariableTableEntityView currentView,CPQVariableTableValueView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            Value = RPSControlFactory.CreateRPSGridTextBox<CPQVariableTableEntityView>("","#c8d781df-ce3d-4e5b-b117-5ddb334689b8 .ag-row[role='row']@ROWINDEX [col-id='cValue']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<CPQVariableTableEntityView> Value { get; set; } 
                     
    }
 
    }
  
            
    public partial class CPQVariableTableValueView : View
    {
        public CPQVariableTableValueView(CPQVariableTable screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            DeleteButton = RPSControlFactory.RPSDeleteButton<CPQVariableTableValueView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<CPQVariableTableValueView,CPQVariableTableEntityView>( this,Screen.CPQVariableTableEntityView);
 
            BackButton = RPSControlFactory.RPSBackButton<CPQVariableTableValueView,CPQVariableTableEntityView>( this,Screen.CPQVariableTableEntityView);
 
            AcceptButton = RPSControlFactory.RPSAcceptButton<CPQVariableTableValueView,CPQVariableTableEntityView>( this,Screen.CPQVariableTableEntityView);
 
            Value = RPSControlFactory.CreateRPSTextBox<CPQVariableTableValueView>("6967e67e-3ea2-4c98-818a-0ce8f70b725b","","",false, this);
 
            CollectionInit params_CPQVariableTableValueByLangs = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="8fd9a2a9-04db-4727-958f-057cee26fcc9",CSSSelectorGrid="",XPathGrid=""};
            CPQVariableTableValueByLangs = RPSControlFactory.RPSCreateCollectionWithGrid<CPQVariableTableValueByLangsCollectionEditor<CPQVariableTableValueView,CPQVariableTableValueByLangView>,CPQVariableTableValueView,CPQVariableTableValueByLangView>( params_CPQVariableTableValueByLangs,this,Screen.CPQVariableTableValueByLangView);
 

        }
        public IRPSButton<CPQVariableTableValueView> DeleteButton { get; set; } 
        public IRPSButton<CPQVariableTableValueView,CPQVariableTableEntityView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<CPQVariableTableValueView,CPQVariableTableEntityView> BackButton { get; set; } 
        public IRPSAcceptButton<CPQVariableTableValueView,CPQVariableTableEntityView> AcceptButton { get; set; } 
        public IRPSTextBox<CPQVariableTableValueView> Value { get; set; } 
        public CPQVariableTableValueByLangsCollectionEditor<CPQVariableTableValueView,CPQVariableTableValueByLangView> CPQVariableTableValueByLangs { get; set; } 
        public CPQVariableTable Screen { get; set; }
        public CPQVariableTableValueView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class CPQVariableTableValueByLangsCollectionEditor<CPQVariableTableValueView,CPQVariableTableValueByLangView>:RPSCollectionEditor<CPQVariableTableValueView,CPQVariableTableValueByLangView> where CPQVariableTableValueView : class, IView where CPQVariableTableValueByLangView : class, IView
    {
        public  CPQVariableTableValueByLangsGridView<CPQVariableTableValueView,CPQVariableTableValueByLangView> GridView {get;set;}
    }
    public partial class CPQVariableTableValueByLangsGridView <CPQVariableTableValueView,CPQVariableTableValueByLangView> :  RPSGridView<CPQVariableTableValueView,CPQVariableTableValueByLangView> where CPQVariableTableValueView : class, IView where CPQVariableTableValueByLangView : class, IView
    {
        public CPQVariableTableValueByLangsGridView(CPQVariableTableValueView currentView,CPQVariableTableValueByLangView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            CodLanguage = RPSControlFactory.CreateRPSGridComboBox<CPQVariableTableValueView>("","#8fd9a2a9-04db-4727-958f-057cee26fcc9 .ag-row[role='row']@ROWINDEX [col-id='cCodLanguage']","",true, this.CurrentView);
 
            Value = RPSControlFactory.CreateRPSGridTextBox<CPQVariableTableValueView>("","#8fd9a2a9-04db-4727-958f-057cee26fcc9 .ag-row[role='row']@ROWINDEX [col-id='cValue']","",false, this.CurrentView);
 

        }
        public IRPSGridComboBox<CPQVariableTableValueView> CodLanguage { get; set; } 
        public IRPSGridTextBox<CPQVariableTableValueView> Value { get; set; } 
                     
    }
 
    }
  
            
    public partial class CPQVariableTableValueByLangView : View
    {
        public CPQVariableTableValueByLangView(CPQVariableTable screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            DeleteButton = RPSControlFactory.RPSDeleteButton<CPQVariableTableValueByLangView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<CPQVariableTableValueByLangView,CPQVariableTableValueView>( this,Screen.CPQVariableTableValueView);
 
            BackButton = RPSControlFactory.RPSBackButton<CPQVariableTableValueByLangView,CPQVariableTableValueView>( this,Screen.CPQVariableTableValueView);
 
            AcceptButton = RPSControlFactory.RPSAcceptButton<CPQVariableTableValueByLangView,CPQVariableTableValueView>( this,Screen.CPQVariableTableValueView);
 
            CodLanguage = RPSControlFactory.CreateRPSComboBox<CPQVariableTableValueByLangView>("1dc5567a-4c0c-47e1-87dc-ed3896750280","","",true, this);
 
            Value = RPSControlFactory.CreateRPSTextBox<CPQVariableTableValueByLangView>("62d3ec84-137a-4eb2-a0d1-4277fe1b99ce","","",false, this);
 

        }
        public IRPSButton<CPQVariableTableValueByLangView> DeleteButton { get; set; } 
        public IRPSButton<CPQVariableTableValueByLangView,CPQVariableTableValueView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<CPQVariableTableValueByLangView,CPQVariableTableValueView> BackButton { get; set; } 
        public IRPSAcceptButton<CPQVariableTableValueByLangView,CPQVariableTableValueView> AcceptButton { get; set; } 
        public IRPSComboBox<CPQVariableTableValueByLangView> CodLanguage { get; set; } 
        public IRPSTextBox<CPQVariableTableValueByLangView> Value { get; set; } 
        public CPQVariableTable Screen { get; set; }
        public CPQVariableTableValueByLangView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}