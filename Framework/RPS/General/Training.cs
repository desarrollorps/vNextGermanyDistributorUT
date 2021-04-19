    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.General.Training
{
    //RPS VERSION 1.0.0.0
    public partial class Training:Screen
    {
        public Training():base()
        {
            this.URL = "general.training";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            TrainingCollectionView  = new TrainingCollectionView(this); 
            TrainingEntityView  = new TrainingEntityView(this); 
            TrainingCollectionView.InitializeControls(); 
            TrainingEntityView.InitializeControls(); 
           
        }
      
            public TrainingCollectionView TrainingCollectionView {get; set; } 
            public TrainingEntityView TrainingEntityView {get; set; } 
    }
            
    public partial class TrainingCollectionView : View
    {
        public TrainingCollectionView(Training screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            NewButton = RPSControlFactory.RPSNewButton<TrainingCollectionView,TrainingEntityView>( this,Screen.TrainingEntityView);
 
            CollectionInit params_MainConsult = new CollectionInit(){IDDescriptor = "d4b4a83f-ab97-4d17-8a8e-420602e1172e",CSSSelectorDescriptor = "",XPathDescriptor = ""};
            MainConsult = RPSControlFactory.RPSCreateCollection<TrainingCollectionView,TrainingEntityView>( params_MainConsult,this,Screen.TrainingEntityView);
 

        }
        public IRPSButton<TrainingCollectionView,TrainingEntityView> NewButton { get; set; } 
        public IRPSCollectionEditor<TrainingCollectionView,TrainingEntityView> MainConsult { get; set; } 
        public Training Screen { get; set; }
        public TrainingCollectionView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class TrainingEntityView : View
    {
        public TrainingEntityView(Training screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            SaveButton = RPSControlFactory.RPSSaveButton<TrainingEntityView>( this);
 
            DeleteButton = RPSControlFactory.RPSDeleteButton<TrainingEntityView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<TrainingEntityView,TrainingCollectionView>( this,Screen.TrainingCollectionView);
 
            BackButton = RPSControlFactory.RPSBackButton<TrainingEntityView,TrainingCollectionView>( this,Screen.TrainingCollectionView);
 
            CodTraining = RPSControlFactory.CreateRPSTextBox<TrainingEntityView>("3e7b8e0b-5757-4e6f-b636-c39a8a8894c7","","",true, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<TrainingEntityView>("d7863f70-f6f7-48a9-9d3e-b4857e50f47a","","",false, this);
 
            TotalHours = RPSControlFactory.CreateRPSFormattedTextBox<TrainingEntityView>("fd12e344-1795-43de-9f98-60ae4b117ca2","","",true, this);
 

        }
        public IRPSSaveButton<TrainingEntityView> SaveButton { get; set; } 
        public IRPSButton<TrainingEntityView> DeleteButton { get; set; } 
        public IRPSButton<TrainingEntityView,TrainingCollectionView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<TrainingEntityView,TrainingCollectionView> BackButton { get; set; } 
        public IRPSTextBox<TrainingEntityView> CodTraining { get; set; } 
        public IRPSTextBox<TrainingEntityView> Description { get; set; } 
        public IRPSTextBox<TrainingEntityView> TotalHours { get; set; } 
        public Training Screen { get; set; }
        public TrainingEntityView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}