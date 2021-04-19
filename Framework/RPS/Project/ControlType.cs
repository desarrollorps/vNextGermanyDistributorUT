    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.Project.ControlType
{
    //RPS VERSION 1.0.0.0
    public partial class ControlType:Screen
    {
        public ControlType():base()
        {
            this.URL = "project.controltype";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            ControlTypeCollectionView  = new ControlTypeCollectionView(this); 
            ControlTypeEntityView  = new ControlTypeEntityView(this); 
            ControlTypeCollectionView.InitializeControls(); 
            ControlTypeEntityView.InitializeControls(); 
           
        }
      
            public ControlTypeCollectionView ControlTypeCollectionView {get; set; } 
            public ControlTypeEntityView ControlTypeEntityView {get; set; } 
    }
            
    public partial class ControlTypeCollectionView : View
    {
        public ControlTypeCollectionView(ControlType screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            NewButton = RPSControlFactory.RPSNewButton<ControlTypeCollectionView,ControlTypeEntityView>( this,Screen.ControlTypeEntityView);
 
            CollectionInit params_MainConsult = new CollectionInit(){IDDescriptor = "6a90123c-f368-43b1-ae9e-7c14a861e842",CSSSelectorDescriptor = "",XPathDescriptor = ""};
            MainConsult = RPSControlFactory.RPSCreateCollection<ControlTypeCollectionView,ControlTypeEntityView>( params_MainConsult,this,Screen.ControlTypeEntityView);
 

        }
        public IRPSButton<ControlTypeCollectionView,ControlTypeEntityView> NewButton { get; set; } 
        public IRPSCollectionEditor<ControlTypeCollectionView,ControlTypeEntityView> MainConsult { get; set; } 
        public ControlType Screen { get; set; }
        public ControlTypeCollectionView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class ControlTypeEntityView : View
    {
        public ControlTypeEntityView(ControlType screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            SaveButton = RPSControlFactory.RPSSaveButton<ControlTypeEntityView>( this);
 
            DeleteButton = RPSControlFactory.RPSDeleteButton<ControlTypeEntityView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<ControlTypeEntityView,ControlTypeCollectionView>( this,Screen.ControlTypeCollectionView);
 
            BackButton = RPSControlFactory.RPSBackButton<ControlTypeEntityView,ControlTypeCollectionView>( this,Screen.ControlTypeCollectionView);
 
            CodControlType = RPSControlFactory.CreateRPSTextBox<ControlTypeEntityView>("17022eaf-2853-40ed-8ca8-d49dc6660d43","","",true, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<ControlTypeEntityView>("3c7c13af-f9da-4d06-b118-b7fbe6dcb0cc","","",false, this);
 
            Notes = RPSControlFactory.CreateRPSTextBox<ControlTypeEntityView>("31988678-52bc-48e0-b5cf-09ae8fa622d2","","",false, this);
 

        }
        public IRPSSaveButton<ControlTypeEntityView> SaveButton { get; set; } 
        public IRPSButton<ControlTypeEntityView> DeleteButton { get; set; } 
        public IRPSButton<ControlTypeEntityView,ControlTypeCollectionView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<ControlTypeEntityView,ControlTypeCollectionView> BackButton { get; set; } 
        public IRPSTextBox<ControlTypeEntityView> CodControlType { get; set; } 
        public IRPSTextBox<ControlTypeEntityView> Description { get; set; } 
        public IRPSTextBox<ControlTypeEntityView> Notes { get; set; } 
        public ControlType Screen { get; set; }
        public ControlTypeEntityView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}