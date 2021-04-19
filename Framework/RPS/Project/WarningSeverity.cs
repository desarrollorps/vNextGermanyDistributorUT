    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.Project.WarningSeverity
{
    //RPS VERSION 1.0.0.0
    public partial class WarningSeverity:Screen
    {
        public WarningSeverity():base()
        {
            this.URL = "project.warningseverity";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            WarningSeverityCollectionView  = new WarningSeverityCollectionView(this); 
            WarningSeverityEntityView  = new WarningSeverityEntityView(this); 
            WarningSeverityCollectionView.InitializeControls(); 
            WarningSeverityEntityView.InitializeControls(); 
           
        }
      
            public WarningSeverityCollectionView WarningSeverityCollectionView {get; set; } 
            public WarningSeverityEntityView WarningSeverityEntityView {get; set; } 
    }
            
    public partial class WarningSeverityCollectionView : View
    {
        public WarningSeverityCollectionView(WarningSeverity screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            NewButton = RPSControlFactory.RPSNewButton<WarningSeverityCollectionView,WarningSeverityEntityView>( this,Screen.WarningSeverityEntityView);
 
            CollectionInit params_MainConsult = new CollectionInit(){IDDescriptor = "00dd9300-a692-49d2-8fa4-d54bf9af91d0",CSSSelectorDescriptor = "",XPathDescriptor = ""};
            MainConsult = RPSControlFactory.RPSCreateCollection<WarningSeverityCollectionView,WarningSeverityEntityView>( params_MainConsult,this,Screen.WarningSeverityEntityView);
 

        }
        public IRPSButton<WarningSeverityCollectionView,WarningSeverityEntityView> NewButton { get; set; } 
        public IRPSCollectionEditor<WarningSeverityCollectionView,WarningSeverityEntityView> MainConsult { get; set; } 
        public WarningSeverity Screen { get; set; }
        public WarningSeverityCollectionView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class WarningSeverityEntityView : View
    {
        public WarningSeverityEntityView(WarningSeverity screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            SaveButton = RPSControlFactory.RPSSaveButton<WarningSeverityEntityView>( this);
 
            DeleteButton = RPSControlFactory.RPSDeleteButton<WarningSeverityEntityView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<WarningSeverityEntityView,WarningSeverityCollectionView>( this,Screen.WarningSeverityCollectionView);
 
            BackButton = RPSControlFactory.RPSBackButton<WarningSeverityEntityView,WarningSeverityCollectionView>( this,Screen.WarningSeverityCollectionView);
 
            CodWarningSeverity = RPSControlFactory.CreateRPSTextBox<WarningSeverityEntityView>("19d38d89-f604-4a5b-9c37-c4a0fc62257b","","",true, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<WarningSeverityEntityView>("b7a5f389-f738-4b85-8804-abb40ee31863","","",false, this);
 

        }
        public IRPSSaveButton<WarningSeverityEntityView> SaveButton { get; set; } 
        public IRPSButton<WarningSeverityEntityView> DeleteButton { get; set; } 
        public IRPSButton<WarningSeverityEntityView,WarningSeverityCollectionView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<WarningSeverityEntityView,WarningSeverityCollectionView> BackButton { get; set; } 
        public IRPSTextBox<WarningSeverityEntityView> CodWarningSeverity { get; set; } 
        public IRPSTextBox<WarningSeverityEntityView> Description { get; set; } 
        public WarningSeverity Screen { get; set; }
        public WarningSeverityEntityView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}