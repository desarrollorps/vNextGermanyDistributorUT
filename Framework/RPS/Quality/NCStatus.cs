    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.Quality.NCStatus
{
    //RPS VERSION 1.0.0.0
    public partial class NCStatus:Screen
    {
        public NCStatus():base()
        {
            this.URL = "quality.ncstatus";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            NCStatusCollectionView  = new NCStatusCollectionView(this); 
            NCStatusEntityView  = new NCStatusEntityView(this); 
            NCStatusCollectionView.InitializeControls(); 
            NCStatusEntityView.InitializeControls(); 
           
        }
      
            public NCStatusCollectionView NCStatusCollectionView {get; set; } 
            public NCStatusEntityView NCStatusEntityView {get; set; } 
    }
            
    public partial class NCStatusCollectionView : View
    {
        public NCStatusCollectionView(NCStatus screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            NewButton = RPSControlFactory.RPSNewButton<NCStatusCollectionView,NCStatusEntityView>( this,Screen.NCStatusEntityView);
 
            CollectionInit params_MainConsult = new CollectionInit(){IDDescriptor = "69668847-96a8-4b3f-afc9-bac7c3ee752f",CSSSelectorDescriptor = "",XPathDescriptor = ""};
            MainConsult = RPSControlFactory.RPSCreateCollection<NCStatusCollectionView,NCStatusEntityView>( params_MainConsult,this,Screen.NCStatusEntityView);
 

        }
        public IRPSButton<NCStatusCollectionView,NCStatusEntityView> NewButton { get; set; } 
        public IRPSCollectionEditor<NCStatusCollectionView,NCStatusEntityView> MainConsult { get; set; } 
        public NCStatus Screen { get; set; }
        public NCStatusCollectionView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class NCStatusEntityView : View
    {
        public NCStatusEntityView(NCStatus screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            SaveButton = RPSControlFactory.RPSSaveButton<NCStatusEntityView>( this);
 
            DeleteButton = RPSControlFactory.RPSDeleteButton<NCStatusEntityView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<NCStatusEntityView,NCStatusCollectionView>( this,Screen.NCStatusCollectionView);
 
            BackButton = RPSControlFactory.RPSBackButton<NCStatusEntityView,NCStatusCollectionView>( this,Screen.NCStatusCollectionView);
 
            CodStatus = RPSControlFactory.CreateRPSTextBox<NCStatusEntityView>("db1d1d78-d445-406f-9d7f-79f8ad25eb10","","",true, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<NCStatusEntityView>("65fee833-a6c6-495b-b446-b14943af7b9b","","",false, this);
 

        }
        public IRPSSaveButton<NCStatusEntityView> SaveButton { get; set; } 
        public IRPSButton<NCStatusEntityView> DeleteButton { get; set; } 
        public IRPSButton<NCStatusEntityView,NCStatusCollectionView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<NCStatusEntityView,NCStatusCollectionView> BackButton { get; set; } 
        public IRPSTextBox<NCStatusEntityView> CodStatus { get; set; } 
        public IRPSTextBox<NCStatusEntityView> Description { get; set; } 
        public NCStatus Screen { get; set; }
        public NCStatusEntityView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}