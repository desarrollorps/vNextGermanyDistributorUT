    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.Quality.Action
{
    //RPS VERSION 1.0.0.0
    public partial class Action:Screen
    {
        public Action():base()
        {
            this.URL = "quality.action";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            ActionCollectionView  = new ActionCollectionView(this); 
            ActionEntityView  = new ActionEntityView(this); 
            ActionByLangView  = new ActionByLangView(this); 
            ActionCollectionView.InitializeControls(); 
            ActionEntityView.InitializeControls(); 
            ActionByLangView.InitializeControls(); 
           
        }
      
            public ActionCollectionView ActionCollectionView {get; set; } 
            public ActionEntityView ActionEntityView {get; set; } 
            public ActionByLangView ActionByLangView {get; set; } 
    }
            
    public partial class ActionCollectionView : View
    {
        public ActionCollectionView(Action screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            NewButton = RPSControlFactory.RPSNewButton<ActionCollectionView,ActionEntityView>( this,Screen.ActionEntityView);
 
            CollectionInit params_MainConsult = new CollectionInit(){IDDescriptor = "24888aa9-32d7-4ba3-947e-0d7fecebb6cf",CSSSelectorDescriptor = "",XPathDescriptor = ""};
            MainConsult = RPSControlFactory.RPSCreateCollection<ActionCollectionView,ActionEntityView>( params_MainConsult,this,Screen.ActionEntityView);
 

        }
        public IRPSButton<ActionCollectionView,ActionEntityView> NewButton { get; set; } 
        public IRPSCollectionEditor<ActionCollectionView,ActionEntityView> MainConsult { get; set; } 
        public Action Screen { get; set; }
        public ActionCollectionView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class ActionEntityView : View
    {
        public ActionEntityView(Action screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            SaveButton = RPSControlFactory.RPSSaveButton<ActionEntityView>( this);
 
            DeleteButton = RPSControlFactory.RPSDeleteButton<ActionEntityView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<ActionEntityView,ActionCollectionView>( this,Screen.ActionCollectionView);
 
            BackButton = RPSControlFactory.RPSBackButton<ActionEntityView,ActionCollectionView>( this,Screen.ActionCollectionView);
 
            CodAction = RPSControlFactory.CreateRPSTextBox<ActionEntityView>("9fc57e67-c32b-4fd8-82ee-1f11b10c3c49","","",true, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<ActionEntityView>("c11e96db-6faa-4867-8a19-9db534601590","","",false, this);
 
            CollectionInit params_ActionByLangs = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="5f990ce2-148b-4978-a51f-3cbf68e3c41e",CSSSelectorGrid="",XPathGrid=""};
            ActionByLangs = RPSControlFactory.RPSCreateCollectionWithGrid<ActionByLangsCollectionEditor<ActionEntityView,ActionByLangView>,ActionEntityView,ActionByLangView>( params_ActionByLangs,this,Screen.ActionByLangView);
 

        }
        public IRPSSaveButton<ActionEntityView> SaveButton { get; set; } 
        public IRPSButton<ActionEntityView> DeleteButton { get; set; } 
        public IRPSButton<ActionEntityView,ActionCollectionView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<ActionEntityView,ActionCollectionView> BackButton { get; set; } 
        public IRPSTextBox<ActionEntityView> CodAction { get; set; } 
        public IRPSTextBox<ActionEntityView> Description { get; set; } 
        public ActionByLangsCollectionEditor<ActionEntityView,ActionByLangView> ActionByLangs { get; set; } 
        public Action Screen { get; set; }
        public ActionEntityView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class ActionByLangsCollectionEditor<ActionEntityView,ActionByLangView>:RPSCollectionEditor<ActionEntityView,ActionByLangView> where ActionEntityView : class, IView where ActionByLangView : class, IView
    {
        public  ActionByLangsGridView<ActionEntityView,ActionByLangView> GridView {get;set;}
    }
    public partial class ActionByLangsGridView <ActionEntityView,ActionByLangView> :  RPSGridView<ActionEntityView,ActionByLangView> where ActionEntityView : class, IView where ActionByLangView : class, IView
    {
        public ActionByLangsGridView(ActionEntityView currentView,ActionByLangView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            CodLanguage = RPSControlFactory.CreateRPSGridComboBox<ActionEntityView>("","#5f990ce2-148b-4978-a51f-3cbf68e3c41e .ag-row[role='row']@ROWINDEX [col-id='cCodLanguage']","",true, this.CurrentView);
 
            Description = RPSControlFactory.CreateRPSGridTextBox<ActionEntityView>("","#5f990ce2-148b-4978-a51f-3cbf68e3c41e .ag-row[role='row']@ROWINDEX [col-id='cDescription']","",false, this.CurrentView);
 

        }
        public IRPSGridComboBox<ActionEntityView> CodLanguage { get; set; } 
        public IRPSGridTextBox<ActionEntityView> Description { get; set; } 
                     
    }
 
    }
  
            
    public partial class ActionByLangView : View
    {
        public ActionByLangView(Action screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            DeleteButton = RPSControlFactory.RPSDeleteButton<ActionByLangView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<ActionByLangView,ActionEntityView>( this,Screen.ActionEntityView);
 
            BackButton = RPSControlFactory.RPSBackButton<ActionByLangView,ActionEntityView>( this,Screen.ActionEntityView);
 
            AcceptButton = RPSControlFactory.RPSAcceptButton<ActionByLangView,ActionEntityView>( this,Screen.ActionEntityView);
 
            CodLanguage = RPSControlFactory.CreateRPSComboBox<ActionByLangView>("29234641-a50a-4b71-b829-6c0821787265","","",true, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<ActionByLangView>("69303449-4285-4443-9095-c00257adf5f0","","",false, this);
 

        }
        public IRPSButton<ActionByLangView> DeleteButton { get; set; } 
        public IRPSButton<ActionByLangView,ActionEntityView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<ActionByLangView,ActionEntityView> BackButton { get; set; } 
        public IRPSAcceptButton<ActionByLangView,ActionEntityView> AcceptButton { get; set; } 
        public IRPSComboBox<ActionByLangView> CodLanguage { get; set; } 
        public IRPSTextBox<ActionByLangView> Description { get; set; } 
        public Action Screen { get; set; }
        public ActionByLangView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}