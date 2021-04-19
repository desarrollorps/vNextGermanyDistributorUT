    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.Quality.ControlMethod
{
    //RPS VERSION 1.0.0.0
    public partial class ControlMethod:Screen
    {
        public ControlMethod():base()
        {
            this.URL = "quality.controlmethod";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            ControlMethodCollectionView  = new ControlMethodCollectionView(this); 
            ControlMethodEntityView  = new ControlMethodEntityView(this); 
            ControlMethodByLangView  = new ControlMethodByLangView(this); 
            ControlMethodCollectionView.InitializeControls(); 
            ControlMethodEntityView.InitializeControls(); 
            ControlMethodByLangView.InitializeControls(); 
           
        }
      
            public ControlMethodCollectionView ControlMethodCollectionView {get; set; } 
            public ControlMethodEntityView ControlMethodEntityView {get; set; } 
            public ControlMethodByLangView ControlMethodByLangView {get; set; } 
    }
            
    public partial class ControlMethodCollectionView : View
    {
        public ControlMethodCollectionView(ControlMethod screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            NewButton = RPSControlFactory.RPSNewButton<ControlMethodCollectionView,ControlMethodEntityView>( this,Screen.ControlMethodEntityView);
 
            CollectionInit params_MainConsult = new CollectionInit(){IDDescriptor = "aa4ccba6-c8f9-411e-a4c8-8e6b1bf35458",CSSSelectorDescriptor = "",XPathDescriptor = ""};
            MainConsult = RPSControlFactory.RPSCreateCollection<ControlMethodCollectionView,ControlMethodEntityView>( params_MainConsult,this,Screen.ControlMethodEntityView);
 

        }
        public IRPSButton<ControlMethodCollectionView,ControlMethodEntityView> NewButton { get; set; } 
        public IRPSCollectionEditor<ControlMethodCollectionView,ControlMethodEntityView> MainConsult { get; set; } 
        public ControlMethod Screen { get; set; }
        public ControlMethodCollectionView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class ControlMethodEntityView : View
    {
        public ControlMethodEntityView(ControlMethod screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            SaveButton = RPSControlFactory.RPSSaveButton<ControlMethodEntityView>( this);
 
            DeleteButton = RPSControlFactory.RPSDeleteButton<ControlMethodEntityView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<ControlMethodEntityView,ControlMethodCollectionView>( this,Screen.ControlMethodCollectionView);
 
            BackButton = RPSControlFactory.RPSBackButton<ControlMethodEntityView,ControlMethodCollectionView>( this,Screen.ControlMethodCollectionView);
 
            CodControlMethod = RPSControlFactory.CreateRPSTextBox<ControlMethodEntityView>("b08ea38a-56c7-45f0-ac9f-18f4bd4acf62","","",true, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<ControlMethodEntityView>("8d1b021c-c530-4bac-8193-86d34aa700dd","","",false, this);
 
            CollectionInit params_ControlMethodByLangs = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="8d0516df-4e9d-4331-8f62-03130c903cf7",CSSSelectorGrid="",XPathGrid=""};
            ControlMethodByLangs = RPSControlFactory.RPSCreateCollectionWithGrid<ControlMethodByLangsCollectionEditor<ControlMethodEntityView,ControlMethodByLangView>,ControlMethodEntityView,ControlMethodByLangView>( params_ControlMethodByLangs,this,Screen.ControlMethodByLangView);
 

        }
        public IRPSSaveButton<ControlMethodEntityView> SaveButton { get; set; } 
        public IRPSButton<ControlMethodEntityView> DeleteButton { get; set; } 
        public IRPSButton<ControlMethodEntityView,ControlMethodCollectionView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<ControlMethodEntityView,ControlMethodCollectionView> BackButton { get; set; } 
        public IRPSTextBox<ControlMethodEntityView> CodControlMethod { get; set; } 
        public IRPSTextBox<ControlMethodEntityView> Description { get; set; } 
        public ControlMethodByLangsCollectionEditor<ControlMethodEntityView,ControlMethodByLangView> ControlMethodByLangs { get; set; } 
        public ControlMethod Screen { get; set; }
        public ControlMethodEntityView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class ControlMethodByLangsCollectionEditor<ControlMethodEntityView,ControlMethodByLangView>:RPSCollectionEditor<ControlMethodEntityView,ControlMethodByLangView> where ControlMethodEntityView : class, IView where ControlMethodByLangView : class, IView
    {
        public  ControlMethodByLangsGridView<ControlMethodEntityView,ControlMethodByLangView> GridView {get;set;}
    }
    public partial class ControlMethodByLangsGridView <ControlMethodEntityView,ControlMethodByLangView> :  RPSGridView<ControlMethodEntityView,ControlMethodByLangView> where ControlMethodEntityView : class, IView where ControlMethodByLangView : class, IView
    {
        public ControlMethodByLangsGridView(ControlMethodEntityView currentView,ControlMethodByLangView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            CodLanguage = RPSControlFactory.CreateRPSGridComboBox<ControlMethodEntityView>("","#8d0516df-4e9d-4331-8f62-03130c903cf7 .ag-row[role='row']@ROWINDEX [col-id='cCodLanguage']","",true, this.CurrentView);
 
            Description = RPSControlFactory.CreateRPSGridTextBox<ControlMethodEntityView>("","#8d0516df-4e9d-4331-8f62-03130c903cf7 .ag-row[role='row']@ROWINDEX [col-id='cDescription']","",false, this.CurrentView);
 

        }
        public IRPSGridComboBox<ControlMethodEntityView> CodLanguage { get; set; } 
        public IRPSGridTextBox<ControlMethodEntityView> Description { get; set; } 
                     
    }
 
    }
  
            
    public partial class ControlMethodByLangView : View
    {
        public ControlMethodByLangView(ControlMethod screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            DeleteButton = RPSControlFactory.RPSDeleteButton<ControlMethodByLangView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<ControlMethodByLangView,ControlMethodEntityView>( this,Screen.ControlMethodEntityView);
 
            BackButton = RPSControlFactory.RPSBackButton<ControlMethodByLangView,ControlMethodEntityView>( this,Screen.ControlMethodEntityView);
 
            AcceptButton = RPSControlFactory.RPSAcceptButton<ControlMethodByLangView,ControlMethodEntityView>( this,Screen.ControlMethodEntityView);
 
            CodLanguage = RPSControlFactory.CreateRPSComboBox<ControlMethodByLangView>("aa277b84-2b88-42bb-b202-64bfde9d5cf5","","",true, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<ControlMethodByLangView>("3ff8183b-67bd-4e9f-84a4-c1758e02fce9","","",false, this);
 

        }
        public IRPSButton<ControlMethodByLangView> DeleteButton { get; set; } 
        public IRPSButton<ControlMethodByLangView,ControlMethodEntityView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<ControlMethodByLangView,ControlMethodEntityView> BackButton { get; set; } 
        public IRPSAcceptButton<ControlMethodByLangView,ControlMethodEntityView> AcceptButton { get; set; } 
        public IRPSComboBox<ControlMethodByLangView> CodLanguage { get; set; } 
        public IRPSTextBox<ControlMethodByLangView> Description { get; set; } 
        public ControlMethod Screen { get; set; }
        public ControlMethodByLangView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}