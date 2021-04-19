    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.Maintenance.ControlMethod
{
    //RPS VERSION 1.0.0.0
    public partial class ControlMethod:Screen
    {
        public ControlMethod():base()
        {
            this.URL = "maintenance.controlmethod";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            ControlMethodCollectionView  = new ControlMethodCollectionView(this); 
            ControlMethodEntityView  = new ControlMethodEntityView(this); 
            ControlMethodCollectionView.InitializeControls(); 
            ControlMethodEntityView.InitializeControls(); 
           
        }
      
            public ControlMethodCollectionView ControlMethodCollectionView {get; set; } 
            public ControlMethodEntityView ControlMethodEntityView {get; set; } 
    }
            
    public partial class ControlMethodCollectionView : View
    {
        public ControlMethodCollectionView(ControlMethod screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            NewButton = RPSControlFactory.RPSNewButton<ControlMethodCollectionView,ControlMethodEntityView>( this,Screen.ControlMethodEntityView);
 
            CollectionInit params_MainConsult = new CollectionInit(){IDDescriptor = "c4e09c8b-aaa5-4dcb-bfa3-4867d1df7972",CSSSelectorDescriptor = "",XPathDescriptor = ""};
            MainConsult = RPSControlFactory.RPSCreateCollection<ControlMethodCollectionView,ControlMethodEntityView>( params_MainConsult,this,Screen.ControlMethodEntityView);
 

        }
        public IRPSButton<ControlMethodCollectionView,ControlMethodEntityView> NewButton { get; set; } 
        public IRPSCollectionEditor<ControlMethodCollectionView,ControlMethodEntityView> MainConsult { get; set; } 
        public ControlMethod Screen { get; set; }
        public ControlMethodCollectionView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class ControlMethodEntityView : View
    {
        public ControlMethodEntityView(ControlMethod screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            SaveButton = RPSControlFactory.RPSSaveButton<ControlMethodEntityView>( this);
 
            DeleteButton = RPSControlFactory.RPSDeleteButton<ControlMethodEntityView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<ControlMethodEntityView,ControlMethodCollectionView>( this,Screen.ControlMethodCollectionView);
 
            BackButton = RPSControlFactory.RPSBackButton<ControlMethodEntityView,ControlMethodCollectionView>( this,Screen.ControlMethodCollectionView);
 
            CodControlMethod = RPSControlFactory.CreateRPSTextBox<ControlMethodEntityView>("e8671f86-7219-4032-ad63-87b38b7dceb1","","",true, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<ControlMethodEntityView>("b3f2da0d-9645-4ff9-a806-0c8803d2bc80","","",false, this);
 

        }
        public IRPSSaveButton<ControlMethodEntityView> SaveButton { get; set; } 
        public IRPSButton<ControlMethodEntityView> DeleteButton { get; set; } 
        public IRPSButton<ControlMethodEntityView,ControlMethodCollectionView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<ControlMethodEntityView,ControlMethodCollectionView> BackButton { get; set; } 
        public IRPSTextBox<ControlMethodEntityView> CodControlMethod { get; set; } 
        public IRPSTextBox<ControlMethodEntityView> Description { get; set; } 
        public ControlMethod Screen { get; set; }
        public ControlMethodEntityView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}