    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.Quality.Requirement
{
    //RPS VERSION 1.0.0.0
    public partial class Requirement:Screen
    {
        public Requirement():base()
        {
            this.URL = "quality.requirement";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            RequirementCollectionView  = new RequirementCollectionView(this); 
            RequirementEntityView  = new RequirementEntityView(this); 
            RequirementByLangView  = new RequirementByLangView(this); 
            RequirementCollectionView.InitializeControls(); 
            RequirementEntityView.InitializeControls(); 
            RequirementByLangView.InitializeControls(); 
           
        }
      
            public RequirementCollectionView RequirementCollectionView {get; set; } 
            public RequirementEntityView RequirementEntityView {get; set; } 
            public RequirementByLangView RequirementByLangView {get; set; } 
    }
            
    public partial class RequirementCollectionView : View
    {
        public RequirementCollectionView(Requirement screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            NewButton = RPSControlFactory.RPSNewButton<RequirementCollectionView,RequirementEntityView>( this,Screen.RequirementEntityView);
 
            CollectionInit params_MainConsult = new CollectionInit(){IDDescriptor = "16f0d9b8-7cb1-4835-9e54-f83b5d339642",CSSSelectorDescriptor = "",XPathDescriptor = ""};
            MainConsult = RPSControlFactory.RPSCreateCollection<RequirementCollectionView,RequirementEntityView>( params_MainConsult,this,Screen.RequirementEntityView);
 

        }
        public IRPSButton<RequirementCollectionView,RequirementEntityView> NewButton { get; set; } 
        public IRPSCollectionEditor<RequirementCollectionView,RequirementEntityView> MainConsult { get; set; } 
        public Requirement Screen { get; set; }
        public RequirementCollectionView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class RequirementEntityView : View
    {
        public RequirementEntityView(Requirement screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            SaveButton = RPSControlFactory.RPSSaveButton<RequirementEntityView>( this);
 
            DeleteButton = RPSControlFactory.RPSDeleteButton<RequirementEntityView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<RequirementEntityView,RequirementCollectionView>( this,Screen.RequirementCollectionView);
 
            BackButton = RPSControlFactory.RPSBackButton<RequirementEntityView,RequirementCollectionView>( this,Screen.RequirementCollectionView);
 
            CodRequirement = RPSControlFactory.CreateRPSTextBox<RequirementEntityView>("90f64c67-7118-44b3-815d-bcfc6a4a27ab","","",true, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<RequirementEntityView>("3e345539-3a8c-450b-930c-33798b871b3d","","",false, this);
 
            CollectionInit params_RequirementByLangs = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="a0f4ca70-1db6-403f-aa69-6b00b8cad615",CSSSelectorGrid="",XPathGrid=""};
            RequirementByLangs = RPSControlFactory.RPSCreateCollectionWithGrid<RequirementByLangsCollectionEditor<RequirementEntityView,RequirementByLangView>,RequirementEntityView,RequirementByLangView>( params_RequirementByLangs,this,Screen.RequirementByLangView);
 

        }
        public IRPSSaveButton<RequirementEntityView> SaveButton { get; set; } 
        public IRPSButton<RequirementEntityView> DeleteButton { get; set; } 
        public IRPSButton<RequirementEntityView,RequirementCollectionView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<RequirementEntityView,RequirementCollectionView> BackButton { get; set; } 
        public IRPSTextBox<RequirementEntityView> CodRequirement { get; set; } 
        public IRPSTextBox<RequirementEntityView> Description { get; set; } 
        public RequirementByLangsCollectionEditor<RequirementEntityView,RequirementByLangView> RequirementByLangs { get; set; } 
        public Requirement Screen { get; set; }
        public RequirementEntityView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class RequirementByLangsCollectionEditor<RequirementEntityView,RequirementByLangView>:RPSCollectionEditor<RequirementEntityView,RequirementByLangView> where RequirementEntityView : class, IView where RequirementByLangView : class, IView
    {
        public  RequirementByLangsGridView<RequirementEntityView,RequirementByLangView> GridView {get;set;}
    }
    public partial class RequirementByLangsGridView <RequirementEntityView,RequirementByLangView> :  RPSGridView<RequirementEntityView,RequirementByLangView> where RequirementEntityView : class, IView where RequirementByLangView : class, IView
    {
        public RequirementByLangsGridView(RequirementEntityView currentView,RequirementByLangView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            CodLanguage = RPSControlFactory.CreateRPSGridComboBox<RequirementEntityView>("","#a0f4ca70-1db6-403f-aa69-6b00b8cad615 .ag-row[role='row']@ROWINDEX [col-id='cCodLanguage']","",true, this.CurrentView);
 
            Description = RPSControlFactory.CreateRPSGridTextBox<RequirementEntityView>("","#a0f4ca70-1db6-403f-aa69-6b00b8cad615 .ag-row[role='row']@ROWINDEX [col-id='cDescription']","",false, this.CurrentView);
 

        }
        public IRPSGridComboBox<RequirementEntityView> CodLanguage { get; set; } 
        public IRPSGridTextBox<RequirementEntityView> Description { get; set; } 
                     
    }
 
    }
  
            
    public partial class RequirementByLangView : View
    {
        public RequirementByLangView(Requirement screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            DeleteButton = RPSControlFactory.RPSDeleteButton<RequirementByLangView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<RequirementByLangView,RequirementEntityView>( this,Screen.RequirementEntityView);
 
            BackButton = RPSControlFactory.RPSBackButton<RequirementByLangView,RequirementEntityView>( this,Screen.RequirementEntityView);
 
            AcceptButton = RPSControlFactory.RPSAcceptButton<RequirementByLangView,RequirementEntityView>( this,Screen.RequirementEntityView);
 
            CodLanguage = RPSControlFactory.CreateRPSComboBox<RequirementByLangView>("3049be2c-d376-4a22-8670-65977338c8ee","","",true, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<RequirementByLangView>("57586dbb-b1fe-4e66-ab66-61614b507c9d","","",false, this);
 

        }
        public IRPSButton<RequirementByLangView> DeleteButton { get; set; } 
        public IRPSButton<RequirementByLangView,RequirementEntityView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<RequirementByLangView,RequirementEntityView> BackButton { get; set; } 
        public IRPSAcceptButton<RequirementByLangView,RequirementEntityView> AcceptButton { get; set; } 
        public IRPSComboBox<RequirementByLangView> CodLanguage { get; set; } 
        public IRPSTextBox<RequirementByLangView> Description { get; set; } 
        public Requirement Screen { get; set; }
        public RequirementByLangView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}