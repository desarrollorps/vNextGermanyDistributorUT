    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.Purchase.Sector
{
    //RPS VERSION 1.0.0.0
    public partial class Sector:Screen
    {
        public Sector():base()
        {
            this.URL = "purchase.sector";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            SectorCollectionView  = new SectorCollectionView(this); 
            SectorEntityView  = new SectorEntityView(this); 
            SectorByLangView  = new SectorByLangView(this); 
            SectorCollectionView.InitializeControls(); 
            SectorEntityView.InitializeControls(); 
            SectorByLangView.InitializeControls(); 
           
        }
      
            public SectorCollectionView SectorCollectionView {get; set; } 
            public SectorEntityView SectorEntityView {get; set; } 
            public SectorByLangView SectorByLangView {get; set; } 
    }
            
    public partial class SectorCollectionView : View
    {
        public SectorCollectionView(Sector screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            NewButton = RPSControlFactory.RPSNewButton<SectorCollectionView,SectorEntityView>( this,Screen.SectorEntityView);
 
            CollectionInit params_MainConsult = new CollectionInit(){IDDescriptor = "4265a142-68b7-4653-a5c1-e3e45af0c32b",CSSSelectorDescriptor = "",XPathDescriptor = ""};
            MainConsult = RPSControlFactory.RPSCreateCollection<SectorCollectionView,SectorEntityView>( params_MainConsult,this,Screen.SectorEntityView);
 

        }
        public IRPSButton<SectorCollectionView,SectorEntityView> NewButton { get; set; } 
        public IRPSCollectionEditor<SectorCollectionView,SectorEntityView> MainConsult { get; set; } 
        public Sector Screen { get; set; }
        public SectorCollectionView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class SectorEntityView : View
    {
        public SectorEntityView(Sector screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            SaveButton = RPSControlFactory.RPSSaveButton<SectorEntityView>( this);
 
            DeleteButton = RPSControlFactory.RPSDeleteButton<SectorEntityView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<SectorEntityView,SectorCollectionView>( this,Screen.SectorCollectionView);
 
            BackButton = RPSControlFactory.RPSBackButton<SectorEntityView,SectorCollectionView>( this,Screen.SectorCollectionView);
 
            CodSector = RPSControlFactory.CreateRPSTextBox<SectorEntityView>("2a358dd3-f5a0-4dc4-9076-1856576d89e3","","",true, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<SectorEntityView>("7cd91171-e30f-4a30-864e-ca018dfd62b2","","",false, this);
 
            CollectionInit params_SectorByLangs = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="543c38ea-9a76-4f9b-8a36-2c2c1988fd10",CSSSelectorGrid="",XPathGrid=""};
            SectorByLangs = RPSControlFactory.RPSCreateCollectionWithGrid<SectorByLangsCollectionEditor<SectorEntityView,SectorByLangView>,SectorEntityView,SectorByLangView>( params_SectorByLangs,this,Screen.SectorByLangView);
 

        }
        public IRPSSaveButton<SectorEntityView> SaveButton { get; set; } 
        public IRPSButton<SectorEntityView> DeleteButton { get; set; } 
        public IRPSButton<SectorEntityView,SectorCollectionView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<SectorEntityView,SectorCollectionView> BackButton { get; set; } 
        public IRPSTextBox<SectorEntityView> CodSector { get; set; } 
        public IRPSTextBox<SectorEntityView> Description { get; set; } 
        public SectorByLangsCollectionEditor<SectorEntityView,SectorByLangView> SectorByLangs { get; set; } 
        public Sector Screen { get; set; }
        public SectorEntityView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class SectorByLangsCollectionEditor<SectorEntityView,SectorByLangView>:RPSCollectionEditor<SectorEntityView,SectorByLangView> where SectorEntityView : class, IView where SectorByLangView : class, IView
    {
        public  SectorByLangsGridView<SectorEntityView,SectorByLangView> GridView {get;set;}
    }
    public partial class SectorByLangsGridView <SectorEntityView,SectorByLangView> :  RPSGridView<SectorEntityView,SectorByLangView> where SectorEntityView : class, IView where SectorByLangView : class, IView
    {
        public SectorByLangsGridView(SectorEntityView currentView,SectorByLangView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            CodLanguage = RPSControlFactory.CreateRPSGridComboBox<SectorEntityView>("","#543c38ea-9a76-4f9b-8a36-2c2c1988fd10 .ag-row[role='row']@ROWINDEX [col-id='cCodLanguage']","",true, this.CurrentView);
 
            Description = RPSControlFactory.CreateRPSGridTextBox<SectorEntityView>("","#543c38ea-9a76-4f9b-8a36-2c2c1988fd10 .ag-row[role='row']@ROWINDEX [col-id='cDescription']","",false, this.CurrentView);
 

        }
        public IRPSGridComboBox<SectorEntityView> CodLanguage { get; set; } 
        public IRPSGridTextBox<SectorEntityView> Description { get; set; } 
                     
    }
 
    }
  
            
    public partial class SectorByLangView : View
    {
        public SectorByLangView(Sector screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            DeleteButton = RPSControlFactory.RPSDeleteButton<SectorByLangView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<SectorByLangView,SectorEntityView>( this,Screen.SectorEntityView);
 
            BackButton = RPSControlFactory.RPSBackButton<SectorByLangView,SectorEntityView>( this,Screen.SectorEntityView);
 
            AcceptButton = RPSControlFactory.RPSAcceptButton<SectorByLangView,SectorEntityView>( this,Screen.SectorEntityView);
 
            CodLanguage = RPSControlFactory.CreateRPSComboBox<SectorByLangView>("f363c745-5ff8-4d55-8fac-b5135b36246e","","",true, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<SectorByLangView>("2d44bd9c-af59-4ffb-9a88-2b6cd5c0a04f","","",false, this);
 

        }
        public IRPSButton<SectorByLangView> DeleteButton { get; set; } 
        public IRPSButton<SectorByLangView,SectorEntityView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<SectorByLangView,SectorEntityView> BackButton { get; set; } 
        public IRPSAcceptButton<SectorByLangView,SectorEntityView> AcceptButton { get; set; } 
        public IRPSComboBox<SectorByLangView> CodLanguage { get; set; } 
        public IRPSTextBox<SectorByLangView> Description { get; set; } 
        public Sector Screen { get; set; }
        public SectorByLangView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}