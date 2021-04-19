    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.Project.WarningType
{
    //RPS VERSION 1.0.0.0
    public partial class WarningType:Screen
    {
        public WarningType():base()
        {
            this.URL = "project.warningtype";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            WarningTypeCollectionView  = new WarningTypeCollectionView(this); 
            WarningTypeEntityView  = new WarningTypeEntityView(this); 
            WarningTypeCollectionView.InitializeControls(); 
            WarningTypeEntityView.InitializeControls(); 
           
        }
      
            public WarningTypeCollectionView WarningTypeCollectionView {get; set; } 
            public WarningTypeEntityView WarningTypeEntityView {get; set; } 
    }
            
    public partial class WarningTypeCollectionView : View
    {
        public WarningTypeCollectionView(WarningType screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            NewButton = RPSControlFactory.RPSNewButton<WarningTypeCollectionView,WarningTypeEntityView>( this,Screen.WarningTypeEntityView);
 
            CollectionInit params_MainConsult = new CollectionInit(){IDDescriptor = "9797eb9c-453b-4941-92f2-02131594c43f",CSSSelectorDescriptor = "",XPathDescriptor = ""};
            MainConsult = RPSControlFactory.RPSCreateCollection<WarningTypeCollectionView,WarningTypeEntityView>( params_MainConsult,this,Screen.WarningTypeEntityView);
 

        }
        public IRPSButton<WarningTypeCollectionView,WarningTypeEntityView> NewButton { get; set; } 
        public IRPSCollectionEditor<WarningTypeCollectionView,WarningTypeEntityView> MainConsult { get; set; } 
        public WarningType Screen { get; set; }
        public WarningTypeCollectionView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class WarningTypeEntityView : View
    {
        public WarningTypeEntityView(WarningType screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            SaveButton = RPSControlFactory.RPSSaveButton<WarningTypeEntityView>( this);
 
            DeleteButton = RPSControlFactory.RPSDeleteButton<WarningTypeEntityView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<WarningTypeEntityView,WarningTypeCollectionView>( this,Screen.WarningTypeCollectionView);
 
            BackButton = RPSControlFactory.RPSBackButton<WarningTypeEntityView,WarningTypeCollectionView>( this,Screen.WarningTypeCollectionView);
 
            CodWarningType = RPSControlFactory.CreateRPSTextBox<WarningTypeEntityView>("ac4418e2-544d-416c-8ef3-fc854653fc1b","","",true, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<WarningTypeEntityView>("0b8e3f52-2da8-447e-b034-529335fcb6c4","","",false, this);
 

        }
        public IRPSSaveButton<WarningTypeEntityView> SaveButton { get; set; } 
        public IRPSButton<WarningTypeEntityView> DeleteButton { get; set; } 
        public IRPSButton<WarningTypeEntityView,WarningTypeCollectionView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<WarningTypeEntityView,WarningTypeCollectionView> BackButton { get; set; } 
        public IRPSTextBox<WarningTypeEntityView> CodWarningType { get; set; } 
        public IRPSTextBox<WarningTypeEntityView> Description { get; set; } 
        public WarningType Screen { get; set; }
        public WarningTypeEntityView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}