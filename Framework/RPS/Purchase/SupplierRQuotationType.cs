    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.Purchase.SupplierRQuotationType
{
    //RPS VERSION 1.0.0.0
    public partial class SupplierRQuotationType:Screen
    {
        public SupplierRQuotationType():base()
        {
            this.URL = "purchase.supplierrquotationtype";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            SupplierRQuotationTypeCollectionView  = new SupplierRQuotationTypeCollectionView(this); 
            SupplierRQuotationTypeEntityView  = new SupplierRQuotationTypeEntityView(this); 
            SupplierRQuotationTypeCollectionView.InitializeControls(); 
            SupplierRQuotationTypeEntityView.InitializeControls(); 
           
        }
      
            public SupplierRQuotationTypeCollectionView SupplierRQuotationTypeCollectionView {get; set; } 
            public SupplierRQuotationTypeEntityView SupplierRQuotationTypeEntityView {get; set; } 
    }
            
    public partial class SupplierRQuotationTypeCollectionView : View
    {
        public SupplierRQuotationTypeCollectionView(SupplierRQuotationType screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            NewButton = RPSControlFactory.RPSNewButton<SupplierRQuotationTypeCollectionView,SupplierRQuotationTypeEntityView>( this,Screen.SupplierRQuotationTypeEntityView);
 
            CollectionInit params_MainConsult = new CollectionInit(){IDDescriptor = "575c11da-2b47-4b09-8c63-dfeb33adb55e",CSSSelectorDescriptor = "",XPathDescriptor = ""};
            MainConsult = RPSControlFactory.RPSCreateCollection<SupplierRQuotationTypeCollectionView,SupplierRQuotationTypeEntityView>( params_MainConsult,this,Screen.SupplierRQuotationTypeEntityView);
 

        }
        public IRPSButton<SupplierRQuotationTypeCollectionView,SupplierRQuotationTypeEntityView> NewButton { get; set; } 
        public IRPSCollectionEditor<SupplierRQuotationTypeCollectionView,SupplierRQuotationTypeEntityView> MainConsult { get; set; } 
        public SupplierRQuotationType Screen { get; set; }
        public SupplierRQuotationTypeCollectionView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class SupplierRQuotationTypeEntityView : View
    {
        public SupplierRQuotationTypeEntityView(SupplierRQuotationType screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            SaveButton = RPSControlFactory.RPSSaveButton<SupplierRQuotationTypeEntityView>( this);
 
            DeleteButton = RPSControlFactory.RPSDeleteButton<SupplierRQuotationTypeEntityView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<SupplierRQuotationTypeEntityView,SupplierRQuotationTypeCollectionView>( this,Screen.SupplierRQuotationTypeCollectionView);
 
            BackButton = RPSControlFactory.RPSBackButton<SupplierRQuotationTypeEntityView,SupplierRQuotationTypeCollectionView>( this,Screen.SupplierRQuotationTypeCollectionView);
 
            CodSupplierRQuotationType = RPSControlFactory.CreateRPSTextBox<SupplierRQuotationTypeEntityView>("ae77ef2d-f143-4dca-9747-6e5edf07410e","","",true, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<SupplierRQuotationTypeEntityView>("08c0ae6c-5b95-4462-9b6a-3d4808e096ad","","",false, this);
 

        }
        public IRPSSaveButton<SupplierRQuotationTypeEntityView> SaveButton { get; set; } 
        public IRPSButton<SupplierRQuotationTypeEntityView> DeleteButton { get; set; } 
        public IRPSButton<SupplierRQuotationTypeEntityView,SupplierRQuotationTypeCollectionView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<SupplierRQuotationTypeEntityView,SupplierRQuotationTypeCollectionView> BackButton { get; set; } 
        public IRPSTextBox<SupplierRQuotationTypeEntityView> CodSupplierRQuotationType { get; set; } 
        public IRPSTextBox<SupplierRQuotationTypeEntityView> Description { get; set; } 
        public SupplierRQuotationType Screen { get; set; }
        public SupplierRQuotationTypeEntityView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}