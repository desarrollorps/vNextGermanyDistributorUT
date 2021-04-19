    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.ReceivablePayable.UnpaidCause
{
    //RPS VERSION 1.0.0.0
    public partial class UnpaidCause:Screen
    {
        public UnpaidCause():base()
        {
            this.URL = "receivablepayable.unpaidcause";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            UnpaidCauseCollectionView  = new UnpaidCauseCollectionView(this); 
            UnpaidCauseEntityView  = new UnpaidCauseEntityView(this); 
            UnpaidCauseCollectionView.InitializeControls(); 
            UnpaidCauseEntityView.InitializeControls(); 
           
        }
      
            public UnpaidCauseCollectionView UnpaidCauseCollectionView {get; set; } 
            public UnpaidCauseEntityView UnpaidCauseEntityView {get; set; } 
    }
            
    public partial class UnpaidCauseCollectionView : View
    {
        public UnpaidCauseCollectionView(UnpaidCause screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            NewButton = RPSControlFactory.RPSNewButton<UnpaidCauseCollectionView,UnpaidCauseEntityView>( this,Screen.UnpaidCauseEntityView);
 
            CollectionInit params_MainConsult = new CollectionInit(){IDDescriptor = "1ad9128d-8bd6-4fdc-880a-ebb09a6263c9",CSSSelectorDescriptor = "",XPathDescriptor = ""};
            MainConsult = RPSControlFactory.RPSCreateCollection<UnpaidCauseCollectionView,UnpaidCauseEntityView>( params_MainConsult,this,Screen.UnpaidCauseEntityView);
 

        }
        public IRPSButton<UnpaidCauseCollectionView,UnpaidCauseEntityView> NewButton { get; set; } 
        public IRPSCollectionEditor<UnpaidCauseCollectionView,UnpaidCauseEntityView> MainConsult { get; set; } 
        public UnpaidCause Screen { get; set; }
        public UnpaidCauseCollectionView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class UnpaidCauseEntityView : View
    {
        public UnpaidCauseEntityView(UnpaidCause screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            SaveButton = RPSControlFactory.RPSSaveButton<UnpaidCauseEntityView>( this);
 
            DeleteButton = RPSControlFactory.RPSDeleteButton<UnpaidCauseEntityView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<UnpaidCauseEntityView,UnpaidCauseCollectionView>( this,Screen.UnpaidCauseCollectionView);
 
            BackButton = RPSControlFactory.RPSBackButton<UnpaidCauseEntityView,UnpaidCauseCollectionView>( this,Screen.UnpaidCauseCollectionView);
 
            CodUnpaidCause = RPSControlFactory.CreateRPSTextBox<UnpaidCauseEntityView>("983b76b9-a5b8-418c-802a-75bdab0d20ec","","",true, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<UnpaidCauseEntityView>("04ebd97c-d10f-443f-82ce-81f0fecccc53","","",false, this);
 

        }
        public IRPSSaveButton<UnpaidCauseEntityView> SaveButton { get; set; } 
        public IRPSButton<UnpaidCauseEntityView> DeleteButton { get; set; } 
        public IRPSButton<UnpaidCauseEntityView,UnpaidCauseCollectionView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<UnpaidCauseEntityView,UnpaidCauseCollectionView> BackButton { get; set; } 
        public IRPSTextBox<UnpaidCauseEntityView> CodUnpaidCause { get; set; } 
        public IRPSTextBox<UnpaidCauseEntityView> Description { get; set; } 
        public UnpaidCause Screen { get; set; }
        public UnpaidCauseEntityView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}