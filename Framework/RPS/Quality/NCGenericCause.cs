    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.Quality.NCGenericCause
{
    //RPS VERSION 1.0.0.0
    public partial class NCGenericCause:Screen
    {
        public NCGenericCause():base()
        {
            this.URL = "quality.ncgenericcause";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            NCGenericCauseCollectionView  = new NCGenericCauseCollectionView(this); 
            NCGenericCauseEntityView  = new NCGenericCauseEntityView(this); 
            NCGenericCauseByLangView  = new NCGenericCauseByLangView(this); 
            NCGenericCauseCollectionView.InitializeControls(); 
            NCGenericCauseEntityView.InitializeControls(); 
            NCGenericCauseByLangView.InitializeControls(); 
           
        }
      
            public NCGenericCauseCollectionView NCGenericCauseCollectionView {get; set; } 
            public NCGenericCauseEntityView NCGenericCauseEntityView {get; set; } 
            public NCGenericCauseByLangView NCGenericCauseByLangView {get; set; } 
    }
            
    public partial class NCGenericCauseCollectionView : View
    {
        public NCGenericCauseCollectionView(NCGenericCause screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            NewButton = RPSControlFactory.RPSNewButton<NCGenericCauseCollectionView,NCGenericCauseEntityView>( this,Screen.NCGenericCauseEntityView);
 
            CollectionInit params_MainConsult = new CollectionInit(){IDDescriptor = "0f1a557f-8fc0-44f5-8259-2fb956254e39",CSSSelectorDescriptor = "",XPathDescriptor = ""};
            MainConsult = RPSControlFactory.RPSCreateCollection<NCGenericCauseCollectionView,NCGenericCauseEntityView>( params_MainConsult,this,Screen.NCGenericCauseEntityView);
 

        }
        public IRPSButton<NCGenericCauseCollectionView,NCGenericCauseEntityView> NewButton { get; set; } 
        public IRPSCollectionEditor<NCGenericCauseCollectionView,NCGenericCauseEntityView> MainConsult { get; set; } 
        public NCGenericCause Screen { get; set; }
        public NCGenericCauseCollectionView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class NCGenericCauseEntityView : View
    {
        public NCGenericCauseEntityView(NCGenericCause screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            SaveButton = RPSControlFactory.RPSSaveButton<NCGenericCauseEntityView>( this);
 
            DeleteButton = RPSControlFactory.RPSDeleteButton<NCGenericCauseEntityView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<NCGenericCauseEntityView,NCGenericCauseCollectionView>( this,Screen.NCGenericCauseCollectionView);
 
            BackButton = RPSControlFactory.RPSBackButton<NCGenericCauseEntityView,NCGenericCauseCollectionView>( this,Screen.NCGenericCauseCollectionView);
 
            CodCause = RPSControlFactory.CreateRPSTextBox<NCGenericCauseEntityView>("0d583126-166f-4803-a0e6-7e673acaa1d3","","",true, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<NCGenericCauseEntityView>("7b149160-0541-49e2-9368-b2a7cd1c42d8","","",false, this);
 
            CollectionInit params_NCGenericCauseByLangs = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="6559320b-1703-4e53-a0de-264f8156276b",CSSSelectorGrid="",XPathGrid=""};
            NCGenericCauseByLangs = RPSControlFactory.RPSCreateCollectionWithGrid<NCGenericCauseByLangsCollectionEditor<NCGenericCauseEntityView,NCGenericCauseByLangView>,NCGenericCauseEntityView,NCGenericCauseByLangView>( params_NCGenericCauseByLangs,this,Screen.NCGenericCauseByLangView);
 

        }
        public IRPSSaveButton<NCGenericCauseEntityView> SaveButton { get; set; } 
        public IRPSButton<NCGenericCauseEntityView> DeleteButton { get; set; } 
        public IRPSButton<NCGenericCauseEntityView,NCGenericCauseCollectionView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<NCGenericCauseEntityView,NCGenericCauseCollectionView> BackButton { get; set; } 
        public IRPSTextBox<NCGenericCauseEntityView> CodCause { get; set; } 
        public IRPSTextBox<NCGenericCauseEntityView> Description { get; set; } 
        public NCGenericCauseByLangsCollectionEditor<NCGenericCauseEntityView,NCGenericCauseByLangView> NCGenericCauseByLangs { get; set; } 
        public NCGenericCause Screen { get; set; }
        public NCGenericCauseEntityView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class NCGenericCauseByLangsCollectionEditor<NCGenericCauseEntityView,NCGenericCauseByLangView>:RPSCollectionEditor<NCGenericCauseEntityView,NCGenericCauseByLangView> where NCGenericCauseEntityView : class, IView where NCGenericCauseByLangView : class, IView
    {
        public  NCGenericCauseByLangsGridView<NCGenericCauseEntityView,NCGenericCauseByLangView> GridView {get;set;}
    }
    public partial class NCGenericCauseByLangsGridView <NCGenericCauseEntityView,NCGenericCauseByLangView> :  RPSGridView<NCGenericCauseEntityView,NCGenericCauseByLangView> where NCGenericCauseEntityView : class, IView where NCGenericCauseByLangView : class, IView
    {
        public NCGenericCauseByLangsGridView(NCGenericCauseEntityView currentView,NCGenericCauseByLangView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            CodLanguage = RPSControlFactory.CreateRPSGridComboBox<NCGenericCauseEntityView>("","#6559320b-1703-4e53-a0de-264f8156276b .ag-row[role='row']@ROWINDEX [col-id='cCodLanguage']","",true, this.CurrentView);
 
            Description = RPSControlFactory.CreateRPSGridTextBox<NCGenericCauseEntityView>("","#6559320b-1703-4e53-a0de-264f8156276b .ag-row[role='row']@ROWINDEX [col-id='cDescription']","",false, this.CurrentView);
 

        }
        public IRPSGridComboBox<NCGenericCauseEntityView> CodLanguage { get; set; } 
        public IRPSGridTextBox<NCGenericCauseEntityView> Description { get; set; } 
                     
    }
 
    }
  
            
    public partial class NCGenericCauseByLangView : View
    {
        public NCGenericCauseByLangView(NCGenericCause screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            DeleteButton = RPSControlFactory.RPSDeleteButton<NCGenericCauseByLangView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<NCGenericCauseByLangView,NCGenericCauseEntityView>( this,Screen.NCGenericCauseEntityView);
 
            BackButton = RPSControlFactory.RPSBackButton<NCGenericCauseByLangView,NCGenericCauseEntityView>( this,Screen.NCGenericCauseEntityView);
 
            AcceptButton = RPSControlFactory.RPSAcceptButton<NCGenericCauseByLangView,NCGenericCauseEntityView>( this,Screen.NCGenericCauseEntityView);
 
            CodLanguage = RPSControlFactory.CreateRPSComboBox<NCGenericCauseByLangView>("99c9cf31-a897-47ac-bbfe-4a5919115e63","","",true, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<NCGenericCauseByLangView>("c8f91bba-7f52-417f-89bc-e227c86305d0","","",false, this);
 

        }
        public IRPSButton<NCGenericCauseByLangView> DeleteButton { get; set; } 
        public IRPSButton<NCGenericCauseByLangView,NCGenericCauseEntityView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<NCGenericCauseByLangView,NCGenericCauseEntityView> BackButton { get; set; } 
        public IRPSAcceptButton<NCGenericCauseByLangView,NCGenericCauseEntityView> AcceptButton { get; set; } 
        public IRPSComboBox<NCGenericCauseByLangView> CodLanguage { get; set; } 
        public IRPSTextBox<NCGenericCauseByLangView> Description { get; set; } 
        public NCGenericCause Screen { get; set; }
        public NCGenericCauseByLangView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}