    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.Purchase.IncidenceType
{
    //RPS VERSION 1.0.0.0
    public partial class IncidenceType:Screen
    {
        public IncidenceType():base()
        {
            this.URL = "purchase.incidencetype";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            IncidenceTypeCollectionView  = new IncidenceTypeCollectionView(this); 
            IncidenceTypeEntityView  = new IncidenceTypeEntityView(this); 
            IncidenceTypeCollectionView.InitializeControls(); 
            IncidenceTypeEntityView.InitializeControls(); 
           
        }
      
            public IncidenceTypeCollectionView IncidenceTypeCollectionView {get; set; } 
            public IncidenceTypeEntityView IncidenceTypeEntityView {get; set; } 
    }
            
    public partial class IncidenceTypeCollectionView : View
    {
        public IncidenceTypeCollectionView(IncidenceType screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            NewButton = RPSControlFactory.RPSNewButton<IncidenceTypeCollectionView,IncidenceTypeEntityView>( this,Screen.IncidenceTypeEntityView);
 
            CollectionInit params_MainConsult = new CollectionInit(){IDDescriptor = "de79e6a2-30e5-46ca-b4a2-c5c90472295d",CSSSelectorDescriptor = "",XPathDescriptor = ""};
            MainConsult = RPSControlFactory.RPSCreateCollection<IncidenceTypeCollectionView,IncidenceTypeEntityView>( params_MainConsult,this,Screen.IncidenceTypeEntityView);
 

        }
        public IRPSButton<IncidenceTypeCollectionView,IncidenceTypeEntityView> NewButton { get; set; } 
        public IRPSCollectionEditor<IncidenceTypeCollectionView,IncidenceTypeEntityView> MainConsult { get; set; } 
        public IncidenceType Screen { get; set; }
        public IncidenceTypeCollectionView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class IncidenceTypeEntityView : View
    {
        public IncidenceTypeEntityView(IncidenceType screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            SaveButton = RPSControlFactory.RPSSaveButton<IncidenceTypeEntityView>( this);
 
            DeleteButton = RPSControlFactory.RPSDeleteButton<IncidenceTypeEntityView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<IncidenceTypeEntityView,IncidenceTypeCollectionView>( this,Screen.IncidenceTypeCollectionView);
 
            BackButton = RPSControlFactory.RPSBackButton<IncidenceTypeEntityView,IncidenceTypeCollectionView>( this,Screen.IncidenceTypeCollectionView);
 
            CodIncidenceType = RPSControlFactory.CreateRPSTextBox<IncidenceTypeEntityView>("2bf1bd1c-f5b6-4fa3-8b94-c7156b311ba9","","",true, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<IncidenceTypeEntityView>("ffda2367-570f-4b16-a964-936f264ecb8e","","",false, this);
 

        }
        public IRPSSaveButton<IncidenceTypeEntityView> SaveButton { get; set; } 
        public IRPSButton<IncidenceTypeEntityView> DeleteButton { get; set; } 
        public IRPSButton<IncidenceTypeEntityView,IncidenceTypeCollectionView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<IncidenceTypeEntityView,IncidenceTypeCollectionView> BackButton { get; set; } 
        public IRPSTextBox<IncidenceTypeEntityView> CodIncidenceType { get; set; } 
        public IRPSTextBox<IncidenceTypeEntityView> Description { get; set; } 
        public IncidenceType Screen { get; set; }
        public IncidenceTypeEntityView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}