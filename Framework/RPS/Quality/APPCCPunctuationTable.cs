    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.Quality.APPCCPunctuationTable
{
    //RPS VERSION 1.0.0.0
    public partial class APPCCPunctuationTable:Screen
    {
        public APPCCPunctuationTable():base()
        {
            this.URL = "quality.appccpunctuationtable";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            APPCCPunctuationTableVMQueryView  = new APPCCPunctuationTableVMQueryView(this); 
            APPCCPunctuationTableVMEntityView  = new APPCCPunctuationTableVMEntityView(this); 
            APPCCPunctuationTableVMQueryView.InitializeControls(); 
            APPCCPunctuationTableVMEntityView.InitializeControls(); 
           
        }
      
            public APPCCPunctuationTableVMQueryView APPCCPunctuationTableVMQueryView {get; set; } 
            public APPCCPunctuationTableVMEntityView APPCCPunctuationTableVMEntityView {get; set; } 
    }
            
    public partial class APPCCPunctuationTableVMQueryView : View
    {
        public APPCCPunctuationTableVMQueryView(APPCCPunctuationTable screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            NewButton = RPSControlFactory.RPSNewButton<APPCCPunctuationTableVMQueryView,APPCCPunctuationTableVMEntityView>( this,Screen.APPCCPunctuationTableVMEntityView);
 
            ConsultButton = RPSControlFactory.RPSConsultButton<APPCCPunctuationTableVMQueryView>( this);
 
            CollectionInit params_APPCCPunctuationTableQuery = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="4bd00497-2444-4d01-8d2e-81f3f0bd1c84",CSSSelectorGrid="",XPathGrid=""};
            APPCCPunctuationTableQuery = RPSControlFactory.RPSCreateCollectionWithGrid<APPCCPunctuationTableQueryCollectionEditor<APPCCPunctuationTableVMQueryView,APPCCPunctuationTableVMEntityView>,APPCCPunctuationTableVMQueryView,APPCCPunctuationTableVMEntityView>( params_APPCCPunctuationTableQuery,this,Screen.APPCCPunctuationTableVMEntityView);
 

        }
        public IRPSButton<APPCCPunctuationTableVMQueryView,APPCCPunctuationTableVMEntityView> NewButton { get; set; } 
        public IRPSButton<APPCCPunctuationTableVMQueryView> ConsultButton { get; set; } 
        public APPCCPunctuationTableQueryCollectionEditor<APPCCPunctuationTableVMQueryView,APPCCPunctuationTableVMEntityView> APPCCPunctuationTableQuery { get; set; } 
        public APPCCPunctuationTable Screen { get; set; }
        public APPCCPunctuationTableVMQueryView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class APPCCPunctuationTableQueryCollectionEditor<APPCCPunctuationTableVMQueryView,APPCCPunctuationTableVMEntityView>:RPSCollectionEditor<APPCCPunctuationTableVMQueryView,APPCCPunctuationTableVMEntityView> where APPCCPunctuationTableVMQueryView : class, IView where APPCCPunctuationTableVMEntityView : class, IView
    {
        public  APPCCPunctuationTableQueryGridView<APPCCPunctuationTableVMQueryView,APPCCPunctuationTableVMEntityView> GridView {get;set;}
    }
    public partial class APPCCPunctuationTableQueryGridView <APPCCPunctuationTableVMQueryView,APPCCPunctuationTableVMEntityView> :  RPSGridView<APPCCPunctuationTableVMQueryView,APPCCPunctuationTableVMEntityView> where APPCCPunctuationTableVMQueryView : class, IView where APPCCPunctuationTableVMEntityView : class, IView
    {
        public APPCCPunctuationTableQueryGridView(APPCCPunctuationTableVMQueryView currentView,APPCCPunctuationTableVMEntityView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            APPCCPunctuationTable_Occurrence = RPSControlFactory.CreateRPSGridTextBox<APPCCPunctuationTableVMQueryView>("","#4bd00497-2444-4d01-8d2e-81f3f0bd1c84 .ag-row[role='row']@ROWINDEX [col-id='cAPPCCPunctuationTable_Occurrence']","",false, this.CurrentView);
 
            APPCCPunctuationTable_Severity = RPSControlFactory.CreateRPSGridTextBox<APPCCPunctuationTableVMQueryView>("","#4bd00497-2444-4d01-8d2e-81f3f0bd1c84 .ag-row[role='row']@ROWINDEX [col-id='cAPPCCPunctuationTable_Severity']","",false, this.CurrentView);
 
            APPCCPunctuationTable_Detection = RPSControlFactory.CreateRPSGridTextBox<APPCCPunctuationTableVMQueryView>("","#4bd00497-2444-4d01-8d2e-81f3f0bd1c84 .ag-row[role='row']@ROWINDEX [col-id='cAPPCCPunctuationTable_Detection']","",false, this.CurrentView);
 
            APPCCPunctuationTable_Punctuation = RPSControlFactory.CreateRPSGridTextBox<APPCCPunctuationTableVMQueryView>("","#4bd00497-2444-4d01-8d2e-81f3f0bd1c84 .ag-row[role='row']@ROWINDEX [col-id='cAPPCCPunctuationTable_Punctuation']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<APPCCPunctuationTableVMQueryView> APPCCPunctuationTable_Occurrence { get; set; } 
        public IRPSGridTextBox<APPCCPunctuationTableVMQueryView> APPCCPunctuationTable_Severity { get; set; } 
        public IRPSGridTextBox<APPCCPunctuationTableVMQueryView> APPCCPunctuationTable_Detection { get; set; } 
        public IRPSGridTextBox<APPCCPunctuationTableVMQueryView> APPCCPunctuationTable_Punctuation { get; set; } 
                     
    }
 
    }
  
            
    public partial class APPCCPunctuationTableVMEntityView : View
    {
        public APPCCPunctuationTableVMEntityView(APPCCPunctuationTable screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            SaveButton = RPSControlFactory.RPSSaveButton<APPCCPunctuationTableVMEntityView>( this);
 
            DeleteButton = RPSControlFactory.RPSDeleteButton<APPCCPunctuationTableVMEntityView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<APPCCPunctuationTableVMEntityView,APPCCPunctuationTableVMQueryView>( this,Screen.APPCCPunctuationTableVMQueryView);
 
            BackButton = RPSControlFactory.RPSBackButton<APPCCPunctuationTableVMEntityView,APPCCPunctuationTableVMQueryView>( this,Screen.APPCCPunctuationTableVMQueryView);
 
            Occurrence = RPSControlFactory.CreateRPSEnumComboBox<APPCCPunctuationTableVMEntityView>("532a0513-475c-437f-9abd-6a2ac635d419","","",true, this);
 
            Severity = RPSControlFactory.CreateRPSEnumComboBox<APPCCPunctuationTableVMEntityView>("cc9106b7-73f5-4678-8dcf-41b671c49554","","",true, this);
 
            Detection = RPSControlFactory.CreateRPSEnumComboBox<APPCCPunctuationTableVMEntityView>("d613bc7f-19bc-4083-ab17-0e2a67cc5b9e","","",true, this);
 
            Punctuation = RPSControlFactory.CreateRPSEnumComboBox<APPCCPunctuationTableVMEntityView>("3b794794-54d5-48e8-8b71-e6c9b6c79ec8","","",true, this);
 

        }
        public IRPSSaveButton<APPCCPunctuationTableVMEntityView> SaveButton { get; set; } 
        public IRPSButton<APPCCPunctuationTableVMEntityView> DeleteButton { get; set; } 
        public IRPSButton<APPCCPunctuationTableVMEntityView,APPCCPunctuationTableVMQueryView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<APPCCPunctuationTableVMEntityView,APPCCPunctuationTableVMQueryView> BackButton { get; set; } 
        public IRPSComboBox<APPCCPunctuationTableVMEntityView> Occurrence { get; set; } 
        public IRPSComboBox<APPCCPunctuationTableVMEntityView> Severity { get; set; } 
        public IRPSComboBox<APPCCPunctuationTableVMEntityView> Detection { get; set; } 
        public IRPSComboBox<APPCCPunctuationTableVMEntityView> Punctuation { get; set; } 
        public APPCCPunctuationTable Screen { get; set; }
        public APPCCPunctuationTableVMEntityView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}