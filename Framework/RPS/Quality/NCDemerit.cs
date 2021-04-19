    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.Quality.NCDemerit
{
    //RPS VERSION 1.0.0.0
    public partial class NCDemerit:Screen
    {
        public NCDemerit():base()
        {
            this.URL = "quality.ncdemerit";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            NCDemeritCollectionView  = new NCDemeritCollectionView(this); 
            NCDemeritEntityView  = new NCDemeritEntityView(this); 
            NCDemeritCollectionView.InitializeControls(); 
            NCDemeritEntityView.InitializeControls(); 
           
        }
      
            public NCDemeritCollectionView NCDemeritCollectionView {get; set; } 
            public NCDemeritEntityView NCDemeritEntityView {get; set; } 
    }
            
    public partial class NCDemeritCollectionView : View
    {
        public NCDemeritCollectionView(NCDemerit screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            NewButton = RPSControlFactory.RPSNewButton<NCDemeritCollectionView,NCDemeritEntityView>( this,Screen.NCDemeritEntityView);
 
            CollectionInit params_MainConsult = new CollectionInit(){IDDescriptor = "c9bcf984-2750-49a2-96ec-7068252004db",CSSSelectorDescriptor = "",XPathDescriptor = ""};
            MainConsult = RPSControlFactory.RPSCreateCollection<NCDemeritCollectionView,NCDemeritEntityView>( params_MainConsult,this,Screen.NCDemeritEntityView);
 

        }
        public IRPSButton<NCDemeritCollectionView,NCDemeritEntityView> NewButton { get; set; } 
        public IRPSCollectionEditor<NCDemeritCollectionView,NCDemeritEntityView> MainConsult { get; set; } 
        public NCDemerit Screen { get; set; }
        public NCDemeritCollectionView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class NCDemeritEntityView : View
    {
        public NCDemeritEntityView(NCDemerit screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            SaveButton = RPSControlFactory.RPSSaveButton<NCDemeritEntityView>( this);
 
            DeleteButton = RPSControlFactory.RPSDeleteButton<NCDemeritEntityView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<NCDemeritEntityView,NCDemeritCollectionView>( this,Screen.NCDemeritCollectionView);
 
            BackButton = RPSControlFactory.RPSBackButton<NCDemeritEntityView,NCDemeritCollectionView>( this,Screen.NCDemeritCollectionView);
 
            Point = RPSControlFactory.CreateRPSFormattedTextBox<NCDemeritEntityView>("c12270e7-4c7f-4be1-8eaa-fcc50186b096","","",true, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<NCDemeritEntityView>("9a56590e-78bb-462a-9dda-b1c51b7e06fd","","",false, this);
 

        }
        public IRPSSaveButton<NCDemeritEntityView> SaveButton { get; set; } 
        public IRPSButton<NCDemeritEntityView> DeleteButton { get; set; } 
        public IRPSButton<NCDemeritEntityView,NCDemeritCollectionView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<NCDemeritEntityView,NCDemeritCollectionView> BackButton { get; set; } 
        public IRPSTextBox<NCDemeritEntityView> Point { get; set; } 
        public IRPSTextBox<NCDemeritEntityView> Description { get; set; } 
        public NCDemerit Screen { get; set; }
        public NCDemeritEntityView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}