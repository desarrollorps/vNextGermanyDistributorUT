    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.Manufacturing.SimulationArticle
{
    //RPS VERSION 1.0.0.0
    public partial class SimulationArticle:Screen
    {
        public SimulationArticle():base()
        {
            this.URL = "manufacturing.simulationarticle";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            ArticleCostSimVMQueryView  = new ArticleCostSimVMQueryView(this); 
            ArticleCostSimVMEntityView  = new ArticleCostSimVMEntityView(this); 
            SimulationArticleDialogView  = new SimulationArticleDialogView(this); 
            ArticleCostSimVMQueryView.InitializeControls(); 
            ArticleCostSimVMEntityView.InitializeControls(); 
            SimulationArticleDialogView.InitializeControls(); 
           
        }
      
            public ArticleCostSimVMQueryView ArticleCostSimVMQueryView {get; set; } 
            public ArticleCostSimVMEntityView ArticleCostSimVMEntityView {get; set; } 
            public SimulationArticleDialogView SimulationArticleDialogView {get; set; } 
    }
            
    public partial class ArticleCostSimVMQueryView : View
    {
        public ArticleCostSimVMQueryView(SimulationArticle screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            NewButton = RPSControlFactory.RPSNewButton<ArticleCostSimVMQueryView,ArticleCostSimVMEntityView>( this,Screen.ArticleCostSimVMEntityView);
 
            ConsultButton = RPSControlFactory.RPSConsultButton<ArticleCostSimVMQueryView>( this);
 
            Site = RPSControlFactory.CreateRPSComboBox<ArticleCostSimVMQueryView>("e53996a0-9b2c-43b3-a6f8-4c5157cf0d7e","","",false, this);
 
            DeleteCommandButton = RPSControlFactory.CreateRPSButton<ArticleCostSimVMQueryView>( "d841f7f5-ce83-49a9-9140-bc9cf5a6eb4d","","",this);
 
            SimulationArticleNavigationCommandButton = RPSControlFactory.CreateRPSButtonToView<ArticleCostSimVMQueryView,SimulationArticleDialogView>("9233909b-981b-4010-8f6b-2b8c76c30b18","","", this,Screen.SimulationArticleDialogView);
 
            CollectionInit params_ArticleCostSim = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="2ca7b087-06e8-4fd7-ad53-4758dd262cfe",CSSSelectorGrid="",XPathGrid=""};
            ArticleCostSim = RPSControlFactory.RPSCreateCollectionWithGrid<ArticleCostSimCollectionEditor<ArticleCostSimVMQueryView,ArticleCostSimVMEntityView>,ArticleCostSimVMQueryView,ArticleCostSimVMEntityView>( params_ArticleCostSim,this,Screen.ArticleCostSimVMEntityView);
 

        }
        public IRPSButton<ArticleCostSimVMQueryView,ArticleCostSimVMEntityView> NewButton { get; set; } 
        public IRPSButton<ArticleCostSimVMQueryView> ConsultButton { get; set; } 
        public IRPSComboBox<ArticleCostSimVMQueryView> Site { get; set; } 
        public IRPSButton<ArticleCostSimVMQueryView> DeleteCommandButton { get; set; } 
        public IRPSButton<ArticleCostSimVMQueryView,SimulationArticleDialogView> SimulationArticleNavigationCommandButton { get; set; } 
        public ArticleCostSimCollectionEditor<ArticleCostSimVMQueryView,ArticleCostSimVMEntityView> ArticleCostSim { get; set; } 
        public SimulationArticle Screen { get; set; }
        public ArticleCostSimVMQueryView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class ArticleCostSimCollectionEditor<ArticleCostSimVMQueryView,ArticleCostSimVMEntityView>:RPSCollectionEditor<ArticleCostSimVMQueryView,ArticleCostSimVMEntityView> where ArticleCostSimVMQueryView : class, IView where ArticleCostSimVMEntityView : class, IView
    {
        public  ArticleCostSimGridView<ArticleCostSimVMQueryView,ArticleCostSimVMEntityView> GridView {get;set;}
    }
    public partial class ArticleCostSimGridView <ArticleCostSimVMQueryView,ArticleCostSimVMEntityView> :  RPSGridView<ArticleCostSimVMQueryView,ArticleCostSimVMEntityView> where ArticleCostSimVMQueryView : class, IView where ArticleCostSimVMEntityView : class, IView
    {
        public ArticleCostSimGridView(ArticleCostSimVMQueryView currentView,ArticleCostSimVMEntityView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            ArticleCostSim_CostPrice = RPSControlFactory.CreateRPSGridFormattedTextBox<ArticleCostSimVMQueryView>("","#2ca7b087-06e8-4fd7-ad53-4758dd262cfe .ag-row[role='row']@ROWINDEX [col-id='cArticleCostSim_CostPrice']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<ArticleCostSimVMQueryView> ArticleCostSim_CostPrice { get; set; } 
                     
    }
 
    }
  
            
    public partial class ArticleCostSimVMEntityView : View
    {
        public ArticleCostSimVMEntityView(SimulationArticle screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            SaveButton = RPSControlFactory.RPSSaveButton<ArticleCostSimVMEntityView>( this);
 
            DeleteButton = RPSControlFactory.RPSDeleteButton<ArticleCostSimVMEntityView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<ArticleCostSimVMEntityView,ArticleCostSimVMQueryView>( this,Screen.ArticleCostSimVMQueryView);
 
            BackButton = RPSControlFactory.RPSBackButton<ArticleCostSimVMEntityView,ArticleCostSimVMQueryView>( this,Screen.ArticleCostSimVMQueryView);
 
            IDSite = RPSControlFactory.CreateRPSComboBox<ArticleCostSimVMEntityView>("93e06a5c-b8c2-4d96-9818-0c9532cf207b","","",true, this);
 
            IDArticle = RPSControlFactory.CreateRPSComboBox<ArticleCostSimVMEntityView>("103d4f32-6c22-40e9-9b3b-a2f268bbc9d5","","",true, this);
 
            CostPrice = RPSControlFactory.CreateRPSFormattedTextBox<ArticleCostSimVMEntityView>("ab263628-8eb5-4a6a-a387-7753abcbf8ee","","",true, this);
 

        }
        public IRPSSaveButton<ArticleCostSimVMEntityView> SaveButton { get; set; } 
        public IRPSButton<ArticleCostSimVMEntityView> DeleteButton { get; set; } 
        public IRPSButton<ArticleCostSimVMEntityView,ArticleCostSimVMQueryView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<ArticleCostSimVMEntityView,ArticleCostSimVMQueryView> BackButton { get; set; } 
        public IRPSComboBox<ArticleCostSimVMEntityView> IDSite { get; set; } 
        public IRPSComboBox<ArticleCostSimVMEntityView> IDArticle { get; set; } 
        public IRPSTextBox<ArticleCostSimVMEntityView> CostPrice { get; set; } 
        public SimulationArticle Screen { get; set; }
        public ArticleCostSimVMEntityView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class SimulationArticleDialogView : View
    {
        public SimulationArticleDialogView(SimulationArticle screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            Article = RPSControlFactory.CreateRPSCollectionComboBox<SimulationArticleDialogView>("18a2a8f1-cd3d-4605-8c6d-6cff26262638","","",false, this);
 
            Percentage = RPSControlFactory.CreateRPSFormattedTextBox<SimulationArticleDialogView>("b4d5db21-6593-43ca-98e2-2ae4ae7b0b06","","",false, this);
 
            ValuationCostPrice = RPSControlFactory.CreateRPSOption<SimulationArticleDialogView>( "f9f99548-ac40-436e-8961-aa8d74766b5a","","",this);
 
            LastPurchaseOrManufacturingPrice = RPSControlFactory.CreateRPSOption<SimulationArticleDialogView>( "a5ed9abb-e4e6-4345-8e57-91348aa0efca","","",this);
 
            AveragePrice = RPSControlFactory.CreateRPSOption<SimulationArticleDialogView>( "f8945c3d-22ed-490f-a479-658924348232","","",this);
 
            StandardPrice = RPSControlFactory.CreateRPSOption<SimulationArticleDialogView>( "39e775ef-98ea-4228-b321-49f8a5d45abf","","",this);
 

        }
        public IRPSCollectionComboBox<SimulationArticleDialogView> Article { get; set; } 
        public IRPSTextBox<SimulationArticleDialogView> Percentage { get; set; } 
        public IRPSOption<SimulationArticleDialogView> ValuationCostPrice { get; set; } 
        public IRPSOption<SimulationArticleDialogView> LastPurchaseOrManufacturingPrice { get; set; } 
        public IRPSOption<SimulationArticleDialogView> AveragePrice { get; set; } 
        public IRPSOption<SimulationArticleDialogView> StandardPrice { get; set; } 
        public SimulationArticle Screen { get; set; }
        public SimulationArticleDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}