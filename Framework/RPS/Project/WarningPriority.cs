    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.Project.WarningPriority
{
    //RPS VERSION 1.0.0.0
    public partial class WarningPriority:Screen
    {
        public WarningPriority():base()
        {
            this.URL = "project.warningpriority";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            WarningPriorityCollectionView  = new WarningPriorityCollectionView(this); 
            WarningPriorityEntityView  = new WarningPriorityEntityView(this); 
            WarningPriorityCollectionView.InitializeControls(); 
            WarningPriorityEntityView.InitializeControls(); 
           
        }
      
            public WarningPriorityCollectionView WarningPriorityCollectionView {get; set; } 
            public WarningPriorityEntityView WarningPriorityEntityView {get; set; } 
    }
            
    public partial class WarningPriorityCollectionView : View
    {
        public WarningPriorityCollectionView(WarningPriority screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            NewButton = RPSControlFactory.RPSNewButton<WarningPriorityCollectionView,WarningPriorityEntityView>( this,Screen.WarningPriorityEntityView);
 
            CollectionInit params_MainConsult = new CollectionInit(){IDDescriptor = "42b0f654-30f9-4bc0-ac5a-6669150ae580",CSSSelectorDescriptor = "",XPathDescriptor = ""};
            MainConsult = RPSControlFactory.RPSCreateCollection<WarningPriorityCollectionView,WarningPriorityEntityView>( params_MainConsult,this,Screen.WarningPriorityEntityView);
 

        }
        public IRPSButton<WarningPriorityCollectionView,WarningPriorityEntityView> NewButton { get; set; } 
        public IRPSCollectionEditor<WarningPriorityCollectionView,WarningPriorityEntityView> MainConsult { get; set; } 
        public WarningPriority Screen { get; set; }
        public WarningPriorityCollectionView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class WarningPriorityEntityView : View
    {
        public WarningPriorityEntityView(WarningPriority screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            SaveButton = RPSControlFactory.RPSSaveButton<WarningPriorityEntityView>( this);
 
            DeleteButton = RPSControlFactory.RPSDeleteButton<WarningPriorityEntityView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<WarningPriorityEntityView,WarningPriorityCollectionView>( this,Screen.WarningPriorityCollectionView);
 
            BackButton = RPSControlFactory.RPSBackButton<WarningPriorityEntityView,WarningPriorityCollectionView>( this,Screen.WarningPriorityCollectionView);
 
            CodWarningPriority = RPSControlFactory.CreateRPSTextBox<WarningPriorityEntityView>("8843a25a-3954-4cca-9bb1-8da9cbb269e3","","",true, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<WarningPriorityEntityView>("f086cde0-6cdb-45ab-8ee0-a11234159074","","",false, this);
 
            Color = RPSControlFactory.CreateRPSColorEditor<WarningPriorityEntityView>( "d3390236-e1b5-4a68-8554-c93c2817242e","","",this);
 

        }
        public IRPSSaveButton<WarningPriorityEntityView> SaveButton { get; set; } 
        public IRPSButton<WarningPriorityEntityView> DeleteButton { get; set; } 
        public IRPSButton<WarningPriorityEntityView,WarningPriorityCollectionView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<WarningPriorityEntityView,WarningPriorityCollectionView> BackButton { get; set; } 
        public IRPSTextBox<WarningPriorityEntityView> CodWarningPriority { get; set; } 
        public IRPSTextBox<WarningPriorityEntityView> Description { get; set; } 
        public IRPSColorEditor<WarningPriorityEntityView> Color { get; set; } 
        public WarningPriority Screen { get; set; }
        public WarningPriorityEntityView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}