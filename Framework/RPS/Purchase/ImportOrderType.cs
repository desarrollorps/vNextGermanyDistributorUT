    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.Purchase.ImportOrderType
{
    //RPS VERSION 1.0.0.0
    public partial class ImportOrderType:Screen
    {
        public ImportOrderType():base()
        {
            this.URL = "purchase.importordertype";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            ImportOrderTypeCollectionView  = new ImportOrderTypeCollectionView(this); 
            ImportOrderTypeEntityView  = new ImportOrderTypeEntityView(this); 
            ImportOrderTypeDetailView  = new ImportOrderTypeDetailView(this); 
            ImportOrderTypeCollectionView.InitializeControls(); 
            ImportOrderTypeEntityView.InitializeControls(); 
            ImportOrderTypeDetailView.InitializeControls(); 
           
        }
      
            public ImportOrderTypeCollectionView ImportOrderTypeCollectionView {get; set; } 
            public ImportOrderTypeEntityView ImportOrderTypeEntityView {get; set; } 
            public ImportOrderTypeDetailView ImportOrderTypeDetailView {get; set; } 
    }
            
    public partial class ImportOrderTypeCollectionView : View
    {
        public ImportOrderTypeCollectionView(ImportOrderType screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            NewButton = RPSControlFactory.RPSNewButton<ImportOrderTypeCollectionView,ImportOrderTypeEntityView>( this,Screen.ImportOrderTypeEntityView);
 
            CollectionInit params_MainConsult = new CollectionInit(){IDDescriptor = "dfd7ed35-2d5a-45ac-9835-3a98088dfbdf",CSSSelectorDescriptor = "",XPathDescriptor = ""};
            MainConsult = RPSControlFactory.RPSCreateCollection<ImportOrderTypeCollectionView,ImportOrderTypeEntityView>( params_MainConsult,this,Screen.ImportOrderTypeEntityView);
 

        }
        public IRPSButton<ImportOrderTypeCollectionView,ImportOrderTypeEntityView> NewButton { get; set; } 
        public IRPSCollectionEditor<ImportOrderTypeCollectionView,ImportOrderTypeEntityView> MainConsult { get; set; } 
        public ImportOrderType Screen { get; set; }
        public ImportOrderTypeCollectionView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class ImportOrderTypeEntityView : View
    {
        public ImportOrderTypeEntityView(ImportOrderType screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            SaveButton = RPSControlFactory.RPSSaveButton<ImportOrderTypeEntityView>( this);
 
            DeleteButton = RPSControlFactory.RPSDeleteButton<ImportOrderTypeEntityView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<ImportOrderTypeEntityView,ImportOrderTypeCollectionView>( this,Screen.ImportOrderTypeCollectionView);
 
            BackButton = RPSControlFactory.RPSBackButton<ImportOrderTypeEntityView,ImportOrderTypeCollectionView>( this,Screen.ImportOrderTypeCollectionView);
 
            CodImportOrderType = RPSControlFactory.CreateRPSTextBox<ImportOrderTypeEntityView>("f5b71a27-02e2-429d-86b4-56cb6b868647","","",true, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<ImportOrderTypeEntityView>("018ef6c8-e230-4e19-9a3b-ac4a2ffa318d","","",false, this);
 
            CollectionInit params_ImportOrderTypeDetails = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="da5d1425-2f7b-47d0-aa02-ae6332c59dac",CSSSelectorGrid="",XPathGrid=""};
            ImportOrderTypeDetails = RPSControlFactory.RPSCreateCollectionWithGrid<ImportOrderTypeDetailsCollectionEditor<ImportOrderTypeEntityView,ImportOrderTypeDetailView>,ImportOrderTypeEntityView,ImportOrderTypeDetailView>( params_ImportOrderTypeDetails,this,Screen.ImportOrderTypeDetailView);
 

        }
        public IRPSSaveButton<ImportOrderTypeEntityView> SaveButton { get; set; } 
        public IRPSButton<ImportOrderTypeEntityView> DeleteButton { get; set; } 
        public IRPSButton<ImportOrderTypeEntityView,ImportOrderTypeCollectionView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<ImportOrderTypeEntityView,ImportOrderTypeCollectionView> BackButton { get; set; } 
        public IRPSTextBox<ImportOrderTypeEntityView> CodImportOrderType { get; set; } 
        public IRPSTextBox<ImportOrderTypeEntityView> Description { get; set; } 
        public ImportOrderTypeDetailsCollectionEditor<ImportOrderTypeEntityView,ImportOrderTypeDetailView> ImportOrderTypeDetails { get; set; } 
        public ImportOrderType Screen { get; set; }
        public ImportOrderTypeEntityView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class ImportOrderTypeDetailsCollectionEditor<ImportOrderTypeEntityView,ImportOrderTypeDetailView>:RPSCollectionEditor<ImportOrderTypeEntityView,ImportOrderTypeDetailView> where ImportOrderTypeEntityView : class, IView where ImportOrderTypeDetailView : class, IView
    {
        public  ImportOrderTypeDetailsGridView<ImportOrderTypeEntityView,ImportOrderTypeDetailView> GridView {get;set;}
    }
    public partial class ImportOrderTypeDetailsGridView <ImportOrderTypeEntityView,ImportOrderTypeDetailView> :  RPSGridView<ImportOrderTypeEntityView,ImportOrderTypeDetailView> where ImportOrderTypeEntityView : class, IView where ImportOrderTypeDetailView : class, IView
    {
        public ImportOrderTypeDetailsGridView(ImportOrderTypeEntityView currentView,ImportOrderTypeDetailView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            NumDetail = RPSControlFactory.CreateRPSGridFormattedTextBox<ImportOrderTypeEntityView>("","#da5d1425-2f7b-47d0-aa02-ae6332c59dac .ag-row[role='row']@ROWINDEX [col-id='cNumDetail']","",true, this.CurrentView);
 
            IDImportDocumentType = RPSControlFactory.CreateRPSGridComboBox<ImportOrderTypeEntityView>("","#da5d1425-2f7b-47d0-aa02-ae6332c59dac .ag-row[role='row']@ROWINDEX [col-id='cIDImportDocumentType']","",true, this.CurrentView);
 
            Obligatory = RPSControlFactory.CreateRPSGridCheckBox<ImportOrderTypeEntityView>("","#da5d1425-2f7b-47d0-aa02-ae6332c59dac .ag-row[role='row']@ROWINDEX [col-id='cObligatory']","",true, this.CurrentView);
 

        }
        public IRPSGridTextBox<ImportOrderTypeEntityView> NumDetail { get; set; } 
        public IRPSGridComboBox<ImportOrderTypeEntityView> IDImportDocumentType { get; set; } 
        public IRPSGridCheckbox<ImportOrderTypeEntityView> Obligatory { get; set; } 
                     
    }
 
    }
  
            
    public partial class ImportOrderTypeDetailView : View
    {
        public ImportOrderTypeDetailView(ImportOrderType screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            DeleteButton = RPSControlFactory.RPSDeleteButton<ImportOrderTypeDetailView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<ImportOrderTypeDetailView,ImportOrderTypeEntityView>( this,Screen.ImportOrderTypeEntityView);
 
            BackButton = RPSControlFactory.RPSBackButton<ImportOrderTypeDetailView,ImportOrderTypeEntityView>( this,Screen.ImportOrderTypeEntityView);
 
            AcceptButton = RPSControlFactory.RPSAcceptButton<ImportOrderTypeDetailView,ImportOrderTypeEntityView>( this,Screen.ImportOrderTypeEntityView);
 
            NumDetail = RPSControlFactory.CreateRPSFormattedTextBox<ImportOrderTypeDetailView>("24ee992d-d7ae-4faf-a93e-a66683406cd1","","",true, this);
 
            IDImportDocumentType = RPSControlFactory.CreateRPSComboBox<ImportOrderTypeDetailView>("393ebbac-53bd-42b9-8bd9-1297e3c51650","","",true, this);
 
            Obligatory = RPSControlFactory.CreateRPSCheckBox<ImportOrderTypeDetailView>("bc5d529a-859c-4714-9970-ac26fda64c65","","",true, this);
 

        }
        public IRPSButton<ImportOrderTypeDetailView> DeleteButton { get; set; } 
        public IRPSButton<ImportOrderTypeDetailView,ImportOrderTypeEntityView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<ImportOrderTypeDetailView,ImportOrderTypeEntityView> BackButton { get; set; } 
        public IRPSAcceptButton<ImportOrderTypeDetailView,ImportOrderTypeEntityView> AcceptButton { get; set; } 
        public IRPSTextBox<ImportOrderTypeDetailView> NumDetail { get; set; } 
        public IRPSComboBox<ImportOrderTypeDetailView> IDImportDocumentType { get; set; } 
        public IRPSCheckbox<ImportOrderTypeDetailView> Obligatory { get; set; } 
        public ImportOrderType Screen { get; set; }
        public ImportOrderTypeDetailView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}