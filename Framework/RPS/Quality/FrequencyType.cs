    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.Quality.FrequencyType
{
    //RPS VERSION 1.0.0.0
    public partial class FrequencyType:Screen
    {
        public FrequencyType():base()
        {
            this.URL = "quality.frequencytype";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            FrequencyTypeCollectionView  = new FrequencyTypeCollectionView(this); 
            FrequencyTypeEntityView  = new FrequencyTypeEntityView(this); 
            FrequencyTypeCollectionView.InitializeControls(); 
            FrequencyTypeEntityView.InitializeControls(); 
           
        }
      
            public FrequencyTypeCollectionView FrequencyTypeCollectionView {get; set; } 
            public FrequencyTypeEntityView FrequencyTypeEntityView {get; set; } 
    }
            
    public partial class FrequencyTypeCollectionView : View
    {
        public FrequencyTypeCollectionView(FrequencyType screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            NewButton = RPSControlFactory.RPSNewButton<FrequencyTypeCollectionView,FrequencyTypeEntityView>( this,Screen.FrequencyTypeEntityView);
 
            CollectionInit params_MainConsult = new CollectionInit(){IDDescriptor = "a96f391a-850f-40b4-9759-26e09e543610",CSSSelectorDescriptor = "",XPathDescriptor = ""};
            MainConsult = RPSControlFactory.RPSCreateCollection<FrequencyTypeCollectionView,FrequencyTypeEntityView>( params_MainConsult,this,Screen.FrequencyTypeEntityView);
 

        }
        public IRPSButton<FrequencyTypeCollectionView,FrequencyTypeEntityView> NewButton { get; set; } 
        public IRPSCollectionEditor<FrequencyTypeCollectionView,FrequencyTypeEntityView> MainConsult { get; set; } 
        public FrequencyType Screen { get; set; }
        public FrequencyTypeCollectionView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class FrequencyTypeEntityView : View
    {
        public FrequencyTypeEntityView(FrequencyType screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            SaveButton = RPSControlFactory.RPSSaveButton<FrequencyTypeEntityView>( this);
 
            DeleteButton = RPSControlFactory.RPSDeleteButton<FrequencyTypeEntityView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<FrequencyTypeEntityView,FrequencyTypeCollectionView>( this,Screen.FrequencyTypeCollectionView);
 
            BackButton = RPSControlFactory.RPSBackButton<FrequencyTypeEntityView,FrequencyTypeCollectionView>( this,Screen.FrequencyTypeCollectionView);
 
            CodFrequencyType = RPSControlFactory.CreateRPSTextBox<FrequencyTypeEntityView>("9bbdf75d-8653-49c4-b987-c073a8de6b68","","",true, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<FrequencyTypeEntityView>("ccc2caef-6f08-46ce-87b7-cdbc65315e9b","","",false, this);
 

        }
        public IRPSSaveButton<FrequencyTypeEntityView> SaveButton { get; set; } 
        public IRPSButton<FrequencyTypeEntityView> DeleteButton { get; set; } 
        public IRPSButton<FrequencyTypeEntityView,FrequencyTypeCollectionView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<FrequencyTypeEntityView,FrequencyTypeCollectionView> BackButton { get; set; } 
        public IRPSTextBox<FrequencyTypeEntityView> CodFrequencyType { get; set; } 
        public IRPSTextBox<FrequencyTypeEntityView> Description { get; set; } 
        public FrequencyType Screen { get; set; }
        public FrequencyTypeEntityView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}