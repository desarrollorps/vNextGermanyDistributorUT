    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.Quality.PotentialDangerCause
{
    //RPS VERSION 1.0.0.0
    public partial class PotentialDangerCause:Screen
    {
        public PotentialDangerCause():base()
        {
            this.URL = "quality.potentialdangercause";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            PotentialDangerCauseCollectionView  = new PotentialDangerCauseCollectionView(this); 
            PotentialDangerCauseEntityView  = new PotentialDangerCauseEntityView(this); 
            PotDangerCauseByLangView  = new PotDangerCauseByLangView(this); 
            PotentialDangerCauseCollectionView.InitializeControls(); 
            PotentialDangerCauseEntityView.InitializeControls(); 
            PotDangerCauseByLangView.InitializeControls(); 
           
        }
      
            public PotentialDangerCauseCollectionView PotentialDangerCauseCollectionView {get; set; } 
            public PotentialDangerCauseEntityView PotentialDangerCauseEntityView {get; set; } 
            public PotDangerCauseByLangView PotDangerCauseByLangView {get; set; } 
    }
            
    public partial class PotentialDangerCauseCollectionView : View
    {
        public PotentialDangerCauseCollectionView(PotentialDangerCause screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            NewButton = RPSControlFactory.RPSNewButton<PotentialDangerCauseCollectionView,PotentialDangerCauseEntityView>( this,Screen.PotentialDangerCauseEntityView);
 
            CollectionInit params_MainConsult = new CollectionInit(){IDDescriptor = "c562eca2-540f-4c2b-a71d-631c835ff689",CSSSelectorDescriptor = "",XPathDescriptor = ""};
            MainConsult = RPSControlFactory.RPSCreateCollection<PotentialDangerCauseCollectionView,PotentialDangerCauseEntityView>( params_MainConsult,this,Screen.PotentialDangerCauseEntityView);
 

        }
        public IRPSButton<PotentialDangerCauseCollectionView,PotentialDangerCauseEntityView> NewButton { get; set; } 
        public IRPSCollectionEditor<PotentialDangerCauseCollectionView,PotentialDangerCauseEntityView> MainConsult { get; set; } 
        public PotentialDangerCause Screen { get; set; }
        public PotentialDangerCauseCollectionView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class PotentialDangerCauseEntityView : View
    {
        public PotentialDangerCauseEntityView(PotentialDangerCause screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            SaveButton = RPSControlFactory.RPSSaveButton<PotentialDangerCauseEntityView>( this);
 
            DeleteButton = RPSControlFactory.RPSDeleteButton<PotentialDangerCauseEntityView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<PotentialDangerCauseEntityView,PotentialDangerCauseCollectionView>( this,Screen.PotentialDangerCauseCollectionView);
 
            BackButton = RPSControlFactory.RPSBackButton<PotentialDangerCauseEntityView,PotentialDangerCauseCollectionView>( this,Screen.PotentialDangerCauseCollectionView);
 
            CodPotentialDangerCause = RPSControlFactory.CreateRPSTextBox<PotentialDangerCauseEntityView>("1d095a9b-a5dc-43ff-b36f-53afe6d0a11e","","",true, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<PotentialDangerCauseEntityView>("6d574653-444b-45be-943a-28a713a7decf","","",false, this);
 
            CollectionInit params_PotDangerCauseByLangs = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="ebebeab8-187f-4f41-b3a1-7ff335622666",CSSSelectorGrid="",XPathGrid=""};
            PotDangerCauseByLangs = RPSControlFactory.RPSCreateCollectionWithGrid<PotDangerCauseByLangsCollectionEditor<PotentialDangerCauseEntityView,PotDangerCauseByLangView>,PotentialDangerCauseEntityView,PotDangerCauseByLangView>( params_PotDangerCauseByLangs,this,Screen.PotDangerCauseByLangView);
 

        }
        public IRPSSaveButton<PotentialDangerCauseEntityView> SaveButton { get; set; } 
        public IRPSButton<PotentialDangerCauseEntityView> DeleteButton { get; set; } 
        public IRPSButton<PotentialDangerCauseEntityView,PotentialDangerCauseCollectionView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<PotentialDangerCauseEntityView,PotentialDangerCauseCollectionView> BackButton { get; set; } 
        public IRPSTextBox<PotentialDangerCauseEntityView> CodPotentialDangerCause { get; set; } 
        public IRPSTextBox<PotentialDangerCauseEntityView> Description { get; set; } 
        public PotDangerCauseByLangsCollectionEditor<PotentialDangerCauseEntityView,PotDangerCauseByLangView> PotDangerCauseByLangs { get; set; } 
        public PotentialDangerCause Screen { get; set; }
        public PotentialDangerCauseEntityView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class PotDangerCauseByLangsCollectionEditor<PotentialDangerCauseEntityView,PotDangerCauseByLangView>:RPSCollectionEditor<PotentialDangerCauseEntityView,PotDangerCauseByLangView> where PotentialDangerCauseEntityView : class, IView where PotDangerCauseByLangView : class, IView
    {
        public  PotDangerCauseByLangsGridView<PotentialDangerCauseEntityView,PotDangerCauseByLangView> GridView {get;set;}
    }
    public partial class PotDangerCauseByLangsGridView <PotentialDangerCauseEntityView,PotDangerCauseByLangView> :  RPSGridView<PotentialDangerCauseEntityView,PotDangerCauseByLangView> where PotentialDangerCauseEntityView : class, IView where PotDangerCauseByLangView : class, IView
    {
        public PotDangerCauseByLangsGridView(PotentialDangerCauseEntityView currentView,PotDangerCauseByLangView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            CodLanguage = RPSControlFactory.CreateRPSGridComboBox<PotentialDangerCauseEntityView>("","#ebebeab8-187f-4f41-b3a1-7ff335622666 .ag-row[role='row']@ROWINDEX [col-id='cCodLanguage']","",true, this.CurrentView);
 
            Description = RPSControlFactory.CreateRPSGridTextBox<PotentialDangerCauseEntityView>("","#ebebeab8-187f-4f41-b3a1-7ff335622666 .ag-row[role='row']@ROWINDEX [col-id='cDescription']","",false, this.CurrentView);
 

        }
        public IRPSGridComboBox<PotentialDangerCauseEntityView> CodLanguage { get; set; } 
        public IRPSGridTextBox<PotentialDangerCauseEntityView> Description { get; set; } 
                     
    }
 
    }
  
            
    public partial class PotDangerCauseByLangView : View
    {
        public PotDangerCauseByLangView(PotentialDangerCause screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            DeleteButton = RPSControlFactory.RPSDeleteButton<PotDangerCauseByLangView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<PotDangerCauseByLangView,PotentialDangerCauseEntityView>( this,Screen.PotentialDangerCauseEntityView);
 
            BackButton = RPSControlFactory.RPSBackButton<PotDangerCauseByLangView,PotentialDangerCauseEntityView>( this,Screen.PotentialDangerCauseEntityView);
 
            AcceptButton = RPSControlFactory.RPSAcceptButton<PotDangerCauseByLangView,PotentialDangerCauseEntityView>( this,Screen.PotentialDangerCauseEntityView);
 
            CodLanguage = RPSControlFactory.CreateRPSComboBox<PotDangerCauseByLangView>("b725a9b3-438a-4262-a0ee-ee99d7bb876c","","",true, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<PotDangerCauseByLangView>("f3242e56-fa1b-4796-8fa6-76588a038b41","","",false, this);
 

        }
        public IRPSButton<PotDangerCauseByLangView> DeleteButton { get; set; } 
        public IRPSButton<PotDangerCauseByLangView,PotentialDangerCauseEntityView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<PotDangerCauseByLangView,PotentialDangerCauseEntityView> BackButton { get; set; } 
        public IRPSAcceptButton<PotDangerCauseByLangView,PotentialDangerCauseEntityView> AcceptButton { get; set; } 
        public IRPSComboBox<PotDangerCauseByLangView> CodLanguage { get; set; } 
        public IRPSTextBox<PotDangerCauseByLangView> Description { get; set; } 
        public PotentialDangerCause Screen { get; set; }
        public PotDangerCauseByLangView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}