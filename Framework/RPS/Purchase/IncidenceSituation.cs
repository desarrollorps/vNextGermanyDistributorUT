    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.Purchase.IncidenceSituation
{
    //RPS VERSION 1.0.0.0
    public partial class IncidenceSituation:Screen
    {
        public IncidenceSituation():base()
        {
            this.URL = "purchase.incidencesituation";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            IncidenceSituationCollectionView  = new IncidenceSituationCollectionView(this); 
            IncidenceSituationEntityView  = new IncidenceSituationEntityView(this); 
            IncidenceSituationCollectionView.InitializeControls(); 
            IncidenceSituationEntityView.InitializeControls(); 
           
        }
      
            public IncidenceSituationCollectionView IncidenceSituationCollectionView {get; set; } 
            public IncidenceSituationEntityView IncidenceSituationEntityView {get; set; } 
    }
            
    public partial class IncidenceSituationCollectionView : View
    {
        public IncidenceSituationCollectionView(IncidenceSituation screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            NewButton = RPSControlFactory.RPSNewButton<IncidenceSituationCollectionView,IncidenceSituationEntityView>( this,Screen.IncidenceSituationEntityView);
 
            CollectionInit params_MainConsult = new CollectionInit(){IDDescriptor = "e2636498-6390-4d42-8755-51acf92a53db",CSSSelectorDescriptor = "",XPathDescriptor = ""};
            MainConsult = RPSControlFactory.RPSCreateCollection<IncidenceSituationCollectionView,IncidenceSituationEntityView>( params_MainConsult,this,Screen.IncidenceSituationEntityView);
 

        }
        public IRPSButton<IncidenceSituationCollectionView,IncidenceSituationEntityView> NewButton { get; set; } 
        public IRPSCollectionEditor<IncidenceSituationCollectionView,IncidenceSituationEntityView> MainConsult { get; set; } 
        public IncidenceSituation Screen { get; set; }
        public IncidenceSituationCollectionView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class IncidenceSituationEntityView : View
    {
        public IncidenceSituationEntityView(IncidenceSituation screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            SaveButton = RPSControlFactory.RPSSaveButton<IncidenceSituationEntityView>( this);
 
            DeleteButton = RPSControlFactory.RPSDeleteButton<IncidenceSituationEntityView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<IncidenceSituationEntityView,IncidenceSituationCollectionView>( this,Screen.IncidenceSituationCollectionView);
 
            BackButton = RPSControlFactory.RPSBackButton<IncidenceSituationEntityView,IncidenceSituationCollectionView>( this,Screen.IncidenceSituationCollectionView);
 
            CodIncidenceSituation = RPSControlFactory.CreateRPSTextBox<IncidenceSituationEntityView>("e6ee3742-c2ff-4ea3-8933-5016785f6af0","","",true, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<IncidenceSituationEntityView>("36361579-326b-4dd1-8577-c409973ae8d9","","",false, this);
 

        }
        public IRPSSaveButton<IncidenceSituationEntityView> SaveButton { get; set; } 
        public IRPSButton<IncidenceSituationEntityView> DeleteButton { get; set; } 
        public IRPSButton<IncidenceSituationEntityView,IncidenceSituationCollectionView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<IncidenceSituationEntityView,IncidenceSituationCollectionView> BackButton { get; set; } 
        public IRPSTextBox<IncidenceSituationEntityView> CodIncidenceSituation { get; set; } 
        public IRPSTextBox<IncidenceSituationEntityView> Description { get; set; } 
        public IncidenceSituation Screen { get; set; }
        public IncidenceSituationEntityView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}