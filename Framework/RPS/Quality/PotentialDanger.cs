    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.Quality.PotentialDanger
{
    //RPS VERSION 1.0.0.0
    public partial class PotentialDanger:Screen
    {
        public PotentialDanger():base()
        {
            this.URL = "quality.potentialdanger";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            PotentialDangerCollectionView  = new PotentialDangerCollectionView(this); 
            PotentialDangerEntityView  = new PotentialDangerEntityView(this); 
            PotentialDangerByLangView  = new PotentialDangerByLangView(this); 
            PotentialDangerCollectionView.InitializeControls(); 
            PotentialDangerEntityView.InitializeControls(); 
            PotentialDangerByLangView.InitializeControls(); 
           
        }
      
            public PotentialDangerCollectionView PotentialDangerCollectionView {get; set; } 
            public PotentialDangerEntityView PotentialDangerEntityView {get; set; } 
            public PotentialDangerByLangView PotentialDangerByLangView {get; set; } 
    }
            
    public partial class PotentialDangerCollectionView : View
    {
        public PotentialDangerCollectionView(PotentialDanger screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            NewButton = RPSControlFactory.RPSNewButton<PotentialDangerCollectionView,PotentialDangerEntityView>( this,Screen.PotentialDangerEntityView);
 
            CollectionInit params_MainConsult = new CollectionInit(){IDDescriptor = "54063cf0-eecb-4d18-a55d-38b09c6805a2",CSSSelectorDescriptor = "",XPathDescriptor = ""};
            MainConsult = RPSControlFactory.RPSCreateCollection<PotentialDangerCollectionView,PotentialDangerEntityView>( params_MainConsult,this,Screen.PotentialDangerEntityView);
 

        }
        public IRPSButton<PotentialDangerCollectionView,PotentialDangerEntityView> NewButton { get; set; } 
        public IRPSCollectionEditor<PotentialDangerCollectionView,PotentialDangerEntityView> MainConsult { get; set; } 
        public PotentialDanger Screen { get; set; }
        public PotentialDangerCollectionView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class PotentialDangerEntityView : View
    {
        public PotentialDangerEntityView(PotentialDanger screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            SaveButton = RPSControlFactory.RPSSaveButton<PotentialDangerEntityView>( this);
 
            DeleteButton = RPSControlFactory.RPSDeleteButton<PotentialDangerEntityView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<PotentialDangerEntityView,PotentialDangerCollectionView>( this,Screen.PotentialDangerCollectionView);
 
            BackButton = RPSControlFactory.RPSBackButton<PotentialDangerEntityView,PotentialDangerCollectionView>( this,Screen.PotentialDangerCollectionView);
 
            Type = RPSControlFactory.CreateRPSEnumComboBox<PotentialDangerEntityView>("2ee637be-215c-4f89-9bc1-ad70b024bf0f","","",true, this);
 
            CodPotentialDanger = RPSControlFactory.CreateRPSTextBox<PotentialDangerEntityView>("07d7e8b7-205f-49b5-befd-211de8f57dcd","","",true, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<PotentialDangerEntityView>("97bae4c3-39b2-4aa8-a727-5f8e0b56e92c","","",false, this);
 
            CollectionInit params_PotentialDangerByLangs = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="9fadbf81-258b-448c-becc-308c60b9ffab",CSSSelectorGrid="",XPathGrid=""};
            PotentialDangerByLangs = RPSControlFactory.RPSCreateCollectionWithGrid<PotentialDangerByLangsCollectionEditor<PotentialDangerEntityView,PotentialDangerByLangView>,PotentialDangerEntityView,PotentialDangerByLangView>( params_PotentialDangerByLangs,this,Screen.PotentialDangerByLangView);
 

        }
        public IRPSSaveButton<PotentialDangerEntityView> SaveButton { get; set; } 
        public IRPSButton<PotentialDangerEntityView> DeleteButton { get; set; } 
        public IRPSButton<PotentialDangerEntityView,PotentialDangerCollectionView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<PotentialDangerEntityView,PotentialDangerCollectionView> BackButton { get; set; } 
        public IRPSComboBox<PotentialDangerEntityView> Type { get; set; } 
        public IRPSTextBox<PotentialDangerEntityView> CodPotentialDanger { get; set; } 
        public IRPSTextBox<PotentialDangerEntityView> Description { get; set; } 
        public PotentialDangerByLangsCollectionEditor<PotentialDangerEntityView,PotentialDangerByLangView> PotentialDangerByLangs { get; set; } 
        public PotentialDanger Screen { get; set; }
        public PotentialDangerEntityView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class PotentialDangerByLangsCollectionEditor<PotentialDangerEntityView,PotentialDangerByLangView>:RPSCollectionEditor<PotentialDangerEntityView,PotentialDangerByLangView> where PotentialDangerEntityView : class, IView where PotentialDangerByLangView : class, IView
    {
        public  PotentialDangerByLangsGridView<PotentialDangerEntityView,PotentialDangerByLangView> GridView {get;set;}
    }
    public partial class PotentialDangerByLangsGridView <PotentialDangerEntityView,PotentialDangerByLangView> :  RPSGridView<PotentialDangerEntityView,PotentialDangerByLangView> where PotentialDangerEntityView : class, IView where PotentialDangerByLangView : class, IView
    {
        public PotentialDangerByLangsGridView(PotentialDangerEntityView currentView,PotentialDangerByLangView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            CodLanguage = RPSControlFactory.CreateRPSGridComboBox<PotentialDangerEntityView>("","#9fadbf81-258b-448c-becc-308c60b9ffab .ag-row[role='row']@ROWINDEX [col-id='cCodLanguage']","",true, this.CurrentView);
 
            Description = RPSControlFactory.CreateRPSGridTextBox<PotentialDangerEntityView>("","#9fadbf81-258b-448c-becc-308c60b9ffab .ag-row[role='row']@ROWINDEX [col-id='cDescription']","",false, this.CurrentView);
 

        }
        public IRPSGridComboBox<PotentialDangerEntityView> CodLanguage { get; set; } 
        public IRPSGridTextBox<PotentialDangerEntityView> Description { get; set; } 
                     
    }
 
    }
  
            
    public partial class PotentialDangerByLangView : View
    {
        public PotentialDangerByLangView(PotentialDanger screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            DeleteButton = RPSControlFactory.RPSDeleteButton<PotentialDangerByLangView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<PotentialDangerByLangView,PotentialDangerEntityView>( this,Screen.PotentialDangerEntityView);
 
            BackButton = RPSControlFactory.RPSBackButton<PotentialDangerByLangView,PotentialDangerEntityView>( this,Screen.PotentialDangerEntityView);
 
            AcceptButton = RPSControlFactory.RPSAcceptButton<PotentialDangerByLangView,PotentialDangerEntityView>( this,Screen.PotentialDangerEntityView);
 
            CodLanguage = RPSControlFactory.CreateRPSComboBox<PotentialDangerByLangView>("8ce52097-bc09-44e0-8d37-7dcaa88a522b","","",true, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<PotentialDangerByLangView>("0f9bd170-9973-4507-9594-38c66b655cf5","","",false, this);
 

        }
        public IRPSButton<PotentialDangerByLangView> DeleteButton { get; set; } 
        public IRPSButton<PotentialDangerByLangView,PotentialDangerEntityView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<PotentialDangerByLangView,PotentialDangerEntityView> BackButton { get; set; } 
        public IRPSAcceptButton<PotentialDangerByLangView,PotentialDangerEntityView> AcceptButton { get; set; } 
        public IRPSComboBox<PotentialDangerByLangView> CodLanguage { get; set; } 
        public IRPSTextBox<PotentialDangerByLangView> Description { get; set; } 
        public PotentialDanger Screen { get; set; }
        public PotentialDangerByLangView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}