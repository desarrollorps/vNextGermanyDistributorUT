    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.Quality.APPCCTeam
{
    //RPS VERSION 1.0.0.0
    public partial class APPCCTeam:Screen
    {
        public APPCCTeam():base()
        {
            this.URL = "quality.appccteam";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            APPCCTeamCollectionView  = new APPCCTeamCollectionView(this); 
            APPCCTeamEntityView  = new APPCCTeamEntityView(this); 
            APPCCTeamCollectionView.InitializeControls(); 
            APPCCTeamEntityView.InitializeControls(); 
           
        }
      
            public APPCCTeamCollectionView APPCCTeamCollectionView {get; set; } 
            public APPCCTeamEntityView APPCCTeamEntityView {get; set; } 
    }
            
    public partial class APPCCTeamCollectionView : View
    {
        public APPCCTeamCollectionView(APPCCTeam screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            NewButton = RPSControlFactory.RPSNewButton<APPCCTeamCollectionView,APPCCTeamEntityView>( this,Screen.APPCCTeamEntityView);
 
            CollectionInit params_MainConsult = new CollectionInit(){IDDescriptor = "e53d9469-a9e1-4217-a24d-32b2d84b6566",CSSSelectorDescriptor = "",XPathDescriptor = ""};
            MainConsult = RPSControlFactory.RPSCreateCollection<APPCCTeamCollectionView,APPCCTeamEntityView>( params_MainConsult,this,Screen.APPCCTeamEntityView);
 

        }
        public IRPSButton<APPCCTeamCollectionView,APPCCTeamEntityView> NewButton { get; set; } 
        public IRPSCollectionEditor<APPCCTeamCollectionView,APPCCTeamEntityView> MainConsult { get; set; } 
        public APPCCTeam Screen { get; set; }
        public APPCCTeamCollectionView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class APPCCTeamEntityView : View
    {
        public APPCCTeamEntityView(APPCCTeam screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            SaveButton = RPSControlFactory.RPSSaveButton<APPCCTeamEntityView>( this);
 
            DeleteButton = RPSControlFactory.RPSDeleteButton<APPCCTeamEntityView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<APPCCTeamEntityView,APPCCTeamCollectionView>( this,Screen.APPCCTeamCollectionView);
 
            BackButton = RPSControlFactory.RPSBackButton<APPCCTeamEntityView,APPCCTeamCollectionView>( this,Screen.APPCCTeamCollectionView);
 
            IDEmployee = RPSControlFactory.CreateRPSComboBox<APPCCTeamEntityView>("6f6a97f8-288d-4537-9ea5-fa934ff309a5","","",true, this);
 

        }
        public IRPSSaveButton<APPCCTeamEntityView> SaveButton { get; set; } 
        public IRPSButton<APPCCTeamEntityView> DeleteButton { get; set; } 
        public IRPSButton<APPCCTeamEntityView,APPCCTeamCollectionView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<APPCCTeamEntityView,APPCCTeamCollectionView> BackButton { get; set; } 
        public IRPSComboBox<APPCCTeamEntityView> IDEmployee { get; set; } 
        public APPCCTeam Screen { get; set; }
        public APPCCTeamEntityView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}