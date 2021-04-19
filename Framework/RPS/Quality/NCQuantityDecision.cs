    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.Quality.NCQuantityDecision
{
    //RPS VERSION 1.0.0.0
    public partial class NCQuantityDecision:Screen
    {
        public NCQuantityDecision():base()
        {
            this.URL = "quality.ncquantitydecision";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            NCQuantityDecisionCollectionView  = new NCQuantityDecisionCollectionView(this); 
            NCQuantityDecisionEntityView  = new NCQuantityDecisionEntityView(this); 
            NCQuantityDecisionCollectionView.InitializeControls(); 
            NCQuantityDecisionEntityView.InitializeControls(); 
           
        }
      
            public NCQuantityDecisionCollectionView NCQuantityDecisionCollectionView {get; set; } 
            public NCQuantityDecisionEntityView NCQuantityDecisionEntityView {get; set; } 
    }
            
    public partial class NCQuantityDecisionCollectionView : View
    {
        public NCQuantityDecisionCollectionView(NCQuantityDecision screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            NewButton = RPSControlFactory.RPSNewButton<NCQuantityDecisionCollectionView,NCQuantityDecisionEntityView>( this,Screen.NCQuantityDecisionEntityView);
 
            CollectionInit params_MainConsult = new CollectionInit(){IDDescriptor = "f675e7b1-f591-4e58-99e4-24d66d425147",CSSSelectorDescriptor = "",XPathDescriptor = ""};
            MainConsult = RPSControlFactory.RPSCreateCollection<NCQuantityDecisionCollectionView,NCQuantityDecisionEntityView>( params_MainConsult,this,Screen.NCQuantityDecisionEntityView);
 

        }
        public IRPSButton<NCQuantityDecisionCollectionView,NCQuantityDecisionEntityView> NewButton { get; set; } 
        public IRPSCollectionEditor<NCQuantityDecisionCollectionView,NCQuantityDecisionEntityView> MainConsult { get; set; } 
        public NCQuantityDecision Screen { get; set; }
        public NCQuantityDecisionCollectionView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class NCQuantityDecisionEntityView : View
    {
        public NCQuantityDecisionEntityView(NCQuantityDecision screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            SaveButton = RPSControlFactory.RPSSaveButton<NCQuantityDecisionEntityView>( this);
 
            DeleteButton = RPSControlFactory.RPSDeleteButton<NCQuantityDecisionEntityView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<NCQuantityDecisionEntityView,NCQuantityDecisionCollectionView>( this,Screen.NCQuantityDecisionCollectionView);
 
            BackButton = RPSControlFactory.RPSBackButton<NCQuantityDecisionEntityView,NCQuantityDecisionCollectionView>( this,Screen.NCQuantityDecisionCollectionView);
 
            CodDecision = RPSControlFactory.CreateRPSTextBox<NCQuantityDecisionEntityView>("1fa00b54-86df-4047-9e0f-889a8b2ea2da","","",true, this);
 
            Desciption = RPSControlFactory.CreateRPSTextBox<NCQuantityDecisionEntityView>("5d0b44f3-7e30-4760-9160-e37ad1a0a718","","",false, this);
 

        }
        public IRPSSaveButton<NCQuantityDecisionEntityView> SaveButton { get; set; } 
        public IRPSButton<NCQuantityDecisionEntityView> DeleteButton { get; set; } 
        public IRPSButton<NCQuantityDecisionEntityView,NCQuantityDecisionCollectionView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<NCQuantityDecisionEntityView,NCQuantityDecisionCollectionView> BackButton { get; set; } 
        public IRPSTextBox<NCQuantityDecisionEntityView> CodDecision { get; set; } 
        public IRPSTextBox<NCQuantityDecisionEntityView> Desciption { get; set; } 
        public NCQuantityDecision Screen { get; set; }
        public NCQuantityDecisionEntityView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}