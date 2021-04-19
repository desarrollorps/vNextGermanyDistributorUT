    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.Quality.Effect
{
    //RPS VERSION 1.0.0.0
    public partial class Effect:Screen
    {
        public Effect():base()
        {
            this.URL = "quality.effect";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            EffectCollectionView  = new EffectCollectionView(this); 
            EffectEntityView  = new EffectEntityView(this); 
            EffectByLangView  = new EffectByLangView(this); 
            EffectCollectionView.InitializeControls(); 
            EffectEntityView.InitializeControls(); 
            EffectByLangView.InitializeControls(); 
           
        }
      
            public EffectCollectionView EffectCollectionView {get; set; } 
            public EffectEntityView EffectEntityView {get; set; } 
            public EffectByLangView EffectByLangView {get; set; } 
    }
            
    public partial class EffectCollectionView : View
    {
        public EffectCollectionView(Effect screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            NewButton = RPSControlFactory.RPSNewButton<EffectCollectionView,EffectEntityView>( this,Screen.EffectEntityView);
 
            CollectionInit params_MainConsult = new CollectionInit(){IDDescriptor = "f9a735ee-35df-4545-90b3-f4ed0a7cdfaa",CSSSelectorDescriptor = "",XPathDescriptor = ""};
            MainConsult = RPSControlFactory.RPSCreateCollection<EffectCollectionView,EffectEntityView>( params_MainConsult,this,Screen.EffectEntityView);
 

        }
        public IRPSButton<EffectCollectionView,EffectEntityView> NewButton { get; set; } 
        public IRPSCollectionEditor<EffectCollectionView,EffectEntityView> MainConsult { get; set; } 
        public Effect Screen { get; set; }
        public EffectCollectionView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class EffectEntityView : View
    {
        public EffectEntityView(Effect screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            SaveButton = RPSControlFactory.RPSSaveButton<EffectEntityView>( this);
 
            DeleteButton = RPSControlFactory.RPSDeleteButton<EffectEntityView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<EffectEntityView,EffectCollectionView>( this,Screen.EffectCollectionView);
 
            BackButton = RPSControlFactory.RPSBackButton<EffectEntityView,EffectCollectionView>( this,Screen.EffectCollectionView);
 
            CodEffect = RPSControlFactory.CreateRPSTextBox<EffectEntityView>("173c1ec6-83e6-4e79-acef-d75d96c7ad0d","","",true, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<EffectEntityView>("daa4a78e-a3a8-45a9-b595-fe3604439266","","",false, this);
 
            CollectionInit params_EffectByLangs = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="0ea41e6b-6d3c-4180-bedf-b14ab06aa891",CSSSelectorGrid="",XPathGrid=""};
            EffectByLangs = RPSControlFactory.RPSCreateCollectionWithGrid<EffectByLangsCollectionEditor<EffectEntityView,EffectByLangView>,EffectEntityView,EffectByLangView>( params_EffectByLangs,this,Screen.EffectByLangView);
 

        }
        public IRPSSaveButton<EffectEntityView> SaveButton { get; set; } 
        public IRPSButton<EffectEntityView> DeleteButton { get; set; } 
        public IRPSButton<EffectEntityView,EffectCollectionView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<EffectEntityView,EffectCollectionView> BackButton { get; set; } 
        public IRPSTextBox<EffectEntityView> CodEffect { get; set; } 
        public IRPSTextBox<EffectEntityView> Description { get; set; } 
        public EffectByLangsCollectionEditor<EffectEntityView,EffectByLangView> EffectByLangs { get; set; } 
        public Effect Screen { get; set; }
        public EffectEntityView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class EffectByLangsCollectionEditor<EffectEntityView,EffectByLangView>:RPSCollectionEditor<EffectEntityView,EffectByLangView> where EffectEntityView : class, IView where EffectByLangView : class, IView
    {
        public  EffectByLangsGridView<EffectEntityView,EffectByLangView> GridView {get;set;}
    }
    public partial class EffectByLangsGridView <EffectEntityView,EffectByLangView> :  RPSGridView<EffectEntityView,EffectByLangView> where EffectEntityView : class, IView where EffectByLangView : class, IView
    {
        public EffectByLangsGridView(EffectEntityView currentView,EffectByLangView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            CodLanguage = RPSControlFactory.CreateRPSGridComboBox<EffectEntityView>("","#0ea41e6b-6d3c-4180-bedf-b14ab06aa891 .ag-row[role='row']@ROWINDEX [col-id='cCodLanguage']","",true, this.CurrentView);
 
            Description = RPSControlFactory.CreateRPSGridTextBox<EffectEntityView>("","#0ea41e6b-6d3c-4180-bedf-b14ab06aa891 .ag-row[role='row']@ROWINDEX [col-id='cDescription']","",false, this.CurrentView);
 

        }
        public IRPSGridComboBox<EffectEntityView> CodLanguage { get; set; } 
        public IRPSGridTextBox<EffectEntityView> Description { get; set; } 
                     
    }
 
    }
  
            
    public partial class EffectByLangView : View
    {
        public EffectByLangView(Effect screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            DeleteButton = RPSControlFactory.RPSDeleteButton<EffectByLangView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<EffectByLangView,EffectEntityView>( this,Screen.EffectEntityView);
 
            BackButton = RPSControlFactory.RPSBackButton<EffectByLangView,EffectEntityView>( this,Screen.EffectEntityView);
 
            AcceptButton = RPSControlFactory.RPSAcceptButton<EffectByLangView,EffectEntityView>( this,Screen.EffectEntityView);
 
            CodLanguage = RPSControlFactory.CreateRPSComboBox<EffectByLangView>("c3cff3b2-32fb-416e-a68c-1225bc2d151c","","",true, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<EffectByLangView>("c8ff7003-62ea-4ebb-b23a-86d69a1044df","","",false, this);
 

        }
        public IRPSButton<EffectByLangView> DeleteButton { get; set; } 
        public IRPSButton<EffectByLangView,EffectEntityView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<EffectByLangView,EffectEntityView> BackButton { get; set; } 
        public IRPSAcceptButton<EffectByLangView,EffectEntityView> AcceptButton { get; set; } 
        public IRPSComboBox<EffectByLangView> CodLanguage { get; set; } 
        public IRPSTextBox<EffectByLangView> Description { get; set; } 
        public Effect Screen { get; set; }
        public EffectByLangView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}