    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.Configurator.CPQModel
{
    //RPS VERSION 1.0.0.0
    public partial class CPQModel:Screen
    {
        public CPQModel():base()
        {
            this.URL = "configurator.cpqmodel";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            CPQModelCollectionView  = new CPQModelCollectionView(this); 
            CPQModelEntityView  = new CPQModelEntityView(this); 
            CPQModelByLangView  = new CPQModelByLangView(this); 
            CPQOptionGroupView  = new CPQOptionGroupView(this); 
            CPQOptionGroupByLangView  = new CPQOptionGroupByLangView(this); 
            CPQOptionView  = new CPQOptionView(this); 
            CPQOptionByLangView  = new CPQOptionByLangView(this); 
            CPQVariableDataListView  = new CPQVariableDataListView(this); 
            CPQVariableDataListByLangView  = new CPQVariableDataListByLangView(this); 
            NewModelCreatorDialogView  = new NewModelCreatorDialogView(this); 
            CPQModelActionView  = new CPQModelActionView(this); 
            CPQOptionGroupActionView  = new CPQOptionGroupActionView(this); 
            CPQModelVariableDataView  = new CPQModelVariableDataView(this); 
            CPQOptionVariableDataView  = new CPQOptionVariableDataView(this); 
            AddToCompositionExistingDocumentDialogView  = new AddToCompositionExistingDocumentDialogView(this); 
            AddToCompositionReportDialogView  = new AddToCompositionReportDialogView(this); 
            ModelActionConditionEditorDialogView  = new ModelActionConditionEditorDialogView(this); 
            OptionGroupActionFormulaEditorDialogView  = new OptionGroupActionFormulaEditorDialogView(this); 
            OptionArticleFormulaEditorDialogView  = new OptionArticleFormulaEditorDialogView(this); 
            CPQOptionArticleView  = new CPQOptionArticleView(this); 
            ImportCPQOptionGroupDialogView  = new ImportCPQOptionGroupDialogView(this); 
            CPQModelCollectionView.InitializeControls(); 
            CPQModelEntityView.InitializeControls(); 
            CPQModelByLangView.InitializeControls(); 
            CPQOptionGroupView.InitializeControls(); 
            CPQOptionGroupByLangView.InitializeControls(); 
            CPQOptionView.InitializeControls(); 
            CPQOptionByLangView.InitializeControls(); 
            CPQVariableDataListView.InitializeControls(); 
            CPQVariableDataListByLangView.InitializeControls(); 
            NewModelCreatorDialogView.InitializeControls(); 
            CPQModelActionView.InitializeControls(); 
            CPQOptionGroupActionView.InitializeControls(); 
            CPQModelVariableDataView.InitializeControls(); 
            CPQOptionVariableDataView.InitializeControls(); 
            AddToCompositionExistingDocumentDialogView.InitializeControls(); 
            AddToCompositionReportDialogView.InitializeControls(); 
            ModelActionConditionEditorDialogView.InitializeControls(); 
            OptionGroupActionFormulaEditorDialogView.InitializeControls(); 
            OptionArticleFormulaEditorDialogView.InitializeControls(); 
            CPQOptionArticleView.InitializeControls(); 
            ImportCPQOptionGroupDialogView.InitializeControls(); 
           
        }
      
            public CPQModelCollectionView CPQModelCollectionView {get; set; } 
            public CPQModelEntityView CPQModelEntityView {get; set; } 
            public CPQModelByLangView CPQModelByLangView {get; set; } 
            public CPQOptionGroupView CPQOptionGroupView {get; set; } 
            public CPQOptionGroupByLangView CPQOptionGroupByLangView {get; set; } 
            public CPQOptionView CPQOptionView {get; set; } 
            public CPQOptionByLangView CPQOptionByLangView {get; set; } 
            public CPQVariableDataListView CPQVariableDataListView {get; set; } 
            public CPQVariableDataListByLangView CPQVariableDataListByLangView {get; set; } 
            public NewModelCreatorDialogView NewModelCreatorDialogView {get; set; } 
            public CPQModelActionView CPQModelActionView {get; set; } 
            public CPQOptionGroupActionView CPQOptionGroupActionView {get; set; } 
            public CPQModelVariableDataView CPQModelVariableDataView {get; set; } 
            public CPQOptionVariableDataView CPQOptionVariableDataView {get; set; } 
            public AddToCompositionExistingDocumentDialogView AddToCompositionExistingDocumentDialogView {get; set; } 
            public AddToCompositionReportDialogView AddToCompositionReportDialogView {get; set; } 
            public ModelActionConditionEditorDialogView ModelActionConditionEditorDialogView {get; set; } 
            public OptionGroupActionFormulaEditorDialogView OptionGroupActionFormulaEditorDialogView {get; set; } 
            public OptionArticleFormulaEditorDialogView OptionArticleFormulaEditorDialogView {get; set; } 
            public CPQOptionArticleView CPQOptionArticleView {get; set; } 
            public ImportCPQOptionGroupDialogView ImportCPQOptionGroupDialogView {get; set; } 
    }
            
    public partial class CPQModelCollectionView : View
    {
        public CPQModelCollectionView(CPQModel screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            NewButton = RPSControlFactory.RPSNewButton<CPQModelCollectionView,CPQModelEntityView>( this,Screen.CPQModelEntityView);
 
            CollectionInit params_MainConsult = new CollectionInit(){IDDescriptor = "b3409014-1233-4960-82f0-9b0a9b28dbff",CSSSelectorDescriptor = "",XPathDescriptor = ""};
            MainConsult = RPSControlFactory.RPSCreateCollection<CPQModelCollectionView,CPQModelEntityView>( params_MainConsult,this,Screen.CPQModelEntityView);
 

        }
        public IRPSButton<CPQModelCollectionView,CPQModelEntityView> NewButton { get; set; } 
        public IRPSCollectionEditor<CPQModelCollectionView,CPQModelEntityView> MainConsult { get; set; } 
        public CPQModel Screen { get; set; }
        public CPQModelCollectionView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class CPQModelEntityView : View
    {
        public CPQModelEntityView(CPQModel screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            SaveButton = RPSControlFactory.RPSSaveButton<CPQModelEntityView>( this);
 
            DeleteButton = RPSControlFactory.RPSDeleteButton<CPQModelEntityView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<CPQModelEntityView,CPQModelCollectionView>( this,Screen.CPQModelCollectionView);
 
            BackButton = RPSControlFactory.RPSBackButton<CPQModelEntityView,CPQModelCollectionView>( this,Screen.CPQModelCollectionView);
 
            CodModel = RPSControlFactory.CreateRPSTextBox<CPQModelEntityView>("0f913565-c8f6-4c4c-86a8-4dc9a69c5f52","","",true, this);
 
            Version = RPSControlFactory.CreateRPSTextBox<CPQModelEntityView>("0a4d5cfb-abfa-4381-8fcb-219c48cb815f","","",true, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<CPQModelEntityView>("6f8e0c6c-88f7-453b-a6a9-9b5369708137","","",false, this);
 
            Active = RPSControlFactory.CreateRPSCheckBox<CPQModelEntityView>("c51fae25-c9b4-400e-9b86-f648e397b3f2","","",true, this);
 
            ActiveFrom = RPSControlFactory.CreateRPSTextBox<CPQModelEntityView>("0e8d7871-c848-4b18-8214-a09474a833e4","","",false, this);
 
            ShowPrice = RPSControlFactory.CreateRPSCheckBox<CPQModelEntityView>("648d982c-0d27-4b4d-bcb8-fd41e23831b0","","",true, this);
 
            ShowCost = RPSControlFactory.CreateRPSCheckBox<CPQModelEntityView>("3c4d3ca2-b7b8-48d3-bb82-605265c310f8","","",true, this);
 
            ShowImage = RPSControlFactory.CreateRPSCheckBox<CPQModelEntityView>("5fd41baa-1c30-411d-bc87-cd5e23fad829","","",true, this);
 
            ShowDescription = RPSControlFactory.CreateRPSCheckBox<CPQModelEntityView>("25c83847-0193-4cbd-bd7e-61c7ec62d119","","",true, this);
 
            ShowArticleList = RPSControlFactory.CreateRPSCheckBox<CPQModelEntityView>("d03422f3-2a0b-4af6-ab21-662701af56be","","",true, this);
 
            AllowChangeGeneralData = RPSControlFactory.CreateRPSCheckBox<CPQModelEntityView>("d42c76d7-cd23-44c2-9544-fbc7354f6774","","",true, this);
 
            Tab1Description = RPSControlFactory.CreateRPSTextBox<CPQModelEntityView>("8ffaba62-3dad-4af2-87a4-72049970100f","","",false, this);
 
            Tab2Description = RPSControlFactory.CreateRPSTextBox<CPQModelEntityView>("cded5280-0670-4177-a0df-70ecdc5a00d5","","",false, this);
 
            Tab3Description = RPSControlFactory.CreateRPSTextBox<CPQModelEntityView>("42eefaa0-5e7a-4449-bb1a-a7824a1547f0","","",false, this);
 
            TabOption = RPSControlFactory.CreateRPSEnumComboBox<CPQModelEntityView>("55fe1f7b-3286-4ed4-bc4f-02be9d14c37f","","",false, this);
 
            ImportCPQOptionGroupNavigationCommandButton = RPSControlFactory.CreateRPSButtonToView<CPQModelEntityView,ImportCPQOptionGroupDialogView>("317106aa-2497-4f08-963b-5f226d3d81db","","", this,Screen.ImportCPQOptionGroupDialogView);
 
            EventOption = RPSControlFactory.CreateRPSEnumComboBox<CPQModelEntityView>("1d42679d-985f-42cb-a96f-60b7fd1d8823","","",false, this);
 
            NewOptionGroupActionButton = RPSControlFactory.CreateRPSButton<CPQModelEntityView>( "9e6cb2c0-3a9a-41e6-b56a-9b132de1317f","","",this);
 
            AddArticleDocuments = RPSControlFactory.CreateRPSCheckBox<CPQModelEntityView>("54393e96-fb88-4f44-ae25-bfacc847abdf","","",true, this);
 
            IDDocumentTypeArticles = RPSControlFactory.CreateRPSComboBox<CPQModelEntityView>("6d16a3e9-657f-4cec-bf7d-b1999bb0837b","","",false, this);
 
            OrderArticleDocuments = RPSControlFactory.CreateRPSFormattedTextBox<CPQModelEntityView>("1857a71e-c734-4a27-b072-8689e65ec8bc","","",true, this);
 
            AddToCompositionExistingDocumentNavigationCommand = RPSControlFactory.CreateRPSButtonToView<CPQModelEntityView,AddToCompositionExistingDocumentDialogView>("76dd12b0-699b-456e-91c3-37cb3ff48003","","", this,Screen.AddToCompositionExistingDocumentDialogView);
 
            AddToCompositionReportNavigationCommand = RPSControlFactory.CreateRPSButtonToView<CPQModelEntityView,AddToCompositionReportDialogView>("3cfa4971-8c7f-49cf-9f24-11c93f55a39f","","", this,Screen.AddToCompositionReportDialogView);
 
            ActivateCommandButton = RPSControlFactory.CreateRPSButton<CPQModelEntityView>( "7daee8a8-42b0-4d10-92db-9ee1cc6faca3","","",this);
 
            DeactivateCommandButton = RPSControlFactory.CreateRPSButton<CPQModelEntityView>( "b1a4378b-fb2a-4c36-bfab-ea58a98adf82","","",this);
 
            CopyModelCreatorNavigationCommandButton = RPSControlFactory.CreateRPSButtonToView<CPQModelEntityView,NewModelCreatorDialogView>("c37f1394-4acf-47de-b08a-64e2eb29c829","","", this,Screen.NewModelCreatorDialogView);
 
            NewVersionModelCreatorNavigationCommandButton = RPSControlFactory.CreateRPSButtonToView<CPQModelEntityView,NewModelCreatorDialogView>("663363b7-9853-4285-8427-048376d1eb1e","","", this,Screen.NewModelCreatorDialogView);
 
            CollectionInit params_CPQModelByLangs = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="79fa3ed2-ad99-4879-b12f-b205deaf9596",CSSSelectorGrid="",XPathGrid=""};
            CPQModelByLangs = RPSControlFactory.RPSCreateCollectionWithGrid<CPQModelByLangsCollectionEditor<CPQModelEntityView,CPQModelByLangView>,CPQModelEntityView,CPQModelByLangView>( params_CPQModelByLangs,this,Screen.CPQModelByLangView);
 
            CollectionInit params_CPQOptionGroups = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="4441d13a-6402-4b08-8c53-ecb5313dba09",CSSSelectorGrid="",XPathGrid=""};
            CPQOptionGroups = RPSControlFactory.RPSCreateCollectionWithGrid<CPQOptionGroupsCollectionEditor<CPQModelEntityView,CPQModelByLangView>,CPQModelEntityView,CPQModelByLangView>( params_CPQOptionGroups,this,Screen.CPQModelByLangView);
 
            CollectionInit params_CPQModelActions = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="0e1ac252-0319-47f7-8687-535580f224ef",CSSSelectorGrid="",XPathGrid=""};
            CPQModelActions = RPSControlFactory.RPSCreateCollectionWithGrid<CPQModelActionsCollectionEditor<CPQModelEntityView,CPQModelByLangView>,CPQModelEntityView,CPQModelByLangView>( params_CPQModelActions,this,Screen.CPQModelByLangView);
 
            CollectionInit params_InterfaceModelActions = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="fdf971b4-861c-4a57-8a26-0ed5d1bff5fa",CSSSelectorGrid="",XPathGrid=""};
            InterfaceModelActions = RPSControlFactory.RPSCreateCollectionWithGrid<InterfaceModelActionsCollectionEditor<CPQModelEntityView,CPQModelByLangView>,CPQModelEntityView,CPQModelByLangView>( params_InterfaceModelActions,this,Screen.CPQModelByLangView);
 
            CollectionInit params_CPQModelVariableDatas = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="d2d7ba2a-197c-4a83-a6e8-3b3c31335f53",CSSSelectorGrid="",XPathGrid=""};
            CPQModelVariableDatas = RPSControlFactory.RPSCreateCollectionWithGrid<CPQModelVariableDatasCollectionEditor<CPQModelEntityView,CPQModelByLangView>,CPQModelEntityView,CPQModelByLangView>( params_CPQModelVariableDatas,this,Screen.CPQModelByLangView);
 
            CollectionInit params_CPQSalesQuoteTemplates = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="1e735f79-c07b-4a05-b27e-aaf9d9c3686d",CSSSelectorGrid="",XPathGrid=""};
            CPQSalesQuoteTemplates = RPSControlFactory.RPSCreateCollectionWithGrid<CPQSalesQuoteTemplatesCollectionEditor<CPQModelEntityView,CPQModelByLangView>,CPQModelEntityView,CPQModelByLangView>( params_CPQSalesQuoteTemplates,this,Screen.CPQModelByLangView);
 
            CollectionInit params_CPQSalesQuoteCompositions = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="5388886f-1af2-4d5b-ace5-ad05ad10b3e2",CSSSelectorGrid="",XPathGrid=""};
            CPQSalesQuoteCompositions = RPSControlFactory.RPSCreateCollectionWithGrid<CPQSalesQuoteCompositionsCollectionEditor<CPQModelEntityView,CPQModelByLangView>,CPQModelEntityView,CPQModelByLangView>( params_CPQSalesQuoteCompositions,this,Screen.CPQModelByLangView);
 
            CollectionInit params_CPQProduct = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="0db9f908-6cd6-4231-9508-0153271f83cf",CSSSelectorGrid="",XPathGrid=""};
            CPQProduct = RPSControlFactory.RPSCreateCollectionWithGrid<CPQProductCollectionEditor<CPQModelEntityView,CPQModelByLangView>,CPQModelEntityView,CPQModelByLangView>( params_CPQProduct,this,Screen.CPQModelByLangView);
 
            GeneralData = RPSControlFactory.CreateRPSSection<CPQModelEntityView>( "","ul li[rpsid='55812e03-b125-4738-b319-23454555365f']","",this);
 
            OptionGroups = RPSControlFactory.CreateRPSSection<CPQModelEntityView>( "","ul li[rpsid='1cd1b175-8013-4bf0-89e8-f982a248eca0']","",this);
 
            Actions = RPSControlFactory.CreateRPSSection<CPQModelEntityView>( "","ul li[rpsid='5f827e8a-2f22-4b64-b5dd-cbac9ae40c55']","",this);
 
            OptionGroupsActions = RPSControlFactory.CreateRPSSection<CPQModelEntityView>( "","ul li[rpsid='2dac308d-bddf-43b3-bfa3-4528056ff4cc']","",this);
 
            ModelVariableData = RPSControlFactory.CreateRPSSection<CPQModelEntityView>( "","ul li[rpsid='747e36ed-35c4-4f12-9c68-4426b7abbfcd']","",this);
 
            SalesQuoteComposition = RPSControlFactory.CreateRPSSection<CPQModelEntityView>( "","ul li[rpsid='671defa3-d0bb-407f-bc10-0382043915fc']","",this);
 
            Products = RPSControlFactory.CreateRPSSection<CPQModelEntityView>( "","ul li[rpsid='0c65d1f0-3cdf-4074-bac2-453c2b4af1f9']","",this);
 

        }
        public IRPSSaveButton<CPQModelEntityView> SaveButton { get; set; } 
        public IRPSButton<CPQModelEntityView> DeleteButton { get; set; } 
        public IRPSButton<CPQModelEntityView,CPQModelCollectionView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<CPQModelEntityView,CPQModelCollectionView> BackButton { get; set; } 
        public IRPSTextBox<CPQModelEntityView> CodModel { get; set; } 
        public IRPSTextBox<CPQModelEntityView> Version { get; set; } 
        public IRPSTextBox<CPQModelEntityView> Description { get; set; } 
        public IRPSCheckbox<CPQModelEntityView> Active { get; set; } 
        public IRPSTextBox<CPQModelEntityView> ActiveFrom { get; set; } 
        public IRPSCheckbox<CPQModelEntityView> ShowPrice { get; set; } 
        public IRPSCheckbox<CPQModelEntityView> ShowCost { get; set; } 
        public IRPSCheckbox<CPQModelEntityView> ShowImage { get; set; } 
        public IRPSCheckbox<CPQModelEntityView> ShowDescription { get; set; } 
        public IRPSCheckbox<CPQModelEntityView> ShowArticleList { get; set; } 
        public IRPSCheckbox<CPQModelEntityView> AllowChangeGeneralData { get; set; } 
        public IRPSTextBox<CPQModelEntityView> Tab1Description { get; set; } 
        public IRPSTextBox<CPQModelEntityView> Tab2Description { get; set; } 
        public IRPSTextBox<CPQModelEntityView> Tab3Description { get; set; } 
        public IRPSComboBox<CPQModelEntityView> TabOption { get; set; } 
        public IRPSButton<CPQModelEntityView,ImportCPQOptionGroupDialogView> ImportCPQOptionGroupNavigationCommandButton { get; set; } 
        public IRPSComboBox<CPQModelEntityView> EventOption { get; set; } 
        public IRPSButton<CPQModelEntityView> NewOptionGroupActionButton { get; set; } 
        public IRPSCheckbox<CPQModelEntityView> AddArticleDocuments { get; set; } 
        public IRPSComboBox<CPQModelEntityView> IDDocumentTypeArticles { get; set; } 
        public IRPSTextBox<CPQModelEntityView> OrderArticleDocuments { get; set; } 
        public IRPSButton<CPQModelEntityView,AddToCompositionExistingDocumentDialogView> AddToCompositionExistingDocumentNavigationCommand { get; set; } 
        public IRPSButton<CPQModelEntityView,AddToCompositionReportDialogView> AddToCompositionReportNavigationCommand { get; set; } 
        public IRPSButton<CPQModelEntityView> ActivateCommandButton { get; set; } 
        public IRPSButton<CPQModelEntityView> DeactivateCommandButton { get; set; } 
        public IRPSButton<CPQModelEntityView,NewModelCreatorDialogView> CopyModelCreatorNavigationCommandButton { get; set; } 
        public IRPSButton<CPQModelEntityView,NewModelCreatorDialogView> NewVersionModelCreatorNavigationCommandButton { get; set; } 
        public CPQModelByLangsCollectionEditor<CPQModelEntityView,CPQModelByLangView> CPQModelByLangs { get; set; } 
        public CPQOptionGroupsCollectionEditor<CPQModelEntityView,CPQModelByLangView> CPQOptionGroups { get; set; } 
        public CPQModelActionsCollectionEditor<CPQModelEntityView,CPQModelByLangView> CPQModelActions { get; set; } 
        public InterfaceModelActionsCollectionEditor<CPQModelEntityView,CPQModelByLangView> InterfaceModelActions { get; set; } 
        public CPQModelVariableDatasCollectionEditor<CPQModelEntityView,CPQModelByLangView> CPQModelVariableDatas { get; set; } 
        public CPQSalesQuoteTemplatesCollectionEditor<CPQModelEntityView,CPQModelByLangView> CPQSalesQuoteTemplates { get; set; } 
        public CPQSalesQuoteCompositionsCollectionEditor<CPQModelEntityView,CPQModelByLangView> CPQSalesQuoteCompositions { get; set; } 
        public CPQProductCollectionEditor<CPQModelEntityView,CPQModelByLangView> CPQProduct { get; set; } 
        public IRPSSection<CPQModelEntityView> GeneralData { get; set; } 
        public IRPSSection<CPQModelEntityView> OptionGroups { get; set; } 
        public IRPSSection<CPQModelEntityView> Actions { get; set; } 
        public IRPSSection<CPQModelEntityView> OptionGroupsActions { get; set; } 
        public IRPSSection<CPQModelEntityView> ModelVariableData { get; set; } 
        public IRPSSection<CPQModelEntityView> SalesQuoteComposition { get; set; } 
        public IRPSSection<CPQModelEntityView> Products { get; set; } 
        public CPQModel Screen { get; set; }
        public CPQModelEntityView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class CPQModelByLangsCollectionEditor<CPQModelEntityView,CPQModelByLangView>:RPSCollectionEditor<CPQModelEntityView,CPQModelByLangView> where CPQModelEntityView : class, IView where CPQModelByLangView : class, IView
    {
        public  CPQModelByLangsGridView<CPQModelEntityView,CPQModelByLangView> GridView {get;set;}
    }
    public partial class CPQModelByLangsGridView <CPQModelEntityView,CPQModelByLangView> :  RPSGridView<CPQModelEntityView,CPQModelByLangView> where CPQModelEntityView : class, IView where CPQModelByLangView : class, IView
    {
        public CPQModelByLangsGridView(CPQModelEntityView currentView,CPQModelByLangView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            CodLanguage = RPSControlFactory.CreateRPSGridComboBox<CPQModelEntityView>("","#79fa3ed2-ad99-4879-b12f-b205deaf9596 .ag-row[role='row']@ROWINDEX [col-id='cCodLanguage']","",true, this.CurrentView);
 
            Description = RPSControlFactory.CreateRPSGridTextBox<CPQModelEntityView>("","#79fa3ed2-ad99-4879-b12f-b205deaf9596 .ag-row[role='row']@ROWINDEX [col-id='cDescription']","",false, this.CurrentView);
 
            Tab1Description = RPSControlFactory.CreateRPSGridTextBox<CPQModelEntityView>("","#79fa3ed2-ad99-4879-b12f-b205deaf9596 .ag-row[role='row']@ROWINDEX [col-id='cTab1Description']","",false, this.CurrentView);
 
            Tab2Description = RPSControlFactory.CreateRPSGridTextBox<CPQModelEntityView>("","#79fa3ed2-ad99-4879-b12f-b205deaf9596 .ag-row[role='row']@ROWINDEX [col-id='cTab2Description']","",false, this.CurrentView);
 
            Tab3Description = RPSControlFactory.CreateRPSGridTextBox<CPQModelEntityView>("","#79fa3ed2-ad99-4879-b12f-b205deaf9596 .ag-row[role='row']@ROWINDEX [col-id='cTab3Description']","",false, this.CurrentView);
 

        }
        public IRPSGridComboBox<CPQModelEntityView> CodLanguage { get; set; } 
        public IRPSGridTextBox<CPQModelEntityView> Description { get; set; } 
        public IRPSGridTextBox<CPQModelEntityView> Tab1Description { get; set; } 
        public IRPSGridTextBox<CPQModelEntityView> Tab2Description { get; set; } 
        public IRPSGridTextBox<CPQModelEntityView> Tab3Description { get; set; } 
                     
    }
 
        public partial class CPQOptionGroupsCollectionEditor<CPQModelEntityView,CPQModelByLangView>:RPSCollectionEditor<CPQModelEntityView,CPQModelByLangView> where CPQModelEntityView : class, IView where CPQModelByLangView : class, IView
    {
        public  CPQOptionGroupsGridView<CPQModelEntityView,CPQModelByLangView> GridView {get;set;}
    }
    public partial class CPQOptionGroupsGridView <CPQModelEntityView,CPQModelByLangView> :  RPSGridView<CPQModelEntityView,CPQModelByLangView> where CPQModelEntityView : class, IView where CPQModelByLangView : class, IView
    {
        public CPQOptionGroupsGridView(CPQModelEntityView currentView,CPQModelByLangView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            Tab = RPSControlFactory.CreateRPSGridEnumComboBox<CPQModelEntityView>("","#4441d13a-6402-4b08-8c53-ecb5313dba09 .ag-row[role='row']@ROWINDEX [col-id='cTab']","",true, this.CurrentView);
 
            ShowOrder = RPSControlFactory.CreateRPSGridFormattedTextBox<CPQModelEntityView>("","#4441d13a-6402-4b08-8c53-ecb5313dba09 .ag-row[role='row']@ROWINDEX [col-id='cShowOrder']","",true, this.CurrentView);
 
            SequenceOrder = RPSControlFactory.CreateRPSGridFormattedTextBox<CPQModelEntityView>("","#4441d13a-6402-4b08-8c53-ecb5313dba09 .ag-row[role='row']@ROWINDEX [col-id='cSequenceOrder']","",true, this.CurrentView);
 
            CODOptionGroup = RPSControlFactory.CreateRPSGridTextBox<CPQModelEntityView>("","#4441d13a-6402-4b08-8c53-ecb5313dba09 .ag-row[role='row']@ROWINDEX [col-id='cCODOptionGroup']","",true, this.CurrentView);
 
            Description = RPSControlFactory.CreateRPSGridTextBox<CPQModelEntityView>("","#4441d13a-6402-4b08-8c53-ecb5313dba09 .ag-row[role='row']@ROWINDEX [col-id='cDescription']","",true, this.CurrentView);
 
            SelectionType = RPSControlFactory.CreateRPSGridEnumComboBox<CPQModelEntityView>("","#4441d13a-6402-4b08-8c53-ecb5313dba09 .ag-row[role='row']@ROWINDEX [col-id='cSelectionType']","",true, this.CurrentView);
 
            SelectionRequired = RPSControlFactory.CreateRPSGridCheckBox<CPQModelEntityView>("","#4441d13a-6402-4b08-8c53-ecb5313dba09 .ag-row[role='row']@ROWINDEX [col-id='cSelectionRequired']","",true, this.CurrentView);
 
            Visible = RPSControlFactory.CreateRPSGridCheckBox<CPQModelEntityView>("","#4441d13a-6402-4b08-8c53-ecb5313dba09 .ag-row[role='row']@ROWINDEX [col-id='cVisible']","",true, this.CurrentView);
 
            HideIncompatible = RPSControlFactory.CreateRPSGridCheckBox<CPQModelEntityView>("","#4441d13a-6402-4b08-8c53-ecb5313dba09 .ag-row[role='row']@ROWINDEX [col-id='cHideIncompatible']","",true, this.CurrentView);
 
            IterationNumber = RPSControlFactory.CreateRPSGridFormattedTextBox<CPQModelEntityView>("","#4441d13a-6402-4b08-8c53-ecb5313dba09 .ag-row[role='row']@ROWINDEX [col-id='cIterationNumber']","",false, this.CurrentView);
 

        }
        public IRPSGridComboBox<CPQModelEntityView> Tab { get; set; } 
        public IRPSGridTextBox<CPQModelEntityView> ShowOrder { get; set; } 
        public IRPSGridTextBox<CPQModelEntityView> SequenceOrder { get; set; } 
        public IRPSGridTextBox<CPQModelEntityView> CODOptionGroup { get; set; } 
        public IRPSGridTextBox<CPQModelEntityView> Description { get; set; } 
        public IRPSGridComboBox<CPQModelEntityView> SelectionType { get; set; } 
        public IRPSGridCheckbox<CPQModelEntityView> SelectionRequired { get; set; } 
        public IRPSGridCheckbox<CPQModelEntityView> Visible { get; set; } 
        public IRPSGridCheckbox<CPQModelEntityView> HideIncompatible { get; set; } 
        public IRPSGridTextBox<CPQModelEntityView> IterationNumber { get; set; } 
                     
    }
 
        public partial class CPQModelActionsCollectionEditor<CPQModelEntityView,CPQModelByLangView>:RPSCollectionEditor<CPQModelEntityView,CPQModelByLangView> where CPQModelEntityView : class, IView where CPQModelByLangView : class, IView
    {
        public  CPQModelActionsGridView<CPQModelEntityView,CPQModelByLangView> GridView {get;set;}
    }
    public partial class CPQModelActionsGridView <CPQModelEntityView,CPQModelByLangView> :  RPSGridView<CPQModelEntityView,CPQModelByLangView> where CPQModelEntityView : class, IView where CPQModelByLangView : class, IView
    {
        public CPQModelActionsGridView(CPQModelEntityView currentView,CPQModelByLangView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            ExecutionOrder = RPSControlFactory.CreateRPSGridFormattedTextBox<CPQModelEntityView>("","#0e1ac252-0319-47f7-8687-535580f224ef .ag-row[role='row']@ROWINDEX [col-id='cExecutionOrder']","",true, this.CurrentView);
 
            Condition = RPSControlFactory.CreateRPSGridMemoTextBox<CPQModelEntityView>("","#0e1ac252-0319-47f7-8687-535580f224ef .ag-row[role='row']@ROWINDEX [col-id='cCondition']","",false, this.CurrentView);
 
            Description = RPSControlFactory.CreateRPSGridTextBox<CPQModelEntityView>("","#0e1ac252-0319-47f7-8687-535580f224ef .ag-row[role='row']@ROWINDEX [col-id='cDescription']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<CPQModelEntityView> ExecutionOrder { get; set; } 
        public IRPSGridTextBox<CPQModelEntityView> Condition { get; set; } 
        public IRPSGridTextBox<CPQModelEntityView> Description { get; set; } 
                     
    }
 
        public partial class InterfaceModelActionsCollectionEditor<CPQModelEntityView,CPQModelByLangView>:RPSCollectionEditor<CPQModelEntityView,CPQModelByLangView> where CPQModelEntityView : class, IView where CPQModelByLangView : class, IView
    {
        public  InterfaceModelActionsGridView<CPQModelEntityView,CPQModelByLangView> GridView {get;set;}
    }
    public partial class InterfaceModelActionsGridView <CPQModelEntityView,CPQModelByLangView> :  RPSGridView<CPQModelEntityView,CPQModelByLangView> where CPQModelEntityView : class, IView where CPQModelByLangView : class, IView
    {
        public InterfaceModelActionsGridView(CPQModelEntityView currentView,CPQModelByLangView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            Tab = RPSControlFactory.CreateRPSGridFormattedTextBox<CPQModelEntityView>("","#fdf971b4-861c-4a57-8a26-0ed5d1bff5fa .ag-row[role='row']@ROWINDEX [col-id='cTab']","",false, this.CurrentView);
 
            ShowOrder = RPSControlFactory.CreateRPSGridFormattedTextBox<CPQModelEntityView>("","#fdf971b4-861c-4a57-8a26-0ed5d1bff5fa .ag-row[role='row']@ROWINDEX [col-id='cShowOrder']","",false, this.CurrentView);
 
            CODOptionGroup = RPSControlFactory.CreateRPSGridTextBox<CPQModelEntityView>("","#fdf971b4-861c-4a57-8a26-0ed5d1bff5fa .ag-row[role='row']@ROWINDEX [col-id='cCODOptionGroup']","",true, this.CurrentView);
 
            Description = RPSControlFactory.CreateRPSGridTextBox<CPQModelEntityView>("","#fdf971b4-861c-4a57-8a26-0ed5d1bff5fa .ag-row[role='row']@ROWINDEX [col-id='cDescription']","",true, this.CurrentView);
 
            ExecutionOrder = RPSControlFactory.CreateRPSGridFormattedTextBox<CPQModelEntityView>("","#fdf971b4-861c-4a57-8a26-0ed5d1bff5fa .ag-row[role='row']@ROWINDEX [col-id='cExecutionOrder']","",true, this.CurrentView);
 
            Condition = RPSControlFactory.CreateRPSGridMemoTextBox<CPQModelEntityView>("","#fdf971b4-861c-4a57-8a26-0ed5d1bff5fa .ag-row[role='row']@ROWINDEX [col-id='cCondition']","",false, this.CurrentView);
 
            ActionDescription = RPSControlFactory.CreateRPSGridMemoTextBox<CPQModelEntityView>("","#fdf971b4-861c-4a57-8a26-0ed5d1bff5fa .ag-row[role='row']@ROWINDEX [col-id='cActionDescription']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<CPQModelEntityView> Tab { get; set; } 
        public IRPSGridTextBox<CPQModelEntityView> ShowOrder { get; set; } 
        public IRPSGridTextBox<CPQModelEntityView> CODOptionGroup { get; set; } 
        public IRPSGridTextBox<CPQModelEntityView> Description { get; set; } 
        public IRPSGridTextBox<CPQModelEntityView> ExecutionOrder { get; set; } 
        public IRPSGridTextBox<CPQModelEntityView> Condition { get; set; } 
        public IRPSGridTextBox<CPQModelEntityView> ActionDescription { get; set; } 
                     
    }
 
        public partial class CPQModelVariableDatasCollectionEditor<CPQModelEntityView,CPQModelByLangView>:RPSCollectionEditor<CPQModelEntityView,CPQModelByLangView> where CPQModelEntityView : class, IView where CPQModelByLangView : class, IView
    {
        public  CPQModelVariableDatasGridView<CPQModelEntityView,CPQModelByLangView> GridView {get;set;}
    }
    public partial class CPQModelVariableDatasGridView <CPQModelEntityView,CPQModelByLangView> :  RPSGridView<CPQModelEntityView,CPQModelByLangView> where CPQModelEntityView : class, IView where CPQModelByLangView : class, IView
    {
        public CPQModelVariableDatasGridView(CPQModelEntityView currentView,CPQModelByLangView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            IDCPQVariableDataLabel = RPSControlFactory.CreateRPSGridComboBox<CPQModelEntityView>("","#d2d7ba2a-197c-4a83-a6e8-3b3c31335f53 .ag-row[role='row']@ROWINDEX [col-id='cIDCPQVariableDataLabel']","",true, this.CurrentView);
 

        }
        public IRPSGridComboBox<CPQModelEntityView> IDCPQVariableDataLabel { get; set; } 
                     
    }
 
        public partial class CPQSalesQuoteTemplatesCollectionEditor<CPQModelEntityView,CPQModelByLangView>:RPSCollectionEditor<CPQModelEntityView,CPQModelByLangView> where CPQModelEntityView : class, IView where CPQModelByLangView : class, IView
    {
        public  CPQSalesQuoteTemplatesGridView<CPQModelEntityView,CPQModelByLangView> GridView {get;set;}
    }
    public partial class CPQSalesQuoteTemplatesGridView <CPQModelEntityView,CPQModelByLangView> :  RPSGridView<CPQModelEntityView,CPQModelByLangView> where CPQModelEntityView : class, IView where CPQModelByLangView : class, IView
    {
        public CPQSalesQuoteTemplatesGridView(CPQModelEntityView currentView,CPQModelByLangView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            CodLanguage = RPSControlFactory.CreateRPSGridComboBox<CPQModelEntityView>("","#1e735f79-c07b-4a05-b27e-aaf9d9c3686d .ag-row[role='row']@ROWINDEX [col-id='cCodLanguage']","",false, this.CurrentView);
 
            IDCompositionTemplate = RPSControlFactory.CreateRPSGridComboBox<CPQModelEntityView>("","#1e735f79-c07b-4a05-b27e-aaf9d9c3686d .ag-row[role='row']@ROWINDEX [col-id='cIDCompositionTemplate']","",true, this.CurrentView);
 

        }
        public IRPSGridComboBox<CPQModelEntityView> CodLanguage { get; set; } 
        public IRPSGridComboBox<CPQModelEntityView> IDCompositionTemplate { get; set; } 
                     
    }
 
        public partial class CPQSalesQuoteCompositionsCollectionEditor<CPQModelEntityView,CPQModelByLangView>:RPSCollectionEditor<CPQModelEntityView,CPQModelByLangView> where CPQModelEntityView : class, IView where CPQModelByLangView : class, IView
    {
        public  CPQSalesQuoteCompositionsGridView<CPQModelEntityView,CPQModelByLangView> GridView {get;set;}
    }
    public partial class CPQSalesQuoteCompositionsGridView <CPQModelEntityView,CPQModelByLangView> :  RPSGridView<CPQModelEntityView,CPQModelByLangView> where CPQModelEntityView : class, IView where CPQModelByLangView : class, IView
    {
        public CPQSalesQuoteCompositionsGridView(CPQModelEntityView currentView,CPQModelByLangView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            CodLanguage = RPSControlFactory.CreateRPSGridComboBox<CPQModelEntityView>("","#5388886f-1af2-4d5b-ace5-ad05ad10b3e2 .ag-row[role='row']@ROWINDEX [col-id='cCodLanguage']","",false, this.CurrentView);
 
            Order = RPSControlFactory.CreateRPSGridFormattedTextBox<CPQModelEntityView>("","#5388886f-1af2-4d5b-ace5-ad05ad10b3e2 .ag-row[role='row']@ROWINDEX [col-id='cOrder']","",true, this.CurrentView);
 

        }
        public IRPSGridComboBox<CPQModelEntityView> CodLanguage { get; set; } 
        public IRPSGridTextBox<CPQModelEntityView> Order { get; set; } 
                     
    }
 
        public partial class CPQProductCollectionEditor<CPQModelEntityView,CPQModelByLangView>:RPSCollectionEditor<CPQModelEntityView,CPQModelByLangView> where CPQModelEntityView : class, IView where CPQModelByLangView : class, IView
    {
        public  CPQProductGridView<CPQModelEntityView,CPQModelByLangView> GridView {get;set;}
    }
    public partial class CPQProductGridView <CPQModelEntityView,CPQModelByLangView> :  RPSGridView<CPQModelEntityView,CPQModelByLangView> where CPQModelEntityView : class, IView where CPQModelByLangView : class, IView
    {
        public CPQProductGridView(CPQModelEntityView currentView,CPQModelByLangView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            Date = RPSControlFactory.CreateRPSGridTextBox<CPQModelEntityView>("","#0db9f908-6cd6-4231-9508-0153271f83cf .ag-row[role='row']@ROWINDEX [col-id='cDate']","",false, this.CurrentView);
 
            CPQProduct_DescriptionExtended = RPSControlFactory.CreateRPSGridMemoTextBox<CPQModelEntityView>("","#0db9f908-6cd6-4231-9508-0153271f83cf .ag-row[role='row']@ROWINDEX [col-id='cCPQProduct_DescriptionExtended']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<CPQModelEntityView> Date { get; set; } 
        public IRPSGridTextBox<CPQModelEntityView> CPQProduct_DescriptionExtended { get; set; } 
                     
    }
 
    }
  
            
    public partial class CPQModelByLangView : View
    {
        public CPQModelByLangView(CPQModel screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            DeleteButton = RPSControlFactory.RPSDeleteButton<CPQModelByLangView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<CPQModelByLangView,CPQModelEntityView>( this,Screen.CPQModelEntityView);
 
            BackButton = RPSControlFactory.RPSBackButton<CPQModelByLangView,CPQModelEntityView>( this,Screen.CPQModelEntityView);
 
            AcceptButton = RPSControlFactory.RPSAcceptButton<CPQModelByLangView,CPQModelEntityView>( this,Screen.CPQModelEntityView);
 
            CodLanguage = RPSControlFactory.CreateRPSComboBox<CPQModelByLangView>("e13b2ca4-c9bb-4a38-92d1-e52765264982","","",true, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<CPQModelByLangView>("94a8b450-fdaf-4244-abe2-eff464bd87a4","","",false, this);
 
            Tab1Description = RPSControlFactory.CreateRPSTextBox<CPQModelByLangView>("0535cda8-f71a-4b12-9bc7-c2e2f2c25837","","",false, this);
 
            Tab2Description = RPSControlFactory.CreateRPSTextBox<CPQModelByLangView>("23ddf453-2fbb-471d-af6c-eef106be28b0","","",false, this);
 
            Tab3Description = RPSControlFactory.CreateRPSTextBox<CPQModelByLangView>("0bf019f1-803c-411d-9de9-f23dd04a07c0","","",false, this);
 

        }
        public IRPSButton<CPQModelByLangView> DeleteButton { get; set; } 
        public IRPSButton<CPQModelByLangView,CPQModelEntityView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<CPQModelByLangView,CPQModelEntityView> BackButton { get; set; } 
        public IRPSAcceptButton<CPQModelByLangView,CPQModelEntityView> AcceptButton { get; set; } 
        public IRPSComboBox<CPQModelByLangView> CodLanguage { get; set; } 
        public IRPSTextBox<CPQModelByLangView> Description { get; set; } 
        public IRPSTextBox<CPQModelByLangView> Tab1Description { get; set; } 
        public IRPSTextBox<CPQModelByLangView> Tab2Description { get; set; } 
        public IRPSTextBox<CPQModelByLangView> Tab3Description { get; set; } 
        public CPQModel Screen { get; set; }
        public CPQModelByLangView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class CPQOptionGroupView : View
    {
        public CPQOptionGroupView(CPQModel screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            DeleteButton = RPSControlFactory.RPSDeleteButton<CPQOptionGroupView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<CPQOptionGroupView,CPQModelEntityView>( this,Screen.CPQModelEntityView);
 
            BackButton = RPSControlFactory.RPSBackButton<CPQOptionGroupView,CPQModelEntityView>( this,Screen.CPQModelEntityView);
 
            AcceptButton = RPSControlFactory.RPSAcceptButton<CPQOptionGroupView,CPQModelEntityView>( this,Screen.CPQModelEntityView);
 
            Tab = RPSControlFactory.CreateRPSEnumComboBox<CPQOptionGroupView>("544a8c51-3891-4936-a073-30b47716d363","","",true, this);
 
            ShowOrder = RPSControlFactory.CreateRPSFormattedTextBox<CPQOptionGroupView>("f3844671-f68e-47e8-923c-38d68836c342","","",true, this);
 
            SequenceOrder = RPSControlFactory.CreateRPSFormattedTextBox<CPQOptionGroupView>("f29c65e2-5167-4d87-af57-ea34a1957ee8","","",true, this);
 
            CODOptionGroup = RPSControlFactory.CreateRPSTextBox<CPQOptionGroupView>("44751bf9-317d-488d-9b41-b1aa5a8ce4dc","","",true, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<CPQOptionGroupView>("d5c58fdf-c737-461e-a0ae-528a0e5706e5","","",true, this);
 
            SelectionRequired = RPSControlFactory.CreateRPSCheckBox<CPQOptionGroupView>("ed6983eb-6dc3-4e49-818d-52d46c88a87e","","",true, this);
 
            Visible = RPSControlFactory.CreateRPSCheckBox<CPQOptionGroupView>("ef0d75ef-439a-4a03-b78a-17b07a146792","","",true, this);
 
            HideIncompatible = RPSControlFactory.CreateRPSCheckBox<CPQOptionGroupView>("d6a7583f-ff62-4c4c-9c11-78b51d729f3d","","",true, this);
 
            SelectionType = RPSControlFactory.CreateRPSEnumComboBox<CPQOptionGroupView>("0cd28acc-505d-48be-9d5f-144416341c69","","",true, this);
 
            IterationNumber = RPSControlFactory.CreateRPSFormattedTextBox<CPQOptionGroupView>("8784e43e-dfec-49c0-a166-b3ecdd2668bc","","",false, this);
 
            DescriptionExtended = RPSControlFactory.CreateRPSTextBox<CPQOptionGroupView>("5ed332fc-3df0-4573-be61-484196db521d","","",false, this);
 
            CollectionInit params_CPQOptionGroupByLangs = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="d056f71d-33cf-41c5-8b35-ead3fdc2097e",CSSSelectorGrid="",XPathGrid=""};
            CPQOptionGroupByLangs = RPSControlFactory.RPSCreateCollectionWithGrid<CPQOptionGroupByLangsCollectionEditor<CPQOptionGroupView,CPQOptionGroupByLangView>,CPQOptionGroupView,CPQOptionGroupByLangView>( params_CPQOptionGroupByLangs,this,Screen.CPQOptionGroupByLangView);
 
            CollectionInit params_CPQOptions = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="c7ac387f-7ca1-4e21-a1e9-9cd60297f090",CSSSelectorGrid="",XPathGrid=""};
            CPQOptions = RPSControlFactory.RPSCreateCollectionWithGrid<CPQOptionsCollectionEditor<CPQOptionGroupView,CPQOptionGroupByLangView>,CPQOptionGroupView,CPQOptionGroupByLangView>( params_CPQOptions,this,Screen.CPQOptionGroupByLangView);
 
            CollectionInit params_CPQVariableDataLists = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="0449a377-01b6-4621-b237-739f243feccc",CSSSelectorGrid="",XPathGrid=""};
            CPQVariableDataLists = RPSControlFactory.RPSCreateCollectionWithGrid<CPQVariableDataListsCollectionEditor<CPQOptionGroupView,CPQOptionGroupByLangView>,CPQOptionGroupView,CPQOptionGroupByLangView>( params_CPQVariableDataLists,this,Screen.CPQOptionGroupByLangView);
 
            CollectionInit params_CPQOptionGroupActions = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="cda62a58-9287-4121-aba4-6f34a173dd68",CSSSelectorGrid="",XPathGrid=""};
            CPQOptionGroupActions = RPSControlFactory.RPSCreateCollectionWithGrid<CPQOptionGroupActionsCollectionEditor<CPQOptionGroupView,CPQOptionGroupByLangView>,CPQOptionGroupView,CPQOptionGroupByLangView>( params_CPQOptionGroupActions,this,Screen.CPQOptionGroupByLangView);
 
            GeneralData = RPSControlFactory.CreateRPSSection<CPQOptionGroupView>( "","ul li[rpsid='814e039a-4512-486f-8fb7-442ea9c46a2f']","",this);
 
            Options = RPSControlFactory.CreateRPSSection<CPQOptionGroupView>( "","ul li[rpsid='88055596-e8f3-4489-b70a-739ac5e94a64']","",this);
 
            VariableDataList = RPSControlFactory.CreateRPSSection<CPQOptionGroupView>( "","ul li[rpsid='35aac908-6021-4232-9f1f-a2d643ddd416']","",this);
 
            Actions = RPSControlFactory.CreateRPSSection<CPQOptionGroupView>( "","ul li[rpsid='12ba2550-4313-450b-8da1-9156bd6723ca']","",this);
 

        }
        public IRPSButton<CPQOptionGroupView> DeleteButton { get; set; } 
        public IRPSButton<CPQOptionGroupView,CPQModelEntityView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<CPQOptionGroupView,CPQModelEntityView> BackButton { get; set; } 
        public IRPSAcceptButton<CPQOptionGroupView,CPQModelEntityView> AcceptButton { get; set; } 
        public IRPSComboBox<CPQOptionGroupView> Tab { get; set; } 
        public IRPSTextBox<CPQOptionGroupView> ShowOrder { get; set; } 
        public IRPSTextBox<CPQOptionGroupView> SequenceOrder { get; set; } 
        public IRPSTextBox<CPQOptionGroupView> CODOptionGroup { get; set; } 
        public IRPSTextBox<CPQOptionGroupView> Description { get; set; } 
        public IRPSCheckbox<CPQOptionGroupView> SelectionRequired { get; set; } 
        public IRPSCheckbox<CPQOptionGroupView> Visible { get; set; } 
        public IRPSCheckbox<CPQOptionGroupView> HideIncompatible { get; set; } 
        public IRPSComboBox<CPQOptionGroupView> SelectionType { get; set; } 
        public IRPSTextBox<CPQOptionGroupView> IterationNumber { get; set; } 
        public IRPSTextBox<CPQOptionGroupView> DescriptionExtended { get; set; } 
        public CPQOptionGroupByLangsCollectionEditor<CPQOptionGroupView,CPQOptionGroupByLangView> CPQOptionGroupByLangs { get; set; } 
        public CPQOptionsCollectionEditor<CPQOptionGroupView,CPQOptionGroupByLangView> CPQOptions { get; set; } 
        public CPQVariableDataListsCollectionEditor<CPQOptionGroupView,CPQOptionGroupByLangView> CPQVariableDataLists { get; set; } 
        public CPQOptionGroupActionsCollectionEditor<CPQOptionGroupView,CPQOptionGroupByLangView> CPQOptionGroupActions { get; set; } 
        public IRPSSection<CPQOptionGroupView> GeneralData { get; set; } 
        public IRPSSection<CPQOptionGroupView> Options { get; set; } 
        public IRPSSection<CPQOptionGroupView> VariableDataList { get; set; } 
        public IRPSSection<CPQOptionGroupView> Actions { get; set; } 
        public CPQModel Screen { get; set; }
        public CPQOptionGroupView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class CPQOptionGroupByLangsCollectionEditor<CPQOptionGroupView,CPQOptionGroupByLangView>:RPSCollectionEditor<CPQOptionGroupView,CPQOptionGroupByLangView> where CPQOptionGroupView : class, IView where CPQOptionGroupByLangView : class, IView
    {
        public  CPQOptionGroupByLangsGridView<CPQOptionGroupView,CPQOptionGroupByLangView> GridView {get;set;}
    }
    public partial class CPQOptionGroupByLangsGridView <CPQOptionGroupView,CPQOptionGroupByLangView> :  RPSGridView<CPQOptionGroupView,CPQOptionGroupByLangView> where CPQOptionGroupView : class, IView where CPQOptionGroupByLangView : class, IView
    {
        public CPQOptionGroupByLangsGridView(CPQOptionGroupView currentView,CPQOptionGroupByLangView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            CodLanguage = RPSControlFactory.CreateRPSGridComboBox<CPQOptionGroupView>("","#d056f71d-33cf-41c5-8b35-ead3fdc2097e .ag-row[role='row']@ROWINDEX [col-id='cCodLanguage']","",true, this.CurrentView);
 
            Description = RPSControlFactory.CreateRPSGridTextBox<CPQOptionGroupView>("","#d056f71d-33cf-41c5-8b35-ead3fdc2097e .ag-row[role='row']@ROWINDEX [col-id='cDescription']","",false, this.CurrentView);
 
            DescriptionExtended = RPSControlFactory.CreateRPSGridMemoTextBox<CPQOptionGroupView>("","#d056f71d-33cf-41c5-8b35-ead3fdc2097e .ag-row[role='row']@ROWINDEX [col-id='cDescriptionExtended']","",false, this.CurrentView);
 

        }
        public IRPSGridComboBox<CPQOptionGroupView> CodLanguage { get; set; } 
        public IRPSGridTextBox<CPQOptionGroupView> Description { get; set; } 
        public IRPSGridTextBox<CPQOptionGroupView> DescriptionExtended { get; set; } 
                     
    }
 
        public partial class CPQOptionsCollectionEditor<CPQOptionGroupView,CPQOptionGroupByLangView>:RPSCollectionEditor<CPQOptionGroupView,CPQOptionGroupByLangView> where CPQOptionGroupView : class, IView where CPQOptionGroupByLangView : class, IView
    {
        public  CPQOptionsGridView<CPQOptionGroupView,CPQOptionGroupByLangView> GridView {get;set;}
    }
    public partial class CPQOptionsGridView <CPQOptionGroupView,CPQOptionGroupByLangView> :  RPSGridView<CPQOptionGroupView,CPQOptionGroupByLangView> where CPQOptionGroupView : class, IView where CPQOptionGroupByLangView : class, IView
    {
        public CPQOptionsGridView(CPQOptionGroupView currentView,CPQOptionGroupByLangView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            ShowOrder = RPSControlFactory.CreateRPSGridFormattedTextBox<CPQOptionGroupView>("","#c7ac387f-7ca1-4e21-a1e9-9cd60297f090 .ag-row[role='row']@ROWINDEX [col-id='cShowOrder']","",true, this.CurrentView);
 
            CodOption = RPSControlFactory.CreateRPSGridTextBox<CPQOptionGroupView>("","#c7ac387f-7ca1-4e21-a1e9-9cd60297f090 .ag-row[role='row']@ROWINDEX [col-id='cCodOption']","",true, this.CurrentView);
 
            Classification = RPSControlFactory.CreateRPSGridTextBox<CPQOptionGroupView>("","#c7ac387f-7ca1-4e21-a1e9-9cd60297f090 .ag-row[role='row']@ROWINDEX [col-id='cClassification']","",false, this.CurrentView);
 
            Description = RPSControlFactory.CreateRPSGridTextBox<CPQOptionGroupView>("","#c7ac387f-7ca1-4e21-a1e9-9cd60297f090 .ag-row[role='row']@ROWINDEX [col-id='cDescription']","",true, this.CurrentView);
 
            Selected = RPSControlFactory.CreateRPSGridCheckBox<CPQOptionGroupView>("","#c7ac387f-7ca1-4e21-a1e9-9cd60297f090 .ag-row[role='row']@ROWINDEX [col-id='cSelected']","",true, this.CurrentView);
 
            IDCPQVariableDataLabel = RPSControlFactory.CreateRPSGridComboBox<CPQOptionGroupView>("","#c7ac387f-7ca1-4e21-a1e9-9cd60297f090 .ag-row[role='row']@ROWINDEX [col-id='cIDCPQVariableDataLabel']","",false, this.CurrentView);
 
            RequiredData = RPSControlFactory.CreateRPSGridCheckBox<CPQOptionGroupView>("","#c7ac387f-7ca1-4e21-a1e9-9cd60297f090 .ag-row[role='row']@ROWINDEX [col-id='cRequiredData']","",true, this.CurrentView);
 

        }
        public IRPSGridTextBox<CPQOptionGroupView> ShowOrder { get; set; } 
        public IRPSGridTextBox<CPQOptionGroupView> CodOption { get; set; } 
        public IRPSGridTextBox<CPQOptionGroupView> Classification { get; set; } 
        public IRPSGridTextBox<CPQOptionGroupView> Description { get; set; } 
        public IRPSGridCheckbox<CPQOptionGroupView> Selected { get; set; } 
        public IRPSGridComboBox<CPQOptionGroupView> IDCPQVariableDataLabel { get; set; } 
        public IRPSGridCheckbox<CPQOptionGroupView> RequiredData { get; set; } 
                     
    }
 
        public partial class CPQVariableDataListsCollectionEditor<CPQOptionGroupView,CPQOptionGroupByLangView>:RPSCollectionEditor<CPQOptionGroupView,CPQOptionGroupByLangView> where CPQOptionGroupView : class, IView where CPQOptionGroupByLangView : class, IView
    {
        public  CPQVariableDataListsGridView<CPQOptionGroupView,CPQOptionGroupByLangView> GridView {get;set;}
    }
    public partial class CPQVariableDataListsGridView <CPQOptionGroupView,CPQOptionGroupByLangView> :  RPSGridView<CPQOptionGroupView,CPQOptionGroupByLangView> where CPQOptionGroupView : class, IView where CPQOptionGroupByLangView : class, IView
    {
        public CPQVariableDataListsGridView(CPQOptionGroupView currentView,CPQOptionGroupByLangView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            ShowOrder = RPSControlFactory.CreateRPSGridFormattedTextBox<CPQOptionGroupView>("","#0449a377-01b6-4621-b237-739f243feccc .ag-row[role='row']@ROWINDEX [col-id='cShowOrder']","",true, this.CurrentView);
 
            IDCPQVariableDataLabel = RPSControlFactory.CreateRPSGridComboBox<CPQOptionGroupView>("","#0449a377-01b6-4621-b237-739f243feccc .ag-row[role='row']@ROWINDEX [col-id='cIDCPQVariableDataLabel']","",true, this.CurrentView);
 
            RequiredData = RPSControlFactory.CreateRPSGridCheckBox<CPQOptionGroupView>("","#0449a377-01b6-4621-b237-739f243feccc .ag-row[role='row']@ROWINDEX [col-id='cRequiredData']","",true, this.CurrentView);
 

        }
        public IRPSGridTextBox<CPQOptionGroupView> ShowOrder { get; set; } 
        public IRPSGridComboBox<CPQOptionGroupView> IDCPQVariableDataLabel { get; set; } 
        public IRPSGridCheckbox<CPQOptionGroupView> RequiredData { get; set; } 
                     
    }
 
        public partial class CPQOptionGroupActionsCollectionEditor<CPQOptionGroupView,CPQOptionGroupByLangView>:RPSCollectionEditor<CPQOptionGroupView,CPQOptionGroupByLangView> where CPQOptionGroupView : class, IView where CPQOptionGroupByLangView : class, IView
    {
        public  CPQOptionGroupActionsGridView<CPQOptionGroupView,CPQOptionGroupByLangView> GridView {get;set;}
    }
    public partial class CPQOptionGroupActionsGridView <CPQOptionGroupView,CPQOptionGroupByLangView> :  RPSGridView<CPQOptionGroupView,CPQOptionGroupByLangView> where CPQOptionGroupView : class, IView where CPQOptionGroupByLangView : class, IView
    {
        public CPQOptionGroupActionsGridView(CPQOptionGroupView currentView,CPQOptionGroupByLangView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            ExecutionOrder = RPSControlFactory.CreateRPSGridFormattedTextBox<CPQOptionGroupView>("","#cda62a58-9287-4121-aba4-6f34a173dd68 .ag-row[role='row']@ROWINDEX [col-id='cExecutionOrder']","",true, this.CurrentView);
 
            Description = RPSControlFactory.CreateRPSGridMemoTextBox<CPQOptionGroupView>("","#cda62a58-9287-4121-aba4-6f34a173dd68 .ag-row[role='row']@ROWINDEX [col-id='cDescription']","",false, this.CurrentView);
 
            Condition = RPSControlFactory.CreateRPSGridMemoTextBox<CPQOptionGroupView>("","#cda62a58-9287-4121-aba4-6f34a173dd68 .ag-row[role='row']@ROWINDEX [col-id='cCondition']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<CPQOptionGroupView> ExecutionOrder { get; set; } 
        public IRPSGridTextBox<CPQOptionGroupView> Description { get; set; } 
        public IRPSGridTextBox<CPQOptionGroupView> Condition { get; set; } 
                     
    }
 
    }
  
            
    public partial class CPQOptionGroupByLangView : View
    {
        public CPQOptionGroupByLangView(CPQModel screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            DeleteButton = RPSControlFactory.RPSDeleteButton<CPQOptionGroupByLangView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<CPQOptionGroupByLangView,CPQOptionGroupView>( this,Screen.CPQOptionGroupView);
 
            BackButton = RPSControlFactory.RPSBackButton<CPQOptionGroupByLangView,CPQOptionGroupView>( this,Screen.CPQOptionGroupView);
 
            AcceptButton = RPSControlFactory.RPSAcceptButton<CPQOptionGroupByLangView,CPQOptionGroupView>( this,Screen.CPQOptionGroupView);
 
            CodLanguage = RPSControlFactory.CreateRPSComboBox<CPQOptionGroupByLangView>("f676ec05-9a05-4079-9da5-ad9a7cdba6b9","","",true, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<CPQOptionGroupByLangView>("ad3c26c1-de72-45a3-8f9d-bbe106978cdd","","",false, this);
 
            DescriptionExtended = RPSControlFactory.CreateRPSTextBox<CPQOptionGroupByLangView>("d5868371-2a17-40bf-9bb9-9fec06dea53b","","",false, this);
 

        }
        public IRPSButton<CPQOptionGroupByLangView> DeleteButton { get; set; } 
        public IRPSButton<CPQOptionGroupByLangView,CPQOptionGroupView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<CPQOptionGroupByLangView,CPQOptionGroupView> BackButton { get; set; } 
        public IRPSAcceptButton<CPQOptionGroupByLangView,CPQOptionGroupView> AcceptButton { get; set; } 
        public IRPSComboBox<CPQOptionGroupByLangView> CodLanguage { get; set; } 
        public IRPSTextBox<CPQOptionGroupByLangView> Description { get; set; } 
        public IRPSTextBox<CPQOptionGroupByLangView> DescriptionExtended { get; set; } 
        public CPQModel Screen { get; set; }
        public CPQOptionGroupByLangView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class CPQOptionView : View
    {
        public CPQOptionView(CPQModel screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            DeleteButton = RPSControlFactory.RPSDeleteButton<CPQOptionView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<CPQOptionView,CPQOptionGroupView>( this,Screen.CPQOptionGroupView);
 
            BackButton = RPSControlFactory.RPSBackButton<CPQOptionView,CPQOptionGroupView>( this,Screen.CPQOptionGroupView);
 
            AcceptButton = RPSControlFactory.RPSAcceptButton<CPQOptionView,CPQOptionGroupView>( this,Screen.CPQOptionGroupView);
 
            ShowOrder = RPSControlFactory.CreateRPSFormattedTextBox<CPQOptionView>("dfc6e0ee-6d13-42f8-809a-9058e4b0ca39","","",true, this);
 
            CodOption = RPSControlFactory.CreateRPSTextBox<CPQOptionView>("dc045152-6fcd-411f-aa26-d12f54cdc19a","","",true, this);
 
            Classification = RPSControlFactory.CreateRPSTextBox<CPQOptionView>("2182bdc8-310c-436e-933c-037c684d53db","","",false, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<CPQOptionView>("3d299404-ef2f-4272-981c-bff4eea764dc","","",true, this);
 
            Selected = RPSControlFactory.CreateRPSCheckBox<CPQOptionView>("ec5a5d1e-fedc-4ffa-a13a-da7ccf6b6ead","","",true, this);
 
            IDCPQVariableDataLabel = RPSControlFactory.CreateRPSComboBox<CPQOptionView>("2d267e67-6a57-43c9-b2b8-028c2f96ac44","","",false, this);
 
            RequiredData = RPSControlFactory.CreateRPSCheckBox<CPQOptionView>("977d2ffa-5cde-4ea0-a0e2-ac77ddd3756f","","",true, this);
 
            DescriptionExtended = RPSControlFactory.CreateRPSTextBox<CPQOptionView>("41ff9e8b-a141-4f29-8d95-59471e01efb6","","",false, this);
 
            CollectionInit params_CPQOptionByLangs = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="123c0e54-538a-4f7e-a198-3cad8164b3b9",CSSSelectorGrid="",XPathGrid=""};
            CPQOptionByLangs = RPSControlFactory.RPSCreateCollectionWithGrid<CPQOptionByLangsCollectionEditor<CPQOptionView,CPQOptionByLangView>,CPQOptionView,CPQOptionByLangView>( params_CPQOptionByLangs,this,Screen.CPQOptionByLangView);
 
            CollectionInit params_CPQOptionArticles = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="37f1654f-b39f-4c0b-a931-c857dc7b9ada",CSSSelectorGrid="",XPathGrid=""};
            CPQOptionArticles = RPSControlFactory.RPSCreateCollectionWithGrid<CPQOptionArticlesCollectionEditor<CPQOptionView,CPQOptionByLangView>,CPQOptionView,CPQOptionByLangView>( params_CPQOptionArticles,this,Screen.CPQOptionByLangView);
 
            CollectionInit params_CPQOptionVariableDatas = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="eaeda43c-81cd-4ae6-8eab-6992cd600b3d",CSSSelectorGrid="",XPathGrid=""};
            CPQOptionVariableDatas = RPSControlFactory.RPSCreateCollectionWithGrid<CPQOptionVariableDatasCollectionEditor<CPQOptionView,CPQOptionByLangView>,CPQOptionView,CPQOptionByLangView>( params_CPQOptionVariableDatas,this,Screen.CPQOptionByLangView);
 
            GeneralData = RPSControlFactory.CreateRPSSection<CPQOptionView>( "","ul li[rpsid='f901eea7-caca-4704-9575-58ff8d6f5e20']","",this);
 
            Articles = RPSControlFactory.CreateRPSSection<CPQOptionView>( "","ul li[rpsid='bafef09a-5970-4085-8357-905af6bd2238']","",this);
 
            VariableData = RPSControlFactory.CreateRPSSection<CPQOptionView>( "","ul li[rpsid='e8007da5-9dfe-4a23-a1ba-2d52db380791']","",this);
 

        }
        public IRPSButton<CPQOptionView> DeleteButton { get; set; } 
        public IRPSButton<CPQOptionView,CPQOptionGroupView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<CPQOptionView,CPQOptionGroupView> BackButton { get; set; } 
        public IRPSAcceptButton<CPQOptionView,CPQOptionGroupView> AcceptButton { get; set; } 
        public IRPSTextBox<CPQOptionView> ShowOrder { get; set; } 
        public IRPSTextBox<CPQOptionView> CodOption { get; set; } 
        public IRPSTextBox<CPQOptionView> Classification { get; set; } 
        public IRPSTextBox<CPQOptionView> Description { get; set; } 
        public IRPSCheckbox<CPQOptionView> Selected { get; set; } 
        public IRPSComboBox<CPQOptionView> IDCPQVariableDataLabel { get; set; } 
        public IRPSCheckbox<CPQOptionView> RequiredData { get; set; } 
        public IRPSTextBox<CPQOptionView> DescriptionExtended { get; set; } 
        public CPQOptionByLangsCollectionEditor<CPQOptionView,CPQOptionByLangView> CPQOptionByLangs { get; set; } 
        public CPQOptionArticlesCollectionEditor<CPQOptionView,CPQOptionByLangView> CPQOptionArticles { get; set; } 
        public CPQOptionVariableDatasCollectionEditor<CPQOptionView,CPQOptionByLangView> CPQOptionVariableDatas { get; set; } 
        public IRPSSection<CPQOptionView> GeneralData { get; set; } 
        public IRPSSection<CPQOptionView> Articles { get; set; } 
        public IRPSSection<CPQOptionView> VariableData { get; set; } 
        public CPQModel Screen { get; set; }
        public CPQOptionView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class CPQOptionByLangsCollectionEditor<CPQOptionView,CPQOptionByLangView>:RPSCollectionEditor<CPQOptionView,CPQOptionByLangView> where CPQOptionView : class, IView where CPQOptionByLangView : class, IView
    {
        public  CPQOptionByLangsGridView<CPQOptionView,CPQOptionByLangView> GridView {get;set;}
    }
    public partial class CPQOptionByLangsGridView <CPQOptionView,CPQOptionByLangView> :  RPSGridView<CPQOptionView,CPQOptionByLangView> where CPQOptionView : class, IView where CPQOptionByLangView : class, IView
    {
        public CPQOptionByLangsGridView(CPQOptionView currentView,CPQOptionByLangView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            CodLanguage = RPSControlFactory.CreateRPSGridComboBox<CPQOptionView>("","#123c0e54-538a-4f7e-a198-3cad8164b3b9 .ag-row[role='row']@ROWINDEX [col-id='cCodLanguage']","",true, this.CurrentView);
 
            Description = RPSControlFactory.CreateRPSGridTextBox<CPQOptionView>("","#123c0e54-538a-4f7e-a198-3cad8164b3b9 .ag-row[role='row']@ROWINDEX [col-id='cDescription']","",false, this.CurrentView);
 
            DescriptionExtended = RPSControlFactory.CreateRPSGridMemoTextBox<CPQOptionView>("","#123c0e54-538a-4f7e-a198-3cad8164b3b9 .ag-row[role='row']@ROWINDEX [col-id='cDescriptionExtended']","",false, this.CurrentView);
 

        }
        public IRPSGridComboBox<CPQOptionView> CodLanguage { get; set; } 
        public IRPSGridTextBox<CPQOptionView> Description { get; set; } 
        public IRPSGridTextBox<CPQOptionView> DescriptionExtended { get; set; } 
                     
    }
 
        public partial class CPQOptionArticlesCollectionEditor<CPQOptionView,CPQOptionByLangView>:RPSCollectionEditor<CPQOptionView,CPQOptionByLangView> where CPQOptionView : class, IView where CPQOptionByLangView : class, IView
    {
        public  CPQOptionArticlesGridView<CPQOptionView,CPQOptionByLangView> GridView {get;set;}
    }
    public partial class CPQOptionArticlesGridView <CPQOptionView,CPQOptionByLangView> :  RPSGridView<CPQOptionView,CPQOptionByLangView> where CPQOptionView : class, IView where CPQOptionByLangView : class, IView
    {
        public CPQOptionArticlesGridView(CPQOptionView currentView,CPQOptionByLangView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            IDArticle = RPSControlFactory.CreateRPSGridComboBox<CPQOptionView>("","#37f1654f-b39f-4c0b-a931-c857dc7b9ada .ag-row[role='row']@ROWINDEX [col-id='cIDArticle']","",true, this.CurrentView);
 
            Quantity = RPSControlFactory.CreateRPSGridFormattedTextBox<CPQOptionView>("","#37f1654f-b39f-4c0b-a931-c857dc7b9ada .ag-row[role='row']@ROWINDEX [col-id='cQuantityFixed']","",true, this.CurrentView);
 
            QuantityFormula = RPSControlFactory.CreateRPSGridMemoTextBox<CPQOptionView>("","#37f1654f-b39f-4c0b-a931-c857dc7b9ada .ag-row[role='row']@ROWINDEX [col-id='cQuantityFormula']","",false, this.CurrentView);
 
            OptionArticleFormulaEditorNavigationCommand = RPSControlFactory.CreateRPSGridButtonToView<CPQOptionView,OptionArticleFormulaEditorDialogView>("","#37f1654f-b39f-4c0b-a931-c857dc7b9ada .ag-row[role='row']@ROWINDEX [col-id='cOptionArticleFormulaEditorNavigationCommand']","", this.CurrentView,this.CurrentView.Screen.GetViewInstance<OptionArticleFormulaEditorDialogView>());
 

        }
        public IRPSGridComboBox<CPQOptionView> IDArticle { get; set; } 
        public IRPSGridTextBox<CPQOptionView> Quantity { get; set; } 
        public IRPSGridTextBox<CPQOptionView> QuantityFormula { get; set; } 
        public IRPSGridButton<CPQOptionView,OptionArticleFormulaEditorDialogView> OptionArticleFormulaEditorNavigationCommand { get; set; } 
                     
    }
 
        public partial class CPQOptionVariableDatasCollectionEditor<CPQOptionView,CPQOptionByLangView>:RPSCollectionEditor<CPQOptionView,CPQOptionByLangView> where CPQOptionView : class, IView where CPQOptionByLangView : class, IView
    {
        public  CPQOptionVariableDatasGridView<CPQOptionView,CPQOptionByLangView> GridView {get;set;}
    }
    public partial class CPQOptionVariableDatasGridView <CPQOptionView,CPQOptionByLangView> :  RPSGridView<CPQOptionView,CPQOptionByLangView> where CPQOptionView : class, IView where CPQOptionByLangView : class, IView
    {
        public CPQOptionVariableDatasGridView(CPQOptionView currentView,CPQOptionByLangView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            IDCPQVariableDataLabel = RPSControlFactory.CreateRPSGridComboBox<CPQOptionView>("","#eaeda43c-81cd-4ae6-8eab-6992cd600b3d .ag-row[role='row']@ROWINDEX [col-id='cIDCPQVariableDataLabel']","",true, this.CurrentView);
 

        }
        public IRPSGridComboBox<CPQOptionView> IDCPQVariableDataLabel { get; set; } 
                     
    }
 
    }
  
            
    public partial class CPQOptionByLangView : View
    {
        public CPQOptionByLangView(CPQModel screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            DeleteButton = RPSControlFactory.RPSDeleteButton<CPQOptionByLangView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<CPQOptionByLangView,CPQOptionView>( this,Screen.CPQOptionView);
 
            BackButton = RPSControlFactory.RPSBackButton<CPQOptionByLangView,CPQOptionView>( this,Screen.CPQOptionView);
 
            AcceptButton = RPSControlFactory.RPSAcceptButton<CPQOptionByLangView,CPQOptionView>( this,Screen.CPQOptionView);
 
            CodLanguage = RPSControlFactory.CreateRPSComboBox<CPQOptionByLangView>("39b8d1c1-a120-4d3a-a97b-c59dff6bdbd2","","",true, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<CPQOptionByLangView>("561be204-6cd7-4f3e-856a-0464bdad1b98","","",false, this);
 
            DescriptionExtended = RPSControlFactory.CreateRPSTextBox<CPQOptionByLangView>("ab92019b-5b4e-4934-8fef-053a56a82b7c","","",false, this);
 

        }
        public IRPSButton<CPQOptionByLangView> DeleteButton { get; set; } 
        public IRPSButton<CPQOptionByLangView,CPQOptionView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<CPQOptionByLangView,CPQOptionView> BackButton { get; set; } 
        public IRPSAcceptButton<CPQOptionByLangView,CPQOptionView> AcceptButton { get; set; } 
        public IRPSComboBox<CPQOptionByLangView> CodLanguage { get; set; } 
        public IRPSTextBox<CPQOptionByLangView> Description { get; set; } 
        public IRPSTextBox<CPQOptionByLangView> DescriptionExtended { get; set; } 
        public CPQModel Screen { get; set; }
        public CPQOptionByLangView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class CPQVariableDataListView : View
    {
        public CPQVariableDataListView(CPQModel screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            DeleteButton = RPSControlFactory.RPSDeleteButton<CPQVariableDataListView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<CPQVariableDataListView,CPQOptionGroupView>( this,Screen.CPQOptionGroupView);
 
            BackButton = RPSControlFactory.RPSBackButton<CPQVariableDataListView,CPQOptionGroupView>( this,Screen.CPQOptionGroupView);
 
            AcceptButton = RPSControlFactory.RPSAcceptButton<CPQVariableDataListView,CPQOptionGroupView>( this,Screen.CPQOptionGroupView);
 
            ShowOrder = RPSControlFactory.CreateRPSFormattedTextBox<CPQVariableDataListView>("adcd5e46-bd20-4aaa-89a3-c64c93dc0d33","","",true, this);
 
            IDCPQVariableDataLabel = RPSControlFactory.CreateRPSComboBox<CPQVariableDataListView>("948835a3-2801-469d-92a4-f49fd7566839","","",true, this);
 
            RequiredData = RPSControlFactory.CreateRPSCheckBox<CPQVariableDataListView>("1324d7bc-4074-45f6-8a79-4c7ebbd19538","","",true, this);
 
            CollectionInit params_CPQVariableDataListByLangs = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="5854e7c4-6648-4102-82e2-ac85f627aeb9",CSSSelectorGrid="",XPathGrid=""};
            CPQVariableDataListByLangs = RPSControlFactory.RPSCreateCollectionWithGrid<CPQVariableDataListByLangsCollectionEditor<CPQVariableDataListView,CPQVariableDataListByLangView>,CPQVariableDataListView,CPQVariableDataListByLangView>( params_CPQVariableDataListByLangs,this,Screen.CPQVariableDataListByLangView);
 

        }
        public IRPSButton<CPQVariableDataListView> DeleteButton { get; set; } 
        public IRPSButton<CPQVariableDataListView,CPQOptionGroupView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<CPQVariableDataListView,CPQOptionGroupView> BackButton { get; set; } 
        public IRPSAcceptButton<CPQVariableDataListView,CPQOptionGroupView> AcceptButton { get; set; } 
        public IRPSTextBox<CPQVariableDataListView> ShowOrder { get; set; } 
        public IRPSComboBox<CPQVariableDataListView> IDCPQVariableDataLabel { get; set; } 
        public IRPSCheckbox<CPQVariableDataListView> RequiredData { get; set; } 
        public CPQVariableDataListByLangsCollectionEditor<CPQVariableDataListView,CPQVariableDataListByLangView> CPQVariableDataListByLangs { get; set; } 
        public CPQModel Screen { get; set; }
        public CPQVariableDataListView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class CPQVariableDataListByLangsCollectionEditor<CPQVariableDataListView,CPQVariableDataListByLangView>:RPSCollectionEditor<CPQVariableDataListView,CPQVariableDataListByLangView> where CPQVariableDataListView : class, IView where CPQVariableDataListByLangView : class, IView
    {
        public  CPQVariableDataListByLangsGridView<CPQVariableDataListView,CPQVariableDataListByLangView> GridView {get;set;}
    }
    public partial class CPQVariableDataListByLangsGridView <CPQVariableDataListView,CPQVariableDataListByLangView> :  RPSGridView<CPQVariableDataListView,CPQVariableDataListByLangView> where CPQVariableDataListView : class, IView where CPQVariableDataListByLangView : class, IView
    {
        public CPQVariableDataListByLangsGridView(CPQVariableDataListView currentView,CPQVariableDataListByLangView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            CodLanguage = RPSControlFactory.CreateRPSGridComboBox<CPQVariableDataListView>("","#5854e7c4-6648-4102-82e2-ac85f627aeb9 .ag-row[role='row']@ROWINDEX [col-id='cCodLanguage']","",true, this.CurrentView);
 

        }
        public IRPSGridComboBox<CPQVariableDataListView> CodLanguage { get; set; } 
                     
    }
 
    }
  
            
    public partial class CPQVariableDataListByLangView : View
    {
        public CPQVariableDataListByLangView(CPQModel screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            DeleteButton = RPSControlFactory.RPSDeleteButton<CPQVariableDataListByLangView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<CPQVariableDataListByLangView,CPQVariableDataListView>( this,Screen.CPQVariableDataListView);
 
            BackButton = RPSControlFactory.RPSBackButton<CPQVariableDataListByLangView,CPQVariableDataListView>( this,Screen.CPQVariableDataListView);
 
            AcceptButton = RPSControlFactory.RPSAcceptButton<CPQVariableDataListByLangView,CPQVariableDataListView>( this,Screen.CPQVariableDataListView);
 
            CodLanguage = RPSControlFactory.CreateRPSComboBox<CPQVariableDataListByLangView>("32551d35-cfcb-4bd2-8551-428fd3f5e6df","","",true, this);
 

        }
        public IRPSButton<CPQVariableDataListByLangView> DeleteButton { get; set; } 
        public IRPSButton<CPQVariableDataListByLangView,CPQVariableDataListView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<CPQVariableDataListByLangView,CPQVariableDataListView> BackButton { get; set; } 
        public IRPSAcceptButton<CPQVariableDataListByLangView,CPQVariableDataListView> AcceptButton { get; set; } 
        public IRPSComboBox<CPQVariableDataListByLangView> CodLanguage { get; set; } 
        public CPQModel Screen { get; set; }
        public CPQVariableDataListByLangView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class NewModelCreatorDialogView : View
    {
        public NewModelCreatorDialogView(CPQModel screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            CodNewModel = RPSControlFactory.CreateRPSTextBox<NewModelCreatorDialogView>("6dc14e89-ba65-44f7-bcb0-6ef20d34e06f","","",false, this);
 
            CodVersionNewModel = RPSControlFactory.CreateRPSTextBox<NewModelCreatorDialogView>("3a7f3034-a76a-4af9-a020-828714fa7952","","",true, this);
 
            DescriptionNewModel = RPSControlFactory.CreateRPSTextBox<NewModelCreatorDialogView>("dbd701fc-ab77-4ff7-b63c-eb951fb96f5a","","",false, this);
 

        }
        public IRPSTextBox<NewModelCreatorDialogView> CodNewModel { get; set; } 
        public IRPSTextBox<NewModelCreatorDialogView> CodVersionNewModel { get; set; } 
        public IRPSTextBox<NewModelCreatorDialogView> DescriptionNewModel { get; set; } 
        public CPQModel Screen { get; set; }
        public NewModelCreatorDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class CPQModelActionView : View
    {
        public CPQModelActionView(CPQModel screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            DeleteButton = RPSControlFactory.RPSDeleteButton<CPQModelActionView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<CPQModelActionView,CPQOptionGroupActionView>( this,Screen.CPQOptionGroupActionView);
 
            BackButton = RPSControlFactory.RPSBackButton<CPQModelActionView,CPQOptionGroupActionView>( this,Screen.CPQOptionGroupActionView);
 
            AcceptButton = RPSControlFactory.RPSAcceptButton<CPQModelActionView,CPQOptionGroupActionView>( this,Screen.CPQOptionGroupActionView);
 
            ExecutionOrder = RPSControlFactory.CreateRPSFormattedTextBox<CPQModelActionView>("0e445ac7-f80d-44e8-9f4d-d3a6cf814acd","","",true, this);
 
            Event = RPSControlFactory.CreateRPSEnumComboBox<CPQModelActionView>("d9b034ec-dabd-4250-96e6-fa12ea63bc99","","",true, this);
 
            ModelActionConditionEditorNavigationCommand = RPSControlFactory.CreateRPSButtonToView<CPQModelActionView,ModelActionConditionEditorDialogView>("439ee386-07f5-437c-93f5-ae943be46901","","", this,Screen.ModelActionConditionEditorDialogView);
 
            Condition = RPSControlFactory.CreateRPSTextBox<CPQModelActionView>("875b0803-3cd7-4944-9ee2-56f25e66ea1b","","",false, this);
 
            Action = RPSControlFactory.CreateRPSEnumComboBox<CPQModelActionView>("d08dd405-82ab-4a32-877e-086057bb9ca9","","",true, this);
 
            CollectionInit params_CPQModelActionParams = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="4542d311-e2df-4bfa-ba9b-f41cc39524cc",CSSSelectorGrid="",XPathGrid=""};
            CPQModelActionParams = RPSControlFactory.RPSCreateCollectionWithGrid<CPQModelActionParamsCollectionEditor<CPQModelActionView,ModelActionConditionEditorDialogView>,CPQModelActionView,ModelActionConditionEditorDialogView>( params_CPQModelActionParams,this,Screen.ModelActionConditionEditorDialogView);
 
            CollectionInit params_ModelActionParamCollectionElements = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="4a14c923-7d8e-4896-8637-92d3b8989aca",CSSSelectorGrid="",XPathGrid=""};
            ModelActionParamCollectionElements = RPSControlFactory.RPSCreateCollectionWithGrid<ModelActionParamCollectionElementsCollectionEditor<CPQModelActionView,ModelActionConditionEditorDialogView>,CPQModelActionView,ModelActionConditionEditorDialogView>( params_ModelActionParamCollectionElements,this,Screen.ModelActionConditionEditorDialogView);
 

        }
        public IRPSButton<CPQModelActionView> DeleteButton { get; set; } 
        public IRPSButton<CPQModelActionView,CPQOptionGroupActionView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<CPQModelActionView,CPQOptionGroupActionView> BackButton { get; set; } 
        public IRPSAcceptButton<CPQModelActionView,CPQOptionGroupActionView> AcceptButton { get; set; } 
        public IRPSTextBox<CPQModelActionView> ExecutionOrder { get; set; } 
        public IRPSComboBox<CPQModelActionView> Event { get; set; } 
        public IRPSButton<CPQModelActionView,ModelActionConditionEditorDialogView> ModelActionConditionEditorNavigationCommand { get; set; } 
        public IRPSTextBox<CPQModelActionView> Condition { get; set; } 
        public IRPSComboBox<CPQModelActionView> Action { get; set; } 
        public CPQModelActionParamsCollectionEditor<CPQModelActionView,ModelActionConditionEditorDialogView> CPQModelActionParams { get; set; } 
        public ModelActionParamCollectionElementsCollectionEditor<CPQModelActionView,ModelActionConditionEditorDialogView> ModelActionParamCollectionElements { get; set; } 
        public CPQModel Screen { get; set; }
        public CPQModelActionView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class CPQModelActionParamsCollectionEditor<CPQModelActionView,ModelActionConditionEditorDialogView>:RPSCollectionEditor<CPQModelActionView,ModelActionConditionEditorDialogView> where CPQModelActionView : class, IView where ModelActionConditionEditorDialogView : class, IView
    {
        public  CPQModelActionParamsGridView<CPQModelActionView,ModelActionConditionEditorDialogView> GridView {get;set;}
    }
    public partial class CPQModelActionParamsGridView <CPQModelActionView,ModelActionConditionEditorDialogView> :  RPSGridView<CPQModelActionView,ModelActionConditionEditorDialogView> where CPQModelActionView : class, IView where ModelActionConditionEditorDialogView : class, IView
    {
        public CPQModelActionParamsGridView(CPQModelActionView currentView,ModelActionConditionEditorDialogView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            ParamName = RPSControlFactory.CreateRPSGridTextBox<CPQModelActionView>("","#4542d311-e2df-4bfa-ba9b-f41cc39524cc .ag-row[role='row']@ROWINDEX [col-id='cParamName']","",false, this.CurrentView);
 
            Type = RPSControlFactory.CreateRPSGridEnumComboBox<CPQModelActionView>("","#4542d311-e2df-4bfa-ba9b-f41cc39524cc .ag-row[role='row']@ROWINDEX [col-id='cType']","",true, this.CurrentView);
 
            Direction = RPSControlFactory.CreateRPSGridEnumComboBox<CPQModelActionView>("","#4542d311-e2df-4bfa-ba9b-f41cc39524cc .ag-row[role='row']@ROWINDEX [col-id='cDirection']","",true, this.CurrentView);
 
            IsRequired = RPSControlFactory.CreateRPSGridCheckBox<CPQModelActionView>("","#4542d311-e2df-4bfa-ba9b-f41cc39524cc .ag-row[role='row']@ROWINDEX [col-id='cIsRequired']","",true, this.CurrentView);
 
            Constant = RPSControlFactory.CreateRPSGridEnumComboBox<CPQModelActionView>("","#4542d311-e2df-4bfa-ba9b-f41cc39524cc .ag-row[role='row']@ROWINDEX [col-id='cConstant']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<CPQModelActionView> ParamName { get; set; } 
        public IRPSGridComboBox<CPQModelActionView> Type { get; set; } 
        public IRPSGridComboBox<CPQModelActionView> Direction { get; set; } 
        public IRPSGridCheckbox<CPQModelActionView> IsRequired { get; set; } 
        public IRPSGridComboBox<CPQModelActionView> Constant { get; set; } 
                     
    }
 
        public partial class ModelActionParamCollectionElementsCollectionEditor<CPQModelActionView,ModelActionConditionEditorDialogView>:RPSCollectionEditor<CPQModelActionView,ModelActionConditionEditorDialogView> where CPQModelActionView : class, IView where ModelActionConditionEditorDialogView : class, IView
    {
        public  ModelActionParamCollectionElementsGridView<CPQModelActionView,ModelActionConditionEditorDialogView> GridView {get;set;}
    }
    public partial class ModelActionParamCollectionElementsGridView <CPQModelActionView,ModelActionConditionEditorDialogView> :  RPSGridView<CPQModelActionView,ModelActionConditionEditorDialogView> where CPQModelActionView : class, IView where ModelActionConditionEditorDialogView : class, IView
    {
        public ModelActionParamCollectionElementsGridView(CPQModelActionView currentView,ModelActionConditionEditorDialogView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            PropertyCode = RPSControlFactory.CreateRPSGridTextBox<CPQModelActionView>("","#4a14c923-7d8e-4896-8637-92d3b8989aca .ag-row[role='row']@ROWINDEX [col-id='cPropertyCode']","",true, this.CurrentView);
 
            Value = RPSControlFactory.CreateRPSGridTextBox<CPQModelActionView>("","#4a14c923-7d8e-4896-8637-92d3b8989aca .ag-row[role='row']@ROWINDEX [col-id='cValue']","",false, this.CurrentView);
 
            Constant = RPSControlFactory.CreateRPSGridEnumComboBox<CPQModelActionView>("","#4a14c923-7d8e-4896-8637-92d3b8989aca .ag-row[role='row']@ROWINDEX [col-id='cConstant']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<CPQModelActionView> PropertyCode { get; set; } 
        public IRPSGridTextBox<CPQModelActionView> Value { get; set; } 
        public IRPSGridComboBox<CPQModelActionView> Constant { get; set; } 
                     
    }
 
    }
  
            
    public partial class CPQOptionGroupActionView : View
    {
        public CPQOptionGroupActionView(CPQModel screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            DeleteButton = RPSControlFactory.RPSDeleteButton<CPQOptionGroupActionView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<CPQOptionGroupActionView,CPQOptionGroupView>( this,Screen.CPQOptionGroupView);
 
            BackButton = RPSControlFactory.RPSBackButton<CPQOptionGroupActionView,CPQOptionGroupView>( this,Screen.CPQOptionGroupView);
 
            AcceptButton = RPSControlFactory.RPSAcceptButton<CPQOptionGroupActionView,CPQOptionGroupView>( this,Screen.CPQOptionGroupView);
 
            ExecutionOrder = RPSControlFactory.CreateRPSFormattedTextBox<CPQOptionGroupActionView>("a4e75747-f755-4b14-9ab2-37ccdb1b41c5","","",true, this);
 
            Event = RPSControlFactory.CreateRPSEnumComboBox<CPQOptionGroupActionView>("5daaabcd-9bf0-4593-9805-6132518da72b","","",true, this);
 
            OptionGroupActionConditionEditorNavigationCommand = RPSControlFactory.CreateRPSButtonToView<CPQOptionGroupActionView,OptionGroupActionFormulaEditorDialogView>("13402ea5-3906-48cf-9d8d-fce0d0b7d25a","","", this,Screen.OptionGroupActionFormulaEditorDialogView);
 
            Condition = RPSControlFactory.CreateRPSTextBox<CPQOptionGroupActionView>("8be38671-62ff-4f78-9d79-a7e5707b2661","","",false, this);
 
            Action = RPSControlFactory.CreateRPSEnumComboBox<CPQOptionGroupActionView>("1525e678-5b87-4a5f-ada1-79972e079aac","","",true, this);
 
            OptionGroupActionFormulaEditorNavigationCommand = RPSControlFactory.CreateRPSButtonToView<CPQOptionGroupActionView,OptionGroupActionFormulaEditorDialogView>("e1120a86-2cd5-4438-b731-fb110e5f2439","","", this,Screen.OptionGroupActionFormulaEditorDialogView);
 
            Formula = RPSControlFactory.CreateRPSTextBox<CPQOptionGroupActionView>("f3ee4d2d-ae2d-4e46-85d3-5de2d163f0e6","","",false, this);
 
            Parameter = RPSControlFactory.CreateRPSTextBox<CPQOptionGroupActionView>("cb0beeb1-9591-4ffc-8a06-5cccb65624bd","","",false, this);
 
            CollectionInit params_ParamActionDetail = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="f677f83c-ef57-4051-9083-98616c85d454",CSSSelectorGrid="",XPathGrid=""};
            ParamActionDetail = RPSControlFactory.RPSCreateCollectionWithGrid<ParamActionDetailCollectionEditor<CPQOptionGroupActionView,NewModelCreatorDialogView>,CPQOptionGroupActionView,NewModelCreatorDialogView>( params_ParamActionDetail,this,Screen.NewModelCreatorDialogView);
 
            CollectionInit params_MsgTextByLang = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="e9d93fa8-a315-4d8f-8324-2b1740ff85db",CSSSelectorGrid="",XPathGrid=""};
            MsgTextByLang = RPSControlFactory.RPSCreateCollectionWithGrid<MsgTextByLangCollectionEditor<CPQOptionGroupActionView,NewModelCreatorDialogView>,CPQOptionGroupActionView,NewModelCreatorDialogView>( params_MsgTextByLang,this,Screen.NewModelCreatorDialogView);
 

        }
        public IRPSButton<CPQOptionGroupActionView> DeleteButton { get; set; } 
        public IRPSButton<CPQOptionGroupActionView,CPQOptionGroupView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<CPQOptionGroupActionView,CPQOptionGroupView> BackButton { get; set; } 
        public IRPSAcceptButton<CPQOptionGroupActionView,CPQOptionGroupView> AcceptButton { get; set; } 
        public IRPSTextBox<CPQOptionGroupActionView> ExecutionOrder { get; set; } 
        public IRPSComboBox<CPQOptionGroupActionView> Event { get; set; } 
        public IRPSButton<CPQOptionGroupActionView,OptionGroupActionFormulaEditorDialogView> OptionGroupActionConditionEditorNavigationCommand { get; set; } 
        public IRPSTextBox<CPQOptionGroupActionView> Condition { get; set; } 
        public IRPSComboBox<CPQOptionGroupActionView> Action { get; set; } 
        public IRPSButton<CPQOptionGroupActionView,OptionGroupActionFormulaEditorDialogView> OptionGroupActionFormulaEditorNavigationCommand { get; set; } 
        public IRPSTextBox<CPQOptionGroupActionView> Formula { get; set; } 
        public IRPSTextBox<CPQOptionGroupActionView> Parameter { get; set; } 
        public ParamActionDetailCollectionEditor<CPQOptionGroupActionView,NewModelCreatorDialogView> ParamActionDetail { get; set; } 
        public MsgTextByLangCollectionEditor<CPQOptionGroupActionView,NewModelCreatorDialogView> MsgTextByLang { get; set; } 
        public CPQModel Screen { get; set; }
        public CPQOptionGroupActionView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class ParamActionDetailCollectionEditor<CPQOptionGroupActionView,NewModelCreatorDialogView>:RPSCollectionEditor<CPQOptionGroupActionView,NewModelCreatorDialogView> where CPQOptionGroupActionView : class, IView where NewModelCreatorDialogView : class, IView
    {
        public  ParamActionDetailGridView<CPQOptionGroupActionView,NewModelCreatorDialogView> GridView {get;set;}
    }
    public partial class ParamActionDetailGridView <CPQOptionGroupActionView,NewModelCreatorDialogView> :  RPSGridView<CPQOptionGroupActionView,NewModelCreatorDialogView> where CPQOptionGroupActionView : class, IView where NewModelCreatorDialogView : class, IView
    {
        public ParamActionDetailGridView(CPQOptionGroupActionView currentView,NewModelCreatorDialogView newView)
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
 
        public partial class MsgTextByLangCollectionEditor<CPQOptionGroupActionView,NewModelCreatorDialogView>:RPSCollectionEditor<CPQOptionGroupActionView,NewModelCreatorDialogView> where CPQOptionGroupActionView : class, IView where NewModelCreatorDialogView : class, IView
    {
        public  MsgTextByLangGridView<CPQOptionGroupActionView,NewModelCreatorDialogView> GridView {get;set;}
    }
    public partial class MsgTextByLangGridView <CPQOptionGroupActionView,NewModelCreatorDialogView> :  RPSGridView<CPQOptionGroupActionView,NewModelCreatorDialogView> where CPQOptionGroupActionView : class, IView where NewModelCreatorDialogView : class, IView
    {
        public MsgTextByLangGridView(CPQOptionGroupActionView currentView,NewModelCreatorDialogView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            CodLanguage = RPSControlFactory.CreateRPSGridComboBox<CPQOptionGroupActionView>("","#e9d93fa8-a315-4d8f-8324-2b1740ff85db .ag-row[role='row']@ROWINDEX [col-id='cCodLanguage']","",false, this.CurrentView);
 
            MsgText = RPSControlFactory.CreateRPSGridMemoTextBox<CPQOptionGroupActionView>("","#e9d93fa8-a315-4d8f-8324-2b1740ff85db .ag-row[role='row']@ROWINDEX [col-id='cMsgText']","",false, this.CurrentView);
 

        }
        public IRPSGridComboBox<CPQOptionGroupActionView> CodLanguage { get; set; } 
        public IRPSGridTextBox<CPQOptionGroupActionView> MsgText { get; set; } 
                     
    }
 
    }
  
            
    public partial class CPQModelVariableDataView : View
    {
        public CPQModelVariableDataView(CPQModel screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            DeleteButton = RPSControlFactory.RPSDeleteButton<CPQModelVariableDataView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<CPQModelVariableDataView,CPQOptionGroupActionView>( this,Screen.CPQOptionGroupActionView);
 
            BackButton = RPSControlFactory.RPSBackButton<CPQModelVariableDataView,CPQOptionGroupActionView>( this,Screen.CPQOptionGroupActionView);
 
            AcceptButton = RPSControlFactory.RPSAcceptButton<CPQModelVariableDataView,CPQOptionGroupActionView>( this,Screen.CPQOptionGroupActionView);
 
            IDCPQVariableDataLabel = RPSControlFactory.CreateRPSComboBox<CPQModelVariableDataView>("f257bf1f-67a1-41cc-beab-715b20af03ef","","",true, this);
 
            CollectionInit params_CPQModelVariableDataByLangs = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="f6888fea-abc3-4d72-a533-54feb9697bbb",CSSSelectorGrid="",XPathGrid=""};
            CPQModelVariableDataByLangs = RPSControlFactory.RPSCreateCollectionWithGrid<CPQModelVariableDataByLangsCollectionEditor<CPQModelVariableDataView>,CPQModelVariableDataView>( params_CPQModelVariableDataByLangs,this);
 

        }
        public IRPSButton<CPQModelVariableDataView> DeleteButton { get; set; } 
        public IRPSButton<CPQModelVariableDataView,CPQOptionGroupActionView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<CPQModelVariableDataView,CPQOptionGroupActionView> BackButton { get; set; } 
        public IRPSAcceptButton<CPQModelVariableDataView,CPQOptionGroupActionView> AcceptButton { get; set; } 
        public IRPSComboBox<CPQModelVariableDataView> IDCPQVariableDataLabel { get; set; } 
        public CPQModelVariableDataByLangsCollectionEditor<CPQModelVariableDataView> CPQModelVariableDataByLangs { get; set; } 
        public CPQModel Screen { get; set; }
        public CPQModelVariableDataView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class CPQModelVariableDataByLangsCollectionEditor<CPQModelVariableDataView>:RPSCollectionEditor<CPQModelVariableDataView> where CPQModelVariableDataView : class, IView
    {
        public  CPQModelVariableDataByLangsGridView<CPQModelVariableDataView> GridView {get;set;}
    }
    public partial class CPQModelVariableDataByLangsGridView <CPQModelVariableDataView> :  RPSGridView<CPQModelVariableDataView> where CPQModelVariableDataView : class, IView
    {
        public CPQModelVariableDataByLangsGridView(CPQModelVariableDataView currentView)
        {
            this.WebDriver = currentView.WebDriver;          
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            CodLanguage = RPSControlFactory.CreateRPSGridComboBox<CPQModelVariableDataView>("","#f6888fea-abc3-4d72-a533-54feb9697bbb .ag-row[role='row']@ROWINDEX [col-id='cCodLanguage']","",true, this.CurrentView);
 

        }
        public IRPSGridComboBox<CPQModelVariableDataView> CodLanguage { get; set; } 
                     
    }
 
    }
  
            
    public partial class CPQOptionVariableDataView : View
    {
        public CPQOptionVariableDataView(CPQModel screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            DeleteButton = RPSControlFactory.RPSDeleteButton<CPQOptionVariableDataView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<CPQOptionVariableDataView,CPQOptionView>( this,Screen.CPQOptionView);
 
            BackButton = RPSControlFactory.RPSBackButton<CPQOptionVariableDataView,CPQOptionView>( this,Screen.CPQOptionView);
 
            AcceptButton = RPSControlFactory.RPSAcceptButton<CPQOptionVariableDataView,CPQOptionView>( this,Screen.CPQOptionView);
 
            IDCPQVariableDataLabel = RPSControlFactory.CreateRPSComboBox<CPQOptionVariableDataView>("d1ad424c-0eb1-4324-9b64-015bcd6fab49","","",true, this);
 
            CollectionInit params_CPQOptionVariableDataByLangs = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="70a6568e-5999-4fbb-bd7a-24e1305b1f8a",CSSSelectorGrid="",XPathGrid=""};
            CPQOptionVariableDataByLangs = RPSControlFactory.RPSCreateCollectionWithGrid<CPQOptionVariableDataByLangsCollectionEditor<CPQOptionVariableDataView>,CPQOptionVariableDataView>( params_CPQOptionVariableDataByLangs,this);
 

        }
        public IRPSButton<CPQOptionVariableDataView> DeleteButton { get; set; } 
        public IRPSButton<CPQOptionVariableDataView,CPQOptionView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<CPQOptionVariableDataView,CPQOptionView> BackButton { get; set; } 
        public IRPSAcceptButton<CPQOptionVariableDataView,CPQOptionView> AcceptButton { get; set; } 
        public IRPSComboBox<CPQOptionVariableDataView> IDCPQVariableDataLabel { get; set; } 
        public CPQOptionVariableDataByLangsCollectionEditor<CPQOptionVariableDataView> CPQOptionVariableDataByLangs { get; set; } 
        public CPQModel Screen { get; set; }
        public CPQOptionVariableDataView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class CPQOptionVariableDataByLangsCollectionEditor<CPQOptionVariableDataView>:RPSCollectionEditor<CPQOptionVariableDataView> where CPQOptionVariableDataView : class, IView
    {
        public  CPQOptionVariableDataByLangsGridView<CPQOptionVariableDataView> GridView {get;set;}
    }
    public partial class CPQOptionVariableDataByLangsGridView <CPQOptionVariableDataView> :  RPSGridView<CPQOptionVariableDataView> where CPQOptionVariableDataView : class, IView
    {
        public CPQOptionVariableDataByLangsGridView(CPQOptionVariableDataView currentView)
        {
            this.WebDriver = currentView.WebDriver;          
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            CodLanguage = RPSControlFactory.CreateRPSGridComboBox<CPQOptionVariableDataView>("","#70a6568e-5999-4fbb-bd7a-24e1305b1f8a .ag-row[role='row']@ROWINDEX [col-id='cCodLanguage']","",true, this.CurrentView);
 

        }
        public IRPSGridComboBox<CPQOptionVariableDataView> CodLanguage { get; set; } 
                     
    }
 
    }
  
            
    public partial class AddToCompositionExistingDocumentDialogView : View
    {
        public AddToCompositionExistingDocumentDialogView(CPQModel screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            IDDocument = RPSControlFactory.CreateRPSCollectionComboBox<AddToCompositionExistingDocumentDialogView>("423e9d45-eb0c-4ce6-b346-db90089dea4c","","",false, this);
 

        }
        public IRPSCollectionComboBox<AddToCompositionExistingDocumentDialogView> IDDocument { get; set; } 
        public CPQModel Screen { get; set; }
        public AddToCompositionExistingDocumentDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class AddToCompositionReportDialogView : View
    {
        public AddToCompositionReportDialogView(CPQModel screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            IDCustomReport = RPSControlFactory.CreateRPSCollectionComboBox<AddToCompositionReportDialogView>("0a183eef-c830-42a0-93c5-610f67253876","","",false, this);
 

        }
        public IRPSCollectionComboBox<AddToCompositionReportDialogView> IDCustomReport { get; set; } 
        public CPQModel Screen { get; set; }
        public AddToCompositionReportDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class ModelActionConditionEditorDialogView : View
    {
        public ModelActionConditionEditorDialogView(CPQModel screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            AddVariableData = RPSControlFactory.CreateRPSButton<ModelActionConditionEditorDialogView>( "8a4882bf-5971-4f22-ac64-aa08261cd6bf","","",this);
 
            AddDynamicValueCommand = RPSControlFactory.CreateRPSButton<ModelActionConditionEditorDialogView>( "a87cc016-a403-4c68-a19d-a7e4a1f4a696","","",this);
 
            FinalExpression = RPSControlFactory.CreateRPSTextBox<ModelActionConditionEditorDialogView>("ef9a0388-1cdb-47e3-85b4-3aa3207092ad","","",false, this);
 
            Constant = RPSControlFactory.CreateRPSEnumComboBox<ModelActionConditionEditorDialogView>("1ac88439-7011-47e2-b9cc-63141e36a1c4","","",false, this);
 
            AddConstant = RPSControlFactory.CreateRPSButton<ModelActionConditionEditorDialogView>( "87ab8e6b-6166-4d9a-ba9b-a770400e2bc1","","",this);
 
            Function = RPSControlFactory.CreateRPSEnumComboBox<ModelActionConditionEditorDialogView>("d45ef4f3-2e8a-42cf-a966-e4fbafa2116e","","",false, this);
 
            AddFunction = RPSControlFactory.CreateRPSButton<ModelActionConditionEditorDialogView>( "2557b49f-6a47-4242-b4c4-206fca82f36c","","",this);
 
            Method = RPSControlFactory.CreateRPSEnumComboBox<ModelActionConditionEditorDialogView>("897bd899-d1d0-43ff-87f7-0158e3ae4637","","",false, this);
 
            AddMethod = RPSControlFactory.CreateRPSButton<ModelActionConditionEditorDialogView>( "7d560e9c-1d11-42f1-9d14-d900f529034b","","",this);
 
            PlusCommand = RPSControlFactory.CreateRPSButton<ModelActionConditionEditorDialogView>( "82b9fc2d-dfb3-4562-a267-476f31e30a75","","",this);
 
            MinusCommand = RPSControlFactory.CreateRPSButton<ModelActionConditionEditorDialogView>( "aeca3694-c513-4932-8461-43e06478df56","","",this);
 
            TimesCommand = RPSControlFactory.CreateRPSButton<ModelActionConditionEditorDialogView>( "9f908e66-eb5b-4119-bd42-fafc920a23ff","","",this);
 
            DividedCommand = RPSControlFactory.CreateRPSButton<ModelActionConditionEditorDialogView>( "e8ce7dd0-2b29-4111-bb21-3149c94acf5f","","",this);
 
            LeftParenthesisCommand = RPSControlFactory.CreateRPSButton<ModelActionConditionEditorDialogView>( "127e7a98-e037-4717-86fc-effe053cd691","","",this);
 
            RightParenthesisCommand = RPSControlFactory.CreateRPSButton<ModelActionConditionEditorDialogView>( "8422bbba-b3ed-4ac6-b26d-12bdf4abe1cb","","",this);
 
            EqualsCommand = RPSControlFactory.CreateRPSButton<ModelActionConditionEditorDialogView>( "19fb0443-254a-43d9-aaba-10424d8d18d2","","",this);
 
            DifferentCommand = RPSControlFactory.CreateRPSButton<ModelActionConditionEditorDialogView>( "dcc575c2-4e13-447e-bb9e-8af671fceac2","","",this);
 
            LessCommand = RPSControlFactory.CreateRPSButton<ModelActionConditionEditorDialogView>( "9ac73a71-6591-4d19-b7e4-cb80882820a0","","",this);
 
            LessThanOrEqualCommand = RPSControlFactory.CreateRPSButton<ModelActionConditionEditorDialogView>( "23488c7b-cadf-428f-9347-ce48c8fd46eb","","",this);
 
            GreaterCommand = RPSControlFactory.CreateRPSButton<ModelActionConditionEditorDialogView>( "b84ffab7-6a37-4dc6-873b-4fc0833e63e4","","",this);
 
            GreaterThanOrEqualCommand = RPSControlFactory.CreateRPSButton<ModelActionConditionEditorDialogView>( "9ca6bbb5-ccaa-4a3a-a598-0a16d1a8a9f0","","",this);
 
            AndCommand = RPSControlFactory.CreateRPSButton<ModelActionConditionEditorDialogView>( "c07277b9-027b-4e07-bdc6-895273bce07a","","",this);
 
            OrCommand = RPSControlFactory.CreateRPSButton<ModelActionConditionEditorDialogView>( "faf86e04-d4da-4d95-ab94-f2aae4abf970","","",this);
 
            OKCommandButton = RPSControlFactory.CreateRPSButton<ModelActionConditionEditorDialogView>( "1363e6e9-de9a-4c48-bb3f-dfa0c36caca9","","",this);
 
            CancelCommandButton = RPSControlFactory.CreateRPSButton<ModelActionConditionEditorDialogView>( "9dabf664-8c73-45d9-b9fe-8468c0e20f2b","","",this);
 
            ValidateFinalExpressionCommandButton = RPSControlFactory.CreateRPSButton<ModelActionConditionEditorDialogView>( "e5243d7e-86ac-4995-a694-e1ff7dea4a52","","",this);
 
            CleanFinalExpressionCommandButton = RPSControlFactory.CreateRPSButton<ModelActionConditionEditorDialogView>( "f5a83816-b04d-42bb-8986-71bdfe3d3d66","","",this);
 
            SelectOptionButton = RPSControlFactory.CreateRPSButton<ModelActionConditionEditorDialogView>( "cca3beda-1c74-420e-92a5-e8b60c1370ce","","",this);
 
            NotSelectOptionButton = RPSControlFactory.CreateRPSButton<ModelActionConditionEditorDialogView>( "b53cb357-e8ba-404d-bab4-3ba9b400b2df","","",this);
 
            QuantityButton = RPSControlFactory.CreateRPSButton<ModelActionConditionEditorDialogView>( "98f1b1ff-439b-42a9-abf8-9c31f4fd4cff","","",this);
 
            PriceButton = RPSControlFactory.CreateRPSButton<ModelActionConditionEditorDialogView>( "fa71a260-3eb2-47f2-bcfe-909cb6a0235f","","",this);
 

        }
        public IRPSButton<ModelActionConditionEditorDialogView> AddVariableData { get; set; } 
        public IRPSButton<ModelActionConditionEditorDialogView> AddDynamicValueCommand { get; set; } 
        public IRPSTextBox<ModelActionConditionEditorDialogView> FinalExpression { get; set; } 
        public IRPSComboBox<ModelActionConditionEditorDialogView> Constant { get; set; } 
        public IRPSButton<ModelActionConditionEditorDialogView> AddConstant { get; set; } 
        public IRPSComboBox<ModelActionConditionEditorDialogView> Function { get; set; } 
        public IRPSButton<ModelActionConditionEditorDialogView> AddFunction { get; set; } 
        public IRPSComboBox<ModelActionConditionEditorDialogView> Method { get; set; } 
        public IRPSButton<ModelActionConditionEditorDialogView> AddMethod { get; set; } 
        public IRPSButton<ModelActionConditionEditorDialogView> PlusCommand { get; set; } 
        public IRPSButton<ModelActionConditionEditorDialogView> MinusCommand { get; set; } 
        public IRPSButton<ModelActionConditionEditorDialogView> TimesCommand { get; set; } 
        public IRPSButton<ModelActionConditionEditorDialogView> DividedCommand { get; set; } 
        public IRPSButton<ModelActionConditionEditorDialogView> LeftParenthesisCommand { get; set; } 
        public IRPSButton<ModelActionConditionEditorDialogView> RightParenthesisCommand { get; set; } 
        public IRPSButton<ModelActionConditionEditorDialogView> EqualsCommand { get; set; } 
        public IRPSButton<ModelActionConditionEditorDialogView> DifferentCommand { get; set; } 
        public IRPSButton<ModelActionConditionEditorDialogView> LessCommand { get; set; } 
        public IRPSButton<ModelActionConditionEditorDialogView> LessThanOrEqualCommand { get; set; } 
        public IRPSButton<ModelActionConditionEditorDialogView> GreaterCommand { get; set; } 
        public IRPSButton<ModelActionConditionEditorDialogView> GreaterThanOrEqualCommand { get; set; } 
        public IRPSButton<ModelActionConditionEditorDialogView> AndCommand { get; set; } 
        public IRPSButton<ModelActionConditionEditorDialogView> OrCommand { get; set; } 
        public IRPSButton<ModelActionConditionEditorDialogView> OKCommandButton { get; set; } 
        public IRPSButton<ModelActionConditionEditorDialogView> CancelCommandButton { get; set; } 
        public IRPSButton<ModelActionConditionEditorDialogView> ValidateFinalExpressionCommandButton { get; set; } 
        public IRPSButton<ModelActionConditionEditorDialogView> CleanFinalExpressionCommandButton { get; set; } 
        public IRPSButton<ModelActionConditionEditorDialogView> SelectOptionButton { get; set; } 
        public IRPSButton<ModelActionConditionEditorDialogView> NotSelectOptionButton { get; set; } 
        public IRPSButton<ModelActionConditionEditorDialogView> QuantityButton { get; set; } 
        public IRPSButton<ModelActionConditionEditorDialogView> PriceButton { get; set; } 
        public CPQModel Screen { get; set; }
        public ModelActionConditionEditorDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class OptionGroupActionFormulaEditorDialogView : View
    {
        public OptionGroupActionFormulaEditorDialogView(CPQModel screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            AddVariableData = RPSControlFactory.CreateRPSButton<OptionGroupActionFormulaEditorDialogView>( "29a0164f-8446-45a1-9ab4-34a60710b018","","",this);
 
            AddDynamicValueCommand = RPSControlFactory.CreateRPSButton<OptionGroupActionFormulaEditorDialogView>( "19245d63-88e8-4f48-bd4a-89f22c674fe6","","",this);
 
            FinalExpression = RPSControlFactory.CreateRPSTextBox<OptionGroupActionFormulaEditorDialogView>("d7a3f297-2d71-4fcf-8715-d6b4e42a6507","","",false, this);
 
            Constant = RPSControlFactory.CreateRPSEnumComboBox<OptionGroupActionFormulaEditorDialogView>("3e9cd0d9-e21f-40b0-8b47-aba96e4b4b8c","","",false, this);
 
            AddConstant = RPSControlFactory.CreateRPSButton<OptionGroupActionFormulaEditorDialogView>( "84178e42-bd3f-40f1-ad7c-2f3c8bee5d0c","","",this);
 
            Function = RPSControlFactory.CreateRPSEnumComboBox<OptionGroupActionFormulaEditorDialogView>("78dcbcd5-ee4e-406a-a909-f33f3fa52c9d","","",false, this);
 
            AddFunction = RPSControlFactory.CreateRPSButton<OptionGroupActionFormulaEditorDialogView>( "bb4843f1-36c5-4cde-b338-335fdc407561","","",this);
 
            Method = RPSControlFactory.CreateRPSEnumComboBox<OptionGroupActionFormulaEditorDialogView>("7126e057-1d6a-495b-8417-1b2a697f06aa","","",false, this);
 
            AddMethod = RPSControlFactory.CreateRPSButton<OptionGroupActionFormulaEditorDialogView>( "574f1dba-2105-4166-a336-70414266bcde","","",this);
 
            AssignmentCommand = RPSControlFactory.CreateRPSButton<OptionGroupActionFormulaEditorDialogView>( "a44cb1cb-8b8a-444e-a79a-5eaf87898b8a","","",this);
 
            PlusCommand = RPSControlFactory.CreateRPSButton<OptionGroupActionFormulaEditorDialogView>( "832281e8-032f-4bd6-8f4c-ffc5dd39585e","","",this);
 
            MinusCommand = RPSControlFactory.CreateRPSButton<OptionGroupActionFormulaEditorDialogView>( "69d8ef68-72b7-4851-9bfa-5e617869c9d7","","",this);
 
            TimesCommand = RPSControlFactory.CreateRPSButton<OptionGroupActionFormulaEditorDialogView>( "e60cf1e9-125e-434f-a17b-454c32038c4e","","",this);
 
            DividedCommand = RPSControlFactory.CreateRPSButton<OptionGroupActionFormulaEditorDialogView>( "2b8236aa-952f-44ec-af32-a65d8c0943fe","","",this);
 
            LeftParenthesisCommand = RPSControlFactory.CreateRPSButton<OptionGroupActionFormulaEditorDialogView>( "9e7306fe-9a20-4437-8c0d-c0258528b55f","","",this);
 
            RightParenthesisCommand = RPSControlFactory.CreateRPSButton<OptionGroupActionFormulaEditorDialogView>( "531efd8a-6976-4149-9766-0370f8bfde06","","",this);
 
            EqualsCommand = RPSControlFactory.CreateRPSButton<OptionGroupActionFormulaEditorDialogView>( "df3c4dae-cdbb-4772-a1ff-6221bbe925f8","","",this);
 
            DifferentCommand = RPSControlFactory.CreateRPSButton<OptionGroupActionFormulaEditorDialogView>( "5bdb2092-5952-41f2-909d-3d8346a06853","","",this);
 
            LessCommand = RPSControlFactory.CreateRPSButton<OptionGroupActionFormulaEditorDialogView>( "90708d12-5513-4be7-8f55-e0cbe7bb2070","","",this);
 
            LessThanOrEqualCommand = RPSControlFactory.CreateRPSButton<OptionGroupActionFormulaEditorDialogView>( "cd1b5b8a-0ed4-4356-abe2-ec7b638d0c68","","",this);
 
            GreaterCommand = RPSControlFactory.CreateRPSButton<OptionGroupActionFormulaEditorDialogView>( "22ac8087-1bf4-449a-99cf-cbce92769424","","",this);
 
            GreaterThanOrEqualCommand = RPSControlFactory.CreateRPSButton<OptionGroupActionFormulaEditorDialogView>( "bf7d3671-1a2c-426d-8fc6-a033afc54a9d","","",this);
 
            AndCommand = RPSControlFactory.CreateRPSButton<OptionGroupActionFormulaEditorDialogView>( "43b27d1e-e530-445c-80b0-e87517d2bbd0","","",this);
 
            OrCommand = RPSControlFactory.CreateRPSButton<OptionGroupActionFormulaEditorDialogView>( "2a9442fa-6e45-480f-b57d-82922351d693","","",this);
 
            OKCommandButton = RPSControlFactory.CreateRPSButton<OptionGroupActionFormulaEditorDialogView>( "70f53af1-9282-47ac-847b-2ce79a203d0f","","",this);
 
            CancelCommandButton = RPSControlFactory.CreateRPSButton<OptionGroupActionFormulaEditorDialogView>( "5b959409-4deb-4555-acce-8198bd262c92","","",this);
 
            ValidateFinalExpressionCommandButton = RPSControlFactory.CreateRPSButton<OptionGroupActionFormulaEditorDialogView>( "c2c3016c-a1e1-40e8-8adc-04df35ddf372","","",this);
 
            CleanFinalExpressionCommandButton = RPSControlFactory.CreateRPSButton<OptionGroupActionFormulaEditorDialogView>( "985fd6c2-18e5-4773-a802-3358e40bb2af","","",this);
 
            SelectOptionButton = RPSControlFactory.CreateRPSButton<OptionGroupActionFormulaEditorDialogView>( "e7c66b8b-90f4-4a7b-a671-215b661902a2","","",this);
 
            NotSelectOptionButton = RPSControlFactory.CreateRPSButton<OptionGroupActionFormulaEditorDialogView>( "aab67877-a51a-4d56-96da-bb98ee101e06","","",this);
 
            QuantityButton = RPSControlFactory.CreateRPSButton<OptionGroupActionFormulaEditorDialogView>( "2f4f5ad1-8569-427d-9dfe-1f1ce7090560","","",this);
 
            PriceButton = RPSControlFactory.CreateRPSButton<OptionGroupActionFormulaEditorDialogView>( "a0baf61c-641a-4194-9fb2-9b10c06fef79","","",this);
 

        }
        public IRPSButton<OptionGroupActionFormulaEditorDialogView> AddVariableData { get; set; } 
        public IRPSButton<OptionGroupActionFormulaEditorDialogView> AddDynamicValueCommand { get; set; } 
        public IRPSTextBox<OptionGroupActionFormulaEditorDialogView> FinalExpression { get; set; } 
        public IRPSComboBox<OptionGroupActionFormulaEditorDialogView> Constant { get; set; } 
        public IRPSButton<OptionGroupActionFormulaEditorDialogView> AddConstant { get; set; } 
        public IRPSComboBox<OptionGroupActionFormulaEditorDialogView> Function { get; set; } 
        public IRPSButton<OptionGroupActionFormulaEditorDialogView> AddFunction { get; set; } 
        public IRPSComboBox<OptionGroupActionFormulaEditorDialogView> Method { get; set; } 
        public IRPSButton<OptionGroupActionFormulaEditorDialogView> AddMethod { get; set; } 
        public IRPSButton<OptionGroupActionFormulaEditorDialogView> AssignmentCommand { get; set; } 
        public IRPSButton<OptionGroupActionFormulaEditorDialogView> PlusCommand { get; set; } 
        public IRPSButton<OptionGroupActionFormulaEditorDialogView> MinusCommand { get; set; } 
        public IRPSButton<OptionGroupActionFormulaEditorDialogView> TimesCommand { get; set; } 
        public IRPSButton<OptionGroupActionFormulaEditorDialogView> DividedCommand { get; set; } 
        public IRPSButton<OptionGroupActionFormulaEditorDialogView> LeftParenthesisCommand { get; set; } 
        public IRPSButton<OptionGroupActionFormulaEditorDialogView> RightParenthesisCommand { get; set; } 
        public IRPSButton<OptionGroupActionFormulaEditorDialogView> EqualsCommand { get; set; } 
        public IRPSButton<OptionGroupActionFormulaEditorDialogView> DifferentCommand { get; set; } 
        public IRPSButton<OptionGroupActionFormulaEditorDialogView> LessCommand { get; set; } 
        public IRPSButton<OptionGroupActionFormulaEditorDialogView> LessThanOrEqualCommand { get; set; } 
        public IRPSButton<OptionGroupActionFormulaEditorDialogView> GreaterCommand { get; set; } 
        public IRPSButton<OptionGroupActionFormulaEditorDialogView> GreaterThanOrEqualCommand { get; set; } 
        public IRPSButton<OptionGroupActionFormulaEditorDialogView> AndCommand { get; set; } 
        public IRPSButton<OptionGroupActionFormulaEditorDialogView> OrCommand { get; set; } 
        public IRPSButton<OptionGroupActionFormulaEditorDialogView> OKCommandButton { get; set; } 
        public IRPSButton<OptionGroupActionFormulaEditorDialogView> CancelCommandButton { get; set; } 
        public IRPSButton<OptionGroupActionFormulaEditorDialogView> ValidateFinalExpressionCommandButton { get; set; } 
        public IRPSButton<OptionGroupActionFormulaEditorDialogView> CleanFinalExpressionCommandButton { get; set; } 
        public IRPSButton<OptionGroupActionFormulaEditorDialogView> SelectOptionButton { get; set; } 
        public IRPSButton<OptionGroupActionFormulaEditorDialogView> NotSelectOptionButton { get; set; } 
        public IRPSButton<OptionGroupActionFormulaEditorDialogView> QuantityButton { get; set; } 
        public IRPSButton<OptionGroupActionFormulaEditorDialogView> PriceButton { get; set; } 
        public CPQModel Screen { get; set; }
        public OptionGroupActionFormulaEditorDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class OptionArticleFormulaEditorDialogView : View
    {
        public OptionArticleFormulaEditorDialogView(CPQModel screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            AddVariableData = RPSControlFactory.CreateRPSButton<OptionArticleFormulaEditorDialogView>( "33e9f136-e52f-4025-a7f8-b757707dad3b","","",this);
 
            AddDynamicValueCommand = RPSControlFactory.CreateRPSButton<OptionArticleFormulaEditorDialogView>( "6d74a8f9-9325-4777-acba-48883aeb3415","","",this);
 
            FinalExpression = RPSControlFactory.CreateRPSTextBox<OptionArticleFormulaEditorDialogView>("7d6eab6c-c273-4a28-ba12-da5f4b8fe1e8","","",false, this);
 
            Constant = RPSControlFactory.CreateRPSEnumComboBox<OptionArticleFormulaEditorDialogView>("6ae59a4d-ebfc-4ef2-9a99-61b27a81601f","","",false, this);
 
            AddConstant = RPSControlFactory.CreateRPSButton<OptionArticleFormulaEditorDialogView>( "9bc38764-1d2c-44c2-83e9-afdf202a4d50","","",this);
 
            Function = RPSControlFactory.CreateRPSEnumComboBox<OptionArticleFormulaEditorDialogView>("6f737a2e-3471-4ead-8a7d-43757b708082","","",false, this);
 
            AddFunction = RPSControlFactory.CreateRPSButton<OptionArticleFormulaEditorDialogView>( "877e5f6f-4e16-4c94-b7eb-0ef67631f03c","","",this);
 
            Method = RPSControlFactory.CreateRPSEnumComboBox<OptionArticleFormulaEditorDialogView>("c1933654-d47f-41c9-a638-9df246912c68","","",false, this);
 
            AddMethod = RPSControlFactory.CreateRPSButton<OptionArticleFormulaEditorDialogView>( "09bc1c7f-642a-4fb1-b5e0-609b74362806","","",this);
 
            PlusCommand = RPSControlFactory.CreateRPSButton<OptionArticleFormulaEditorDialogView>( "b185c2be-bacb-4e1e-912e-b2472882be3d","","",this);
 
            MinusCommand = RPSControlFactory.CreateRPSButton<OptionArticleFormulaEditorDialogView>( "9986f36e-414f-4b3f-9bbb-285fb08438ee","","",this);
 
            TimesCommand = RPSControlFactory.CreateRPSButton<OptionArticleFormulaEditorDialogView>( "35dd4494-40c5-4d78-ba52-9e68d7cae1ae","","",this);
 
            DividedCommand = RPSControlFactory.CreateRPSButton<OptionArticleFormulaEditorDialogView>( "52736ccb-c861-45ba-bcb7-77cc64839bb0","","",this);
 
            LeftParenthesisCommand = RPSControlFactory.CreateRPSButton<OptionArticleFormulaEditorDialogView>( "65b416d7-7843-451f-b544-bf2b9fa31d01","","",this);
 
            RightParenthesisCommand = RPSControlFactory.CreateRPSButton<OptionArticleFormulaEditorDialogView>( "e3b9ffdd-68df-4d4c-9228-a69d1f88fc21","","",this);
 
            EqualsCommand = RPSControlFactory.CreateRPSButton<OptionArticleFormulaEditorDialogView>( "6b6ce847-cc9e-4911-9c5d-77cb754425e8","","",this);
 
            DifferentCommand = RPSControlFactory.CreateRPSButton<OptionArticleFormulaEditorDialogView>( "38901fd0-40d7-4d1d-8307-dceb410d2910","","",this);
 
            LessCommand = RPSControlFactory.CreateRPSButton<OptionArticleFormulaEditorDialogView>( "b883c67f-ebfe-447b-959c-1b306412eb25","","",this);
 
            LessThanOrEqualCommand = RPSControlFactory.CreateRPSButton<OptionArticleFormulaEditorDialogView>( "b09da009-0d24-4eaa-b13e-6b2198a6bd81","","",this);
 
            GreaterCommand = RPSControlFactory.CreateRPSButton<OptionArticleFormulaEditorDialogView>( "fd49c172-9006-40d4-b18c-f346666656a4","","",this);
 
            GreaterThanOrEqualCommand = RPSControlFactory.CreateRPSButton<OptionArticleFormulaEditorDialogView>( "93ba5faa-5fa6-4466-9079-8d462de0d576","","",this);
 
            AndCommand = RPSControlFactory.CreateRPSButton<OptionArticleFormulaEditorDialogView>( "c60cf71e-bca9-415e-b6c0-b0e791a8b808","","",this);
 
            OrCommand = RPSControlFactory.CreateRPSButton<OptionArticleFormulaEditorDialogView>( "4a7b5013-4ef3-4d09-a2ff-288e217610ef","","",this);
 
            OKCommandButton = RPSControlFactory.CreateRPSButton<OptionArticleFormulaEditorDialogView>( "0561a8c6-5336-487b-8f25-02efafe907b9","","",this);
 
            CancelCommandButton = RPSControlFactory.CreateRPSButton<OptionArticleFormulaEditorDialogView>( "70441142-ccdf-4353-8a01-6b7e6116b6fc","","",this);
 
            ValidateFinalExpressionCommandButton = RPSControlFactory.CreateRPSButton<OptionArticleFormulaEditorDialogView>( "f28da99a-2de7-4198-bb05-b0ac6dc8d61c","","",this);
 
            CleanFinalExpressionCommandButton = RPSControlFactory.CreateRPSButton<OptionArticleFormulaEditorDialogView>( "8f5df71b-d265-435d-97db-6c2120f8e0f4","","",this);
 
            SelectOptionButton = RPSControlFactory.CreateRPSButton<OptionArticleFormulaEditorDialogView>( "c03fb22d-1574-414a-ad8f-7000e371c58d","","",this);
 
            NotSelectOptionButton = RPSControlFactory.CreateRPSButton<OptionArticleFormulaEditorDialogView>( "4396245a-1a70-4655-b9e9-c5aa1f68d8db","","",this);
 
            QuantityButton = RPSControlFactory.CreateRPSButton<OptionArticleFormulaEditorDialogView>( "33a86c50-fe2a-4956-809a-f1c5cf323561","","",this);
 
            PriceButton = RPSControlFactory.CreateRPSButton<OptionArticleFormulaEditorDialogView>( "0e08e6a2-36c9-4eca-b0cb-5a769e72950a","","",this);
 

        }
        public IRPSButton<OptionArticleFormulaEditorDialogView> AddVariableData { get; set; } 
        public IRPSButton<OptionArticleFormulaEditorDialogView> AddDynamicValueCommand { get; set; } 
        public IRPSTextBox<OptionArticleFormulaEditorDialogView> FinalExpression { get; set; } 
        public IRPSComboBox<OptionArticleFormulaEditorDialogView> Constant { get; set; } 
        public IRPSButton<OptionArticleFormulaEditorDialogView> AddConstant { get; set; } 
        public IRPSComboBox<OptionArticleFormulaEditorDialogView> Function { get; set; } 
        public IRPSButton<OptionArticleFormulaEditorDialogView> AddFunction { get; set; } 
        public IRPSComboBox<OptionArticleFormulaEditorDialogView> Method { get; set; } 
        public IRPSButton<OptionArticleFormulaEditorDialogView> AddMethod { get; set; } 
        public IRPSButton<OptionArticleFormulaEditorDialogView> PlusCommand { get; set; } 
        public IRPSButton<OptionArticleFormulaEditorDialogView> MinusCommand { get; set; } 
        public IRPSButton<OptionArticleFormulaEditorDialogView> TimesCommand { get; set; } 
        public IRPSButton<OptionArticleFormulaEditorDialogView> DividedCommand { get; set; } 
        public IRPSButton<OptionArticleFormulaEditorDialogView> LeftParenthesisCommand { get; set; } 
        public IRPSButton<OptionArticleFormulaEditorDialogView> RightParenthesisCommand { get; set; } 
        public IRPSButton<OptionArticleFormulaEditorDialogView> EqualsCommand { get; set; } 
        public IRPSButton<OptionArticleFormulaEditorDialogView> DifferentCommand { get; set; } 
        public IRPSButton<OptionArticleFormulaEditorDialogView> LessCommand { get; set; } 
        public IRPSButton<OptionArticleFormulaEditorDialogView> LessThanOrEqualCommand { get; set; } 
        public IRPSButton<OptionArticleFormulaEditorDialogView> GreaterCommand { get; set; } 
        public IRPSButton<OptionArticleFormulaEditorDialogView> GreaterThanOrEqualCommand { get; set; } 
        public IRPSButton<OptionArticleFormulaEditorDialogView> AndCommand { get; set; } 
        public IRPSButton<OptionArticleFormulaEditorDialogView> OrCommand { get; set; } 
        public IRPSButton<OptionArticleFormulaEditorDialogView> OKCommandButton { get; set; } 
        public IRPSButton<OptionArticleFormulaEditorDialogView> CancelCommandButton { get; set; } 
        public IRPSButton<OptionArticleFormulaEditorDialogView> ValidateFinalExpressionCommandButton { get; set; } 
        public IRPSButton<OptionArticleFormulaEditorDialogView> CleanFinalExpressionCommandButton { get; set; } 
        public IRPSButton<OptionArticleFormulaEditorDialogView> SelectOptionButton { get; set; } 
        public IRPSButton<OptionArticleFormulaEditorDialogView> NotSelectOptionButton { get; set; } 
        public IRPSButton<OptionArticleFormulaEditorDialogView> QuantityButton { get; set; } 
        public IRPSButton<OptionArticleFormulaEditorDialogView> PriceButton { get; set; } 
        public CPQModel Screen { get; set; }
        public OptionArticleFormulaEditorDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class CPQOptionArticleView : View
    {
        public CPQOptionArticleView(CPQModel screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            DeleteButton = RPSControlFactory.RPSDeleteButton<CPQOptionArticleView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<CPQOptionArticleView,CPQOptionView>( this,Screen.CPQOptionView);
 
            BackButton = RPSControlFactory.RPSBackButton<CPQOptionArticleView,CPQOptionView>( this,Screen.CPQOptionView);
 
            AcceptButton = RPSControlFactory.RPSAcceptButton<CPQOptionArticleView,CPQOptionView>( this,Screen.CPQOptionView);
 
            IDArticle = RPSControlFactory.CreateRPSComboBox<CPQOptionArticleView>("fa471b2d-56dd-479c-a805-ce2c8caeb6d3","","",true, this);
 
            QuantityFixed = RPSControlFactory.CreateRPSFormattedTextBox<CPQOptionArticleView>("0ba3e8c0-1083-42d0-a5a4-a849921214af","","",true, this);
 
            OptionArticleFormulaEditorNavigationCommand = RPSControlFactory.CreateRPSButtonToView<CPQOptionArticleView,OptionArticleFormulaEditorDialogView>("eadf60f6-8101-464b-8604-fca5295c6e8a","","", this,Screen.OptionArticleFormulaEditorDialogView);
 
            QuantityFormula = RPSControlFactory.CreateRPSTextBox<CPQOptionArticleView>("8c0d5a3c-a8a6-4c38-b3d1-9d39fb1f9e7f","","",false, this);
 

        }
        public IRPSButton<CPQOptionArticleView> DeleteButton { get; set; } 
        public IRPSButton<CPQOptionArticleView,CPQOptionView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<CPQOptionArticleView,CPQOptionView> BackButton { get; set; } 
        public IRPSAcceptButton<CPQOptionArticleView,CPQOptionView> AcceptButton { get; set; } 
        public IRPSComboBox<CPQOptionArticleView> IDArticle { get; set; } 
        public IRPSTextBox<CPQOptionArticleView> QuantityFixed { get; set; } 
        public IRPSButton<CPQOptionArticleView,OptionArticleFormulaEditorDialogView> OptionArticleFormulaEditorNavigationCommand { get; set; } 
        public IRPSTextBox<CPQOptionArticleView> QuantityFormula { get; set; } 
        public CPQModel Screen { get; set; }
        public CPQOptionArticleView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class ImportCPQOptionGroupDialogView : View
    {
        public ImportCPQOptionGroupDialogView(CPQModel screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            IDCPQModelSource = RPSControlFactory.CreateRPSComboBox<ImportCPQOptionGroupDialogView>("640bc6c3-315a-49c5-8bd5-ab56ba2612fe","","",true, this);
 
            IDCPQOptionGroup = RPSControlFactory.CreateRPSComboBox<ImportCPQOptionGroupDialogView>("d10cf940-626e-4abf-b3b1-33b660196984","","",true, this);
 
            NewCodOptionGroup = RPSControlFactory.CreateRPSTextBox<ImportCPQOptionGroupDialogView>("e63c4de3-eb96-4e4f-9afd-facdc43ae59c","","",true, this);
 
            NewOptionGroupDescription = RPSControlFactory.CreateRPSTextBox<ImportCPQOptionGroupDialogView>("6eacc081-416a-4fd6-9d42-7f82c594e876","","",true, this);
 

        }
        public IRPSComboBox<ImportCPQOptionGroupDialogView> IDCPQModelSource { get; set; } 
        public IRPSComboBox<ImportCPQOptionGroupDialogView> IDCPQOptionGroup { get; set; } 
        public IRPSTextBox<ImportCPQOptionGroupDialogView> NewCodOptionGroup { get; set; } 
        public IRPSTextBox<ImportCPQOptionGroupDialogView> NewOptionGroupDescription { get; set; } 
        public CPQModel Screen { get; set; }
        public ImportCPQOptionGroupDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}