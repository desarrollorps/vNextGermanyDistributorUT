    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.Manufacturing.RejectionCause
{
    //RPS VERSION 1.0.0.0
    public partial class RejectionCause:Screen
    {
        public RejectionCause():base()
        {
            this.URL = "manufacturing.rejectioncause";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            RejectionCauseCollectionView  = new RejectionCauseCollectionView(this); 
            RejectionCauseEntityView  = new RejectionCauseEntityView(this); 
            RejectionCauseCollectionView.InitializeControls(); 
            RejectionCauseEntityView.InitializeControls(); 
           
        }
      
            public RejectionCauseCollectionView RejectionCauseCollectionView {get; set; } 
            public RejectionCauseEntityView RejectionCauseEntityView {get; set; } 
    }
            
    public partial class RejectionCauseCollectionView : View
    {
        public RejectionCauseCollectionView(RejectionCause screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            NewButton = RPSControlFactory.RPSNewButton<RejectionCauseCollectionView,RejectionCauseEntityView>( this,Screen.RejectionCauseEntityView);
 
            CollectionInit params_MainConsult = new CollectionInit(){IDDescriptor = "577bab1d-1f15-4f1e-bcd2-dd57bf4783b5",CSSSelectorDescriptor = "",XPathDescriptor = ""};
            MainConsult = RPSControlFactory.RPSCreateCollection<RejectionCauseCollectionView,RejectionCauseEntityView>( params_MainConsult,this,Screen.RejectionCauseEntityView);
 

        }
        public IRPSButton<RejectionCauseCollectionView,RejectionCauseEntityView> NewButton { get; set; } 
        public IRPSCollectionEditor<RejectionCauseCollectionView,RejectionCauseEntityView> MainConsult { get; set; } 
        public RejectionCause Screen { get; set; }
        public RejectionCauseCollectionView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class RejectionCauseEntityView : View
    {
        public RejectionCauseEntityView(RejectionCause screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            SaveButton = RPSControlFactory.RPSSaveButton<RejectionCauseEntityView>( this);
 
            DeleteButton = RPSControlFactory.RPSDeleteButton<RejectionCauseEntityView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<RejectionCauseEntityView,RejectionCauseCollectionView>( this,Screen.RejectionCauseCollectionView);
 
            BackButton = RPSControlFactory.RPSBackButton<RejectionCauseEntityView,RejectionCauseCollectionView>( this,Screen.RejectionCauseCollectionView);
 
            CodRejectionCause = RPSControlFactory.CreateRPSTextBox<RejectionCauseEntityView>("d86bce75-667c-418b-9a38-bbc915e6fc8c","","",true, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<RejectionCauseEntityView>("a5d78d4b-1846-4a1f-82a6-dc0557ed5409","","",false, this);
 

        }
        public IRPSSaveButton<RejectionCauseEntityView> SaveButton { get; set; } 
        public IRPSButton<RejectionCauseEntityView> DeleteButton { get; set; } 
        public IRPSButton<RejectionCauseEntityView,RejectionCauseCollectionView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<RejectionCauseEntityView,RejectionCauseCollectionView> BackButton { get; set; } 
        public IRPSTextBox<RejectionCauseEntityView> CodRejectionCause { get; set; } 
        public IRPSTextBox<RejectionCauseEntityView> Description { get; set; } 
        public RejectionCause Screen { get; set; }
        public RejectionCauseEntityView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}