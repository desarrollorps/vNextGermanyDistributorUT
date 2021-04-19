    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.Documents.DocumentsSearchByRelatedEntity
{
    //RPS VERSION 1.0.0.0
    public partial class DocumentsSearchByRelatedEntity:Screen
    {
        public DocumentsSearchByRelatedEntity():base()
        {
            this.URL = "documents.documentssearchbyrelatedentity";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            DocumentsSearchByRelatedEntityQueryView  = new DocumentsSearchByRelatedEntityQueryView(this); 
            PackFileWizardDialogView  = new PackFileWizardDialogView(this); 
            DocumentsSearchByRelatedEntityQueryView.InitializeControls(); 
            PackFileWizardDialogView.InitializeControls(); 
           
        }
      
            public DocumentsSearchByRelatedEntityQueryView DocumentsSearchByRelatedEntityQueryView {get; set; } 
            public PackFileWizardDialogView PackFileWizardDialogView {get; set; } 
    }
            
    public partial class DocumentsSearchByRelatedEntityQueryView : View
    {
        public DocumentsSearchByRelatedEntityQueryView(DocumentsSearchByRelatedEntity screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            UIService = RPSControlFactory.CreateRPSEnumComboBox<DocumentsSearchByRelatedEntityQueryView>("35995164-9811-4c3c-bd62-e6a1d3bc473b","","",true, this);
 
            UIServiceEntity = RPSControlFactory.CreateRPSEnumComboBox<DocumentsSearchByRelatedEntityQueryView>("3806ee31-348d-4018-a70f-681556b98104","","",false, this);
 
            PackFileWizardNavigationCommandButton = RPSControlFactory.CreateRPSButtonToView<DocumentsSearchByRelatedEntityQueryView,PackFileWizardDialogView>("1242d60f-1e53-4815-9081-0daca0c6c1d0","","", this,Screen.PackFileWizardDialogView);
 
            CollectionInit params_DocumentsSearchByRelatedEntity = new CollectionInit(){IDDescriptor = "2b179754-fadb-48bd-b63c-9f9fe0f06204",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="6ef3a363-6876-4775-8e8a-dff5df9eaed4",CSSSelectorGrid="",XPathGrid=""};
            DocumentsSearchByRelatedEntity = RPSControlFactory.RPSCreateCollectionWithGrid<DocumentsSearchByRelatedEntityCollectionEditor<DocumentsSearchByRelatedEntityQueryView,PackFileWizardDialogView>,DocumentsSearchByRelatedEntityQueryView,PackFileWizardDialogView>( params_DocumentsSearchByRelatedEntity,this,Screen.PackFileWizardDialogView);
 

        }
        public IRPSComboBox<DocumentsSearchByRelatedEntityQueryView> UIService { get; set; } 
        public IRPSComboBox<DocumentsSearchByRelatedEntityQueryView> UIServiceEntity { get; set; } 
        public IRPSButton<DocumentsSearchByRelatedEntityQueryView,PackFileWizardDialogView> PackFileWizardNavigationCommandButton { get; set; } 
        public DocumentsSearchByRelatedEntityCollectionEditor<DocumentsSearchByRelatedEntityQueryView,PackFileWizardDialogView> DocumentsSearchByRelatedEntity { get; set; } 
        public DocumentsSearchByRelatedEntity Screen { get; set; }
        public DocumentsSearchByRelatedEntityQueryView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class DocumentsSearchByRelatedEntityCollectionEditor<DocumentsSearchByRelatedEntityQueryView,PackFileWizardDialogView>:RPSCollectionEditor<DocumentsSearchByRelatedEntityQueryView,PackFileWizardDialogView> where DocumentsSearchByRelatedEntityQueryView : class, IView where PackFileWizardDialogView : class, IView
    {
        public  DocumentsSearchByRelatedEntityGridView<DocumentsSearchByRelatedEntityQueryView,PackFileWizardDialogView> GridView {get;set;}
    }
    public partial class DocumentsSearchByRelatedEntityGridView <DocumentsSearchByRelatedEntityQueryView,PackFileWizardDialogView> :  RPSGridView<DocumentsSearchByRelatedEntityQueryView,PackFileWizardDialogView> where DocumentsSearchByRelatedEntityQueryView : class, IView where PackFileWizardDialogView : class, IView
    {
        public DocumentsSearchByRelatedEntityGridView(DocumentsSearchByRelatedEntityQueryView currentView,PackFileWizardDialogView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            Document_Version = RPSControlFactory.CreateRPSGridTextBox<DocumentsSearchByRelatedEntityQueryView>("","#6ef3a363-6876-4775-8e8a-dff5df9eaed4 .ag-row[role='row']@ROWINDEX [col-id='cDocument_Version']","",false, this.CurrentView);
 
            Document_RevisionNumber = RPSControlFactory.CreateRPSGridFormattedTextBox<DocumentsSearchByRelatedEntityQueryView>("","#6ef3a363-6876-4775-8e8a-dff5df9eaed4 .ag-row[role='row']@ROWINDEX [col-id='cDocument_RevisionNumber']","",false, this.CurrentView);
 
            Document_LastRevisionDate = RPSControlFactory.CreateRPSGridTextBox<DocumentsSearchByRelatedEntityQueryView>("","#6ef3a363-6876-4775-8e8a-dff5df9eaed4 .ag-row[role='row']@ROWINDEX [col-id='cDocument_LastRevisionDate']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<DocumentsSearchByRelatedEntityQueryView> Document_Version { get; set; } 
        public IRPSGridTextBox<DocumentsSearchByRelatedEntityQueryView> Document_RevisionNumber { get; set; } 
        public IRPSGridTextBox<DocumentsSearchByRelatedEntityQueryView> Document_LastRevisionDate { get; set; } 
                     
    }
 
    }
  
            
    public partial class PackFileWizardDialogView : View
    {
        public PackFileWizardDialogView(DocumentsSearchByRelatedEntity screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            PackFileOptions = RPSControlFactory.CreateRPSEnumComboBox<PackFileWizardDialogView>("3954ec2e-953b-4cbb-9b76-09426de8fa2a","","",false, this);
 
            DaysOfValidity = RPSControlFactory.CreateRPSFormattedTextBox<PackFileWizardDialogView>("693d317d-058c-4124-a10f-74199ccbdf03","","",false, this);
 
            PackFileComment = RPSControlFactory.CreateRPSTextBox<PackFileWizardDialogView>("3a32de61-1c28-4260-920f-9f819c32770b","","",false, this);
 
            IDPackFile = RPSControlFactory.CreateRPSComboBox<PackFileWizardDialogView>("52234013-a1c5-439b-9207-94becea42e66","","",false, this);
 
            PublishPackage = RPSControlFactory.CreateRPSCheckBox<PackFileWizardDialogView>("3d0dde5c-9a86-4aef-9966-956537b17d09","","",false, this);
 
            CollectionInit params_RPSUsers = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="232383a9-75b2-4d6f-aeb0-3c77d5441dbd",CSSSelectorGrid="",XPathGrid=""};
            RPSUsers = RPSControlFactory.RPSCreateCollectionWithGrid<RPSUsersCollectionEditor<PackFileWizardDialogView>,PackFileWizardDialogView>( params_RPSUsers,this);
 
            CollectionInit params_ExternalUsers = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="38aadb49-15b9-4883-a6a4-b6bf013abc09",CSSSelectorGrid="",XPathGrid=""};
            ExternalUsers = RPSControlFactory.RPSCreateCollectionWithGrid<ExternalUsersCollectionEditor<PackFileWizardDialogView>,PackFileWizardDialogView>( params_ExternalUsers,this);
 

        }
        public IRPSComboBox<PackFileWizardDialogView> PackFileOptions { get; set; } 
        public IRPSTextBox<PackFileWizardDialogView> DaysOfValidity { get; set; } 
        public IRPSTextBox<PackFileWizardDialogView> PackFileComment { get; set; } 
        public IRPSComboBox<PackFileWizardDialogView> IDPackFile { get; set; } 
        public IRPSCheckbox<PackFileWizardDialogView> PublishPackage { get; set; } 
        public RPSUsersCollectionEditor<PackFileWizardDialogView> RPSUsers { get; set; } 
        public ExternalUsersCollectionEditor<PackFileWizardDialogView> ExternalUsers { get; set; } 
        public DocumentsSearchByRelatedEntity Screen { get; set; }
        public PackFileWizardDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class RPSUsersCollectionEditor<PackFileWizardDialogView>:RPSCollectionEditor<PackFileWizardDialogView> where PackFileWizardDialogView : class, IView
    {
        public  RPSUsersGridView<PackFileWizardDialogView> GridView {get;set;}
    }
    public partial class RPSUsersGridView <PackFileWizardDialogView> :  RPSGridView<PackFileWizardDialogView> where PackFileWizardDialogView : class, IView
    {
        public RPSUsersGridView(PackFileWizardDialogView currentView)
        {
            this.WebDriver = currentView.WebDriver;          
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            CodUser = RPSControlFactory.CreateRPSGridComboBox<PackFileWizardDialogView>("","#232383a9-75b2-4d6f-aeb0-3c77d5441dbd .ag-row[role='row']@ROWINDEX [col-id='cCodUser']","",false, this.CurrentView);
 

        }
        public IRPSGridComboBox<PackFileWizardDialogView> CodUser { get; set; } 
                     
    }
 
        public partial class ExternalUsersCollectionEditor<PackFileWizardDialogView>:RPSCollectionEditor<PackFileWizardDialogView> where PackFileWizardDialogView : class, IView
    {
        public  ExternalUsersGridView<PackFileWizardDialogView> GridView {get;set;}
    }
    public partial class ExternalUsersGridView <PackFileWizardDialogView> :  RPSGridView<PackFileWizardDialogView> where PackFileWizardDialogView : class, IView
    {
        public ExternalUsersGridView(PackFileWizardDialogView currentView)
        {
            this.WebDriver = currentView.WebDriver;          
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            ExternalUserDescription = RPSControlFactory.CreateRPSGridTextBox<PackFileWizardDialogView>("","#38aadb49-15b9-4883-a6a4-b6bf013abc09 .ag-row[role='row']@ROWINDEX [col-id='cExternalUserDescription']","",false, this.CurrentView);
 
            ExternalUserEmailToInvite = RPSControlFactory.CreateRPSGridEmailTextBox<PackFileWizardDialogView>("","#38aadb49-15b9-4883-a6a4-b6bf013abc09 .ag-row[role='row']@ROWINDEX [col-id='cExternalUserEmailToInvite']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<PackFileWizardDialogView> ExternalUserDescription { get; set; } 
        public IRPSGridTextBox<PackFileWizardDialogView> ExternalUserEmailToInvite { get; set; } 
                     
    }
 
    }
  
    

}