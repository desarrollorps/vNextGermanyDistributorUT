    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.Documents.DocumentCategory
{
    //RPS VERSION 1.0.0.0
    public partial class DocumentCategory:Screen
    {
        public DocumentCategory():base()
        {
            this.URL = "documents.documentcategory";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            DocumentCategoryVMTreeView  = new DocumentCategoryVMTreeView(this); 
            DocumentCategoryVMEntityView  = new DocumentCategoryVMEntityView(this); 
            CategoryDocumentsView  = new CategoryDocumentsView(this); 
            FileUploadDialogView  = new FileUploadDialogView(this); 
            PackFileWizardDialogView  = new PackFileWizardDialogView(this); 
            DocumentCategoryVMTreeView.InitializeControls(); 
            DocumentCategoryVMEntityView.InitializeControls(); 
            CategoryDocumentsView.InitializeControls(); 
            FileUploadDialogView.InitializeControls(); 
            PackFileWizardDialogView.InitializeControls(); 
           
        }
      
            public DocumentCategoryVMTreeView DocumentCategoryVMTreeView {get; set; } 
            public DocumentCategoryVMEntityView DocumentCategoryVMEntityView {get; set; } 
            public CategoryDocumentsView CategoryDocumentsView {get; set; } 
            public FileUploadDialogView FileUploadDialogView {get; set; } 
            public PackFileWizardDialogView PackFileWizardDialogView {get; set; } 
    }
            
    public partial class DocumentCategoryVMTreeView : View
    {
        public DocumentCategoryVMTreeView(DocumentCategory screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {

        }
        public DocumentCategory Screen { get; set; }
        public DocumentCategoryVMTreeView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class DocumentCategoryVMEntityView : View
    {
        public DocumentCategoryVMEntityView(DocumentCategory screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            SaveButton = RPSControlFactory.RPSSaveButton<DocumentCategoryVMEntityView>( this);
 
            DeleteButton = RPSControlFactory.RPSDeleteButton<DocumentCategoryVMEntityView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<DocumentCategoryVMEntityView,CategoryDocumentsView>( this,Screen.CategoryDocumentsView);
 
            BackButton = RPSControlFactory.RPSBackButton<DocumentCategoryVMEntityView,CategoryDocumentsView>( this,Screen.CategoryDocumentsView);
 
            CodCategory = RPSControlFactory.CreateRPSTextBox<DocumentCategoryVMEntityView>("3f3293ec-f257-459f-9026-55bc6716e079","","",true, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<DocumentCategoryVMEntityView>("0ca127f4-f164-4cd6-a8e9-b166b2d5eae8","","",false, this);
 
            IDDocumentSituationInitial = RPSControlFactory.CreateRPSComboBox<DocumentCategoryVMEntityView>("44cd48e3-82a0-49d4-b3cd-41798f08c63e","","",false, this);
 
            IDDocumentType = RPSControlFactory.CreateRPSComboBox<DocumentCategoryVMEntityView>("5c2e6b69-8d6a-4961-889e-405cf62cdc2a","","",false, this);
 
            CustomerManagement = RPSControlFactory.CreateRPSCheckBox<DocumentCategoryVMEntityView>("b49b423e-498b-4828-8e22-59fc2d37ac94","","",true, this);
 
            SupplierManagement = RPSControlFactory.CreateRPSCheckBox<DocumentCategoryVMEntityView>("e9913911-7a75-4d04-830f-2a5822f67a96","","",true, this);
 
            KeyLabel1 = RPSControlFactory.CreateRPSTextBox<DocumentCategoryVMEntityView>("55c692ff-6ef7-4542-93ae-e2c205b5df27","","",false, this);
 
            KeyDefaultValue1 = RPSControlFactory.CreateRPSTextBox<DocumentCategoryVMEntityView>("057149fd-a160-4291-a776-bc6428825b60","","",false, this);
 
            KeyLinkType1 = RPSControlFactory.CreateRPSEnumComboBox<DocumentCategoryVMEntityView>("6b489db9-90d9-4875-a333-bb114d8e29a8","","",true, this);
 
            KeyLinkProperty1 = RPSControlFactory.CreateRPSTextBox<DocumentCategoryVMEntityView>("1846a52d-d734-4ce1-870b-efcc16f27c0b","","",false, this);
 
            KeyLabel2 = RPSControlFactory.CreateRPSTextBox<DocumentCategoryVMEntityView>("92f8939d-578a-425d-baa9-9e8b753c3d44","","",false, this);
 
            KeyDefaultValue2 = RPSControlFactory.CreateRPSTextBox<DocumentCategoryVMEntityView>("8663e816-c088-4b9c-a590-978fc3dcbc3b","","",false, this);
 
            KeyLinkType2 = RPSControlFactory.CreateRPSEnumComboBox<DocumentCategoryVMEntityView>("ce11378e-cd7d-4541-abee-81115faa62a0","","",true, this);
 
            KeyLinkProperty2 = RPSControlFactory.CreateRPSTextBox<DocumentCategoryVMEntityView>("ddbc3480-b2c3-4dcd-8693-15e53ff3c1c7","","",false, this);
 
            KeyLabel3 = RPSControlFactory.CreateRPSTextBox<DocumentCategoryVMEntityView>("56290307-ea10-45bf-8ec2-c1654abff394","","",false, this);
 
            KeyDefaultValue3 = RPSControlFactory.CreateRPSTextBox<DocumentCategoryVMEntityView>("d3cf31c1-3e49-470e-995a-fbbd8eaa05a5","","",false, this);
 
            KeyLinkType3 = RPSControlFactory.CreateRPSEnumComboBox<DocumentCategoryVMEntityView>("9e3fff20-ba82-4736-a2eb-b96a7f193fff","","",true, this);
 
            KeyLinkProperty3 = RPSControlFactory.CreateRPSTextBox<DocumentCategoryVMEntityView>("75097496-d9f9-4976-8437-657465ff2e33","","",false, this);
 
            KeyLabel4 = RPSControlFactory.CreateRPSTextBox<DocumentCategoryVMEntityView>("a8db70ec-4066-482a-99b1-3768eee445e7","","",false, this);
 
            KeyDefaultValue4 = RPSControlFactory.CreateRPSTextBox<DocumentCategoryVMEntityView>("90c44389-fa7d-42b3-8dcc-a04608f4123b","","",false, this);
 
            KeyLinkType4 = RPSControlFactory.CreateRPSEnumComboBox<DocumentCategoryVMEntityView>("90cd9e12-b235-4510-99e3-682f03a0b908","","",true, this);
 
            KeyLinkProperty4 = RPSControlFactory.CreateRPSTextBox<DocumentCategoryVMEntityView>("3c66f65d-21ea-483d-bda0-9dcc0046d4bf","","",false, this);
 
            KeyLabel5 = RPSControlFactory.CreateRPSTextBox<DocumentCategoryVMEntityView>("7b04564b-429d-4ddd-86e8-8e6fe1c49c55","","",false, this);
 
            KeyDefaultValue5 = RPSControlFactory.CreateRPSTextBox<DocumentCategoryVMEntityView>("38862dff-f54e-4fe1-9c4e-04521bb67e29","","",false, this);
 
            KeyLinkType5 = RPSControlFactory.CreateRPSEnumComboBox<DocumentCategoryVMEntityView>("450a5e0c-9e7e-438b-8e20-20edce2c3ec9","","",true, this);
 
            KeyLinkProperty5 = RPSControlFactory.CreateRPSTextBox<DocumentCategoryVMEntityView>("4f1a6947-e949-4277-8f55-09cfb0357dda","","",false, this);
 
            KeyLabel6 = RPSControlFactory.CreateRPSTextBox<DocumentCategoryVMEntityView>("bf473908-4502-4fd1-b960-865f129430c9","","",false, this);
 
            KeyDefaultValue6 = RPSControlFactory.CreateRPSTextBox<DocumentCategoryVMEntityView>("3f7c0139-95e2-4d04-8957-b11d1105641e","","",false, this);
 
            KeyLinkType6 = RPSControlFactory.CreateRPSEnumComboBox<DocumentCategoryVMEntityView>("8b6dc47c-0f70-4767-bdc8-bbb9d8ccade0","","",true, this);
 
            KeyLinkProperty6 = RPSControlFactory.CreateRPSTextBox<DocumentCategoryVMEntityView>("93771dfc-abd0-4d95-8dc2-d0f8a435b797","","",false, this);
 
            KeyLabel7 = RPSControlFactory.CreateRPSTextBox<DocumentCategoryVMEntityView>("0cbf5a7e-8717-4982-a7f1-ddd4e2551c25","","",false, this);
 
            KeyDefaultValue7 = RPSControlFactory.CreateRPSTextBox<DocumentCategoryVMEntityView>("f3fa55ba-16c8-479d-a334-2d3c59035477","","",false, this);
 
            KeyLinkType7 = RPSControlFactory.CreateRPSEnumComboBox<DocumentCategoryVMEntityView>("e5ab4d06-f011-495c-ab5a-d263b3942a3f","","",true, this);
 
            KeyLinkProperty7 = RPSControlFactory.CreateRPSTextBox<DocumentCategoryVMEntityView>("290557c1-50fa-41b8-8e3c-150da22c9cf1","","",false, this);
 
            KeyLabel8 = RPSControlFactory.CreateRPSTextBox<DocumentCategoryVMEntityView>("839d16e5-1c55-4722-85fc-b7e1c8618520","","",false, this);
 
            KeyDefaultValue8 = RPSControlFactory.CreateRPSTextBox<DocumentCategoryVMEntityView>("d8febb8d-61b3-413c-8c35-b7f510f383a9","","",false, this);
 
            KeyLinkType8 = RPSControlFactory.CreateRPSEnumComboBox<DocumentCategoryVMEntityView>("fe757d96-f988-46ea-ab60-409398f6f1cb","","",true, this);
 
            KeyLinkProperty8 = RPSControlFactory.CreateRPSTextBox<DocumentCategoryVMEntityView>("a0418228-1020-431b-a66b-f4f497d9c212","","",false, this);
 
            KeyLabel9 = RPSControlFactory.CreateRPSTextBox<DocumentCategoryVMEntityView>("314dd060-5644-48d2-8418-bc0ceec5d3cd","","",false, this);
 
            KeyDefaultValue9 = RPSControlFactory.CreateRPSTextBox<DocumentCategoryVMEntityView>("1ca4c4f7-8fc8-43f6-83a6-06fb1e993fe1","","",false, this);
 
            KeyLinkType9 = RPSControlFactory.CreateRPSEnumComboBox<DocumentCategoryVMEntityView>("78edc394-32a3-4851-af30-a11172c6527f","","",true, this);
 
            KeyLinkProperty9 = RPSControlFactory.CreateRPSTextBox<DocumentCategoryVMEntityView>("88bd9717-d603-49e1-949c-50a599cf844c","","",false, this);
 
            KeyLabel10 = RPSControlFactory.CreateRPSTextBox<DocumentCategoryVMEntityView>("24d4ba52-89e6-4f5e-9fcb-4c5ac77d7fc0","","",false, this);
 
            KeyDefaultValue10 = RPSControlFactory.CreateRPSTextBox<DocumentCategoryVMEntityView>("cb65e712-81a0-4ff7-8a46-bd3b96b404f5","","",false, this);
 
            KeyLinkType10 = RPSControlFactory.CreateRPSEnumComboBox<DocumentCategoryVMEntityView>("0c1e0eaa-c13c-4276-b7ec-d82239a50be9","","",true, this);
 
            KeyLinkProperty101 = RPSControlFactory.CreateRPSTextBox<DocumentCategoryVMEntityView>("a55eec49-cc66-4191-9a48-b4593119d0bd","","",false, this);
 
            ExecuteAddCategorySubscriptionButton = RPSControlFactory.CreateRPSButton<DocumentCategoryVMEntityView>( "a29ebbf1-76b3-443a-99ad-9dd76495e1cf","","",this);
 
            ExecuteRemoveCategorySubscriptionButton = RPSControlFactory.CreateRPSButton<DocumentCategoryVMEntityView>( "145cb674-c2c2-4099-8d37-9cd45073829e","","",this);
 
            ExecuteResetPermissionsButton = RPSControlFactory.CreateRPSButton<DocumentCategoryVMEntityView>( "20b2b62e-50a0-4b90-a71e-9b83f6d2f056","","",this);
 
            CollectionInit params_DocumentKeysByLang = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="9d024665-b9e5-4458-8415-425e32f968a3",CSSSelectorGrid="",XPathGrid=""};
            DocumentKeysByLang = RPSControlFactory.RPSCreateCollectionWithGrid<DocumentKeysByLangCollectionEditor<DocumentCategoryVMEntityView>,DocumentCategoryVMEntityView>( params_DocumentKeysByLang,this);
 
            CollectionInit params_DocumentCategoryPermsUser = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="c555ad20-79be-4877-84d6-09a65ac757e8",CSSSelectorGrid="",XPathGrid=""};
            DocumentCategoryPermsUser = RPSControlFactory.RPSCreateCollectionWithGrid<DocumentCategoryPermsUserCollectionEditor<DocumentCategoryVMEntityView>,DocumentCategoryVMEntityView>( params_DocumentCategoryPermsUser,this);
 
            CollectionInit params_DocumentCategoryPermsRole = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="6031c2fd-a69d-475e-9299-9b47e062ee4f",CSSSelectorGrid="",XPathGrid=""};
            DocumentCategoryPermsRole = RPSControlFactory.RPSCreateCollectionWithGrid<DocumentCategoryPermsRoleCollectionEditor<DocumentCategoryVMEntityView>,DocumentCategoryVMEntityView>( params_DocumentCategoryPermsRole,this);
 
            CollectionInit params_CategorySituationChangePerms = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="9ecbc7e8-dc2e-44f9-81dc-30dd36687ba6",CSSSelectorGrid="",XPathGrid=""};
            CategorySituationChangePerms = RPSControlFactory.RPSCreateCollectionWithGrid<CategorySituationChangePermsCollectionEditor<DocumentCategoryVMEntityView>,DocumentCategoryVMEntityView>( params_CategorySituationChangePerms,this);
 
            GeneralData = RPSControlFactory.CreateRPSSection<DocumentCategoryVMEntityView>( "","ul li[rpsid='90413050-d759-499d-838f-c1181fb7d685']","",this);
 
            Section = RPSControlFactory.CreateRPSSection<DocumentCategoryVMEntityView>( "","ul li[rpsid='144865cd-80fd-4f56-89d6-05707b483baf']","",this);
 
            UserPermissions = RPSControlFactory.CreateRPSSection<DocumentCategoryVMEntityView>( "","ul li[rpsid='1c9c4b72-8fc9-4eb7-b735-9841fe5b70b1']","",this);
 
            RolePermissions = RPSControlFactory.CreateRPSSection<DocumentCategoryVMEntityView>( "","ul li[rpsid='24c9001c-1757-498b-8bba-836274489220']","",this);
 
            SituationChangePermissions = RPSControlFactory.CreateRPSSection<DocumentCategoryVMEntityView>( "","ul li[rpsid='c59d1673-046b-47fc-93f6-392763c5285f']","",this);
 

        }
        public IRPSSaveButton<DocumentCategoryVMEntityView> SaveButton { get; set; } 
        public IRPSButton<DocumentCategoryVMEntityView> DeleteButton { get; set; } 
        public IRPSButton<DocumentCategoryVMEntityView,CategoryDocumentsView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<DocumentCategoryVMEntityView,CategoryDocumentsView> BackButton { get; set; } 
        public IRPSTextBox<DocumentCategoryVMEntityView> CodCategory { get; set; } 
        public IRPSTextBox<DocumentCategoryVMEntityView> Description { get; set; } 
        public IRPSComboBox<DocumentCategoryVMEntityView> IDDocumentSituationInitial { get; set; } 
        public IRPSComboBox<DocumentCategoryVMEntityView> IDDocumentType { get; set; } 
        public IRPSCheckbox<DocumentCategoryVMEntityView> CustomerManagement { get; set; } 
        public IRPSCheckbox<DocumentCategoryVMEntityView> SupplierManagement { get; set; } 
        public IRPSTextBox<DocumentCategoryVMEntityView> KeyLabel1 { get; set; } 
        public IRPSTextBox<DocumentCategoryVMEntityView> KeyDefaultValue1 { get; set; } 
        public IRPSComboBox<DocumentCategoryVMEntityView> KeyLinkType1 { get; set; } 
        public IRPSTextBox<DocumentCategoryVMEntityView> KeyLinkProperty1 { get; set; } 
        public IRPSTextBox<DocumentCategoryVMEntityView> KeyLabel2 { get; set; } 
        public IRPSTextBox<DocumentCategoryVMEntityView> KeyDefaultValue2 { get; set; } 
        public IRPSComboBox<DocumentCategoryVMEntityView> KeyLinkType2 { get; set; } 
        public IRPSTextBox<DocumentCategoryVMEntityView> KeyLinkProperty2 { get; set; } 
        public IRPSTextBox<DocumentCategoryVMEntityView> KeyLabel3 { get; set; } 
        public IRPSTextBox<DocumentCategoryVMEntityView> KeyDefaultValue3 { get; set; } 
        public IRPSComboBox<DocumentCategoryVMEntityView> KeyLinkType3 { get; set; } 
        public IRPSTextBox<DocumentCategoryVMEntityView> KeyLinkProperty3 { get; set; } 
        public IRPSTextBox<DocumentCategoryVMEntityView> KeyLabel4 { get; set; } 
        public IRPSTextBox<DocumentCategoryVMEntityView> KeyDefaultValue4 { get; set; } 
        public IRPSComboBox<DocumentCategoryVMEntityView> KeyLinkType4 { get; set; } 
        public IRPSTextBox<DocumentCategoryVMEntityView> KeyLinkProperty4 { get; set; } 
        public IRPSTextBox<DocumentCategoryVMEntityView> KeyLabel5 { get; set; } 
        public IRPSTextBox<DocumentCategoryVMEntityView> KeyDefaultValue5 { get; set; } 
        public IRPSComboBox<DocumentCategoryVMEntityView> KeyLinkType5 { get; set; } 
        public IRPSTextBox<DocumentCategoryVMEntityView> KeyLinkProperty5 { get; set; } 
        public IRPSTextBox<DocumentCategoryVMEntityView> KeyLabel6 { get; set; } 
        public IRPSTextBox<DocumentCategoryVMEntityView> KeyDefaultValue6 { get; set; } 
        public IRPSComboBox<DocumentCategoryVMEntityView> KeyLinkType6 { get; set; } 
        public IRPSTextBox<DocumentCategoryVMEntityView> KeyLinkProperty6 { get; set; } 
        public IRPSTextBox<DocumentCategoryVMEntityView> KeyLabel7 { get; set; } 
        public IRPSTextBox<DocumentCategoryVMEntityView> KeyDefaultValue7 { get; set; } 
        public IRPSComboBox<DocumentCategoryVMEntityView> KeyLinkType7 { get; set; } 
        public IRPSTextBox<DocumentCategoryVMEntityView> KeyLinkProperty7 { get; set; } 
        public IRPSTextBox<DocumentCategoryVMEntityView> KeyLabel8 { get; set; } 
        public IRPSTextBox<DocumentCategoryVMEntityView> KeyDefaultValue8 { get; set; } 
        public IRPSComboBox<DocumentCategoryVMEntityView> KeyLinkType8 { get; set; } 
        public IRPSTextBox<DocumentCategoryVMEntityView> KeyLinkProperty8 { get; set; } 
        public IRPSTextBox<DocumentCategoryVMEntityView> KeyLabel9 { get; set; } 
        public IRPSTextBox<DocumentCategoryVMEntityView> KeyDefaultValue9 { get; set; } 
        public IRPSComboBox<DocumentCategoryVMEntityView> KeyLinkType9 { get; set; } 
        public IRPSTextBox<DocumentCategoryVMEntityView> KeyLinkProperty9 { get; set; } 
        public IRPSTextBox<DocumentCategoryVMEntityView> KeyLabel10 { get; set; } 
        public IRPSTextBox<DocumentCategoryVMEntityView> KeyDefaultValue10 { get; set; } 
        public IRPSComboBox<DocumentCategoryVMEntityView> KeyLinkType10 { get; set; } 
        public IRPSTextBox<DocumentCategoryVMEntityView> KeyLinkProperty101 { get; set; } 
        public IRPSButton<DocumentCategoryVMEntityView> ExecuteAddCategorySubscriptionButton { get; set; } 
        public IRPSButton<DocumentCategoryVMEntityView> ExecuteRemoveCategorySubscriptionButton { get; set; } 
        public IRPSButton<DocumentCategoryVMEntityView> ExecuteResetPermissionsButton { get; set; } 
        public DocumentKeysByLangCollectionEditor<DocumentCategoryVMEntityView> DocumentKeysByLang { get; set; } 
        public DocumentCategoryPermsUserCollectionEditor<DocumentCategoryVMEntityView> DocumentCategoryPermsUser { get; set; } 
        public DocumentCategoryPermsRoleCollectionEditor<DocumentCategoryVMEntityView> DocumentCategoryPermsRole { get; set; } 
        public CategorySituationChangePermsCollectionEditor<DocumentCategoryVMEntityView> CategorySituationChangePerms { get; set; } 
        public IRPSSection<DocumentCategoryVMEntityView> GeneralData { get; set; } 
        public IRPSSection<DocumentCategoryVMEntityView> Section { get; set; } 
        public IRPSSection<DocumentCategoryVMEntityView> UserPermissions { get; set; } 
        public IRPSSection<DocumentCategoryVMEntityView> RolePermissions { get; set; } 
        public IRPSSection<DocumentCategoryVMEntityView> SituationChangePermissions { get; set; } 
        public DocumentCategory Screen { get; set; }
        public DocumentCategoryVMEntityView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class DocumentKeysByLangCollectionEditor<DocumentCategoryVMEntityView>:RPSCollectionEditor<DocumentCategoryVMEntityView> where DocumentCategoryVMEntityView : class, IView
    {
        public  DocumentKeysByLangGridView<DocumentCategoryVMEntityView> GridView {get;set;}
    }
    public partial class DocumentKeysByLangGridView <DocumentCategoryVMEntityView> :  RPSGridView<DocumentCategoryVMEntityView> where DocumentCategoryVMEntityView : class, IView
    {
        public DocumentKeysByLangGridView(DocumentCategoryVMEntityView currentView)
        {
            this.WebDriver = currentView.WebDriver;          
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            CodLanguage = RPSControlFactory.CreateRPSGridComboBox<DocumentCategoryVMEntityView>("","#9d024665-b9e5-4458-8415-425e32f968a3 .ag-row[role='row']@ROWINDEX [col-id='cCodLanguage']","",true, this.CurrentView);
 
            KeyLabel1 = RPSControlFactory.CreateRPSGridTextBox<DocumentCategoryVMEntityView>("","#9d024665-b9e5-4458-8415-425e32f968a3 .ag-row[role='row']@ROWINDEX [col-id='cKeyLabel1']","",false, this.CurrentView);
 
            KeyLabel2 = RPSControlFactory.CreateRPSGridTextBox<DocumentCategoryVMEntityView>("","#9d024665-b9e5-4458-8415-425e32f968a3 .ag-row[role='row']@ROWINDEX [col-id='cKeyLabel2']","",false, this.CurrentView);
 
            KeyLabel3 = RPSControlFactory.CreateRPSGridTextBox<DocumentCategoryVMEntityView>("","#9d024665-b9e5-4458-8415-425e32f968a3 .ag-row[role='row']@ROWINDEX [col-id='cKeyLabel3']","",false, this.CurrentView);
 
            KeyLabel4 = RPSControlFactory.CreateRPSGridTextBox<DocumentCategoryVMEntityView>("","#9d024665-b9e5-4458-8415-425e32f968a3 .ag-row[role='row']@ROWINDEX [col-id='cKeyLabel4']","",false, this.CurrentView);
 
            KeyLabel5 = RPSControlFactory.CreateRPSGridTextBox<DocumentCategoryVMEntityView>("","#9d024665-b9e5-4458-8415-425e32f968a3 .ag-row[role='row']@ROWINDEX [col-id='cKeyLabel5']","",false, this.CurrentView);
 
            KeyLabel6 = RPSControlFactory.CreateRPSGridTextBox<DocumentCategoryVMEntityView>("","#9d024665-b9e5-4458-8415-425e32f968a3 .ag-row[role='row']@ROWINDEX [col-id='cKeyLabel6']","",false, this.CurrentView);
 
            KeyLabel7 = RPSControlFactory.CreateRPSGridTextBox<DocumentCategoryVMEntityView>("","#9d024665-b9e5-4458-8415-425e32f968a3 .ag-row[role='row']@ROWINDEX [col-id='cKeyLabel7']","",false, this.CurrentView);
 
            KeyLabel8 = RPSControlFactory.CreateRPSGridTextBox<DocumentCategoryVMEntityView>("","#9d024665-b9e5-4458-8415-425e32f968a3 .ag-row[role='row']@ROWINDEX [col-id='cKeyLabel8']","",false, this.CurrentView);
 
            KeyLabel9 = RPSControlFactory.CreateRPSGridTextBox<DocumentCategoryVMEntityView>("","#9d024665-b9e5-4458-8415-425e32f968a3 .ag-row[role='row']@ROWINDEX [col-id='cKeyLabel9']","",false, this.CurrentView);
 
            KeyLabel10 = RPSControlFactory.CreateRPSGridTextBox<DocumentCategoryVMEntityView>("","#9d024665-b9e5-4458-8415-425e32f968a3 .ag-row[role='row']@ROWINDEX [col-id='cKeyLabel10']","",false, this.CurrentView);
 

        }
        public IRPSGridComboBox<DocumentCategoryVMEntityView> CodLanguage { get; set; } 
        public IRPSGridTextBox<DocumentCategoryVMEntityView> KeyLabel1 { get; set; } 
        public IRPSGridTextBox<DocumentCategoryVMEntityView> KeyLabel2 { get; set; } 
        public IRPSGridTextBox<DocumentCategoryVMEntityView> KeyLabel3 { get; set; } 
        public IRPSGridTextBox<DocumentCategoryVMEntityView> KeyLabel4 { get; set; } 
        public IRPSGridTextBox<DocumentCategoryVMEntityView> KeyLabel5 { get; set; } 
        public IRPSGridTextBox<DocumentCategoryVMEntityView> KeyLabel6 { get; set; } 
        public IRPSGridTextBox<DocumentCategoryVMEntityView> KeyLabel7 { get; set; } 
        public IRPSGridTextBox<DocumentCategoryVMEntityView> KeyLabel8 { get; set; } 
        public IRPSGridTextBox<DocumentCategoryVMEntityView> KeyLabel9 { get; set; } 
        public IRPSGridTextBox<DocumentCategoryVMEntityView> KeyLabel10 { get; set; } 
                     
    }
 
        public partial class DocumentCategoryPermsUserCollectionEditor<DocumentCategoryVMEntityView>:RPSCollectionEditor<DocumentCategoryVMEntityView> where DocumentCategoryVMEntityView : class, IView
    {
        public  DocumentCategoryPermsUserGridView<DocumentCategoryVMEntityView> GridView {get;set;}
    }
    public partial class DocumentCategoryPermsUserGridView <DocumentCategoryVMEntityView> :  RPSGridView<DocumentCategoryVMEntityView> where DocumentCategoryVMEntityView : class, IView
    {
        public DocumentCategoryPermsUserGridView(DocumentCategoryVMEntityView currentView)
        {
            this.WebDriver = currentView.WebDriver;          
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            CodUser = RPSControlFactory.CreateRPSGridComboBox<DocumentCategoryVMEntityView>("","#c555ad20-79be-4877-84d6-09a65ac757e8 .ag-row[role='row']@ROWINDEX [col-id='cCodUser']","",false, this.CurrentView);
 
            Allow = RPSControlFactory.CreateRPSGridEnumComboBox<DocumentCategoryVMEntityView>("","#c555ad20-79be-4877-84d6-09a65ac757e8 .ag-row[role='row']@ROWINDEX [col-id='cAllow']","",true, this.CurrentView);
 

        }
        public IRPSGridComboBox<DocumentCategoryVMEntityView> CodUser { get; set; } 
        public IRPSGridComboBox<DocumentCategoryVMEntityView> Allow { get; set; } 
                     
    }
 
        public partial class DocumentCategoryPermsRoleCollectionEditor<DocumentCategoryVMEntityView>:RPSCollectionEditor<DocumentCategoryVMEntityView> where DocumentCategoryVMEntityView : class, IView
    {
        public  DocumentCategoryPermsRoleGridView<DocumentCategoryVMEntityView> GridView {get;set;}
    }
    public partial class DocumentCategoryPermsRoleGridView <DocumentCategoryVMEntityView> :  RPSGridView<DocumentCategoryVMEntityView> where DocumentCategoryVMEntityView : class, IView
    {
        public DocumentCategoryPermsRoleGridView(DocumentCategoryVMEntityView currentView)
        {
            this.WebDriver = currentView.WebDriver;          
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            CodRole = RPSControlFactory.CreateRPSGridComboBox<DocumentCategoryVMEntityView>("","#6031c2fd-a69d-475e-9299-9b47e062ee4f .ag-row[role='row']@ROWINDEX [col-id='cCodRole']","",false, this.CurrentView);
 
            Allow = RPSControlFactory.CreateRPSGridEnumComboBox<DocumentCategoryVMEntityView>("","#6031c2fd-a69d-475e-9299-9b47e062ee4f .ag-row[role='row']@ROWINDEX [col-id='cAllow']","",true, this.CurrentView);
 

        }
        public IRPSGridComboBox<DocumentCategoryVMEntityView> CodRole { get; set; } 
        public IRPSGridComboBox<DocumentCategoryVMEntityView> Allow { get; set; } 
                     
    }
 
        public partial class CategorySituationChangePermsCollectionEditor<DocumentCategoryVMEntityView>:RPSCollectionEditor<DocumentCategoryVMEntityView> where DocumentCategoryVMEntityView : class, IView
    {
        public  CategorySituationChangePermsGridView<DocumentCategoryVMEntityView> GridView {get;set;}
    }
    public partial class CategorySituationChangePermsGridView <DocumentCategoryVMEntityView> :  RPSGridView<DocumentCategoryVMEntityView> where DocumentCategoryVMEntityView : class, IView
    {
        public CategorySituationChangePermsGridView(DocumentCategoryVMEntityView currentView)
        {
            this.WebDriver = currentView.WebDriver;          
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            IDDocumentSituation = RPSControlFactory.CreateRPSGridComboBox<DocumentCategoryVMEntityView>("","#9ecbc7e8-dc2e-44f9-81dc-30dd36687ba6 .ag-row[role='row']@ROWINDEX [col-id='cIDDocumentSituation']","",true, this.CurrentView);
 
            EntityType = RPSControlFactory.CreateRPSGridEnumComboBox<DocumentCategoryVMEntityView>("","#9ecbc7e8-dc2e-44f9-81dc-30dd36687ba6 .ag-row[role='row']@ROWINDEX [col-id='cEntityType']","",true, this.CurrentView);
 
            CodUserOrRole = RPSControlFactory.CreateRPSGridComboBox<DocumentCategoryVMEntityView>("","#9ecbc7e8-dc2e-44f9-81dc-30dd36687ba6 .ag-row[role='row']@ROWINDEX [col-id='cCodUserOrRole']","",false, this.CurrentView);
 

        }
        public IRPSGridComboBox<DocumentCategoryVMEntityView> IDDocumentSituation { get; set; } 
        public IRPSGridComboBox<DocumentCategoryVMEntityView> EntityType { get; set; } 
        public IRPSGridComboBox<DocumentCategoryVMEntityView> CodUserOrRole { get; set; } 
                     
    }
 
    }
  
            
    public partial class CategoryDocumentsView : View
    {
        public CategoryDocumentsView(DocumentCategory screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            TextToSearch = RPSControlFactory.CreateRPSTextBox<CategoryDocumentsView>("a3d8ffa0-00c5-4b66-8409-f9735be280c4","","",false, this);
 
            FileUploadNavigationCommandButton = RPSControlFactory.CreateRPSButtonToView<CategoryDocumentsView,FileUploadDialogView>("e00f946a-6031-49e5-8782-008bff3e1182","","", this,Screen.FileUploadDialogView);
 
            LinkNavigationCommandButton = RPSControlFactory.CreateRPSButton<CategoryDocumentsView>( "a6b35b9f-3abe-40fa-aca5-c63c822b7b6e","","",this);
 
            PackFileWizardNavigationCommandButton = RPSControlFactory.CreateRPSButtonToView<CategoryDocumentsView,PackFileWizardDialogView>("72b52871-9645-44d4-a7d7-35fc7dfb8f92","","", this,Screen.PackFileWizardDialogView);
 
            CollectionInit params_DocumentsForCategory = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="fd509161-94cb-4f20-a93a-3a773763ff0c",CSSSelectorGrid="",XPathGrid=""};
            DocumentsForCategory = RPSControlFactory.RPSCreateCollectionWithGrid<DocumentsForCategoryCollectionEditor<CategoryDocumentsView,DocumentCategoryVMEntityView>,CategoryDocumentsView,DocumentCategoryVMEntityView>( params_DocumentsForCategory,this,Screen.DocumentCategoryVMEntityView);
 

        }
        public IRPSTextBox<CategoryDocumentsView> TextToSearch { get; set; } 
        public IRPSButton<CategoryDocumentsView,FileUploadDialogView> FileUploadNavigationCommandButton { get; set; } 
        public IRPSButton<CategoryDocumentsView> LinkNavigationCommandButton { get; set; } 
        public IRPSButton<CategoryDocumentsView,PackFileWizardDialogView> PackFileWizardNavigationCommandButton { get; set; } 
        public DocumentsForCategoryCollectionEditor<CategoryDocumentsView,DocumentCategoryVMEntityView> DocumentsForCategory { get; set; } 
        public DocumentCategory Screen { get; set; }
        public CategoryDocumentsView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class DocumentsForCategoryCollectionEditor<CategoryDocumentsView,DocumentCategoryVMEntityView>:RPSCollectionEditor<CategoryDocumentsView,DocumentCategoryVMEntityView> where CategoryDocumentsView : class, IView where DocumentCategoryVMEntityView : class, IView
    {
        public  DocumentsForCategoryGridView<CategoryDocumentsView,DocumentCategoryVMEntityView> GridView {get;set;}
    }
    public partial class DocumentsForCategoryGridView <CategoryDocumentsView,DocumentCategoryVMEntityView> :  RPSGridView<CategoryDocumentsView,DocumentCategoryVMEntityView> where CategoryDocumentsView : class, IView where DocumentCategoryVMEntityView : class, IView
    {
        public DocumentsForCategoryGridView(CategoryDocumentsView currentView,DocumentCategoryVMEntityView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            IsFavourite = RPSControlFactory.CreateRPSGridCheckBox<CategoryDocumentsView>("","#fd509161-94cb-4f20-a93a-3a773763ff0c .ag-row[role='row']@ROWINDEX [col-id='cIsFavourite']","",false, this.CurrentView);
 
            downloadDocumentCommand = RPSControlFactory.CreateRPSGridButton<CategoryDocumentsView>( "","#fd509161-94cb-4f20-a93a-3a773763ff0c .ag-row[role='row']@ROWINDEX [col-id='cdownloadDocumentCommand']","",this.CurrentView);
 
            PreviewCommand = RPSControlFactory.CreateRPSGridButton<CategoryDocumentsView>( "","#fd509161-94cb-4f20-a93a-3a773763ff0c .ag-row[role='row']@ROWINDEX [col-id='cPreviewCommand']","",this.CurrentView);
 
            Document_LastRevisionDate = RPSControlFactory.CreateRPSGridTextBox<CategoryDocumentsView>("","#fd509161-94cb-4f20-a93a-3a773763ff0c .ag-row[role='row']@ROWINDEX [col-id='cDocument_LastRevisionDate']","",false, this.CurrentView);
 

        }
        public IRPSGridCheckbox<CategoryDocumentsView> IsFavourite { get; set; } 
        public IRPSGridButton<CategoryDocumentsView> downloadDocumentCommand { get; set; } 
        public IRPSGridButton<CategoryDocumentsView> PreviewCommand { get; set; } 
        public IRPSGridTextBox<CategoryDocumentsView> Document_LastRevisionDate { get; set; } 
                     
    }
 
    }
  
            
    public partial class FileUploadDialogView : View
    {
        public FileUploadDialogView(DocumentCategory screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            DocumentType = RPSControlFactory.CreateRPSComboBox<FileUploadDialogView>("5e76e41a-d049-4424-ae9a-977008b3cd42","","",false, this);
 

        }
        public IRPSComboBox<FileUploadDialogView> DocumentType { get; set; } 
        public DocumentCategory Screen { get; set; }
        public FileUploadDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class PackFileWizardDialogView : View
    {
        public PackFileWizardDialogView(DocumentCategory screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            AllCategory = RPSControlFactory.CreateRPSOption<PackFileWizardDialogView>( "c3b94e30-ffc6-4f21-b5ff-f39110d385a3","","",this);
 
            SelectedDocuments = RPSControlFactory.CreateRPSOption<PackFileWizardDialogView>( "725cf0f9-5534-46e5-b05c-e4f683388d00","","",this);
 
            PackFileOptions = RPSControlFactory.CreateRPSEnumComboBox<PackFileWizardDialogView>("3954ec2e-953b-4cbb-9b76-09426de8fa2a","","",false, this);
 
            DaysOfValidity = RPSControlFactory.CreateRPSFormattedTextBox<PackFileWizardDialogView>("693d317d-058c-4124-a10f-74199ccbdf03","","",false, this);
 
            PackFileComment = RPSControlFactory.CreateRPSTextBox<PackFileWizardDialogView>("3a32de61-1c28-4260-920f-9f819c32770b","","",false, this);
 
            IDPackFile = RPSControlFactory.CreateRPSComboBox<PackFileWizardDialogView>("52234013-a1c5-439b-9207-94becea42e66","","",false, this);
 
            PublishPackage = RPSControlFactory.CreateRPSCheckBox<PackFileWizardDialogView>("3d0dde5c-9a86-4aef-9966-956537b17d09","","",false, this);
 
            CollectionInit params_RPSUsers = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="3af28f61-a29f-4875-b0cf-4fa45840163e",CSSSelectorGrid="",XPathGrid=""};
            RPSUsers = RPSControlFactory.RPSCreateCollectionWithGrid<RPSUsersCollectionEditor<PackFileWizardDialogView>,PackFileWizardDialogView>( params_RPSUsers,this);
 
            CollectionInit params_ExternalUsers = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="a7cf3d68-8e6b-4276-bb8c-5419721f4efe",CSSSelectorGrid="",XPathGrid=""};
            ExternalUsers = RPSControlFactory.RPSCreateCollectionWithGrid<ExternalUsersCollectionEditor<PackFileWizardDialogView>,PackFileWizardDialogView>( params_ExternalUsers,this);
 

        }
        public IRPSOption<PackFileWizardDialogView> AllCategory { get; set; } 
        public IRPSOption<PackFileWizardDialogView> SelectedDocuments { get; set; } 
        public IRPSComboBox<PackFileWizardDialogView> PackFileOptions { get; set; } 
        public IRPSTextBox<PackFileWizardDialogView> DaysOfValidity { get; set; } 
        public IRPSTextBox<PackFileWizardDialogView> PackFileComment { get; set; } 
        public IRPSComboBox<PackFileWizardDialogView> IDPackFile { get; set; } 
        public IRPSCheckbox<PackFileWizardDialogView> PublishPackage { get; set; } 
        public RPSUsersCollectionEditor<PackFileWizardDialogView> RPSUsers { get; set; } 
        public ExternalUsersCollectionEditor<PackFileWizardDialogView> ExternalUsers { get; set; } 
        public DocumentCategory Screen { get; set; }
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
            CodUser = RPSControlFactory.CreateRPSGridComboBox<PackFileWizardDialogView>("","#3af28f61-a29f-4875-b0cf-4fa45840163e .ag-row[role='row']@ROWINDEX [col-id='cCodUser']","",false, this.CurrentView);
 

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
            ExternalUserDescription = RPSControlFactory.CreateRPSGridTextBox<PackFileWizardDialogView>("","#a7cf3d68-8e6b-4276-bb8c-5419721f4efe .ag-row[role='row']@ROWINDEX [col-id='cExternalUserDescription']","",false, this.CurrentView);
 
            ExternalUserEmailToInvite = RPSControlFactory.CreateRPSGridEmailTextBox<PackFileWizardDialogView>("","#a7cf3d68-8e6b-4276-bb8c-5419721f4efe .ag-row[role='row']@ROWINDEX [col-id='cExternalUserEmailToInvite']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<PackFileWizardDialogView> ExternalUserDescription { get; set; } 
        public IRPSGridTextBox<PackFileWizardDialogView> ExternalUserEmailToInvite { get; set; } 
                     
    }
 
    }
  
    

}