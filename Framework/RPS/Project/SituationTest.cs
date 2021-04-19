    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.Project.SituationTest
{
    //RPS VERSION 1.0.0.0
    public partial class SituationTest:Screen
    {
        public SituationTest():base()
        {
            this.URL = "project.situationtest";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            SituationTestCollectionView  = new SituationTestCollectionView(this); 
            SituationTestEntityView  = new SituationTestEntityView(this); 
            SituationTestCollectionView.InitializeControls(); 
            SituationTestEntityView.InitializeControls(); 
           
        }
      
            public SituationTestCollectionView SituationTestCollectionView {get; set; } 
            public SituationTestEntityView SituationTestEntityView {get; set; } 
    }
            
    public partial class SituationTestCollectionView : View
    {
        public SituationTestCollectionView(SituationTest screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            NewButton = RPSControlFactory.RPSNewButton<SituationTestCollectionView,SituationTestEntityView>( this,Screen.SituationTestEntityView);
 
            CollectionInit params_MainConsult = new CollectionInit(){IDDescriptor = "e3d7c5d1-140f-40ad-9624-828051420ea2",CSSSelectorDescriptor = "",XPathDescriptor = ""};
            MainConsult = RPSControlFactory.RPSCreateCollection<SituationTestCollectionView,SituationTestEntityView>( params_MainConsult,this,Screen.SituationTestEntityView);
 

        }
        public IRPSButton<SituationTestCollectionView,SituationTestEntityView> NewButton { get; set; } 
        public IRPSCollectionEditor<SituationTestCollectionView,SituationTestEntityView> MainConsult { get; set; } 
        public SituationTest Screen { get; set; }
        public SituationTestCollectionView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class SituationTestEntityView : View
    {
        public SituationTestEntityView(SituationTest screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            SaveButton = RPSControlFactory.RPSSaveButton<SituationTestEntityView>( this);
 
            DeleteButton = RPSControlFactory.RPSDeleteButton<SituationTestEntityView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<SituationTestEntityView,SituationTestCollectionView>( this,Screen.SituationTestCollectionView);
 
            BackButton = RPSControlFactory.RPSBackButton<SituationTestEntityView,SituationTestCollectionView>( this,Screen.SituationTestCollectionView);
 
            CodSituationTest = RPSControlFactory.CreateRPSTextBox<SituationTestEntityView>("ff53440a-7b57-45a8-9864-8aa67d7ef28b","","",true, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<SituationTestEntityView>("0b467225-3ed6-4e47-a2dc-db89d0b7d8c2","","",false, this);
 

        }
        public IRPSSaveButton<SituationTestEntityView> SaveButton { get; set; } 
        public IRPSButton<SituationTestEntityView> DeleteButton { get; set; } 
        public IRPSButton<SituationTestEntityView,SituationTestCollectionView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<SituationTestEntityView,SituationTestCollectionView> BackButton { get; set; } 
        public IRPSTextBox<SituationTestEntityView> CodSituationTest { get; set; } 
        public IRPSTextBox<SituationTestEntityView> Description { get; set; } 
        public SituationTest Screen { get; set; }
        public SituationTestEntityView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}