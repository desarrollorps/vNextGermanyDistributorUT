    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.Project.ArticleResource
{
    //RPS VERSION 1.0.0.0
    public partial class ArticleResource:Screen
    {
        public ArticleResource():base()
        {
            this.URL = "project.articleresource";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            ArticleResourceVMCollectionView  = new ArticleResourceVMCollectionView(this); 
            ArticleResourceVMEntityView  = new ArticleResourceVMEntityView(this); 
            ArticleResourceVMCollectionView.InitializeControls(); 
            ArticleResourceVMEntityView.InitializeControls(); 
           
        }
      
            public ArticleResourceVMCollectionView ArticleResourceVMCollectionView {get; set; } 
            public ArticleResourceVMEntityView ArticleResourceVMEntityView {get; set; } 
    }
            
    public partial class ArticleResourceVMCollectionView : View
    {
        public ArticleResourceVMCollectionView(ArticleResource screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            Qualify = RPSControlFactory.CreateRPSCheckBox<ArticleResourceVMCollectionView>("498395e0-3699-44d3-b1ce-838d3dfae921","","",false, this);
 
            Employee = RPSControlFactory.CreateRPSCheckBox<ArticleResourceVMCollectionView>("a8f9a80a-5438-444c-9cd2-56b1ba4345a8","","",false, this);
 
            Machine = RPSControlFactory.CreateRPSCheckBox<ArticleResourceVMCollectionView>("4fef4368-42c9-4278-8e47-81b14ce410df","","",false, this);
 
            MachineGroup = RPSControlFactory.CreateRPSCheckBox<ArticleResourceVMCollectionView>("43e9ced4-ed3e-4e12-88b0-d93424c9c76e","","",false, this);
 
            Tool = RPSControlFactory.CreateRPSCheckBox<ArticleResourceVMCollectionView>("45f4bfed-cec3-4c7f-83f3-1b5b512fda48","","",false, this);
 
            OtherCost = RPSControlFactory.CreateRPSCheckBox<ArticleResourceVMCollectionView>("bca8112c-0b99-443b-bf0d-dbef423000e9","","",false, this);
 
            CollectionInit params_ArticleResourceQueryEntity = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="8fb6ed44-90cd-40a9-86ef-c5902420ffba",CSSSelectorGrid="",XPathGrid=""};
            ArticleResourceQueryEntity = RPSControlFactory.RPSCreateCollectionWithGrid<ArticleResourceQueryEntityCollectionEditor<ArticleResourceVMCollectionView,ArticleResourceVMEntityView>,ArticleResourceVMCollectionView,ArticleResourceVMEntityView>( params_ArticleResourceQueryEntity,this,Screen.ArticleResourceVMEntityView);
 

        }
        public IRPSCheckbox<ArticleResourceVMCollectionView> Qualify { get; set; } 
        public IRPSCheckbox<ArticleResourceVMCollectionView> Employee { get; set; } 
        public IRPSCheckbox<ArticleResourceVMCollectionView> Machine { get; set; } 
        public IRPSCheckbox<ArticleResourceVMCollectionView> MachineGroup { get; set; } 
        public IRPSCheckbox<ArticleResourceVMCollectionView> Tool { get; set; } 
        public IRPSCheckbox<ArticleResourceVMCollectionView> OtherCost { get; set; } 
        public ArticleResourceQueryEntityCollectionEditor<ArticleResourceVMCollectionView,ArticleResourceVMEntityView> ArticleResourceQueryEntity { get; set; } 
        public ArticleResource Screen { get; set; }
        public ArticleResourceVMCollectionView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class ArticleResourceQueryEntityCollectionEditor<ArticleResourceVMCollectionView,ArticleResourceVMEntityView>:RPSCollectionEditor<ArticleResourceVMCollectionView,ArticleResourceVMEntityView> where ArticleResourceVMCollectionView : class, IView where ArticleResourceVMEntityView : class, IView
    {
        public  ArticleResourceQueryEntityGridView<ArticleResourceVMCollectionView,ArticleResourceVMEntityView> GridView {get;set;}
    }
    public partial class ArticleResourceQueryEntityGridView <ArticleResourceVMCollectionView,ArticleResourceVMEntityView> :  RPSGridView<ArticleResourceVMCollectionView,ArticleResourceVMEntityView> where ArticleResourceVMCollectionView : class, IView where ArticleResourceVMEntityView : class, IView
    {
        public ArticleResourceQueryEntityGridView(ArticleResourceVMCollectionView currentView,ArticleResourceVMEntityView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            TypeArticleResource = RPSControlFactory.CreateRPSGridEnumComboBox<ArticleResourceVMCollectionView>("","#8fb6ed44-90cd-40a9-86ef-c5902420ffba .ag-row[role='row']@ROWINDEX [col-id='cTypeArticleResource']","",true, this.CurrentView);
 
            IDResourceSelector = RPSControlFactory.CreateRPSGridComboBox<ArticleResourceVMCollectionView>("","#8fb6ed44-90cd-40a9-86ef-c5902420ffba .ag-row[role='row']@ROWINDEX [col-id='cIDResourceSelector']","",false, this.CurrentView);
 
            Article = RPSControlFactory.CreateRPSGridComboBox<ArticleResourceVMCollectionView>("","#8fb6ed44-90cd-40a9-86ef-c5902420ffba .ag-row[role='row']@ROWINDEX [col-id='cIDArticle']","",false, this.CurrentView);
 

        }
        public IRPSGridComboBox<ArticleResourceVMCollectionView> TypeArticleResource { get; set; } 
        public IRPSGridComboBox<ArticleResourceVMCollectionView> IDResourceSelector { get; set; } 
        public IRPSGridComboBox<ArticleResourceVMCollectionView> Article { get; set; } 
                     
    }
 
    }
  
            
    public partial class ArticleResourceVMEntityView : View
    {
        public ArticleResourceVMEntityView(ArticleResource screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            DeleteButton = RPSControlFactory.RPSDeleteButton<ArticleResourceVMEntityView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<ArticleResourceVMEntityView,ArticleResourceVMCollectionView>( this,Screen.ArticleResourceVMCollectionView);
 
            BackButton = RPSControlFactory.RPSBackButton<ArticleResourceVMEntityView,ArticleResourceVMCollectionView>( this,Screen.ArticleResourceVMCollectionView);
 
            AcceptButton = RPSControlFactory.RPSAcceptButton<ArticleResourceVMEntityView,ArticleResourceVMCollectionView>( this,Screen.ArticleResourceVMCollectionView);
 
            TypeArticleResource = RPSControlFactory.CreateRPSEnumComboBox<ArticleResourceVMEntityView>("7563aa47-dfaf-4eba-83fe-5d49d1d3dd0c","","",true, this);
 
            IDResourceSelector = RPSControlFactory.CreateRPSComboBox<ArticleResourceVMEntityView>("371e3a11-6232-4062-984e-631d9e94fe37","","",false, this);
 
            IDArticle = RPSControlFactory.CreateRPSComboBox<ArticleResourceVMEntityView>("33cfe3b5-cb0b-4d01-b9b7-aa2ccad6dd69","","",false, this);
 

        }
        public IRPSButton<ArticleResourceVMEntityView> DeleteButton { get; set; } 
        public IRPSButton<ArticleResourceVMEntityView,ArticleResourceVMCollectionView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<ArticleResourceVMEntityView,ArticleResourceVMCollectionView> BackButton { get; set; } 
        public IRPSAcceptButton<ArticleResourceVMEntityView,ArticleResourceVMCollectionView> AcceptButton { get; set; } 
        public IRPSComboBox<ArticleResourceVMEntityView> TypeArticleResource { get; set; } 
        public IRPSComboBox<ArticleResourceVMEntityView> IDResourceSelector { get; set; } 
        public IRPSComboBox<ArticleResourceVMEntityView> IDArticle { get; set; } 
        public ArticleResource Screen { get; set; }
        public ArticleResourceVMEntityView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}