    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.Quality.FeasibilityQuestion
{
    //RPS VERSION 1.0.0.0
    public partial class FeasibilityQuestion:Screen
    {
        public FeasibilityQuestion():base()
        {
            this.URL = "quality.feasibilityquestion";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            FeasibilityQuestionCollectionView  = new FeasibilityQuestionCollectionView(this); 
            FeasibilityQuestionEntityView  = new FeasibilityQuestionEntityView(this); 
            FeasibilityQuestionByLangView  = new FeasibilityQuestionByLangView(this); 
            FeasibilityQuestionCollectionView.InitializeControls(); 
            FeasibilityQuestionEntityView.InitializeControls(); 
            FeasibilityQuestionByLangView.InitializeControls(); 
           
        }
      
            public FeasibilityQuestionCollectionView FeasibilityQuestionCollectionView {get; set; } 
            public FeasibilityQuestionEntityView FeasibilityQuestionEntityView {get; set; } 
            public FeasibilityQuestionByLangView FeasibilityQuestionByLangView {get; set; } 
    }
            
    public partial class FeasibilityQuestionCollectionView : View
    {
        public FeasibilityQuestionCollectionView(FeasibilityQuestion screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            NewButton = RPSControlFactory.RPSNewButton<FeasibilityQuestionCollectionView,FeasibilityQuestionEntityView>( this,Screen.FeasibilityQuestionEntityView);
 
            CollectionInit params_MainConsult = new CollectionInit(){IDDescriptor = "b2831b70-6772-4402-ba9a-1ac8a726fe6c",CSSSelectorDescriptor = "",XPathDescriptor = ""};
            MainConsult = RPSControlFactory.RPSCreateCollection<FeasibilityQuestionCollectionView,FeasibilityQuestionEntityView>( params_MainConsult,this,Screen.FeasibilityQuestionEntityView);
 

        }
        public IRPSButton<FeasibilityQuestionCollectionView,FeasibilityQuestionEntityView> NewButton { get; set; } 
        public IRPSCollectionEditor<FeasibilityQuestionCollectionView,FeasibilityQuestionEntityView> MainConsult { get; set; } 
        public FeasibilityQuestion Screen { get; set; }
        public FeasibilityQuestionCollectionView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class FeasibilityQuestionEntityView : View
    {
        public FeasibilityQuestionEntityView(FeasibilityQuestion screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            SaveButton = RPSControlFactory.RPSSaveButton<FeasibilityQuestionEntityView>( this);
 
            DeleteButton = RPSControlFactory.RPSDeleteButton<FeasibilityQuestionEntityView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<FeasibilityQuestionEntityView,FeasibilityQuestionCollectionView>( this,Screen.FeasibilityQuestionCollectionView);
 
            BackButton = RPSControlFactory.RPSBackButton<FeasibilityQuestionEntityView,FeasibilityQuestionCollectionView>( this,Screen.FeasibilityQuestionCollectionView);
 
            NumQuestion = RPSControlFactory.CreateRPSFormattedTextBox<FeasibilityQuestionEntityView>("f01b650b-a24f-423d-ad18-f157bbe52e6c","","",true, this);
 
            Question = RPSControlFactory.CreateRPSTextBox<FeasibilityQuestionEntityView>("3a97f9a8-d528-44be-a5ef-bd663dec8650","","",false, this);
 
            CollectionInit params_FeasibilityQuestionByLangs = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="6a08d84a-b250-4871-a412-0aabce8ad08c",CSSSelectorGrid="",XPathGrid=""};
            FeasibilityQuestionByLangs = RPSControlFactory.RPSCreateCollectionWithGrid<FeasibilityQuestionByLangsCollectionEditor<FeasibilityQuestionEntityView,FeasibilityQuestionByLangView>,FeasibilityQuestionEntityView,FeasibilityQuestionByLangView>( params_FeasibilityQuestionByLangs,this,Screen.FeasibilityQuestionByLangView);
 

        }
        public IRPSSaveButton<FeasibilityQuestionEntityView> SaveButton { get; set; } 
        public IRPSButton<FeasibilityQuestionEntityView> DeleteButton { get; set; } 
        public IRPSButton<FeasibilityQuestionEntityView,FeasibilityQuestionCollectionView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<FeasibilityQuestionEntityView,FeasibilityQuestionCollectionView> BackButton { get; set; } 
        public IRPSTextBox<FeasibilityQuestionEntityView> NumQuestion { get; set; } 
        public IRPSTextBox<FeasibilityQuestionEntityView> Question { get; set; } 
        public FeasibilityQuestionByLangsCollectionEditor<FeasibilityQuestionEntityView,FeasibilityQuestionByLangView> FeasibilityQuestionByLangs { get; set; } 
        public FeasibilityQuestion Screen { get; set; }
        public FeasibilityQuestionEntityView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class FeasibilityQuestionByLangsCollectionEditor<FeasibilityQuestionEntityView,FeasibilityQuestionByLangView>:RPSCollectionEditor<FeasibilityQuestionEntityView,FeasibilityQuestionByLangView> where FeasibilityQuestionEntityView : class, IView where FeasibilityQuestionByLangView : class, IView
    {
        public  FeasibilityQuestionByLangsGridView<FeasibilityQuestionEntityView,FeasibilityQuestionByLangView> GridView {get;set;}
    }
    public partial class FeasibilityQuestionByLangsGridView <FeasibilityQuestionEntityView,FeasibilityQuestionByLangView> :  RPSGridView<FeasibilityQuestionEntityView,FeasibilityQuestionByLangView> where FeasibilityQuestionEntityView : class, IView where FeasibilityQuestionByLangView : class, IView
    {
        public FeasibilityQuestionByLangsGridView(FeasibilityQuestionEntityView currentView,FeasibilityQuestionByLangView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            CodLanguage = RPSControlFactory.CreateRPSGridComboBox<FeasibilityQuestionEntityView>("","#6a08d84a-b250-4871-a412-0aabce8ad08c .ag-row[role='row']@ROWINDEX [col-id='cCodLanguage']","",true, this.CurrentView);
 
            Description = RPSControlFactory.CreateRPSGridTextBox<FeasibilityQuestionEntityView>("","#6a08d84a-b250-4871-a412-0aabce8ad08c .ag-row[role='row']@ROWINDEX [col-id='cDescription']","",false, this.CurrentView);
 

        }
        public IRPSGridComboBox<FeasibilityQuestionEntityView> CodLanguage { get; set; } 
        public IRPSGridTextBox<FeasibilityQuestionEntityView> Description { get; set; } 
                     
    }
 
    }
  
            
    public partial class FeasibilityQuestionByLangView : View
    {
        public FeasibilityQuestionByLangView(FeasibilityQuestion screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            DeleteButton = RPSControlFactory.RPSDeleteButton<FeasibilityQuestionByLangView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<FeasibilityQuestionByLangView,FeasibilityQuestionEntityView>( this,Screen.FeasibilityQuestionEntityView);
 
            BackButton = RPSControlFactory.RPSBackButton<FeasibilityQuestionByLangView,FeasibilityQuestionEntityView>( this,Screen.FeasibilityQuestionEntityView);
 
            AcceptButton = RPSControlFactory.RPSAcceptButton<FeasibilityQuestionByLangView,FeasibilityQuestionEntityView>( this,Screen.FeasibilityQuestionEntityView);
 
            CodLanguage = RPSControlFactory.CreateRPSComboBox<FeasibilityQuestionByLangView>("07160408-519d-4a97-a3bd-443fbad507a7","","",true, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<FeasibilityQuestionByLangView>("e2fb8275-d740-4f1c-8553-68709c6dce02","","",false, this);
 

        }
        public IRPSButton<FeasibilityQuestionByLangView> DeleteButton { get; set; } 
        public IRPSButton<FeasibilityQuestionByLangView,FeasibilityQuestionEntityView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<FeasibilityQuestionByLangView,FeasibilityQuestionEntityView> BackButton { get; set; } 
        public IRPSAcceptButton<FeasibilityQuestionByLangView,FeasibilityQuestionEntityView> AcceptButton { get; set; } 
        public IRPSComboBox<FeasibilityQuestionByLangView> CodLanguage { get; set; } 
        public IRPSTextBox<FeasibilityQuestionByLangView> Description { get; set; } 
        public FeasibilityQuestion Screen { get; set; }
        public FeasibilityQuestionByLangView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}