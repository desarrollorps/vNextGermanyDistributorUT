    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.General.BusinessType
{
    //RPS VERSION 1.0.0.0
    public partial class BusinessType:Screen
    {
        public BusinessType():base()
        {
            this.URL = "general.businesstype";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            BusinessTypeCollectionView  = new BusinessTypeCollectionView(this); 
            BusinessTypeEntityView  = new BusinessTypeEntityView(this); 
            BusinessTypeCollectionView.InitializeControls(); 
            BusinessTypeEntityView.InitializeControls(); 
           
        }
      
            public BusinessTypeCollectionView BusinessTypeCollectionView {get; set; } 
            public BusinessTypeEntityView BusinessTypeEntityView {get; set; } 
    }
            
    public partial class BusinessTypeCollectionView : View
    {
        public BusinessTypeCollectionView(BusinessType screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            NewButton = RPSControlFactory.RPSNewButton<BusinessTypeCollectionView,BusinessTypeEntityView>( this,Screen.BusinessTypeEntityView);
 
            CollectionInit params_MainConsult = new CollectionInit(){IDDescriptor = "fc2a1b35-10e1-4337-abc7-f3a087a02229",CSSSelectorDescriptor = "",XPathDescriptor = ""};
            MainConsult = RPSControlFactory.RPSCreateCollection<BusinessTypeCollectionView,BusinessTypeEntityView>( params_MainConsult,this,Screen.BusinessTypeEntityView);
 

        }
        public IRPSButton<BusinessTypeCollectionView,BusinessTypeEntityView> NewButton { get; set; } 
        public IRPSCollectionEditor<BusinessTypeCollectionView,BusinessTypeEntityView> MainConsult { get; set; } 
        public BusinessType Screen { get; set; }
        public BusinessTypeCollectionView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class BusinessTypeEntityView : View
    {
        public BusinessTypeEntityView(BusinessType screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            SaveButton = RPSControlFactory.RPSSaveButton<BusinessTypeEntityView>( this);
 
            DeleteButton = RPSControlFactory.RPSDeleteButton<BusinessTypeEntityView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<BusinessTypeEntityView,BusinessTypeCollectionView>( this,Screen.BusinessTypeCollectionView);
 
            BackButton = RPSControlFactory.RPSBackButton<BusinessTypeEntityView,BusinessTypeCollectionView>( this,Screen.BusinessTypeCollectionView);
 
            CodBusinessType = RPSControlFactory.CreateRPSTextBox<BusinessTypeEntityView>("98200b64-387d-4da6-9724-ff3e09dfd90a","","",true, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<BusinessTypeEntityView>("e658d13c-0088-45a0-b1d4-b90fbc61060a","","",false, this);
 

        }
        public IRPSSaveButton<BusinessTypeEntityView> SaveButton { get; set; } 
        public IRPSButton<BusinessTypeEntityView> DeleteButton { get; set; } 
        public IRPSButton<BusinessTypeEntityView,BusinessTypeCollectionView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<BusinessTypeEntityView,BusinessTypeCollectionView> BackButton { get; set; } 
        public IRPSTextBox<BusinessTypeEntityView> CodBusinessType { get; set; } 
        public IRPSTextBox<BusinessTypeEntityView> Description { get; set; } 
        public BusinessType Screen { get; set; }
        public BusinessTypeEntityView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}