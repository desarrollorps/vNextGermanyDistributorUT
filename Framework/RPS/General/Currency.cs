    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.General.Currency
{
    //RPS VERSION 1.0.0.0
    public partial class Currency:Screen
    {
        public Currency():base()
        {
            this.URL = "general.currency";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            CurrencyCollectionView  = new CurrencyCollectionView(this); 
            CurrencyEntityView  = new CurrencyEntityView(this); 
            ExchangeView  = new ExchangeView(this); 
            CurrencyCollectionView.InitializeControls(); 
            CurrencyEntityView.InitializeControls(); 
            ExchangeView.InitializeControls(); 
           
        }
      
            public CurrencyCollectionView CurrencyCollectionView {get; set; } 
            public CurrencyEntityView CurrencyEntityView {get; set; } 
            public ExchangeView ExchangeView {get; set; } 
    }
            
    public partial class CurrencyCollectionView : View
    {
        public CurrencyCollectionView(Currency screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            NewButton = RPSControlFactory.RPSNewButton<CurrencyCollectionView,CurrencyEntityView>( this,Screen.CurrencyEntityView);
 
            CollectionInit params_MainConsult = new CollectionInit(){IDDescriptor = "d652c97b-a744-49c1-a2bb-fb6486ee60cb",CSSSelectorDescriptor = "",XPathDescriptor = ""};
            MainConsult = RPSControlFactory.RPSCreateCollection<CurrencyCollectionView,CurrencyEntityView>( params_MainConsult,this,Screen.CurrencyEntityView);
 

        }
        public IRPSButton<CurrencyCollectionView,CurrencyEntityView> NewButton { get; set; } 
        public IRPSCollectionEditor<CurrencyCollectionView,CurrencyEntityView> MainConsult { get; set; } 
        public Currency Screen { get; set; }
        public CurrencyCollectionView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class CurrencyEntityView : View
    {
        public CurrencyEntityView(Currency screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            SaveButton = RPSControlFactory.RPSSaveButton<CurrencyEntityView>( this);
 
            DeleteButton = RPSControlFactory.RPSDeleteButton<CurrencyEntityView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<CurrencyEntityView,CurrencyCollectionView>( this,Screen.CurrencyCollectionView);
 
            BackButton = RPSControlFactory.RPSBackButton<CurrencyEntityView,CurrencyCollectionView>( this,Screen.CurrencyCollectionView);
 
            CodCurrency = RPSControlFactory.CreateRPSTextBox<CurrencyEntityView>("4db03986-115b-4467-9a46-38a0b1858bef","","",true, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<CurrencyEntityView>("ee6ddfaa-6d6b-4fbb-b05c-b17806602484","","",false, this);
 
            Type = RPSControlFactory.CreateRPSEnumComboBox<CurrencyEntityView>("ab7c0cc8-40cb-48d8-af6f-12d41f6ddb8a","","",true, this);
 
            DecimalAmount = RPSControlFactory.CreateRPSFormattedTextBox<CurrencyEntityView>("d785576b-83bb-4ad2-8abb-0bd25483ab2e","","",true, this);
 
            Symbol = RPSControlFactory.CreateRPSTextBox<CurrencyEntityView>("2a3168b5-6b3e-4d4c-bd71-aa0edd064c37","","",false, this);
 
            CodISO = RPSControlFactory.CreateRPSTextBox<CurrencyEntityView>("c2c7fce1-a441-4841-8981-d2efb4219fbf","","",false, this);
 
            CompanyCurrency = RPSControlFactory.CreateRPSOption<CurrencyEntityView>( "c7a9f868-254b-412d-8372-b9803b4fd656","","",this);
 
            ForeignCurrency = RPSControlFactory.CreateRPSOption<CurrencyEntityView>( "0077b22f-51b0-47de-a21f-6f1eec5715cd","","",this);
 
            AverageRate = RPSControlFactory.CreateRPSFormattedTextBox<CurrencyEntityView>("21e17dc4-261e-468c-bba0-98ac715699b2","","",true, this);
 
            ClosingDateRate = RPSControlFactory.CreateRPSFormattedTextBox<CurrencyEntityView>("235e98f0-c844-4198-8cb5-4aea04fc841c","","",true, this);
 
            ChangeUnit = RPSControlFactory.CreateRPSFormattedTextBox<CurrencyEntityView>("fbbc0547-d04f-4af8-945e-c597cdc1dd86","","",true, this);
 
            CollectionInit params_GENExchanges = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="b4fc4236-984b-408d-a4dd-345fa5a04a69",CSSSelectorGrid="",XPathGrid=""};
            GENExchanges = RPSControlFactory.RPSCreateCollectionWithGrid<GENExchangesCollectionEditor<CurrencyEntityView,ExchangeView>,CurrencyEntityView,ExchangeView>( params_GENExchanges,this,Screen.ExchangeView);
 

        }
        public IRPSSaveButton<CurrencyEntityView> SaveButton { get; set; } 
        public IRPSButton<CurrencyEntityView> DeleteButton { get; set; } 
        public IRPSButton<CurrencyEntityView,CurrencyCollectionView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<CurrencyEntityView,CurrencyCollectionView> BackButton { get; set; } 
        public IRPSTextBox<CurrencyEntityView> CodCurrency { get; set; } 
        public IRPSTextBox<CurrencyEntityView> Description { get; set; } 
        public IRPSComboBox<CurrencyEntityView> Type { get; set; } 
        public IRPSTextBox<CurrencyEntityView> DecimalAmount { get; set; } 
        public IRPSTextBox<CurrencyEntityView> Symbol { get; set; } 
        public IRPSTextBox<CurrencyEntityView> CodISO { get; set; } 
        public IRPSOption<CurrencyEntityView> CompanyCurrency { get; set; } 
        public IRPSOption<CurrencyEntityView> ForeignCurrency { get; set; } 
        public IRPSTextBox<CurrencyEntityView> AverageRate { get; set; } 
        public IRPSTextBox<CurrencyEntityView> ClosingDateRate { get; set; } 
        public IRPSTextBox<CurrencyEntityView> ChangeUnit { get; set; } 
        public GENExchangesCollectionEditor<CurrencyEntityView,ExchangeView> GENExchanges { get; set; } 
        public Currency Screen { get; set; }
        public CurrencyEntityView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class GENExchangesCollectionEditor<CurrencyEntityView,ExchangeView>:RPSCollectionEditor<CurrencyEntityView,ExchangeView> where CurrencyEntityView : class, IView where ExchangeView : class, IView
    {
        public  GENExchangesGridView<CurrencyEntityView,ExchangeView> GridView {get;set;}
    }
    public partial class GENExchangesGridView <CurrencyEntityView,ExchangeView> :  RPSGridView<CurrencyEntityView,ExchangeView> where CurrencyEntityView : class, IView where ExchangeView : class, IView
    {
        public GENExchangesGridView(CurrencyEntityView currentView,ExchangeView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            DateFrom = RPSControlFactory.CreateRPSGridTextBox<CurrencyEntityView>("","#b4fc4236-984b-408d-a4dd-345fa5a04a69 .ag-row[role='row']@ROWINDEX [col-id='cDateFrom']","",true, this.CurrentView);
 
            Change = RPSControlFactory.CreateRPSGridFormattedTextBox<CurrencyEntityView>("","#b4fc4236-984b-408d-a4dd-345fa5a04a69 .ag-row[role='row']@ROWINDEX [col-id='cChange']","",true, this.CurrentView);
 

        }
        public IRPSGridTextBox<CurrencyEntityView> DateFrom { get; set; } 
        public IRPSGridTextBox<CurrencyEntityView> Change { get; set; } 
                     
    }
 
    }
  
            
    public partial class ExchangeView : View
    {
        public ExchangeView(Currency screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            DeleteButton = RPSControlFactory.RPSDeleteButton<ExchangeView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<ExchangeView,CurrencyEntityView>( this,Screen.CurrencyEntityView);
 
            BackButton = RPSControlFactory.RPSBackButton<ExchangeView,CurrencyEntityView>( this,Screen.CurrencyEntityView);
 
            AcceptButton = RPSControlFactory.RPSAcceptButton<ExchangeView,CurrencyEntityView>( this,Screen.CurrencyEntityView);
 
            DateFrom = RPSControlFactory.CreateRPSTextBox<ExchangeView>("e29187a8-6086-4ee1-9228-54facd53f4a5","","",true, this);
 
            Change = RPSControlFactory.CreateRPSFormattedTextBox<ExchangeView>("c278d924-0dea-4800-a9db-b2da7da033c4","","",true, this);
 

        }
        public IRPSButton<ExchangeView> DeleteButton { get; set; } 
        public IRPSButton<ExchangeView,CurrencyEntityView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<ExchangeView,CurrencyEntityView> BackButton { get; set; } 
        public IRPSAcceptButton<ExchangeView,CurrencyEntityView> AcceptButton { get; set; } 
        public IRPSTextBox<ExchangeView> DateFrom { get; set; } 
        public IRPSTextBox<ExchangeView> Change { get; set; } 
        public Currency Screen { get; set; }
        public ExchangeView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}