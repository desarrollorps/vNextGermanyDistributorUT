    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.ReceivablePayable.ForecastType
{
    //RPS VERSION 1.0.0.0
    public partial class ForecastType:Screen
    {
        public ForecastType():base()
        {
            this.URL = "receivablepayable.forecasttype";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            ForecastTypeCollectionView  = new ForecastTypeCollectionView(this); 
            ForecastTypeEntityView  = new ForecastTypeEntityView(this); 
            ForecastTypeCollectionView.InitializeControls(); 
            ForecastTypeEntityView.InitializeControls(); 
           
        }
      
            public ForecastTypeCollectionView ForecastTypeCollectionView {get; set; } 
            public ForecastTypeEntityView ForecastTypeEntityView {get; set; } 
    }
            
    public partial class ForecastTypeCollectionView : View
    {
        public ForecastTypeCollectionView(ForecastType screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            NewButton = RPSControlFactory.RPSNewButton<ForecastTypeCollectionView,ForecastTypeEntityView>( this,Screen.ForecastTypeEntityView);
 
            CollectionInit params_MainConsult = new CollectionInit(){IDDescriptor = "0e6119c7-0497-4aae-91dc-6afce5284239",CSSSelectorDescriptor = "",XPathDescriptor = ""};
            MainConsult = RPSControlFactory.RPSCreateCollection<ForecastTypeCollectionView,ForecastTypeEntityView>( params_MainConsult,this,Screen.ForecastTypeEntityView);
 

        }
        public IRPSButton<ForecastTypeCollectionView,ForecastTypeEntityView> NewButton { get; set; } 
        public IRPSCollectionEditor<ForecastTypeCollectionView,ForecastTypeEntityView> MainConsult { get; set; } 
        public ForecastType Screen { get; set; }
        public ForecastTypeCollectionView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class ForecastTypeEntityView : View
    {
        public ForecastTypeEntityView(ForecastType screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            SaveButton = RPSControlFactory.RPSSaveButton<ForecastTypeEntityView>( this);
 
            DeleteButton = RPSControlFactory.RPSDeleteButton<ForecastTypeEntityView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<ForecastTypeEntityView,ForecastTypeCollectionView>( this,Screen.ForecastTypeCollectionView);
 
            BackButton = RPSControlFactory.RPSBackButton<ForecastTypeEntityView,ForecastTypeCollectionView>( this,Screen.ForecastTypeCollectionView);
 
            CodForecastType = RPSControlFactory.CreateRPSTextBox<ForecastTypeEntityView>("ac324112-c57a-4ea9-a456-191ea1be1cbd","","",false, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<ForecastTypeEntityView>("5345a0ec-90eb-4bf1-bc67-b65a4ae28c3a","","",false, this);
 
            Type = RPSControlFactory.CreateRPSEnumComboBox<ForecastTypeEntityView>("d03472bd-161f-44cb-b87c-d8c662605513","","",false, this);
 

        }
        public IRPSSaveButton<ForecastTypeEntityView> SaveButton { get; set; } 
        public IRPSButton<ForecastTypeEntityView> DeleteButton { get; set; } 
        public IRPSButton<ForecastTypeEntityView,ForecastTypeCollectionView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<ForecastTypeEntityView,ForecastTypeCollectionView> BackButton { get; set; } 
        public IRPSTextBox<ForecastTypeEntityView> CodForecastType { get; set; } 
        public IRPSTextBox<ForecastTypeEntityView> Description { get; set; } 
        public IRPSComboBox<ForecastTypeEntityView> Type { get; set; } 
        public ForecastType Screen { get; set; }
        public ForecastTypeEntityView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}