    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.Quality.SampleSize
{
    //RPS VERSION 1.0.0.0
    public partial class SampleSize:Screen
    {
        public SampleSize():base()
        {
            this.URL = "quality.samplesize";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            SampleSizeCollectionView  = new SampleSizeCollectionView(this); 
            SampleSizeEntityView  = new SampleSizeEntityView(this); 
            SampleSizeByLangView  = new SampleSizeByLangView(this); 
            SampleSizeCollectionView.InitializeControls(); 
            SampleSizeEntityView.InitializeControls(); 
            SampleSizeByLangView.InitializeControls(); 
           
        }
      
            public SampleSizeCollectionView SampleSizeCollectionView {get; set; } 
            public SampleSizeEntityView SampleSizeEntityView {get; set; } 
            public SampleSizeByLangView SampleSizeByLangView {get; set; } 
    }
            
    public partial class SampleSizeCollectionView : View
    {
        public SampleSizeCollectionView(SampleSize screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            NewButton = RPSControlFactory.RPSNewButton<SampleSizeCollectionView,SampleSizeEntityView>( this,Screen.SampleSizeEntityView);
 
            CollectionInit params_MainConsult = new CollectionInit(){IDDescriptor = "13f05d24-3a0a-42c7-abb9-14d9bfc0ba68",CSSSelectorDescriptor = "",XPathDescriptor = ""};
            MainConsult = RPSControlFactory.RPSCreateCollection<SampleSizeCollectionView,SampleSizeEntityView>( params_MainConsult,this,Screen.SampleSizeEntityView);
 

        }
        public IRPSButton<SampleSizeCollectionView,SampleSizeEntityView> NewButton { get; set; } 
        public IRPSCollectionEditor<SampleSizeCollectionView,SampleSizeEntityView> MainConsult { get; set; } 
        public SampleSize Screen { get; set; }
        public SampleSizeCollectionView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class SampleSizeEntityView : View
    {
        public SampleSizeEntityView(SampleSize screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            SaveButton = RPSControlFactory.RPSSaveButton<SampleSizeEntityView>( this);
 
            DeleteButton = RPSControlFactory.RPSDeleteButton<SampleSizeEntityView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<SampleSizeEntityView,SampleSizeCollectionView>( this,Screen.SampleSizeCollectionView);
 
            BackButton = RPSControlFactory.RPSBackButton<SampleSizeEntityView,SampleSizeCollectionView>( this,Screen.SampleSizeCollectionView);
 
            CodSampleSize = RPSControlFactory.CreateRPSTextBox<SampleSizeEntityView>("ab065113-722a-4929-a626-d3f59eef7151","","",true, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<SampleSizeEntityView>("1c0c8954-449c-497d-9c01-9b23ae35cf11","","",false, this);
 
            CollectionInit params_SampleSizeByLangs = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="622f2592-3567-483e-a30d-800142bf23f8",CSSSelectorGrid="",XPathGrid=""};
            SampleSizeByLangs = RPSControlFactory.RPSCreateCollectionWithGrid<SampleSizeByLangsCollectionEditor<SampleSizeEntityView,SampleSizeByLangView>,SampleSizeEntityView,SampleSizeByLangView>( params_SampleSizeByLangs,this,Screen.SampleSizeByLangView);
 

        }
        public IRPSSaveButton<SampleSizeEntityView> SaveButton { get; set; } 
        public IRPSButton<SampleSizeEntityView> DeleteButton { get; set; } 
        public IRPSButton<SampleSizeEntityView,SampleSizeCollectionView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<SampleSizeEntityView,SampleSizeCollectionView> BackButton { get; set; } 
        public IRPSTextBox<SampleSizeEntityView> CodSampleSize { get; set; } 
        public IRPSTextBox<SampleSizeEntityView> Description { get; set; } 
        public SampleSizeByLangsCollectionEditor<SampleSizeEntityView,SampleSizeByLangView> SampleSizeByLangs { get; set; } 
        public SampleSize Screen { get; set; }
        public SampleSizeEntityView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class SampleSizeByLangsCollectionEditor<SampleSizeEntityView,SampleSizeByLangView>:RPSCollectionEditor<SampleSizeEntityView,SampleSizeByLangView> where SampleSizeEntityView : class, IView where SampleSizeByLangView : class, IView
    {
        public  SampleSizeByLangsGridView<SampleSizeEntityView,SampleSizeByLangView> GridView {get;set;}
    }
    public partial class SampleSizeByLangsGridView <SampleSizeEntityView,SampleSizeByLangView> :  RPSGridView<SampleSizeEntityView,SampleSizeByLangView> where SampleSizeEntityView : class, IView where SampleSizeByLangView : class, IView
    {
        public SampleSizeByLangsGridView(SampleSizeEntityView currentView,SampleSizeByLangView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            CodLanguage = RPSControlFactory.CreateRPSGridComboBox<SampleSizeEntityView>("","#622f2592-3567-483e-a30d-800142bf23f8 .ag-row[role='row']@ROWINDEX [col-id='cCodLanguage']","",true, this.CurrentView);
 
            Description = RPSControlFactory.CreateRPSGridTextBox<SampleSizeEntityView>("","#622f2592-3567-483e-a30d-800142bf23f8 .ag-row[role='row']@ROWINDEX [col-id='cDescription']","",false, this.CurrentView);
 

        }
        public IRPSGridComboBox<SampleSizeEntityView> CodLanguage { get; set; } 
        public IRPSGridTextBox<SampleSizeEntityView> Description { get; set; } 
                     
    }
 
    }
  
            
    public partial class SampleSizeByLangView : View
    {
        public SampleSizeByLangView(SampleSize screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            DeleteButton = RPSControlFactory.RPSDeleteButton<SampleSizeByLangView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<SampleSizeByLangView,SampleSizeEntityView>( this,Screen.SampleSizeEntityView);
 
            BackButton = RPSControlFactory.RPSBackButton<SampleSizeByLangView,SampleSizeEntityView>( this,Screen.SampleSizeEntityView);
 
            AcceptButton = RPSControlFactory.RPSAcceptButton<SampleSizeByLangView,SampleSizeEntityView>( this,Screen.SampleSizeEntityView);
 
            CodLanguage = RPSControlFactory.CreateRPSComboBox<SampleSizeByLangView>("cbecd724-a56e-4a8c-9eca-a6e2c38515f1","","",true, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<SampleSizeByLangView>("dd247f75-9447-4759-9bd4-4e57996e70b4","","",false, this);
 

        }
        public IRPSButton<SampleSizeByLangView> DeleteButton { get; set; } 
        public IRPSButton<SampleSizeByLangView,SampleSizeEntityView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<SampleSizeByLangView,SampleSizeEntityView> BackButton { get; set; } 
        public IRPSAcceptButton<SampleSizeByLangView,SampleSizeEntityView> AcceptButton { get; set; } 
        public IRPSComboBox<SampleSizeByLangView> CodLanguage { get; set; } 
        public IRPSTextBox<SampleSizeByLangView> Description { get; set; } 
        public SampleSize Screen { get; set; }
        public SampleSizeByLangView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}