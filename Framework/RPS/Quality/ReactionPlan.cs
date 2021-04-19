    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.Quality.ReactionPlan
{
    //RPS VERSION 1.0.0.0
    public partial class ReactionPlan:Screen
    {
        public ReactionPlan():base()
        {
            this.URL = "quality.reactionplan";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            ReactionPlanCollectionView  = new ReactionPlanCollectionView(this); 
            ReactionPlanEntityView  = new ReactionPlanEntityView(this); 
            ReactionPlanByLangView  = new ReactionPlanByLangView(this); 
            ReactionPlanCollectionView.InitializeControls(); 
            ReactionPlanEntityView.InitializeControls(); 
            ReactionPlanByLangView.InitializeControls(); 
           
        }
      
            public ReactionPlanCollectionView ReactionPlanCollectionView {get; set; } 
            public ReactionPlanEntityView ReactionPlanEntityView {get; set; } 
            public ReactionPlanByLangView ReactionPlanByLangView {get; set; } 
    }
            
    public partial class ReactionPlanCollectionView : View
    {
        public ReactionPlanCollectionView(ReactionPlan screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            NewButton = RPSControlFactory.RPSNewButton<ReactionPlanCollectionView,ReactionPlanEntityView>( this,Screen.ReactionPlanEntityView);
 
            CollectionInit params_MainConsult = new CollectionInit(){IDDescriptor = "c48c295c-4c72-4817-95bd-6eec2f1cb151",CSSSelectorDescriptor = "",XPathDescriptor = ""};
            MainConsult = RPSControlFactory.RPSCreateCollection<ReactionPlanCollectionView,ReactionPlanEntityView>( params_MainConsult,this,Screen.ReactionPlanEntityView);
 

        }
        public IRPSButton<ReactionPlanCollectionView,ReactionPlanEntityView> NewButton { get; set; } 
        public IRPSCollectionEditor<ReactionPlanCollectionView,ReactionPlanEntityView> MainConsult { get; set; } 
        public ReactionPlan Screen { get; set; }
        public ReactionPlanCollectionView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class ReactionPlanEntityView : View
    {
        public ReactionPlanEntityView(ReactionPlan screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            SaveButton = RPSControlFactory.RPSSaveButton<ReactionPlanEntityView>( this);
 
            DeleteButton = RPSControlFactory.RPSDeleteButton<ReactionPlanEntityView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<ReactionPlanEntityView,ReactionPlanCollectionView>( this,Screen.ReactionPlanCollectionView);
 
            BackButton = RPSControlFactory.RPSBackButton<ReactionPlanEntityView,ReactionPlanCollectionView>( this,Screen.ReactionPlanCollectionView);
 
            CodReactionPlan = RPSControlFactory.CreateRPSTextBox<ReactionPlanEntityView>("98ccef13-9ffa-43a8-ab4d-7734595a5713","","",true, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<ReactionPlanEntityView>("565cffcc-40ef-4289-9b46-61ca33160f67","","",false, this);
 
            CollectionInit params_ReactionPlanByLangs = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="129a88c7-605f-46cc-8d49-df78beef3e0f",CSSSelectorGrid="",XPathGrid=""};
            ReactionPlanByLangs = RPSControlFactory.RPSCreateCollectionWithGrid<ReactionPlanByLangsCollectionEditor<ReactionPlanEntityView,ReactionPlanByLangView>,ReactionPlanEntityView,ReactionPlanByLangView>( params_ReactionPlanByLangs,this,Screen.ReactionPlanByLangView);
 

        }
        public IRPSSaveButton<ReactionPlanEntityView> SaveButton { get; set; } 
        public IRPSButton<ReactionPlanEntityView> DeleteButton { get; set; } 
        public IRPSButton<ReactionPlanEntityView,ReactionPlanCollectionView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<ReactionPlanEntityView,ReactionPlanCollectionView> BackButton { get; set; } 
        public IRPSTextBox<ReactionPlanEntityView> CodReactionPlan { get; set; } 
        public IRPSTextBox<ReactionPlanEntityView> Description { get; set; } 
        public ReactionPlanByLangsCollectionEditor<ReactionPlanEntityView,ReactionPlanByLangView> ReactionPlanByLangs { get; set; } 
        public ReactionPlan Screen { get; set; }
        public ReactionPlanEntityView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class ReactionPlanByLangsCollectionEditor<ReactionPlanEntityView,ReactionPlanByLangView>:RPSCollectionEditor<ReactionPlanEntityView,ReactionPlanByLangView> where ReactionPlanEntityView : class, IView where ReactionPlanByLangView : class, IView
    {
        public  ReactionPlanByLangsGridView<ReactionPlanEntityView,ReactionPlanByLangView> GridView {get;set;}
    }
    public partial class ReactionPlanByLangsGridView <ReactionPlanEntityView,ReactionPlanByLangView> :  RPSGridView<ReactionPlanEntityView,ReactionPlanByLangView> where ReactionPlanEntityView : class, IView where ReactionPlanByLangView : class, IView
    {
        public ReactionPlanByLangsGridView(ReactionPlanEntityView currentView,ReactionPlanByLangView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            CodLanguage = RPSControlFactory.CreateRPSGridComboBox<ReactionPlanEntityView>("","#129a88c7-605f-46cc-8d49-df78beef3e0f .ag-row[role='row']@ROWINDEX [col-id='cCodLanguage']","",true, this.CurrentView);
 
            Description = RPSControlFactory.CreateRPSGridTextBox<ReactionPlanEntityView>("","#129a88c7-605f-46cc-8d49-df78beef3e0f .ag-row[role='row']@ROWINDEX [col-id='cDescription']","",false, this.CurrentView);
 

        }
        public IRPSGridComboBox<ReactionPlanEntityView> CodLanguage { get; set; } 
        public IRPSGridTextBox<ReactionPlanEntityView> Description { get; set; } 
                     
    }
 
    }
  
            
    public partial class ReactionPlanByLangView : View
    {
        public ReactionPlanByLangView(ReactionPlan screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            DeleteButton = RPSControlFactory.RPSDeleteButton<ReactionPlanByLangView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<ReactionPlanByLangView,ReactionPlanEntityView>( this,Screen.ReactionPlanEntityView);
 
            BackButton = RPSControlFactory.RPSBackButton<ReactionPlanByLangView,ReactionPlanEntityView>( this,Screen.ReactionPlanEntityView);
 
            AcceptButton = RPSControlFactory.RPSAcceptButton<ReactionPlanByLangView,ReactionPlanEntityView>( this,Screen.ReactionPlanEntityView);
 
            CodLanguage = RPSControlFactory.CreateRPSComboBox<ReactionPlanByLangView>("1dbcdef3-2a86-42b8-9e52-43b25a9f5335","","",true, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<ReactionPlanByLangView>("95fb60bb-f741-4a89-ba0e-e11511c506ff","","",false, this);
 

        }
        public IRPSButton<ReactionPlanByLangView> DeleteButton { get; set; } 
        public IRPSButton<ReactionPlanByLangView,ReactionPlanEntityView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<ReactionPlanByLangView,ReactionPlanEntityView> BackButton { get; set; } 
        public IRPSAcceptButton<ReactionPlanByLangView,ReactionPlanEntityView> AcceptButton { get; set; } 
        public IRPSComboBox<ReactionPlanByLangView> CodLanguage { get; set; } 
        public IRPSTextBox<ReactionPlanByLangView> Description { get; set; } 
        public ReactionPlan Screen { get; set; }
        public ReactionPlanByLangView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}