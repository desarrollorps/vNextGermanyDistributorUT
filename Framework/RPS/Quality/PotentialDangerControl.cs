    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.Quality.PotentialDangerControl
{
    //RPS VERSION 1.0.0.0
    public partial class PotentialDangerControl:Screen
    {
        public PotentialDangerControl():base()
        {
            this.URL = "quality.potentialdangercontrol";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            PotentialDangerControlCollectionView  = new PotentialDangerControlCollectionView(this); 
            PotentialDangerControlEntityView  = new PotentialDangerControlEntityView(this); 
            PotDangerControlByLangView  = new PotDangerControlByLangView(this); 
            PotentialDangerControlCollectionView.InitializeControls(); 
            PotentialDangerControlEntityView.InitializeControls(); 
            PotDangerControlByLangView.InitializeControls(); 
           
        }
      
            public PotentialDangerControlCollectionView PotentialDangerControlCollectionView {get; set; } 
            public PotentialDangerControlEntityView PotentialDangerControlEntityView {get; set; } 
            public PotDangerControlByLangView PotDangerControlByLangView {get; set; } 
    }
            
    public partial class PotentialDangerControlCollectionView : View
    {
        public PotentialDangerControlCollectionView(PotentialDangerControl screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            NewButton = RPSControlFactory.RPSNewButton<PotentialDangerControlCollectionView,PotentialDangerControlEntityView>( this,Screen.PotentialDangerControlEntityView);
 
            CollectionInit params_MainConsult = new CollectionInit(){IDDescriptor = "574e03c1-d5dd-4e5e-bf98-baf4cd457fcd",CSSSelectorDescriptor = "",XPathDescriptor = ""};
            MainConsult = RPSControlFactory.RPSCreateCollection<PotentialDangerControlCollectionView,PotentialDangerControlEntityView>( params_MainConsult,this,Screen.PotentialDangerControlEntityView);
 

        }
        public IRPSButton<PotentialDangerControlCollectionView,PotentialDangerControlEntityView> NewButton { get; set; } 
        public IRPSCollectionEditor<PotentialDangerControlCollectionView,PotentialDangerControlEntityView> MainConsult { get; set; } 
        public PotentialDangerControl Screen { get; set; }
        public PotentialDangerControlCollectionView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class PotentialDangerControlEntityView : View
    {
        public PotentialDangerControlEntityView(PotentialDangerControl screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            SaveButton = RPSControlFactory.RPSSaveButton<PotentialDangerControlEntityView>( this);
 
            DeleteButton = RPSControlFactory.RPSDeleteButton<PotentialDangerControlEntityView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<PotentialDangerControlEntityView,PotentialDangerControlCollectionView>( this,Screen.PotentialDangerControlCollectionView);
 
            BackButton = RPSControlFactory.RPSBackButton<PotentialDangerControlEntityView,PotentialDangerControlCollectionView>( this,Screen.PotentialDangerControlCollectionView);
 
            CodPotentialDangerControl = RPSControlFactory.CreateRPSTextBox<PotentialDangerControlEntityView>("e6fec67f-e711-4edb-9f62-e038cc9e9716","","",true, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<PotentialDangerControlEntityView>("4973f699-fa36-46fa-8b85-c59dc578cc09","","",false, this);
 
            CollectionInit params_PotDangerControlByLangs = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="ad033c8c-26c5-42b9-ae33-bf7633c5da2c",CSSSelectorGrid="",XPathGrid=""};
            PotDangerControlByLangs = RPSControlFactory.RPSCreateCollectionWithGrid<PotDangerControlByLangsCollectionEditor<PotentialDangerControlEntityView,PotDangerControlByLangView>,PotentialDangerControlEntityView,PotDangerControlByLangView>( params_PotDangerControlByLangs,this,Screen.PotDangerControlByLangView);
 

        }
        public IRPSSaveButton<PotentialDangerControlEntityView> SaveButton { get; set; } 
        public IRPSButton<PotentialDangerControlEntityView> DeleteButton { get; set; } 
        public IRPSButton<PotentialDangerControlEntityView,PotentialDangerControlCollectionView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<PotentialDangerControlEntityView,PotentialDangerControlCollectionView> BackButton { get; set; } 
        public IRPSTextBox<PotentialDangerControlEntityView> CodPotentialDangerControl { get; set; } 
        public IRPSTextBox<PotentialDangerControlEntityView> Description { get; set; } 
        public PotDangerControlByLangsCollectionEditor<PotentialDangerControlEntityView,PotDangerControlByLangView> PotDangerControlByLangs { get; set; } 
        public PotentialDangerControl Screen { get; set; }
        public PotentialDangerControlEntityView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class PotDangerControlByLangsCollectionEditor<PotentialDangerControlEntityView,PotDangerControlByLangView>:RPSCollectionEditor<PotentialDangerControlEntityView,PotDangerControlByLangView> where PotentialDangerControlEntityView : class, IView where PotDangerControlByLangView : class, IView
    {
        public  PotDangerControlByLangsGridView<PotentialDangerControlEntityView,PotDangerControlByLangView> GridView {get;set;}
    }
    public partial class PotDangerControlByLangsGridView <PotentialDangerControlEntityView,PotDangerControlByLangView> :  RPSGridView<PotentialDangerControlEntityView,PotDangerControlByLangView> where PotentialDangerControlEntityView : class, IView where PotDangerControlByLangView : class, IView
    {
        public PotDangerControlByLangsGridView(PotentialDangerControlEntityView currentView,PotDangerControlByLangView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            CodLanguage = RPSControlFactory.CreateRPSGridComboBox<PotentialDangerControlEntityView>("","#ad033c8c-26c5-42b9-ae33-bf7633c5da2c .ag-row[role='row']@ROWINDEX [col-id='cCodLanguage']","",true, this.CurrentView);
 
            Description = RPSControlFactory.CreateRPSGridTextBox<PotentialDangerControlEntityView>("","#ad033c8c-26c5-42b9-ae33-bf7633c5da2c .ag-row[role='row']@ROWINDEX [col-id='cDescription']","",false, this.CurrentView);
 

        }
        public IRPSGridComboBox<PotentialDangerControlEntityView> CodLanguage { get; set; } 
        public IRPSGridTextBox<PotentialDangerControlEntityView> Description { get; set; } 
                     
    }
 
    }
  
            
    public partial class PotDangerControlByLangView : View
    {
        public PotDangerControlByLangView(PotentialDangerControl screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            DeleteButton = RPSControlFactory.RPSDeleteButton<PotDangerControlByLangView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<PotDangerControlByLangView,PotentialDangerControlEntityView>( this,Screen.PotentialDangerControlEntityView);
 
            BackButton = RPSControlFactory.RPSBackButton<PotDangerControlByLangView,PotentialDangerControlEntityView>( this,Screen.PotentialDangerControlEntityView);
 
            AcceptButton = RPSControlFactory.RPSAcceptButton<PotDangerControlByLangView,PotentialDangerControlEntityView>( this,Screen.PotentialDangerControlEntityView);
 
            CodLanguage = RPSControlFactory.CreateRPSComboBox<PotDangerControlByLangView>("f8cf5882-c12a-40c7-b511-4cfa095973bf","","",true, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<PotDangerControlByLangView>("ac481386-41dc-492d-97c6-0bd5e4d5d49c","","",false, this);
 

        }
        public IRPSButton<PotDangerControlByLangView> DeleteButton { get; set; } 
        public IRPSButton<PotDangerControlByLangView,PotentialDangerControlEntityView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<PotDangerControlByLangView,PotentialDangerControlEntityView> BackButton { get; set; } 
        public IRPSAcceptButton<PotDangerControlByLangView,PotentialDangerControlEntityView> AcceptButton { get; set; } 
        public IRPSComboBox<PotDangerControlByLangView> CodLanguage { get; set; } 
        public IRPSTextBox<PotDangerControlByLangView> Description { get; set; } 
        public PotentialDangerControl Screen { get; set; }
        public PotDangerControlByLangView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}