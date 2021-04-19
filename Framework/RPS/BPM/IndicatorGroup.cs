    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.BPM.IndicatorGroup
{
    //RPS VERSION 1.0.0.0
    public partial class IndicatorGroup:Screen
    {
        public IndicatorGroup():base()
        {
            this.URL = "bpm.indicatorgroup";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            IndicatorGroupCollectionView  = new IndicatorGroupCollectionView(this); 
            IndicatorGroupEntityView  = new IndicatorGroupEntityView(this); 
            IndicatorGroupCollectionView.InitializeControls(); 
            IndicatorGroupEntityView.InitializeControls(); 
           
        }
      
            public IndicatorGroupCollectionView IndicatorGroupCollectionView {get; set; } 
            public IndicatorGroupEntityView IndicatorGroupEntityView {get; set; } 
    }
            
    public partial class IndicatorGroupCollectionView : View
    {
        public IndicatorGroupCollectionView(IndicatorGroup screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            NewButton = RPSControlFactory.RPSNewButton<IndicatorGroupCollectionView,IndicatorGroupEntityView>( this,Screen.IndicatorGroupEntityView);
 
            CollectionInit params_MainConsult = new CollectionInit(){IDDescriptor = "0713e361-4c45-404c-bd81-8c2b1bdb2ad3",CSSSelectorDescriptor = "",XPathDescriptor = ""};
            MainConsult = RPSControlFactory.RPSCreateCollection<IndicatorGroupCollectionView,IndicatorGroupEntityView>( params_MainConsult,this,Screen.IndicatorGroupEntityView);
 

        }
        public IRPSButton<IndicatorGroupCollectionView,IndicatorGroupEntityView> NewButton { get; set; } 
        public IRPSCollectionEditor<IndicatorGroupCollectionView,IndicatorGroupEntityView> MainConsult { get; set; } 
        public IndicatorGroup Screen { get; set; }
        public IndicatorGroupCollectionView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class IndicatorGroupEntityView : View
    {
        public IndicatorGroupEntityView(IndicatorGroup screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            SaveButton = RPSControlFactory.RPSSaveButton<IndicatorGroupEntityView>( this);
 
            DeleteButton = RPSControlFactory.RPSDeleteButton<IndicatorGroupEntityView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<IndicatorGroupEntityView,IndicatorGroupCollectionView>( this,Screen.IndicatorGroupCollectionView);
 
            BackButton = RPSControlFactory.RPSBackButton<IndicatorGroupEntityView,IndicatorGroupCollectionView>( this,Screen.IndicatorGroupCollectionView);
 
            CodGroup = RPSControlFactory.CreateRPSTextBox<IndicatorGroupEntityView>("56d30fed-85cd-4146-9453-ff8bf2c575ec","","",true, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<IndicatorGroupEntityView>("14b44414-cfeb-4f64-a7ab-4369369ae8f4","","",false, this);
 

        }
        public IRPSSaveButton<IndicatorGroupEntityView> SaveButton { get; set; } 
        public IRPSButton<IndicatorGroupEntityView> DeleteButton { get; set; } 
        public IRPSButton<IndicatorGroupEntityView,IndicatorGroupCollectionView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<IndicatorGroupEntityView,IndicatorGroupCollectionView> BackButton { get; set; } 
        public IRPSTextBox<IndicatorGroupEntityView> CodGroup { get; set; } 
        public IRPSTextBox<IndicatorGroupEntityView> Description { get; set; } 
        public IndicatorGroup Screen { get; set; }
        public IndicatorGroupEntityView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}