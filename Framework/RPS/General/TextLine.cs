    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.General.TextLine
{
    //RPS VERSION 1.0.0.0
    public partial class TextLine:Screen
    {
        public TextLine():base()
        {
            this.URL = "general.textline";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            TextLineCollectionView  = new TextLineCollectionView(this); 
            TextLineEntityView  = new TextLineEntityView(this); 
            TextLineByLangView  = new TextLineByLangView(this); 
            TextLineCollectionView.InitializeControls(); 
            TextLineEntityView.InitializeControls(); 
            TextLineByLangView.InitializeControls(); 
           
        }
      
            public TextLineCollectionView TextLineCollectionView {get; set; } 
            public TextLineEntityView TextLineEntityView {get; set; } 
            public TextLineByLangView TextLineByLangView {get; set; } 
    }
            
    public partial class TextLineCollectionView : View
    {
        public TextLineCollectionView(TextLine screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            NewButton = RPSControlFactory.RPSNewButton<TextLineCollectionView,TextLineEntityView>( this,Screen.TextLineEntityView);
 
            CollectionInit params_MainConsult = new CollectionInit(){IDDescriptor = "df5ebec6-e7ea-4118-ae2e-2a848cd19456",CSSSelectorDescriptor = "",XPathDescriptor = ""};
            MainConsult = RPSControlFactory.RPSCreateCollection<TextLineCollectionView,TextLineEntityView>( params_MainConsult,this,Screen.TextLineEntityView);
 

        }
        public IRPSButton<TextLineCollectionView,TextLineEntityView> NewButton { get; set; } 
        public IRPSCollectionEditor<TextLineCollectionView,TextLineEntityView> MainConsult { get; set; } 
        public TextLine Screen { get; set; }
        public TextLineCollectionView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class TextLineEntityView : View
    {
        public TextLineEntityView(TextLine screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            SaveButton = RPSControlFactory.RPSSaveButton<TextLineEntityView>( this);
 
            DeleteButton = RPSControlFactory.RPSDeleteButton<TextLineEntityView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<TextLineEntityView,TextLineCollectionView>( this,Screen.TextLineCollectionView);
 
            BackButton = RPSControlFactory.RPSBackButton<TextLineEntityView,TextLineCollectionView>( this,Screen.TextLineCollectionView);
 
            CodTextLine = RPSControlFactory.CreateRPSTextBox<TextLineEntityView>("e3d3cd80-6485-4496-9721-d0b6d69750d3","","",true, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<TextLineEntityView>("cef64745-f207-4f21-8893-54483bc30e61","","",false, this);
 
            Type = RPSControlFactory.CreateRPSEnumComboBox<TextLineEntityView>("bdcfe24b-6ae6-447d-b645-02bb4f058a92","","",true, this);
 
            CollectionInit params_TextLineByLangs = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="6628a8f9-34e4-44f4-a682-fc72a43a64ed",CSSSelectorGrid="",XPathGrid=""};
            TextLineByLangs = RPSControlFactory.RPSCreateCollectionWithGrid<TextLineByLangsCollectionEditor<TextLineEntityView,TextLineByLangView>,TextLineEntityView,TextLineByLangView>( params_TextLineByLangs,this,Screen.TextLineByLangView);
 

        }
        public IRPSSaveButton<TextLineEntityView> SaveButton { get; set; } 
        public IRPSButton<TextLineEntityView> DeleteButton { get; set; } 
        public IRPSButton<TextLineEntityView,TextLineCollectionView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<TextLineEntityView,TextLineCollectionView> BackButton { get; set; } 
        public IRPSTextBox<TextLineEntityView> CodTextLine { get; set; } 
        public IRPSTextBox<TextLineEntityView> Description { get; set; } 
        public IRPSComboBox<TextLineEntityView> Type { get; set; } 
        public TextLineByLangsCollectionEditor<TextLineEntityView,TextLineByLangView> TextLineByLangs { get; set; } 
        public TextLine Screen { get; set; }
        public TextLineEntityView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class TextLineByLangsCollectionEditor<TextLineEntityView,TextLineByLangView>:RPSCollectionEditor<TextLineEntityView,TextLineByLangView> where TextLineEntityView : class, IView where TextLineByLangView : class, IView
    {
        public  TextLineByLangsGridView<TextLineEntityView,TextLineByLangView> GridView {get;set;}
    }
    public partial class TextLineByLangsGridView <TextLineEntityView,TextLineByLangView> :  RPSGridView<TextLineEntityView,TextLineByLangView> where TextLineEntityView : class, IView where TextLineByLangView : class, IView
    {
        public TextLineByLangsGridView(TextLineEntityView currentView,TextLineByLangView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            CodLanguage = RPSControlFactory.CreateRPSGridComboBox<TextLineEntityView>("","#6628a8f9-34e4-44f4-a682-fc72a43a64ed .ag-row[role='row']@ROWINDEX [col-id='cCodLanguage']","",true, this.CurrentView);
 
            Text = RPSControlFactory.CreateRPSGridMemoTextBox<TextLineEntityView>("","#6628a8f9-34e4-44f4-a682-fc72a43a64ed .ag-row[role='row']@ROWINDEX [col-id='cText']","",true, this.CurrentView);
 

        }
        public IRPSGridComboBox<TextLineEntityView> CodLanguage { get; set; } 
        public IRPSGridTextBox<TextLineEntityView> Text { get; set; } 
                     
    }
 
    }
  
            
    public partial class TextLineByLangView : View
    {
        public TextLineByLangView(TextLine screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            DeleteButton = RPSControlFactory.RPSDeleteButton<TextLineByLangView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<TextLineByLangView,TextLineEntityView>( this,Screen.TextLineEntityView);
 
            BackButton = RPSControlFactory.RPSBackButton<TextLineByLangView,TextLineEntityView>( this,Screen.TextLineEntityView);
 
            AcceptButton = RPSControlFactory.RPSAcceptButton<TextLineByLangView,TextLineEntityView>( this,Screen.TextLineEntityView);
 
            CodLanguage = RPSControlFactory.CreateRPSComboBox<TextLineByLangView>("3758aa3b-3830-4b75-a3ee-559ec687d1e9","","",true, this);
 
            Text = RPSControlFactory.CreateRPSTextBox<TextLineByLangView>("21a4fdfd-3a1e-401e-b195-b690a9a8c0b1","","",true, this);
 

        }
        public IRPSButton<TextLineByLangView> DeleteButton { get; set; } 
        public IRPSButton<TextLineByLangView,TextLineEntityView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<TextLineByLangView,TextLineEntityView> BackButton { get; set; } 
        public IRPSAcceptButton<TextLineByLangView,TextLineEntityView> AcceptButton { get; set; } 
        public IRPSComboBox<TextLineByLangView> CodLanguage { get; set; } 
        public IRPSTextBox<TextLineByLangView> Text { get; set; } 
        public TextLine Screen { get; set; }
        public TextLineByLangView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}