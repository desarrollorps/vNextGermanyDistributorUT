    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.Warehouse.ArticlesLabelsMaintenance
{
    //RPS VERSION 1.0.0.0
    public partial class ArticlesLabelsMaintenance:Screen
    {
        public ArticlesLabelsMaintenance():base()
        {
            this.URL = "warehouse.articleslabelsmaintenance";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            ArticleVMCollectionView  = new ArticleVMCollectionView(this); 
            ArticleFeaturesComparerDialogView  = new ArticleFeaturesComparerDialogView(this); 
            ArticleVMCollectionView.InitializeControls(); 
            ArticleFeaturesComparerDialogView.InitializeControls(); 
           
        }
      
            public ArticleVMCollectionView ArticleVMCollectionView {get; set; } 
            public ArticleFeaturesComparerDialogView ArticleFeaturesComparerDialogView {get; set; } 
    }
            
    public partial class ArticleVMCollectionView : View
    {
        public ArticleVMCollectionView(ArticlesLabelsMaintenance screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            ProductLine = RPSControlFactory.CreateRPSComboBox<ArticleVMCollectionView>("5a2bb206-0a33-43ba-8339-4c7bd16de00a","","",false, this);
 
            ProductFamily = RPSControlFactory.CreateRPSComboBox<ArticleVMCollectionView>("e6034289-d4f4-40a6-aa05-c2020219e6ae","","",false, this);
 
            ProductSubFamily = RPSControlFactory.CreateRPSComboBox<ArticleVMCollectionView>("d1238097-099f-4a21-8720-26f83b1e1754","","",false, this);
 
            IDArticleLabel = RPSControlFactory.CreateRPSComboBox<ArticleVMCollectionView>("2db0848c-b938-403b-9c38-0545e0850c09","","",false, this);
 
            IDArticleLabelGroup = RPSControlFactory.CreateRPSComboBox<ArticleVMCollectionView>("7e05f4d8-fb67-43b4-909b-dbd3357cffcb","","",false, this);
 
            AddArticleLabelFilter = RPSControlFactory.CreateRPSButton<ArticleVMCollectionView>( "1a7f84ac-75fa-4f75-b411-ccd31ff719b0","","",this);
 
            PreviousCommand = RPSControlFactory.CreateRPSButton<ArticleVMCollectionView>( "0bedc9ff-4f63-49bf-8812-1b23e72eec2f","","",this);
 
            UIOptPageSize = RPSControlFactory.CreateRPSEnumComboBox<ArticleVMCollectionView>("a534114c-d135-4743-b47e-c777b34d8d1b","","",false, this);
 
            NextCommand = RPSControlFactory.CreateRPSButton<ArticleVMCollectionView>( "b6080639-3401-4978-9956-1b2da1a3bfbf","","",this);
 
            IDArticleLabel1 = RPSControlFactory.CreateRPSComboBox<ArticleVMCollectionView>("72f7781e-1ce9-4423-88b2-dabc18b30db0","","",true, this);
 
            ValueString = RPSControlFactory.CreateRPSTextBox<ArticleVMCollectionView>("b9d39f6a-2e22-49e2-8cf1-7389faea1a87","","",false, this);
 
            ValueDate = RPSControlFactory.CreateRPSTextBox<ArticleVMCollectionView>("bfcd17dc-aa3d-420f-b95f-21979b6e4753","","",false, this);
 
            ValueDecimal = RPSControlFactory.CreateRPSFormattedTextBox<ArticleVMCollectionView>("487d0992-e5c5-4e79-8ed5-99f147b4b4d5","","",false, this);
 
            ValueInteger = RPSControlFactory.CreateRPSFormattedTextBox<ArticleVMCollectionView>("4c37fdf9-2fe9-4ee6-beb3-de0d1c019e19","","",true, this);
 
            VariableTableValue = RPSControlFactory.CreateRPSEnumComboBox<ArticleVMCollectionView>("f57fa5d0-1c38-496c-a044-0c3016281ca6","","",false, this);
 
            ArticleFeaturesComparerNavigationCommandButton = RPSControlFactory.CreateRPSButtonToView<ArticleVMCollectionView,ArticleFeaturesComparerDialogView>("dd7a5256-ae58-4262-b02e-9292f7cc8fee","","", this,Screen.ArticleFeaturesComparerDialogView);
 
            CollectionInit params_ArticlesLabelsMaintenance = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = ""};
            ArticlesLabelsMaintenance = RPSControlFactory.RPSCreateCollection<ArticleVMCollectionView,ArticleFeaturesComparerDialogView>( params_ArticlesLabelsMaintenance,this,Screen.ArticleFeaturesComparerDialogView);
 
            CollectionInit params_ArticlesFeatures = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="fb5323ef-7861-4d2e-b9ea-399756ee2c6e",CSSSelectorGrid="",XPathGrid=""};
            ArticlesFeatures = RPSControlFactory.RPSCreateCollectionWithGrid<ArticlesFeaturesCollectionEditor<ArticleVMCollectionView,ArticleFeaturesComparerDialogView>,ArticleVMCollectionView,ArticleFeaturesComparerDialogView>( params_ArticlesFeatures,this,Screen.ArticleFeaturesComparerDialogView);
 

        }
        public IRPSComboBox<ArticleVMCollectionView> ProductLine { get; set; } 
        public IRPSComboBox<ArticleVMCollectionView> ProductFamily { get; set; } 
        public IRPSComboBox<ArticleVMCollectionView> ProductSubFamily { get; set; } 
        public IRPSComboBox<ArticleVMCollectionView> IDArticleLabel { get; set; } 
        public IRPSComboBox<ArticleVMCollectionView> IDArticleLabelGroup { get; set; } 
        public IRPSButton<ArticleVMCollectionView> AddArticleLabelFilter { get; set; } 
        public IRPSButton<ArticleVMCollectionView> PreviousCommand { get; set; } 
        public IRPSComboBox<ArticleVMCollectionView> UIOptPageSize { get; set; } 
        public IRPSButton<ArticleVMCollectionView> NextCommand { get; set; } 
        public IRPSComboBox<ArticleVMCollectionView> IDArticleLabel1 { get; set; } 
        public IRPSTextBox<ArticleVMCollectionView> ValueString { get; set; } 
        public IRPSTextBox<ArticleVMCollectionView> ValueDate { get; set; } 
        public IRPSTextBox<ArticleVMCollectionView> ValueDecimal { get; set; } 
        public IRPSTextBox<ArticleVMCollectionView> ValueInteger { get; set; } 
        public IRPSComboBox<ArticleVMCollectionView> VariableTableValue { get; set; } 
        public IRPSButton<ArticleVMCollectionView,ArticleFeaturesComparerDialogView> ArticleFeaturesComparerNavigationCommandButton { get; set; } 
        public IRPSCollectionEditor<ArticleVMCollectionView,ArticleFeaturesComparerDialogView> ArticlesLabelsMaintenance { get; set; } 
        public ArticlesFeaturesCollectionEditor<ArticleVMCollectionView,ArticleFeaturesComparerDialogView> ArticlesFeatures { get; set; } 
        public ArticlesLabelsMaintenance Screen { get; set; }
        public ArticleVMCollectionView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class ArticlesFeaturesCollectionEditor<ArticleVMCollectionView,ArticleFeaturesComparerDialogView>:RPSCollectionEditor<ArticleVMCollectionView,ArticleFeaturesComparerDialogView> where ArticleVMCollectionView : class, IView where ArticleFeaturesComparerDialogView : class, IView
    {
        public  ArticlesFeaturesGridView<ArticleVMCollectionView,ArticleFeaturesComparerDialogView> GridView {get;set;}
    }
    public partial class ArticlesFeaturesGridView <ArticleVMCollectionView,ArticleFeaturesComparerDialogView> :  RPSGridView<ArticleVMCollectionView,ArticleFeaturesComparerDialogView> where ArticleVMCollectionView : class, IView where ArticleFeaturesComparerDialogView : class, IView
    {
        public ArticlesFeaturesGridView(ArticleVMCollectionView currentView,ArticleFeaturesComparerDialogView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            IDArticleLabel = RPSControlFactory.CreateRPSGridComboBox<ArticleVMCollectionView>("","#fb5323ef-7861-4d2e-b9ea-399756ee2c6e .ag-row[role='row']@ROWINDEX [col-id='cIDArticleLabel']","",true, this.CurrentView);
 
            Value = RPSControlFactory.CreateRPSGridTextBox<ArticleVMCollectionView>("","#fb5323ef-7861-4d2e-b9ea-399756ee2c6e .ag-row[role='row']@ROWINDEX [col-id='cValue']","",false, this.CurrentView);
 

        }
        public IRPSGridComboBox<ArticleVMCollectionView> IDArticleLabel { get; set; } 
        public IRPSGridTextBox<ArticleVMCollectionView> Value { get; set; } 
                     
    }
 
    }
  
            
    public partial class ArticleFeaturesComparerDialogView : View
    {
        public ArticleFeaturesComparerDialogView(ArticlesLabelsMaintenance screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            CollectionInit params_ArticlesLabelsComparer = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="78b902f7-1a4e-48ff-95da-4a7d71328978",CSSSelectorGrid="",XPathGrid=""};
            ArticlesLabelsComparer = RPSControlFactory.RPSCreateCollectionWithGrid<ArticlesLabelsComparerCollectionEditor<ArticleFeaturesComparerDialogView>,ArticleFeaturesComparerDialogView>( params_ArticlesLabelsComparer,this);
 

        }
        public ArticlesLabelsComparerCollectionEditor<ArticleFeaturesComparerDialogView> ArticlesLabelsComparer { get; set; } 
        public ArticlesLabelsMaintenance Screen { get; set; }
        public ArticleFeaturesComparerDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class ArticlesLabelsComparerCollectionEditor<ArticleFeaturesComparerDialogView>:RPSCollectionEditor<ArticleFeaturesComparerDialogView> where ArticleFeaturesComparerDialogView : class, IView
    {
        public  ArticlesLabelsComparerGridView<ArticleFeaturesComparerDialogView> GridView {get;set;}
    }
    public partial class ArticlesLabelsComparerGridView <ArticleFeaturesComparerDialogView> :  RPSGridView<ArticleFeaturesComparerDialogView> where ArticleFeaturesComparerDialogView : class, IView
    {
        public ArticlesLabelsComparerGridView(ArticleFeaturesComparerDialogView currentView)
        {
            this.WebDriver = currentView.WebDriver;          
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {

        }
                     
    }
 
    }
  
    

}