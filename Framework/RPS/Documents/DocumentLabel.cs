    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.Documents.DocumentLabel
{
    //RPS VERSION 1.0.0.0
    public partial class DocumentLabel:Screen
    {
        public DocumentLabel():base()
        {
            this.URL = "documents.documentlabel";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            DocumentLabelCollectionView  = new DocumentLabelCollectionView(this); 
            DocumentLabelEntityView  = new DocumentLabelEntityView(this); 
            DocumentLabelByLangView  = new DocumentLabelByLangView(this); 
            DocumentLabelCollectionView.InitializeControls(); 
            DocumentLabelEntityView.InitializeControls(); 
            DocumentLabelByLangView.InitializeControls(); 
           
        }
      
            public DocumentLabelCollectionView DocumentLabelCollectionView {get; set; } 
            public DocumentLabelEntityView DocumentLabelEntityView {get; set; } 
            public DocumentLabelByLangView DocumentLabelByLangView {get; set; } 
    }
            
    public partial class DocumentLabelCollectionView : View
    {
        public DocumentLabelCollectionView(DocumentLabel screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            NewButton = RPSControlFactory.RPSNewButton<DocumentLabelCollectionView,DocumentLabelEntityView>( this,Screen.DocumentLabelEntityView);
 
            CollectionInit params_MainConsult = new CollectionInit(){IDDescriptor = "b45813d0-5f17-41a9-afc8-338b88601ac5",CSSSelectorDescriptor = "",XPathDescriptor = ""};
            MainConsult = RPSControlFactory.RPSCreateCollection<DocumentLabelCollectionView,DocumentLabelEntityView>( params_MainConsult,this,Screen.DocumentLabelEntityView);
 

        }
        public IRPSButton<DocumentLabelCollectionView,DocumentLabelEntityView> NewButton { get; set; } 
        public IRPSCollectionEditor<DocumentLabelCollectionView,DocumentLabelEntityView> MainConsult { get; set; } 
        public DocumentLabel Screen { get; set; }
        public DocumentLabelCollectionView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class DocumentLabelEntityView : View
    {
        public DocumentLabelEntityView(DocumentLabel screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            SaveButton = RPSControlFactory.RPSSaveButton<DocumentLabelEntityView>( this);
 
            DeleteButton = RPSControlFactory.RPSDeleteButton<DocumentLabelEntityView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<DocumentLabelEntityView,DocumentLabelCollectionView>( this,Screen.DocumentLabelCollectionView);
 
            BackButton = RPSControlFactory.RPSBackButton<DocumentLabelEntityView,DocumentLabelCollectionView>( this,Screen.DocumentLabelCollectionView);
 
            CodDocumentLabel = RPSControlFactory.CreateRPSTextBox<DocumentLabelEntityView>("edbd5d88-2b01-4eb1-9230-fdf94d8001fd","","",true, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<DocumentLabelEntityView>("cc75d368-164e-4476-87ac-e0a26706bcf7","","",false, this);
 
            DataType = RPSControlFactory.CreateRPSEnumComboBox<DocumentLabelEntityView>("e57241be-8fd8-411e-9ca2-4ad36be9bb20","","",true, this);
 
            IDDocumentVariableTable = RPSControlFactory.CreateRPSComboBox<DocumentLabelEntityView>("22c2c053-bc60-4b59-9389-1177256dff5a","","",false, this);
 
            PropertyLinkName = RPSControlFactory.CreateRPSTextBox<DocumentLabelEntityView>("ff4b7ea2-599f-40b3-a08e-ea0993bd46ed","","",false, this);
 
            MinInteger = RPSControlFactory.CreateRPSFormattedTextBox<DocumentLabelEntityView>("5696408e-69f1-4fba-a20f-24179bc2e017","","",false, this);
 
            MaxInteger = RPSControlFactory.CreateRPSFormattedTextBox<DocumentLabelEntityView>("020ba39a-3a4b-4839-a0d7-d33f1e3272f5","","",false, this);
 
            DefaultInteger = RPSControlFactory.CreateRPSFormattedTextBox<DocumentLabelEntityView>("62589fb7-5a29-429c-a277-9e983fff2eb0","","",false, this);
 
            MinString = RPSControlFactory.CreateRPSTextBox<DocumentLabelEntityView>("81262509-001c-4b42-83e0-4a4bea62ef54","","",false, this);
 
            MaxString = RPSControlFactory.CreateRPSTextBox<DocumentLabelEntityView>("f8a46eec-f405-48ed-a7f4-6d88a956a86e","","",false, this);
 
            DefaultString = RPSControlFactory.CreateRPSTextBox<DocumentLabelEntityView>("add087c2-c06d-42a4-a71b-f08ebf61cf6d","","",false, this);
 
            MinDecimal = RPSControlFactory.CreateRPSFormattedTextBox<DocumentLabelEntityView>("82a28185-3bdd-4357-999c-8645d7d460ae","","",false, this);
 
            MaxDecimal = RPSControlFactory.CreateRPSFormattedTextBox<DocumentLabelEntityView>("df7b53da-87c2-4d3e-a46f-04f961136f47","","",false, this);
 
            DefaultDecimal = RPSControlFactory.CreateRPSFormattedTextBox<DocumentLabelEntityView>("78b2918e-8395-487e-af4f-59e111d41ab2","","",false, this);
 
            MinDate = RPSControlFactory.CreateRPSTextBox<DocumentLabelEntityView>("96762dad-31cf-49aa-b820-5be7db396341","","",false, this);
 
            MaxDate = RPSControlFactory.CreateRPSTextBox<DocumentLabelEntityView>("251c61b9-996d-40bf-8b53-3630450d9910","","",false, this);
 
            DefaultDate = RPSControlFactory.CreateRPSTextBox<DocumentLabelEntityView>("1fa5fd50-662b-49cb-8411-bb3618bec774","","",false, this);
 
            MinString1 = RPSControlFactory.CreateRPSTextBox<DocumentLabelEntityView>("60d73677-bee4-4f55-aa64-d53afd2e8cd4","","",false, this);
 
            MaxString1 = RPSControlFactory.CreateRPSTextBox<DocumentLabelEntityView>("c32c03ee-6577-4fc2-ab65-541603b5d364","","",false, this);
 
            DefaultString1 = RPSControlFactory.CreateRPSTextBox<DocumentLabelEntityView>("04f1f8a9-09d2-4f07-81d3-49be4229d094","","",false, this);
 
            MinString2 = RPSControlFactory.CreateRPSTextBox<DocumentLabelEntityView>("b0c511fb-066f-4fd3-a982-7ca7ad45eed3","","",false, this);
 
            MaxString2 = RPSControlFactory.CreateRPSTextBox<DocumentLabelEntityView>("dbce866f-c0de-4d73-abeb-5b172673e21d","","",false, this);
 
            DefaultString2 = RPSControlFactory.CreateRPSTextBox<DocumentLabelEntityView>("9bc3480c-9eb8-4fbf-8b44-41d6a0181f8f","","",false, this);
 
            CollectionInit params_DocumentLabelByLangs = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="d56ca9a7-41c6-4951-8705-7d29fbf6d570",CSSSelectorGrid="",XPathGrid=""};
            DocumentLabelByLangs = RPSControlFactory.RPSCreateCollectionWithGrid<DocumentLabelByLangsCollectionEditor<DocumentLabelEntityView,DocumentLabelByLangView>,DocumentLabelEntityView,DocumentLabelByLangView>( params_DocumentLabelByLangs,this,Screen.DocumentLabelByLangView);
 

        }
        public IRPSSaveButton<DocumentLabelEntityView> SaveButton { get; set; } 
        public IRPSButton<DocumentLabelEntityView> DeleteButton { get; set; } 
        public IRPSButton<DocumentLabelEntityView,DocumentLabelCollectionView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<DocumentLabelEntityView,DocumentLabelCollectionView> BackButton { get; set; } 
        public IRPSTextBox<DocumentLabelEntityView> CodDocumentLabel { get; set; } 
        public IRPSTextBox<DocumentLabelEntityView> Description { get; set; } 
        public IRPSComboBox<DocumentLabelEntityView> DataType { get; set; } 
        public IRPSComboBox<DocumentLabelEntityView> IDDocumentVariableTable { get; set; } 
        public IRPSTextBox<DocumentLabelEntityView> PropertyLinkName { get; set; } 
        public IRPSTextBox<DocumentLabelEntityView> MinInteger { get; set; } 
        public IRPSTextBox<DocumentLabelEntityView> MaxInteger { get; set; } 
        public IRPSTextBox<DocumentLabelEntityView> DefaultInteger { get; set; } 
        public IRPSTextBox<DocumentLabelEntityView> MinString { get; set; } 
        public IRPSTextBox<DocumentLabelEntityView> MaxString { get; set; } 
        public IRPSTextBox<DocumentLabelEntityView> DefaultString { get; set; } 
        public IRPSTextBox<DocumentLabelEntityView> MinDecimal { get; set; } 
        public IRPSTextBox<DocumentLabelEntityView> MaxDecimal { get; set; } 
        public IRPSTextBox<DocumentLabelEntityView> DefaultDecimal { get; set; } 
        public IRPSTextBox<DocumentLabelEntityView> MinDate { get; set; } 
        public IRPSTextBox<DocumentLabelEntityView> MaxDate { get; set; } 
        public IRPSTextBox<DocumentLabelEntityView> DefaultDate { get; set; } 
        public IRPSTextBox<DocumentLabelEntityView> MinString1 { get; set; } 
        public IRPSTextBox<DocumentLabelEntityView> MaxString1 { get; set; } 
        public IRPSTextBox<DocumentLabelEntityView> DefaultString1 { get; set; } 
        public IRPSTextBox<DocumentLabelEntityView> MinString2 { get; set; } 
        public IRPSTextBox<DocumentLabelEntityView> MaxString2 { get; set; } 
        public IRPSTextBox<DocumentLabelEntityView> DefaultString2 { get; set; } 
        public DocumentLabelByLangsCollectionEditor<DocumentLabelEntityView,DocumentLabelByLangView> DocumentLabelByLangs { get; set; } 
        public DocumentLabel Screen { get; set; }
        public DocumentLabelEntityView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class DocumentLabelByLangsCollectionEditor<DocumentLabelEntityView,DocumentLabelByLangView>:RPSCollectionEditor<DocumentLabelEntityView,DocumentLabelByLangView> where DocumentLabelEntityView : class, IView where DocumentLabelByLangView : class, IView
    {
        public  DocumentLabelByLangsGridView<DocumentLabelEntityView,DocumentLabelByLangView> GridView {get;set;}
    }
    public partial class DocumentLabelByLangsGridView <DocumentLabelEntityView,DocumentLabelByLangView> :  RPSGridView<DocumentLabelEntityView,DocumentLabelByLangView> where DocumentLabelEntityView : class, IView where DocumentLabelByLangView : class, IView
    {
        public DocumentLabelByLangsGridView(DocumentLabelEntityView currentView,DocumentLabelByLangView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            CodLanguage = RPSControlFactory.CreateRPSGridComboBox<DocumentLabelEntityView>("","#d56ca9a7-41c6-4951-8705-7d29fbf6d570 .ag-row[role='row']@ROWINDEX [col-id='cCodLanguage']","",true, this.CurrentView);
 
            Description = RPSControlFactory.CreateRPSGridTextBox<DocumentLabelEntityView>("","#d56ca9a7-41c6-4951-8705-7d29fbf6d570 .ag-row[role='row']@ROWINDEX [col-id='cDescription']","",false, this.CurrentView);
 

        }
        public IRPSGridComboBox<DocumentLabelEntityView> CodLanguage { get; set; } 
        public IRPSGridTextBox<DocumentLabelEntityView> Description { get; set; } 
                     
    }
 
    }
  
            
    public partial class DocumentLabelByLangView : View
    {
        public DocumentLabelByLangView(DocumentLabel screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            DeleteButton = RPSControlFactory.RPSDeleteButton<DocumentLabelByLangView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<DocumentLabelByLangView,DocumentLabelEntityView>( this,Screen.DocumentLabelEntityView);
 
            BackButton = RPSControlFactory.RPSBackButton<DocumentLabelByLangView,DocumentLabelEntityView>( this,Screen.DocumentLabelEntityView);
 
            AcceptButton = RPSControlFactory.RPSAcceptButton<DocumentLabelByLangView,DocumentLabelEntityView>( this,Screen.DocumentLabelEntityView);
 
            CodLanguage = RPSControlFactory.CreateRPSComboBox<DocumentLabelByLangView>("135930fa-1ef0-448a-852f-b2e546d6be1a","","",true, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<DocumentLabelByLangView>("1f57db0d-0b79-4b0f-b118-b73244c260b3","","",false, this);
 

        }
        public IRPSButton<DocumentLabelByLangView> DeleteButton { get; set; } 
        public IRPSButton<DocumentLabelByLangView,DocumentLabelEntityView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<DocumentLabelByLangView,DocumentLabelEntityView> BackButton { get; set; } 
        public IRPSAcceptButton<DocumentLabelByLangView,DocumentLabelEntityView> AcceptButton { get; set; } 
        public IRPSComboBox<DocumentLabelByLangView> CodLanguage { get; set; } 
        public IRPSTextBox<DocumentLabelByLangView> Description { get; set; } 
        public DocumentLabel Screen { get; set; }
        public DocumentLabelByLangView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}