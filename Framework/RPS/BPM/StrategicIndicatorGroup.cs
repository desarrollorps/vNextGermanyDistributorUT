    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.BPM.StrategicIndicatorGroup
{
    //RPS VERSION 1.0.0.0
    public partial class StrategicIndicatorGroup:Screen
    {
        public StrategicIndicatorGroup():base()
        {
            this.URL = "bpm.strategicindicatorgroup";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            StrategicIndicatorGroupCollectionView  = new StrategicIndicatorGroupCollectionView(this); 
            StrategicIndicatorGroupEntityView  = new StrategicIndicatorGroupEntityView(this); 
            StrategicIndicatorGroupCollectionView.InitializeControls(); 
            StrategicIndicatorGroupEntityView.InitializeControls(); 
           
        }
      
            public StrategicIndicatorGroupCollectionView StrategicIndicatorGroupCollectionView {get; set; } 
            public StrategicIndicatorGroupEntityView StrategicIndicatorGroupEntityView {get; set; } 
    }
            
    public partial class StrategicIndicatorGroupCollectionView : View
    {
        public StrategicIndicatorGroupCollectionView(StrategicIndicatorGroup screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            NewButton = RPSControlFactory.RPSNewButton<StrategicIndicatorGroupCollectionView,StrategicIndicatorGroupEntityView>( this,Screen.StrategicIndicatorGroupEntityView);
 
            CollectionInit params_MainConsult = new CollectionInit(){IDDescriptor = "599db2bf-c8a7-40df-9872-90fe411d9d5b",CSSSelectorDescriptor = "",XPathDescriptor = ""};
            MainConsult = RPSControlFactory.RPSCreateCollection<StrategicIndicatorGroupCollectionView,StrategicIndicatorGroupEntityView>( params_MainConsult,this,Screen.StrategicIndicatorGroupEntityView);
 

        }
        public IRPSButton<StrategicIndicatorGroupCollectionView,StrategicIndicatorGroupEntityView> NewButton { get; set; } 
        public IRPSCollectionEditor<StrategicIndicatorGroupCollectionView,StrategicIndicatorGroupEntityView> MainConsult { get; set; } 
        public StrategicIndicatorGroup Screen { get; set; }
        public StrategicIndicatorGroupCollectionView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class StrategicIndicatorGroupEntityView : View
    {
        public StrategicIndicatorGroupEntityView(StrategicIndicatorGroup screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            SaveButton = RPSControlFactory.RPSSaveButton<StrategicIndicatorGroupEntityView>( this);
 
            DeleteButton = RPSControlFactory.RPSDeleteButton<StrategicIndicatorGroupEntityView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<StrategicIndicatorGroupEntityView,StrategicIndicatorGroupCollectionView>( this,Screen.StrategicIndicatorGroupCollectionView);
 
            BackButton = RPSControlFactory.RPSBackButton<StrategicIndicatorGroupEntityView,StrategicIndicatorGroupCollectionView>( this,Screen.StrategicIndicatorGroupCollectionView);
 
            CodStrategicIndicatorGroup = RPSControlFactory.CreateRPSTextBox<StrategicIndicatorGroupEntityView>("decaad80-5742-4fef-9e5f-a29fe670a136","","",true, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<StrategicIndicatorGroupEntityView>("bf4928c6-3aba-4d63-8bdb-114c1ab932bc","","",false, this);
 

        }
        public IRPSSaveButton<StrategicIndicatorGroupEntityView> SaveButton { get; set; } 
        public IRPSButton<StrategicIndicatorGroupEntityView> DeleteButton { get; set; } 
        public IRPSButton<StrategicIndicatorGroupEntityView,StrategicIndicatorGroupCollectionView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<StrategicIndicatorGroupEntityView,StrategicIndicatorGroupCollectionView> BackButton { get; set; } 
        public IRPSTextBox<StrategicIndicatorGroupEntityView> CodStrategicIndicatorGroup { get; set; } 
        public IRPSTextBox<StrategicIndicatorGroupEntityView> Description { get; set; } 
        public StrategicIndicatorGroup Screen { get; set; }
        public StrategicIndicatorGroupEntityView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}