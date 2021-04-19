    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.Purchase.FrameworkContractStatus
{
    //RPS VERSION 1.0.0.0
    public partial class FrameworkContractStatus:Screen
    {
        public FrameworkContractStatus():base()
        {
            this.URL = "purchase.frameworkcontractstatus";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            FrameworkContractStatusCollectionView  = new FrameworkContractStatusCollectionView(this); 
            FrameworkContractStatusEntityView  = new FrameworkContractStatusEntityView(this); 
            FrameworkContractStatusCollectionView.InitializeControls(); 
            FrameworkContractStatusEntityView.InitializeControls(); 
           
        }
      
            public FrameworkContractStatusCollectionView FrameworkContractStatusCollectionView {get; set; } 
            public FrameworkContractStatusEntityView FrameworkContractStatusEntityView {get; set; } 
    }
            
    public partial class FrameworkContractStatusCollectionView : View
    {
        public FrameworkContractStatusCollectionView(FrameworkContractStatus screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            NewButton = RPSControlFactory.RPSNewButton<FrameworkContractStatusCollectionView,FrameworkContractStatusEntityView>( this,Screen.FrameworkContractStatusEntityView);
 
            CollectionInit params_MainConsult = new CollectionInit(){IDDescriptor = "5b3169e1-7334-4dcc-9e83-4d798eeea654",CSSSelectorDescriptor = "",XPathDescriptor = ""};
            MainConsult = RPSControlFactory.RPSCreateCollection<FrameworkContractStatusCollectionView,FrameworkContractStatusEntityView>( params_MainConsult,this,Screen.FrameworkContractStatusEntityView);
 

        }
        public IRPSButton<FrameworkContractStatusCollectionView,FrameworkContractStatusEntityView> NewButton { get; set; } 
        public IRPSCollectionEditor<FrameworkContractStatusCollectionView,FrameworkContractStatusEntityView> MainConsult { get; set; } 
        public FrameworkContractStatus Screen { get; set; }
        public FrameworkContractStatusCollectionView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class FrameworkContractStatusEntityView : View
    {
        public FrameworkContractStatusEntityView(FrameworkContractStatus screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            SaveButton = RPSControlFactory.RPSSaveButton<FrameworkContractStatusEntityView>( this);
 
            DeleteButton = RPSControlFactory.RPSDeleteButton<FrameworkContractStatusEntityView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<FrameworkContractStatusEntityView,FrameworkContractStatusCollectionView>( this,Screen.FrameworkContractStatusCollectionView);
 
            BackButton = RPSControlFactory.RPSBackButton<FrameworkContractStatusEntityView,FrameworkContractStatusCollectionView>( this,Screen.FrameworkContractStatusCollectionView);
 
            CodFrameworkContractStatus = RPSControlFactory.CreateRPSTextBox<FrameworkContractStatusEntityView>("21e10d16-88ba-460c-afb6-a0c05feebd40","","",true, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<FrameworkContractStatusEntityView>("3043fc37-40ea-4b39-aa76-0be79e68d2ea","","",false, this);
 
            StatusType = RPSControlFactory.CreateRPSEnumComboBox<FrameworkContractStatusEntityView>("2f809e09-5f57-49f5-a1bd-b434981861a7","","",true, this);
 

        }
        public IRPSSaveButton<FrameworkContractStatusEntityView> SaveButton { get; set; } 
        public IRPSButton<FrameworkContractStatusEntityView> DeleteButton { get; set; } 
        public IRPSButton<FrameworkContractStatusEntityView,FrameworkContractStatusCollectionView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<FrameworkContractStatusEntityView,FrameworkContractStatusCollectionView> BackButton { get; set; } 
        public IRPSTextBox<FrameworkContractStatusEntityView> CodFrameworkContractStatus { get; set; } 
        public IRPSTextBox<FrameworkContractStatusEntityView> Description { get; set; } 
        public IRPSComboBox<FrameworkContractStatusEntityView> StatusType { get; set; } 
        public FrameworkContractStatus Screen { get; set; }
        public FrameworkContractStatusEntityView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}