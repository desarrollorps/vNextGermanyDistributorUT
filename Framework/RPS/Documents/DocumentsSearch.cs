    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.Documents.DocumentsSearch
{
    //RPS VERSION 1.0.0.0
    public partial class DocumentsSearch:Screen
    {
        public DocumentsSearch():base()
        {
            this.URL = "documents.documentssearch";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            DocumentCollectionView  = new DocumentCollectionView(this); 
            DocumentEntityView  = new DocumentEntityView(this); 
            DocumentHistoryView  = new DocumentHistoryView(this); 
            NewDocumentRelatedEntityDialogView  = new NewDocumentRelatedEntityDialogView(this); 
            NewDocumentTagDialogView  = new NewDocumentTagDialogView(this); 
            NewDocumentAssociationDialogView  = new NewDocumentAssociationDialogView(this); 
            FileCheckInDialogView  = new FileCheckInDialogView(this); 
            DocumentVariableValueView  = new DocumentVariableValueView(this); 
            ChangeSituationDialogView  = new ChangeSituationDialogView(this); 
            ChangeDocumentCategoryDialogView  = new ChangeDocumentCategoryDialogView(this); 
            PackFileWizardDialogView  = new PackFileWizardDialogView(this); 
            DocumentCollectionView.InitializeControls(); 
            DocumentEntityView.InitializeControls(); 
            DocumentHistoryView.InitializeControls(); 
            NewDocumentRelatedEntityDialogView.InitializeControls(); 
            NewDocumentTagDialogView.InitializeControls(); 
            NewDocumentAssociationDialogView.InitializeControls(); 
            FileCheckInDialogView.InitializeControls(); 
            DocumentVariableValueView.InitializeControls(); 
            ChangeSituationDialogView.InitializeControls(); 
            ChangeDocumentCategoryDialogView.InitializeControls(); 
            PackFileWizardDialogView.InitializeControls(); 
           
        }
      
            public DocumentCollectionView DocumentCollectionView {get; set; } 
            public DocumentEntityView DocumentEntityView {get; set; } 
            public DocumentHistoryView DocumentHistoryView {get; set; } 
            public NewDocumentRelatedEntityDialogView NewDocumentRelatedEntityDialogView {get; set; } 
            public NewDocumentTagDialogView NewDocumentTagDialogView {get; set; } 
            public NewDocumentAssociationDialogView NewDocumentAssociationDialogView {get; set; } 
            public FileCheckInDialogView FileCheckInDialogView {get; set; } 
            public DocumentVariableValueView DocumentVariableValueView {get; set; } 
            public ChangeSituationDialogView ChangeSituationDialogView {get; set; } 
            public ChangeDocumentCategoryDialogView ChangeDocumentCategoryDialogView {get; set; } 
            public PackFileWizardDialogView PackFileWizardDialogView {get; set; } 
    }
            
    public partial class DocumentCollectionView : View
    {
        public DocumentCollectionView(DocumentsSearch screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            NewButton = RPSControlFactory.RPSNewButton<DocumentCollectionView,DocumentEntityView>( this,Screen.DocumentEntityView);
 
            PackFileWizardNavigationCommandButton = RPSControlFactory.CreateRPSButtonToView<DocumentCollectionView,PackFileWizardDialogView>("8f6b34be-06ec-4761-b1ea-f2fad768d401","","", this,Screen.PackFileWizardDialogView);
 
            DownloadCommandButton = RPSControlFactory.CreateRPSButton<DocumentCollectionView>( "ca7a5390-d5c2-43c1-b4a0-f717df2209ad","","",this);
 
            PreviewCommandButton = RPSControlFactory.CreateRPSButton<DocumentCollectionView>( "351eb8eb-4caa-4718-8838-7bf5d0ecb3aa","","",this);
 
            CollectionInit params_MainConsult = new CollectionInit(){IDDescriptor = "ac768035-c77b-47c6-8e83-ec2658512483",CSSSelectorDescriptor = "",XPathDescriptor = ""};
            MainConsult = RPSControlFactory.RPSCreateCollection<DocumentCollectionView,DocumentEntityView>( params_MainConsult,this,Screen.DocumentEntityView);
 

        }
        public IRPSButton<DocumentCollectionView,DocumentEntityView> NewButton { get; set; } 
        public IRPSButton<DocumentCollectionView,PackFileWizardDialogView> PackFileWizardNavigationCommandButton { get; set; } 
        public IRPSButton<DocumentCollectionView> DownloadCommandButton { get; set; } 
        public IRPSButton<DocumentCollectionView> PreviewCommandButton { get; set; } 
        public IRPSCollectionEditor<DocumentCollectionView,DocumentEntityView> MainConsult { get; set; } 
        public DocumentsSearch Screen { get; set; }
        public DocumentCollectionView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class DocumentEntityView : View
    {
        public DocumentEntityView(DocumentsSearch screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            SaveButton = RPSControlFactory.RPSSaveButton<DocumentEntityView>( this);
 
            DeleteButton = RPSControlFactory.RPSDeleteButton<DocumentEntityView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<DocumentEntityView,DocumentCollectionView>( this,Screen.DocumentCollectionView);
 
            BackButton = RPSControlFactory.RPSBackButton<DocumentEntityView,DocumentCollectionView>( this,Screen.DocumentCollectionView);
 
            IsFavourite = RPSControlFactory.CreateRPSCheckBox<DocumentEntityView>("c8d80346-755c-4d93-8037-91919df1843a","","",false, this);
 
            CodDocument = RPSControlFactory.CreateRPSTextBox<DocumentEntityView>("da0e3e3a-da3c-4413-a6f1-a0d16b6a246f","","",false, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<DocumentEntityView>("72cc0446-12c5-482b-9aa2-051b18875c14","","",false, this);
 
            Date = RPSControlFactory.CreateRPSTextBox<DocumentEntityView>("6e8095ff-298c-43c5-9192-202d99c21920","","",true, this);
 
            Version = RPSControlFactory.CreateRPSTextBox<DocumentEntityView>("77c2c779-31db-496a-9f07-39bb644c535c","","",false, this);
 
            Path = RPSControlFactory.CreateRPSTextBox<DocumentEntityView>("93935365-332e-47a3-84cb-3f54422c3114","","",true, this);
 
            IDDocumentSituation = RPSControlFactory.CreateRPSComboBox<DocumentEntityView>("15acc15d-5fbc-4dbc-b01a-0c948fe7715f","","",false, this);
 
            IDDocumentType = RPSControlFactory.CreateRPSComboBox<DocumentEntityView>("b1bbe9a1-a8d7-4459-b2f7-92447790d907","","",false, this);
 
            DocumentStateText = RPSControlFactory.CreateRPSTextBox<DocumentEntityView>("d1f161cd-0247-41e6-98dd-2d3f22acfe37","","",false, this);
 
            CheckedOutMachine = RPSControlFactory.CreateRPSTextBox<DocumentEntityView>("3884c184-8335-43ad-9fa4-5188673e3017","","",false, this);
 
            RevisionNumber = RPSControlFactory.CreateRPSFormattedTextBox<DocumentEntityView>("7ebd1096-ce00-4ca1-8cd4-679585520efb","","",true, this);
 
            LastRevisionDate = RPSControlFactory.CreateRPSTextBox<DocumentEntityView>("69e5e9c4-baf3-4249-bae0-f9e7626074a4","","",true, this);
 
            LastRevisionTime = RPSControlFactory.CreateRPSTextBox<DocumentEntityView>("f824ddb2-3826-4c5e-a953-04a411806707","","",true, this);
 
            LastRevisionMachine = RPSControlFactory.CreateRPSTextBox<DocumentEntityView>("bbdaa0bc-22e0-4a26-9b22-c04b6132385d","","",false, this);
 
            KeyValue1 = RPSControlFactory.CreateRPSTextBox<DocumentEntityView>("df11b95c-00aa-45c7-8af5-f39e8bd9c687","","",false, this);
 
            KeyValue2 = RPSControlFactory.CreateRPSTextBox<DocumentEntityView>("b4143ca4-3d68-4d8e-b3c2-3d2779984d76","","",false, this);
 
            KeyValue3 = RPSControlFactory.CreateRPSTextBox<DocumentEntityView>("0aefae1f-1728-4617-a096-ea0adce5a1de","","",false, this);
 
            KeyValue4 = RPSControlFactory.CreateRPSTextBox<DocumentEntityView>("94f8f305-1f2d-4751-aa5d-a8e05b5bc7f5","","",false, this);
 
            KeyValue5 = RPSControlFactory.CreateRPSTextBox<DocumentEntityView>("c1c60d04-0329-4975-86c8-a60c10d69fcf","","",false, this);
 
            KeyValue6 = RPSControlFactory.CreateRPSTextBox<DocumentEntityView>("71044080-d474-4fce-a1f6-27e6f3aa8874","","",false, this);
 
            KeyValue7 = RPSControlFactory.CreateRPSTextBox<DocumentEntityView>("fa80a468-92bc-49b7-a4ea-d5bf14ded5fc","","",false, this);
 
            KeyValue8 = RPSControlFactory.CreateRPSTextBox<DocumentEntityView>("9c51a772-bd61-4f72-acf6-c59907230c2f","","",false, this);
 
            KeyValue9 = RPSControlFactory.CreateRPSTextBox<DocumentEntityView>("d24e053a-47ee-4f58-b1cf-99824caeb0e8","","",false, this);
 
            KeyValue10 = RPSControlFactory.CreateRPSTextBox<DocumentEntityView>("d41f312c-1fa9-4785-bd52-4190577cdb78","","",false, this);
 
            NewDocumentAssociationCommand = RPSControlFactory.CreateRPSButtonToView<DocumentEntityView,NewDocumentAssociationDialogView>("a8608d1f-c7db-4b30-9ac0-a2639a266628","","", this,Screen.NewDocumentAssociationDialogView);
 
            ExecuteRemoveDocumentAssociation = RPSControlFactory.CreateRPSButton<DocumentEntityView>( "07720416-95d7-4061-94a6-f21eb6bb6988","","",this);
 
            Document_RevisionNumber = RPSControlFactory.CreateRPSFormattedTextBox<DocumentEntityView>("8839b2f5-ad44-4783-b087-fadd9987d92c","","",false, this);
 
            DocumentLocation = RPSControlFactory.CreateRPSTextBox<DocumentEntityView>("0f7af8c6-888a-4937-9f77-1adba29a76d0","","",false, this);
 
            Document_CheckedOutBy = RPSControlFactory.CreateRPSTextBox<DocumentEntityView>("6bf402be-47d2-4173-9f3a-6d8d2dbbe6be","","",false, this);
 
            Document_CheckedOutMachine = RPSControlFactory.CreateRPSTextBox<DocumentEntityView>("3d48143e-4087-428e-ab07-77b17cfe2486","","",false, this);
 
            Document_RevisionNumber1 = RPSControlFactory.CreateRPSFormattedTextBox<DocumentEntityView>("103a2ce0-aac2-4a5b-9397-015ccad8e76d","","",false, this);
 
            DocumentLocation1 = RPSControlFactory.CreateRPSTextBox<DocumentEntityView>("b1289514-be46-41db-8f50-69cc1addd4e5","","",false, this);
 
            Document_CheckedOutBy1 = RPSControlFactory.CreateRPSTextBox<DocumentEntityView>("2abc9b14-b3ae-4428-b2ac-7055f66032c3","","",false, this);
 
            Document_CheckedOutMachine1 = RPSControlFactory.CreateRPSTextBox<DocumentEntityView>("760005c5-6f69-4e5b-85e1-7cedf7cbc079","","",false, this);
 
            NewDocumentTagCommand = RPSControlFactory.CreateRPSButtonToView<DocumentEntityView,NewDocumentTagDialogView>("cf10b7bc-92dd-487a-8f16-ccbaa5d91022","","", this,Screen.NewDocumentTagDialogView);
 
            ExecuteResetDocumentVariableValuesButton = RPSControlFactory.CreateRPSButton<DocumentEntityView>( "14328515-3fb2-4bb0-8129-c34213fa1b65","","",this);
 
            NewDocumentRelatedEntityCommand = RPSControlFactory.CreateRPSButtonToView<DocumentEntityView,NewDocumentRelatedEntityDialogView>("e214921c-d7ea-41e8-80ac-47ceded6a578","","", this,Screen.NewDocumentRelatedEntityDialogView);
 
            CategoryTreeLinkNavigationCommandButton = RPSControlFactory.CreateRPSButton<DocumentEntityView>( "db52d960-de06-4946-9653-c85f6e3b8099","","",this);
 
            OpenDocumentCommandButton = RPSControlFactory.CreateRPSButton<DocumentEntityView>( "05e47152-4839-46c2-85ca-4691db85a1f3","","",this);
 
            DownloadDocumentCommandButton = RPSControlFactory.CreateRPSButton<DocumentEntityView>( "f5560539-ab35-4935-b748-ef6475f93506","","",this);
 
            DownloadAssemblyCommandButton = RPSControlFactory.CreateRPSButton<DocumentEntityView>( "313a3ad1-0a03-4714-8c8b-056b87cd78c1","","",this);
 
            CheckOutDocumentCommandButton = RPSControlFactory.CreateRPSButton<DocumentEntityView>( "a6e09617-7e65-47b7-95c0-922cd541c170","","",this);
 
            CheckInCommonCommandButton = RPSControlFactory.CreateRPSButton<DocumentEntityView>( "4a3e850c-b8a7-4d0f-af26-ffdfcd754019","","",this);
 
            UndoDocumentCommandButton = RPSControlFactory.CreateRPSButton<DocumentEntityView>( "86c473de-e29d-4d30-bcde-065ab5f71cfa","","",this);
 
            ChangeSituationCommonCommandButton = RPSControlFactory.CreateRPSButton<DocumentEntityView>( "067cebb7-590d-4a59-9974-1d72f07a41a2","","",this);
 
            ChangeDocumentCategoryCommandButton = RPSControlFactory.CreateRPSButtonToView<DocumentEntityView,ChangeDocumentCategoryDialogView>("6342ff00-f045-443b-8fb1-a2b159bf0892","","", this,Screen.ChangeDocumentCategoryDialogView);
 
            AddDocumentSubscriptionCommandButton = RPSControlFactory.CreateRPSButton<DocumentEntityView>( "dc7b2fc9-31c6-44ce-8eb1-8fa8b2437ee3","","",this);
 
            RemoveDocumentSubscriptionCommandButton = RPSControlFactory.CreateRPSButton<DocumentEntityView>( "672960c8-bbd4-4101-8bc7-220e3b3a619a","","",this);
 
            CollectionInit params_DocumentPermissionsUser = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="34356985-9ad7-468e-ab0a-b1ff0d74d622",CSSSelectorGrid="",XPathGrid=""};
            DocumentPermissionsUser = RPSControlFactory.RPSCreateCollectionWithGrid<DocumentPermissionsUserCollectionEditor<DocumentEntityView,DocumentHistoryView>,DocumentEntityView,DocumentHistoryView>( params_DocumentPermissionsUser,this,Screen.DocumentHistoryView);
 
            CollectionInit params_DocumentPermissionsRole = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="f2c89620-7851-478e-b547-f81d51be0013",CSSSelectorGrid="",XPathGrid=""};
            DocumentPermissionsRole = RPSControlFactory.RPSCreateCollectionWithGrid<DocumentPermissionsRoleCollectionEditor<DocumentEntityView,DocumentHistoryView>,DocumentEntityView,DocumentHistoryView>( params_DocumentPermissionsRole,this,Screen.DocumentHistoryView);
 
            CollectionInit params_TagsDocumentForUser = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="5762415d-57b1-4eed-bea8-dd155773634a",CSSSelectorGrid="",XPathGrid=""};
            TagsDocumentForUser = RPSControlFactory.RPSCreateCollectionWithGrid<TagsDocumentForUserCollectionEditor<DocumentEntityView,DocumentHistoryView>,DocumentEntityView,DocumentHistoryView>( params_TagsDocumentForUser,this,Screen.DocumentHistoryView);
 
            CollectionInit params_DocumentVariableValues = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="bf9f7842-4676-4570-8932-0bb114bc0474",CSSSelectorGrid="",XPathGrid=""};
            DocumentVariableValues = RPSControlFactory.RPSCreateCollectionWithGrid<DocumentVariableValuesCollectionEditor<DocumentEntityView,DocumentHistoryView>,DocumentEntityView,DocumentHistoryView>( params_DocumentVariableValues,this,Screen.DocumentHistoryView);
 
            CollectionInit params_DocumentHistorys = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="a9b7ec1d-f6e3-49b4-b6bb-1a4f46c47226",CSSSelectorGrid="",XPathGrid=""};
            DocumentHistorys = RPSControlFactory.RPSCreateCollectionWithGrid<DocumentHistorysCollectionEditor<DocumentEntityView,DocumentHistoryView>,DocumentEntityView,DocumentHistoryView>( params_DocumentHistorys,this,Screen.DocumentHistoryView);
 
            CollectionInit params_EntityDocumentsForIDDocument = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="c862bd39-6cf2-4285-8b94-33d41fc87262",CSSSelectorGrid="",XPathGrid=""};
            EntityDocumentsForIDDocument = RPSControlFactory.RPSCreateCollectionWithGrid<EntityDocumentsForIDDocumentCollectionEditor<DocumentEntityView,DocumentHistoryView>,DocumentEntityView,DocumentHistoryView>( params_EntityDocumentsForIDDocument,this,Screen.DocumentHistoryView);
 
            GeneralData = RPSControlFactory.CreateRPSSection<DocumentEntityView>( "","ul li[rpsid='a25547d8-4668-465d-ad3e-6723f4af7c9a']","",this);
 
            UserPermissions = RPSControlFactory.CreateRPSSection<DocumentEntityView>( "","ul li[rpsid='ebc2afd8-02cb-4d57-853e-a751fd535747']","",this);
 
            RolePermissions = RPSControlFactory.CreateRPSSection<DocumentEntityView>( "","ul li[rpsid='09f761fb-7128-4d6b-b143-92888e66af99']","",this);
 
            Content = RPSControlFactory.CreateRPSSection<DocumentEntityView>( "","ul li[rpsid='10557523-05fe-479e-9237-0b772ec48711']","",this);
 
            UsedIn = RPSControlFactory.CreateRPSSection<DocumentEntityView>( "","ul li[rpsid='7ad32a3b-4471-4b6b-b55f-a270ae7420cd']","",this);
 
            Opinions = RPSControlFactory.CreateRPSSection<DocumentEntityView>( "","ul li[rpsid='fb5774ec-8df5-46bf-8968-ad7174d282cc']","",this);
 
            VariableValues = RPSControlFactory.CreateRPSSection<DocumentEntityView>( "","ul li[rpsid='5545f67d-27e5-42aa-b136-b94b80ebba32']","",this);
 
            History = RPSControlFactory.CreateRPSSection<DocumentEntityView>( "","ul li[rpsid='17818b31-09df-42e0-9160-700080d96b08']","",this);
 
            RelatedEntities = RPSControlFactory.CreateRPSSection<DocumentEntityView>( "","ul li[rpsid='c87c5f71-e5b0-420b-9670-d808d735ba0c']","",this);
 

        }
        public IRPSSaveButton<DocumentEntityView> SaveButton { get; set; } 
        public IRPSButton<DocumentEntityView> DeleteButton { get; set; } 
        public IRPSButton<DocumentEntityView,DocumentCollectionView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<DocumentEntityView,DocumentCollectionView> BackButton { get; set; } 
        public IRPSCheckbox<DocumentEntityView> IsFavourite { get; set; } 
        public IRPSTextBox<DocumentEntityView> CodDocument { get; set; } 
        public IRPSTextBox<DocumentEntityView> Description { get; set; } 
        public IRPSTextBox<DocumentEntityView> Date { get; set; } 
        public IRPSTextBox<DocumentEntityView> Version { get; set; } 
        public IRPSTextBox<DocumentEntityView> Path { get; set; } 
        public IRPSComboBox<DocumentEntityView> IDDocumentSituation { get; set; } 
        public IRPSComboBox<DocumentEntityView> IDDocumentType { get; set; } 
        public IRPSTextBox<DocumentEntityView> DocumentStateText { get; set; } 
        public IRPSTextBox<DocumentEntityView> CheckedOutMachine { get; set; } 
        public IRPSTextBox<DocumentEntityView> RevisionNumber { get; set; } 
        public IRPSTextBox<DocumentEntityView> LastRevisionDate { get; set; } 
        public IRPSTextBox<DocumentEntityView> LastRevisionTime { get; set; } 
        public IRPSTextBox<DocumentEntityView> LastRevisionMachine { get; set; } 
        public IRPSTextBox<DocumentEntityView> KeyValue1 { get; set; } 
        public IRPSTextBox<DocumentEntityView> KeyValue2 { get; set; } 
        public IRPSTextBox<DocumentEntityView> KeyValue3 { get; set; } 
        public IRPSTextBox<DocumentEntityView> KeyValue4 { get; set; } 
        public IRPSTextBox<DocumentEntityView> KeyValue5 { get; set; } 
        public IRPSTextBox<DocumentEntityView> KeyValue6 { get; set; } 
        public IRPSTextBox<DocumentEntityView> KeyValue7 { get; set; } 
        public IRPSTextBox<DocumentEntityView> KeyValue8 { get; set; } 
        public IRPSTextBox<DocumentEntityView> KeyValue9 { get; set; } 
        public IRPSTextBox<DocumentEntityView> KeyValue10 { get; set; } 
        public IRPSButton<DocumentEntityView,NewDocumentAssociationDialogView> NewDocumentAssociationCommand { get; set; } 
        public IRPSButton<DocumentEntityView> ExecuteRemoveDocumentAssociation { get; set; } 
        public IRPSTextBox<DocumentEntityView> Document_RevisionNumber { get; set; } 
        public IRPSTextBox<DocumentEntityView> DocumentLocation { get; set; } 
        public IRPSTextBox<DocumentEntityView> Document_CheckedOutBy { get; set; } 
        public IRPSTextBox<DocumentEntityView> Document_CheckedOutMachine { get; set; } 
        public IRPSTextBox<DocumentEntityView> Document_RevisionNumber1 { get; set; } 
        public IRPSTextBox<DocumentEntityView> DocumentLocation1 { get; set; } 
        public IRPSTextBox<DocumentEntityView> Document_CheckedOutBy1 { get; set; } 
        public IRPSTextBox<DocumentEntityView> Document_CheckedOutMachine1 { get; set; } 
        public IRPSButton<DocumentEntityView,NewDocumentTagDialogView> NewDocumentTagCommand { get; set; } 
        public IRPSButton<DocumentEntityView> ExecuteResetDocumentVariableValuesButton { get; set; } 
        public IRPSButton<DocumentEntityView,NewDocumentRelatedEntityDialogView> NewDocumentRelatedEntityCommand { get; set; } 
        public IRPSButton<DocumentEntityView> CategoryTreeLinkNavigationCommandButton { get; set; } 
        public IRPSButton<DocumentEntityView> OpenDocumentCommandButton { get; set; } 
        public IRPSButton<DocumentEntityView> DownloadDocumentCommandButton { get; set; } 
        public IRPSButton<DocumentEntityView> DownloadAssemblyCommandButton { get; set; } 
        public IRPSButton<DocumentEntityView> CheckOutDocumentCommandButton { get; set; } 
        public IRPSButton<DocumentEntityView> CheckInCommonCommandButton { get; set; } 
        public IRPSButton<DocumentEntityView> UndoDocumentCommandButton { get; set; } 
        public IRPSButton<DocumentEntityView> ChangeSituationCommonCommandButton { get; set; } 
        public IRPSButton<DocumentEntityView,ChangeDocumentCategoryDialogView> ChangeDocumentCategoryCommandButton { get; set; } 
        public IRPSButton<DocumentEntityView> AddDocumentSubscriptionCommandButton { get; set; } 
        public IRPSButton<DocumentEntityView> RemoveDocumentSubscriptionCommandButton { get; set; } 
        public DocumentPermissionsUserCollectionEditor<DocumentEntityView,DocumentHistoryView> DocumentPermissionsUser { get; set; } 
        public DocumentPermissionsRoleCollectionEditor<DocumentEntityView,DocumentHistoryView> DocumentPermissionsRole { get; set; } 
        public TagsDocumentForUserCollectionEditor<DocumentEntityView,DocumentHistoryView> TagsDocumentForUser { get; set; } 
        public DocumentVariableValuesCollectionEditor<DocumentEntityView,DocumentHistoryView> DocumentVariableValues { get; set; } 
        public DocumentHistorysCollectionEditor<DocumentEntityView,DocumentHistoryView> DocumentHistorys { get; set; } 
        public EntityDocumentsForIDDocumentCollectionEditor<DocumentEntityView,DocumentHistoryView> EntityDocumentsForIDDocument { get; set; } 
        public IRPSSection<DocumentEntityView> GeneralData { get; set; } 
        public IRPSSection<DocumentEntityView> UserPermissions { get; set; } 
        public IRPSSection<DocumentEntityView> RolePermissions { get; set; } 
        public IRPSSection<DocumentEntityView> Content { get; set; } 
        public IRPSSection<DocumentEntityView> UsedIn { get; set; } 
        public IRPSSection<DocumentEntityView> Opinions { get; set; } 
        public IRPSSection<DocumentEntityView> VariableValues { get; set; } 
        public IRPSSection<DocumentEntityView> History { get; set; } 
        public IRPSSection<DocumentEntityView> RelatedEntities { get; set; } 
        public DocumentsSearch Screen { get; set; }
        public DocumentEntityView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class DocumentPermissionsUserCollectionEditor<DocumentEntityView,DocumentHistoryView>:RPSCollectionEditor<DocumentEntityView,DocumentHistoryView> where DocumentEntityView : class, IView where DocumentHistoryView : class, IView
    {
        public  DocumentPermissionsUserGridView<DocumentEntityView,DocumentHistoryView> GridView {get;set;}
    }
    public partial class DocumentPermissionsUserGridView <DocumentEntityView,DocumentHistoryView> :  RPSGridView<DocumentEntityView,DocumentHistoryView> where DocumentEntityView : class, IView where DocumentHistoryView : class, IView
    {
        public DocumentPermissionsUserGridView(DocumentEntityView currentView,DocumentHistoryView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            CodUser = RPSControlFactory.CreateRPSGridComboBox<DocumentEntityView>("","#34356985-9ad7-468e-ab0a-b1ff0d74d622 .ag-row[role='row']@ROWINDEX [col-id='cCodUser']","",false, this.CurrentView);
 
            Allow = RPSControlFactory.CreateRPSGridEnumComboBox<DocumentEntityView>("","#34356985-9ad7-468e-ab0a-b1ff0d74d622 .ag-row[role='row']@ROWINDEX [col-id='cAllow']","",true, this.CurrentView);
 

        }
        public IRPSGridComboBox<DocumentEntityView> CodUser { get; set; } 
        public IRPSGridComboBox<DocumentEntityView> Allow { get; set; } 
                     
    }
 
        public partial class DocumentPermissionsRoleCollectionEditor<DocumentEntityView,DocumentHistoryView>:RPSCollectionEditor<DocumentEntityView,DocumentHistoryView> where DocumentEntityView : class, IView where DocumentHistoryView : class, IView
    {
        public  DocumentPermissionsRoleGridView<DocumentEntityView,DocumentHistoryView> GridView {get;set;}
    }
    public partial class DocumentPermissionsRoleGridView <DocumentEntityView,DocumentHistoryView> :  RPSGridView<DocumentEntityView,DocumentHistoryView> where DocumentEntityView : class, IView where DocumentHistoryView : class, IView
    {
        public DocumentPermissionsRoleGridView(DocumentEntityView currentView,DocumentHistoryView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            CodRole = RPSControlFactory.CreateRPSGridComboBox<DocumentEntityView>("","#f2c89620-7851-478e-b547-f81d51be0013 .ag-row[role='row']@ROWINDEX [col-id='cCodRole']","",false, this.CurrentView);
 
            Allow = RPSControlFactory.CreateRPSGridEnumComboBox<DocumentEntityView>("","#f2c89620-7851-478e-b547-f81d51be0013 .ag-row[role='row']@ROWINDEX [col-id='cAllow']","",true, this.CurrentView);
 

        }
        public IRPSGridComboBox<DocumentEntityView> CodRole { get; set; } 
        public IRPSGridComboBox<DocumentEntityView> Allow { get; set; } 
                     
    }
 
        public partial class TagsDocumentForUserCollectionEditor<DocumentEntityView,DocumentHistoryView>:RPSCollectionEditor<DocumentEntityView,DocumentHistoryView> where DocumentEntityView : class, IView where DocumentHistoryView : class, IView
    {
        public  TagsDocumentForUserGridView<DocumentEntityView,DocumentHistoryView> GridView {get;set;}
    }
    public partial class TagsDocumentForUserGridView <DocumentEntityView,DocumentHistoryView> :  RPSGridView<DocumentEntityView,DocumentHistoryView> where DocumentEntityView : class, IView where DocumentHistoryView : class, IView
    {
        public TagsDocumentForUserGridView(DocumentEntityView currentView,DocumentHistoryView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            RemoveDocumentTagCommand = RPSControlFactory.CreateRPSGridButton<DocumentEntityView>( "","#5762415d-57b1-4eed-bea8-dd155773634a .ag-row[role='row']@ROWINDEX [col-id='cRemoveDocumentTagCommand']","",this.CurrentView);
 
            Tag_InsertionTime = RPSControlFactory.CreateRPSGridTextBox<DocumentEntityView>("","#5762415d-57b1-4eed-bea8-dd155773634a .ag-row[role='row']@ROWINDEX [col-id='cTag_InsertionTime']","",false, this.CurrentView);
 
            Tag_Comment = RPSControlFactory.CreateRPSGridMemoTextBox<DocumentEntityView>("","#5762415d-57b1-4eed-bea8-dd155773634a .ag-row[role='row']@ROWINDEX [col-id='cTag_Comment']","",false, this.CurrentView);
 
            Tag_Scope = RPSControlFactory.CreateRPSGridTextBox<DocumentEntityView>("","#5762415d-57b1-4eed-bea8-dd155773634a .ag-row[role='row']@ROWINDEX [col-id='cTag_Scope']","",false, this.CurrentView);
 

        }
        public IRPSGridButton<DocumentEntityView> RemoveDocumentTagCommand { get; set; } 
        public IRPSGridTextBox<DocumentEntityView> Tag_InsertionTime { get; set; } 
        public IRPSGridTextBox<DocumentEntityView> Tag_Comment { get; set; } 
        public IRPSGridTextBox<DocumentEntityView> Tag_Scope { get; set; } 
                     
    }
 
        public partial class DocumentVariableValuesCollectionEditor<DocumentEntityView,DocumentHistoryView>:RPSCollectionEditor<DocumentEntityView,DocumentHistoryView> where DocumentEntityView : class, IView where DocumentHistoryView : class, IView
    {
        public  DocumentVariableValuesGridView<DocumentEntityView,DocumentHistoryView> GridView {get;set;}
    }
    public partial class DocumentVariableValuesGridView <DocumentEntityView,DocumentHistoryView> :  RPSGridView<DocumentEntityView,DocumentHistoryView> where DocumentEntityView : class, IView where DocumentHistoryView : class, IView
    {
        public DocumentVariableValuesGridView(DocumentEntityView currentView,DocumentHistoryView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            IDDocumentLabel = RPSControlFactory.CreateRPSGridComboBox<DocumentEntityView>("","#bf9f7842-4676-4570-8932-0bb114bc0474 .ag-row[role='row']@ROWINDEX [col-id='cIDDocumentLabel']","",true, this.CurrentView);
 
            IsMapped = RPSControlFactory.CreateRPSGridCheckBox<DocumentEntityView>("","#bf9f7842-4676-4570-8932-0bb114bc0474 .ag-row[role='row']@ROWINDEX [col-id='cIsMapped']","",false, this.CurrentView);
 

        }
        public IRPSGridComboBox<DocumentEntityView> IDDocumentLabel { get; set; } 
        public IRPSGridCheckbox<DocumentEntityView> IsMapped { get; set; } 
                     
    }
 
        public partial class DocumentHistorysCollectionEditor<DocumentEntityView,DocumentHistoryView>:RPSCollectionEditor<DocumentEntityView,DocumentHistoryView> where DocumentEntityView : class, IView where DocumentHistoryView : class, IView
    {
        public  DocumentHistorysGridView<DocumentEntityView,DocumentHistoryView> GridView {get;set;}
    }
    public partial class DocumentHistorysGridView <DocumentEntityView,DocumentHistoryView> :  RPSGridView<DocumentEntityView,DocumentHistoryView> where DocumentEntityView : class, IView where DocumentHistoryView : class, IView
    {
        public DocumentHistorysGridView(DocumentEntityView currentView,DocumentHistoryView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            DownloadHistoryCommand = RPSControlFactory.CreateRPSGridButton<DocumentEntityView>( "","#a9b7ec1d-f6e3-49b4-b6bb-1a4f46c47226 .ag-row[role='row']@ROWINDEX [col-id='cDownloadHistoryCommand']","",this.CurrentView);
 
            RevisionNumber = RPSControlFactory.CreateRPSGridFormattedTextBox<DocumentEntityView>("","#a9b7ec1d-f6e3-49b4-b6bb-1a4f46c47226 .ag-row[role='row']@ROWINDEX [col-id='cRevisionNumber']","",true, this.CurrentView);
 
            RevisionUser = RPSControlFactory.CreateRPSGridTextBox<DocumentEntityView>("","#a9b7ec1d-f6e3-49b4-b6bb-1a4f46c47226 .ag-row[role='row']@ROWINDEX [col-id='cRevisionUser']","",true, this.CurrentView);
 
            RevisionMachine = RPSControlFactory.CreateRPSGridTextBox<DocumentEntityView>("","#a9b7ec1d-f6e3-49b4-b6bb-1a4f46c47226 .ag-row[role='row']@ROWINDEX [col-id='cRevisionMachine']","",false, this.CurrentView);
 
            RevisionDate = RPSControlFactory.CreateRPSGridTextBox<DocumentEntityView>("","#a9b7ec1d-f6e3-49b4-b6bb-1a4f46c47226 .ag-row[role='row']@ROWINDEX [col-id='cRevisionDate']","",true, this.CurrentView);
 
            RevisionTime = RPSControlFactory.CreateRPSGridTextBox<DocumentEntityView>("","#a9b7ec1d-f6e3-49b4-b6bb-1a4f46c47226 .ag-row[role='row']@ROWINDEX [col-id='cRevisionTime']","",true, this.CurrentView);
 
            Version = RPSControlFactory.CreateRPSGridTextBox<DocumentEntityView>("","#a9b7ec1d-f6e3-49b4-b6bb-1a4f46c47226 .ag-row[role='row']@ROWINDEX [col-id='cVersion']","",false, this.CurrentView);
 
            DocumentSituation = RPSControlFactory.CreateRPSGridTextBox<DocumentEntityView>("","#a9b7ec1d-f6e3-49b4-b6bb-1a4f46c47226 .ag-row[role='row']@ROWINDEX [col-id='cDocumentSituation']","",false, this.CurrentView);
 
            Comment = RPSControlFactory.CreateRPSGridMemoTextBox<DocumentEntityView>("","#a9b7ec1d-f6e3-49b4-b6bb-1a4f46c47226 .ag-row[role='row']@ROWINDEX [col-id='cComment']","",false, this.CurrentView);
 

        }
        public IRPSGridButton<DocumentEntityView> DownloadHistoryCommand { get; set; } 
        public IRPSGridTextBox<DocumentEntityView> RevisionNumber { get; set; } 
        public IRPSGridTextBox<DocumentEntityView> RevisionUser { get; set; } 
        public IRPSGridTextBox<DocumentEntityView> RevisionMachine { get; set; } 
        public IRPSGridTextBox<DocumentEntityView> RevisionDate { get; set; } 
        public IRPSGridTextBox<DocumentEntityView> RevisionTime { get; set; } 
        public IRPSGridTextBox<DocumentEntityView> Version { get; set; } 
        public IRPSGridTextBox<DocumentEntityView> DocumentSituation { get; set; } 
        public IRPSGridTextBox<DocumentEntityView> Comment { get; set; } 
                     
    }
 
        public partial class EntityDocumentsForIDDocumentCollectionEditor<DocumentEntityView,DocumentHistoryView>:RPSCollectionEditor<DocumentEntityView,DocumentHistoryView> where DocumentEntityView : class, IView where DocumentHistoryView : class, IView
    {
        public  EntityDocumentsForIDDocumentGridView<DocumentEntityView,DocumentHistoryView> GridView {get;set;}
    }
    public partial class EntityDocumentsForIDDocumentGridView <DocumentEntityView,DocumentHistoryView> :  RPSGridView<DocumentEntityView,DocumentHistoryView> where DocumentEntityView : class, IView where DocumentHistoryView : class, IView
    {
        public EntityDocumentsForIDDocumentGridView(DocumentEntityView currentView,DocumentHistoryView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            RemoveRelatedEntityCommand = RPSControlFactory.CreateRPSGridButton<DocumentEntityView>( "","#c862bd39-6cf2-4285-8b94-33d41fc87262 .ag-row[role='row']@ROWINDEX [col-id='cRemoveRelatedEntityCommand']","",this.CurrentView);
 
            EntityDocument_EntityType = RPSControlFactory.CreateRPSGridTextBox<DocumentEntityView>("","#c862bd39-6cf2-4285-8b94-33d41fc87262 .ag-row[role='row']@ROWINDEX [col-id='cEntityDocument_EntityType']","",false, this.CurrentView);
 

        }
        public IRPSGridButton<DocumentEntityView> RemoveRelatedEntityCommand { get; set; } 
        public IRPSGridTextBox<DocumentEntityView> EntityDocument_EntityType { get; set; } 
                     
    }
 
    }
  
            
    public partial class DocumentHistoryView : View
    {
        public DocumentHistoryView(DocumentsSearch screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            DeleteButton = RPSControlFactory.RPSDeleteButton<DocumentHistoryView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<DocumentHistoryView,DocumentEntityView>( this,Screen.DocumentEntityView);
 
            BackButton = RPSControlFactory.RPSBackButton<DocumentHistoryView,DocumentEntityView>( this,Screen.DocumentEntityView);
 
            AcceptButton = RPSControlFactory.RPSAcceptButton<DocumentHistoryView,DocumentEntityView>( this,Screen.DocumentEntityView);
 
            RevisionNumber = RPSControlFactory.CreateRPSTextBox<DocumentHistoryView>("5863f485-abf6-49d5-98cd-78ea1b5ac201","","",false, this);
 
            RevisionUser = RPSControlFactory.CreateRPSTextBox<DocumentHistoryView>("1ffc75a2-f607-42df-92b4-20743eaba9ad","","",false, this);
 
            RevisionMachine = RPSControlFactory.CreateRPSTextBox<DocumentHistoryView>("9bb07a73-1aa6-4e1d-88e6-f87ffdd22a61","","",false, this);
 
            Annotation = RPSControlFactory.CreateRPSTextBox<DocumentHistoryView>("d59a797d-adf0-477e-8b8d-c0b05bec5b1d","","",false, this);
 
            Comment = RPSControlFactory.CreateRPSTextBox<DocumentHistoryView>("760d0df6-8064-4fce-9f4d-cfd1be873dee","","",false, this);
 
            Version = RPSControlFactory.CreateRPSTextBox<DocumentHistoryView>("45fc2926-acf6-4f00-9939-5273d7a955d0","","",false, this);
 
            DocumentSituation = RPSControlFactory.CreateRPSTextBox<DocumentHistoryView>("9660a38a-b5b4-4c8c-b0ee-1f0134ef13b3","","",false, this);
 
            RevisionNumber1 = RPSControlFactory.CreateRPSTextBox<DocumentHistoryView>("8dd7a29a-2d27-4c40-9745-1b9d8b4bbd62","","",false, this);
 
            RevisionUser1 = RPSControlFactory.CreateRPSTextBox<DocumentHistoryView>("f04d0797-1e25-4b1c-9a23-9784d8283209","","",false, this);
 
            RevisionMachine1 = RPSControlFactory.CreateRPSTextBox<DocumentHistoryView>("b2ae4dce-1249-4593-8678-39c7a7363eb8","","",false, this);
 
            Annotation1 = RPSControlFactory.CreateRPSTextBox<DocumentHistoryView>("22cfe1c5-e48c-4906-b06a-181b062a3d79","","",false, this);
 
            Comment1 = RPSControlFactory.CreateRPSTextBox<DocumentHistoryView>("8ea3bbfb-11c9-4737-a04a-0c3c359aa56d","","",false, this);
 
            Version1 = RPSControlFactory.CreateRPSTextBox<DocumentHistoryView>("1764389b-698a-4e5b-88de-dc0873c9cbb7","","",false, this);
 
            DocumentSituation1 = RPSControlFactory.CreateRPSTextBox<DocumentHistoryView>("f30498f6-0521-4cd1-bdf4-27ff403862ce","","",false, this);
 
            RevisionNumber2 = RPSControlFactory.CreateRPSFormattedTextBox<DocumentHistoryView>("622250b2-6b39-4139-ba34-8ea058cb9641","","",true, this);
 
            Version2 = RPSControlFactory.CreateRPSTextBox<DocumentHistoryView>("a93a843c-53cd-482e-9440-e70984afa5cd","","",false, this);
 
            DocumentSituation2 = RPSControlFactory.CreateRPSTextBox<DocumentHistoryView>("96b2e593-6d43-43b7-abee-15170b317719","","",false, this);
 
            RevisionUser2 = RPSControlFactory.CreateRPSTextBox<DocumentHistoryView>("d1bba95e-d182-4de6-8cc4-ad1432515c61","","",true, this);
 
            RevisionMachine2 = RPSControlFactory.CreateRPSTextBox<DocumentHistoryView>("227f52d9-728b-4f51-a16e-6bc146b5f776","","",false, this);
 
            RevisionDate = RPSControlFactory.CreateRPSTextBox<DocumentHistoryView>("2febd523-fdb8-4024-a3d9-033b25e85a45","","",true, this);
 
            RevisionTime = RPSControlFactory.CreateRPSTextBox<DocumentHistoryView>("c3461e65-ee2a-455f-9e09-dd6ef77421d7","","",true, this);
 
            Comment2 = RPSControlFactory.CreateRPSTextBox<DocumentHistoryView>("84721399-1ac5-4440-8c59-1a145423066d","","",false, this);
 
            Annotation2 = RPSControlFactory.CreateRPSTextBox<DocumentHistoryView>("c7806bfe-c95f-44ef-94af-4bae3ba230d2","","",false, this);
 
            HistoryContent = RPSControlFactory.CreateRPSSection<DocumentHistoryView>( "","ul li[rpsid='76136f40-103c-4f1a-a887-a8defc54bad1']","",this);
 
            HistoryUsedIn = RPSControlFactory.CreateRPSSection<DocumentHistoryView>( "","ul li[rpsid='134449b8-b7f1-4934-9e15-f86d4118fb73']","",this);
 
            GeneralData = RPSControlFactory.CreateRPSSection<DocumentHistoryView>( "","ul li[rpsid='18953d00-28a1-4e0e-ae6f-5ba46574c72a']","",this);
 
            Comments = RPSControlFactory.CreateRPSSection<DocumentHistoryView>( "","ul li[rpsid='21a37e0a-d21e-40be-b82c-b946bf69d8e7']","",this);
 

        }
        public IRPSButton<DocumentHistoryView> DeleteButton { get; set; } 
        public IRPSButton<DocumentHistoryView,DocumentEntityView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<DocumentHistoryView,DocumentEntityView> BackButton { get; set; } 
        public IRPSAcceptButton<DocumentHistoryView,DocumentEntityView> AcceptButton { get; set; } 
        public IRPSTextBox<DocumentHistoryView> RevisionNumber { get; set; } 
        public IRPSTextBox<DocumentHistoryView> RevisionUser { get; set; } 
        public IRPSTextBox<DocumentHistoryView> RevisionMachine { get; set; } 
        public IRPSTextBox<DocumentHistoryView> Annotation { get; set; } 
        public IRPSTextBox<DocumentHistoryView> Comment { get; set; } 
        public IRPSTextBox<DocumentHistoryView> Version { get; set; } 
        public IRPSTextBox<DocumentHistoryView> DocumentSituation { get; set; } 
        public IRPSTextBox<DocumentHistoryView> RevisionNumber1 { get; set; } 
        public IRPSTextBox<DocumentHistoryView> RevisionUser1 { get; set; } 
        public IRPSTextBox<DocumentHistoryView> RevisionMachine1 { get; set; } 
        public IRPSTextBox<DocumentHistoryView> Annotation1 { get; set; } 
        public IRPSTextBox<DocumentHistoryView> Comment1 { get; set; } 
        public IRPSTextBox<DocumentHistoryView> Version1 { get; set; } 
        public IRPSTextBox<DocumentHistoryView> DocumentSituation1 { get; set; } 
        public IRPSTextBox<DocumentHistoryView> RevisionNumber2 { get; set; } 
        public IRPSTextBox<DocumentHistoryView> Version2 { get; set; } 
        public IRPSTextBox<DocumentHistoryView> DocumentSituation2 { get; set; } 
        public IRPSTextBox<DocumentHistoryView> RevisionUser2 { get; set; } 
        public IRPSTextBox<DocumentHistoryView> RevisionMachine2 { get; set; } 
        public IRPSTextBox<DocumentHistoryView> RevisionDate { get; set; } 
        public IRPSTextBox<DocumentHistoryView> RevisionTime { get; set; } 
        public IRPSTextBox<DocumentHistoryView> Comment2 { get; set; } 
        public IRPSTextBox<DocumentHistoryView> Annotation2 { get; set; } 
        public IRPSSection<DocumentHistoryView> HistoryContent { get; set; } 
        public IRPSSection<DocumentHistoryView> HistoryUsedIn { get; set; } 
        public IRPSSection<DocumentHistoryView> GeneralData { get; set; } 
        public IRPSSection<DocumentHistoryView> Comments { get; set; } 
        public DocumentsSearch Screen { get; set; }
        public DocumentHistoryView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class NewDocumentRelatedEntityDialogView : View
    {
        public NewDocumentRelatedEntityDialogView(DocumentsSearch screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            UIService = RPSControlFactory.CreateRPSEnumComboBox<NewDocumentRelatedEntityDialogView>("604b49c2-dd4e-41fb-8cd5-d1fb6102be7c","","",false, this);
 
            UIServiceEntity = RPSControlFactory.CreateRPSEnumComboBox<NewDocumentRelatedEntityDialogView>("6fae6189-117d-40e6-a81f-238cde19bdb7","","",false, this);
 

        }
        public IRPSComboBox<NewDocumentRelatedEntityDialogView> UIService { get; set; } 
        public IRPSComboBox<NewDocumentRelatedEntityDialogView> UIServiceEntity { get; set; } 
        public DocumentsSearch Screen { get; set; }
        public NewDocumentRelatedEntityDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class NewDocumentTagDialogView : View
    {
        public NewDocumentTagDialogView(DocumentsSearch screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            UIDueDate = RPSControlFactory.CreateRPSTextBox<NewDocumentTagDialogView>("8b5873b3-8b4c-412b-a646-959e63e9737a","","",false, this);
 
            Colors = RPSControlFactory.CreateRPSEnumComboBox<NewDocumentTagDialogView>("4bda2bb4-6728-4bce-ba82-db6e77b1e918","","",false, this);
 
            eScope = RPSControlFactory.CreateRPSEnumComboBox<NewDocumentTagDialogView>("2d633d86-8034-4e9d-a1f5-ae69e13717ad","","",false, this);
 
            UIUser = RPSControlFactory.CreateRPSCollectionComboBox<NewDocumentTagDialogView>("24d0ae9b-7ef6-4515-9f1e-f67759ded008","","",false, this);
 
            UIComment = RPSControlFactory.CreateRPSTextBox<NewDocumentTagDialogView>("355cd73e-852c-4d01-91a0-726e05f53159","","",false, this);
 

        }
        public IRPSTextBox<NewDocumentTagDialogView> UIDueDate { get; set; } 
        public IRPSComboBox<NewDocumentTagDialogView> Colors { get; set; } 
        public IRPSComboBox<NewDocumentTagDialogView> eScope { get; set; } 
        public IRPSCollectionComboBox<NewDocumentTagDialogView> UIUser { get; set; } 
        public IRPSTextBox<NewDocumentTagDialogView> UIComment { get; set; } 
        public DocumentsSearch Screen { get; set; }
        public NewDocumentTagDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class NewDocumentAssociationDialogView : View
    {
        public NewDocumentAssociationDialogView(DocumentsSearch screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            UIIDDocumentCategory = RPSControlFactory.CreateRPSComboBox<NewDocumentAssociationDialogView>("cca76cda-6008-48cb-b8cc-5c1b8079a3c0","","",false, this);
 
            CollectionInit params_DocumentsForCategory = new CollectionInit(){IDDescriptor = "b6770557-e377-48e7-af74-1749f3e3ad17",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="6c36e214-f2f1-4d19-b4b9-acb404521cc4",CSSSelectorGrid="",XPathGrid=""};
            DocumentsForCategory = RPSControlFactory.RPSCreateCollectionWithGrid<DocumentsForCategoryCollectionEditor<NewDocumentAssociationDialogView>,NewDocumentAssociationDialogView>( params_DocumentsForCategory,this);
 

        }
        public IRPSComboBox<NewDocumentAssociationDialogView> UIIDDocumentCategory { get; set; } 
        public DocumentsForCategoryCollectionEditor<NewDocumentAssociationDialogView> DocumentsForCategory { get; set; } 
        public DocumentsSearch Screen { get; set; }
        public NewDocumentAssociationDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class DocumentsForCategoryCollectionEditor<NewDocumentAssociationDialogView>:RPSCollectionEditor<NewDocumentAssociationDialogView> where NewDocumentAssociationDialogView : class, IView
    {
        public  DocumentsForCategoryGridView<NewDocumentAssociationDialogView> GridView {get;set;}
    }
    public partial class DocumentsForCategoryGridView <NewDocumentAssociationDialogView> :  RPSGridView<NewDocumentAssociationDialogView> where NewDocumentAssociationDialogView : class, IView
    {
        public DocumentsForCategoryGridView(NewDocumentAssociationDialogView currentView)
        {
            this.WebDriver = currentView.WebDriver;          
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            Document_LastRevisionDate = RPSControlFactory.CreateRPSGridTextBox<NewDocumentAssociationDialogView>("","#6c36e214-f2f1-4d19-b4b9-acb404521cc4 .ag-row[role='row']@ROWINDEX [col-id='cDocument_LastRevisionDate']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<NewDocumentAssociationDialogView> Document_LastRevisionDate { get; set; } 
                     
    }
 
    }
  
            
    public partial class FileCheckInDialogView : View
    {
        public FileCheckInDialogView(DocumentsSearch screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            Version = RPSControlFactory.CreateRPSTextBox<FileCheckInDialogView>("bdfd7612-f77d-4b38-ae5b-7a3788710cca","","",false, this);
 
            Comment = RPSControlFactory.CreateRPSTextBox<FileCheckInDialogView>("858f5463-dd37-4a73-ba68-f2c550466d2a","","",false, this);
 

        }
        public IRPSTextBox<FileCheckInDialogView> Version { get; set; } 
        public IRPSTextBox<FileCheckInDialogView> Comment { get; set; } 
        public DocumentsSearch Screen { get; set; }
        public FileCheckInDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class DocumentVariableValueView : View
    {
        public DocumentVariableValueView(DocumentsSearch screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            DeleteButton = RPSControlFactory.RPSDeleteButton<DocumentVariableValueView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<DocumentVariableValueView,DocumentEntityView>( this,Screen.DocumentEntityView);
 
            BackButton = RPSControlFactory.RPSBackButton<DocumentVariableValueView,DocumentEntityView>( this,Screen.DocumentEntityView);
 
            AcceptButton = RPSControlFactory.RPSAcceptButton<DocumentVariableValueView,DocumentEntityView>( this,Screen.DocumentEntityView);
 
            IDDocumentLabel = RPSControlFactory.CreateRPSComboBox<DocumentVariableValueView>("dbc30e83-d8fa-4479-a2cf-1d07529cce00","","",true, this);
 
            IsMapped = RPSControlFactory.CreateRPSCheckBox<DocumentVariableValueView>("df33b572-2219-410c-b371-3c1dde22e553","","",false, this);
 

        }
        public IRPSButton<DocumentVariableValueView> DeleteButton { get; set; } 
        public IRPSButton<DocumentVariableValueView,DocumentEntityView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<DocumentVariableValueView,DocumentEntityView> BackButton { get; set; } 
        public IRPSAcceptButton<DocumentVariableValueView,DocumentEntityView> AcceptButton { get; set; } 
        public IRPSComboBox<DocumentVariableValueView> IDDocumentLabel { get; set; } 
        public IRPSCheckbox<DocumentVariableValueView> IsMapped { get; set; } 
        public DocumentsSearch Screen { get; set; }
        public DocumentVariableValueView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class ChangeSituationDialogView : View
    {
        public ChangeSituationDialogView(DocumentsSearch screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            IDDocumentSituationFinal = RPSControlFactory.CreateRPSComboBox<ChangeSituationDialogView>("ab2483e5-1b96-4a5d-bf1e-194f9f6ef734","","",true, this);
 
            Document_RevisionNumber = RPSControlFactory.CreateRPSFormattedTextBox<ChangeSituationDialogView>("590dddc1-0fd6-45f1-adc0-09f6584628e5","","",false, this);
 
            DocumentLocation = RPSControlFactory.CreateRPSTextBox<ChangeSituationDialogView>("4ac8d5b6-4e83-4bf4-b9dd-7d9697e950cc","","",false, this);
 
            Document_CheckedOutBy = RPSControlFactory.CreateRPSTextBox<ChangeSituationDialogView>("efa6ab9b-641e-4ba7-a660-9acf9c2f9ba9","","",false, this);
 
            Document_CheckedOutMachine = RPSControlFactory.CreateRPSTextBox<ChangeSituationDialogView>("f1a60f3b-5984-4bd3-8e67-36a881bd82d9","","",false, this);
 
            Observations = RPSControlFactory.CreateRPSTextBox<ChangeSituationDialogView>("212b3c8e-056e-453b-b30e-9b03142c4125","","",false, this);
 
            Comment = RPSControlFactory.CreateRPSTextBox<ChangeSituationDialogView>("e2d84a56-513a-4cde-85e1-9b5f1ed4fd80","","",false, this);
 

        }
        public IRPSComboBox<ChangeSituationDialogView> IDDocumentSituationFinal { get; set; } 
        public IRPSTextBox<ChangeSituationDialogView> Document_RevisionNumber { get; set; } 
        public IRPSTextBox<ChangeSituationDialogView> DocumentLocation { get; set; } 
        public IRPSTextBox<ChangeSituationDialogView> Document_CheckedOutBy { get; set; } 
        public IRPSTextBox<ChangeSituationDialogView> Document_CheckedOutMachine { get; set; } 
        public IRPSTextBox<ChangeSituationDialogView> Observations { get; set; } 
        public IRPSTextBox<ChangeSituationDialogView> Comment { get; set; } 
        public DocumentsSearch Screen { get; set; }
        public ChangeSituationDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class ChangeDocumentCategoryDialogView : View
    {
        public ChangeDocumentCategoryDialogView(DocumentsSearch screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            IDDocumentCategory = RPSControlFactory.CreateRPSComboBox<ChangeDocumentCategoryDialogView>("409f4c8c-a4a0-46b9-b166-ddc812613f73","","",false, this);
 

        }
        public IRPSComboBox<ChangeDocumentCategoryDialogView> IDDocumentCategory { get; set; } 
        public DocumentsSearch Screen { get; set; }
        public ChangeDocumentCategoryDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class PackFileWizardDialogView : View
    {
        public PackFileWizardDialogView(DocumentsSearch screen) : base()
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
 
            CollectionInit params_RPSUsers = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="d5246bee-de8c-4052-8742-0e1379ddf733",CSSSelectorGrid="",XPathGrid=""};
            RPSUsers = RPSControlFactory.RPSCreateCollectionWithGrid<RPSUsersCollectionEditor<PackFileWizardDialogView>,PackFileWizardDialogView>( params_RPSUsers,this);
 
            CollectionInit params_ExternalUsers = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="7375a92e-161d-4dc8-a4c5-4807872cda46",CSSSelectorGrid="",XPathGrid=""};
            ExternalUsers = RPSControlFactory.RPSCreateCollectionWithGrid<ExternalUsersCollectionEditor<PackFileWizardDialogView>,PackFileWizardDialogView>( params_ExternalUsers,this);
 

        }
        public IRPSComboBox<PackFileWizardDialogView> PackFileOptions { get; set; } 
        public IRPSTextBox<PackFileWizardDialogView> DaysOfValidity { get; set; } 
        public IRPSTextBox<PackFileWizardDialogView> PackFileComment { get; set; } 
        public IRPSComboBox<PackFileWizardDialogView> IDPackFile { get; set; } 
        public IRPSCheckbox<PackFileWizardDialogView> PublishPackage { get; set; } 
        public RPSUsersCollectionEditor<PackFileWizardDialogView> RPSUsers { get; set; } 
        public ExternalUsersCollectionEditor<PackFileWizardDialogView> ExternalUsers { get; set; } 
        public DocumentsSearch Screen { get; set; }
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
            CodUser = RPSControlFactory.CreateRPSGridComboBox<PackFileWizardDialogView>("","#d5246bee-de8c-4052-8742-0e1379ddf733 .ag-row[role='row']@ROWINDEX [col-id='cCodUser']","",false, this.CurrentView);
 

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
            ExternalUserDescription = RPSControlFactory.CreateRPSGridTextBox<PackFileWizardDialogView>("","#7375a92e-161d-4dc8-a4c5-4807872cda46 .ag-row[role='row']@ROWINDEX [col-id='cExternalUserDescription']","",false, this.CurrentView);
 
            ExternalUserEmailToInvite = RPSControlFactory.CreateRPSGridEmailTextBox<PackFileWizardDialogView>("","#7375a92e-161d-4dc8-a4c5-4807872cda46 .ag-row[role='row']@ROWINDEX [col-id='cExternalUserEmailToInvite']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<PackFileWizardDialogView> ExternalUserDescription { get; set; } 
        public IRPSGridTextBox<PackFileWizardDialogView> ExternalUserEmailToInvite { get; set; } 
                     
    }
 
    }
  
    

}