    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.Quality.CharacteristicClass
{
    //RPS VERSION 1.0.0.0
    public partial class CharacteristicClass:Screen
    {
        public CharacteristicClass():base()
        {
            this.URL = "quality.characteristicclass";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            CharacteristicClassCollectionView  = new CharacteristicClassCollectionView(this); 
            CharacteristicClassEntityView  = new CharacteristicClassEntityView(this); 
            CharacteristicClassCollectionView.InitializeControls(); 
            CharacteristicClassEntityView.InitializeControls(); 
           
        }
      
            public CharacteristicClassCollectionView CharacteristicClassCollectionView {get; set; } 
            public CharacteristicClassEntityView CharacteristicClassEntityView {get; set; } 
    }
            
    public partial class CharacteristicClassCollectionView : View
    {
        public CharacteristicClassCollectionView(CharacteristicClass screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            NewButton = RPSControlFactory.RPSNewButton<CharacteristicClassCollectionView,CharacteristicClassEntityView>( this,Screen.CharacteristicClassEntityView);
 
            CollectionInit params_MainConsult = new CollectionInit(){IDDescriptor = "f66c5ab1-f611-48e2-972c-79bf7e6542e0",CSSSelectorDescriptor = "",XPathDescriptor = ""};
            MainConsult = RPSControlFactory.RPSCreateCollection<CharacteristicClassCollectionView,CharacteristicClassEntityView>( params_MainConsult,this,Screen.CharacteristicClassEntityView);
 

        }
        public IRPSButton<CharacteristicClassCollectionView,CharacteristicClassEntityView> NewButton { get; set; } 
        public IRPSCollectionEditor<CharacteristicClassCollectionView,CharacteristicClassEntityView> MainConsult { get; set; } 
        public CharacteristicClass Screen { get; set; }
        public CharacteristicClassCollectionView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class CharacteristicClassEntityView : View
    {
        public CharacteristicClassEntityView(CharacteristicClass screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            SaveButton = RPSControlFactory.RPSSaveButton<CharacteristicClassEntityView>( this);
 
            DeleteButton = RPSControlFactory.RPSDeleteButton<CharacteristicClassEntityView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<CharacteristicClassEntityView,CharacteristicClassCollectionView>( this,Screen.CharacteristicClassCollectionView);
 
            BackButton = RPSControlFactory.RPSBackButton<CharacteristicClassEntityView,CharacteristicClassCollectionView>( this,Screen.CharacteristicClassCollectionView);
 
            CodCharacteristicClass = RPSControlFactory.CreateRPSTextBox<CharacteristicClassEntityView>("84944d03-34e0-4829-baa5-e89426dc3756","","",true, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<CharacteristicClassEntityView>("acd17673-519b-4331-b377-cf2700dd57f8","","",false, this);
 

        }
        public IRPSSaveButton<CharacteristicClassEntityView> SaveButton { get; set; } 
        public IRPSButton<CharacteristicClassEntityView> DeleteButton { get; set; } 
        public IRPSButton<CharacteristicClassEntityView,CharacteristicClassCollectionView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<CharacteristicClassEntityView,CharacteristicClassCollectionView> BackButton { get; set; } 
        public IRPSTextBox<CharacteristicClassEntityView> CodCharacteristicClass { get; set; } 
        public IRPSTextBox<CharacteristicClassEntityView> Description { get; set; } 
        public CharacteristicClass Screen { get; set; }
        public CharacteristicClassEntityView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}