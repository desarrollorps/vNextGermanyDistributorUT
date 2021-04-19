    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.Sales.ReturnCauseSL
{
    //RPS VERSION 1.0.0.0
    public partial class ReturnCauseSL:Screen
    {
        public ReturnCauseSL():base()
        {
            this.URL = "sales.returncausesl";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            ReturnCauseSLCollectionView  = new ReturnCauseSLCollectionView(this); 
            ReturnCauseSLEntityView  = new ReturnCauseSLEntityView(this); 
            ReturnCauseSLCollectionView.InitializeControls(); 
            ReturnCauseSLEntityView.InitializeControls(); 
           
        }
      
            public ReturnCauseSLCollectionView ReturnCauseSLCollectionView {get; set; } 
            public ReturnCauseSLEntityView ReturnCauseSLEntityView {get; set; } 
    }
            
    public partial class ReturnCauseSLCollectionView : View
    {
        public ReturnCauseSLCollectionView(ReturnCauseSL screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            NewButton = RPSControlFactory.RPSNewButton<ReturnCauseSLCollectionView,ReturnCauseSLEntityView>( this,Screen.ReturnCauseSLEntityView);
 
            CollectionInit params_MainConsult = new CollectionInit(){IDDescriptor = "409d721e-523a-403d-957b-a8185bb029c0",CSSSelectorDescriptor = "",XPathDescriptor = ""};
            MainConsult = RPSControlFactory.RPSCreateCollection<ReturnCauseSLCollectionView,ReturnCauseSLEntityView>( params_MainConsult,this,Screen.ReturnCauseSLEntityView);
 

        }
        public IRPSButton<ReturnCauseSLCollectionView,ReturnCauseSLEntityView> NewButton { get; set; } 
        public IRPSCollectionEditor<ReturnCauseSLCollectionView,ReturnCauseSLEntityView> MainConsult { get; set; } 
        public ReturnCauseSL Screen { get; set; }
        public ReturnCauseSLCollectionView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class ReturnCauseSLEntityView : View
    {
        public ReturnCauseSLEntityView(ReturnCauseSL screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            SaveButton = RPSControlFactory.RPSSaveButton<ReturnCauseSLEntityView>( this);
 
            DeleteButton = RPSControlFactory.RPSDeleteButton<ReturnCauseSLEntityView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<ReturnCauseSLEntityView,ReturnCauseSLCollectionView>( this,Screen.ReturnCauseSLCollectionView);
 
            BackButton = RPSControlFactory.RPSBackButton<ReturnCauseSLEntityView,ReturnCauseSLCollectionView>( this,Screen.ReturnCauseSLCollectionView);
 
            CodReturnCause = RPSControlFactory.CreateRPSTextBox<ReturnCauseSLEntityView>("257cd439-09d0-4ae4-bfc0-de9653965490","","",true, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<ReturnCauseSLEntityView>("799ee6c5-e356-4de6-bb59-b10a90efd275","","",false, this);
 
            IDDeliveryNoteType = RPSControlFactory.CreateRPSComboBox<ReturnCauseSLEntityView>("ef5b2276-a013-4835-81b3-8aebe646a562","","",true, this);
 

        }
        public IRPSSaveButton<ReturnCauseSLEntityView> SaveButton { get; set; } 
        public IRPSButton<ReturnCauseSLEntityView> DeleteButton { get; set; } 
        public IRPSButton<ReturnCauseSLEntityView,ReturnCauseSLCollectionView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<ReturnCauseSLEntityView,ReturnCauseSLCollectionView> BackButton { get; set; } 
        public IRPSTextBox<ReturnCauseSLEntityView> CodReturnCause { get; set; } 
        public IRPSTextBox<ReturnCauseSLEntityView> Description { get; set; } 
        public IRPSComboBox<ReturnCauseSLEntityView> IDDeliveryNoteType { get; set; } 
        public ReturnCauseSL Screen { get; set; }
        public ReturnCauseSLEntityView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}