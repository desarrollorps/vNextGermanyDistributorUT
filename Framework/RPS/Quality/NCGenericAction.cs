    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.Quality.NCGenericAction
{
    //RPS VERSION 1.0.0.0
    public partial class NCGenericAction:Screen
    {
        public NCGenericAction():base()
        {
            this.URL = "quality.ncgenericaction";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            NCGenericActionCollectionView  = new NCGenericActionCollectionView(this); 
            NCGenericActionEntityView  = new NCGenericActionEntityView(this); 
            NCGenericActionByLangView  = new NCGenericActionByLangView(this); 
            NCGenericActionCollectionView.InitializeControls(); 
            NCGenericActionEntityView.InitializeControls(); 
            NCGenericActionByLangView.InitializeControls(); 
           
        }
      
            public NCGenericActionCollectionView NCGenericActionCollectionView {get; set; } 
            public NCGenericActionEntityView NCGenericActionEntityView {get; set; } 
            public NCGenericActionByLangView NCGenericActionByLangView {get; set; } 
    }
            
    public partial class NCGenericActionCollectionView : View
    {
        public NCGenericActionCollectionView(NCGenericAction screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            NewButton = RPSControlFactory.RPSNewButton<NCGenericActionCollectionView,NCGenericActionEntityView>( this,Screen.NCGenericActionEntityView);
 
            CollectionInit params_MainConsult = new CollectionInit(){IDDescriptor = "749be821-b9c2-4c4b-866d-8bb1b51afc56",CSSSelectorDescriptor = "",XPathDescriptor = ""};
            MainConsult = RPSControlFactory.RPSCreateCollection<NCGenericActionCollectionView,NCGenericActionEntityView>( params_MainConsult,this,Screen.NCGenericActionEntityView);
 

        }
        public IRPSButton<NCGenericActionCollectionView,NCGenericActionEntityView> NewButton { get; set; } 
        public IRPSCollectionEditor<NCGenericActionCollectionView,NCGenericActionEntityView> MainConsult { get; set; } 
        public NCGenericAction Screen { get; set; }
        public NCGenericActionCollectionView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class NCGenericActionEntityView : View
    {
        public NCGenericActionEntityView(NCGenericAction screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            SaveButton = RPSControlFactory.RPSSaveButton<NCGenericActionEntityView>( this);
 
            DeleteButton = RPSControlFactory.RPSDeleteButton<NCGenericActionEntityView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<NCGenericActionEntityView,NCGenericActionCollectionView>( this,Screen.NCGenericActionCollectionView);
 
            BackButton = RPSControlFactory.RPSBackButton<NCGenericActionEntityView,NCGenericActionCollectionView>( this,Screen.NCGenericActionCollectionView);
 
            CodAction = RPSControlFactory.CreateRPSTextBox<NCGenericActionEntityView>("6c4b1b9a-7523-420f-a182-d8b0d290c5a9","","",true, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<NCGenericActionEntityView>("ba424a64-fda8-4952-bd77-4fa2a6ff8c98","","",false, this);
 
            CollectionInit params_NCGenericActionByLangs = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="b39d43fd-85b0-45c4-937d-ab7ddd0584d7",CSSSelectorGrid="",XPathGrid=""};
            NCGenericActionByLangs = RPSControlFactory.RPSCreateCollectionWithGrid<NCGenericActionByLangsCollectionEditor<NCGenericActionEntityView,NCGenericActionByLangView>,NCGenericActionEntityView,NCGenericActionByLangView>( params_NCGenericActionByLangs,this,Screen.NCGenericActionByLangView);
 

        }
        public IRPSSaveButton<NCGenericActionEntityView> SaveButton { get; set; } 
        public IRPSButton<NCGenericActionEntityView> DeleteButton { get; set; } 
        public IRPSButton<NCGenericActionEntityView,NCGenericActionCollectionView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<NCGenericActionEntityView,NCGenericActionCollectionView> BackButton { get; set; } 
        public IRPSTextBox<NCGenericActionEntityView> CodAction { get; set; } 
        public IRPSTextBox<NCGenericActionEntityView> Description { get; set; } 
        public NCGenericActionByLangsCollectionEditor<NCGenericActionEntityView,NCGenericActionByLangView> NCGenericActionByLangs { get; set; } 
        public NCGenericAction Screen { get; set; }
        public NCGenericActionEntityView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class NCGenericActionByLangsCollectionEditor<NCGenericActionEntityView,NCGenericActionByLangView>:RPSCollectionEditor<NCGenericActionEntityView,NCGenericActionByLangView> where NCGenericActionEntityView : class, IView where NCGenericActionByLangView : class, IView
    {
        public  NCGenericActionByLangsGridView<NCGenericActionEntityView,NCGenericActionByLangView> GridView {get;set;}
    }
    public partial class NCGenericActionByLangsGridView <NCGenericActionEntityView,NCGenericActionByLangView> :  RPSGridView<NCGenericActionEntityView,NCGenericActionByLangView> where NCGenericActionEntityView : class, IView where NCGenericActionByLangView : class, IView
    {
        public NCGenericActionByLangsGridView(NCGenericActionEntityView currentView,NCGenericActionByLangView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            CodLanguage = RPSControlFactory.CreateRPSGridComboBox<NCGenericActionEntityView>("","#b39d43fd-85b0-45c4-937d-ab7ddd0584d7 .ag-row[role='row']@ROWINDEX [col-id='cCodLanguage']","",true, this.CurrentView);
 
            Description = RPSControlFactory.CreateRPSGridTextBox<NCGenericActionEntityView>("","#b39d43fd-85b0-45c4-937d-ab7ddd0584d7 .ag-row[role='row']@ROWINDEX [col-id='cDescription']","",false, this.CurrentView);
 

        }
        public IRPSGridComboBox<NCGenericActionEntityView> CodLanguage { get; set; } 
        public IRPSGridTextBox<NCGenericActionEntityView> Description { get; set; } 
                     
    }
 
    }
  
            
    public partial class NCGenericActionByLangView : View
    {
        public NCGenericActionByLangView(NCGenericAction screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            DeleteButton = RPSControlFactory.RPSDeleteButton<NCGenericActionByLangView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<NCGenericActionByLangView,NCGenericActionEntityView>( this,Screen.NCGenericActionEntityView);
 
            BackButton = RPSControlFactory.RPSBackButton<NCGenericActionByLangView,NCGenericActionEntityView>( this,Screen.NCGenericActionEntityView);
 
            AcceptButton = RPSControlFactory.RPSAcceptButton<NCGenericActionByLangView,NCGenericActionEntityView>( this,Screen.NCGenericActionEntityView);
 
            CodLanguage = RPSControlFactory.CreateRPSComboBox<NCGenericActionByLangView>("eb2b6eec-8852-440e-b6a6-dc5bceef7a24","","",true, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<NCGenericActionByLangView>("dad58570-a86e-49a3-8cc1-9e00d5ee0b50","","",false, this);
 

        }
        public IRPSButton<NCGenericActionByLangView> DeleteButton { get; set; } 
        public IRPSButton<NCGenericActionByLangView,NCGenericActionEntityView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<NCGenericActionByLangView,NCGenericActionEntityView> BackButton { get; set; } 
        public IRPSAcceptButton<NCGenericActionByLangView,NCGenericActionEntityView> AcceptButton { get; set; } 
        public IRPSComboBox<NCGenericActionByLangView> CodLanguage { get; set; } 
        public IRPSTextBox<NCGenericActionByLangView> Description { get; set; } 
        public NCGenericAction Screen { get; set; }
        public NCGenericActionByLangView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}