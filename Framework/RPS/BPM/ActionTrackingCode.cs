    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.BPM.ActionTrackingCode
{
    //RPS VERSION 1.0.0.0
    public partial class ActionTrackingCode:Screen
    {
        public ActionTrackingCode():base()
        {
            this.URL = "bpm.actiontrackingcode";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            ActionTrackingCodeCollectionView  = new ActionTrackingCodeCollectionView(this); 
            ActionTrackingCodeEntityView  = new ActionTrackingCodeEntityView(this); 
            ActionTrackingCodeCollectionView.InitializeControls(); 
            ActionTrackingCodeEntityView.InitializeControls(); 
           
        }
      
            public ActionTrackingCodeCollectionView ActionTrackingCodeCollectionView {get; set; } 
            public ActionTrackingCodeEntityView ActionTrackingCodeEntityView {get; set; } 
    }
            
    public partial class ActionTrackingCodeCollectionView : View
    {
        public ActionTrackingCodeCollectionView(ActionTrackingCode screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            NewButton = RPSControlFactory.RPSNewButton<ActionTrackingCodeCollectionView,ActionTrackingCodeEntityView>( this,Screen.ActionTrackingCodeEntityView);
 
            CollectionInit params_MainConsult = new CollectionInit(){IDDescriptor = "66f9c4a1-f9d3-4152-bcc2-a66f8ca21176",CSSSelectorDescriptor = "",XPathDescriptor = ""};
            MainConsult = RPSControlFactory.RPSCreateCollection<ActionTrackingCodeCollectionView,ActionTrackingCodeEntityView>( params_MainConsult,this,Screen.ActionTrackingCodeEntityView);
 

        }
        public IRPSButton<ActionTrackingCodeCollectionView,ActionTrackingCodeEntityView> NewButton { get; set; } 
        public IRPSCollectionEditor<ActionTrackingCodeCollectionView,ActionTrackingCodeEntityView> MainConsult { get; set; } 
        public ActionTrackingCode Screen { get; set; }
        public ActionTrackingCodeCollectionView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class ActionTrackingCodeEntityView : View
    {
        public ActionTrackingCodeEntityView(ActionTrackingCode screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            SaveButton = RPSControlFactory.RPSSaveButton<ActionTrackingCodeEntityView>( this);
 
            DeleteButton = RPSControlFactory.RPSDeleteButton<ActionTrackingCodeEntityView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<ActionTrackingCodeEntityView,ActionTrackingCodeCollectionView>( this,Screen.ActionTrackingCodeCollectionView);
 
            BackButton = RPSControlFactory.RPSBackButton<ActionTrackingCodeEntityView,ActionTrackingCodeCollectionView>( this,Screen.ActionTrackingCodeCollectionView);
 
            CodActionTrackingCode = RPSControlFactory.CreateRPSTextBox<ActionTrackingCodeEntityView>("fafe918f-9229-4fc8-b3d0-d86804dab3eb","","",true, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<ActionTrackingCodeEntityView>("396b3a77-75bb-4044-a3a5-9b54dfcf20a4","","",true, this);
 

        }
        public IRPSSaveButton<ActionTrackingCodeEntityView> SaveButton { get; set; } 
        public IRPSButton<ActionTrackingCodeEntityView> DeleteButton { get; set; } 
        public IRPSButton<ActionTrackingCodeEntityView,ActionTrackingCodeCollectionView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<ActionTrackingCodeEntityView,ActionTrackingCodeCollectionView> BackButton { get; set; } 
        public IRPSTextBox<ActionTrackingCodeEntityView> CodActionTrackingCode { get; set; } 
        public IRPSTextBox<ActionTrackingCodeEntityView> Description { get; set; } 
        public ActionTrackingCode Screen { get; set; }
        public ActionTrackingCodeEntityView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}