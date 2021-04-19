    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.Maintenance.Accreditation
{
    //RPS VERSION 1.0.0.0
    public partial class Accreditation:Screen
    {
        public Accreditation():base()
        {
            this.URL = "maintenance.accreditation";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            AccreditationCollectionView  = new AccreditationCollectionView(this); 
            AccreditationEntityView  = new AccreditationEntityView(this); 
            AccreditationCollectionView.InitializeControls(); 
            AccreditationEntityView.InitializeControls(); 
           
        }
      
            public AccreditationCollectionView AccreditationCollectionView {get; set; } 
            public AccreditationEntityView AccreditationEntityView {get; set; } 
    }
            
    public partial class AccreditationCollectionView : View
    {
        public AccreditationCollectionView(Accreditation screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            NewButton = RPSControlFactory.RPSNewButton<AccreditationCollectionView,AccreditationEntityView>( this,Screen.AccreditationEntityView);
 
            CollectionInit params_MainConsult = new CollectionInit(){IDDescriptor = "269061ad-b90a-4d44-b394-ba81a7fc49a0",CSSSelectorDescriptor = "",XPathDescriptor = ""};
            MainConsult = RPSControlFactory.RPSCreateCollection<AccreditationCollectionView,AccreditationEntityView>( params_MainConsult,this,Screen.AccreditationEntityView);
 

        }
        public IRPSButton<AccreditationCollectionView,AccreditationEntityView> NewButton { get; set; } 
        public IRPSCollectionEditor<AccreditationCollectionView,AccreditationEntityView> MainConsult { get; set; } 
        public Accreditation Screen { get; set; }
        public AccreditationCollectionView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class AccreditationEntityView : View
    {
        public AccreditationEntityView(Accreditation screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            SaveButton = RPSControlFactory.RPSSaveButton<AccreditationEntityView>( this);
 
            DeleteButton = RPSControlFactory.RPSDeleteButton<AccreditationEntityView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<AccreditationEntityView,AccreditationCollectionView>( this,Screen.AccreditationCollectionView);
 
            BackButton = RPSControlFactory.RPSBackButton<AccreditationEntityView,AccreditationCollectionView>( this,Screen.AccreditationCollectionView);
 
            CodAccreditation = RPSControlFactory.CreateRPSTextBox<AccreditationEntityView>("5fdbb702-c1f2-4139-9eeb-23d3dd1c3817","","",true, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<AccreditationEntityView>("97bad22d-8e7c-4229-b9a4-690411ee4019","","",false, this);
 

        }
        public IRPSSaveButton<AccreditationEntityView> SaveButton { get; set; } 
        public IRPSButton<AccreditationEntityView> DeleteButton { get; set; } 
        public IRPSButton<AccreditationEntityView,AccreditationCollectionView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<AccreditationEntityView,AccreditationCollectionView> BackButton { get; set; } 
        public IRPSTextBox<AccreditationEntityView> CodAccreditation { get; set; } 
        public IRPSTextBox<AccreditationEntityView> Description { get; set; } 
        public Accreditation Screen { get; set; }
        public AccreditationEntityView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}