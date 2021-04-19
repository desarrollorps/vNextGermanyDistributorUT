    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.Project.ProjectType
{
    //RPS VERSION 1.0.0.0
    public partial class ProjectType:Screen
    {
        public ProjectType():base()
        {
            this.URL = "project.projecttype";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            ProjectTypeCollectionView  = new ProjectTypeCollectionView(this); 
            ProjectTypeEntityView  = new ProjectTypeEntityView(this); 
            ProjectTypeCollectionView.InitializeControls(); 
            ProjectTypeEntityView.InitializeControls(); 
           
        }
      
            public ProjectTypeCollectionView ProjectTypeCollectionView {get; set; } 
            public ProjectTypeEntityView ProjectTypeEntityView {get; set; } 
    }
            
    public partial class ProjectTypeCollectionView : View
    {
        public ProjectTypeCollectionView(ProjectType screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            NewButton = RPSControlFactory.RPSNewButton<ProjectTypeCollectionView,ProjectTypeEntityView>( this,Screen.ProjectTypeEntityView);
 
            CollectionInit params_MainConsult = new CollectionInit(){IDDescriptor = "bfe8cdc5-1e20-405e-aae0-ea7c69240733",CSSSelectorDescriptor = "",XPathDescriptor = ""};
            MainConsult = RPSControlFactory.RPSCreateCollection<ProjectTypeCollectionView,ProjectTypeEntityView>( params_MainConsult,this,Screen.ProjectTypeEntityView);
 

        }
        public IRPSButton<ProjectTypeCollectionView,ProjectTypeEntityView> NewButton { get; set; } 
        public IRPSCollectionEditor<ProjectTypeCollectionView,ProjectTypeEntityView> MainConsult { get; set; } 
        public ProjectType Screen { get; set; }
        public ProjectTypeCollectionView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class ProjectTypeEntityView : View
    {
        public ProjectTypeEntityView(ProjectType screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            SaveButton = RPSControlFactory.RPSSaveButton<ProjectTypeEntityView>( this);
 
            DeleteButton = RPSControlFactory.RPSDeleteButton<ProjectTypeEntityView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<ProjectTypeEntityView,ProjectTypeCollectionView>( this,Screen.ProjectTypeCollectionView);
 
            BackButton = RPSControlFactory.RPSBackButton<ProjectTypeEntityView,ProjectTypeCollectionView>( this,Screen.ProjectTypeCollectionView);
 
            CodProjectType = RPSControlFactory.CreateRPSTextBox<ProjectTypeEntityView>("98f569fe-c5cc-41c6-a06f-ea1fe50cbb4e","","",true, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<ProjectTypeEntityView>("53cb1e51-a477-4e37-b219-c15b012adf74","","",false, this);
 

        }
        public IRPSSaveButton<ProjectTypeEntityView> SaveButton { get; set; } 
        public IRPSButton<ProjectTypeEntityView> DeleteButton { get; set; } 
        public IRPSButton<ProjectTypeEntityView,ProjectTypeCollectionView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<ProjectTypeEntityView,ProjectTypeCollectionView> BackButton { get; set; } 
        public IRPSTextBox<ProjectTypeEntityView> CodProjectType { get; set; } 
        public IRPSTextBox<ProjectTypeEntityView> Description { get; set; } 
        public ProjectType Screen { get; set; }
        public ProjectTypeEntityView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}