    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.Sales.IncidenceTypeSL
{
    //RPS VERSION 1.0.0.0
    public partial class IncidenceTypeSL:Screen
    {
        public IncidenceTypeSL():base()
        {
            this.URL = "sales.incidencetypesl";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            IncidenceTypeSLCollectionView  = new IncidenceTypeSLCollectionView(this); 
            IncidenceTypeSLEntityView  = new IncidenceTypeSLEntityView(this); 
            IncidenceTypeSLCollectionView.InitializeControls(); 
            IncidenceTypeSLEntityView.InitializeControls(); 
           
        }
      
            public IncidenceTypeSLCollectionView IncidenceTypeSLCollectionView {get; set; } 
            public IncidenceTypeSLEntityView IncidenceTypeSLEntityView {get; set; } 
    }
            
    public partial class IncidenceTypeSLCollectionView : View
    {
        public IncidenceTypeSLCollectionView(IncidenceTypeSL screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            NewButton = RPSControlFactory.RPSNewButton<IncidenceTypeSLCollectionView,IncidenceTypeSLEntityView>( this,Screen.IncidenceTypeSLEntityView);
 
            CollectionInit params_MainConsult = new CollectionInit(){IDDescriptor = "066dd68a-bc29-421f-a507-bdb0c790d06b",CSSSelectorDescriptor = "",XPathDescriptor = ""};
            MainConsult = RPSControlFactory.RPSCreateCollection<IncidenceTypeSLCollectionView,IncidenceTypeSLEntityView>( params_MainConsult,this,Screen.IncidenceTypeSLEntityView);
 

        }
        public IRPSButton<IncidenceTypeSLCollectionView,IncidenceTypeSLEntityView> NewButton { get; set; } 
        public IRPSCollectionEditor<IncidenceTypeSLCollectionView,IncidenceTypeSLEntityView> MainConsult { get; set; } 
        public IncidenceTypeSL Screen { get; set; }
        public IncidenceTypeSLCollectionView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class IncidenceTypeSLEntityView : View
    {
        public IncidenceTypeSLEntityView(IncidenceTypeSL screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            SaveButton = RPSControlFactory.RPSSaveButton<IncidenceTypeSLEntityView>( this);
 
            DeleteButton = RPSControlFactory.RPSDeleteButton<IncidenceTypeSLEntityView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<IncidenceTypeSLEntityView,IncidenceTypeSLCollectionView>( this,Screen.IncidenceTypeSLCollectionView);
 
            BackButton = RPSControlFactory.RPSBackButton<IncidenceTypeSLEntityView,IncidenceTypeSLCollectionView>( this,Screen.IncidenceTypeSLCollectionView);
 
            CodIncidenceType = RPSControlFactory.CreateRPSTextBox<IncidenceTypeSLEntityView>("7423443c-795d-45da-b984-99b09039cc94","","",true, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<IncidenceTypeSLEntityView>("a0813ea6-1d06-433d-bcec-f7a795117713","","",false, this);
 

        }
        public IRPSSaveButton<IncidenceTypeSLEntityView> SaveButton { get; set; } 
        public IRPSButton<IncidenceTypeSLEntityView> DeleteButton { get; set; } 
        public IRPSButton<IncidenceTypeSLEntityView,IncidenceTypeSLCollectionView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<IncidenceTypeSLEntityView,IncidenceTypeSLCollectionView> BackButton { get; set; } 
        public IRPSTextBox<IncidenceTypeSLEntityView> CodIncidenceType { get; set; } 
        public IRPSTextBox<IncidenceTypeSLEntityView> Description { get; set; } 
        public IncidenceTypeSL Screen { get; set; }
        public IncidenceTypeSLEntityView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}