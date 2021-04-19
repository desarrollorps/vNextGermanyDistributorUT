    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.Quality.SampleFrequency
{
    //RPS VERSION 1.0.0.0
    public partial class SampleFrequency:Screen
    {
        public SampleFrequency():base()
        {
            this.URL = "quality.samplefrequency";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            SampleFrequencyCollectionView  = new SampleFrequencyCollectionView(this); 
            SampleFrequencyEntityView  = new SampleFrequencyEntityView(this); 
            SampleFrequencyByLangView  = new SampleFrequencyByLangView(this); 
            SampleFrequencyCollectionView.InitializeControls(); 
            SampleFrequencyEntityView.InitializeControls(); 
            SampleFrequencyByLangView.InitializeControls(); 
           
        }
      
            public SampleFrequencyCollectionView SampleFrequencyCollectionView {get; set; } 
            public SampleFrequencyEntityView SampleFrequencyEntityView {get; set; } 
            public SampleFrequencyByLangView SampleFrequencyByLangView {get; set; } 
    }
            
    public partial class SampleFrequencyCollectionView : View
    {
        public SampleFrequencyCollectionView(SampleFrequency screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            NewButton = RPSControlFactory.RPSNewButton<SampleFrequencyCollectionView,SampleFrequencyEntityView>( this,Screen.SampleFrequencyEntityView);
 
            CollectionInit params_MainConsult = new CollectionInit(){IDDescriptor = "c038ff4b-cff9-4725-aa51-6aa1afd36704",CSSSelectorDescriptor = "",XPathDescriptor = ""};
            MainConsult = RPSControlFactory.RPSCreateCollection<SampleFrequencyCollectionView,SampleFrequencyEntityView>( params_MainConsult,this,Screen.SampleFrequencyEntityView);
 

        }
        public IRPSButton<SampleFrequencyCollectionView,SampleFrequencyEntityView> NewButton { get; set; } 
        public IRPSCollectionEditor<SampleFrequencyCollectionView,SampleFrequencyEntityView> MainConsult { get; set; } 
        public SampleFrequency Screen { get; set; }
        public SampleFrequencyCollectionView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class SampleFrequencyEntityView : View
    {
        public SampleFrequencyEntityView(SampleFrequency screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            SaveButton = RPSControlFactory.RPSSaveButton<SampleFrequencyEntityView>( this);
 
            DeleteButton = RPSControlFactory.RPSDeleteButton<SampleFrequencyEntityView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<SampleFrequencyEntityView,SampleFrequencyCollectionView>( this,Screen.SampleFrequencyCollectionView);
 
            BackButton = RPSControlFactory.RPSBackButton<SampleFrequencyEntityView,SampleFrequencyCollectionView>( this,Screen.SampleFrequencyCollectionView);
 
            CodSampleFrequency = RPSControlFactory.CreateRPSTextBox<SampleFrequencyEntityView>("b3f3050d-2392-4d57-a99a-8238f25d7214","","",true, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<SampleFrequencyEntityView>("9ab5ba7c-03fa-431f-8652-d9f50337593a","","",false, this);
 
            CollectionInit params_SampleFrecuencyByLangs = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="7d9ba51d-2e21-4827-82e8-c12c021d734c",CSSSelectorGrid="",XPathGrid=""};
            SampleFrecuencyByLangs = RPSControlFactory.RPSCreateCollectionWithGrid<SampleFrecuencyByLangsCollectionEditor<SampleFrequencyEntityView,SampleFrequencyByLangView>,SampleFrequencyEntityView,SampleFrequencyByLangView>( params_SampleFrecuencyByLangs,this,Screen.SampleFrequencyByLangView);
 

        }
        public IRPSSaveButton<SampleFrequencyEntityView> SaveButton { get; set; } 
        public IRPSButton<SampleFrequencyEntityView> DeleteButton { get; set; } 
        public IRPSButton<SampleFrequencyEntityView,SampleFrequencyCollectionView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<SampleFrequencyEntityView,SampleFrequencyCollectionView> BackButton { get; set; } 
        public IRPSTextBox<SampleFrequencyEntityView> CodSampleFrequency { get; set; } 
        public IRPSTextBox<SampleFrequencyEntityView> Description { get; set; } 
        public SampleFrecuencyByLangsCollectionEditor<SampleFrequencyEntityView,SampleFrequencyByLangView> SampleFrecuencyByLangs { get; set; } 
        public SampleFrequency Screen { get; set; }
        public SampleFrequencyEntityView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class SampleFrecuencyByLangsCollectionEditor<SampleFrequencyEntityView,SampleFrequencyByLangView>:RPSCollectionEditor<SampleFrequencyEntityView,SampleFrequencyByLangView> where SampleFrequencyEntityView : class, IView where SampleFrequencyByLangView : class, IView
    {
        public  SampleFrecuencyByLangsGridView<SampleFrequencyEntityView,SampleFrequencyByLangView> GridView {get;set;}
    }
    public partial class SampleFrecuencyByLangsGridView <SampleFrequencyEntityView,SampleFrequencyByLangView> :  RPSGridView<SampleFrequencyEntityView,SampleFrequencyByLangView> where SampleFrequencyEntityView : class, IView where SampleFrequencyByLangView : class, IView
    {
        public SampleFrecuencyByLangsGridView(SampleFrequencyEntityView currentView,SampleFrequencyByLangView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            CodLanguage = RPSControlFactory.CreateRPSGridComboBox<SampleFrequencyEntityView>("","#7d9ba51d-2e21-4827-82e8-c12c021d734c .ag-row[role='row']@ROWINDEX [col-id='cCodLanguage']","",true, this.CurrentView);
 
            Description = RPSControlFactory.CreateRPSGridTextBox<SampleFrequencyEntityView>("","#7d9ba51d-2e21-4827-82e8-c12c021d734c .ag-row[role='row']@ROWINDEX [col-id='cDescription']","",false, this.CurrentView);
 

        }
        public IRPSGridComboBox<SampleFrequencyEntityView> CodLanguage { get; set; } 
        public IRPSGridTextBox<SampleFrequencyEntityView> Description { get; set; } 
                     
    }
 
    }
  
            
    public partial class SampleFrequencyByLangView : View
    {
        public SampleFrequencyByLangView(SampleFrequency screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            DeleteButton = RPSControlFactory.RPSDeleteButton<SampleFrequencyByLangView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<SampleFrequencyByLangView,SampleFrequencyEntityView>( this,Screen.SampleFrequencyEntityView);
 
            BackButton = RPSControlFactory.RPSBackButton<SampleFrequencyByLangView,SampleFrequencyEntityView>( this,Screen.SampleFrequencyEntityView);
 
            AcceptButton = RPSControlFactory.RPSAcceptButton<SampleFrequencyByLangView,SampleFrequencyEntityView>( this,Screen.SampleFrequencyEntityView);
 
            CodLanguage = RPSControlFactory.CreateRPSComboBox<SampleFrequencyByLangView>("4c676b92-613e-445b-93e8-ed6335af7d91","","",true, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<SampleFrequencyByLangView>("5d814ec8-b7f2-476b-b1b8-1b111bdabf68","","",false, this);
 

        }
        public IRPSButton<SampleFrequencyByLangView> DeleteButton { get; set; } 
        public IRPSButton<SampleFrequencyByLangView,SampleFrequencyEntityView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<SampleFrequencyByLangView,SampleFrequencyEntityView> BackButton { get; set; } 
        public IRPSAcceptButton<SampleFrequencyByLangView,SampleFrequencyEntityView> AcceptButton { get; set; } 
        public IRPSComboBox<SampleFrequencyByLangView> CodLanguage { get; set; } 
        public IRPSTextBox<SampleFrequencyByLangView> Description { get; set; } 
        public SampleFrequency Screen { get; set; }
        public SampleFrequencyByLangView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}