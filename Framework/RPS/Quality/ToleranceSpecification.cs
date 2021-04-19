    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.Quality.ToleranceSpecification
{
    //RPS VERSION 1.0.0.0
    public partial class ToleranceSpecification:Screen
    {
        public ToleranceSpecification():base()
        {
            this.URL = "quality.tolerancespecification";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            ToleranceSpecificationCollectionView  = new ToleranceSpecificationCollectionView(this); 
            ToleranceSpecificationEntityView  = new ToleranceSpecificationEntityView(this); 
            TolSpecificationByLangView  = new TolSpecificationByLangView(this); 
            ToleranceSpecificationCollectionView.InitializeControls(); 
            ToleranceSpecificationEntityView.InitializeControls(); 
            TolSpecificationByLangView.InitializeControls(); 
           
        }
      
            public ToleranceSpecificationCollectionView ToleranceSpecificationCollectionView {get; set; } 
            public ToleranceSpecificationEntityView ToleranceSpecificationEntityView {get; set; } 
            public TolSpecificationByLangView TolSpecificationByLangView {get; set; } 
    }
            
    public partial class ToleranceSpecificationCollectionView : View
    {
        public ToleranceSpecificationCollectionView(ToleranceSpecification screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            NewButton = RPSControlFactory.RPSNewButton<ToleranceSpecificationCollectionView,ToleranceSpecificationEntityView>( this,Screen.ToleranceSpecificationEntityView);
 
            CollectionInit params_MainConsult = new CollectionInit(){IDDescriptor = "7aea3dba-5fc0-400a-a9a0-344f3413b847",CSSSelectorDescriptor = "",XPathDescriptor = ""};
            MainConsult = RPSControlFactory.RPSCreateCollection<ToleranceSpecificationCollectionView,ToleranceSpecificationEntityView>( params_MainConsult,this,Screen.ToleranceSpecificationEntityView);
 

        }
        public IRPSButton<ToleranceSpecificationCollectionView,ToleranceSpecificationEntityView> NewButton { get; set; } 
        public IRPSCollectionEditor<ToleranceSpecificationCollectionView,ToleranceSpecificationEntityView> MainConsult { get; set; } 
        public ToleranceSpecification Screen { get; set; }
        public ToleranceSpecificationCollectionView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class ToleranceSpecificationEntityView : View
    {
        public ToleranceSpecificationEntityView(ToleranceSpecification screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            SaveButton = RPSControlFactory.RPSSaveButton<ToleranceSpecificationEntityView>( this);
 
            DeleteButton = RPSControlFactory.RPSDeleteButton<ToleranceSpecificationEntityView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<ToleranceSpecificationEntityView,ToleranceSpecificationCollectionView>( this,Screen.ToleranceSpecificationCollectionView);
 
            BackButton = RPSControlFactory.RPSBackButton<ToleranceSpecificationEntityView,ToleranceSpecificationCollectionView>( this,Screen.ToleranceSpecificationCollectionView);
 
            CodToleranceSpecification = RPSControlFactory.CreateRPSTextBox<ToleranceSpecificationEntityView>("2919eb96-5a91-4d56-b9cd-5f99072c85ed","","",true, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<ToleranceSpecificationEntityView>("13bdcdd0-3d87-4166-b4e2-0dfe5daa0216","","",false, this);
 
            CollectionInit params_TolSpecificationByLangs = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="a75c3613-ed4d-429e-8a45-ae91d1fceb92",CSSSelectorGrid="",XPathGrid=""};
            TolSpecificationByLangs = RPSControlFactory.RPSCreateCollectionWithGrid<TolSpecificationByLangsCollectionEditor<ToleranceSpecificationEntityView,TolSpecificationByLangView>,ToleranceSpecificationEntityView,TolSpecificationByLangView>( params_TolSpecificationByLangs,this,Screen.TolSpecificationByLangView);
 

        }
        public IRPSSaveButton<ToleranceSpecificationEntityView> SaveButton { get; set; } 
        public IRPSButton<ToleranceSpecificationEntityView> DeleteButton { get; set; } 
        public IRPSButton<ToleranceSpecificationEntityView,ToleranceSpecificationCollectionView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<ToleranceSpecificationEntityView,ToleranceSpecificationCollectionView> BackButton { get; set; } 
        public IRPSTextBox<ToleranceSpecificationEntityView> CodToleranceSpecification { get; set; } 
        public IRPSTextBox<ToleranceSpecificationEntityView> Description { get; set; } 
        public TolSpecificationByLangsCollectionEditor<ToleranceSpecificationEntityView,TolSpecificationByLangView> TolSpecificationByLangs { get; set; } 
        public ToleranceSpecification Screen { get; set; }
        public ToleranceSpecificationEntityView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class TolSpecificationByLangsCollectionEditor<ToleranceSpecificationEntityView,TolSpecificationByLangView>:RPSCollectionEditor<ToleranceSpecificationEntityView,TolSpecificationByLangView> where ToleranceSpecificationEntityView : class, IView where TolSpecificationByLangView : class, IView
    {
        public  TolSpecificationByLangsGridView<ToleranceSpecificationEntityView,TolSpecificationByLangView> GridView {get;set;}
    }
    public partial class TolSpecificationByLangsGridView <ToleranceSpecificationEntityView,TolSpecificationByLangView> :  RPSGridView<ToleranceSpecificationEntityView,TolSpecificationByLangView> where ToleranceSpecificationEntityView : class, IView where TolSpecificationByLangView : class, IView
    {
        public TolSpecificationByLangsGridView(ToleranceSpecificationEntityView currentView,TolSpecificationByLangView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            CodLanguage = RPSControlFactory.CreateRPSGridComboBox<ToleranceSpecificationEntityView>("","#a75c3613-ed4d-429e-8a45-ae91d1fceb92 .ag-row[role='row']@ROWINDEX [col-id='cCodLanguage']","",true, this.CurrentView);
 
            Description = RPSControlFactory.CreateRPSGridTextBox<ToleranceSpecificationEntityView>("","#a75c3613-ed4d-429e-8a45-ae91d1fceb92 .ag-row[role='row']@ROWINDEX [col-id='cDescription']","",false, this.CurrentView);
 

        }
        public IRPSGridComboBox<ToleranceSpecificationEntityView> CodLanguage { get; set; } 
        public IRPSGridTextBox<ToleranceSpecificationEntityView> Description { get; set; } 
                     
    }
 
    }
  
            
    public partial class TolSpecificationByLangView : View
    {
        public TolSpecificationByLangView(ToleranceSpecification screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            DeleteButton = RPSControlFactory.RPSDeleteButton<TolSpecificationByLangView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<TolSpecificationByLangView,ToleranceSpecificationEntityView>( this,Screen.ToleranceSpecificationEntityView);
 
            BackButton = RPSControlFactory.RPSBackButton<TolSpecificationByLangView,ToleranceSpecificationEntityView>( this,Screen.ToleranceSpecificationEntityView);
 
            AcceptButton = RPSControlFactory.RPSAcceptButton<TolSpecificationByLangView,ToleranceSpecificationEntityView>( this,Screen.ToleranceSpecificationEntityView);
 
            CodLanguage = RPSControlFactory.CreateRPSComboBox<TolSpecificationByLangView>("3d0a1384-7369-4ee1-a2d2-e56393062a50","","",true, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<TolSpecificationByLangView>("3233106a-effe-4636-a11a-2be2c0c638a4","","",false, this);
 

        }
        public IRPSButton<TolSpecificationByLangView> DeleteButton { get; set; } 
        public IRPSButton<TolSpecificationByLangView,ToleranceSpecificationEntityView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<TolSpecificationByLangView,ToleranceSpecificationEntityView> BackButton { get; set; } 
        public IRPSAcceptButton<TolSpecificationByLangView,ToleranceSpecificationEntityView> AcceptButton { get; set; } 
        public IRPSComboBox<TolSpecificationByLangView> CodLanguage { get; set; } 
        public IRPSTextBox<TolSpecificationByLangView> Description { get; set; } 
        public ToleranceSpecification Screen { get; set; }
        public TolSpecificationByLangView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}