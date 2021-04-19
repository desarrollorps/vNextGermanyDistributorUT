    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.Purchase.SupplierChangeInArticles
{
    //RPS VERSION 1.0.0.0
    public partial class SupplierChangeInArticles:Screen
    {
        public SupplierChangeInArticles():base()
        {
            this.URL = "purchase.supplierchangeinarticles";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            SupplierChangeInArticlesQueryView  = new SupplierChangeInArticlesQueryView(this); 
            SupplierChangeChildDialogView  = new SupplierChangeChildDialogView(this); 
            SupplierChangeInArticlesQueryView.InitializeControls(); 
            SupplierChangeChildDialogView.InitializeControls(); 
           
        }
      
            public SupplierChangeInArticlesQueryView SupplierChangeInArticlesQueryView {get; set; } 
            public SupplierChangeChildDialogView SupplierChangeChildDialogView {get; set; } 
    }
            
    public partial class SupplierChangeInArticlesQueryView : View
    {
        public SupplierChangeInArticlesQueryView(SupplierChangeInArticles screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            Supplier = RPSControlFactory.CreateRPSComboBox<SupplierChangeInArticlesQueryView>("7843b541-7637-4917-865c-d1269642db53","","",false, this);
 
            SupplierChangeChildNavigationCommandButton = RPSControlFactory.CreateRPSButtonToView<SupplierChangeInArticlesQueryView,SupplierChangeChildDialogView>("fc27f9d0-b518-4a0e-aae5-696f7616f6d3","","", this,Screen.SupplierChangeChildDialogView);
 
            CollectionInit params_SupplierChangeInArticleMainQuery = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="be70ce68-6c0f-47f6-af92-9bd033a7f40f",CSSSelectorGrid="",XPathGrid=""};
            SupplierChangeInArticleMainQuery = RPSControlFactory.RPSCreateCollectionWithGrid<SupplierChangeInArticleMainQueryCollectionEditor<SupplierChangeInArticlesQueryView,SupplierChangeChildDialogView>,SupplierChangeInArticlesQueryView,SupplierChangeChildDialogView>( params_SupplierChangeInArticleMainQuery,this,Screen.SupplierChangeChildDialogView);
 

        }
        public IRPSComboBox<SupplierChangeInArticlesQueryView> Supplier { get; set; } 
        public IRPSButton<SupplierChangeInArticlesQueryView,SupplierChangeChildDialogView> SupplierChangeChildNavigationCommandButton { get; set; } 
        public SupplierChangeInArticleMainQueryCollectionEditor<SupplierChangeInArticlesQueryView,SupplierChangeChildDialogView> SupplierChangeInArticleMainQuery { get; set; } 
        public SupplierChangeInArticles Screen { get; set; }
        public SupplierChangeInArticlesQueryView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class SupplierChangeInArticleMainQueryCollectionEditor<SupplierChangeInArticlesQueryView,SupplierChangeChildDialogView>:RPSCollectionEditor<SupplierChangeInArticlesQueryView,SupplierChangeChildDialogView> where SupplierChangeInArticlesQueryView : class, IView where SupplierChangeChildDialogView : class, IView
    {
        public  SupplierChangeInArticleMainQueryGridView<SupplierChangeInArticlesQueryView,SupplierChangeChildDialogView> GridView {get;set;}
    }
    public partial class SupplierChangeInArticleMainQueryGridView <SupplierChangeInArticlesQueryView,SupplierChangeChildDialogView> :  RPSGridView<SupplierChangeInArticlesQueryView,SupplierChangeChildDialogView> where SupplierChangeInArticlesQueryView : class, IView where SupplierChangeChildDialogView : class, IView
    {
        public SupplierChangeInArticleMainQueryGridView(SupplierChangeInArticlesQueryView currentView,SupplierChangeChildDialogView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {

        }
                     
    }
 
    }
  
            
    public partial class SupplierChangeChildDialogView : View
    {
        public SupplierChangeChildDialogView(SupplierChangeInArticles screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            Supplier = RPSControlFactory.CreateRPSComboBox<SupplierChangeChildDialogView>("9938a3d9-401d-44c1-a5d7-ae3faa7a5eca","","",false, this);
 
            Supplier2 = RPSControlFactory.CreateRPSComboBox<SupplierChangeChildDialogView>("5c30fd73-6ec0-48a1-9726-a1f0c0a6d1d4","","",false, this);
 

        }
        public IRPSComboBox<SupplierChangeChildDialogView> Supplier { get; set; } 
        public IRPSComboBox<SupplierChangeChildDialogView> Supplier2 { get; set; } 
        public SupplierChangeInArticles Screen { get; set; }
        public SupplierChangeChildDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}