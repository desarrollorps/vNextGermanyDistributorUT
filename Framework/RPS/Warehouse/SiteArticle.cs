    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.Warehouse.SiteArticle
{
    //RPS VERSION 1.0.0.0
    public partial class SiteArticle:Screen
    {
        public SiteArticle():base()
        {
            this.URL = "warehouse.sitearticle";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            SiteArticleVMQueryView  = new SiteArticleVMQueryView(this); 
            SiteArticleVMEntityView  = new SiteArticleVMEntityView(this); 
            UpdateWarehouseArticleDialogView  = new UpdateWarehouseArticleDialogView(this); 
            SiteArticleVMQueryView.InitializeControls(); 
            SiteArticleVMEntityView.InitializeControls(); 
            UpdateWarehouseArticleDialogView.InitializeControls(); 
           
        }
      
            public SiteArticleVMQueryView SiteArticleVMQueryView {get; set; } 
            public SiteArticleVMEntityView SiteArticleVMEntityView {get; set; } 
            public UpdateWarehouseArticleDialogView UpdateWarehouseArticleDialogView {get; set; } 
    }
            
    public partial class SiteArticleVMQueryView : View
    {
        public SiteArticleVMQueryView(SiteArticle screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            NewButton = RPSControlFactory.RPSNewButton<SiteArticleVMQueryView,SiteArticleVMEntityView>( this,Screen.SiteArticleVMEntityView);
 
            ConsultButton = RPSControlFactory.RPSConsultButton<SiteArticleVMQueryView>( this);
 
            Article = RPSControlFactory.CreateRPSCollectionComboBox<SiteArticleVMQueryView>("d0aed11b-13f2-4be2-8ae1-774c19bb739e","","",false, this);
 
            Site = RPSControlFactory.CreateRPSCollectionComboBox<SiteArticleVMQueryView>("f69910e1-8ea1-44e1-8303-e409283245a2","","",false, this);
 
            CollectionInit params_SiteArticleQuery = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="ed84ba58-d5e7-4ee9-b27b-a2fd771605cb",CSSSelectorGrid="",XPathGrid=""};
            SiteArticleQuery = RPSControlFactory.RPSCreateCollectionWithGrid<SiteArticleQueryCollectionEditor<SiteArticleVMQueryView,SiteArticleVMEntityView>,SiteArticleVMQueryView,SiteArticleVMEntityView>( params_SiteArticleQuery,this,Screen.SiteArticleVMEntityView);
 

        }
        public IRPSButton<SiteArticleVMQueryView,SiteArticleVMEntityView> NewButton { get; set; } 
        public IRPSButton<SiteArticleVMQueryView> ConsultButton { get; set; } 
        public IRPSCollectionComboBox<SiteArticleVMQueryView> Article { get; set; } 
        public IRPSCollectionComboBox<SiteArticleVMQueryView> Site { get; set; } 
        public SiteArticleQueryCollectionEditor<SiteArticleVMQueryView,SiteArticleVMEntityView> SiteArticleQuery { get; set; } 
        public SiteArticle Screen { get; set; }
        public SiteArticleVMQueryView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class SiteArticleQueryCollectionEditor<SiteArticleVMQueryView,SiteArticleVMEntityView>:RPSCollectionEditor<SiteArticleVMQueryView,SiteArticleVMEntityView> where SiteArticleVMQueryView : class, IView where SiteArticleVMEntityView : class, IView
    {
        public  SiteArticleQueryGridView<SiteArticleVMQueryView,SiteArticleVMEntityView> GridView {get;set;}
    }
    public partial class SiteArticleQueryGridView <SiteArticleVMQueryView,SiteArticleVMEntityView> :  RPSGridView<SiteArticleVMQueryView,SiteArticleVMEntityView> where SiteArticleVMQueryView : class, IView where SiteArticleVMEntityView : class, IView
    {
        public SiteArticleQueryGridView(SiteArticleVMQueryView currentView,SiteArticleVMEntityView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            SiteArticle_StockMin = RPSControlFactory.CreateRPSGridFormattedTextBox<SiteArticleVMQueryView>("","#ed84ba58-d5e7-4ee9-b27b-a2fd771605cb .ag-row[role='row']@ROWINDEX [col-id='cSiteArticle_StockMin']","",false, this.CurrentView);
 
            SiteArticle_PointOrder = RPSControlFactory.CreateRPSGridFormattedTextBox<SiteArticleVMQueryView>("","#ed84ba58-d5e7-4ee9-b27b-a2fd771605cb .ag-row[role='row']@ROWINDEX [col-id='cSiteArticle_PointOrder']","",false, this.CurrentView);
 
            SiteArticle_PurchasePrice = RPSControlFactory.CreateRPSGridFormattedTextBox<SiteArticleVMQueryView>("","#ed84ba58-d5e7-4ee9-b27b-a2fd771605cb .ag-row[role='row']@ROWINDEX [col-id='cSiteArticle_PurchasePrice']","",false, this.CurrentView);
 
            SiteArticle_AveragePrice = RPSControlFactory.CreateRPSGridFormattedTextBox<SiteArticleVMQueryView>("","#ed84ba58-d5e7-4ee9-b27b-a2fd771605cb .ag-row[role='row']@ROWINDEX [col-id='cSiteArticle_AveragePrice']","",false, this.CurrentView);
 
            SiteArticle_ManufacturePrice = RPSControlFactory.CreateRPSGridFormattedTextBox<SiteArticleVMQueryView>("","#ed84ba58-d5e7-4ee9-b27b-a2fd771605cb .ag-row[role='row']@ROWINDEX [col-id='cSiteArticle_ManufacturePrice']","",false, this.CurrentView);
 
            SiteArticle_StandardPrice = RPSControlFactory.CreateRPSGridFormattedTextBox<SiteArticleVMQueryView>("","#ed84ba58-d5e7-4ee9-b27b-a2fd771605cb .ag-row[role='row']@ROWINDEX [col-id='cSiteArticle_StandardPrice']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<SiteArticleVMQueryView> SiteArticle_StockMin { get; set; } 
        public IRPSGridTextBox<SiteArticleVMQueryView> SiteArticle_PointOrder { get; set; } 
        public IRPSGridTextBox<SiteArticleVMQueryView> SiteArticle_PurchasePrice { get; set; } 
        public IRPSGridTextBox<SiteArticleVMQueryView> SiteArticle_AveragePrice { get; set; } 
        public IRPSGridTextBox<SiteArticleVMQueryView> SiteArticle_ManufacturePrice { get; set; } 
        public IRPSGridTextBox<SiteArticleVMQueryView> SiteArticle_StandardPrice { get; set; } 
                     
    }
 
    }
  
            
    public partial class SiteArticleVMEntityView : View
    {
        public SiteArticleVMEntityView(SiteArticle screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            SaveButton = RPSControlFactory.RPSSaveButton<SiteArticleVMEntityView>( this);
 
            DeleteButton = RPSControlFactory.RPSDeleteButton<SiteArticleVMEntityView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<SiteArticleVMEntityView,SiteArticleVMQueryView>( this,Screen.SiteArticleVMQueryView);
 
            BackButton = RPSControlFactory.RPSBackButton<SiteArticleVMEntityView,SiteArticleVMQueryView>( this,Screen.SiteArticleVMQueryView);
 
            IDArticle = RPSControlFactory.CreateRPSComboBox<SiteArticleVMEntityView>("fee8774b-ec9d-4330-86da-9187a2b8b549","","",true, this);
 
            IDSite = RPSControlFactory.CreateRPSComboBox<SiteArticleVMEntityView>("061c3a9e-e059-4e51-a07c-05e5d60004e6","","",true, this);
 
            StockMin = RPSControlFactory.CreateRPSFormattedTextBox<SiteArticleVMEntityView>("cdba6a08-5c9b-46aa-bc67-08f981f7752a","","",true, this);
 
            PointOrder = RPSControlFactory.CreateRPSFormattedTextBox<SiteArticleVMEntityView>("ba589c90-a6fc-4891-aaca-98c51ebc7c7c","","",true, this);
 
            ConsumePrevision = RPSControlFactory.CreateRPSFormattedTextBox<SiteArticleVMEntityView>("860e814e-90c5-497c-ba36-eb73e36081a9","","",true, this);
 
            RotationIndex = RPSControlFactory.CreateRPSFormattedTextBox<SiteArticleVMEntityView>("0b1c969c-68e1-475b-a292-543138d7b8ae","","",true, this);
 
            ArticleType = RPSControlFactory.CreateRPSEnumComboBox<SiteArticleVMEntityView>("27a72dbe-ab5e-4620-a826-024e5632e1d7","","",true, this);
 
            PurchasePrice = RPSControlFactory.CreateRPSFormattedTextBox<SiteArticleVMEntityView>("1cc8b965-d21f-47c2-94c9-408c55e4c552","","",true, this);
 
            PurchaseDate = RPSControlFactory.CreateRPSTextBox<SiteArticleVMEntityView>("07390d37-554a-4f05-8e97-2ef6bd16ccee","","",false, this);
 
            AveragePrice = RPSControlFactory.CreateRPSFormattedTextBox<SiteArticleVMEntityView>("5131947a-38c3-4a84-83e1-974a7c79eed0","","",true, this);
 
            ManufacturePrice = RPSControlFactory.CreateRPSFormattedTextBox<SiteArticleVMEntityView>("8334a979-b412-4879-ab17-6dc5f38cbf77","","",true, this);
 
            ManufactureDate = RPSControlFactory.CreateRPSTextBox<SiteArticleVMEntityView>("51a0318c-1c6f-4361-8a82-cb9ae67a69ce","","",false, this);
 
            StandardPrice = RPSControlFactory.CreateRPSFormattedTextBox<SiteArticleVMEntityView>("43124a54-6e75-4b29-8f20-073dd628424e","","",true, this);
 
            UpdateWarehouseArticleNavigationCommandButton = RPSControlFactory.CreateRPSButtonToView<SiteArticleVMEntityView,UpdateWarehouseArticleDialogView>("429775c4-90b1-48ab-89a8-98e2a67f40de","","", this,Screen.UpdateWarehouseArticleDialogView);
 

        }
        public IRPSSaveButton<SiteArticleVMEntityView> SaveButton { get; set; } 
        public IRPSButton<SiteArticleVMEntityView> DeleteButton { get; set; } 
        public IRPSButton<SiteArticleVMEntityView,SiteArticleVMQueryView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<SiteArticleVMEntityView,SiteArticleVMQueryView> BackButton { get; set; } 
        public IRPSComboBox<SiteArticleVMEntityView> IDArticle { get; set; } 
        public IRPSComboBox<SiteArticleVMEntityView> IDSite { get; set; } 
        public IRPSTextBox<SiteArticleVMEntityView> StockMin { get; set; } 
        public IRPSTextBox<SiteArticleVMEntityView> PointOrder { get; set; } 
        public IRPSTextBox<SiteArticleVMEntityView> ConsumePrevision { get; set; } 
        public IRPSTextBox<SiteArticleVMEntityView> RotationIndex { get; set; } 
        public IRPSComboBox<SiteArticleVMEntityView> ArticleType { get; set; } 
        public IRPSTextBox<SiteArticleVMEntityView> PurchasePrice { get; set; } 
        public IRPSTextBox<SiteArticleVMEntityView> PurchaseDate { get; set; } 
        public IRPSTextBox<SiteArticleVMEntityView> AveragePrice { get; set; } 
        public IRPSTextBox<SiteArticleVMEntityView> ManufacturePrice { get; set; } 
        public IRPSTextBox<SiteArticleVMEntityView> ManufactureDate { get; set; } 
        public IRPSTextBox<SiteArticleVMEntityView> StandardPrice { get; set; } 
        public IRPSButton<SiteArticleVMEntityView,UpdateWarehouseArticleDialogView> UpdateWarehouseArticleNavigationCommandButton { get; set; } 
        public SiteArticle Screen { get; set; }
        public SiteArticleVMEntityView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class UpdateWarehouseArticleDialogView : View
    {
        public UpdateWarehouseArticleDialogView(SiteArticle screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            UIStocMin = RPSControlFactory.CreateRPSCheckBox<UpdateWarehouseArticleDialogView>("2bc75c7c-69da-4611-81bd-285ce35a450b","","",false, this);
 
            UIConsumePrevision = RPSControlFactory.CreateRPSCheckBox<UpdateWarehouseArticleDialogView>("0cd1a10a-c693-482d-8236-cfb9335357b2","","",false, this);
 
            UIOrderPoint = RPSControlFactory.CreateRPSCheckBox<UpdateWarehouseArticleDialogView>("96b719cc-d902-4b4f-8704-cd505ea0f697","","",false, this);
 
            UIRotationIndex = RPSControlFactory.CreateRPSCheckBox<UpdateWarehouseArticleDialogView>("8f23f0c0-8838-45f8-8bcf-55ef508d3116","","",false, this);
 

        }
        public IRPSCheckbox<UpdateWarehouseArticleDialogView> UIStocMin { get; set; } 
        public IRPSCheckbox<UpdateWarehouseArticleDialogView> UIConsumePrevision { get; set; } 
        public IRPSCheckbox<UpdateWarehouseArticleDialogView> UIOrderPoint { get; set; } 
        public IRPSCheckbox<UpdateWarehouseArticleDialogView> UIRotationIndex { get; set; } 
        public SiteArticle Screen { get; set; }
        public UpdateWarehouseArticleDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}