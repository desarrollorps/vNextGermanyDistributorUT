    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.Quality.MeasureTechnique
{
    //RPS VERSION 1.0.0.0
    public partial class MeasureTechnique:Screen
    {
        public MeasureTechnique():base()
        {
            this.URL = "quality.measuretechnique";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            MeasureTechniqueCollectionView  = new MeasureTechniqueCollectionView(this); 
            MeasureTechniqueEntityView  = new MeasureTechniqueEntityView(this); 
            MeasureTechniqueByLangView  = new MeasureTechniqueByLangView(this); 
            MeasureTechniqueCollectionView.InitializeControls(); 
            MeasureTechniqueEntityView.InitializeControls(); 
            MeasureTechniqueByLangView.InitializeControls(); 
           
        }
      
            public MeasureTechniqueCollectionView MeasureTechniqueCollectionView {get; set; } 
            public MeasureTechniqueEntityView MeasureTechniqueEntityView {get; set; } 
            public MeasureTechniqueByLangView MeasureTechniqueByLangView {get; set; } 
    }
            
    public partial class MeasureTechniqueCollectionView : View
    {
        public MeasureTechniqueCollectionView(MeasureTechnique screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            NewButton = RPSControlFactory.RPSNewButton<MeasureTechniqueCollectionView,MeasureTechniqueEntityView>( this,Screen.MeasureTechniqueEntityView);
 
            CollectionInit params_MainConsult = new CollectionInit(){IDDescriptor = "f64d26e7-512c-4a8d-a7fe-ee0a5eb971fe",CSSSelectorDescriptor = "",XPathDescriptor = ""};
            MainConsult = RPSControlFactory.RPSCreateCollection<MeasureTechniqueCollectionView,MeasureTechniqueEntityView>( params_MainConsult,this,Screen.MeasureTechniqueEntityView);
 

        }
        public IRPSButton<MeasureTechniqueCollectionView,MeasureTechniqueEntityView> NewButton { get; set; } 
        public IRPSCollectionEditor<MeasureTechniqueCollectionView,MeasureTechniqueEntityView> MainConsult { get; set; } 
        public MeasureTechnique Screen { get; set; }
        public MeasureTechniqueCollectionView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class MeasureTechniqueEntityView : View
    {
        public MeasureTechniqueEntityView(MeasureTechnique screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            SaveButton = RPSControlFactory.RPSSaveButton<MeasureTechniqueEntityView>( this);
 
            DeleteButton = RPSControlFactory.RPSDeleteButton<MeasureTechniqueEntityView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<MeasureTechniqueEntityView,MeasureTechniqueCollectionView>( this,Screen.MeasureTechniqueCollectionView);
 
            BackButton = RPSControlFactory.RPSBackButton<MeasureTechniqueEntityView,MeasureTechniqueCollectionView>( this,Screen.MeasureTechniqueCollectionView);
 
            CodMeasureTechnique = RPSControlFactory.CreateRPSTextBox<MeasureTechniqueEntityView>("9cab6782-bd4e-4fb9-96fd-f0c5bc34f5bd","","",true, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<MeasureTechniqueEntityView>("3bf96f99-7404-477b-bdc1-365f1b534974","","",false, this);
 
            CollectionInit params_MeasureTechniqueByLangs = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="aae11543-3676-4689-a93d-94e8da6bbb36",CSSSelectorGrid="",XPathGrid=""};
            MeasureTechniqueByLangs = RPSControlFactory.RPSCreateCollectionWithGrid<MeasureTechniqueByLangsCollectionEditor<MeasureTechniqueEntityView,MeasureTechniqueByLangView>,MeasureTechniqueEntityView,MeasureTechniqueByLangView>( params_MeasureTechniqueByLangs,this,Screen.MeasureTechniqueByLangView);
 

        }
        public IRPSSaveButton<MeasureTechniqueEntityView> SaveButton { get; set; } 
        public IRPSButton<MeasureTechniqueEntityView> DeleteButton { get; set; } 
        public IRPSButton<MeasureTechniqueEntityView,MeasureTechniqueCollectionView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<MeasureTechniqueEntityView,MeasureTechniqueCollectionView> BackButton { get; set; } 
        public IRPSTextBox<MeasureTechniqueEntityView> CodMeasureTechnique { get; set; } 
        public IRPSTextBox<MeasureTechniqueEntityView> Description { get; set; } 
        public MeasureTechniqueByLangsCollectionEditor<MeasureTechniqueEntityView,MeasureTechniqueByLangView> MeasureTechniqueByLangs { get; set; } 
        public MeasureTechnique Screen { get; set; }
        public MeasureTechniqueEntityView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class MeasureTechniqueByLangsCollectionEditor<MeasureTechniqueEntityView,MeasureTechniqueByLangView>:RPSCollectionEditor<MeasureTechniqueEntityView,MeasureTechniqueByLangView> where MeasureTechniqueEntityView : class, IView where MeasureTechniqueByLangView : class, IView
    {
        public  MeasureTechniqueByLangsGridView<MeasureTechniqueEntityView,MeasureTechniqueByLangView> GridView {get;set;}
    }
    public partial class MeasureTechniqueByLangsGridView <MeasureTechniqueEntityView,MeasureTechniqueByLangView> :  RPSGridView<MeasureTechniqueEntityView,MeasureTechniqueByLangView> where MeasureTechniqueEntityView : class, IView where MeasureTechniqueByLangView : class, IView
    {
        public MeasureTechniqueByLangsGridView(MeasureTechniqueEntityView currentView,MeasureTechniqueByLangView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            CodLanguage = RPSControlFactory.CreateRPSGridComboBox<MeasureTechniqueEntityView>("","#aae11543-3676-4689-a93d-94e8da6bbb36 .ag-row[role='row']@ROWINDEX [col-id='cCodLanguage']","",true, this.CurrentView);
 
            Description = RPSControlFactory.CreateRPSGridTextBox<MeasureTechniqueEntityView>("","#aae11543-3676-4689-a93d-94e8da6bbb36 .ag-row[role='row']@ROWINDEX [col-id='cDescription']","",false, this.CurrentView);
 

        }
        public IRPSGridComboBox<MeasureTechniqueEntityView> CodLanguage { get; set; } 
        public IRPSGridTextBox<MeasureTechniqueEntityView> Description { get; set; } 
                     
    }
 
    }
  
            
    public partial class MeasureTechniqueByLangView : View
    {
        public MeasureTechniqueByLangView(MeasureTechnique screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            DeleteButton = RPSControlFactory.RPSDeleteButton<MeasureTechniqueByLangView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<MeasureTechniqueByLangView,MeasureTechniqueEntityView>( this,Screen.MeasureTechniqueEntityView);
 
            BackButton = RPSControlFactory.RPSBackButton<MeasureTechniqueByLangView,MeasureTechniqueEntityView>( this,Screen.MeasureTechniqueEntityView);
 
            AcceptButton = RPSControlFactory.RPSAcceptButton<MeasureTechniqueByLangView,MeasureTechniqueEntityView>( this,Screen.MeasureTechniqueEntityView);
 
            CodLanguage = RPSControlFactory.CreateRPSComboBox<MeasureTechniqueByLangView>("6f24c35f-2552-4f8b-8278-5e769df18ec4","","",true, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<MeasureTechniqueByLangView>("47fcb73a-b7d6-4edd-8d06-3ff01f022cf6","","",false, this);
 

        }
        public IRPSButton<MeasureTechniqueByLangView> DeleteButton { get; set; } 
        public IRPSButton<MeasureTechniqueByLangView,MeasureTechniqueEntityView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<MeasureTechniqueByLangView,MeasureTechniqueEntityView> BackButton { get; set; } 
        public IRPSAcceptButton<MeasureTechniqueByLangView,MeasureTechniqueEntityView> AcceptButton { get; set; } 
        public IRPSComboBox<MeasureTechniqueByLangView> CodLanguage { get; set; } 
        public IRPSTextBox<MeasureTechniqueByLangView> Description { get; set; } 
        public MeasureTechnique Screen { get; set; }
        public MeasureTechniqueByLangView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}