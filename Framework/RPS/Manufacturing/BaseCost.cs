    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.Manufacturing.BaseCost
{
    //RPS VERSION 1.0.0.0
    public partial class BaseCost:Screen
    {
        public BaseCost():base()
        {
            this.URL = "manufacturing.basecost";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            BaseCostCollectionView  = new BaseCostCollectionView(this); 
            BaseCostEntityView  = new BaseCostEntityView(this); 
            BaseCostCollectionView.InitializeControls(); 
            BaseCostEntityView.InitializeControls(); 
           
        }
      
            public BaseCostCollectionView BaseCostCollectionView {get; set; } 
            public BaseCostEntityView BaseCostEntityView {get; set; } 
    }
            
    public partial class BaseCostCollectionView : View
    {
        public BaseCostCollectionView(BaseCost screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            NewButton = RPSControlFactory.RPSNewButton<BaseCostCollectionView,BaseCostEntityView>( this,Screen.BaseCostEntityView);
 
            CollectionInit params_MainConsult = new CollectionInit(){IDDescriptor = "b6556c85-9144-422f-b664-ff0b517b3318",CSSSelectorDescriptor = "",XPathDescriptor = ""};
            MainConsult = RPSControlFactory.RPSCreateCollection<BaseCostCollectionView,BaseCostEntityView>( params_MainConsult,this,Screen.BaseCostEntityView);
 

        }
        public IRPSButton<BaseCostCollectionView,BaseCostEntityView> NewButton { get; set; } 
        public IRPSCollectionEditor<BaseCostCollectionView,BaseCostEntityView> MainConsult { get; set; } 
        public BaseCost Screen { get; set; }
        public BaseCostCollectionView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class BaseCostEntityView : View
    {
        public BaseCostEntityView(BaseCost screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            SaveButton = RPSControlFactory.RPSSaveButton<BaseCostEntityView>( this);
 
            DeleteButton = RPSControlFactory.RPSDeleteButton<BaseCostEntityView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<BaseCostEntityView,BaseCostCollectionView>( this,Screen.BaseCostCollectionView);
 
            BackButton = RPSControlFactory.RPSBackButton<BaseCostEntityView,BaseCostCollectionView>( this,Screen.BaseCostCollectionView);
 
            CodBaseCost = RPSControlFactory.CreateRPSTextBox<BaseCostEntityView>("3db88df5-2cc6-43eb-99e0-6e1ad37ea379","","",true, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<BaseCostEntityView>("36ba1f86-409f-4545-9927-b872de1edcfb","","",false, this);
 
            TypeBaseCost = RPSControlFactory.CreateRPSEnumComboBox<BaseCostEntityView>("38c62540-4313-4586-853b-50014434d5fc","","",false, this);
 
            TypeValue = RPSControlFactory.CreateRPSEnumComboBox<BaseCostEntityView>("4e21a8fa-8a01-45fe-a788-ac783eeae2e4","","",false, this);
 

        }
        public IRPSSaveButton<BaseCostEntityView> SaveButton { get; set; } 
        public IRPSButton<BaseCostEntityView> DeleteButton { get; set; } 
        public IRPSButton<BaseCostEntityView,BaseCostCollectionView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<BaseCostEntityView,BaseCostCollectionView> BackButton { get; set; } 
        public IRPSTextBox<BaseCostEntityView> CodBaseCost { get; set; } 
        public IRPSTextBox<BaseCostEntityView> Description { get; set; } 
        public IRPSComboBox<BaseCostEntityView> TypeBaseCost { get; set; } 
        public IRPSComboBox<BaseCostEntityView> TypeValue { get; set; } 
        public BaseCost Screen { get; set; }
        public BaseCostEntityView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}