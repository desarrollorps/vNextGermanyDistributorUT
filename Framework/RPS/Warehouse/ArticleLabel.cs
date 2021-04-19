    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.Warehouse.ArticleLabel
{
    //RPS VERSION 1.0.0.0
    public partial class ArticleLabel:Screen
    {
        public ArticleLabel():base()
        {
            this.URL = "warehouse.articlelabel";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            ArticleLabelCollectionView  = new ArticleLabelCollectionView(this); 
            ArticleLabelEntityView  = new ArticleLabelEntityView(this); 
            ArticleLabelByLangView  = new ArticleLabelByLangView(this); 
            ArticleLabelGroupLabelView  = new ArticleLabelGroupLabelView(this); 
            ArticleLabelCollectionView.InitializeControls(); 
            ArticleLabelEntityView.InitializeControls(); 
            ArticleLabelByLangView.InitializeControls(); 
            ArticleLabelGroupLabelView.InitializeControls(); 
           
        }
      
            public ArticleLabelCollectionView ArticleLabelCollectionView {get; set; } 
            public ArticleLabelEntityView ArticleLabelEntityView {get; set; } 
            public ArticleLabelByLangView ArticleLabelByLangView {get; set; } 
            public ArticleLabelGroupLabelView ArticleLabelGroupLabelView {get; set; } 
    }
            
    public partial class ArticleLabelCollectionView : View
    {
        public ArticleLabelCollectionView(ArticleLabel screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            NewButton = RPSControlFactory.RPSNewButton<ArticleLabelCollectionView,ArticleLabelEntityView>( this,Screen.ArticleLabelEntityView);
 
            CollectionInit params_MainConsult = new CollectionInit(){IDDescriptor = "6caacd95-7e90-43e4-9377-0186f9d17499",CSSSelectorDescriptor = "",XPathDescriptor = ""};
            MainConsult = RPSControlFactory.RPSCreateCollection<ArticleLabelCollectionView,ArticleLabelEntityView>( params_MainConsult,this,Screen.ArticleLabelEntityView);
 

        }
        public IRPSButton<ArticleLabelCollectionView,ArticleLabelEntityView> NewButton { get; set; } 
        public IRPSCollectionEditor<ArticleLabelCollectionView,ArticleLabelEntityView> MainConsult { get; set; } 
        public ArticleLabel Screen { get; set; }
        public ArticleLabelCollectionView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class ArticleLabelEntityView : View
    {
        public ArticleLabelEntityView(ArticleLabel screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            SaveButton = RPSControlFactory.RPSSaveButton<ArticleLabelEntityView>( this);
 
            DeleteButton = RPSControlFactory.RPSDeleteButton<ArticleLabelEntityView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<ArticleLabelEntityView,ArticleLabelCollectionView>( this,Screen.ArticleLabelCollectionView);
 
            BackButton = RPSControlFactory.RPSBackButton<ArticleLabelEntityView,ArticleLabelCollectionView>( this,Screen.ArticleLabelCollectionView);
 
            CodArticleLabel = RPSControlFactory.CreateRPSTextBox<ArticleLabelEntityView>("c9d17832-b9c5-4c69-b09c-02f3ded48f83","","",true, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<ArticleLabelEntityView>("41127022-bc27-46ee-9273-e0b5d0a45036","","",false, this);
 
            DataType = RPSControlFactory.CreateRPSEnumComboBox<ArticleLabelEntityView>("c3635d0d-9715-4834-9c4d-440f063b209e","","",true, this);
 
            bCostCalculation = RPSControlFactory.CreateRPSCheckBox<ArticleLabelEntityView>("0acb033f-be3f-4ff7-b064-082e9ef1c4a2","","",true, this);
 
            MinInt = RPSControlFactory.CreateRPSFormattedTextBox<ArticleLabelEntityView>("d4950cb4-09b4-479c-9ec0-386f787f7e4d","","",false, this);
 
            MaxInt = RPSControlFactory.CreateRPSFormattedTextBox<ArticleLabelEntityView>("34121998-963e-42d4-b1a6-35878ca3a990","","",false, this);
 
            DefaultInt = RPSControlFactory.CreateRPSFormattedTextBox<ArticleLabelEntityView>("e3b435ce-fab2-4998-a395-73a1d97bb989","","",false, this);
 
            MinDec = RPSControlFactory.CreateRPSFormattedTextBox<ArticleLabelEntityView>("c302f614-474e-4a08-99bf-a3b7934413b1","","",false, this);
 
            MaxDec = RPSControlFactory.CreateRPSFormattedTextBox<ArticleLabelEntityView>("e3bffb5d-a86e-4643-a183-fd82f2f95402","","",false, this);
 
            DefaultDec = RPSControlFactory.CreateRPSFormattedTextBox<ArticleLabelEntityView>("e0cf5c02-cd5b-4492-89b3-9eeec3ae1269","","",false, this);
 
            MinString = RPSControlFactory.CreateRPSTextBox<ArticleLabelEntityView>("b16916a0-2eb9-448b-9a3b-b7cc72c2c04c","","",false, this);
 
            MaxString = RPSControlFactory.CreateRPSTextBox<ArticleLabelEntityView>("6ba61f23-dbb8-4ad3-b4d8-51658742856e","","",false, this);
 
            DefaultString = RPSControlFactory.CreateRPSTextBox<ArticleLabelEntityView>("b8c966b5-6ee6-4000-83a7-01c96ebe9f72","","",false, this);
 
            MinDate = RPSControlFactory.CreateRPSTextBox<ArticleLabelEntityView>("4116c044-2cff-48f0-ac06-52975f597e1d","","",false, this);
 
            MaxDate = RPSControlFactory.CreateRPSTextBox<ArticleLabelEntityView>("6e4e2b3f-6650-400f-a121-ed767fa2dd68","","",false, this);
 
            DefaultDate = RPSControlFactory.CreateRPSTextBox<ArticleLabelEntityView>("2dcab9de-19e8-405e-b3f2-ea1048cdaeac","","",false, this);
 
            IDTable = RPSControlFactory.CreateRPSComboBox<ArticleLabelEntityView>("88276d77-8b0b-4cc8-baa7-47a658953f8f","","",false, this);
 
            MatchCodeUsing = RPSControlFactory.CreateRPSCheckBox<ArticleLabelEntityView>("b33ed6af-92b7-40ae-a412-1c94fbc8db36","","",true, this);
 
            CollectionInit params_STKArticleLabelByLangs = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="56a428ad-fc58-4a6f-9e56-ceac2b8adc54",CSSSelectorGrid="",XPathGrid=""};
            STKArticleLabelByLangs = RPSControlFactory.RPSCreateCollectionWithGrid<STKArticleLabelByLangsCollectionEditor<ArticleLabelEntityView,ArticleLabelByLangView>,ArticleLabelEntityView,ArticleLabelByLangView>( params_STKArticleLabelByLangs,this,Screen.ArticleLabelByLangView);
 
            CollectionInit params_ArticleLabelGroupLabels = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="17ab5f1a-7a85-41da-b338-3162b4547fd3",CSSSelectorGrid="",XPathGrid=""};
            ArticleLabelGroupLabels = RPSControlFactory.RPSCreateCollectionWithGrid<ArticleLabelGroupLabelsCollectionEditor<ArticleLabelEntityView,ArticleLabelByLangView>,ArticleLabelEntityView,ArticleLabelByLangView>( params_ArticleLabelGroupLabels,this,Screen.ArticleLabelByLangView);
 

        }
        public IRPSSaveButton<ArticleLabelEntityView> SaveButton { get; set; } 
        public IRPSButton<ArticleLabelEntityView> DeleteButton { get; set; } 
        public IRPSButton<ArticleLabelEntityView,ArticleLabelCollectionView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<ArticleLabelEntityView,ArticleLabelCollectionView> BackButton { get; set; } 
        public IRPSTextBox<ArticleLabelEntityView> CodArticleLabel { get; set; } 
        public IRPSTextBox<ArticleLabelEntityView> Description { get; set; } 
        public IRPSComboBox<ArticleLabelEntityView> DataType { get; set; } 
        public IRPSCheckbox<ArticleLabelEntityView> bCostCalculation { get; set; } 
        public IRPSTextBox<ArticleLabelEntityView> MinInt { get; set; } 
        public IRPSTextBox<ArticleLabelEntityView> MaxInt { get; set; } 
        public IRPSTextBox<ArticleLabelEntityView> DefaultInt { get; set; } 
        public IRPSTextBox<ArticleLabelEntityView> MinDec { get; set; } 
        public IRPSTextBox<ArticleLabelEntityView> MaxDec { get; set; } 
        public IRPSTextBox<ArticleLabelEntityView> DefaultDec { get; set; } 
        public IRPSTextBox<ArticleLabelEntityView> MinString { get; set; } 
        public IRPSTextBox<ArticleLabelEntityView> MaxString { get; set; } 
        public IRPSTextBox<ArticleLabelEntityView> DefaultString { get; set; } 
        public IRPSTextBox<ArticleLabelEntityView> MinDate { get; set; } 
        public IRPSTextBox<ArticleLabelEntityView> MaxDate { get; set; } 
        public IRPSTextBox<ArticleLabelEntityView> DefaultDate { get; set; } 
        public IRPSComboBox<ArticleLabelEntityView> IDTable { get; set; } 
        public IRPSCheckbox<ArticleLabelEntityView> MatchCodeUsing { get; set; } 
        public STKArticleLabelByLangsCollectionEditor<ArticleLabelEntityView,ArticleLabelByLangView> STKArticleLabelByLangs { get; set; } 
        public ArticleLabelGroupLabelsCollectionEditor<ArticleLabelEntityView,ArticleLabelByLangView> ArticleLabelGroupLabels { get; set; } 
        public ArticleLabel Screen { get; set; }
        public ArticleLabelEntityView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class STKArticleLabelByLangsCollectionEditor<ArticleLabelEntityView,ArticleLabelByLangView>:RPSCollectionEditor<ArticleLabelEntityView,ArticleLabelByLangView> where ArticleLabelEntityView : class, IView where ArticleLabelByLangView : class, IView
    {
        public  STKArticleLabelByLangsGridView<ArticleLabelEntityView,ArticleLabelByLangView> GridView {get;set;}
    }
    public partial class STKArticleLabelByLangsGridView <ArticleLabelEntityView,ArticleLabelByLangView> :  RPSGridView<ArticleLabelEntityView,ArticleLabelByLangView> where ArticleLabelEntityView : class, IView where ArticleLabelByLangView : class, IView
    {
        public STKArticleLabelByLangsGridView(ArticleLabelEntityView currentView,ArticleLabelByLangView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            CodLanguage = RPSControlFactory.CreateRPSGridComboBox<ArticleLabelEntityView>("","#56a428ad-fc58-4a6f-9e56-ceac2b8adc54 .ag-row[role='row']@ROWINDEX [col-id='cCodLanguage']","",true, this.CurrentView);
 
            Description = RPSControlFactory.CreateRPSGridTextBox<ArticleLabelEntityView>("","#56a428ad-fc58-4a6f-9e56-ceac2b8adc54 .ag-row[role='row']@ROWINDEX [col-id='cDescription']","",false, this.CurrentView);
 

        }
        public IRPSGridComboBox<ArticleLabelEntityView> CodLanguage { get; set; } 
        public IRPSGridTextBox<ArticleLabelEntityView> Description { get; set; } 
                     
    }
 
        public partial class ArticleLabelGroupLabelsCollectionEditor<ArticleLabelEntityView,ArticleLabelByLangView>:RPSCollectionEditor<ArticleLabelEntityView,ArticleLabelByLangView> where ArticleLabelEntityView : class, IView where ArticleLabelByLangView : class, IView
    {
        public  ArticleLabelGroupLabelsGridView<ArticleLabelEntityView,ArticleLabelByLangView> GridView {get;set;}
    }
    public partial class ArticleLabelGroupLabelsGridView <ArticleLabelEntityView,ArticleLabelByLangView> :  RPSGridView<ArticleLabelEntityView,ArticleLabelByLangView> where ArticleLabelEntityView : class, IView where ArticleLabelByLangView : class, IView
    {
        public ArticleLabelGroupLabelsGridView(ArticleLabelEntityView currentView,ArticleLabelByLangView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            IDArticleLabelGroup = RPSControlFactory.CreateRPSGridComboBox<ArticleLabelEntityView>("","#17ab5f1a-7a85-41da-b338-3162b4547fd3 .ag-row[role='row']@ROWINDEX [col-id='cIDArticleLabelGroup']","",true, this.CurrentView);
 

        }
        public IRPSGridComboBox<ArticleLabelEntityView> IDArticleLabelGroup { get; set; } 
                     
    }
 
    }
  
            
    public partial class ArticleLabelByLangView : View
    {
        public ArticleLabelByLangView(ArticleLabel screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            DeleteButton = RPSControlFactory.RPSDeleteButton<ArticleLabelByLangView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<ArticleLabelByLangView,ArticleLabelEntityView>( this,Screen.ArticleLabelEntityView);
 
            BackButton = RPSControlFactory.RPSBackButton<ArticleLabelByLangView,ArticleLabelEntityView>( this,Screen.ArticleLabelEntityView);
 
            AcceptButton = RPSControlFactory.RPSAcceptButton<ArticleLabelByLangView,ArticleLabelEntityView>( this,Screen.ArticleLabelEntityView);
 
            CodLanguage = RPSControlFactory.CreateRPSComboBox<ArticleLabelByLangView>("2327ea31-be58-468e-b450-f417efae4d91","","",true, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<ArticleLabelByLangView>("35803c50-0fb7-41c0-abdb-845ef5dbfb78","","",false, this);
 

        }
        public IRPSButton<ArticleLabelByLangView> DeleteButton { get; set; } 
        public IRPSButton<ArticleLabelByLangView,ArticleLabelEntityView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<ArticleLabelByLangView,ArticleLabelEntityView> BackButton { get; set; } 
        public IRPSAcceptButton<ArticleLabelByLangView,ArticleLabelEntityView> AcceptButton { get; set; } 
        public IRPSComboBox<ArticleLabelByLangView> CodLanguage { get; set; } 
        public IRPSTextBox<ArticleLabelByLangView> Description { get; set; } 
        public ArticleLabel Screen { get; set; }
        public ArticleLabelByLangView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class ArticleLabelGroupLabelView : View
    {
        public ArticleLabelGroupLabelView(ArticleLabel screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            DeleteButton = RPSControlFactory.RPSDeleteButton<ArticleLabelGroupLabelView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<ArticleLabelGroupLabelView,ArticleLabelEntityView>( this,Screen.ArticleLabelEntityView);
 
            BackButton = RPSControlFactory.RPSBackButton<ArticleLabelGroupLabelView,ArticleLabelEntityView>( this,Screen.ArticleLabelEntityView);
 
            AcceptButton = RPSControlFactory.RPSAcceptButton<ArticleLabelGroupLabelView,ArticleLabelEntityView>( this,Screen.ArticleLabelEntityView);
 
            IDArticleLabel = RPSControlFactory.CreateRPSComboBox<ArticleLabelGroupLabelView>("2ca0f503-c468-44dd-b14e-748019c4e3ae","","",true, this);
 
            IDArticleLabelGroup = RPSControlFactory.CreateRPSComboBox<ArticleLabelGroupLabelView>("2741c7c0-f51c-4284-9402-0e8e4a421413","","",true, this);
 

        }
        public IRPSButton<ArticleLabelGroupLabelView> DeleteButton { get; set; } 
        public IRPSButton<ArticleLabelGroupLabelView,ArticleLabelEntityView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<ArticleLabelGroupLabelView,ArticleLabelEntityView> BackButton { get; set; } 
        public IRPSAcceptButton<ArticleLabelGroupLabelView,ArticleLabelEntityView> AcceptButton { get; set; } 
        public IRPSComboBox<ArticleLabelGroupLabelView> IDArticleLabel { get; set; } 
        public IRPSComboBox<ArticleLabelGroupLabelView> IDArticleLabelGroup { get; set; } 
        public ArticleLabel Screen { get; set; }
        public ArticleLabelGroupLabelView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}