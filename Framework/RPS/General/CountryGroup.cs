    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.General.CountryGroup
{
    //RPS VERSION 1.0.0.0
    public partial class CountryGroup:Screen
    {
        public CountryGroup():base()
        {
            this.URL = "general.countrygroup";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            CountryGroupCollectionView  = new CountryGroupCollectionView(this); 
            CountryGroupEntityView  = new CountryGroupEntityView(this); 
            CountryGroupCollectionView.InitializeControls(); 
            CountryGroupEntityView.InitializeControls(); 
           
        }
      
            public CountryGroupCollectionView CountryGroupCollectionView {get; set; } 
            public CountryGroupEntityView CountryGroupEntityView {get; set; } 
    }
            
    public partial class CountryGroupCollectionView : View
    {
        public CountryGroupCollectionView(CountryGroup screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            NewButton = RPSControlFactory.RPSNewButton<CountryGroupCollectionView,CountryGroupEntityView>( this,Screen.CountryGroupEntityView);
 
            CollectionInit params_MainConsult = new CollectionInit(){IDDescriptor = "e70b2ad0-344c-45a0-b3d4-11fa79a47cbc",CSSSelectorDescriptor = "",XPathDescriptor = ""};
            MainConsult = RPSControlFactory.RPSCreateCollection<CountryGroupCollectionView,CountryGroupEntityView>( params_MainConsult,this,Screen.CountryGroupEntityView);
 

        }
        public IRPSButton<CountryGroupCollectionView,CountryGroupEntityView> NewButton { get; set; } 
        public IRPSCollectionEditor<CountryGroupCollectionView,CountryGroupEntityView> MainConsult { get; set; } 
        public CountryGroup Screen { get; set; }
        public CountryGroupCollectionView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class CountryGroupEntityView : View
    {
        public CountryGroupEntityView(CountryGroup screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            SaveButton = RPSControlFactory.RPSSaveButton<CountryGroupEntityView>( this);
 
            DeleteButton = RPSControlFactory.RPSDeleteButton<CountryGroupEntityView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<CountryGroupEntityView,CountryGroupCollectionView>( this,Screen.CountryGroupCollectionView);
 
            BackButton = RPSControlFactory.RPSBackButton<CountryGroupEntityView,CountryGroupCollectionView>( this,Screen.CountryGroupCollectionView);
 
            CodCountryGroup = RPSControlFactory.CreateRPSTextBox<CountryGroupEntityView>("9a46a273-8866-4ab5-863a-8880f04c44c2","","",true, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<CountryGroupEntityView>("434f3364-4c01-4037-b4cb-1ea54b905780","","",false, this);
 

        }
        public IRPSSaveButton<CountryGroupEntityView> SaveButton { get; set; } 
        public IRPSButton<CountryGroupEntityView> DeleteButton { get; set; } 
        public IRPSButton<CountryGroupEntityView,CountryGroupCollectionView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<CountryGroupEntityView,CountryGroupCollectionView> BackButton { get; set; } 
        public IRPSTextBox<CountryGroupEntityView> CodCountryGroup { get; set; } 
        public IRPSTextBox<CountryGroupEntityView> Description { get; set; } 
        public CountryGroup Screen { get; set; }
        public CountryGroupEntityView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}