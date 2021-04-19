    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.Warehouse.ArticleLabelGroup
{
    //RPS VERSION 1.0.0.0
    public partial class ArticleLabelGroup:Screen
    {
        public ArticleLabelGroup():base()
        {
            this.URL = "warehouse.articlelabelgroup";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            ArticleLabelGroupCollectionView  = new ArticleLabelGroupCollectionView(this); 
            ArticleLabelGroupEntityView  = new ArticleLabelGroupEntityView(this); 
            ArticleLabelGroupByLangView  = new ArticleLabelGroupByLangView(this); 
            ArticleLabelGroupCollectionView.InitializeControls(); 
            ArticleLabelGroupEntityView.InitializeControls(); 
            ArticleLabelGroupByLangView.InitializeControls(); 
           
        }
      
            public ArticleLabelGroupCollectionView ArticleLabelGroupCollectionView {get; set; } 
            public ArticleLabelGroupEntityView ArticleLabelGroupEntityView {get; set; } 
            public ArticleLabelGroupByLangView ArticleLabelGroupByLangView {get; set; } 
    }
            
    public partial class ArticleLabelGroupCollectionView : View
    {
        public ArticleLabelGroupCollectionView(ArticleLabelGroup screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            NewButton = RPSControlFactory.RPSNewButton<ArticleLabelGroupCollectionView,ArticleLabelGroupEntityView>( this,Screen.ArticleLabelGroupEntityView);
 
            CollectionInit params_MainConsult = new CollectionInit(){IDDescriptor = "70ea370e-cd5a-4c89-a8fc-0152cdfe6e0d",CSSSelectorDescriptor = "",XPathDescriptor = ""};
            MainConsult = RPSControlFactory.RPSCreateCollection<ArticleLabelGroupCollectionView,ArticleLabelGroupEntityView>( params_MainConsult,this,Screen.ArticleLabelGroupEntityView);
 

        }
        public IRPSButton<ArticleLabelGroupCollectionView,ArticleLabelGroupEntityView> NewButton { get; set; } 
        public IRPSCollectionEditor<ArticleLabelGroupCollectionView,ArticleLabelGroupEntityView> MainConsult { get; set; } 
        public ArticleLabelGroup Screen { get; set; }
        public ArticleLabelGroupCollectionView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class ArticleLabelGroupEntityView : View
    {
        public ArticleLabelGroupEntityView(ArticleLabelGroup screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            SaveButton = RPSControlFactory.RPSSaveButton<ArticleLabelGroupEntityView>( this);
 
            DeleteButton = RPSControlFactory.RPSDeleteButton<ArticleLabelGroupEntityView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<ArticleLabelGroupEntityView,ArticleLabelGroupCollectionView>( this,Screen.ArticleLabelGroupCollectionView);
 
            BackButton = RPSControlFactory.RPSBackButton<ArticleLabelGroupEntityView,ArticleLabelGroupCollectionView>( this,Screen.ArticleLabelGroupCollectionView);
 
            CodArticleLabelGroup = RPSControlFactory.CreateRPSTextBox<ArticleLabelGroupEntityView>("0c6f8a0a-26b3-40ee-8667-b374d5a87cbf","","",true, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<ArticleLabelGroupEntityView>("911f94f6-549b-4c2c-a1b6-c7dc56e76d56","","",false, this);
 
            CollectionInit params_ArticleLabelGroupByLangs = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="8997a107-07b4-4a0b-b656-09a381861700",CSSSelectorGrid="",XPathGrid=""};
            ArticleLabelGroupByLangs = RPSControlFactory.RPSCreateCollectionWithGrid<ArticleLabelGroupByLangsCollectionEditor<ArticleLabelGroupEntityView,ArticleLabelGroupByLangView>,ArticleLabelGroupEntityView,ArticleLabelGroupByLangView>( params_ArticleLabelGroupByLangs,this,Screen.ArticleLabelGroupByLangView);
 

        }
        public IRPSSaveButton<ArticleLabelGroupEntityView> SaveButton { get; set; } 
        public IRPSButton<ArticleLabelGroupEntityView> DeleteButton { get; set; } 
        public IRPSButton<ArticleLabelGroupEntityView,ArticleLabelGroupCollectionView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<ArticleLabelGroupEntityView,ArticleLabelGroupCollectionView> BackButton { get; set; } 
        public IRPSTextBox<ArticleLabelGroupEntityView> CodArticleLabelGroup { get; set; } 
        public IRPSTextBox<ArticleLabelGroupEntityView> Description { get; set; } 
        public ArticleLabelGroupByLangsCollectionEditor<ArticleLabelGroupEntityView,ArticleLabelGroupByLangView> ArticleLabelGroupByLangs { get; set; } 
        public ArticleLabelGroup Screen { get; set; }
        public ArticleLabelGroupEntityView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class ArticleLabelGroupByLangsCollectionEditor<ArticleLabelGroupEntityView,ArticleLabelGroupByLangView>:RPSCollectionEditor<ArticleLabelGroupEntityView,ArticleLabelGroupByLangView> where ArticleLabelGroupEntityView : class, IView where ArticleLabelGroupByLangView : class, IView
    {
        public  ArticleLabelGroupByLangsGridView<ArticleLabelGroupEntityView,ArticleLabelGroupByLangView> GridView {get;set;}
    }
    public partial class ArticleLabelGroupByLangsGridView <ArticleLabelGroupEntityView,ArticleLabelGroupByLangView> :  RPSGridView<ArticleLabelGroupEntityView,ArticleLabelGroupByLangView> where ArticleLabelGroupEntityView : class, IView where ArticleLabelGroupByLangView : class, IView
    {
        public ArticleLabelGroupByLangsGridView(ArticleLabelGroupEntityView currentView,ArticleLabelGroupByLangView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            CodLanguage = RPSControlFactory.CreateRPSGridComboBox<ArticleLabelGroupEntityView>("","#8997a107-07b4-4a0b-b656-09a381861700 .ag-row[role='row']@ROWINDEX [col-id='cCodLanguage']","",true, this.CurrentView);
 
            Description = RPSControlFactory.CreateRPSGridTextBox<ArticleLabelGroupEntityView>("","#8997a107-07b4-4a0b-b656-09a381861700 .ag-row[role='row']@ROWINDEX [col-id='cDescription']","",false, this.CurrentView);
 

        }
        public IRPSGridComboBox<ArticleLabelGroupEntityView> CodLanguage { get; set; } 
        public IRPSGridTextBox<ArticleLabelGroupEntityView> Description { get; set; } 
                     
    }
 
    }
  
            
    public partial class ArticleLabelGroupByLangView : View
    {
        public ArticleLabelGroupByLangView(ArticleLabelGroup screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            DeleteButton = RPSControlFactory.RPSDeleteButton<ArticleLabelGroupByLangView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<ArticleLabelGroupByLangView,ArticleLabelGroupEntityView>( this,Screen.ArticleLabelGroupEntityView);
 
            BackButton = RPSControlFactory.RPSBackButton<ArticleLabelGroupByLangView,ArticleLabelGroupEntityView>( this,Screen.ArticleLabelGroupEntityView);
 
            AcceptButton = RPSControlFactory.RPSAcceptButton<ArticleLabelGroupByLangView,ArticleLabelGroupEntityView>( this,Screen.ArticleLabelGroupEntityView);
 
            CodLanguage = RPSControlFactory.CreateRPSComboBox<ArticleLabelGroupByLangView>("da4b1333-c4e9-4468-8d63-df60497cf409","","",true, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<ArticleLabelGroupByLangView>("048cf16c-29b0-4c4a-a5e8-0b0396b7ef3e","","",false, this);
 

        }
        public IRPSButton<ArticleLabelGroupByLangView> DeleteButton { get; set; } 
        public IRPSButton<ArticleLabelGroupByLangView,ArticleLabelGroupEntityView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<ArticleLabelGroupByLangView,ArticleLabelGroupEntityView> BackButton { get; set; } 
        public IRPSAcceptButton<ArticleLabelGroupByLangView,ArticleLabelGroupEntityView> AcceptButton { get; set; } 
        public IRPSComboBox<ArticleLabelGroupByLangView> CodLanguage { get; set; } 
        public IRPSTextBox<ArticleLabelGroupByLangView> Description { get; set; } 
        public ArticleLabelGroup Screen { get; set; }
        public ArticleLabelGroupByLangView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}