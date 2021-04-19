    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.Sales.IncidenceSituationSL
{
    //RPS VERSION 1.0.0.0
    public partial class IncidenceSituationSL:Screen
    {
        public IncidenceSituationSL():base()
        {
            this.URL = "sales.incidencesituationsl";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            IncidenceSituationSLCollectionView  = new IncidenceSituationSLCollectionView(this); 
            IncidenceSituationSLEntityView  = new IncidenceSituationSLEntityView(this); 
            IncidenceSituationSLCollectionView.InitializeControls(); 
            IncidenceSituationSLEntityView.InitializeControls(); 
           
        }
      
            public IncidenceSituationSLCollectionView IncidenceSituationSLCollectionView {get; set; } 
            public IncidenceSituationSLEntityView IncidenceSituationSLEntityView {get; set; } 
    }
            
    public partial class IncidenceSituationSLCollectionView : View
    {
        public IncidenceSituationSLCollectionView(IncidenceSituationSL screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            NewButton = RPSControlFactory.RPSNewButton<IncidenceSituationSLCollectionView,IncidenceSituationSLEntityView>( this,Screen.IncidenceSituationSLEntityView);
 
            CollectionInit params_MainConsult = new CollectionInit(){IDDescriptor = "1a5a656d-d304-4358-88a9-0c9da5936420",CSSSelectorDescriptor = "",XPathDescriptor = ""};
            MainConsult = RPSControlFactory.RPSCreateCollection<IncidenceSituationSLCollectionView,IncidenceSituationSLEntityView>( params_MainConsult,this,Screen.IncidenceSituationSLEntityView);
 

        }
        public IRPSButton<IncidenceSituationSLCollectionView,IncidenceSituationSLEntityView> NewButton { get; set; } 
        public IRPSCollectionEditor<IncidenceSituationSLCollectionView,IncidenceSituationSLEntityView> MainConsult { get; set; } 
        public IncidenceSituationSL Screen { get; set; }
        public IncidenceSituationSLCollectionView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class IncidenceSituationSLEntityView : View
    {
        public IncidenceSituationSLEntityView(IncidenceSituationSL screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            SaveButton = RPSControlFactory.RPSSaveButton<IncidenceSituationSLEntityView>( this);
 
            DeleteButton = RPSControlFactory.RPSDeleteButton<IncidenceSituationSLEntityView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<IncidenceSituationSLEntityView,IncidenceSituationSLCollectionView>( this,Screen.IncidenceSituationSLCollectionView);
 
            BackButton = RPSControlFactory.RPSBackButton<IncidenceSituationSLEntityView,IncidenceSituationSLCollectionView>( this,Screen.IncidenceSituationSLCollectionView);
 
            CodIncidenceSituation = RPSControlFactory.CreateRPSTextBox<IncidenceSituationSLEntityView>("956e5296-6248-473e-8f42-ca9b2c79645d","","",true, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<IncidenceSituationSLEntityView>("9e817cb5-e5df-40c0-b0c4-920e5ad11343","","",false, this);
 

        }
        public IRPSSaveButton<IncidenceSituationSLEntityView> SaveButton { get; set; } 
        public IRPSButton<IncidenceSituationSLEntityView> DeleteButton { get; set; } 
        public IRPSButton<IncidenceSituationSLEntityView,IncidenceSituationSLCollectionView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<IncidenceSituationSLEntityView,IncidenceSituationSLCollectionView> BackButton { get; set; } 
        public IRPSTextBox<IncidenceSituationSLEntityView> CodIncidenceSituation { get; set; } 
        public IRPSTextBox<IncidenceSituationSLEntityView> Description { get; set; } 
        public IncidenceSituationSL Screen { get; set; }
        public IncidenceSituationSLEntityView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}