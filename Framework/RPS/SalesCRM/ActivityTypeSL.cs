    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.SalesCRM.ActivityTypeSL
{
    //RPS VERSION 1.0.0.0
    public partial class ActivityTypeSL:Screen
    {
        public ActivityTypeSL():base()
        {
            this.URL = "salescrm.activitytypesl";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            ActivityTypeSLQueryView  = new ActivityTypeSLQueryView(this); 
            ActivityTypeSLEntityView  = new ActivityTypeSLEntityView(this); 
            ActivityTypeSLQueryView.InitializeControls(); 
            ActivityTypeSLEntityView.InitializeControls(); 
           
        }
      
            public ActivityTypeSLQueryView ActivityTypeSLQueryView {get; set; } 
            public ActivityTypeSLEntityView ActivityTypeSLEntityView {get; set; } 
    }
            
    public partial class ActivityTypeSLQueryView : View
    {
        public ActivityTypeSLQueryView(ActivityTypeSL screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            NewButton = RPSControlFactory.RPSNewButton<ActivityTypeSLQueryView,ActivityTypeSLEntityView>( this,Screen.ActivityTypeSLEntityView);
 
            CollectionInit params_MainConsult = new CollectionInit(){IDDescriptor = "5961d10b-b53a-448f-a71f-a758b6fb487a",CSSSelectorDescriptor = "",XPathDescriptor = ""};
            MainConsult = RPSControlFactory.RPSCreateCollection<ActivityTypeSLQueryView,ActivityTypeSLEntityView>( params_MainConsult,this,Screen.ActivityTypeSLEntityView);
 

        }
        public IRPSButton<ActivityTypeSLQueryView,ActivityTypeSLEntityView> NewButton { get; set; } 
        public IRPSCollectionEditor<ActivityTypeSLQueryView,ActivityTypeSLEntityView> MainConsult { get; set; } 
        public ActivityTypeSL Screen { get; set; }
        public ActivityTypeSLQueryView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class ActivityTypeSLEntityView : View
    {
        public ActivityTypeSLEntityView(ActivityTypeSL screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            SaveButton = RPSControlFactory.RPSSaveButton<ActivityTypeSLEntityView>( this);
 
            DeleteButton = RPSControlFactory.RPSDeleteButton<ActivityTypeSLEntityView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<ActivityTypeSLEntityView,ActivityTypeSLQueryView>( this,Screen.ActivityTypeSLQueryView);
 
            BackButton = RPSControlFactory.RPSBackButton<ActivityTypeSLEntityView,ActivityTypeSLQueryView>( this,Screen.ActivityTypeSLQueryView);
 
            CodActivityType = RPSControlFactory.CreateRPSTextBox<ActivityTypeSLEntityView>("b182357a-a575-4444-a3c1-3a764989dc82","","",true, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<ActivityTypeSLEntityView>("216b2e37-94e3-4937-87af-4779dd847bed","","",false, this);
 

        }
        public IRPSSaveButton<ActivityTypeSLEntityView> SaveButton { get; set; } 
        public IRPSButton<ActivityTypeSLEntityView> DeleteButton { get; set; } 
        public IRPSButton<ActivityTypeSLEntityView,ActivityTypeSLQueryView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<ActivityTypeSLEntityView,ActivityTypeSLQueryView> BackButton { get; set; } 
        public IRPSTextBox<ActivityTypeSLEntityView> CodActivityType { get; set; } 
        public IRPSTextBox<ActivityTypeSLEntityView> Description { get; set; } 
        public ActivityTypeSL Screen { get; set; }
        public ActivityTypeSLEntityView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}