    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.Quality.DocumentRevisionFlow
{
    //RPS VERSION 1.0.0.0
    public partial class DocumentRevisionFlow:Screen
    {
        public DocumentRevisionFlow():base()
        {
            this.URL = "quality.documentrevisionflow";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            DocumentRevisionFlowVMCollectionView  = new DocumentRevisionFlowVMCollectionView(this); 
            DocumentRevisionFlowVMEntityView  = new DocumentRevisionFlowVMEntityView(this); 
            DocumentRevisionFlowVMCollectionView.InitializeControls(); 
            DocumentRevisionFlowVMEntityView.InitializeControls(); 
           
        }
      
            public DocumentRevisionFlowVMCollectionView DocumentRevisionFlowVMCollectionView {get; set; } 
            public DocumentRevisionFlowVMEntityView DocumentRevisionFlowVMEntityView {get; set; } 
    }
            
    public partial class DocumentRevisionFlowVMCollectionView : View
    {
        public DocumentRevisionFlowVMCollectionView(DocumentRevisionFlow screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            IDDocTypeApprovedNew = RPSControlFactory.CreateRPSComboBox<DocumentRevisionFlowVMCollectionView>("e2667b4c-4ade-47b8-a9e4-f2d8e0525a30","","",false, this);
 
            CollectionInit params_DocumentRevisionFlowQuery = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="6c78c6ae-5335-4b85-a9f5-01baace267a9",CSSSelectorGrid="",XPathGrid=""};
            DocumentRevisionFlowQuery = RPSControlFactory.RPSCreateCollectionWithGrid<DocumentRevisionFlowQueryCollectionEditor<DocumentRevisionFlowVMCollectionView,DocumentRevisionFlowVMEntityView>,DocumentRevisionFlowVMCollectionView,DocumentRevisionFlowVMEntityView>( params_DocumentRevisionFlowQuery,this,Screen.DocumentRevisionFlowVMEntityView);
 

        }
        public IRPSComboBox<DocumentRevisionFlowVMCollectionView> IDDocTypeApprovedNew { get; set; } 
        public DocumentRevisionFlowQueryCollectionEditor<DocumentRevisionFlowVMCollectionView,DocumentRevisionFlowVMEntityView> DocumentRevisionFlowQuery { get; set; } 
        public DocumentRevisionFlow Screen { get; set; }
        public DocumentRevisionFlowVMCollectionView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class DocumentRevisionFlowQueryCollectionEditor<DocumentRevisionFlowVMCollectionView,DocumentRevisionFlowVMEntityView>:RPSCollectionEditor<DocumentRevisionFlowVMCollectionView,DocumentRevisionFlowVMEntityView> where DocumentRevisionFlowVMCollectionView : class, IView where DocumentRevisionFlowVMEntityView : class, IView
    {
        public  DocumentRevisionFlowQueryGridView<DocumentRevisionFlowVMCollectionView,DocumentRevisionFlowVMEntityView> GridView {get;set;}
    }
    public partial class DocumentRevisionFlowQueryGridView <DocumentRevisionFlowVMCollectionView,DocumentRevisionFlowVMEntityView> :  RPSGridView<DocumentRevisionFlowVMCollectionView,DocumentRevisionFlowVMEntityView> where DocumentRevisionFlowVMCollectionView : class, IView where DocumentRevisionFlowVMEntityView : class, IView
    {
        public DocumentRevisionFlowQueryGridView(DocumentRevisionFlowVMCollectionView currentView,DocumentRevisionFlowVMEntityView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            IDDocTypeApproved = RPSControlFactory.CreateRPSGridComboBox<DocumentRevisionFlowVMCollectionView>("","#6c78c6ae-5335-4b85-a9f5-01baace267a9 .ag-row[role='row']@ROWINDEX [col-id='cIDDocTypeApproved']","",true, this.CurrentView);
 
            IDDocTypeToRevise = RPSControlFactory.CreateRPSGridComboBox<DocumentRevisionFlowVMCollectionView>("","#6c78c6ae-5335-4b85-a9f5-01baace267a9 .ag-row[role='row']@ROWINDEX [col-id='cIDDocTypeToRevise']","",true, this.CurrentView);
 
            ReviseReason = RPSControlFactory.CreateRPSGridTextBox<DocumentRevisionFlowVMCollectionView>("","#6c78c6ae-5335-4b85-a9f5-01baace267a9 .ag-row[role='row']@ROWINDEX [col-id='cReviseReason']","",false, this.CurrentView);
 

        }
        public IRPSGridComboBox<DocumentRevisionFlowVMCollectionView> IDDocTypeApproved { get; set; } 
        public IRPSGridComboBox<DocumentRevisionFlowVMCollectionView> IDDocTypeToRevise { get; set; } 
        public IRPSGridTextBox<DocumentRevisionFlowVMCollectionView> ReviseReason { get; set; } 
                     
    }
 
    }
  
            
    public partial class DocumentRevisionFlowVMEntityView : View
    {
        public DocumentRevisionFlowVMEntityView(DocumentRevisionFlow screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            DeleteButton = RPSControlFactory.RPSDeleteButton<DocumentRevisionFlowVMEntityView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<DocumentRevisionFlowVMEntityView,DocumentRevisionFlowVMCollectionView>( this,Screen.DocumentRevisionFlowVMCollectionView);
 
            BackButton = RPSControlFactory.RPSBackButton<DocumentRevisionFlowVMEntityView,DocumentRevisionFlowVMCollectionView>( this,Screen.DocumentRevisionFlowVMCollectionView);
 
            AcceptButton = RPSControlFactory.RPSAcceptButton<DocumentRevisionFlowVMEntityView,DocumentRevisionFlowVMCollectionView>( this,Screen.DocumentRevisionFlowVMCollectionView);
 
            IDDocTypeApprovedNew = RPSControlFactory.CreateRPSComboBox<DocumentRevisionFlowVMEntityView>("d77f1f4c-b9c2-459a-8e28-3eb38577d1e5","","",true, this);
 
            IDDocTypeApproved = RPSControlFactory.CreateRPSComboBox<DocumentRevisionFlowVMEntityView>("dc2e4b63-7364-49d5-b26e-c86523d50ba0","","",true, this);
 
            IDDocTypeToRevise = RPSControlFactory.CreateRPSComboBox<DocumentRevisionFlowVMEntityView>("ff0ec5a2-b6eb-4dc1-bb78-18d77b80337a","","",true, this);
 
            ReviseReason = RPSControlFactory.CreateRPSTextBox<DocumentRevisionFlowVMEntityView>("5b9d5476-f208-4b1a-b22d-cd2314325e34","","",false, this);
 

        }
        public IRPSButton<DocumentRevisionFlowVMEntityView> DeleteButton { get; set; } 
        public IRPSButton<DocumentRevisionFlowVMEntityView,DocumentRevisionFlowVMCollectionView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<DocumentRevisionFlowVMEntityView,DocumentRevisionFlowVMCollectionView> BackButton { get; set; } 
        public IRPSAcceptButton<DocumentRevisionFlowVMEntityView,DocumentRevisionFlowVMCollectionView> AcceptButton { get; set; } 
        public IRPSComboBox<DocumentRevisionFlowVMEntityView> IDDocTypeApprovedNew { get; set; } 
        public IRPSComboBox<DocumentRevisionFlowVMEntityView> IDDocTypeApproved { get; set; } 
        public IRPSComboBox<DocumentRevisionFlowVMEntityView> IDDocTypeToRevise { get; set; } 
        public IRPSTextBox<DocumentRevisionFlowVMEntityView> ReviseReason { get; set; } 
        public DocumentRevisionFlow Screen { get; set; }
        public DocumentRevisionFlowVMEntityView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}