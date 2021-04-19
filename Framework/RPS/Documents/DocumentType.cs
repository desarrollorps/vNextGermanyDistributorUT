    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.Documents.DocumentType
{
    //RPS VERSION 1.0.0.0
    public partial class DocumentType:Screen
    {
        public DocumentType():base()
        {
            this.URL = "documents.documenttype";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            DocumentTypeCollectionView  = new DocumentTypeCollectionView(this); 
            DocumentTypeEntityView  = new DocumentTypeEntityView(this); 
            DocumentSituationChangeView  = new DocumentSituationChangeView(this); 
            DocumentSituationChangePropView  = new DocumentSituationChangePropView(this); 
            DocSituationChangeFormatView  = new DocSituationChangeFormatView(this); 
            DocumentTypeCollectionView.InitializeControls(); 
            DocumentTypeEntityView.InitializeControls(); 
            DocumentSituationChangeView.InitializeControls(); 
            DocumentSituationChangePropView.InitializeControls(); 
            DocSituationChangeFormatView.InitializeControls(); 
           
        }
      
            public DocumentTypeCollectionView DocumentTypeCollectionView {get; set; } 
            public DocumentTypeEntityView DocumentTypeEntityView {get; set; } 
            public DocumentSituationChangeView DocumentSituationChangeView {get; set; } 
            public DocumentSituationChangePropView DocumentSituationChangePropView {get; set; } 
            public DocSituationChangeFormatView DocSituationChangeFormatView {get; set; } 
    }
            
    public partial class DocumentTypeCollectionView : View
    {
        public DocumentTypeCollectionView(DocumentType screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            NewButton = RPSControlFactory.RPSNewButton<DocumentTypeCollectionView,DocumentTypeEntityView>( this,Screen.DocumentTypeEntityView);
 
            CollectionInit params_MainConsult = new CollectionInit(){IDDescriptor = "caee18f7-a333-463f-a69a-af278b9d0ce7",CSSSelectorDescriptor = "",XPathDescriptor = ""};
            MainConsult = RPSControlFactory.RPSCreateCollection<DocumentTypeCollectionView,DocumentTypeEntityView>( params_MainConsult,this,Screen.DocumentTypeEntityView);
 

        }
        public IRPSButton<DocumentTypeCollectionView,DocumentTypeEntityView> NewButton { get; set; } 
        public IRPSCollectionEditor<DocumentTypeCollectionView,DocumentTypeEntityView> MainConsult { get; set; } 
        public DocumentType Screen { get; set; }
        public DocumentTypeCollectionView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class DocumentTypeEntityView : View
    {
        public DocumentTypeEntityView(DocumentType screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            SaveButton = RPSControlFactory.RPSSaveButton<DocumentTypeEntityView>( this);
 
            DeleteButton = RPSControlFactory.RPSDeleteButton<DocumentTypeEntityView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<DocumentTypeEntityView,DocumentTypeCollectionView>( this,Screen.DocumentTypeCollectionView);
 
            BackButton = RPSControlFactory.RPSBackButton<DocumentTypeEntityView,DocumentTypeCollectionView>( this,Screen.DocumentTypeCollectionView);
 
            CodDocumentType = RPSControlFactory.CreateRPSTextBox<DocumentTypeEntityView>("8840b064-2984-4f20-86b2-822a2b3a54b7","","",true, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<DocumentTypeEntityView>("be9ebe08-36ac-4990-b11f-f62fa30a8285","","",false, this);
 
            SituationChangeType = RPSControlFactory.CreateRPSEnumComboBox<DocumentTypeEntityView>("cc390326-75ac-4138-9740-784e0a478d80","","",true, this);
 
            ExcludeFromCoding = RPSControlFactory.CreateRPSCheckBox<DocumentTypeEntityView>("9cc9b082-619d-4284-9c57-36987932b7b9","","",true, this);
 
            IDWorkflowOnDocumentCreate = RPSControlFactory.CreateRPSComboBox<DocumentTypeEntityView>("86b047cc-2101-40e3-a79e-7e7c72d409fc","","",false, this);
 
            IDWorkflowOnSituationChange = RPSControlFactory.CreateRPSComboBox<DocumentTypeEntityView>("eef6b620-b0c0-4b3d-ae3e-243b0e0016c3","","",false, this);
 
            IDWorkflowOnCheckedOut = RPSControlFactory.CreateRPSComboBox<DocumentTypeEntityView>("78682e8f-bc7f-48b5-9838-6e64cd7299e4","","",false, this);
 
            IDWorkflowOnNewRevision = RPSControlFactory.CreateRPSComboBox<DocumentTypeEntityView>("949004db-fcb9-428d-a2e6-68fd3bd315bd","","",false, this);
 
            IDWorkflowOnVersionChange = RPSControlFactory.CreateRPSComboBox<DocumentTypeEntityView>("62e542a4-a21a-4bb5-8e95-9b1b7f1ba4f5","","",false, this);
 
            IDWorkflowOnDownload = RPSControlFactory.CreateRPSComboBox<DocumentTypeEntityView>("9cff4e4e-a334-4f9a-bd3b-f5b64547d0ba","","",false, this);
 
            AutoVersion = RPSControlFactory.CreateRPSCheckBox<DocumentTypeEntityView>("7c3ccb86-8d2a-4128-9ac5-2f706d113ae9","","",true, this);
 
            Separator = RPSControlFactory.CreateRPSTextBox<DocumentTypeEntityView>("db4aa483-2b69-4f6e-8f95-9a3a61ad6f9a","","",false, this);
 
            PrimVersionType = RPSControlFactory.CreateRPSEnumComboBox<DocumentTypeEntityView>("81d40b65-3ee7-4736-a9be-afd45cc4cf53","","",true, this);
 
            PrimVersionLength = RPSControlFactory.CreateRPSFormattedTextBox<DocumentTypeEntityView>("7dd0ad33-60fe-40a3-852c-94068aac4f9a","","",true, this);
 
            PrimVersionPrefix = RPSControlFactory.CreateRPSTextBox<DocumentTypeEntityView>("b28b7633-4168-49ca-b810-190869f00869","","",false, this);
 
            PrimVersionInit = RPSControlFactory.CreateRPSTextBox<DocumentTypeEntityView>("2e010231-955f-48c2-a722-c899b881bada","","",false, this);
 
            PrimVersionFill = RPSControlFactory.CreateRPSTextBox<DocumentTypeEntityView>("4a0991e3-e383-42a4-b63f-f4f8b21380b8","","",false, this);
 
            PrimVersionList = RPSControlFactory.CreateRPSTextBox<DocumentTypeEntityView>("9842ff60-59e2-4a07-9044-596ad4d7d104","","",false, this);
 
            SecVersionType = RPSControlFactory.CreateRPSEnumComboBox<DocumentTypeEntityView>("bbe1e384-47cc-4e32-9a3a-0ed1fe7d0dbc","","",true, this);
 
            SecVersionLength = RPSControlFactory.CreateRPSFormattedTextBox<DocumentTypeEntityView>("189cbb40-818f-4743-8fb1-099ba1238fcc","","",true, this);
 
            SecVersionPrefix = RPSControlFactory.CreateRPSTextBox<DocumentTypeEntityView>("b7b8df78-a66e-49c0-ba22-ade37aa9d903","","",false, this);
 
            SecVersionInit = RPSControlFactory.CreateRPSTextBox<DocumentTypeEntityView>("2d72a8bd-5d6d-497a-a44c-00fd5a15fef0","","",false, this);
 
            SecVersionFill = RPSControlFactory.CreateRPSTextBox<DocumentTypeEntityView>("188009eb-02d6-4425-be53-5fb385ccbefd","","",false, this);
 
            SecVersionList = RPSControlFactory.CreateRPSTextBox<DocumentTypeEntityView>("0b03acd8-cace-435a-9c08-8d63738cac6f","","",false, this);
 
            IDDocumentLabelForCode = RPSControlFactory.CreateRPSComboBox<DocumentTypeEntityView>("742f9fc5-93a5-4d09-aac4-3c8b3107eb17","","",false, this);
 
            IDDocumentLabelForDescription = RPSControlFactory.CreateRPSComboBox<DocumentTypeEntityView>("16421e84-d9f3-4cb2-829e-1980bff9503a","","",false, this);
 
            PurchaseOfferDocuments = RPSControlFactory.CreateRPSCheckBox<DocumentTypeEntityView>("49e86b85-4c89-4871-9057-63d0cde23950","","",true, this);
 
            PurchaseOrderDocuments = RPSControlFactory.CreateRPSCheckBox<DocumentTypeEntityView>("df39cf5e-dcb0-4a2b-8465-7ba3fe02c35f","","",true, this);
 
            SalesOfferDocuments = RPSControlFactory.CreateRPSCheckBox<DocumentTypeEntityView>("32486c12-21b7-4e21-bce2-fe0983e9dc12","","",true, this);
 
            SalesOrderDocuments = RPSControlFactory.CreateRPSCheckBox<DocumentTypeEntityView>("06d7fd9c-a7aa-481a-a08b-141e3824b3b7","","",true, this);
 
            CollectionInit params_DocumentTypeVariableLabels = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="3c54a612-391e-4cb0-af4d-89392b325e12",CSSSelectorGrid="",XPathGrid=""};
            DocumentTypeVariableLabels = RPSControlFactory.RPSCreateCollectionWithGrid<DocumentTypeVariableLabelsCollectionEditor<DocumentTypeEntityView,DocumentSituationChangeView>,DocumentTypeEntityView,DocumentSituationChangeView>( params_DocumentTypeVariableLabels,this,Screen.DocumentSituationChangeView);
 
            CollectionInit params_DocumentSituationChanges = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="56323615-5e8e-4c9b-989d-fe554ca537b7",CSSSelectorGrid="",XPathGrid=""};
            DocumentSituationChanges = RPSControlFactory.RPSCreateCollectionWithGrid<DocumentSituationChangesCollectionEditor<DocumentTypeEntityView,DocumentSituationChangeView>,DocumentTypeEntityView,DocumentSituationChangeView>( params_DocumentSituationChanges,this,Screen.DocumentSituationChangeView);
 
            CollectionInit params_DocumentTypePermissionsUser = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="70f71630-5390-48bd-acac-4736d457bf24",CSSSelectorGrid="",XPathGrid=""};
            DocumentTypePermissionsUser = RPSControlFactory.RPSCreateCollectionWithGrid<DocumentTypePermissionsUserCollectionEditor<DocumentTypeEntityView,DocumentSituationChangeView>,DocumentTypeEntityView,DocumentSituationChangeView>( params_DocumentTypePermissionsUser,this,Screen.DocumentSituationChangeView);
 
            CollectionInit params_DocumentTypePermissionsRole = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="f1668c37-8355-4315-8c60-90c8ce9bb282",CSSSelectorGrid="",XPathGrid=""};
            DocumentTypePermissionsRole = RPSControlFactory.RPSCreateCollectionWithGrid<DocumentTypePermissionsRoleCollectionEditor<DocumentTypeEntityView,DocumentSituationChangeView>,DocumentTypeEntityView,DocumentSituationChangeView>( params_DocumentTypePermissionsRole,this,Screen.DocumentSituationChangeView);
 
            GeneralData = RPSControlFactory.CreateRPSSection<DocumentTypeEntityView>( "","ul li[rpsid='abb893a4-1846-4ee2-af7b-f714b4ed9f5f']","",this);
 
            Labels = RPSControlFactory.CreateRPSSection<DocumentTypeEntityView>( "","ul li[rpsid='669c6a9f-0e41-4e33-af50-068f73ed26e9']","",this);
 
            SituationChange = RPSControlFactory.CreateRPSSection<DocumentTypeEntityView>( "","ul li[rpsid='185a551f-493c-4849-80ac-761101155467']","",this);
 
            OffersOrders = RPSControlFactory.CreateRPSSection<DocumentTypeEntityView>( "","ul li[rpsid='74b2a483-2ce9-4f22-a7ac-63c1477f8974']","",this);
 
            UserPermissions = RPSControlFactory.CreateRPSSection<DocumentTypeEntityView>( "","ul li[rpsid='08676d09-2e86-45be-a0c1-5c0500cf000e']","",this);
 
            RolePermissions = RPSControlFactory.CreateRPSSection<DocumentTypeEntityView>( "","ul li[rpsid='152f0a36-fa84-4339-9e2d-f88e586f363f']","",this);
 

        }
        public IRPSSaveButton<DocumentTypeEntityView> SaveButton { get; set; } 
        public IRPSButton<DocumentTypeEntityView> DeleteButton { get; set; } 
        public IRPSButton<DocumentTypeEntityView,DocumentTypeCollectionView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<DocumentTypeEntityView,DocumentTypeCollectionView> BackButton { get; set; } 
        public IRPSTextBox<DocumentTypeEntityView> CodDocumentType { get; set; } 
        public IRPSTextBox<DocumentTypeEntityView> Description { get; set; } 
        public IRPSComboBox<DocumentTypeEntityView> SituationChangeType { get; set; } 
        public IRPSCheckbox<DocumentTypeEntityView> ExcludeFromCoding { get; set; } 
        public IRPSComboBox<DocumentTypeEntityView> IDWorkflowOnDocumentCreate { get; set; } 
        public IRPSComboBox<DocumentTypeEntityView> IDWorkflowOnSituationChange { get; set; } 
        public IRPSComboBox<DocumentTypeEntityView> IDWorkflowOnCheckedOut { get; set; } 
        public IRPSComboBox<DocumentTypeEntityView> IDWorkflowOnNewRevision { get; set; } 
        public IRPSComboBox<DocumentTypeEntityView> IDWorkflowOnVersionChange { get; set; } 
        public IRPSComboBox<DocumentTypeEntityView> IDWorkflowOnDownload { get; set; } 
        public IRPSCheckbox<DocumentTypeEntityView> AutoVersion { get; set; } 
        public IRPSTextBox<DocumentTypeEntityView> Separator { get; set; } 
        public IRPSComboBox<DocumentTypeEntityView> PrimVersionType { get; set; } 
        public IRPSTextBox<DocumentTypeEntityView> PrimVersionLength { get; set; } 
        public IRPSTextBox<DocumentTypeEntityView> PrimVersionPrefix { get; set; } 
        public IRPSTextBox<DocumentTypeEntityView> PrimVersionInit { get; set; } 
        public IRPSTextBox<DocumentTypeEntityView> PrimVersionFill { get; set; } 
        public IRPSTextBox<DocumentTypeEntityView> PrimVersionList { get; set; } 
        public IRPSComboBox<DocumentTypeEntityView> SecVersionType { get; set; } 
        public IRPSTextBox<DocumentTypeEntityView> SecVersionLength { get; set; } 
        public IRPSTextBox<DocumentTypeEntityView> SecVersionPrefix { get; set; } 
        public IRPSTextBox<DocumentTypeEntityView> SecVersionInit { get; set; } 
        public IRPSTextBox<DocumentTypeEntityView> SecVersionFill { get; set; } 
        public IRPSTextBox<DocumentTypeEntityView> SecVersionList { get; set; } 
        public IRPSComboBox<DocumentTypeEntityView> IDDocumentLabelForCode { get; set; } 
        public IRPSComboBox<DocumentTypeEntityView> IDDocumentLabelForDescription { get; set; } 
        public IRPSCheckbox<DocumentTypeEntityView> PurchaseOfferDocuments { get; set; } 
        public IRPSCheckbox<DocumentTypeEntityView> PurchaseOrderDocuments { get; set; } 
        public IRPSCheckbox<DocumentTypeEntityView> SalesOfferDocuments { get; set; } 
        public IRPSCheckbox<DocumentTypeEntityView> SalesOrderDocuments { get; set; } 
        public DocumentTypeVariableLabelsCollectionEditor<DocumentTypeEntityView,DocumentSituationChangeView> DocumentTypeVariableLabels { get; set; } 
        public DocumentSituationChangesCollectionEditor<DocumentTypeEntityView,DocumentSituationChangeView> DocumentSituationChanges { get; set; } 
        public DocumentTypePermissionsUserCollectionEditor<DocumentTypeEntityView,DocumentSituationChangeView> DocumentTypePermissionsUser { get; set; } 
        public DocumentTypePermissionsRoleCollectionEditor<DocumentTypeEntityView,DocumentSituationChangeView> DocumentTypePermissionsRole { get; set; } 
        public IRPSSection<DocumentTypeEntityView> GeneralData { get; set; } 
        public IRPSSection<DocumentTypeEntityView> Labels { get; set; } 
        public IRPSSection<DocumentTypeEntityView> SituationChange { get; set; } 
        public IRPSSection<DocumentTypeEntityView> OffersOrders { get; set; } 
        public IRPSSection<DocumentTypeEntityView> UserPermissions { get; set; } 
        public IRPSSection<DocumentTypeEntityView> RolePermissions { get; set; } 
        public DocumentType Screen { get; set; }
        public DocumentTypeEntityView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class DocumentTypeVariableLabelsCollectionEditor<DocumentTypeEntityView,DocumentSituationChangeView>:RPSCollectionEditor<DocumentTypeEntityView,DocumentSituationChangeView> where DocumentTypeEntityView : class, IView where DocumentSituationChangeView : class, IView
    {
        public  DocumentTypeVariableLabelsGridView<DocumentTypeEntityView,DocumentSituationChangeView> GridView {get;set;}
    }
    public partial class DocumentTypeVariableLabelsGridView <DocumentTypeEntityView,DocumentSituationChangeView> :  RPSGridView<DocumentTypeEntityView,DocumentSituationChangeView> where DocumentTypeEntityView : class, IView where DocumentSituationChangeView : class, IView
    {
        public DocumentTypeVariableLabelsGridView(DocumentTypeEntityView currentView,DocumentSituationChangeView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            IDDocumentLabel = RPSControlFactory.CreateRPSGridComboBox<DocumentTypeEntityView>("","#3c54a612-391e-4cb0-af4d-89392b325e12 .ag-row[role='row']@ROWINDEX [col-id='cIDDocumentLabel']","",true, this.CurrentView);
 
            PropertyLinkName = RPSControlFactory.CreateRPSGridTextBox<DocumentTypeEntityView>("","#3c54a612-391e-4cb0-af4d-89392b325e12 .ag-row[role='row']@ROWINDEX [col-id='cPropertyLinkName']","",false, this.CurrentView);
 

        }
        public IRPSGridComboBox<DocumentTypeEntityView> IDDocumentLabel { get; set; } 
        public IRPSGridTextBox<DocumentTypeEntityView> PropertyLinkName { get; set; } 
                     
    }
 
        public partial class DocumentSituationChangesCollectionEditor<DocumentTypeEntityView,DocumentSituationChangeView>:RPSCollectionEditor<DocumentTypeEntityView,DocumentSituationChangeView> where DocumentTypeEntityView : class, IView where DocumentSituationChangeView : class, IView
    {
        public  DocumentSituationChangesGridView<DocumentTypeEntityView,DocumentSituationChangeView> GridView {get;set;}
    }
    public partial class DocumentSituationChangesGridView <DocumentTypeEntityView,DocumentSituationChangeView> :  RPSGridView<DocumentTypeEntityView,DocumentSituationChangeView> where DocumentTypeEntityView : class, IView where DocumentSituationChangeView : class, IView
    {
        public DocumentSituationChangesGridView(DocumentTypeEntityView currentView,DocumentSituationChangeView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            IDSituationInitial = RPSControlFactory.CreateRPSGridComboBox<DocumentTypeEntityView>("","#56323615-5e8e-4c9b-989d-fe554ca537b7 .ag-row[role='row']@ROWINDEX [col-id='cIDSituationInitial']","",true, this.CurrentView);
 
            IDSituationFinal = RPSControlFactory.CreateRPSGridComboBox<DocumentTypeEntityView>("","#56323615-5e8e-4c9b-989d-fe554ca537b7 .ag-row[role='row']@ROWINDEX [col-id='cIDSituationFinal']","",true, this.CurrentView);
 
            IsCommentRequired = RPSControlFactory.CreateRPSGridCheckBox<DocumentTypeEntityView>("","#56323615-5e8e-4c9b-989d-fe554ca537b7 .ag-row[role='row']@ROWINDEX [col-id='cIsCommentRequired']","",true, this.CurrentView);
 
            PDFGenerate = RPSControlFactory.CreateRPSGridCheckBox<DocumentTypeEntityView>("","#56323615-5e8e-4c9b-989d-fe554ca537b7 .ag-row[role='row']@ROWINDEX [col-id='cPDFGenerate']","",true, this.CurrentView);
 

        }
        public IRPSGridComboBox<DocumentTypeEntityView> IDSituationInitial { get; set; } 
        public IRPSGridComboBox<DocumentTypeEntityView> IDSituationFinal { get; set; } 
        public IRPSGridCheckbox<DocumentTypeEntityView> IsCommentRequired { get; set; } 
        public IRPSGridCheckbox<DocumentTypeEntityView> PDFGenerate { get; set; } 
                     
    }
 
        public partial class DocumentTypePermissionsUserCollectionEditor<DocumentTypeEntityView,DocumentSituationChangeView>:RPSCollectionEditor<DocumentTypeEntityView,DocumentSituationChangeView> where DocumentTypeEntityView : class, IView where DocumentSituationChangeView : class, IView
    {
        public  DocumentTypePermissionsUserGridView<DocumentTypeEntityView,DocumentSituationChangeView> GridView {get;set;}
    }
    public partial class DocumentTypePermissionsUserGridView <DocumentTypeEntityView,DocumentSituationChangeView> :  RPSGridView<DocumentTypeEntityView,DocumentSituationChangeView> where DocumentTypeEntityView : class, IView where DocumentSituationChangeView : class, IView
    {
        public DocumentTypePermissionsUserGridView(DocumentTypeEntityView currentView,DocumentSituationChangeView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            CodUser = RPSControlFactory.CreateRPSGridComboBox<DocumentTypeEntityView>("","#70f71630-5390-48bd-acac-4736d457bf24 .ag-row[role='row']@ROWINDEX [col-id='cCodUser']","",false, this.CurrentView);
 
            Allow = RPSControlFactory.CreateRPSGridEnumComboBox<DocumentTypeEntityView>("","#70f71630-5390-48bd-acac-4736d457bf24 .ag-row[role='row']@ROWINDEX [col-id='cAllow']","",true, this.CurrentView);
 

        }
        public IRPSGridComboBox<DocumentTypeEntityView> CodUser { get; set; } 
        public IRPSGridComboBox<DocumentTypeEntityView> Allow { get; set; } 
                     
    }
 
        public partial class DocumentTypePermissionsRoleCollectionEditor<DocumentTypeEntityView,DocumentSituationChangeView>:RPSCollectionEditor<DocumentTypeEntityView,DocumentSituationChangeView> where DocumentTypeEntityView : class, IView where DocumentSituationChangeView : class, IView
    {
        public  DocumentTypePermissionsRoleGridView<DocumentTypeEntityView,DocumentSituationChangeView> GridView {get;set;}
    }
    public partial class DocumentTypePermissionsRoleGridView <DocumentTypeEntityView,DocumentSituationChangeView> :  RPSGridView<DocumentTypeEntityView,DocumentSituationChangeView> where DocumentTypeEntityView : class, IView where DocumentSituationChangeView : class, IView
    {
        public DocumentTypePermissionsRoleGridView(DocumentTypeEntityView currentView,DocumentSituationChangeView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            CodRole = RPSControlFactory.CreateRPSGridComboBox<DocumentTypeEntityView>("","#f1668c37-8355-4315-8c60-90c8ce9bb282 .ag-row[role='row']@ROWINDEX [col-id='cCodRole']","",false, this.CurrentView);
 
            Allow = RPSControlFactory.CreateRPSGridEnumComboBox<DocumentTypeEntityView>("","#f1668c37-8355-4315-8c60-90c8ce9bb282 .ag-row[role='row']@ROWINDEX [col-id='cAllow']","",true, this.CurrentView);
 

        }
        public IRPSGridComboBox<DocumentTypeEntityView> CodRole { get; set; } 
        public IRPSGridComboBox<DocumentTypeEntityView> Allow { get; set; } 
                     
    }
 
    }
  
            
    public partial class DocumentSituationChangeView : View
    {
        public DocumentSituationChangeView(DocumentType screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            DeleteButton = RPSControlFactory.RPSDeleteButton<DocumentSituationChangeView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<DocumentSituationChangeView,DocumentTypeEntityView>( this,Screen.DocumentTypeEntityView);
 
            BackButton = RPSControlFactory.RPSBackButton<DocumentSituationChangeView,DocumentTypeEntityView>( this,Screen.DocumentTypeEntityView);
 
            AcceptButton = RPSControlFactory.RPSAcceptButton<DocumentSituationChangeView,DocumentTypeEntityView>( this,Screen.DocumentTypeEntityView);
 
            IDSituationInitial = RPSControlFactory.CreateRPSComboBox<DocumentSituationChangeView>("e30bd353-d8ae-461f-ab03-80e1c0b63fb0","","",true, this);
 
            IDSituationFinal = RPSControlFactory.CreateRPSComboBox<DocumentSituationChangeView>("c059e1e6-4feb-4364-94a2-90729e2d56ef","","",true, this);
 
            IsCommentRequired = RPSControlFactory.CreateRPSCheckBox<DocumentSituationChangeView>("79a494a6-b167-4bb5-a906-ed5a783a0cc4","","",true, this);
 
            PDFGenerate = RPSControlFactory.CreateRPSCheckBox<DocumentSituationChangeView>("8761b87a-facd-4738-88d4-fb39542b835f","","",true, this);
 
            PrimaryVersion = RPSControlFactory.CreateRPSEnumComboBox<DocumentSituationChangeView>("ae216657-a2ff-4720-a708-360279572ce5","","",true, this);
 
            SecondaryVersion = RPSControlFactory.CreateRPSEnumComboBox<DocumentSituationChangeView>("ccc2d9dd-198c-4711-b1bd-2a4ed683bc1d","","",true, this);
 
            AssociatedEntityRequired = RPSControlFactory.CreateRPSEnumComboBox<DocumentSituationChangeView>("40e7fc74-5ad7-4cb5-871e-443525a10c54","","",true, this);
 
            AssociatedEntityType = RPSControlFactory.CreateRPSEnumComboBox<DocumentSituationChangeView>("ce44d6e7-40f6-4e4f-b7a5-7b05dc9a8ce7","","",false, this);
 
            AssociatedDocumentRequired = RPSControlFactory.CreateRPSCheckBox<DocumentSituationChangeView>("ea2bb5bb-de27-4283-b88e-8436b6c5a0d5","","",true, this);
 
            IDDocumentTypeAssociated = RPSControlFactory.CreateRPSComboBox<DocumentSituationChangeView>("fe12d1f6-a7fc-4c76-9169-dde294eafe4f","","",false, this);
 
            AssociationsInFinalSituation = RPSControlFactory.CreateRPSCheckBox<DocumentSituationChangeView>("61b8f0a3-7616-4c68-bd7b-3084da7a24e6","","",true, this);
 
            CollectionInit params_DocumentSituationChangeProps = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="c1c46a14-bfc9-4b48-b9cd-d0279db49af9",CSSSelectorGrid="",XPathGrid=""};
            DocumentSituationChangeProps = RPSControlFactory.RPSCreateCollectionWithGrid<DocumentSituationChangePropsCollectionEditor<DocumentSituationChangeView,DocumentSituationChangePropView>,DocumentSituationChangeView,DocumentSituationChangePropView>( params_DocumentSituationChangeProps,this,Screen.DocumentSituationChangePropView);
 
            CollectionInit params_DocumentSituationChangeRoles = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="b5cf3ad4-4891-4e5e-9dcd-34f666e85822",CSSSelectorGrid="",XPathGrid=""};
            DocumentSituationChangeRoles = RPSControlFactory.RPSCreateCollectionWithGrid<DocumentSituationChangeRolesCollectionEditor<DocumentSituationChangeView,DocumentSituationChangePropView>,DocumentSituationChangeView,DocumentSituationChangePropView>( params_DocumentSituationChangeRoles,this,Screen.DocumentSituationChangePropView);
 
            CollectionInit params_DocSituationChangeFormats = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="5120153a-2009-407b-8589-5e824e195e14",CSSSelectorGrid="",XPathGrid=""};
            DocSituationChangeFormats = RPSControlFactory.RPSCreateCollectionWithGrid<DocSituationChangeFormatsCollectionEditor<DocumentSituationChangeView,DocumentSituationChangePropView>,DocumentSituationChangeView,DocumentSituationChangePropView>( params_DocSituationChangeFormats,this,Screen.DocumentSituationChangePropView);
 
            GeneralData = RPSControlFactory.CreateRPSSection<DocumentSituationChangeView>( "","ul li[rpsid='70c35888-c8ce-45ee-8cea-841b34231f42']","",this);
 
            Properties = RPSControlFactory.CreateRPSSection<DocumentSituationChangeView>( "","ul li[rpsid='5cac50e7-af5e-4a11-8206-1794c4572b79']","",this);
 
            Roles = RPSControlFactory.CreateRPSSection<DocumentSituationChangeView>( "","ul li[rpsid='172bf414-dd7b-4684-bfe8-6f7d53287057']","",this);
 
            PDFGeneration = RPSControlFactory.CreateRPSSection<DocumentSituationChangeView>( "","ul li[rpsid='22fb17a2-64e1-4d57-8237-b4597b6a4f74']","",this);
 

        }
        public IRPSButton<DocumentSituationChangeView> DeleteButton { get; set; } 
        public IRPSButton<DocumentSituationChangeView,DocumentTypeEntityView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<DocumentSituationChangeView,DocumentTypeEntityView> BackButton { get; set; } 
        public IRPSAcceptButton<DocumentSituationChangeView,DocumentTypeEntityView> AcceptButton { get; set; } 
        public IRPSComboBox<DocumentSituationChangeView> IDSituationInitial { get; set; } 
        public IRPSComboBox<DocumentSituationChangeView> IDSituationFinal { get; set; } 
        public IRPSCheckbox<DocumentSituationChangeView> IsCommentRequired { get; set; } 
        public IRPSCheckbox<DocumentSituationChangeView> PDFGenerate { get; set; } 
        public IRPSComboBox<DocumentSituationChangeView> PrimaryVersion { get; set; } 
        public IRPSComboBox<DocumentSituationChangeView> SecondaryVersion { get; set; } 
        public IRPSComboBox<DocumentSituationChangeView> AssociatedEntityRequired { get; set; } 
        public IRPSComboBox<DocumentSituationChangeView> AssociatedEntityType { get; set; } 
        public IRPSCheckbox<DocumentSituationChangeView> AssociatedDocumentRequired { get; set; } 
        public IRPSComboBox<DocumentSituationChangeView> IDDocumentTypeAssociated { get; set; } 
        public IRPSCheckbox<DocumentSituationChangeView> AssociationsInFinalSituation { get; set; } 
        public DocumentSituationChangePropsCollectionEditor<DocumentSituationChangeView,DocumentSituationChangePropView> DocumentSituationChangeProps { get; set; } 
        public DocumentSituationChangeRolesCollectionEditor<DocumentSituationChangeView,DocumentSituationChangePropView> DocumentSituationChangeRoles { get; set; } 
        public DocSituationChangeFormatsCollectionEditor<DocumentSituationChangeView,DocumentSituationChangePropView> DocSituationChangeFormats { get; set; } 
        public IRPSSection<DocumentSituationChangeView> GeneralData { get; set; } 
        public IRPSSection<DocumentSituationChangeView> Properties { get; set; } 
        public IRPSSection<DocumentSituationChangeView> Roles { get; set; } 
        public IRPSSection<DocumentSituationChangeView> PDFGeneration { get; set; } 
        public DocumentType Screen { get; set; }
        public DocumentSituationChangeView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class DocumentSituationChangePropsCollectionEditor<DocumentSituationChangeView,DocumentSituationChangePropView>:RPSCollectionEditor<DocumentSituationChangeView,DocumentSituationChangePropView> where DocumentSituationChangeView : class, IView where DocumentSituationChangePropView : class, IView
    {
        public  DocumentSituationChangePropsGridView<DocumentSituationChangeView,DocumentSituationChangePropView> GridView {get;set;}
    }
    public partial class DocumentSituationChangePropsGridView <DocumentSituationChangeView,DocumentSituationChangePropView> :  RPSGridView<DocumentSituationChangeView,DocumentSituationChangePropView> where DocumentSituationChangeView : class, IView where DocumentSituationChangePropView : class, IView
    {
        public DocumentSituationChangePropsGridView(DocumentSituationChangeView currentView,DocumentSituationChangePropView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            IDDestinationLabel = RPSControlFactory.CreateRPSGridComboBox<DocumentSituationChangeView>("","#c1c46a14-bfc9-4b48-b9cd-d0279db49af9 .ag-row[role='row']@ROWINDEX [col-id='cIDDestinationLabel']","",true, this.CurrentView);
 
            PropertyValue = RPSControlFactory.CreateRPSGridEnumComboBox<DocumentSituationChangeView>("","#c1c46a14-bfc9-4b48-b9cd-d0279db49af9 .ag-row[role='row']@ROWINDEX [col-id='cPropertyValue']","",true, this.CurrentView);
 
            IDSourceLabel = RPSControlFactory.CreateRPSGridComboBox<DocumentSituationChangeView>("","#c1c46a14-bfc9-4b48-b9cd-d0279db49af9 .ag-row[role='row']@ROWINDEX [col-id='cIDSourceLabel']","",false, this.CurrentView);
 
            FixedValue = RPSControlFactory.CreateRPSGridTextBox<DocumentSituationChangeView>("","#c1c46a14-bfc9-4b48-b9cd-d0279db49af9 .ag-row[role='row']@ROWINDEX [col-id='cFixedValue']","",false, this.CurrentView);
 

        }
        public IRPSGridComboBox<DocumentSituationChangeView> IDDestinationLabel { get; set; } 
        public IRPSGridComboBox<DocumentSituationChangeView> PropertyValue { get; set; } 
        public IRPSGridComboBox<DocumentSituationChangeView> IDSourceLabel { get; set; } 
        public IRPSGridTextBox<DocumentSituationChangeView> FixedValue { get; set; } 
                     
    }
 
        public partial class DocumentSituationChangeRolesCollectionEditor<DocumentSituationChangeView,DocumentSituationChangePropView>:RPSCollectionEditor<DocumentSituationChangeView,DocumentSituationChangePropView> where DocumentSituationChangeView : class, IView where DocumentSituationChangePropView : class, IView
    {
        public  DocumentSituationChangeRolesGridView<DocumentSituationChangeView,DocumentSituationChangePropView> GridView {get;set;}
    }
    public partial class DocumentSituationChangeRolesGridView <DocumentSituationChangeView,DocumentSituationChangePropView> :  RPSGridView<DocumentSituationChangeView,DocumentSituationChangePropView> where DocumentSituationChangeView : class, IView where DocumentSituationChangePropView : class, IView
    {
        public DocumentSituationChangeRolesGridView(DocumentSituationChangeView currentView,DocumentSituationChangePropView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            CodRole = RPSControlFactory.CreateRPSGridComboBox<DocumentSituationChangeView>("","#b5cf3ad4-4891-4e5e-9dcd-34f666e85822 .ag-row[role='row']@ROWINDEX [col-id='cCodRole']","",true, this.CurrentView);
 

        }
        public IRPSGridComboBox<DocumentSituationChangeView> CodRole { get; set; } 
                     
    }
 
        public partial class DocSituationChangeFormatsCollectionEditor<DocumentSituationChangeView,DocumentSituationChangePropView>:RPSCollectionEditor<DocumentSituationChangeView,DocumentSituationChangePropView> where DocumentSituationChangeView : class, IView where DocumentSituationChangePropView : class, IView
    {
        public  DocSituationChangeFormatsGridView<DocumentSituationChangeView,DocumentSituationChangePropView> GridView {get;set;}
    }
    public partial class DocSituationChangeFormatsGridView <DocumentSituationChangeView,DocumentSituationChangePropView> :  RPSGridView<DocumentSituationChangeView,DocumentSituationChangePropView> where DocumentSituationChangeView : class, IView where DocumentSituationChangePropView : class, IView
    {
        public DocSituationChangeFormatsGridView(DocumentSituationChangeView currentView,DocumentSituationChangePropView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            Extensions = RPSControlFactory.CreateRPSGridTextBox<DocumentSituationChangeView>("","#5120153a-2009-407b-8589-5e824e195e14 .ag-row[role='row']@ROWINDEX [col-id='cExtensions']","",false, this.CurrentView);
 
            FileFormat = RPSControlFactory.CreateRPSGridEnumComboBox<DocumentSituationChangeView>("","#5120153a-2009-407b-8589-5e824e195e14 .ag-row[role='row']@ROWINDEX [col-id='cFileFormat']","",true, this.CurrentView);
 
            Path = RPSControlFactory.CreateRPSGridEnumComboBox<DocumentSituationChangeView>("","#5120153a-2009-407b-8589-5e824e195e14 .ag-row[role='row']@ROWINDEX [col-id='cPath']","",true, this.CurrentView);
 
            CodCategory = RPSControlFactory.CreateRPSGridTextBox<DocumentSituationChangeView>("","#5120153a-2009-407b-8589-5e824e195e14 .ag-row[role='row']@ROWINDEX [col-id='cCodCategory']","",false, this.CurrentView);
 
            IDDocumentCategory = RPSControlFactory.CreateRPSGridComboBox<DocumentSituationChangeView>("","#5120153a-2009-407b-8589-5e824e195e14 .ag-row[role='row']@ROWINDEX [col-id='cIDDocumentCategory']","",false, this.CurrentView);
 
            Name = RPSControlFactory.CreateRPSGridEnumComboBox<DocumentSituationChangeView>("","#5120153a-2009-407b-8589-5e824e195e14 .ag-row[role='row']@ROWINDEX [col-id='cName']","",true, this.CurrentView);
 
            Associations = RPSControlFactory.CreateRPSGridEnumComboBox<DocumentSituationChangeView>("","#5120153a-2009-407b-8589-5e824e195e14 .ag-row[role='row']@ROWINDEX [col-id='cAssociations']","",true, this.CurrentView);
 
            CopyEntities = RPSControlFactory.CreateRPSGridCheckBox<DocumentSituationChangeView>("","#5120153a-2009-407b-8589-5e824e195e14 .ag-row[role='row']@ROWINDEX [col-id='cCopyEntities']","",true, this.CurrentView);
 

        }
        public IRPSGridTextBox<DocumentSituationChangeView> Extensions { get; set; } 
        public IRPSGridComboBox<DocumentSituationChangeView> FileFormat { get; set; } 
        public IRPSGridComboBox<DocumentSituationChangeView> Path { get; set; } 
        public IRPSGridTextBox<DocumentSituationChangeView> CodCategory { get; set; } 
        public IRPSGridComboBox<DocumentSituationChangeView> IDDocumentCategory { get; set; } 
        public IRPSGridComboBox<DocumentSituationChangeView> Name { get; set; } 
        public IRPSGridComboBox<DocumentSituationChangeView> Associations { get; set; } 
        public IRPSGridCheckbox<DocumentSituationChangeView> CopyEntities { get; set; } 
                     
    }
 
    }
  
            
    public partial class DocumentSituationChangePropView : View
    {
        public DocumentSituationChangePropView(DocumentType screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            DeleteButton = RPSControlFactory.RPSDeleteButton<DocumentSituationChangePropView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<DocumentSituationChangePropView,DocumentSituationChangeView>( this,Screen.DocumentSituationChangeView);
 
            BackButton = RPSControlFactory.RPSBackButton<DocumentSituationChangePropView,DocumentSituationChangeView>( this,Screen.DocumentSituationChangeView);
 
            AcceptButton = RPSControlFactory.RPSAcceptButton<DocumentSituationChangePropView,DocumentSituationChangeView>( this,Screen.DocumentSituationChangeView);
 
            IDDestinationLabel = RPSControlFactory.CreateRPSComboBox<DocumentSituationChangePropView>("d15c472a-c78b-4cd6-add3-6349558df33b","","",true, this);
 
            PropertyValue = RPSControlFactory.CreateRPSEnumComboBox<DocumentSituationChangePropView>("023193e4-d747-4af0-9e53-4e065aca3c83","","",true, this);
 
            IDSourceLabel = RPSControlFactory.CreateRPSComboBox<DocumentSituationChangePropView>("cb084e4e-0540-491f-9240-b65520ad97c9","","",false, this);
 
            FixedValue = RPSControlFactory.CreateRPSTextBox<DocumentSituationChangePropView>("62fbaaca-daa1-4a2d-b26f-9db82bd03672","","",false, this);
 

        }
        public IRPSButton<DocumentSituationChangePropView> DeleteButton { get; set; } 
        public IRPSButton<DocumentSituationChangePropView,DocumentSituationChangeView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<DocumentSituationChangePropView,DocumentSituationChangeView> BackButton { get; set; } 
        public IRPSAcceptButton<DocumentSituationChangePropView,DocumentSituationChangeView> AcceptButton { get; set; } 
        public IRPSComboBox<DocumentSituationChangePropView> IDDestinationLabel { get; set; } 
        public IRPSComboBox<DocumentSituationChangePropView> PropertyValue { get; set; } 
        public IRPSComboBox<DocumentSituationChangePropView> IDSourceLabel { get; set; } 
        public IRPSTextBox<DocumentSituationChangePropView> FixedValue { get; set; } 
        public DocumentType Screen { get; set; }
        public DocumentSituationChangePropView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class DocSituationChangeFormatView : View
    {
        public DocSituationChangeFormatView(DocumentType screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            DeleteButton = RPSControlFactory.RPSDeleteButton<DocSituationChangeFormatView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<DocSituationChangeFormatView,DocumentSituationChangeView>( this,Screen.DocumentSituationChangeView);
 
            BackButton = RPSControlFactory.RPSBackButton<DocSituationChangeFormatView,DocumentSituationChangeView>( this,Screen.DocumentSituationChangeView);
 
            AcceptButton = RPSControlFactory.RPSAcceptButton<DocSituationChangeFormatView,DocumentSituationChangeView>( this,Screen.DocumentSituationChangeView);
 
            Extensions = RPSControlFactory.CreateRPSTextBox<DocSituationChangeFormatView>("1b795417-4afe-4a27-b8b2-f243435e4f5f","","",false, this);
 
            FileFormat = RPSControlFactory.CreateRPSEnumComboBox<DocSituationChangeFormatView>("ccb15922-00c0-462d-a8a6-309727ad05fd","","",true, this);
 
            Path = RPSControlFactory.CreateRPSEnumComboBox<DocSituationChangeFormatView>("6ac45840-02fa-42af-bf69-e140a10fca1e","","",true, this);
 
            CodCategory = RPSControlFactory.CreateRPSTextBox<DocSituationChangeFormatView>("be79f635-7ef8-4efd-a1c3-4ece999ea7a2","","",false, this);
 
            Name = RPSControlFactory.CreateRPSEnumComboBox<DocSituationChangeFormatView>("67c14666-135e-498f-8017-afb75f1c3635","","",true, this);
 
            Associations = RPSControlFactory.CreateRPSEnumComboBox<DocSituationChangeFormatView>("5d839e2f-b608-4431-8ee4-819d84c4df00","","",true, this);
 
            CopyEntities = RPSControlFactory.CreateRPSCheckBox<DocSituationChangeFormatView>("f547652f-e223-4b22-835a-0e2f802cdf85","","",true, this);
 

        }
        public IRPSButton<DocSituationChangeFormatView> DeleteButton { get; set; } 
        public IRPSButton<DocSituationChangeFormatView,DocumentSituationChangeView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<DocSituationChangeFormatView,DocumentSituationChangeView> BackButton { get; set; } 
        public IRPSAcceptButton<DocSituationChangeFormatView,DocumentSituationChangeView> AcceptButton { get; set; } 
        public IRPSTextBox<DocSituationChangeFormatView> Extensions { get; set; } 
        public IRPSComboBox<DocSituationChangeFormatView> FileFormat { get; set; } 
        public IRPSComboBox<DocSituationChangeFormatView> Path { get; set; } 
        public IRPSTextBox<DocSituationChangeFormatView> CodCategory { get; set; } 
        public IRPSComboBox<DocSituationChangeFormatView> Name { get; set; } 
        public IRPSComboBox<DocSituationChangeFormatView> Associations { get; set; } 
        public IRPSCheckbox<DocSituationChangeFormatView> CopyEntities { get; set; } 
        public DocumentType Screen { get; set; }
        public DocSituationChangeFormatView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}