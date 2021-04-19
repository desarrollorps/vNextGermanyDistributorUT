    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.General.Language
{
    //RPS VERSION 1.0.0.0
    public partial class Language:Screen
    {
        public Language():base()
        {
            this.URL = "general.language";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            LanguageCollectionView  = new LanguageCollectionView(this); 
            LanguageEntityView  = new LanguageEntityView(this); 
            LanguageCollectionView.InitializeControls(); 
            LanguageEntityView.InitializeControls(); 
           
        }
      
            public LanguageCollectionView LanguageCollectionView {get; set; } 
            public LanguageEntityView LanguageEntityView {get; set; } 
    }
            
    public partial class LanguageCollectionView : View
    {
        public LanguageCollectionView(Language screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            NewButton = RPSControlFactory.RPSNewButton<LanguageCollectionView,LanguageEntityView>( this,Screen.LanguageEntityView);
 
            CollectionInit params_MainConsult = new CollectionInit(){IDDescriptor = "b52d149b-35d8-42c8-9076-934ed67d50b7",CSSSelectorDescriptor = "",XPathDescriptor = ""};
            MainConsult = RPSControlFactory.RPSCreateCollection<LanguageCollectionView,LanguageEntityView>( params_MainConsult,this,Screen.LanguageEntityView);
 

        }
        public IRPSButton<LanguageCollectionView,LanguageEntityView> NewButton { get; set; } 
        public IRPSCollectionEditor<LanguageCollectionView,LanguageEntityView> MainConsult { get; set; } 
        public Language Screen { get; set; }
        public LanguageCollectionView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class LanguageEntityView : View
    {
        public LanguageEntityView(Language screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            SaveButton = RPSControlFactory.RPSSaveButton<LanguageEntityView>( this);
 
            DeleteButton = RPSControlFactory.RPSDeleteButton<LanguageEntityView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<LanguageEntityView,LanguageCollectionView>( this,Screen.LanguageCollectionView);
 
            BackButton = RPSControlFactory.RPSBackButton<LanguageEntityView,LanguageCollectionView>( this,Screen.LanguageCollectionView);
 
            CodLanguage = RPSControlFactory.CreateRPSTextBox<LanguageEntityView>("839205cf-4cce-420e-a704-84bcec15d214","","",true, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<LanguageEntityView>("52b1e394-6fa6-442f-94aa-044e1cdeb9d2","","",false, this);
 
            Culture = RPSControlFactory.CreateRPSEnumComboBox<LanguageEntityView>("2014c2a0-26ef-4916-9c61-81b3c998fec7","","",true, this);
 
            CodISO = RPSControlFactory.CreateRPSTextBox<LanguageEntityView>("f92b0e61-4bb7-4d24-bebf-cfb7fffe1c08","","",false, this);
 
            CultureHTML5 = RPSControlFactory.CreateRPSEnumComboBox<LanguageEntityView>("e4684d59-1fbf-423a-80a5-c8d548de2d69","","",false, this);
 
            CultureReporting = RPSControlFactory.CreateRPSEnumComboBox<LanguageEntityView>("2c5b941e-5055-4a32-9139-ff58f083b487","","",true, this);
 

        }
        public IRPSSaveButton<LanguageEntityView> SaveButton { get; set; } 
        public IRPSButton<LanguageEntityView> DeleteButton { get; set; } 
        public IRPSButton<LanguageEntityView,LanguageCollectionView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<LanguageEntityView,LanguageCollectionView> BackButton { get; set; } 
        public IRPSTextBox<LanguageEntityView> CodLanguage { get; set; } 
        public IRPSTextBox<LanguageEntityView> Description { get; set; } 
        public IRPSComboBox<LanguageEntityView> Culture { get; set; } 
        public IRPSTextBox<LanguageEntityView> CodISO { get; set; } 
        public IRPSComboBox<LanguageEntityView> CultureHTML5 { get; set; } 
        public IRPSComboBox<LanguageEntityView> CultureReporting { get; set; } 
        public Language Screen { get; set; }
        public LanguageEntityView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}