    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.General.HourType
{
    //RPS VERSION 1.0.0.0
    public partial class HourType:Screen
    {
        public HourType():base()
        {
            this.URL = "general.hourtype";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            HourTypeCollectionView  = new HourTypeCollectionView(this); 
            HourTypeEntityView  = new HourTypeEntityView(this); 
            HourTypeCollectionView.InitializeControls(); 
            HourTypeEntityView.InitializeControls(); 
           
        }
      
            public HourTypeCollectionView HourTypeCollectionView {get; set; } 
            public HourTypeEntityView HourTypeEntityView {get; set; } 
    }
            
    public partial class HourTypeCollectionView : View
    {
        public HourTypeCollectionView(HourType screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            NewButton = RPSControlFactory.RPSNewButton<HourTypeCollectionView,HourTypeEntityView>( this,Screen.HourTypeEntityView);
 
            CollectionInit params_MainConsult = new CollectionInit(){IDDescriptor = "d6bc1c52-b3fb-4b47-9b8f-503ec6287c71",CSSSelectorDescriptor = "",XPathDescriptor = ""};
            MainConsult = RPSControlFactory.RPSCreateCollection<HourTypeCollectionView,HourTypeEntityView>( params_MainConsult,this,Screen.HourTypeEntityView);
 

        }
        public IRPSButton<HourTypeCollectionView,HourTypeEntityView> NewButton { get; set; } 
        public IRPSCollectionEditor<HourTypeCollectionView,HourTypeEntityView> MainConsult { get; set; } 
        public HourType Screen { get; set; }
        public HourTypeCollectionView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class HourTypeEntityView : View
    {
        public HourTypeEntityView(HourType screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            SaveButton = RPSControlFactory.RPSSaveButton<HourTypeEntityView>( this);
 
            DeleteButton = RPSControlFactory.RPSDeleteButton<HourTypeEntityView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<HourTypeEntityView,HourTypeCollectionView>( this,Screen.HourTypeCollectionView);
 
            BackButton = RPSControlFactory.RPSBackButton<HourTypeEntityView,HourTypeCollectionView>( this,Screen.HourTypeCollectionView);
 
            CodHourType = RPSControlFactory.CreateRPSTextBox<HourTypeEntityView>("94b08e3f-6568-4063-b4fd-1b0aff2f3c98","","",true, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<HourTypeEntityView>("8e018df5-478f-4f0d-b3e7-3b52eb8bd78a","","",false, this);
 

        }
        public IRPSSaveButton<HourTypeEntityView> SaveButton { get; set; } 
        public IRPSButton<HourTypeEntityView> DeleteButton { get; set; } 
        public IRPSButton<HourTypeEntityView,HourTypeCollectionView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<HourTypeEntityView,HourTypeCollectionView> BackButton { get; set; } 
        public IRPSTextBox<HourTypeEntityView> CodHourType { get; set; } 
        public IRPSTextBox<HourTypeEntityView> Description { get; set; } 
        public HourType Screen { get; set; }
        public HourTypeEntityView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}