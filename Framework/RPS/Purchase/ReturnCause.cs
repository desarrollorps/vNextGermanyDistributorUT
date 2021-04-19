    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.Purchase.ReturnCause
{
    //RPS VERSION 1.0.0.0
    public partial class ReturnCause:Screen
    {
        public ReturnCause():base()
        {
            this.URL = "purchase.returncause";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            ReturnCauseCollectionView  = new ReturnCauseCollectionView(this); 
            ReturnCauseEntityView  = new ReturnCauseEntityView(this); 
            ReturnCauseCollectionView.InitializeControls(); 
            ReturnCauseEntityView.InitializeControls(); 
           
        }
      
            public ReturnCauseCollectionView ReturnCauseCollectionView {get; set; } 
            public ReturnCauseEntityView ReturnCauseEntityView {get; set; } 
    }
            
    public partial class ReturnCauseCollectionView : View
    {
        public ReturnCauseCollectionView(ReturnCause screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            NewButton = RPSControlFactory.RPSNewButton<ReturnCauseCollectionView,ReturnCauseEntityView>( this,Screen.ReturnCauseEntityView);
 
            CollectionInit params_MainConsult = new CollectionInit(){IDDescriptor = "11f96c2f-38c3-475a-ba12-c41f5f2c46e8",CSSSelectorDescriptor = "",XPathDescriptor = ""};
            MainConsult = RPSControlFactory.RPSCreateCollection<ReturnCauseCollectionView,ReturnCauseEntityView>( params_MainConsult,this,Screen.ReturnCauseEntityView);
 

        }
        public IRPSButton<ReturnCauseCollectionView,ReturnCauseEntityView> NewButton { get; set; } 
        public IRPSCollectionEditor<ReturnCauseCollectionView,ReturnCauseEntityView> MainConsult { get; set; } 
        public ReturnCause Screen { get; set; }
        public ReturnCauseCollectionView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class ReturnCauseEntityView : View
    {
        public ReturnCauseEntityView(ReturnCause screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            SaveButton = RPSControlFactory.RPSSaveButton<ReturnCauseEntityView>( this);
 
            DeleteButton = RPSControlFactory.RPSDeleteButton<ReturnCauseEntityView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<ReturnCauseEntityView,ReturnCauseCollectionView>( this,Screen.ReturnCauseCollectionView);
 
            BackButton = RPSControlFactory.RPSBackButton<ReturnCauseEntityView,ReturnCauseCollectionView>( this,Screen.ReturnCauseCollectionView);
 
            CodReturnCause = RPSControlFactory.CreateRPSTextBox<ReturnCauseEntityView>("44377157-8099-4659-8fea-4d80af8330aa","","",true, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<ReturnCauseEntityView>("f518542d-fe16-423e-9473-0ac4d217e6e7","","",false, this);
 
            IDDeliveryNoteType = RPSControlFactory.CreateRPSComboBox<ReturnCauseEntityView>("5abbf312-147a-4787-9949-0854fdf5b297","","",true, this);
 

        }
        public IRPSSaveButton<ReturnCauseEntityView> SaveButton { get; set; } 
        public IRPSButton<ReturnCauseEntityView> DeleteButton { get; set; } 
        public IRPSButton<ReturnCauseEntityView,ReturnCauseCollectionView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<ReturnCauseEntityView,ReturnCauseCollectionView> BackButton { get; set; } 
        public IRPSTextBox<ReturnCauseEntityView> CodReturnCause { get; set; } 
        public IRPSTextBox<ReturnCauseEntityView> Description { get; set; } 
        public IRPSComboBox<ReturnCauseEntityView> IDDeliveryNoteType { get; set; } 
        public ReturnCause Screen { get; set; }
        public ReturnCauseEntityView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}