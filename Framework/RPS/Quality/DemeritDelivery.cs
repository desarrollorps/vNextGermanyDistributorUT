    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.Quality.DemeritDelivery
{
    //RPS VERSION 1.0.0.0
    public partial class DemeritDelivery:Screen
    {
        public DemeritDelivery():base()
        {
            this.URL = "quality.demeritdelivery";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            DemeritDeliveryCollectionView  = new DemeritDeliveryCollectionView(this); 
            DemeritDeliveryEntityView  = new DemeritDeliveryEntityView(this); 
            DemeritDeliveryCollectionView.InitializeControls(); 
            DemeritDeliveryEntityView.InitializeControls(); 
           
        }
      
            public DemeritDeliveryCollectionView DemeritDeliveryCollectionView {get; set; } 
            public DemeritDeliveryEntityView DemeritDeliveryEntityView {get; set; } 
    }
            
    public partial class DemeritDeliveryCollectionView : View
    {
        public DemeritDeliveryCollectionView(DemeritDelivery screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            NewButton = RPSControlFactory.RPSNewButton<DemeritDeliveryCollectionView,DemeritDeliveryEntityView>( this,Screen.DemeritDeliveryEntityView);
 
            CollectionInit params_MainConsult = new CollectionInit(){IDDescriptor = "eeae8784-aad1-4d55-8036-2e0363e8052a",CSSSelectorDescriptor = "",XPathDescriptor = ""};
            MainConsult = RPSControlFactory.RPSCreateCollection<DemeritDeliveryCollectionView,DemeritDeliveryEntityView>( params_MainConsult,this,Screen.DemeritDeliveryEntityView);
 

        }
        public IRPSButton<DemeritDeliveryCollectionView,DemeritDeliveryEntityView> NewButton { get; set; } 
        public IRPSCollectionEditor<DemeritDeliveryCollectionView,DemeritDeliveryEntityView> MainConsult { get; set; } 
        public DemeritDelivery Screen { get; set; }
        public DemeritDeliveryCollectionView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class DemeritDeliveryEntityView : View
    {
        public DemeritDeliveryEntityView(DemeritDelivery screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            SaveButton = RPSControlFactory.RPSSaveButton<DemeritDeliveryEntityView>( this);
 
            DeleteButton = RPSControlFactory.RPSDeleteButton<DemeritDeliveryEntityView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<DemeritDeliveryEntityView,DemeritDeliveryCollectionView>( this,Screen.DemeritDeliveryCollectionView);
 
            BackButton = RPSControlFactory.RPSBackButton<DemeritDeliveryEntityView,DemeritDeliveryCollectionView>( this,Screen.DemeritDeliveryCollectionView);
 
            LowerLimit = RPSControlFactory.CreateRPSFormattedTextBox<DemeritDeliveryEntityView>("5498b806-6381-4180-ab25-2804dc74325d","","",true, this);
 
            Point = RPSControlFactory.CreateRPSFormattedTextBox<DemeritDeliveryEntityView>("7bbed787-252e-428b-9edf-5f99a1fefbc2","","",true, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<DemeritDeliveryEntityView>("149ff3fd-db8f-4f7f-88a5-4db8e35f2097","","",false, this);
 

        }
        public IRPSSaveButton<DemeritDeliveryEntityView> SaveButton { get; set; } 
        public IRPSButton<DemeritDeliveryEntityView> DeleteButton { get; set; } 
        public IRPSButton<DemeritDeliveryEntityView,DemeritDeliveryCollectionView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<DemeritDeliveryEntityView,DemeritDeliveryCollectionView> BackButton { get; set; } 
        public IRPSTextBox<DemeritDeliveryEntityView> LowerLimit { get; set; } 
        public IRPSTextBox<DemeritDeliveryEntityView> Point { get; set; } 
        public IRPSTextBox<DemeritDeliveryEntityView> Description { get; set; } 
        public DemeritDelivery Screen { get; set; }
        public DemeritDeliveryEntityView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}