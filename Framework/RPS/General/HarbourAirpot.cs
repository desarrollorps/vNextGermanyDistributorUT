    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.General.HarbourAirpot
{
    //RPS VERSION 1.0.0.0
    public partial class HarbourAirpot:Screen
    {
        public HarbourAirpot():base()
        {
            this.URL = "general.harbourairpot";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            HarborAirportCollectionView  = new HarborAirportCollectionView(this); 
            HarborAirportEntityView  = new HarborAirportEntityView(this); 
            HarborAirportCollectionView.InitializeControls(); 
            HarborAirportEntityView.InitializeControls(); 
           
        }
      
            public HarborAirportCollectionView HarborAirportCollectionView {get; set; } 
            public HarborAirportEntityView HarborAirportEntityView {get; set; } 
    }
            
    public partial class HarborAirportCollectionView : View
    {
        public HarborAirportCollectionView(HarbourAirpot screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            NewButton = RPSControlFactory.RPSNewButton<HarborAirportCollectionView,HarborAirportEntityView>( this,Screen.HarborAirportEntityView);
 
            CollectionInit params_MainConsult = new CollectionInit(){IDDescriptor = "cf679329-5229-42f6-b84d-ea6c5bdfe5b4",CSSSelectorDescriptor = "",XPathDescriptor = ""};
            MainConsult = RPSControlFactory.RPSCreateCollection<HarborAirportCollectionView,HarborAirportEntityView>( params_MainConsult,this,Screen.HarborAirportEntityView);
 

        }
        public IRPSButton<HarborAirportCollectionView,HarborAirportEntityView> NewButton { get; set; } 
        public IRPSCollectionEditor<HarborAirportCollectionView,HarborAirportEntityView> MainConsult { get; set; } 
        public HarbourAirpot Screen { get; set; }
        public HarborAirportCollectionView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class HarborAirportEntityView : View
    {
        public HarborAirportEntityView(HarbourAirpot screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            SaveButton = RPSControlFactory.RPSSaveButton<HarborAirportEntityView>( this);
 
            DeleteButton = RPSControlFactory.RPSDeleteButton<HarborAirportEntityView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<HarborAirportEntityView,HarborAirportCollectionView>( this,Screen.HarborAirportCollectionView);
 
            BackButton = RPSControlFactory.RPSBackButton<HarborAirportEntityView,HarborAirportCollectionView>( this,Screen.HarborAirportCollectionView);
 
            CodHarborAirport = RPSControlFactory.CreateRPSTextBox<HarborAirportEntityView>("2ea4eab2-06c6-4832-bdd2-966626aef5a5","","",true, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<HarborAirportEntityView>("7cd39234-8e35-4a69-bc5a-3ee224948997","","",false, this);
 

        }
        public IRPSSaveButton<HarborAirportEntityView> SaveButton { get; set; } 
        public IRPSButton<HarborAirportEntityView> DeleteButton { get; set; } 
        public IRPSButton<HarborAirportEntityView,HarborAirportCollectionView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<HarborAirportEntityView,HarborAirportCollectionView> BackButton { get; set; } 
        public IRPSTextBox<HarborAirportEntityView> CodHarborAirport { get; set; } 
        public IRPSTextBox<HarborAirportEntityView> Description { get; set; } 
        public HarbourAirpot Screen { get; set; }
        public HarborAirportEntityView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}