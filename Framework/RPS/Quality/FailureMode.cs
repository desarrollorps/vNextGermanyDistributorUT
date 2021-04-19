    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.Quality.FailureMode
{
    //RPS VERSION 1.0.0.0
    public partial class FailureMode:Screen
    {
        public FailureMode():base()
        {
            this.URL = "quality.failuremode";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            FailureModeCollectionView  = new FailureModeCollectionView(this); 
            FailureModeEntityView  = new FailureModeEntityView(this); 
            FailureModeByLangView  = new FailureModeByLangView(this); 
            FailureModeCollectionView.InitializeControls(); 
            FailureModeEntityView.InitializeControls(); 
            FailureModeByLangView.InitializeControls(); 
           
        }
      
            public FailureModeCollectionView FailureModeCollectionView {get; set; } 
            public FailureModeEntityView FailureModeEntityView {get; set; } 
            public FailureModeByLangView FailureModeByLangView {get; set; } 
    }
            
    public partial class FailureModeCollectionView : View
    {
        public FailureModeCollectionView(FailureMode screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            NewButton = RPSControlFactory.RPSNewButton<FailureModeCollectionView,FailureModeEntityView>( this,Screen.FailureModeEntityView);
 
            CollectionInit params_MainConsult = new CollectionInit(){IDDescriptor = "04e6aa66-0a1b-42e3-9b33-73e4248323a3",CSSSelectorDescriptor = "",XPathDescriptor = ""};
            MainConsult = RPSControlFactory.RPSCreateCollection<FailureModeCollectionView,FailureModeEntityView>( params_MainConsult,this,Screen.FailureModeEntityView);
 

        }
        public IRPSButton<FailureModeCollectionView,FailureModeEntityView> NewButton { get; set; } 
        public IRPSCollectionEditor<FailureModeCollectionView,FailureModeEntityView> MainConsult { get; set; } 
        public FailureMode Screen { get; set; }
        public FailureModeCollectionView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class FailureModeEntityView : View
    {
        public FailureModeEntityView(FailureMode screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            SaveButton = RPSControlFactory.RPSSaveButton<FailureModeEntityView>( this);
 
            DeleteButton = RPSControlFactory.RPSDeleteButton<FailureModeEntityView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<FailureModeEntityView,FailureModeCollectionView>( this,Screen.FailureModeCollectionView);
 
            BackButton = RPSControlFactory.RPSBackButton<FailureModeEntityView,FailureModeCollectionView>( this,Screen.FailureModeCollectionView);
 
            CodFailureMode = RPSControlFactory.CreateRPSTextBox<FailureModeEntityView>("f6676b32-cb3c-4b0d-adf5-749613df21bc","","",true, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<FailureModeEntityView>("cd6f8c06-892f-4e2f-8b4d-935ec05aa2e5","","",false, this);
 
            CollectionInit params_FailureModeByLangs = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="aa682890-49a7-4b50-ba6b-f008fa8d5e51",CSSSelectorGrid="",XPathGrid=""};
            FailureModeByLangs = RPSControlFactory.RPSCreateCollectionWithGrid<FailureModeByLangsCollectionEditor<FailureModeEntityView,FailureModeByLangView>,FailureModeEntityView,FailureModeByLangView>( params_FailureModeByLangs,this,Screen.FailureModeByLangView);
 

        }
        public IRPSSaveButton<FailureModeEntityView> SaveButton { get; set; } 
        public IRPSButton<FailureModeEntityView> DeleteButton { get; set; } 
        public IRPSButton<FailureModeEntityView,FailureModeCollectionView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<FailureModeEntityView,FailureModeCollectionView> BackButton { get; set; } 
        public IRPSTextBox<FailureModeEntityView> CodFailureMode { get; set; } 
        public IRPSTextBox<FailureModeEntityView> Description { get; set; } 
        public FailureModeByLangsCollectionEditor<FailureModeEntityView,FailureModeByLangView> FailureModeByLangs { get; set; } 
        public FailureMode Screen { get; set; }
        public FailureModeEntityView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class FailureModeByLangsCollectionEditor<FailureModeEntityView,FailureModeByLangView>:RPSCollectionEditor<FailureModeEntityView,FailureModeByLangView> where FailureModeEntityView : class, IView where FailureModeByLangView : class, IView
    {
        public  FailureModeByLangsGridView<FailureModeEntityView,FailureModeByLangView> GridView {get;set;}
    }
    public partial class FailureModeByLangsGridView <FailureModeEntityView,FailureModeByLangView> :  RPSGridView<FailureModeEntityView,FailureModeByLangView> where FailureModeEntityView : class, IView where FailureModeByLangView : class, IView
    {
        public FailureModeByLangsGridView(FailureModeEntityView currentView,FailureModeByLangView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            CodLanguage = RPSControlFactory.CreateRPSGridComboBox<FailureModeEntityView>("","#aa682890-49a7-4b50-ba6b-f008fa8d5e51 .ag-row[role='row']@ROWINDEX [col-id='cCodLanguage']","",true, this.CurrentView);
 
            Description = RPSControlFactory.CreateRPSGridTextBox<FailureModeEntityView>("","#aa682890-49a7-4b50-ba6b-f008fa8d5e51 .ag-row[role='row']@ROWINDEX [col-id='cDescription']","",false, this.CurrentView);
 

        }
        public IRPSGridComboBox<FailureModeEntityView> CodLanguage { get; set; } 
        public IRPSGridTextBox<FailureModeEntityView> Description { get; set; } 
                     
    }
 
    }
  
            
    public partial class FailureModeByLangView : View
    {
        public FailureModeByLangView(FailureMode screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            DeleteButton = RPSControlFactory.RPSDeleteButton<FailureModeByLangView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<FailureModeByLangView,FailureModeEntityView>( this,Screen.FailureModeEntityView);
 
            BackButton = RPSControlFactory.RPSBackButton<FailureModeByLangView,FailureModeEntityView>( this,Screen.FailureModeEntityView);
 
            AcceptButton = RPSControlFactory.RPSAcceptButton<FailureModeByLangView,FailureModeEntityView>( this,Screen.FailureModeEntityView);
 
            CodLanguage = RPSControlFactory.CreateRPSComboBox<FailureModeByLangView>("25a92f81-933c-4754-beaa-8ea0edab857a","","",true, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<FailureModeByLangView>("0095f85a-d946-4b31-8877-4f511ea2bbbb","","",false, this);
 

        }
        public IRPSButton<FailureModeByLangView> DeleteButton { get; set; } 
        public IRPSButton<FailureModeByLangView,FailureModeEntityView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<FailureModeByLangView,FailureModeEntityView> BackButton { get; set; } 
        public IRPSAcceptButton<FailureModeByLangView,FailureModeEntityView> AcceptButton { get; set; } 
        public IRPSComboBox<FailureModeByLangView> CodLanguage { get; set; } 
        public IRPSTextBox<FailureModeByLangView> Description { get; set; } 
        public FailureMode Screen { get; set; }
        public FailureModeByLangView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}