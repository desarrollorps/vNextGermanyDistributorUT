    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.General.PendingActivities
{
    //RPS VERSION 1.0.0.0
    public partial class PendingActivities:Screen
    {
        public PendingActivities():base()
        {
            this.URL = "general.pendingactivities";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            PendingActivitiesView  = new PendingActivitiesView(this); 
            PendingActivitiesChildView  = new PendingActivitiesChildView(this); 
            PendingActivitiesView.InitializeControls(); 
            PendingActivitiesChildView.InitializeControls(); 
           
        }
      
            public PendingActivitiesView PendingActivitiesView {get; set; } 
            public PendingActivitiesChildView PendingActivitiesChildView {get; set; } 
    }
            
    public partial class PendingActivitiesView : View
    {
        public PendingActivitiesView(PendingActivities screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            Section = RPSControlFactory.CreateRPSSection<PendingActivitiesView>( "","ul li[rpsid='2eeaa2f4-329a-4f22-9141-94b80a50237f']","",this);
 

        }
        public IRPSSection<PendingActivitiesView> Section { get; set; } 
        public PendingActivities Screen { get; set; }
        public PendingActivitiesView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class PendingActivitiesChildView : View
    {
        public PendingActivitiesChildView(PendingActivities screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            CollectionInit params_NotificationsConsult = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = ""};
            NotificationsConsult = RPSControlFactory.RPSCreateCollection<PendingActivitiesChildView>( params_NotificationsConsult,this);
 

        }
        public IRPSCollectionEditor<PendingActivitiesChildView> NotificationsConsult { get; set; } 
        public PendingActivities Screen { get; set; }
        public PendingActivitiesChildView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}