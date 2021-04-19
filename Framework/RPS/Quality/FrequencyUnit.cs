    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.Quality.FrequencyUnit
{
    //RPS VERSION 1.0.0.0
    public partial class FrequencyUnit:Screen
    {
        public FrequencyUnit():base()
        {
            this.URL = "quality.frequencyunit";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            FrequencyUnitCollectionView  = new FrequencyUnitCollectionView(this); 
            FrequencyUnitEntityView  = new FrequencyUnitEntityView(this); 
            FrequencyUnitCollectionView.InitializeControls(); 
            FrequencyUnitEntityView.InitializeControls(); 
           
        }
      
            public FrequencyUnitCollectionView FrequencyUnitCollectionView {get; set; } 
            public FrequencyUnitEntityView FrequencyUnitEntityView {get; set; } 
    }
            
    public partial class FrequencyUnitCollectionView : View
    {
        public FrequencyUnitCollectionView(FrequencyUnit screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            NewButton = RPSControlFactory.RPSNewButton<FrequencyUnitCollectionView,FrequencyUnitEntityView>( this,Screen.FrequencyUnitEntityView);
 
            CollectionInit params_MainConsult = new CollectionInit(){IDDescriptor = "6bbe9edc-4810-4e76-a8be-5535269d42c3",CSSSelectorDescriptor = "",XPathDescriptor = ""};
            MainConsult = RPSControlFactory.RPSCreateCollection<FrequencyUnitCollectionView,FrequencyUnitEntityView>( params_MainConsult,this,Screen.FrequencyUnitEntityView);
 

        }
        public IRPSButton<FrequencyUnitCollectionView,FrequencyUnitEntityView> NewButton { get; set; } 
        public IRPSCollectionEditor<FrequencyUnitCollectionView,FrequencyUnitEntityView> MainConsult { get; set; } 
        public FrequencyUnit Screen { get; set; }
        public FrequencyUnitCollectionView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class FrequencyUnitEntityView : View
    {
        public FrequencyUnitEntityView(FrequencyUnit screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            SaveButton = RPSControlFactory.RPSSaveButton<FrequencyUnitEntityView>( this);
 
            DeleteButton = RPSControlFactory.RPSDeleteButton<FrequencyUnitEntityView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<FrequencyUnitEntityView,FrequencyUnitCollectionView>( this,Screen.FrequencyUnitCollectionView);
 
            BackButton = RPSControlFactory.RPSBackButton<FrequencyUnitEntityView,FrequencyUnitCollectionView>( this,Screen.FrequencyUnitCollectionView);
 
            CodFrequencyUnit = RPSControlFactory.CreateRPSTextBox<FrequencyUnitEntityView>("7bf27604-16b1-47be-9fdb-be893b57e819","","",true, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<FrequencyUnitEntityView>("c6099434-5877-4a8f-8f7d-8fbf5bfc0eee","","",false, this);
 

        }
        public IRPSSaveButton<FrequencyUnitEntityView> SaveButton { get; set; } 
        public IRPSButton<FrequencyUnitEntityView> DeleteButton { get; set; } 
        public IRPSButton<FrequencyUnitEntityView,FrequencyUnitCollectionView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<FrequencyUnitEntityView,FrequencyUnitCollectionView> BackButton { get; set; } 
        public IRPSTextBox<FrequencyUnitEntityView> CodFrequencyUnit { get; set; } 
        public IRPSTextBox<FrequencyUnitEntityView> Description { get; set; } 
        public FrequencyUnit Screen { get; set; }
        public FrequencyUnitEntityView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}