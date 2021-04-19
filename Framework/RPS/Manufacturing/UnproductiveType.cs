    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.Manufacturing.UnproductiveType
{
    //RPS VERSION 1.0.0.0
    public partial class UnproductiveType:Screen
    {
        public UnproductiveType():base()
        {
            this.URL = "manufacturing.unproductivetype";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            UnproductiveTypeCollectionView  = new UnproductiveTypeCollectionView(this); 
            UnproductiveTypeEntityView  = new UnproductiveTypeEntityView(this); 
            UnproductiveTypeCollectionView.InitializeControls(); 
            UnproductiveTypeEntityView.InitializeControls(); 
           
        }
      
            public UnproductiveTypeCollectionView UnproductiveTypeCollectionView {get; set; } 
            public UnproductiveTypeEntityView UnproductiveTypeEntityView {get; set; } 
    }
            
    public partial class UnproductiveTypeCollectionView : View
    {
        public UnproductiveTypeCollectionView(UnproductiveType screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            NewButton = RPSControlFactory.RPSNewButton<UnproductiveTypeCollectionView,UnproductiveTypeEntityView>( this,Screen.UnproductiveTypeEntityView);
 
            CollectionInit params_MainConsult = new CollectionInit(){IDDescriptor = "bc200f1e-bcd5-4acd-bf39-14d3d45358fc",CSSSelectorDescriptor = "",XPathDescriptor = ""};
            MainConsult = RPSControlFactory.RPSCreateCollection<UnproductiveTypeCollectionView,UnproductiveTypeEntityView>( params_MainConsult,this,Screen.UnproductiveTypeEntityView);
 

        }
        public IRPSButton<UnproductiveTypeCollectionView,UnproductiveTypeEntityView> NewButton { get; set; } 
        public IRPSCollectionEditor<UnproductiveTypeCollectionView,UnproductiveTypeEntityView> MainConsult { get; set; } 
        public UnproductiveType Screen { get; set; }
        public UnproductiveTypeCollectionView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class UnproductiveTypeEntityView : View
    {
        public UnproductiveTypeEntityView(UnproductiveType screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            SaveButton = RPSControlFactory.RPSSaveButton<UnproductiveTypeEntityView>( this);
 
            DeleteButton = RPSControlFactory.RPSDeleteButton<UnproductiveTypeEntityView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<UnproductiveTypeEntityView,UnproductiveTypeCollectionView>( this,Screen.UnproductiveTypeCollectionView);
 
            BackButton = RPSControlFactory.RPSBackButton<UnproductiveTypeEntityView,UnproductiveTypeCollectionView>( this,Screen.UnproductiveTypeCollectionView);
 
            CodUnproductiveType = RPSControlFactory.CreateRPSTextBox<UnproductiveTypeEntityView>("3ea80270-8a00-49ef-9587-8289c0d1c8ec","","",true, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<UnproductiveTypeEntityView>("5b1c56bd-e6d2-4677-af2b-5e8e832b5458","","",false, this);
 

        }
        public IRPSSaveButton<UnproductiveTypeEntityView> SaveButton { get; set; } 
        public IRPSButton<UnproductiveTypeEntityView> DeleteButton { get; set; } 
        public IRPSButton<UnproductiveTypeEntityView,UnproductiveTypeCollectionView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<UnproductiveTypeEntityView,UnproductiveTypeCollectionView> BackButton { get; set; } 
        public IRPSTextBox<UnproductiveTypeEntityView> CodUnproductiveType { get; set; } 
        public IRPSTextBox<UnproductiveTypeEntityView> Description { get; set; } 
        public UnproductiveType Screen { get; set; }
        public UnproductiveTypeEntityView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}