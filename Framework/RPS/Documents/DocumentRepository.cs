    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.Documents.DocumentRepository
{
    //RPS VERSION 1.0.0.0
    public partial class DocumentRepository:Screen
    {
        public DocumentRepository():base()
        {
            this.URL = "documents.documentrepository";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            DocumentRepositoryCollectionView  = new DocumentRepositoryCollectionView(this); 
            DocumentRepositoryEntityView  = new DocumentRepositoryEntityView(this); 
            DocumentRepositoryRestoreDocumentsDialogView  = new DocumentRepositoryRestoreDocumentsDialogView(this); 
            DocumentTypeAutomationView  = new DocumentTypeAutomationView(this); 
            DocumentRepositoryCollectionView.InitializeControls(); 
            DocumentRepositoryEntityView.InitializeControls(); 
            DocumentRepositoryRestoreDocumentsDialogView.InitializeControls(); 
            DocumentTypeAutomationView.InitializeControls(); 
           
        }
      
            public DocumentRepositoryCollectionView DocumentRepositoryCollectionView {get; set; } 
            public DocumentRepositoryEntityView DocumentRepositoryEntityView {get; set; } 
            public DocumentRepositoryRestoreDocumentsDialogView DocumentRepositoryRestoreDocumentsDialogView {get; set; } 
            public DocumentTypeAutomationView DocumentTypeAutomationView {get; set; } 
    }
            
    public partial class DocumentRepositoryCollectionView : View
    {
        public DocumentRepositoryCollectionView(DocumentRepository screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            NewButton = RPSControlFactory.RPSNewButton<DocumentRepositoryCollectionView,DocumentRepositoryEntityView>( this,Screen.DocumentRepositoryEntityView);
 
            CollectionInit params_MainConsult = new CollectionInit(){IDDescriptor = "ee1cd077-433c-400c-b824-a1637528d10a",CSSSelectorDescriptor = "",XPathDescriptor = ""};
            MainConsult = RPSControlFactory.RPSCreateCollection<DocumentRepositoryCollectionView,DocumentRepositoryEntityView>( params_MainConsult,this,Screen.DocumentRepositoryEntityView);
 

        }
        public IRPSButton<DocumentRepositoryCollectionView,DocumentRepositoryEntityView> NewButton { get; set; } 
        public IRPSCollectionEditor<DocumentRepositoryCollectionView,DocumentRepositoryEntityView> MainConsult { get; set; } 
        public DocumentRepository Screen { get; set; }
        public DocumentRepositoryCollectionView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class DocumentRepositoryEntityView : View
    {
        public DocumentRepositoryEntityView(DocumentRepository screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            SaveButton = RPSControlFactory.RPSSaveButton<DocumentRepositoryEntityView>( this);
 
            DeleteButton = RPSControlFactory.RPSDeleteButton<DocumentRepositoryEntityView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<DocumentRepositoryEntityView,DocumentRepositoryCollectionView>( this,Screen.DocumentRepositoryCollectionView);
 
            BackButton = RPSControlFactory.RPSBackButton<DocumentRepositoryEntityView,DocumentRepositoryCollectionView>( this,Screen.DocumentRepositoryCollectionView);
 
            RepositoryName = RPSControlFactory.CreateRPSTextBox<DocumentRepositoryEntityView>("9c18f8c8-d848-4cd6-99ec-19334a159851","","",true, this);
 
            ServerUrl = RPSControlFactory.CreateRPSTextBox<DocumentRepositoryEntityView>("06260e46-f49b-4dae-b519-84a60a17c9d0","","",true, this);
 
            Vault = RPSControlFactory.CreateRPSTextBox<DocumentRepositoryEntityView>("fc6ba0d6-af5b-4090-ad10-277580aec68e","","",true, this);
 
            VisibilityAllCompanies = RPSControlFactory.CreateRPSCheckBox<DocumentRepositoryEntityView>("19d8f189-f79d-4eb4-aa99-184b62f5882b","","",true, this);
 
            AvailableForIndexing = RPSControlFactory.CreateRPSCheckBox<DocumentRepositoryEntityView>("3ca9dda6-be06-4ebc-bff4-9c296d80b83a","","",true, this);
 
            HistoryType = RPSControlFactory.CreateRPSEnumComboBox<DocumentRepositoryEntityView>("5da604f8-0e49-415d-a57f-07e3820f76f3","","",false, this);
 
            IDDocumentLabel = RPSControlFactory.CreateRPSComboBox<DocumentRepositoryEntityView>("7f2053a1-e0aa-4407-bb57-9d3d0fad636d","","",false, this);
 
            UseUniqueFilenames = RPSControlFactory.CreateRPSCheckBox<DocumentRepositoryEntityView>("9494fd73-55d9-46bf-be33-1d44969e51c1","","",true, this);
 
            ExtensionsForUniqueFilename = RPSControlFactory.CreateRPSTextBox<DocumentRepositoryEntityView>("0142a1d3-f5f7-40e4-ac06-fe47a495a680","","",false, this);
 
            SearchForDrawings = RPSControlFactory.CreateRPSCheckBox<DocumentRepositoryEntityView>("9f46281d-e403-4098-b79b-04eebfaceb93","","",true, this);
 
            AutomaticCoding = RPSControlFactory.CreateRPSCheckBox<DocumentRepositoryEntityView>("df2ee095-f2db-45c5-a2e5-ce58e4ec0f96","","",true, this);
 
            LevelNumber = RPSControlFactory.CreateRPSFormattedTextBox<DocumentRepositoryEntityView>("d1ba0383-da5e-46dc-8a34-11d37f1e3388","","",true, this);
 
            DigitNumber = RPSControlFactory.CreateRPSFormattedTextBox<DocumentRepositoryEntityView>("02e928d5-0eae-4221-a74a-97457a976c42","","",true, this);
 
            Separator = RPSControlFactory.CreateRPSTextBox<DocumentRepositoryEntityView>("ca13ee2a-8b51-4d7c-8acb-b8ee9f1657cb","","",false, this);
 
            CodingExtensions = RPSControlFactory.CreateRPSTextBox<DocumentRepositoryEntityView>("cd47f67d-d8da-4f35-a154-08a32a5182e9","","",false, this);
 
            UndoSelectedDocumentsCommandButton = RPSControlFactory.CreateRPSButton<DocumentRepositoryEntityView>( "9ea0d8d5-9645-40f9-ad24-2dc192f3c3d7","","",this);
 
            RestoreDeletedDocumentCommandButton = RPSControlFactory.CreateRPSButtonToView<DocumentRepositoryEntityView,DocumentRepositoryRestoreDocumentsDialogView>("9863308b-3636-475b-a26d-13e50bbd7c69","","", this,Screen.DocumentRepositoryRestoreDocumentsDialogView);
 
            RemoveDeletedDocumentsCommandButton = RPSControlFactory.CreateRPSButton<DocumentRepositoryEntityView>( "53d96536-ae1a-4b13-a8ea-1a076154d651","","",this);
 
            CollectionInit params_DocumentRepositoryPermissionsUser = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="d6f403e7-6633-4a66-9899-9a4b9b3e5f7d",CSSSelectorGrid="",XPathGrid=""};
            DocumentRepositoryPermissionsUser = RPSControlFactory.RPSCreateCollectionWithGrid<DocumentRepositoryPermissionsUserCollectionEditor<DocumentRepositoryEntityView,DocumentRepositoryRestoreDocumentsDialogView>,DocumentRepositoryEntityView,DocumentRepositoryRestoreDocumentsDialogView>( params_DocumentRepositoryPermissionsUser,this,Screen.DocumentRepositoryRestoreDocumentsDialogView);
 
            CollectionInit params_DocumentRepositoryPermissionsRole = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="a767fb67-7f54-4bf3-b4bd-08fc3e5b059e",CSSSelectorGrid="",XPathGrid=""};
            DocumentRepositoryPermissionsRole = RPSControlFactory.RPSCreateCollectionWithGrid<DocumentRepositoryPermissionsRoleCollectionEditor<DocumentRepositoryEntityView,DocumentRepositoryRestoreDocumentsDialogView>,DocumentRepositoryEntityView,DocumentRepositoryRestoreDocumentsDialogView>( params_DocumentRepositoryPermissionsRole,this,Screen.DocumentRepositoryRestoreDocumentsDialogView);
 
            CollectionInit params_DocumentTypeAutomations = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="3fadbf71-a032-4d0c-8350-993e7f8c78fb",CSSSelectorGrid="",XPathGrid=""};
            DocumentTypeAutomations = RPSControlFactory.RPSCreateCollectionWithGrid<DocumentTypeAutomationsCollectionEditor<DocumentRepositoryEntityView,DocumentRepositoryRestoreDocumentsDialogView>,DocumentRepositoryEntityView,DocumentRepositoryRestoreDocumentsDialogView>( params_DocumentTypeAutomations,this,Screen.DocumentRepositoryRestoreDocumentsDialogView);
 
            CollectionInit params_DocumentsLockedForRepository = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="ae3f670e-174a-4fe8-a31d-d68a0e7e9576",CSSSelectorGrid="",XPathGrid=""};
            DocumentsLockedForRepository = RPSControlFactory.RPSCreateCollectionWithGrid<DocumentsLockedForRepositoryCollectionEditor<DocumentRepositoryEntityView,DocumentRepositoryRestoreDocumentsDialogView>,DocumentRepositoryEntityView,DocumentRepositoryRestoreDocumentsDialogView>( params_DocumentsLockedForRepository,this,Screen.DocumentRepositoryRestoreDocumentsDialogView);
 
            CollectionInit params_DocumentsDeletedInRepository = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="f9134c96-b93d-419b-b10e-70e5ee561304",CSSSelectorGrid="",XPathGrid=""};
            DocumentsDeletedInRepository = RPSControlFactory.RPSCreateCollectionWithGrid<DocumentsDeletedInRepositoryCollectionEditor<DocumentRepositoryEntityView,DocumentRepositoryRestoreDocumentsDialogView>,DocumentRepositoryEntityView,DocumentRepositoryRestoreDocumentsDialogView>( params_DocumentsDeletedInRepository,this,Screen.DocumentRepositoryRestoreDocumentsDialogView);
 
            CollectionInit params_DocRepositoryFilesNotExist = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="ef084fda-3de6-4dea-84ba-eabaf1d801f9",CSSSelectorGrid="",XPathGrid=""};
            DocRepositoryFilesNotExist = RPSControlFactory.RPSCreateCollectionWithGrid<DocRepositoryFilesNotExistCollectionEditor<DocumentRepositoryEntityView,DocumentRepositoryRestoreDocumentsDialogView>,DocumentRepositoryEntityView,DocumentRepositoryRestoreDocumentsDialogView>( params_DocRepositoryFilesNotExist,this,Screen.DocumentRepositoryRestoreDocumentsDialogView);
 
            SectionGeneral = RPSControlFactory.CreateRPSSection<DocumentRepositoryEntityView>( "","ul li[rpsid='238de02e-e3ec-4758-a164-6b013cc1287e']","",this);
 
            SectionUserPermission = RPSControlFactory.CreateRPSSection<DocumentRepositoryEntityView>( "","ul li[rpsid='d442bc7a-c34f-4905-99f2-a2152f44402a']","",this);
 
            SectionRolePermission = RPSControlFactory.CreateRPSSection<DocumentRepositoryEntityView>( "","ul li[rpsid='67ba6955-1c2a-4c4f-9895-303e2e00956b']","",this);
 
            SectionDocTypeAutomation = RPSControlFactory.CreateRPSSection<DocumentRepositoryEntityView>( "","ul li[rpsid='dcafdf3a-7d66-4f15-a094-4aad315c9d91']","",this);
 
            SectionLockedFiles = RPSControlFactory.CreateRPSSection<DocumentRepositoryEntityView>( "","ul li[rpsid='cccf89d2-006f-49a1-b440-74bbb83a3e58']","",this);
 
            SectionDeletedDocuments = RPSControlFactory.CreateRPSSection<DocumentRepositoryEntityView>( "","ul li[rpsid='f92ba76d-7b12-45c3-b9d3-5d067f387e98']","",this);
 
            SectionCheckFilesPath = RPSControlFactory.CreateRPSSection<DocumentRepositoryEntityView>( "","ul li[rpsid='b666e699-702a-4b72-8237-50ba39ed407e']","",this);
 

        }
        public IRPSSaveButton<DocumentRepositoryEntityView> SaveButton { get; set; } 
        public IRPSButton<DocumentRepositoryEntityView> DeleteButton { get; set; } 
        public IRPSButton<DocumentRepositoryEntityView,DocumentRepositoryCollectionView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<DocumentRepositoryEntityView,DocumentRepositoryCollectionView> BackButton { get; set; } 
        public IRPSTextBox<DocumentRepositoryEntityView> RepositoryName { get; set; } 
        public IRPSTextBox<DocumentRepositoryEntityView> ServerUrl { get; set; } 
        public IRPSTextBox<DocumentRepositoryEntityView> Vault { get; set; } 
        public IRPSCheckbox<DocumentRepositoryEntityView> VisibilityAllCompanies { get; set; } 
        public IRPSCheckbox<DocumentRepositoryEntityView> AvailableForIndexing { get; set; } 
        public IRPSComboBox<DocumentRepositoryEntityView> HistoryType { get; set; } 
        public IRPSComboBox<DocumentRepositoryEntityView> IDDocumentLabel { get; set; } 
        public IRPSCheckbox<DocumentRepositoryEntityView> UseUniqueFilenames { get; set; } 
        public IRPSTextBox<DocumentRepositoryEntityView> ExtensionsForUniqueFilename { get; set; } 
        public IRPSCheckbox<DocumentRepositoryEntityView> SearchForDrawings { get; set; } 
        public IRPSCheckbox<DocumentRepositoryEntityView> AutomaticCoding { get; set; } 
        public IRPSTextBox<DocumentRepositoryEntityView> LevelNumber { get; set; } 
        public IRPSTextBox<DocumentRepositoryEntityView> DigitNumber { get; set; } 
        public IRPSTextBox<DocumentRepositoryEntityView> Separator { get; set; } 
        public IRPSTextBox<DocumentRepositoryEntityView> CodingExtensions { get; set; } 
        public IRPSButton<DocumentRepositoryEntityView> UndoSelectedDocumentsCommandButton { get; set; } 
        public IRPSButton<DocumentRepositoryEntityView,DocumentRepositoryRestoreDocumentsDialogView> RestoreDeletedDocumentCommandButton { get; set; } 
        public IRPSButton<DocumentRepositoryEntityView> RemoveDeletedDocumentsCommandButton { get; set; } 
        public DocumentRepositoryPermissionsUserCollectionEditor<DocumentRepositoryEntityView,DocumentRepositoryRestoreDocumentsDialogView> DocumentRepositoryPermissionsUser { get; set; } 
        public DocumentRepositoryPermissionsRoleCollectionEditor<DocumentRepositoryEntityView,DocumentRepositoryRestoreDocumentsDialogView> DocumentRepositoryPermissionsRole { get; set; } 
        public DocumentTypeAutomationsCollectionEditor<DocumentRepositoryEntityView,DocumentRepositoryRestoreDocumentsDialogView> DocumentTypeAutomations { get; set; } 
        public DocumentsLockedForRepositoryCollectionEditor<DocumentRepositoryEntityView,DocumentRepositoryRestoreDocumentsDialogView> DocumentsLockedForRepository { get; set; } 
        public DocumentsDeletedInRepositoryCollectionEditor<DocumentRepositoryEntityView,DocumentRepositoryRestoreDocumentsDialogView> DocumentsDeletedInRepository { get; set; } 
        public DocRepositoryFilesNotExistCollectionEditor<DocumentRepositoryEntityView,DocumentRepositoryRestoreDocumentsDialogView> DocRepositoryFilesNotExist { get; set; } 
        public IRPSSection<DocumentRepositoryEntityView> SectionGeneral { get; set; } 
        public IRPSSection<DocumentRepositoryEntityView> SectionUserPermission { get; set; } 
        public IRPSSection<DocumentRepositoryEntityView> SectionRolePermission { get; set; } 
        public IRPSSection<DocumentRepositoryEntityView> SectionDocTypeAutomation { get; set; } 
        public IRPSSection<DocumentRepositoryEntityView> SectionLockedFiles { get; set; } 
        public IRPSSection<DocumentRepositoryEntityView> SectionDeletedDocuments { get; set; } 
        public IRPSSection<DocumentRepositoryEntityView> SectionCheckFilesPath { get; set; } 
        public DocumentRepository Screen { get; set; }
        public DocumentRepositoryEntityView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class DocumentRepositoryPermissionsUserCollectionEditor<DocumentRepositoryEntityView,DocumentRepositoryRestoreDocumentsDialogView>:RPSCollectionEditor<DocumentRepositoryEntityView,DocumentRepositoryRestoreDocumentsDialogView> where DocumentRepositoryEntityView : class, IView where DocumentRepositoryRestoreDocumentsDialogView : class, IView
    {
        public  DocumentRepositoryPermissionsUserGridView<DocumentRepositoryEntityView,DocumentRepositoryRestoreDocumentsDialogView> GridView {get;set;}
    }
    public partial class DocumentRepositoryPermissionsUserGridView <DocumentRepositoryEntityView,DocumentRepositoryRestoreDocumentsDialogView> :  RPSGridView<DocumentRepositoryEntityView,DocumentRepositoryRestoreDocumentsDialogView> where DocumentRepositoryEntityView : class, IView where DocumentRepositoryRestoreDocumentsDialogView : class, IView
    {
        public DocumentRepositoryPermissionsUserGridView(DocumentRepositoryEntityView currentView,DocumentRepositoryRestoreDocumentsDialogView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            CodUser = RPSControlFactory.CreateRPSGridComboBox<DocumentRepositoryEntityView>("","#d6f403e7-6633-4a66-9899-9a4b9b3e5f7d .ag-row[role='row']@ROWINDEX [col-id='cCodUser']","",false, this.CurrentView);
 
            Allow = RPSControlFactory.CreateRPSGridEnumComboBox<DocumentRepositoryEntityView>("","#d6f403e7-6633-4a66-9899-9a4b9b3e5f7d .ag-row[role='row']@ROWINDEX [col-id='cAllow']","",true, this.CurrentView);
 

        }
        public IRPSGridComboBox<DocumentRepositoryEntityView> CodUser { get; set; } 
        public IRPSGridComboBox<DocumentRepositoryEntityView> Allow { get; set; } 
                     
    }
 
        public partial class DocumentRepositoryPermissionsRoleCollectionEditor<DocumentRepositoryEntityView,DocumentRepositoryRestoreDocumentsDialogView>:RPSCollectionEditor<DocumentRepositoryEntityView,DocumentRepositoryRestoreDocumentsDialogView> where DocumentRepositoryEntityView : class, IView where DocumentRepositoryRestoreDocumentsDialogView : class, IView
    {
        public  DocumentRepositoryPermissionsRoleGridView<DocumentRepositoryEntityView,DocumentRepositoryRestoreDocumentsDialogView> GridView {get;set;}
    }
    public partial class DocumentRepositoryPermissionsRoleGridView <DocumentRepositoryEntityView,DocumentRepositoryRestoreDocumentsDialogView> :  RPSGridView<DocumentRepositoryEntityView,DocumentRepositoryRestoreDocumentsDialogView> where DocumentRepositoryEntityView : class, IView where DocumentRepositoryRestoreDocumentsDialogView : class, IView
    {
        public DocumentRepositoryPermissionsRoleGridView(DocumentRepositoryEntityView currentView,DocumentRepositoryRestoreDocumentsDialogView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            CodRole = RPSControlFactory.CreateRPSGridComboBox<DocumentRepositoryEntityView>("","#a767fb67-7f54-4bf3-b4bd-08fc3e5b059e .ag-row[role='row']@ROWINDEX [col-id='cCodRole']","",false, this.CurrentView);
 
            Allow = RPSControlFactory.CreateRPSGridEnumComboBox<DocumentRepositoryEntityView>("","#a767fb67-7f54-4bf3-b4bd-08fc3e5b059e .ag-row[role='row']@ROWINDEX [col-id='cAllow']","",true, this.CurrentView);
 

        }
        public IRPSGridComboBox<DocumentRepositoryEntityView> CodRole { get; set; } 
        public IRPSGridComboBox<DocumentRepositoryEntityView> Allow { get; set; } 
                     
    }
 
        public partial class DocumentTypeAutomationsCollectionEditor<DocumentRepositoryEntityView,DocumentRepositoryRestoreDocumentsDialogView>:RPSCollectionEditor<DocumentRepositoryEntityView,DocumentRepositoryRestoreDocumentsDialogView> where DocumentRepositoryEntityView : class, IView where DocumentRepositoryRestoreDocumentsDialogView : class, IView
    {
        public  DocumentTypeAutomationsGridView<DocumentRepositoryEntityView,DocumentRepositoryRestoreDocumentsDialogView> GridView {get;set;}
    }
    public partial class DocumentTypeAutomationsGridView <DocumentRepositoryEntityView,DocumentRepositoryRestoreDocumentsDialogView> :  RPSGridView<DocumentRepositoryEntityView,DocumentRepositoryRestoreDocumentsDialogView> where DocumentRepositoryEntityView : class, IView where DocumentRepositoryRestoreDocumentsDialogView : class, IView
    {
        public DocumentTypeAutomationsGridView(DocumentRepositoryEntityView currentView,DocumentRepositoryRestoreDocumentsDialogView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            OrderOfApplication = RPSControlFactory.CreateRPSGridFormattedTextBox<DocumentRepositoryEntityView>("","#3fadbf71-a032-4d0c-8350-993e7f8c78fb .ag-row[role='row']@ROWINDEX [col-id='cOrderOfApplication']","",true, this.CurrentView);
 
            PathFilter = RPSControlFactory.CreateRPSGridTextBox<DocumentRepositoryEntityView>("","#3fadbf71-a032-4d0c-8350-993e7f8c78fb .ag-row[role='row']@ROWINDEX [col-id='cPathFilter']","",false, this.CurrentView);
 
            ExtensionFilter = RPSControlFactory.CreateRPSGridTextBox<DocumentRepositoryEntityView>("","#3fadbf71-a032-4d0c-8350-993e7f8c78fb .ag-row[role='row']@ROWINDEX [col-id='cExtensionFilter']","",false, this.CurrentView);
 
            DocumentVariableValue = RPSControlFactory.CreateRPSGridTextBox<DocumentRepositoryEntityView>("","#3fadbf71-a032-4d0c-8350-993e7f8c78fb .ag-row[role='row']@ROWINDEX [col-id='cDocumentVariableValue']","",false, this.CurrentView);
 
            IDDocumentType = RPSControlFactory.CreateRPSGridComboBox<DocumentRepositoryEntityView>("","#3fadbf71-a032-4d0c-8350-993e7f8c78fb .ag-row[role='row']@ROWINDEX [col-id='cIDDocumentType']","",true, this.CurrentView);
 
            IDDocumentSituation = RPSControlFactory.CreateRPSGridComboBox<DocumentRepositoryEntityView>("","#3fadbf71-a032-4d0c-8350-993e7f8c78fb .ag-row[role='row']@ROWINDEX [col-id='cIDDocumentSituation']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<DocumentRepositoryEntityView> OrderOfApplication { get; set; } 
        public IRPSGridTextBox<DocumentRepositoryEntityView> PathFilter { get; set; } 
        public IRPSGridTextBox<DocumentRepositoryEntityView> ExtensionFilter { get; set; } 
        public IRPSGridTextBox<DocumentRepositoryEntityView> DocumentVariableValue { get; set; } 
        public IRPSGridComboBox<DocumentRepositoryEntityView> IDDocumentType { get; set; } 
        public IRPSGridComboBox<DocumentRepositoryEntityView> IDDocumentSituation { get; set; } 
                     
    }
 
        public partial class DocumentsLockedForRepositoryCollectionEditor<DocumentRepositoryEntityView,DocumentRepositoryRestoreDocumentsDialogView>:RPSCollectionEditor<DocumentRepositoryEntityView,DocumentRepositoryRestoreDocumentsDialogView> where DocumentRepositoryEntityView : class, IView where DocumentRepositoryRestoreDocumentsDialogView : class, IView
    {
        public  DocumentsLockedForRepositoryGridView<DocumentRepositoryEntityView,DocumentRepositoryRestoreDocumentsDialogView> GridView {get;set;}
    }
    public partial class DocumentsLockedForRepositoryGridView <DocumentRepositoryEntityView,DocumentRepositoryRestoreDocumentsDialogView> :  RPSGridView<DocumentRepositoryEntityView,DocumentRepositoryRestoreDocumentsDialogView> where DocumentRepositoryEntityView : class, IView where DocumentRepositoryRestoreDocumentsDialogView : class, IView
    {
        public DocumentsLockedForRepositoryGridView(DocumentRepositoryEntityView currentView,DocumentRepositoryRestoreDocumentsDialogView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            Document_CheckedOutMachine = RPSControlFactory.CreateRPSGridTextBox<DocumentRepositoryEntityView>("","#ae3f670e-174a-4fe8-a31d-d68a0e7e9576 .ag-row[role='row']@ROWINDEX [col-id='cDocument_CheckedOutMachine']","",false, this.CurrentView);
 
            Document_Path = RPSControlFactory.CreateRPSGridTextBox<DocumentRepositoryEntityView>("","#ae3f670e-174a-4fe8-a31d-d68a0e7e9576 .ag-row[role='row']@ROWINDEX [col-id='cDocument_Path']","",false, this.CurrentView);
 
            Document_UserCheckOutPath = RPSControlFactory.CreateRPSGridTextBox<DocumentRepositoryEntityView>("","#ae3f670e-174a-4fe8-a31d-d68a0e7e9576 .ag-row[role='row']@ROWINDEX [col-id='cDocument_UserCheckOutPath']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<DocumentRepositoryEntityView> Document_CheckedOutMachine { get; set; } 
        public IRPSGridTextBox<DocumentRepositoryEntityView> Document_Path { get; set; } 
        public IRPSGridTextBox<DocumentRepositoryEntityView> Document_UserCheckOutPath { get; set; } 
                     
    }
 
        public partial class DocumentsDeletedInRepositoryCollectionEditor<DocumentRepositoryEntityView,DocumentRepositoryRestoreDocumentsDialogView>:RPSCollectionEditor<DocumentRepositoryEntityView,DocumentRepositoryRestoreDocumentsDialogView> where DocumentRepositoryEntityView : class, IView where DocumentRepositoryRestoreDocumentsDialogView : class, IView
    {
        public  DocumentsDeletedInRepositoryGridView<DocumentRepositoryEntityView,DocumentRepositoryRestoreDocumentsDialogView> GridView {get;set;}
    }
    public partial class DocumentsDeletedInRepositoryGridView <DocumentRepositoryEntityView,DocumentRepositoryRestoreDocumentsDialogView> :  RPSGridView<DocumentRepositoryEntityView,DocumentRepositoryRestoreDocumentsDialogView> where DocumentRepositoryEntityView : class, IView where DocumentRepositoryRestoreDocumentsDialogView : class, IView
    {
        public DocumentsDeletedInRepositoryGridView(DocumentRepositoryEntityView currentView,DocumentRepositoryRestoreDocumentsDialogView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            CodDocument = RPSControlFactory.CreateRPSGridTextBox<DocumentRepositoryEntityView>("","#f9134c96-b93d-419b-b10e-70e5ee561304 .ag-row[role='row']@ROWINDEX [col-id='cCodDocument']","",false, this.CurrentView);
 
            Path = RPSControlFactory.CreateRPSGridTextBox<DocumentRepositoryEntityView>("","#f9134c96-b93d-419b-b10e-70e5ee561304 .ag-row[role='row']@ROWINDEX [col-id='cPath']","",false, this.CurrentView);
 
            DeletedDate = RPSControlFactory.CreateRPSGridTextBox<DocumentRepositoryEntityView>("","#f9134c96-b93d-419b-b10e-70e5ee561304 .ag-row[role='row']@ROWINDEX [col-id='cDeletedDate']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<DocumentRepositoryEntityView> CodDocument { get; set; } 
        public IRPSGridTextBox<DocumentRepositoryEntityView> Path { get; set; } 
        public IRPSGridTextBox<DocumentRepositoryEntityView> DeletedDate { get; set; } 
                     
    }
 
        public partial class DocRepositoryFilesNotExistCollectionEditor<DocumentRepositoryEntityView,DocumentRepositoryRestoreDocumentsDialogView>:RPSCollectionEditor<DocumentRepositoryEntityView,DocumentRepositoryRestoreDocumentsDialogView> where DocumentRepositoryEntityView : class, IView where DocumentRepositoryRestoreDocumentsDialogView : class, IView
    {
        public  DocRepositoryFilesNotExistGridView<DocumentRepositoryEntityView,DocumentRepositoryRestoreDocumentsDialogView> GridView {get;set;}
    }
    public partial class DocRepositoryFilesNotExistGridView <DocumentRepositoryEntityView,DocumentRepositoryRestoreDocumentsDialogView> :  RPSGridView<DocumentRepositoryEntityView,DocumentRepositoryRestoreDocumentsDialogView> where DocumentRepositoryEntityView : class, IView where DocumentRepositoryRestoreDocumentsDialogView : class, IView
    {
        public DocRepositoryFilesNotExistGridView(DocumentRepositoryEntityView currentView,DocumentRepositoryRestoreDocumentsDialogView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {

        }
                     
    }
 
    }
  
            
    public partial class DocumentRepositoryRestoreDocumentsDialogView : View
    {
        public DocumentRepositoryRestoreDocumentsDialogView(DocumentRepository screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            DefaultDocumentCategory = RPSControlFactory.CreateRPSComboBox<DocumentRepositoryRestoreDocumentsDialogView>("979847a9-3732-4989-be9c-6906ddc695b6","","",false, this);
 
            CollectionInit params_NewModelCollection = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="cb1a56f4-f087-4fe8-91d6-70139adbf09c",CSSSelectorGrid="",XPathGrid=""};
            NewModelCollection = RPSControlFactory.RPSCreateCollectionWithGrid<NewModelCollectionCollectionEditor<DocumentRepositoryRestoreDocumentsDialogView>,DocumentRepositoryRestoreDocumentsDialogView>( params_NewModelCollection,this);
 

        }
        public IRPSComboBox<DocumentRepositoryRestoreDocumentsDialogView> DefaultDocumentCategory { get; set; } 
        public NewModelCollectionCollectionEditor<DocumentRepositoryRestoreDocumentsDialogView> NewModelCollection { get; set; } 
        public DocumentRepository Screen { get; set; }
        public DocumentRepositoryRestoreDocumentsDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class NewModelCollectionCollectionEditor<DocumentRepositoryRestoreDocumentsDialogView>:RPSCollectionEditor<DocumentRepositoryRestoreDocumentsDialogView> where DocumentRepositoryRestoreDocumentsDialogView : class, IView
    {
        public  NewModelCollectionGridView<DocumentRepositoryRestoreDocumentsDialogView> GridView {get;set;}
    }
    public partial class NewModelCollectionGridView <DocumentRepositoryRestoreDocumentsDialogView> :  RPSGridView<DocumentRepositoryRestoreDocumentsDialogView> where DocumentRepositoryRestoreDocumentsDialogView : class, IView
    {
        public NewModelCollectionGridView(DocumentRepositoryRestoreDocumentsDialogView currentView)
        {
            this.WebDriver = currentView.WebDriver;          
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            CodDocument = RPSControlFactory.CreateRPSGridTextBox<DocumentRepositoryRestoreDocumentsDialogView>("","#cb1a56f4-f087-4fe8-91d6-70139adbf09c .ag-row[role='row']@ROWINDEX [col-id='cCodDocument']","",false, this.CurrentView);
 
            Description = RPSControlFactory.CreateRPSGridTextBox<DocumentRepositoryRestoreDocumentsDialogView>("","#cb1a56f4-f087-4fe8-91d6-70139adbf09c .ag-row[role='row']@ROWINDEX [col-id='cDescription']","",false, this.CurrentView);
 
            Path = RPSControlFactory.CreateRPSGridTextBox<DocumentRepositoryRestoreDocumentsDialogView>("","#cb1a56f4-f087-4fe8-91d6-70139adbf09c .ag-row[role='row']@ROWINDEX [col-id='cPath']","",false, this.CurrentView);
 
            DeletedDate = RPSControlFactory.CreateRPSGridTextBox<DocumentRepositoryRestoreDocumentsDialogView>("","#cb1a56f4-f087-4fe8-91d6-70139adbf09c .ag-row[role='row']@ROWINDEX [col-id='cDeletedDate']","",false, this.CurrentView);
 
            IDDocumentCategory = RPSControlFactory.CreateRPSGridComboBox<DocumentRepositoryRestoreDocumentsDialogView>("","#cb1a56f4-f087-4fe8-91d6-70139adbf09c .ag-row[role='row']@ROWINDEX [col-id='cIDDocumentCategory']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<DocumentRepositoryRestoreDocumentsDialogView> CodDocument { get; set; } 
        public IRPSGridTextBox<DocumentRepositoryRestoreDocumentsDialogView> Description { get; set; } 
        public IRPSGridTextBox<DocumentRepositoryRestoreDocumentsDialogView> Path { get; set; } 
        public IRPSGridTextBox<DocumentRepositoryRestoreDocumentsDialogView> DeletedDate { get; set; } 
        public IRPSGridComboBox<DocumentRepositoryRestoreDocumentsDialogView> IDDocumentCategory { get; set; } 
                     
    }
 
    }
  
            
    public partial class DocumentTypeAutomationView : View
    {
        public DocumentTypeAutomationView(DocumentRepository screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            DeleteButton = RPSControlFactory.RPSDeleteButton<DocumentTypeAutomationView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<DocumentTypeAutomationView,DocumentRepositoryEntityView>( this,Screen.DocumentRepositoryEntityView);
 
            BackButton = RPSControlFactory.RPSBackButton<DocumentTypeAutomationView,DocumentRepositoryEntityView>( this,Screen.DocumentRepositoryEntityView);
 
            AcceptButton = RPSControlFactory.RPSAcceptButton<DocumentTypeAutomationView,DocumentRepositoryEntityView>( this,Screen.DocumentRepositoryEntityView);
 
            OrderOfApplication = RPSControlFactory.CreateRPSFormattedTextBox<DocumentTypeAutomationView>("8cde6ec0-f162-41d0-820b-c15c3aad64ce","","",true, this);
 
            PathFilter = RPSControlFactory.CreateRPSTextBox<DocumentTypeAutomationView>("6f1f4533-1dd5-4056-86e4-d1ac617856ec","","",false, this);
 
            ExtensionFilter = RPSControlFactory.CreateRPSTextBox<DocumentTypeAutomationView>("97d4b927-192e-4144-a8a5-9c42b70aa2e6","","",false, this);
 
            DocumentVariableValue = RPSControlFactory.CreateRPSTextBox<DocumentTypeAutomationView>("99139365-82a5-4f6f-bfb9-d1e2603f9a72","","",false, this);
 
            IDDocumentType = RPSControlFactory.CreateRPSComboBox<DocumentTypeAutomationView>("0733a458-4866-48e0-bccc-a9a5480a3c61","","",true, this);
 
            IDDocumentSituation = RPSControlFactory.CreateRPSComboBox<DocumentTypeAutomationView>("d51bade6-83e7-41cd-a95f-cce6de879814","","",false, this);
 

        }
        public IRPSButton<DocumentTypeAutomationView> DeleteButton { get; set; } 
        public IRPSButton<DocumentTypeAutomationView,DocumentRepositoryEntityView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<DocumentTypeAutomationView,DocumentRepositoryEntityView> BackButton { get; set; } 
        public IRPSAcceptButton<DocumentTypeAutomationView,DocumentRepositoryEntityView> AcceptButton { get; set; } 
        public IRPSTextBox<DocumentTypeAutomationView> OrderOfApplication { get; set; } 
        public IRPSTextBox<DocumentTypeAutomationView> PathFilter { get; set; } 
        public IRPSTextBox<DocumentTypeAutomationView> ExtensionFilter { get; set; } 
        public IRPSTextBox<DocumentTypeAutomationView> DocumentVariableValue { get; set; } 
        public IRPSComboBox<DocumentTypeAutomationView> IDDocumentType { get; set; } 
        public IRPSComboBox<DocumentTypeAutomationView> IDDocumentSituation { get; set; } 
        public DocumentRepository Screen { get; set; }
        public DocumentTypeAutomationView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}