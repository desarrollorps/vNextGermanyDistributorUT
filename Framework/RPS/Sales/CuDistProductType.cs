    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.Sales.CuDistProductType
{
    //RPS VERSION 1.0.0.0
    public partial class CuDistProductType:Screen
    {
        public CuDistProductType():base()
        {
            this.URL = "sales.cudistproducttype";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            CuDistProductTypeSLCollectionView  = new CuDistProductTypeSLCollectionView(this); 
            CuDistProductTypeSLEntityView  = new CuDistProductTypeSLEntityView(this); 
            CuDistProductTypeSLCollectionView.InitializeControls(); 
            CuDistProductTypeSLEntityView.InitializeControls(); 
           
        }
      
            public CuDistProductTypeSLCollectionView CuDistProductTypeSLCollectionView {get; set; } 
            public CuDistProductTypeSLEntityView CuDistProductTypeSLEntityView {get; set; } 
    }
            
    public partial class CuDistProductTypeSLCollectionView : View
    {
        public CuDistProductTypeSLCollectionView(CuDistProductType screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            NewButton = RPSControlFactory.RPSNewButton<CuDistProductTypeSLCollectionView,CuDistProductTypeSLEntityView>( this,Screen.CuDistProductTypeSLEntityView);
 
            CollectionInit params_MainConsult = new CollectionInit(){IDDescriptor = "8c22e6a9-0fab-4982-b153-87cd47f1957f",CSSSelectorDescriptor = "",XPathDescriptor = ""};
            MainConsult = RPSControlFactory.RPSCreateCollection<CuDistProductTypeSLCollectionView,CuDistProductTypeSLEntityView>( params_MainConsult,this,Screen.CuDistProductTypeSLEntityView);
 

        }
        public IRPSButton<CuDistProductTypeSLCollectionView,CuDistProductTypeSLEntityView> NewButton { get; set; } 
        public IRPSCollectionEditor<CuDistProductTypeSLCollectionView,CuDistProductTypeSLEntityView> MainConsult { get; set; } 
        public CuDistProductType Screen { get; set; }
        public CuDistProductTypeSLCollectionView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class CuDistProductTypeSLEntityView : View
    {
        public CuDistProductTypeSLEntityView(CuDistProductType screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            SaveButton = RPSControlFactory.RPSSaveButton<CuDistProductTypeSLEntityView>( this);
 
            DeleteButton = RPSControlFactory.RPSDeleteButton<CuDistProductTypeSLEntityView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<CuDistProductTypeSLEntityView,CuDistProductTypeSLCollectionView>( this,Screen.CuDistProductTypeSLCollectionView);
 
            BackButton = RPSControlFactory.RPSBackButton<CuDistProductTypeSLEntityView,CuDistProductTypeSLCollectionView>( this,Screen.CuDistProductTypeSLCollectionView);
 
            CodCuDistProductType = RPSControlFactory.CreateRPSTextBox<CuDistProductTypeSLEntityView>("29ed6246-82d1-405c-b26a-6fbc404557cd","","",true, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<CuDistProductTypeSLEntityView>("1e8b402c-7d28-4f02-9317-5d6ec4f8b3ff","","",false, this);
 

        }
        public IRPSSaveButton<CuDistProductTypeSLEntityView> SaveButton { get; set; } 
        public IRPSButton<CuDistProductTypeSLEntityView> DeleteButton { get; set; } 
        public IRPSButton<CuDistProductTypeSLEntityView,CuDistProductTypeSLCollectionView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<CuDistProductTypeSLEntityView,CuDistProductTypeSLCollectionView> BackButton { get; set; } 
        public IRPSTextBox<CuDistProductTypeSLEntityView> CodCuDistProductType { get; set; } 
        public IRPSTextBox<CuDistProductTypeSLEntityView> Description { get; set; } 
        public CuDistProductType Screen { get; set; }
        public CuDistProductTypeSLEntityView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}