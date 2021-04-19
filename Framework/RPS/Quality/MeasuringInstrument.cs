    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.Quality.MeasuringInstrument
{
    //RPS VERSION 1.0.0.0
    public partial class MeasuringInstrument:Screen
    {
        public MeasuringInstrument():base()
        {
            this.URL = "quality.measuringinstrument";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            MeasuringInstrumentCollectionView  = new MeasuringInstrumentCollectionView(this); 
            MeasuringInstrumentEntityView  = new MeasuringInstrumentEntityView(this); 
            MeasuringInstrumentCollectionView.InitializeControls(); 
            MeasuringInstrumentEntityView.InitializeControls(); 
           
        }
      
            public MeasuringInstrumentCollectionView MeasuringInstrumentCollectionView {get; set; } 
            public MeasuringInstrumentEntityView MeasuringInstrumentEntityView {get; set; } 
    }
            
    public partial class MeasuringInstrumentCollectionView : View
    {
        public MeasuringInstrumentCollectionView(MeasuringInstrument screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            NewButton = RPSControlFactory.RPSNewButton<MeasuringInstrumentCollectionView,MeasuringInstrumentEntityView>( this,Screen.MeasuringInstrumentEntityView);
 
            CollectionInit params_MainConsult = new CollectionInit(){IDDescriptor = "1e3e58c7-bc98-426e-82fe-d7dabde88e24",CSSSelectorDescriptor = "",XPathDescriptor = ""};
            MainConsult = RPSControlFactory.RPSCreateCollection<MeasuringInstrumentCollectionView,MeasuringInstrumentEntityView>( params_MainConsult,this,Screen.MeasuringInstrumentEntityView);
 

        }
        public IRPSButton<MeasuringInstrumentCollectionView,MeasuringInstrumentEntityView> NewButton { get; set; } 
        public IRPSCollectionEditor<MeasuringInstrumentCollectionView,MeasuringInstrumentEntityView> MainConsult { get; set; } 
        public MeasuringInstrument Screen { get; set; }
        public MeasuringInstrumentCollectionView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class MeasuringInstrumentEntityView : View
    {
        public MeasuringInstrumentEntityView(MeasuringInstrument screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            SaveButton = RPSControlFactory.RPSSaveButton<MeasuringInstrumentEntityView>( this);
 
            DeleteButton = RPSControlFactory.RPSDeleteButton<MeasuringInstrumentEntityView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<MeasuringInstrumentEntityView,MeasuringInstrumentCollectionView>( this,Screen.MeasuringInstrumentCollectionView);
 
            BackButton = RPSControlFactory.RPSBackButton<MeasuringInstrumentEntityView,MeasuringInstrumentCollectionView>( this,Screen.MeasuringInstrumentCollectionView);
 
            CodMeasuringInstrument = RPSControlFactory.CreateRPSTextBox<MeasuringInstrumentEntityView>("fe4e614c-136d-4b9a-9dad-e0d698e16dac","","",true, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<MeasuringInstrumentEntityView>("5790f7d3-a7c1-4c8d-875b-60b7f889ce3f","","",false, this);
 

        }
        public IRPSSaveButton<MeasuringInstrumentEntityView> SaveButton { get; set; } 
        public IRPSButton<MeasuringInstrumentEntityView> DeleteButton { get; set; } 
        public IRPSButton<MeasuringInstrumentEntityView,MeasuringInstrumentCollectionView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<MeasuringInstrumentEntityView,MeasuringInstrumentCollectionView> BackButton { get; set; } 
        public IRPSTextBox<MeasuringInstrumentEntityView> CodMeasuringInstrument { get; set; } 
        public IRPSTextBox<MeasuringInstrumentEntityView> Description { get; set; } 
        public MeasuringInstrument Screen { get; set; }
        public MeasuringInstrumentEntityView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}