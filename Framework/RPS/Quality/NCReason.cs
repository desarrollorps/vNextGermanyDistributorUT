    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.Quality.NCReason
{
    //RPS VERSION 1.0.0.0
    public partial class NCReason:Screen
    {
        public NCReason():base()
        {
            this.URL = "quality.ncreason";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            NCReasonCollectionView  = new NCReasonCollectionView(this); 
            NCReasonEntityView  = new NCReasonEntityView(this); 
            NCReasonCollectionView.InitializeControls(); 
            NCReasonEntityView.InitializeControls(); 
           
        }
      
            public NCReasonCollectionView NCReasonCollectionView {get; set; } 
            public NCReasonEntityView NCReasonEntityView {get; set; } 
    }
            
    public partial class NCReasonCollectionView : View
    {
        public NCReasonCollectionView(NCReason screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            NewButton = RPSControlFactory.RPSNewButton<NCReasonCollectionView,NCReasonEntityView>( this,Screen.NCReasonEntityView);
 
            CollectionInit params_MainConsult = new CollectionInit(){IDDescriptor = "41fd097b-0567-45c7-9d2a-efe6454742eb",CSSSelectorDescriptor = "",XPathDescriptor = ""};
            MainConsult = RPSControlFactory.RPSCreateCollection<NCReasonCollectionView,NCReasonEntityView>( params_MainConsult,this,Screen.NCReasonEntityView);
 

        }
        public IRPSButton<NCReasonCollectionView,NCReasonEntityView> NewButton { get; set; } 
        public IRPSCollectionEditor<NCReasonCollectionView,NCReasonEntityView> MainConsult { get; set; } 
        public NCReason Screen { get; set; }
        public NCReasonCollectionView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class NCReasonEntityView : View
    {
        public NCReasonEntityView(NCReason screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            SaveButton = RPSControlFactory.RPSSaveButton<NCReasonEntityView>( this);
 
            DeleteButton = RPSControlFactory.RPSDeleteButton<NCReasonEntityView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<NCReasonEntityView,NCReasonCollectionView>( this,Screen.NCReasonCollectionView);
 
            BackButton = RPSControlFactory.RPSBackButton<NCReasonEntityView,NCReasonCollectionView>( this,Screen.NCReasonCollectionView);
 
            CodNCReason = RPSControlFactory.CreateRPSTextBox<NCReasonEntityView>("d5c4915c-dd99-4a5e-a170-074d52be95e8","","",true, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<NCReasonEntityView>("249b4dab-8b68-4921-8c2e-86c2b5890d43","","",false, this);
 

        }
        public IRPSSaveButton<NCReasonEntityView> SaveButton { get; set; } 
        public IRPSButton<NCReasonEntityView> DeleteButton { get; set; } 
        public IRPSButton<NCReasonEntityView,NCReasonCollectionView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<NCReasonEntityView,NCReasonCollectionView> BackButton { get; set; } 
        public IRPSTextBox<NCReasonEntityView> CodNCReason { get; set; } 
        public IRPSTextBox<NCReasonEntityView> Description { get; set; } 
        public NCReason Screen { get; set; }
        public NCReasonEntityView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}