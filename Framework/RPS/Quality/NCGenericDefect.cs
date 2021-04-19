    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.Quality.NCGenericDefect
{
    //RPS VERSION 1.0.0.0
    public partial class NCGenericDefect:Screen
    {
        public NCGenericDefect():base()
        {
            this.URL = "quality.ncgenericdefect";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            NCGenericDefectCollectionView  = new NCGenericDefectCollectionView(this); 
            NCGenericDefectEntityView  = new NCGenericDefectEntityView(this); 
            NCGenericDefectByLangView  = new NCGenericDefectByLangView(this); 
            NCGenericDefectCollectionView.InitializeControls(); 
            NCGenericDefectEntityView.InitializeControls(); 
            NCGenericDefectByLangView.InitializeControls(); 
           
        }
      
            public NCGenericDefectCollectionView NCGenericDefectCollectionView {get; set; } 
            public NCGenericDefectEntityView NCGenericDefectEntityView {get; set; } 
            public NCGenericDefectByLangView NCGenericDefectByLangView {get; set; } 
    }
            
    public partial class NCGenericDefectCollectionView : View
    {
        public NCGenericDefectCollectionView(NCGenericDefect screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            NewButton = RPSControlFactory.RPSNewButton<NCGenericDefectCollectionView,NCGenericDefectEntityView>( this,Screen.NCGenericDefectEntityView);
 
            CollectionInit params_MainConsult = new CollectionInit(){IDDescriptor = "7b723a0e-e297-43a5-941a-398d38982f83",CSSSelectorDescriptor = "",XPathDescriptor = ""};
            MainConsult = RPSControlFactory.RPSCreateCollection<NCGenericDefectCollectionView,NCGenericDefectEntityView>( params_MainConsult,this,Screen.NCGenericDefectEntityView);
 

        }
        public IRPSButton<NCGenericDefectCollectionView,NCGenericDefectEntityView> NewButton { get; set; } 
        public IRPSCollectionEditor<NCGenericDefectCollectionView,NCGenericDefectEntityView> MainConsult { get; set; } 
        public NCGenericDefect Screen { get; set; }
        public NCGenericDefectCollectionView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class NCGenericDefectEntityView : View
    {
        public NCGenericDefectEntityView(NCGenericDefect screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            SaveButton = RPSControlFactory.RPSSaveButton<NCGenericDefectEntityView>( this);
 
            DeleteButton = RPSControlFactory.RPSDeleteButton<NCGenericDefectEntityView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<NCGenericDefectEntityView,NCGenericDefectCollectionView>( this,Screen.NCGenericDefectCollectionView);
 
            BackButton = RPSControlFactory.RPSBackButton<NCGenericDefectEntityView,NCGenericDefectCollectionView>( this,Screen.NCGenericDefectCollectionView);
 
            CodDefect = RPSControlFactory.CreateRPSTextBox<NCGenericDefectEntityView>("73ea2c31-1962-4bfe-95af-56a60c2448cb","","",true, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<NCGenericDefectEntityView>("bec7a528-f2ac-4a79-b1e7-33d56b976bb4","","",false, this);
 
            CollectionInit params_NCGenericDefectByLangs = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="1ade1045-fee6-4f49-8d2f-44476299e380",CSSSelectorGrid="",XPathGrid=""};
            NCGenericDefectByLangs = RPSControlFactory.RPSCreateCollectionWithGrid<NCGenericDefectByLangsCollectionEditor<NCGenericDefectEntityView,NCGenericDefectByLangView>,NCGenericDefectEntityView,NCGenericDefectByLangView>( params_NCGenericDefectByLangs,this,Screen.NCGenericDefectByLangView);
 

        }
        public IRPSSaveButton<NCGenericDefectEntityView> SaveButton { get; set; } 
        public IRPSButton<NCGenericDefectEntityView> DeleteButton { get; set; } 
        public IRPSButton<NCGenericDefectEntityView,NCGenericDefectCollectionView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<NCGenericDefectEntityView,NCGenericDefectCollectionView> BackButton { get; set; } 
        public IRPSTextBox<NCGenericDefectEntityView> CodDefect { get; set; } 
        public IRPSTextBox<NCGenericDefectEntityView> Description { get; set; } 
        public NCGenericDefectByLangsCollectionEditor<NCGenericDefectEntityView,NCGenericDefectByLangView> NCGenericDefectByLangs { get; set; } 
        public NCGenericDefect Screen { get; set; }
        public NCGenericDefectEntityView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class NCGenericDefectByLangsCollectionEditor<NCGenericDefectEntityView,NCGenericDefectByLangView>:RPSCollectionEditor<NCGenericDefectEntityView,NCGenericDefectByLangView> where NCGenericDefectEntityView : class, IView where NCGenericDefectByLangView : class, IView
    {
        public  NCGenericDefectByLangsGridView<NCGenericDefectEntityView,NCGenericDefectByLangView> GridView {get;set;}
    }
    public partial class NCGenericDefectByLangsGridView <NCGenericDefectEntityView,NCGenericDefectByLangView> :  RPSGridView<NCGenericDefectEntityView,NCGenericDefectByLangView> where NCGenericDefectEntityView : class, IView where NCGenericDefectByLangView : class, IView
    {
        public NCGenericDefectByLangsGridView(NCGenericDefectEntityView currentView,NCGenericDefectByLangView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            CodLanguage = RPSControlFactory.CreateRPSGridComboBox<NCGenericDefectEntityView>("","#1ade1045-fee6-4f49-8d2f-44476299e380 .ag-row[role='row']@ROWINDEX [col-id='cCodLanguage']","",true, this.CurrentView);
 
            Description = RPSControlFactory.CreateRPSGridTextBox<NCGenericDefectEntityView>("","#1ade1045-fee6-4f49-8d2f-44476299e380 .ag-row[role='row']@ROWINDEX [col-id='cDescription']","",false, this.CurrentView);
 

        }
        public IRPSGridComboBox<NCGenericDefectEntityView> CodLanguage { get; set; } 
        public IRPSGridTextBox<NCGenericDefectEntityView> Description { get; set; } 
                     
    }
 
    }
  
            
    public partial class NCGenericDefectByLangView : View
    {
        public NCGenericDefectByLangView(NCGenericDefect screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            DeleteButton = RPSControlFactory.RPSDeleteButton<NCGenericDefectByLangView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<NCGenericDefectByLangView,NCGenericDefectEntityView>( this,Screen.NCGenericDefectEntityView);
 
            BackButton = RPSControlFactory.RPSBackButton<NCGenericDefectByLangView,NCGenericDefectEntityView>( this,Screen.NCGenericDefectEntityView);
 
            AcceptButton = RPSControlFactory.RPSAcceptButton<NCGenericDefectByLangView,NCGenericDefectEntityView>( this,Screen.NCGenericDefectEntityView);
 
            CodLanguage = RPSControlFactory.CreateRPSComboBox<NCGenericDefectByLangView>("990c41f5-4638-43cf-a48f-b204c69a54e1","","",true, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<NCGenericDefectByLangView>("3bf8b8c6-1314-4c3e-8143-1ce3e8cd5662","","",false, this);
 

        }
        public IRPSButton<NCGenericDefectByLangView> DeleteButton { get; set; } 
        public IRPSButton<NCGenericDefectByLangView,NCGenericDefectEntityView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<NCGenericDefectByLangView,NCGenericDefectEntityView> BackButton { get; set; } 
        public IRPSAcceptButton<NCGenericDefectByLangView,NCGenericDefectEntityView> AcceptButton { get; set; } 
        public IRPSComboBox<NCGenericDefectByLangView> CodLanguage { get; set; } 
        public IRPSTextBox<NCGenericDefectByLangView> Description { get; set; } 
        public NCGenericDefect Screen { get; set; }
        public NCGenericDefectByLangView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}