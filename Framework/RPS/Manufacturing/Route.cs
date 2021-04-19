    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.Manufacturing.Route
{
    //RPS VERSION 1.0.0.0
    public partial class Route:Screen
    {
        public Route():base()
        {
            this.URL = "manufacturing.route";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            RouteCollectionView  = new RouteCollectionView(this); 
            RouteEntityView  = new RouteEntityView(this); 
            RouteCollectionView.InitializeControls(); 
            RouteEntityView.InitializeControls(); 
           
        }
      
            public RouteCollectionView RouteCollectionView {get; set; } 
            public RouteEntityView RouteEntityView {get; set; } 
    }
            
    public partial class RouteCollectionView : View
    {
        public RouteCollectionView(Route screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            NewButton = RPSControlFactory.RPSNewButton<RouteCollectionView,RouteEntityView>( this,Screen.RouteEntityView);
 
            CollectionInit params_MainConsult = new CollectionInit(){IDDescriptor = "0302f8e7-5706-43f8-8768-9846998d473f",CSSSelectorDescriptor = "",XPathDescriptor = ""};
            MainConsult = RPSControlFactory.RPSCreateCollection<RouteCollectionView,RouteEntityView>( params_MainConsult,this,Screen.RouteEntityView);
 

        }
        public IRPSButton<RouteCollectionView,RouteEntityView> NewButton { get; set; } 
        public IRPSCollectionEditor<RouteCollectionView,RouteEntityView> MainConsult { get; set; } 
        public Route Screen { get; set; }
        public RouteCollectionView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class RouteEntityView : View
    {
        public RouteEntityView(Route screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            SaveButton = RPSControlFactory.RPSSaveButton<RouteEntityView>( this);
 
            DeleteButton = RPSControlFactory.RPSDeleteButton<RouteEntityView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<RouteEntityView,RouteCollectionView>( this,Screen.RouteCollectionView);
 
            BackButton = RPSControlFactory.RPSBackButton<RouteEntityView,RouteCollectionView>( this,Screen.RouteCollectionView);
 
            CodRoute = RPSControlFactory.CreateRPSTextBox<RouteEntityView>("7f3f8724-c346-441b-8366-c2c59e039b10","","",true, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<RouteEntityView>("c4e448d1-ff98-4938-ba0d-b51dc89fc7cd","","",false, this);
 

        }
        public IRPSSaveButton<RouteEntityView> SaveButton { get; set; } 
        public IRPSButton<RouteEntityView> DeleteButton { get; set; } 
        public IRPSButton<RouteEntityView,RouteCollectionView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<RouteEntityView,RouteCollectionView> BackButton { get; set; } 
        public IRPSTextBox<RouteEntityView> CodRoute { get; set; } 
        public IRPSTextBox<RouteEntityView> Description { get; set; } 
        public Route Screen { get; set; }
        public RouteEntityView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}