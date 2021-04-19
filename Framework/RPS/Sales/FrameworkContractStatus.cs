    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.Sales.FrameworkContractStatus
{
    //RPS VERSION 1.0.0.0
    public partial class FrameworkContractStatus:Screen
    {
        public FrameworkContractStatus():base()
        {
            this.URL = "sales.frameworkcontractstatus";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            FrameworkContractStatusSLCollectionView  = new FrameworkContractStatusSLCollectionView(this); 
            FrameworkContractStatusSLEntityView  = new FrameworkContractStatusSLEntityView(this); 
            FrameworkContractStatusSLCollectionView.InitializeControls(); 
            FrameworkContractStatusSLEntityView.InitializeControls(); 
           
        }
      
            public FrameworkContractStatusSLCollectionView FrameworkContractStatusSLCollectionView {get; set; } 
            public FrameworkContractStatusSLEntityView FrameworkContractStatusSLEntityView {get; set; } 
    }
            
    public partial class FrameworkContractStatusSLCollectionView : View
    {
        public FrameworkContractStatusSLCollectionView(FrameworkContractStatus screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            NewButton = RPSControlFactory.RPSNewButton<FrameworkContractStatusSLCollectionView,FrameworkContractStatusSLEntityView>( this,Screen.FrameworkContractStatusSLEntityView);
 
            CollectionInit params_MainConsult = new CollectionInit(){IDDescriptor = "8a1a5c5a-0ff8-4256-872c-283ed8ff5d44",CSSSelectorDescriptor = "",XPathDescriptor = ""};
            MainConsult = RPSControlFactory.RPSCreateCollection<FrameworkContractStatusSLCollectionView,FrameworkContractStatusSLEntityView>( params_MainConsult,this,Screen.FrameworkContractStatusSLEntityView);
 

        }
        public IRPSButton<FrameworkContractStatusSLCollectionView,FrameworkContractStatusSLEntityView> NewButton { get; set; } 
        public IRPSCollectionEditor<FrameworkContractStatusSLCollectionView,FrameworkContractStatusSLEntityView> MainConsult { get; set; } 
        public FrameworkContractStatus Screen { get; set; }
        public FrameworkContractStatusSLCollectionView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class FrameworkContractStatusSLEntityView : View
    {
        public FrameworkContractStatusSLEntityView(FrameworkContractStatus screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            SaveButton = RPSControlFactory.RPSSaveButton<FrameworkContractStatusSLEntityView>( this);
 
            DeleteButton = RPSControlFactory.RPSDeleteButton<FrameworkContractStatusSLEntityView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<FrameworkContractStatusSLEntityView,FrameworkContractStatusSLCollectionView>( this,Screen.FrameworkContractStatusSLCollectionView);
 
            BackButton = RPSControlFactory.RPSBackButton<FrameworkContractStatusSLEntityView,FrameworkContractStatusSLCollectionView>( this,Screen.FrameworkContractStatusSLCollectionView);
 
            CodFrameworkContractStatus = RPSControlFactory.CreateRPSTextBox<FrameworkContractStatusSLEntityView>("1bbd31a2-cc36-45c1-86f0-66ba3a18da6e","","",true, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<FrameworkContractStatusSLEntityView>("c96a4866-f7cb-41e4-b821-fd0d59aaab96","","",false, this);
 
            StatusType = RPSControlFactory.CreateRPSEnumComboBox<FrameworkContractStatusSLEntityView>("8d2815b5-bd7d-4b72-8abf-684eeefaa991","","",true, this);
 

        }
        public IRPSSaveButton<FrameworkContractStatusSLEntityView> SaveButton { get; set; } 
        public IRPSButton<FrameworkContractStatusSLEntityView> DeleteButton { get; set; } 
        public IRPSButton<FrameworkContractStatusSLEntityView,FrameworkContractStatusSLCollectionView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<FrameworkContractStatusSLEntityView,FrameworkContractStatusSLCollectionView> BackButton { get; set; } 
        public IRPSTextBox<FrameworkContractStatusSLEntityView> CodFrameworkContractStatus { get; set; } 
        public IRPSTextBox<FrameworkContractStatusSLEntityView> Description { get; set; } 
        public IRPSComboBox<FrameworkContractStatusSLEntityView> StatusType { get; set; } 
        public FrameworkContractStatus Screen { get; set; }
        public FrameworkContractStatusSLEntityView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}