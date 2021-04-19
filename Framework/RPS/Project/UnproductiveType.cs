    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.Project.UnproductiveType
{
    //RPS VERSION 1.0.0.0
    public partial class UnproductiveType:Screen
    {
        public UnproductiveType():base()
        {
            this.URL = "project.unproductivetype";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            UnproductiveTypeCollectionView  = new UnproductiveTypeCollectionView(this); 
            UnproductiveTypeEntityView  = new UnproductiveTypeEntityView(this); 
            UnproductiveTypeCollectionView.InitializeControls(); 
            UnproductiveTypeEntityView.InitializeControls(); 
           
        }
      
            public UnproductiveTypeCollectionView UnproductiveTypeCollectionView {get; set; } 
            public UnproductiveTypeEntityView UnproductiveTypeEntityView {get; set; } 
    }
            
    public partial class UnproductiveTypeCollectionView : View
    {
        public UnproductiveTypeCollectionView(UnproductiveType screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            NewButton = RPSControlFactory.RPSNewButton<UnproductiveTypeCollectionView,UnproductiveTypeEntityView>( this,Screen.UnproductiveTypeEntityView);
 
            CollectionInit params_MainConsult = new CollectionInit(){IDDescriptor = "2aaec63d-46ca-46e2-a5ee-57e38fd94a61",CSSSelectorDescriptor = "",XPathDescriptor = ""};
            MainConsult = RPSControlFactory.RPSCreateCollection<UnproductiveTypeCollectionView,UnproductiveTypeEntityView>( params_MainConsult,this,Screen.UnproductiveTypeEntityView);
 

        }
        public IRPSButton<UnproductiveTypeCollectionView,UnproductiveTypeEntityView> NewButton { get; set; } 
        public IRPSCollectionEditor<UnproductiveTypeCollectionView,UnproductiveTypeEntityView> MainConsult { get; set; } 
        public UnproductiveType Screen { get; set; }
        public UnproductiveTypeCollectionView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class UnproductiveTypeEntityView : View
    {
        public UnproductiveTypeEntityView(UnproductiveType screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            SaveButton = RPSControlFactory.RPSSaveButton<UnproductiveTypeEntityView>( this);
 
            DeleteButton = RPSControlFactory.RPSDeleteButton<UnproductiveTypeEntityView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<UnproductiveTypeEntityView,UnproductiveTypeCollectionView>( this,Screen.UnproductiveTypeCollectionView);
 
            BackButton = RPSControlFactory.RPSBackButton<UnproductiveTypeEntityView,UnproductiveTypeCollectionView>( this,Screen.UnproductiveTypeCollectionView);
 
            CodUnproductiveType = RPSControlFactory.CreateRPSTextBox<UnproductiveTypeEntityView>("715065c0-3665-4af2-ab46-aee98925681d","","",true, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<UnproductiveTypeEntityView>("0e62b3da-f69a-489a-9bd3-bfe6c152228e","","",false, this);
 

        }
        public IRPSSaveButton<UnproductiveTypeEntityView> SaveButton { get; set; } 
        public IRPSButton<UnproductiveTypeEntityView> DeleteButton { get; set; } 
        public IRPSButton<UnproductiveTypeEntityView,UnproductiveTypeCollectionView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<UnproductiveTypeEntityView,UnproductiveTypeCollectionView> BackButton { get; set; } 
        public IRPSTextBox<UnproductiveTypeEntityView> CodUnproductiveType { get; set; } 
        public IRPSTextBox<UnproductiveTypeEntityView> Description { get; set; } 
        public UnproductiveType Screen { get; set; }
        public UnproductiveTypeEntityView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}