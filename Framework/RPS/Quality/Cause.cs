    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.Quality.Cause
{
    //RPS VERSION 1.0.0.0
    public partial class Cause:Screen
    {
        public Cause():base()
        {
            this.URL = "quality.cause";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            CauseCollectionView  = new CauseCollectionView(this); 
            CauseEntityView  = new CauseEntityView(this); 
            CauseByLangView  = new CauseByLangView(this); 
            CauseCollectionView.InitializeControls(); 
            CauseEntityView.InitializeControls(); 
            CauseByLangView.InitializeControls(); 
           
        }
      
            public CauseCollectionView CauseCollectionView {get; set; } 
            public CauseEntityView CauseEntityView {get; set; } 
            public CauseByLangView CauseByLangView {get; set; } 
    }
            
    public partial class CauseCollectionView : View
    {
        public CauseCollectionView(Cause screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            NewButton = RPSControlFactory.RPSNewButton<CauseCollectionView,CauseEntityView>( this,Screen.CauseEntityView);
 
            CollectionInit params_MainConsult = new CollectionInit(){IDDescriptor = "fe52ad59-3757-4777-b862-4ed13fc1093a",CSSSelectorDescriptor = "",XPathDescriptor = ""};
            MainConsult = RPSControlFactory.RPSCreateCollection<CauseCollectionView,CauseEntityView>( params_MainConsult,this,Screen.CauseEntityView);
 

        }
        public IRPSButton<CauseCollectionView,CauseEntityView> NewButton { get; set; } 
        public IRPSCollectionEditor<CauseCollectionView,CauseEntityView> MainConsult { get; set; } 
        public Cause Screen { get; set; }
        public CauseCollectionView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class CauseEntityView : View
    {
        public CauseEntityView(Cause screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            SaveButton = RPSControlFactory.RPSSaveButton<CauseEntityView>( this);
 
            DeleteButton = RPSControlFactory.RPSDeleteButton<CauseEntityView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<CauseEntityView,CauseCollectionView>( this,Screen.CauseCollectionView);
 
            BackButton = RPSControlFactory.RPSBackButton<CauseEntityView,CauseCollectionView>( this,Screen.CauseCollectionView);
 
            CodCause = RPSControlFactory.CreateRPSTextBox<CauseEntityView>("71da7496-528b-457a-918d-62df5af37fb4","","",true, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<CauseEntityView>("76a5ba89-ac20-4b4e-83fd-01b402e3bd2f","","",false, this);
 
            CollectionInit params_CauseByLangs = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="a775e2e2-64bc-46d9-8d1a-eef65c9ef17b",CSSSelectorGrid="",XPathGrid=""};
            CauseByLangs = RPSControlFactory.RPSCreateCollectionWithGrid<CauseByLangsCollectionEditor<CauseEntityView,CauseByLangView>,CauseEntityView,CauseByLangView>( params_CauseByLangs,this,Screen.CauseByLangView);
 

        }
        public IRPSSaveButton<CauseEntityView> SaveButton { get; set; } 
        public IRPSButton<CauseEntityView> DeleteButton { get; set; } 
        public IRPSButton<CauseEntityView,CauseCollectionView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<CauseEntityView,CauseCollectionView> BackButton { get; set; } 
        public IRPSTextBox<CauseEntityView> CodCause { get; set; } 
        public IRPSTextBox<CauseEntityView> Description { get; set; } 
        public CauseByLangsCollectionEditor<CauseEntityView,CauseByLangView> CauseByLangs { get; set; } 
        public Cause Screen { get; set; }
        public CauseEntityView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class CauseByLangsCollectionEditor<CauseEntityView,CauseByLangView>:RPSCollectionEditor<CauseEntityView,CauseByLangView> where CauseEntityView : class, IView where CauseByLangView : class, IView
    {
        public  CauseByLangsGridView<CauseEntityView,CauseByLangView> GridView {get;set;}
    }
    public partial class CauseByLangsGridView <CauseEntityView,CauseByLangView> :  RPSGridView<CauseEntityView,CauseByLangView> where CauseEntityView : class, IView where CauseByLangView : class, IView
    {
        public CauseByLangsGridView(CauseEntityView currentView,CauseByLangView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            CodLanguage = RPSControlFactory.CreateRPSGridComboBox<CauseEntityView>("","#a775e2e2-64bc-46d9-8d1a-eef65c9ef17b .ag-row[role='row']@ROWINDEX [col-id='cCodLanguage']","",true, this.CurrentView);
 
            Description = RPSControlFactory.CreateRPSGridTextBox<CauseEntityView>("","#a775e2e2-64bc-46d9-8d1a-eef65c9ef17b .ag-row[role='row']@ROWINDEX [col-id='cDescription']","",false, this.CurrentView);
 

        }
        public IRPSGridComboBox<CauseEntityView> CodLanguage { get; set; } 
        public IRPSGridTextBox<CauseEntityView> Description { get; set; } 
                     
    }
 
    }
  
            
    public partial class CauseByLangView : View
    {
        public CauseByLangView(Cause screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            DeleteButton = RPSControlFactory.RPSDeleteButton<CauseByLangView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<CauseByLangView,CauseEntityView>( this,Screen.CauseEntityView);
 
            BackButton = RPSControlFactory.RPSBackButton<CauseByLangView,CauseEntityView>( this,Screen.CauseEntityView);
 
            AcceptButton = RPSControlFactory.RPSAcceptButton<CauseByLangView,CauseEntityView>( this,Screen.CauseEntityView);
 
            CodLanguage = RPSControlFactory.CreateRPSComboBox<CauseByLangView>("cc6a9db2-863f-49e3-a000-80bf8bb1a03c","","",true, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<CauseByLangView>("09469669-f439-4666-8350-005a8ecbe1d6","","",false, this);
 

        }
        public IRPSButton<CauseByLangView> DeleteButton { get; set; } 
        public IRPSButton<CauseByLangView,CauseEntityView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<CauseByLangView,CauseEntityView> BackButton { get; set; } 
        public IRPSAcceptButton<CauseByLangView,CauseEntityView> AcceptButton { get; set; } 
        public IRPSComboBox<CauseByLangView> CodLanguage { get; set; } 
        public IRPSTextBox<CauseByLangView> Description { get; set; } 
        public Cause Screen { get; set; }
        public CauseByLangView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}