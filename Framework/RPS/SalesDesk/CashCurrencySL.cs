    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.SalesDesk.CashCurrencySL
{
    //RPS VERSION 1.0.0.0
    public partial class CashCurrencySL:Screen
    {
        public CashCurrencySL():base()
        {
            this.URL = "salesdesk.cashcurrencysl";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            CashCurrencySLVMCollectionView  = new CashCurrencySLVMCollectionView(this); 
            CashCurrencySLVMEntityView  = new CashCurrencySLVMEntityView(this); 
            CashCurrencySLVMCollectionView.InitializeControls(); 
            CashCurrencySLVMEntityView.InitializeControls(); 
           
        }
      
            public CashCurrencySLVMCollectionView CashCurrencySLVMCollectionView {get; set; } 
            public CashCurrencySLVMEntityView CashCurrencySLVMEntityView {get; set; } 
    }
            
    public partial class CashCurrencySLVMCollectionView : View
    {
        public CashCurrencySLVMCollectionView(CashCurrencySL screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            IDCurrency = RPSControlFactory.CreateRPSComboBox<CashCurrencySLVMCollectionView>("36e6cecd-398e-4b2e-be18-b59620dbbe9c","","",false, this);
 
            CollectionInit params_CashCurrencySLEntitySourceQuery = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="4d85fd57-6008-4901-b167-86f17e8ac38d",CSSSelectorGrid="",XPathGrid=""};
            CashCurrencySLEntitySourceQuery = RPSControlFactory.RPSCreateCollectionWithGrid<CashCurrencySLEntitySourceQueryCollectionEditor<CashCurrencySLVMCollectionView,CashCurrencySLVMEntityView>,CashCurrencySLVMCollectionView,CashCurrencySLVMEntityView>( params_CashCurrencySLEntitySourceQuery,this,Screen.CashCurrencySLVMEntityView);
 

        }
        public IRPSComboBox<CashCurrencySLVMCollectionView> IDCurrency { get; set; } 
        public CashCurrencySLEntitySourceQueryCollectionEditor<CashCurrencySLVMCollectionView,CashCurrencySLVMEntityView> CashCurrencySLEntitySourceQuery { get; set; } 
        public CashCurrencySL Screen { get; set; }
        public CashCurrencySLVMCollectionView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class CashCurrencySLEntitySourceQueryCollectionEditor<CashCurrencySLVMCollectionView,CashCurrencySLVMEntityView>:RPSCollectionEditor<CashCurrencySLVMCollectionView,CashCurrencySLVMEntityView> where CashCurrencySLVMCollectionView : class, IView where CashCurrencySLVMEntityView : class, IView
    {
        public  CashCurrencySLEntitySourceQueryGridView<CashCurrencySLVMCollectionView,CashCurrencySLVMEntityView> GridView {get;set;}
    }
    public partial class CashCurrencySLEntitySourceQueryGridView <CashCurrencySLVMCollectionView,CashCurrencySLVMEntityView> :  RPSGridView<CashCurrencySLVMCollectionView,CashCurrencySLVMEntityView> where CashCurrencySLVMCollectionView : class, IView where CashCurrencySLVMEntityView : class, IView
    {
        public CashCurrencySLEntitySourceQueryGridView(CashCurrencySLVMCollectionView currentView,CashCurrencySLVMEntityView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            IDCurrency = RPSControlFactory.CreateRPSGridComboBox<CashCurrencySLVMCollectionView>("","#4d85fd57-6008-4901-b167-86f17e8ac38d .ag-row[role='row']@ROWINDEX [col-id='cIDCurrency']","",true, this.CurrentView);
 
            Amount = RPSControlFactory.CreateRPSGridFormattedTextBox<CashCurrencySLVMCollectionView>("","#4d85fd57-6008-4901-b167-86f17e8ac38d .ag-row[role='row']@ROWINDEX [col-id='cAmount']","",true, this.CurrentView);
 

        }
        public IRPSGridComboBox<CashCurrencySLVMCollectionView> IDCurrency { get; set; } 
        public IRPSGridTextBox<CashCurrencySLVMCollectionView> Amount { get; set; } 
                     
    }
 
    }
  
            
    public partial class CashCurrencySLVMEntityView : View
    {
        public CashCurrencySLVMEntityView(CashCurrencySL screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            DeleteButton = RPSControlFactory.RPSDeleteButton<CashCurrencySLVMEntityView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<CashCurrencySLVMEntityView,CashCurrencySLVMCollectionView>( this,Screen.CashCurrencySLVMCollectionView);
 
            BackButton = RPSControlFactory.RPSBackButton<CashCurrencySLVMEntityView,CashCurrencySLVMCollectionView>( this,Screen.CashCurrencySLVMCollectionView);
 
            AcceptButton = RPSControlFactory.RPSAcceptButton<CashCurrencySLVMEntityView,CashCurrencySLVMCollectionView>( this,Screen.CashCurrencySLVMCollectionView);
 
            IDCurrency = RPSControlFactory.CreateRPSComboBox<CashCurrencySLVMEntityView>("0f65fcf8-303f-4c9b-9e94-84aa5dfc83b5","","",true, this);
 
            Amount = RPSControlFactory.CreateRPSFormattedTextBox<CashCurrencySLVMEntityView>("f792e959-563f-4842-b06d-73750c21acfb","","",true, this);
 

        }
        public IRPSButton<CashCurrencySLVMEntityView> DeleteButton { get; set; } 
        public IRPSButton<CashCurrencySLVMEntityView,CashCurrencySLVMCollectionView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<CashCurrencySLVMEntityView,CashCurrencySLVMCollectionView> BackButton { get; set; } 
        public IRPSAcceptButton<CashCurrencySLVMEntityView,CashCurrencySLVMCollectionView> AcceptButton { get; set; } 
        public IRPSComboBox<CashCurrencySLVMEntityView> IDCurrency { get; set; } 
        public IRPSTextBox<CashCurrencySLVMEntityView> Amount { get; set; } 
        public CashCurrencySL Screen { get; set; }
        public CashCurrencySLVMEntityView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}