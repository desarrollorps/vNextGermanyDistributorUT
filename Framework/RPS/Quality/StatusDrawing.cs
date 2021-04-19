    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.Quality.StatusDrawing
{
    //RPS VERSION 1.0.0.0
    public partial class StatusDrawing:Screen
    {
        public StatusDrawing():base()
        {
            this.URL = "quality.statusdrawing";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            StatusDrawingCollectionView  = new StatusDrawingCollectionView(this); 
            StatusDrawingEntityView  = new StatusDrawingEntityView(this); 
            StatusDrawingCollectionView.InitializeControls(); 
            StatusDrawingEntityView.InitializeControls(); 
           
        }
      
            public StatusDrawingCollectionView StatusDrawingCollectionView {get; set; } 
            public StatusDrawingEntityView StatusDrawingEntityView {get; set; } 
    }
            
    public partial class StatusDrawingCollectionView : View
    {
        public StatusDrawingCollectionView(StatusDrawing screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            NewButton = RPSControlFactory.RPSNewButton<StatusDrawingCollectionView,StatusDrawingEntityView>( this,Screen.StatusDrawingEntityView);
 
            CollectionInit params_MainConsult = new CollectionInit(){IDDescriptor = "0c405c2d-28b1-4f70-987b-9d59a347dc34",CSSSelectorDescriptor = "",XPathDescriptor = ""};
            MainConsult = RPSControlFactory.RPSCreateCollection<StatusDrawingCollectionView,StatusDrawingEntityView>( params_MainConsult,this,Screen.StatusDrawingEntityView);
 

        }
        public IRPSButton<StatusDrawingCollectionView,StatusDrawingEntityView> NewButton { get; set; } 
        public IRPSCollectionEditor<StatusDrawingCollectionView,StatusDrawingEntityView> MainConsult { get; set; } 
        public StatusDrawing Screen { get; set; }
        public StatusDrawingCollectionView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class StatusDrawingEntityView : View
    {
        public StatusDrawingEntityView(StatusDrawing screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            SaveButton = RPSControlFactory.RPSSaveButton<StatusDrawingEntityView>( this);
 
            DeleteButton = RPSControlFactory.RPSDeleteButton<StatusDrawingEntityView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<StatusDrawingEntityView,StatusDrawingCollectionView>( this,Screen.StatusDrawingCollectionView);
 
            BackButton = RPSControlFactory.RPSBackButton<StatusDrawingEntityView,StatusDrawingCollectionView>( this,Screen.StatusDrawingCollectionView);
 
            CodStatus = RPSControlFactory.CreateRPSTextBox<StatusDrawingEntityView>("cb15ab5e-c4a6-4510-909b-acd273e611e9","","",true, this);
 
            DescStatus = RPSControlFactory.CreateRPSTextBox<StatusDrawingEntityView>("54071301-6884-4135-a312-48704f14ea95","","",false, this);
 
            StatusType = RPSControlFactory.CreateRPSEnumComboBox<StatusDrawingEntityView>("6a315860-5291-4405-b205-92ac8f5f6f62","","",true, this);
 

        }
        public IRPSSaveButton<StatusDrawingEntityView> SaveButton { get; set; } 
        public IRPSButton<StatusDrawingEntityView> DeleteButton { get; set; } 
        public IRPSButton<StatusDrawingEntityView,StatusDrawingCollectionView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<StatusDrawingEntityView,StatusDrawingCollectionView> BackButton { get; set; } 
        public IRPSTextBox<StatusDrawingEntityView> CodStatus { get; set; } 
        public IRPSTextBox<StatusDrawingEntityView> DescStatus { get; set; } 
        public IRPSComboBox<StatusDrawingEntityView> StatusType { get; set; } 
        public StatusDrawing Screen { get; set; }
        public StatusDrawingEntityView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}