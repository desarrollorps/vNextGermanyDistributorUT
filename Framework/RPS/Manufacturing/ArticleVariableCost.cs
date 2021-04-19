    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.Manufacturing.ArticleVariableCost
{
    //RPS VERSION 1.0.0.0
    public partial class ArticleVariableCost:Screen
    {
        public ArticleVariableCost():base()
        {
            this.URL = "manufacturing.articlevariablecost";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            ArticleVariableCostVMQueryView  = new ArticleVariableCostVMQueryView(this); 
            ArticleVariableCostVMEntityView  = new ArticleVariableCostVMEntityView(this); 
            ArticleVariableCostVMQueryView.InitializeControls(); 
            ArticleVariableCostVMEntityView.InitializeControls(); 
           
        }
      
            public ArticleVariableCostVMQueryView ArticleVariableCostVMQueryView {get; set; } 
            public ArticleVariableCostVMEntityView ArticleVariableCostVMEntityView {get; set; } 
    }
            
    public partial class ArticleVariableCostVMQueryView : View
    {
        public ArticleVariableCostVMQueryView(ArticleVariableCost screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            NewButton = RPSControlFactory.RPSNewButton<ArticleVariableCostVMQueryView,ArticleVariableCostVMEntityView>( this,Screen.ArticleVariableCostVMEntityView);
 
            ConsultButton = RPSControlFactory.RPSConsultButton<ArticleVariableCostVMQueryView>( this);
 
            Site = RPSControlFactory.CreateRPSComboBox<ArticleVariableCostVMQueryView>("540841ac-f7d0-4a20-80dd-af4a0917752e","","",false, this);
 
            Article = RPSControlFactory.CreateRPSCollectionComboBox<ArticleVariableCostVMQueryView>("cffe8f95-a46f-4a4e-88c6-0fce94a6db64","","",false, this);
 
            Route = RPSControlFactory.CreateRPSCollectionComboBox<ArticleVariableCostVMQueryView>("304ca142-023b-4f74-9c60-7cf935359d2a","","",false, this);
 
            DateFrom = RPSControlFactory.CreateRPSTextBox<ArticleVariableCostVMQueryView>("df86d529-6a68-4de4-bdf3-c17640d6aed3","","",false, this);
 
            CollectionInit params_ArticleVariableCost = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="c6c347a6-f969-4210-8fff-7dc4126cfd69",CSSSelectorGrid="",XPathGrid=""};
            ArticleVariableCost = RPSControlFactory.RPSCreateCollectionWithGrid<ArticleVariableCostCollectionEditor<ArticleVariableCostVMQueryView,ArticleVariableCostVMEntityView>,ArticleVariableCostVMQueryView,ArticleVariableCostVMEntityView>( params_ArticleVariableCost,this,Screen.ArticleVariableCostVMEntityView);
 

        }
        public IRPSButton<ArticleVariableCostVMQueryView,ArticleVariableCostVMEntityView> NewButton { get; set; } 
        public IRPSButton<ArticleVariableCostVMQueryView> ConsultButton { get; set; } 
        public IRPSComboBox<ArticleVariableCostVMQueryView> Site { get; set; } 
        public IRPSCollectionComboBox<ArticleVariableCostVMQueryView> Article { get; set; } 
        public IRPSCollectionComboBox<ArticleVariableCostVMQueryView> Route { get; set; } 
        public IRPSTextBox<ArticleVariableCostVMQueryView> DateFrom { get; set; } 
        public ArticleVariableCostCollectionEditor<ArticleVariableCostVMQueryView,ArticleVariableCostVMEntityView> ArticleVariableCost { get; set; } 
        public ArticleVariableCost Screen { get; set; }
        public ArticleVariableCostVMQueryView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class ArticleVariableCostCollectionEditor<ArticleVariableCostVMQueryView,ArticleVariableCostVMEntityView>:RPSCollectionEditor<ArticleVariableCostVMQueryView,ArticleVariableCostVMEntityView> where ArticleVariableCostVMQueryView : class, IView where ArticleVariableCostVMEntityView : class, IView
    {
        public  ArticleVariableCostGridView<ArticleVariableCostVMQueryView,ArticleVariableCostVMEntityView> GridView {get;set;}
    }
    public partial class ArticleVariableCostGridView <ArticleVariableCostVMQueryView,ArticleVariableCostVMEntityView> :  RPSGridView<ArticleVariableCostVMQueryView,ArticleVariableCostVMEntityView> where ArticleVariableCostVMQueryView : class, IView where ArticleVariableCostVMEntityView : class, IView
    {
        public ArticleVariableCostGridView(ArticleVariableCostVMQueryView currentView,ArticleVariableCostVMEntityView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            ArticleVariableCost_DateFrom = RPSControlFactory.CreateRPSGridTextBox<ArticleVariableCostVMQueryView>("","#c6c347a6-f969-4210-8fff-7dc4126cfd69 .ag-row[role='row']@ROWINDEX [col-id='cArticleVariableCost_DateFrom']","",false, this.CurrentView);
 
            ArticleVariableCost_PercentCost1 = RPSControlFactory.CreateRPSGridFormattedTextBox<ArticleVariableCostVMQueryView>("","#c6c347a6-f969-4210-8fff-7dc4126cfd69 .ag-row[role='row']@ROWINDEX [col-id='cArticleVariableCost_PercentCost1']","",false, this.CurrentView);
 
            ArticleVariableCost_PercentCost2 = RPSControlFactory.CreateRPSGridFormattedTextBox<ArticleVariableCostVMQueryView>("","#c6c347a6-f969-4210-8fff-7dc4126cfd69 .ag-row[role='row']@ROWINDEX [col-id='cArticleVariableCost_PercentCost2']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<ArticleVariableCostVMQueryView> ArticleVariableCost_DateFrom { get; set; } 
        public IRPSGridTextBox<ArticleVariableCostVMQueryView> ArticleVariableCost_PercentCost1 { get; set; } 
        public IRPSGridTextBox<ArticleVariableCostVMQueryView> ArticleVariableCost_PercentCost2 { get; set; } 
                     
    }
 
    }
  
            
    public partial class ArticleVariableCostVMEntityView : View
    {
        public ArticleVariableCostVMEntityView(ArticleVariableCost screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            SaveButton = RPSControlFactory.RPSSaveButton<ArticleVariableCostVMEntityView>( this);
 
            DeleteButton = RPSControlFactory.RPSDeleteButton<ArticleVariableCostVMEntityView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<ArticleVariableCostVMEntityView,ArticleVariableCostVMQueryView>( this,Screen.ArticleVariableCostVMQueryView);
 
            BackButton = RPSControlFactory.RPSBackButton<ArticleVariableCostVMEntityView,ArticleVariableCostVMQueryView>( this,Screen.ArticleVariableCostVMQueryView);
 
            IDArticle = RPSControlFactory.CreateRPSComboBox<ArticleVariableCostVMEntityView>("4d887940-bf4c-4657-ab7c-075e3847a212","","",true, this);
 
            IDRoute = RPSControlFactory.CreateRPSComboBox<ArticleVariableCostVMEntityView>("f2add9d0-cc2c-4146-a8a4-47c3714b0045","","",true, this);
 
            IDSite = RPSControlFactory.CreateRPSComboBox<ArticleVariableCostVMEntityView>("717810e0-1359-4f7c-958c-9a0305eb74c1","","",true, this);
 
            DateFrom = RPSControlFactory.CreateRPSTextBox<ArticleVariableCostVMEntityView>("c5b6e74a-9222-4e9b-b28f-977928c90061","","",true, this);
 
            VarCost11 = RPSControlFactory.CreateRPSFormattedTextBox<ArticleVariableCostVMEntityView>("9789b3d2-e840-4d76-90f1-ad021d147243","","",true, this);
 
            VarCost12 = RPSControlFactory.CreateRPSFormattedTextBox<ArticleVariableCostVMEntityView>("3a41ec89-90a0-4979-aa06-c3b375808a6e","","",true, this);
 
            VarCost13 = RPSControlFactory.CreateRPSFormattedTextBox<ArticleVariableCostVMEntityView>("589e2a8c-ce14-4968-9eea-2888df984dde","","",true, this);
 
            PercentCost1 = RPSControlFactory.CreateRPSFormattedTextBox<ArticleVariableCostVMEntityView>("d0d673b0-d05b-43fb-87ca-6ca1c137381c","","",true, this);
 
            VarCost21 = RPSControlFactory.CreateRPSFormattedTextBox<ArticleVariableCostVMEntityView>("65ef0889-fd8b-4aae-8546-abb2379bd83d","","",true, this);
 
            VarCost22 = RPSControlFactory.CreateRPSFormattedTextBox<ArticleVariableCostVMEntityView>("f9a037dc-b202-402b-8c76-13bf5703faf6","","",true, this);
 
            VarCost23 = RPSControlFactory.CreateRPSFormattedTextBox<ArticleVariableCostVMEntityView>("5a427611-abd0-4eab-a2ba-c82f2c9778d3","","",true, this);
 
            PercentCost2 = RPSControlFactory.CreateRPSFormattedTextBox<ArticleVariableCostVMEntityView>("72d5e68e-3b2d-4a53-bf8d-d01d98f2308b","","",true, this);
 

        }
        public IRPSSaveButton<ArticleVariableCostVMEntityView> SaveButton { get; set; } 
        public IRPSButton<ArticleVariableCostVMEntityView> DeleteButton { get; set; } 
        public IRPSButton<ArticleVariableCostVMEntityView,ArticleVariableCostVMQueryView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<ArticleVariableCostVMEntityView,ArticleVariableCostVMQueryView> BackButton { get; set; } 
        public IRPSComboBox<ArticleVariableCostVMEntityView> IDArticle { get; set; } 
        public IRPSComboBox<ArticleVariableCostVMEntityView> IDRoute { get; set; } 
        public IRPSComboBox<ArticleVariableCostVMEntityView> IDSite { get; set; } 
        public IRPSTextBox<ArticleVariableCostVMEntityView> DateFrom { get; set; } 
        public IRPSTextBox<ArticleVariableCostVMEntityView> VarCost11 { get; set; } 
        public IRPSTextBox<ArticleVariableCostVMEntityView> VarCost12 { get; set; } 
        public IRPSTextBox<ArticleVariableCostVMEntityView> VarCost13 { get; set; } 
        public IRPSTextBox<ArticleVariableCostVMEntityView> PercentCost1 { get; set; } 
        public IRPSTextBox<ArticleVariableCostVMEntityView> VarCost21 { get; set; } 
        public IRPSTextBox<ArticleVariableCostVMEntityView> VarCost22 { get; set; } 
        public IRPSTextBox<ArticleVariableCostVMEntityView> VarCost23 { get; set; } 
        public IRPSTextBox<ArticleVariableCostVMEntityView> PercentCost2 { get; set; } 
        public ArticleVariableCost Screen { get; set; }
        public ArticleVariableCostVMEntityView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}