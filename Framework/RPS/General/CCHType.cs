    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.General.CCHType
{
    //RPS VERSION 1.0.0.0
    public partial class CCHType:Screen
    {
        public CCHType():base()
        {
            this.URL = "general.cchtype";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            CCHTypeCollectionView  = new CCHTypeCollectionView(this); 
            CCHTypeEntityView  = new CCHTypeEntityView(this); 
            CCHTypeCollectionView.InitializeControls(); 
            CCHTypeEntityView.InitializeControls(); 
           
        }
      
            public CCHTypeCollectionView CCHTypeCollectionView {get; set; } 
            public CCHTypeEntityView CCHTypeEntityView {get; set; } 
    }
            
    public partial class CCHTypeCollectionView : View
    {
        public CCHTypeCollectionView(CCHType screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            NewButton = RPSControlFactory.RPSNewButton<CCHTypeCollectionView,CCHTypeEntityView>( this,Screen.CCHTypeEntityView);
 
            CollectionInit params_MainConsult = new CollectionInit(){IDDescriptor = "8458c44c-b0e9-4486-85c3-d51f93ebdb38",CSSSelectorDescriptor = "",XPathDescriptor = ""};
            MainConsult = RPSControlFactory.RPSCreateCollection<CCHTypeCollectionView,CCHTypeEntityView>( params_MainConsult,this,Screen.CCHTypeEntityView);
 

        }
        public IRPSButton<CCHTypeCollectionView,CCHTypeEntityView> NewButton { get; set; } 
        public IRPSCollectionEditor<CCHTypeCollectionView,CCHTypeEntityView> MainConsult { get; set; } 
        public CCHType Screen { get; set; }
        public CCHTypeCollectionView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class CCHTypeEntityView : View
    {
        public CCHTypeEntityView(CCHType screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            SaveButton = RPSControlFactory.RPSSaveButton<CCHTypeEntityView>( this);
 
            DeleteButton = RPSControlFactory.RPSDeleteButton<CCHTypeEntityView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<CCHTypeEntityView,CCHTypeCollectionView>( this,Screen.CCHTypeCollectionView);
 
            BackButton = RPSControlFactory.RPSBackButton<CCHTypeEntityView,CCHTypeCollectionView>( this,Screen.CCHTypeCollectionView);
 
            CodCCHType = RPSControlFactory.CreateRPSTextBox<CCHTypeEntityView>("b9484012-b416-48db-9afa-c65b6002f622","","",true, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<CCHTypeEntityView>("7a881c48-fd6f-4fe2-97cc-556986e0d6a1","","",false, this);
 

        }
        public IRPSSaveButton<CCHTypeEntityView> SaveButton { get; set; } 
        public IRPSButton<CCHTypeEntityView> DeleteButton { get; set; } 
        public IRPSButton<CCHTypeEntityView,CCHTypeCollectionView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<CCHTypeEntityView,CCHTypeCollectionView> BackButton { get; set; } 
        public IRPSTextBox<CCHTypeEntityView> CodCCHType { get; set; } 
        public IRPSTextBox<CCHTypeEntityView> Description { get; set; } 
        public CCHType Screen { get; set; }
        public CCHTypeEntityView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}