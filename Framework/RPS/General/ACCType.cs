    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.General.ACCType
{
    //RPS VERSION 1.0.0.0
    public partial class ACCType:Screen
    {
        public ACCType():base()
        {
            this.URL = "general.acctype";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            ACCTypeCollectionView  = new ACCTypeCollectionView(this); 
            ACCTypeEntityView  = new ACCTypeEntityView(this); 
            ACCTypeCollectionView.InitializeControls(); 
            ACCTypeEntityView.InitializeControls(); 
           
        }
      
            public ACCTypeCollectionView ACCTypeCollectionView {get; set; } 
            public ACCTypeEntityView ACCTypeEntityView {get; set; } 
    }
            
    public partial class ACCTypeCollectionView : View
    {
        public ACCTypeCollectionView(ACCType screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            NewButton = RPSControlFactory.RPSNewButton<ACCTypeCollectionView,ACCTypeEntityView>( this,Screen.ACCTypeEntityView);
 
            CollectionInit params_MainConsult = new CollectionInit(){IDDescriptor = "8da9c1e8-5634-4275-a36d-d36a36f31d81",CSSSelectorDescriptor = "",XPathDescriptor = ""};
            MainConsult = RPSControlFactory.RPSCreateCollection<ACCTypeCollectionView,ACCTypeEntityView>( params_MainConsult,this,Screen.ACCTypeEntityView);
 

        }
        public IRPSButton<ACCTypeCollectionView,ACCTypeEntityView> NewButton { get; set; } 
        public IRPSCollectionEditor<ACCTypeCollectionView,ACCTypeEntityView> MainConsult { get; set; } 
        public ACCType Screen { get; set; }
        public ACCTypeCollectionView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class ACCTypeEntityView : View
    {
        public ACCTypeEntityView(ACCType screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            SaveButton = RPSControlFactory.RPSSaveButton<ACCTypeEntityView>( this);
 
            DeleteButton = RPSControlFactory.RPSDeleteButton<ACCTypeEntityView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<ACCTypeEntityView,ACCTypeCollectionView>( this,Screen.ACCTypeCollectionView);
 
            BackButton = RPSControlFactory.RPSBackButton<ACCTypeEntityView,ACCTypeCollectionView>( this,Screen.ACCTypeCollectionView);
 
            CodACCType = RPSControlFactory.CreateRPSTextBox<ACCTypeEntityView>("8db774c1-9717-4bc9-a1e5-b0c92425f816","","",true, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<ACCTypeEntityView>("789a2cec-d4a8-4607-b9e8-c33c1ce62664","","",false, this);
 

        }
        public IRPSSaveButton<ACCTypeEntityView> SaveButton { get; set; } 
        public IRPSButton<ACCTypeEntityView> DeleteButton { get; set; } 
        public IRPSButton<ACCTypeEntityView,ACCTypeCollectionView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<ACCTypeEntityView,ACCTypeCollectionView> BackButton { get; set; } 
        public IRPSTextBox<ACCTypeEntityView> CodACCType { get; set; } 
        public IRPSTextBox<ACCTypeEntityView> Description { get; set; } 
        public ACCType Screen { get; set; }
        public ACCTypeEntityView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}