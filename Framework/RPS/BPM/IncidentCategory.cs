    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.BPM.IncidentCategory
{
    //RPS VERSION 1.0.0.0
    public partial class IncidentCategory:Screen
    {
        public IncidentCategory():base()
        {
            this.URL = "bpm.incidentcategory";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            IncidentCategoryCollectionView  = new IncidentCategoryCollectionView(this); 
            IncidentCategoryEntityView  = new IncidentCategoryEntityView(this); 
            IncidentCategoryCollectionView.InitializeControls(); 
            IncidentCategoryEntityView.InitializeControls(); 
           
        }
      
            public IncidentCategoryCollectionView IncidentCategoryCollectionView {get; set; } 
            public IncidentCategoryEntityView IncidentCategoryEntityView {get; set; } 
    }
            
    public partial class IncidentCategoryCollectionView : View
    {
        public IncidentCategoryCollectionView(IncidentCategory screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            NewButton = RPSControlFactory.RPSNewButton<IncidentCategoryCollectionView,IncidentCategoryEntityView>( this,Screen.IncidentCategoryEntityView);
 
            CollectionInit params_MainConsult = new CollectionInit(){IDDescriptor = "6d9f3a1b-28d6-49db-8af2-7411ea6a923f",CSSSelectorDescriptor = "",XPathDescriptor = ""};
            MainConsult = RPSControlFactory.RPSCreateCollection<IncidentCategoryCollectionView,IncidentCategoryEntityView>( params_MainConsult,this,Screen.IncidentCategoryEntityView);
 

        }
        public IRPSButton<IncidentCategoryCollectionView,IncidentCategoryEntityView> NewButton { get; set; } 
        public IRPSCollectionEditor<IncidentCategoryCollectionView,IncidentCategoryEntityView> MainConsult { get; set; } 
        public IncidentCategory Screen { get; set; }
        public IncidentCategoryCollectionView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class IncidentCategoryEntityView : View
    {
        public IncidentCategoryEntityView(IncidentCategory screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            SaveButton = RPSControlFactory.RPSSaveButton<IncidentCategoryEntityView>( this);
 
            DeleteButton = RPSControlFactory.RPSDeleteButton<IncidentCategoryEntityView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<IncidentCategoryEntityView,IncidentCategoryCollectionView>( this,Screen.IncidentCategoryCollectionView);
 
            BackButton = RPSControlFactory.RPSBackButton<IncidentCategoryEntityView,IncidentCategoryCollectionView>( this,Screen.IncidentCategoryCollectionView);
 
            CodIncidentCategory = RPSControlFactory.CreateRPSTextBox<IncidentCategoryEntityView>("a9ce730a-18e9-401a-b792-2dffacbc7337","","",true, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<IncidentCategoryEntityView>("6a40e195-e099-4524-8beb-6b53b8df8d3f","","",false, this);
 

        }
        public IRPSSaveButton<IncidentCategoryEntityView> SaveButton { get; set; } 
        public IRPSButton<IncidentCategoryEntityView> DeleteButton { get; set; } 
        public IRPSButton<IncidentCategoryEntityView,IncidentCategoryCollectionView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<IncidentCategoryEntityView,IncidentCategoryCollectionView> BackButton { get; set; } 
        public IRPSTextBox<IncidentCategoryEntityView> CodIncidentCategory { get; set; } 
        public IRPSTextBox<IncidentCategoryEntityView> Description { get; set; } 
        public IncidentCategory Screen { get; set; }
        public IncidentCategoryEntityView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}