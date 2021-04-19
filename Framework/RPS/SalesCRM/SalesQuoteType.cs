    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.SalesCRM.SalesQuoteType
{
    //RPS VERSION 1.0.0.0
    public partial class SalesQuoteType:Screen
    {
        public SalesQuoteType():base()
        {
            this.URL = "salescrm.salesquotetype";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            SalesQuoteTypeSLCollectionView  = new SalesQuoteTypeSLCollectionView(this); 
            SalesQuoteTypeSLEntityView  = new SalesQuoteTypeSLEntityView(this); 
            SalesQuoteTypeSLCollectionView.InitializeControls(); 
            SalesQuoteTypeSLEntityView.InitializeControls(); 
           
        }
      
            public SalesQuoteTypeSLCollectionView SalesQuoteTypeSLCollectionView {get; set; } 
            public SalesQuoteTypeSLEntityView SalesQuoteTypeSLEntityView {get; set; } 
    }
            
    public partial class SalesQuoteTypeSLCollectionView : View
    {
        public SalesQuoteTypeSLCollectionView(SalesQuoteType screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            NewButton = RPSControlFactory.RPSNewButton<SalesQuoteTypeSLCollectionView,SalesQuoteTypeSLEntityView>( this,Screen.SalesQuoteTypeSLEntityView);
 
            CollectionInit params_MainConsult = new CollectionInit(){IDDescriptor = "dca62755-63c0-4879-9952-e3ad9ddb9903",CSSSelectorDescriptor = "",XPathDescriptor = ""};
            MainConsult = RPSControlFactory.RPSCreateCollection<SalesQuoteTypeSLCollectionView,SalesQuoteTypeSLEntityView>( params_MainConsult,this,Screen.SalesQuoteTypeSLEntityView);
 

        }
        public IRPSButton<SalesQuoteTypeSLCollectionView,SalesQuoteTypeSLEntityView> NewButton { get; set; } 
        public IRPSCollectionEditor<SalesQuoteTypeSLCollectionView,SalesQuoteTypeSLEntityView> MainConsult { get; set; } 
        public SalesQuoteType Screen { get; set; }
        public SalesQuoteTypeSLCollectionView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class SalesQuoteTypeSLEntityView : View
    {
        public SalesQuoteTypeSLEntityView(SalesQuoteType screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            SaveButton = RPSControlFactory.RPSSaveButton<SalesQuoteTypeSLEntityView>( this);
 
            DeleteButton = RPSControlFactory.RPSDeleteButton<SalesQuoteTypeSLEntityView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<SalesQuoteTypeSLEntityView,SalesQuoteTypeSLCollectionView>( this,Screen.SalesQuoteTypeSLCollectionView);
 
            BackButton = RPSControlFactory.RPSBackButton<SalesQuoteTypeSLEntityView,SalesQuoteTypeSLCollectionView>( this,Screen.SalesQuoteTypeSLCollectionView);
 
            CodSalesQuoteType = RPSControlFactory.CreateRPSTextBox<SalesQuoteTypeSLEntityView>("fb27ab92-6462-4356-9a86-e2809b8fd6e2","","",true, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<SalesQuoteTypeSLEntityView>("05f9e03c-cfcb-41d9-b49a-0eef8413596b","","",false, this);
 

        }
        public IRPSSaveButton<SalesQuoteTypeSLEntityView> SaveButton { get; set; } 
        public IRPSButton<SalesQuoteTypeSLEntityView> DeleteButton { get; set; } 
        public IRPSButton<SalesQuoteTypeSLEntityView,SalesQuoteTypeSLCollectionView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<SalesQuoteTypeSLEntityView,SalesQuoteTypeSLCollectionView> BackButton { get; set; } 
        public IRPSTextBox<SalesQuoteTypeSLEntityView> CodSalesQuoteType { get; set; } 
        public IRPSTextBox<SalesQuoteTypeSLEntityView> Description { get; set; } 
        public SalesQuoteType Screen { get; set; }
        public SalesQuoteTypeSLEntityView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}