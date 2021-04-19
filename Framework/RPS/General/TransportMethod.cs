    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.General.TransportMethod
{
    //RPS VERSION 1.0.0.0
    public partial class TransportMethod:Screen
    {
        public TransportMethod():base()
        {
            this.URL = "general.transportmethod";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            TransportMethodCollectionView  = new TransportMethodCollectionView(this); 
            TransportMethodEntityView  = new TransportMethodEntityView(this); 
            TransportMethodCollectionView.InitializeControls(); 
            TransportMethodEntityView.InitializeControls(); 
           
        }
      
            public TransportMethodCollectionView TransportMethodCollectionView {get; set; } 
            public TransportMethodEntityView TransportMethodEntityView {get; set; } 
    }
            
    public partial class TransportMethodCollectionView : View
    {
        public TransportMethodCollectionView(TransportMethod screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            NewButton = RPSControlFactory.RPSNewButton<TransportMethodCollectionView,TransportMethodEntityView>( this,Screen.TransportMethodEntityView);
 
            CollectionInit params_MainConsult = new CollectionInit(){IDDescriptor = "dc5350a6-3111-45bd-95fd-a3823b8bffa1",CSSSelectorDescriptor = "",XPathDescriptor = ""};
            MainConsult = RPSControlFactory.RPSCreateCollection<TransportMethodCollectionView,TransportMethodEntityView>( params_MainConsult,this,Screen.TransportMethodEntityView);
 

        }
        public IRPSButton<TransportMethodCollectionView,TransportMethodEntityView> NewButton { get; set; } 
        public IRPSCollectionEditor<TransportMethodCollectionView,TransportMethodEntityView> MainConsult { get; set; } 
        public TransportMethod Screen { get; set; }
        public TransportMethodCollectionView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class TransportMethodEntityView : View
    {
        public TransportMethodEntityView(TransportMethod screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            SaveButton = RPSControlFactory.RPSSaveButton<TransportMethodEntityView>( this);
 
            DeleteButton = RPSControlFactory.RPSDeleteButton<TransportMethodEntityView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<TransportMethodEntityView,TransportMethodCollectionView>( this,Screen.TransportMethodCollectionView);
 
            BackButton = RPSControlFactory.RPSBackButton<TransportMethodEntityView,TransportMethodCollectionView>( this,Screen.TransportMethodCollectionView);
 
            CodTransportMethod = RPSControlFactory.CreateRPSTextBox<TransportMethodEntityView>("a63b580c-c40f-4650-a291-eb04b6dfea10","","",true, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<TransportMethodEntityView>("9b4aaa43-ce0d-4ebd-b760-329e73890872","","",false, this);
 

        }
        public IRPSSaveButton<TransportMethodEntityView> SaveButton { get; set; } 
        public IRPSButton<TransportMethodEntityView> DeleteButton { get; set; } 
        public IRPSButton<TransportMethodEntityView,TransportMethodCollectionView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<TransportMethodEntityView,TransportMethodCollectionView> BackButton { get; set; } 
        public IRPSTextBox<TransportMethodEntityView> CodTransportMethod { get; set; } 
        public IRPSTextBox<TransportMethodEntityView> Description { get; set; } 
        public TransportMethod Screen { get; set; }
        public TransportMethodEntityView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}