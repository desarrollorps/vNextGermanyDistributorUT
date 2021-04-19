    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.Planification.StopType
{
    //RPS VERSION 1.0.0.0
    public partial class StopType:Screen
    {
        public StopType():base()
        {
            this.URL = "planification.stoptype";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            StopTypeCollectionView  = new StopTypeCollectionView(this); 
            StopTypeEntityView  = new StopTypeEntityView(this); 
            StopTypeCollectionView.InitializeControls(); 
            StopTypeEntityView.InitializeControls(); 
           
        }
      
            public StopTypeCollectionView StopTypeCollectionView {get; set; } 
            public StopTypeEntityView StopTypeEntityView {get; set; } 
    }
            
    public partial class StopTypeCollectionView : View
    {
        public StopTypeCollectionView(StopType screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            NewButton = RPSControlFactory.RPSNewButton<StopTypeCollectionView,StopTypeEntityView>( this,Screen.StopTypeEntityView);
 
            CollectionInit params_MainConsult = new CollectionInit(){IDDescriptor = "bb1c4eca-945c-4904-a5e5-e80b7722aef8",CSSSelectorDescriptor = "",XPathDescriptor = ""};
            MainConsult = RPSControlFactory.RPSCreateCollection<StopTypeCollectionView,StopTypeEntityView>( params_MainConsult,this,Screen.StopTypeEntityView);
 

        }
        public IRPSButton<StopTypeCollectionView,StopTypeEntityView> NewButton { get; set; } 
        public IRPSCollectionEditor<StopTypeCollectionView,StopTypeEntityView> MainConsult { get; set; } 
        public StopType Screen { get; set; }
        public StopTypeCollectionView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class StopTypeEntityView : View
    {
        public StopTypeEntityView(StopType screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            SaveButton = RPSControlFactory.RPSSaveButton<StopTypeEntityView>( this);
 
            DeleteButton = RPSControlFactory.RPSDeleteButton<StopTypeEntityView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<StopTypeEntityView,StopTypeCollectionView>( this,Screen.StopTypeCollectionView);
 
            BackButton = RPSControlFactory.RPSBackButton<StopTypeEntityView,StopTypeCollectionView>( this,Screen.StopTypeCollectionView);
 
            CodStopType = RPSControlFactory.CreateRPSTextBox<StopTypeEntityView>("236b45f4-ca20-4de2-a460-6d7ac692236a","","",true, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<StopTypeEntityView>("3924e659-958c-420b-aa55-31fc7667e1b0","","",false, this);
 
            CodExternStopType = RPSControlFactory.CreateRPSTextBox<StopTypeEntityView>("009282b8-6d4c-4887-9c68-7807c1cf091a","","",false, this);
 
            HalfDay = RPSControlFactory.CreateRPSCheckBox<StopTypeEntityView>("4d77a157-73c3-48f4-bde9-cadbd3841640","","",true, this);
 
            Color = RPSControlFactory.CreateRPSColorEditor<StopTypeEntityView>( "92b2c2cf-f28e-4a1f-8bd9-7749e02a5675","","",this);
 

        }
        public IRPSSaveButton<StopTypeEntityView> SaveButton { get; set; } 
        public IRPSButton<StopTypeEntityView> DeleteButton { get; set; } 
        public IRPSButton<StopTypeEntityView,StopTypeCollectionView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<StopTypeEntityView,StopTypeCollectionView> BackButton { get; set; } 
        public IRPSTextBox<StopTypeEntityView> CodStopType { get; set; } 
        public IRPSTextBox<StopTypeEntityView> Description { get; set; } 
        public IRPSTextBox<StopTypeEntityView> CodExternStopType { get; set; } 
        public IRPSCheckbox<StopTypeEntityView> HalfDay { get; set; } 
        public IRPSColorEditor<StopTypeEntityView> Color { get; set; } 
        public StopType Screen { get; set; }
        public StopTypeEntityView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}