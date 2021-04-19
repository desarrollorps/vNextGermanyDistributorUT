    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.TaxModel.CashAccount
{
    //RPS VERSION 1.0.0.0
    public partial class CashAccount:Screen
    {
        public CashAccount():base()
        {
            this.URL = "taxmodel.cashaccount";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            CashAccountView  = new CashAccountView(this); 
            CashAccountView.InitializeControls(); 
           
        }
      
            public CashAccountView CashAccountView {get; set; } 
    }
            
    public partial class CashAccountView : View
    {
        public CashAccountView(CashAccount screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            AddCashAccountButton = RPSControlFactory.CreateRPSButton<CashAccountView>( "ec733dc3-b655-4ff7-97f7-da5bcdeab685","","",this);
 
            SaveCommandButton = RPSControlFactory.CreateRPSButton<CashAccountView>( "d626a038-a650-46d2-895e-768ed4bfab2a","","",this);
 
            CollectionInit params_CashAccount = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="4f7db0a9-ec94-456d-a659-527baec3607f",CSSSelectorGrid="",XPathGrid=""};
            CashAccount = RPSControlFactory.RPSCreateCollectionWithGrid<CashAccountCollectionEditor<CashAccountView>,CashAccountView>( params_CashAccount,this);
 

        }
        public IRPSButton<CashAccountView> AddCashAccountButton { get; set; } 
        public IRPSButton<CashAccountView> SaveCommandButton { get; set; } 
        public CashAccountCollectionEditor<CashAccountView> CashAccount { get; set; } 
        public CashAccount Screen { get; set; }
        public CashAccountView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class CashAccountCollectionEditor<CashAccountView>:RPSCollectionEditor<CashAccountView> where CashAccountView : class, IView
    {
        public  CashAccountGridView<CashAccountView> GridView {get;set;}
    }
    public partial class CashAccountGridView <CashAccountView> :  RPSGridView<CashAccountView> where CashAccountView : class, IView
    {
        public CashAccountGridView(CashAccountView currentView)
        {
            this.WebDriver = currentView.WebDriver;          
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            DeleteCashAccount = RPSControlFactory.CreateRPSGridButton<CashAccountView>( "","#4f7db0a9-ec94-456d-a659-527baec3607f .ag-row[role='row']@ROWINDEX [col-id='cDeleteCashAccount']","",this.CurrentView);
 
            IDAccount = RPSControlFactory.CreateRPSGridComboBox<CashAccountView>("","#4f7db0a9-ec94-456d-a659-527baec3607f .ag-row[role='row']@ROWINDEX [col-id='cIDAccount']","",false, this.CurrentView);
 

        }
        public IRPSGridButton<CashAccountView> DeleteCashAccount { get; set; } 
        public IRPSGridComboBox<CashAccountView> IDAccount { get; set; } 
                     
    }
 
    }
  
    

}