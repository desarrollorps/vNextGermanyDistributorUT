    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.Quality.CharacteristicType
{
    //RPS VERSION 1.0.0.0
    public partial class CharacteristicType:Screen
    {
        public CharacteristicType():base()
        {
            this.URL = "quality.characteristictype";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            CharacteristicTypeCollectionView  = new CharacteristicTypeCollectionView(this); 
            CharacteristicTypeEntityView  = new CharacteristicTypeEntityView(this); 
            CharacteristicTypeCollectionView.InitializeControls(); 
            CharacteristicTypeEntityView.InitializeControls(); 
           
        }
      
            public CharacteristicTypeCollectionView CharacteristicTypeCollectionView {get; set; } 
            public CharacteristicTypeEntityView CharacteristicTypeEntityView {get; set; } 
    }
            
    public partial class CharacteristicTypeCollectionView : View
    {
        public CharacteristicTypeCollectionView(CharacteristicType screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            NewButton = RPSControlFactory.RPSNewButton<CharacteristicTypeCollectionView,CharacteristicTypeEntityView>( this,Screen.CharacteristicTypeEntityView);
 
            CollectionInit params_MainConsult = new CollectionInit(){IDDescriptor = "d21f27b7-7e05-4444-b197-c2d00ddcebda",CSSSelectorDescriptor = "",XPathDescriptor = ""};
            MainConsult = RPSControlFactory.RPSCreateCollection<CharacteristicTypeCollectionView,CharacteristicTypeEntityView>( params_MainConsult,this,Screen.CharacteristicTypeEntityView);
 

        }
        public IRPSButton<CharacteristicTypeCollectionView,CharacteristicTypeEntityView> NewButton { get; set; } 
        public IRPSCollectionEditor<CharacteristicTypeCollectionView,CharacteristicTypeEntityView> MainConsult { get; set; } 
        public CharacteristicType Screen { get; set; }
        public CharacteristicTypeCollectionView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class CharacteristicTypeEntityView : View
    {
        public CharacteristicTypeEntityView(CharacteristicType screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            SaveButton = RPSControlFactory.RPSSaveButton<CharacteristicTypeEntityView>( this);
 
            DeleteButton = RPSControlFactory.RPSDeleteButton<CharacteristicTypeEntityView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<CharacteristicTypeEntityView,CharacteristicTypeCollectionView>( this,Screen.CharacteristicTypeCollectionView);
 
            BackButton = RPSControlFactory.RPSBackButton<CharacteristicTypeEntityView,CharacteristicTypeCollectionView>( this,Screen.CharacteristicTypeCollectionView);
 
            CodCharacteristicType = RPSControlFactory.CreateRPSTextBox<CharacteristicTypeEntityView>("45c2ad31-04ec-4a2d-8220-0bfdbcb546f8","","",true, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<CharacteristicTypeEntityView>("afcd0b94-0847-4900-b725-aa0eda4f745d","","",false, this);
 

        }
        public IRPSSaveButton<CharacteristicTypeEntityView> SaveButton { get; set; } 
        public IRPSButton<CharacteristicTypeEntityView> DeleteButton { get; set; } 
        public IRPSButton<CharacteristicTypeEntityView,CharacteristicTypeCollectionView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<CharacteristicTypeEntityView,CharacteristicTypeCollectionView> BackButton { get; set; } 
        public IRPSTextBox<CharacteristicTypeEntityView> CodCharacteristicType { get; set; } 
        public IRPSTextBox<CharacteristicTypeEntityView> Description { get; set; } 
        public CharacteristicType Screen { get; set; }
        public CharacteristicTypeEntityView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}