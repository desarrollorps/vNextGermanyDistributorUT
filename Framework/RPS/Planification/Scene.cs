    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.Planification.Scene
{
    //RPS VERSION 1.0.0.0
    public partial class Scene:Screen
    {
        public Scene():base()
        {
            this.URL = "planification.scene";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            SceneCollectionView  = new SceneCollectionView(this); 
            SceneEntityView  = new SceneEntityView(this); 
            SceneCollectionView.InitializeControls(); 
            SceneEntityView.InitializeControls(); 
           
        }
      
            public SceneCollectionView SceneCollectionView {get; set; } 
            public SceneEntityView SceneEntityView {get; set; } 
    }
            
    public partial class SceneCollectionView : View
    {
        public SceneCollectionView(Scene screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            NewButton = RPSControlFactory.RPSNewButton<SceneCollectionView,SceneEntityView>( this,Screen.SceneEntityView);
 
            CollectionInit params_MainConsult = new CollectionInit(){IDDescriptor = "aa83107c-94cd-44aa-95fb-cd6d843eef66",CSSSelectorDescriptor = "",XPathDescriptor = ""};
            MainConsult = RPSControlFactory.RPSCreateCollection<SceneCollectionView,SceneEntityView>( params_MainConsult,this,Screen.SceneEntityView);
 

        }
        public IRPSButton<SceneCollectionView,SceneEntityView> NewButton { get; set; } 
        public IRPSCollectionEditor<SceneCollectionView,SceneEntityView> MainConsult { get; set; } 
        public Scene Screen { get; set; }
        public SceneCollectionView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class SceneEntityView : View
    {
        public SceneEntityView(Scene screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            SaveButton = RPSControlFactory.RPSSaveButton<SceneEntityView>( this);
 
            DeleteButton = RPSControlFactory.RPSDeleteButton<SceneEntityView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<SceneEntityView,SceneCollectionView>( this,Screen.SceneCollectionView);
 
            BackButton = RPSControlFactory.RPSBackButton<SceneEntityView,SceneCollectionView>( this,Screen.SceneCollectionView);
 
            CodScene = RPSControlFactory.CreateRPSTextBox<SceneEntityView>("2c8819ea-600b-402e-9fde-03623a0748b6","","",true, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<SceneEntityView>("9c4d3bb0-44e9-449f-98ad-c9df82ea123c","","",false, this);
 

        }
        public IRPSSaveButton<SceneEntityView> SaveButton { get; set; } 
        public IRPSButton<SceneEntityView> DeleteButton { get; set; } 
        public IRPSButton<SceneEntityView,SceneCollectionView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<SceneEntityView,SceneCollectionView> BackButton { get; set; } 
        public IRPSTextBox<SceneEntityView> CodScene { get; set; } 
        public IRPSTextBox<SceneEntityView> Description { get; set; } 
        public Scene Screen { get; set; }
        public SceneEntityView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}