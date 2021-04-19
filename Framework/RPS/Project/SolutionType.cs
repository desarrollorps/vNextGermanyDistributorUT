    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.Project.SolutionType
{
    //RPS VERSION 1.0.0.0
    public partial class SolutionType:Screen
    {
        public SolutionType():base()
        {
            this.URL = "project.solutiontype";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            SolutionTypeCollectionView  = new SolutionTypeCollectionView(this); 
            SolutionTypeEntityView  = new SolutionTypeEntityView(this); 
            SolutionTypeCollectionView.InitializeControls(); 
            SolutionTypeEntityView.InitializeControls(); 
           
        }
      
            public SolutionTypeCollectionView SolutionTypeCollectionView {get; set; } 
            public SolutionTypeEntityView SolutionTypeEntityView {get; set; } 
    }
            
    public partial class SolutionTypeCollectionView : View
    {
        public SolutionTypeCollectionView(SolutionType screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            NewButton = RPSControlFactory.RPSNewButton<SolutionTypeCollectionView,SolutionTypeEntityView>( this,Screen.SolutionTypeEntityView);
 
            CollectionInit params_MainConsult = new CollectionInit(){IDDescriptor = "e5d4609f-efbf-49fa-a51a-3c1f4740047b",CSSSelectorDescriptor = "",XPathDescriptor = ""};
            MainConsult = RPSControlFactory.RPSCreateCollection<SolutionTypeCollectionView,SolutionTypeEntityView>( params_MainConsult,this,Screen.SolutionTypeEntityView);
 

        }
        public IRPSButton<SolutionTypeCollectionView,SolutionTypeEntityView> NewButton { get; set; } 
        public IRPSCollectionEditor<SolutionTypeCollectionView,SolutionTypeEntityView> MainConsult { get; set; } 
        public SolutionType Screen { get; set; }
        public SolutionTypeCollectionView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class SolutionTypeEntityView : View
    {
        public SolutionTypeEntityView(SolutionType screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            SaveButton = RPSControlFactory.RPSSaveButton<SolutionTypeEntityView>( this);
 
            DeleteButton = RPSControlFactory.RPSDeleteButton<SolutionTypeEntityView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<SolutionTypeEntityView,SolutionTypeCollectionView>( this,Screen.SolutionTypeCollectionView);
 
            BackButton = RPSControlFactory.RPSBackButton<SolutionTypeEntityView,SolutionTypeCollectionView>( this,Screen.SolutionTypeCollectionView);
 
            CodSolutionType = RPSControlFactory.CreateRPSTextBox<SolutionTypeEntityView>("64abb12c-6e39-49ff-ade2-7949a09fcba8","","",true, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<SolutionTypeEntityView>("c0138349-f0bb-4c7e-bf6d-c39310d0e12e","","",false, this);
 

        }
        public IRPSSaveButton<SolutionTypeEntityView> SaveButton { get; set; } 
        public IRPSButton<SolutionTypeEntityView> DeleteButton { get; set; } 
        public IRPSButton<SolutionTypeEntityView,SolutionTypeCollectionView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<SolutionTypeEntityView,SolutionTypeCollectionView> BackButton { get; set; } 
        public IRPSTextBox<SolutionTypeEntityView> CodSolutionType { get; set; } 
        public IRPSTextBox<SolutionTypeEntityView> Description { get; set; } 
        public SolutionType Screen { get; set; }
        public SolutionTypeEntityView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}