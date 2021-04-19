    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.General.Category
{
    //RPS VERSION 1.0.0.0
    public partial class Category:Screen
    {
        public Category():base()
        {
            this.URL = "general.category";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            CategoryCollectionView  = new CategoryCollectionView(this); 
            CategoryEntityView  = new CategoryEntityView(this); 
            CategoryCollectionView.InitializeControls(); 
            CategoryEntityView.InitializeControls(); 
           
        }
      
            public CategoryCollectionView CategoryCollectionView {get; set; } 
            public CategoryEntityView CategoryEntityView {get; set; } 
    }
            
    public partial class CategoryCollectionView : View
    {
        public CategoryCollectionView(Category screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            NewButton = RPSControlFactory.RPSNewButton<CategoryCollectionView,CategoryEntityView>( this,Screen.CategoryEntityView);
 
            CollectionInit params_MainConsult = new CollectionInit(){IDDescriptor = "4ba45967-0fbd-4c81-ab48-6d51e1a4938a",CSSSelectorDescriptor = "",XPathDescriptor = ""};
            MainConsult = RPSControlFactory.RPSCreateCollection<CategoryCollectionView,CategoryEntityView>( params_MainConsult,this,Screen.CategoryEntityView);
 

        }
        public IRPSButton<CategoryCollectionView,CategoryEntityView> NewButton { get; set; } 
        public IRPSCollectionEditor<CategoryCollectionView,CategoryEntityView> MainConsult { get; set; } 
        public Category Screen { get; set; }
        public CategoryCollectionView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class CategoryEntityView : View
    {
        public CategoryEntityView(Category screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            SaveButton = RPSControlFactory.RPSSaveButton<CategoryEntityView>( this);
 
            DeleteButton = RPSControlFactory.RPSDeleteButton<CategoryEntityView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<CategoryEntityView,CategoryCollectionView>( this,Screen.CategoryCollectionView);
 
            BackButton = RPSControlFactory.RPSBackButton<CategoryEntityView,CategoryCollectionView>( this,Screen.CategoryCollectionView);
 
            CodCategory = RPSControlFactory.CreateRPSTextBox<CategoryEntityView>("0c5f8780-71d3-431f-af3b-4aa7482223af","","",true, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<CategoryEntityView>("0f00a49f-6101-4d79-a5d5-a97b73292dde","","",false, this);
 

        }
        public IRPSSaveButton<CategoryEntityView> SaveButton { get; set; } 
        public IRPSButton<CategoryEntityView> DeleteButton { get; set; } 
        public IRPSButton<CategoryEntityView,CategoryCollectionView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<CategoryEntityView,CategoryCollectionView> BackButton { get; set; } 
        public IRPSTextBox<CategoryEntityView> CodCategory { get; set; } 
        public IRPSTextBox<CategoryEntityView> Description { get; set; } 
        public Category Screen { get; set; }
        public CategoryEntityView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}