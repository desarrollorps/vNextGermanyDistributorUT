    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.Quality.NCSource
{
    //RPS VERSION 1.0.0.0
    public partial class NCSource:Screen
    {
        public NCSource():base()
        {
            this.URL = "quality.ncsource";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            NCSourceCollectionView  = new NCSourceCollectionView(this); 
            NCSourceEntityView  = new NCSourceEntityView(this); 
            NCSourceCollectionView.InitializeControls(); 
            NCSourceEntityView.InitializeControls(); 
           
        }
      
            public NCSourceCollectionView NCSourceCollectionView {get; set; } 
            public NCSourceEntityView NCSourceEntityView {get; set; } 
    }
            
    public partial class NCSourceCollectionView : View
    {
        public NCSourceCollectionView(NCSource screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            NewButton = RPSControlFactory.RPSNewButton<NCSourceCollectionView,NCSourceEntityView>( this,Screen.NCSourceEntityView);
 
            CollectionInit params_MainConsult = new CollectionInit(){IDDescriptor = "15233cbc-c32e-4f48-a342-e3bec80cb0a7",CSSSelectorDescriptor = "",XPathDescriptor = ""};
            MainConsult = RPSControlFactory.RPSCreateCollection<NCSourceCollectionView,NCSourceEntityView>( params_MainConsult,this,Screen.NCSourceEntityView);
 

        }
        public IRPSButton<NCSourceCollectionView,NCSourceEntityView> NewButton { get; set; } 
        public IRPSCollectionEditor<NCSourceCollectionView,NCSourceEntityView> MainConsult { get; set; } 
        public NCSource Screen { get; set; }
        public NCSourceCollectionView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class NCSourceEntityView : View
    {
        public NCSourceEntityView(NCSource screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            SaveButton = RPSControlFactory.RPSSaveButton<NCSourceEntityView>( this);
 
            DeleteButton = RPSControlFactory.RPSDeleteButton<NCSourceEntityView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<NCSourceEntityView,NCSourceCollectionView>( this,Screen.NCSourceCollectionView);
 
            BackButton = RPSControlFactory.RPSBackButton<NCSourceEntityView,NCSourceCollectionView>( this,Screen.NCSourceCollectionView);
 
            CodSource = RPSControlFactory.CreateRPSTextBox<NCSourceEntityView>("637eb10e-b1d6-4192-82e1-d83a6a5e3f74","","",true, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<NCSourceEntityView>("674ae1e8-346c-4561-8146-55c5e241eb6f","","",false, this);
 

        }
        public IRPSSaveButton<NCSourceEntityView> SaveButton { get; set; } 
        public IRPSButton<NCSourceEntityView> DeleteButton { get; set; } 
        public IRPSButton<NCSourceEntityView,NCSourceCollectionView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<NCSourceEntityView,NCSourceCollectionView> BackButton { get; set; } 
        public IRPSTextBox<NCSourceEntityView> CodSource { get; set; } 
        public IRPSTextBox<NCSourceEntityView> Description { get; set; } 
        public NCSource Screen { get; set; }
        public NCSourceEntityView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}