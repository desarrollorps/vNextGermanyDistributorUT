    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.SalesCRM.SalesQuoteStatusSL
{
    //RPS VERSION 1.0.0.0
    public partial class SalesQuoteStatusSL:Screen
    {
        public SalesQuoteStatusSL():base()
        {
            this.URL = "salescrm.salesquotestatussl";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            SalesQuoteStatusSLQueryView  = new SalesQuoteStatusSLQueryView(this); 
            SalesQuoteStatusSLEntityView  = new SalesQuoteStatusSLEntityView(this); 
            SalesQuoteStatusSLQueryView.InitializeControls(); 
            SalesQuoteStatusSLEntityView.InitializeControls(); 
           
        }
      
            public SalesQuoteStatusSLQueryView SalesQuoteStatusSLQueryView {get; set; } 
            public SalesQuoteStatusSLEntityView SalesQuoteStatusSLEntityView {get; set; } 
    }
            
    public partial class SalesQuoteStatusSLQueryView : View
    {
        public SalesQuoteStatusSLQueryView(SalesQuoteStatusSL screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            NewButton = RPSControlFactory.RPSNewButton<SalesQuoteStatusSLQueryView,SalesQuoteStatusSLEntityView>( this,Screen.SalesQuoteStatusSLEntityView);
 
            CollectionInit params_MainConsult = new CollectionInit(){IDDescriptor = "7abc1430-ac60-4978-96c8-ed8aae381936",CSSSelectorDescriptor = "",XPathDescriptor = ""};
            MainConsult = RPSControlFactory.RPSCreateCollection<SalesQuoteStatusSLQueryView,SalesQuoteStatusSLEntityView>( params_MainConsult,this,Screen.SalesQuoteStatusSLEntityView);
 

        }
        public IRPSButton<SalesQuoteStatusSLQueryView,SalesQuoteStatusSLEntityView> NewButton { get; set; } 
        public IRPSCollectionEditor<SalesQuoteStatusSLQueryView,SalesQuoteStatusSLEntityView> MainConsult { get; set; } 
        public SalesQuoteStatusSL Screen { get; set; }
        public SalesQuoteStatusSLQueryView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class SalesQuoteStatusSLEntityView : View
    {
        public SalesQuoteStatusSLEntityView(SalesQuoteStatusSL screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            SaveButton = RPSControlFactory.RPSSaveButton<SalesQuoteStatusSLEntityView>( this);
 
            DeleteButton = RPSControlFactory.RPSDeleteButton<SalesQuoteStatusSLEntityView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<SalesQuoteStatusSLEntityView,SalesQuoteStatusSLQueryView>( this,Screen.SalesQuoteStatusSLQueryView);
 
            BackButton = RPSControlFactory.RPSBackButton<SalesQuoteStatusSLEntityView,SalesQuoteStatusSLQueryView>( this,Screen.SalesQuoteStatusSLQueryView);
 
            CodSalesQuoteStatus = RPSControlFactory.CreateRPSTextBox<SalesQuoteStatusSLEntityView>("8eb163de-260f-4f74-86f3-55d002f41c43","","",true, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<SalesQuoteStatusSLEntityView>("cc1c7073-cc40-4396-bec4-17f3629a537e","","",false, this);
 
            StatusType = RPSControlFactory.CreateRPSEnumComboBox<SalesQuoteStatusSLEntityView>("a4af0a69-c06c-4487-b0ec-8a35ade3b9d4","","",true, this);
 

        }
        public IRPSSaveButton<SalesQuoteStatusSLEntityView> SaveButton { get; set; } 
        public IRPSButton<SalesQuoteStatusSLEntityView> DeleteButton { get; set; } 
        public IRPSButton<SalesQuoteStatusSLEntityView,SalesQuoteStatusSLQueryView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<SalesQuoteStatusSLEntityView,SalesQuoteStatusSLQueryView> BackButton { get; set; } 
        public IRPSTextBox<SalesQuoteStatusSLEntityView> CodSalesQuoteStatus { get; set; } 
        public IRPSTextBox<SalesQuoteStatusSLEntityView> Description { get; set; } 
        public IRPSComboBox<SalesQuoteStatusSLEntityView> StatusType { get; set; } 
        public SalesQuoteStatusSL Screen { get; set; }
        public SalesQuoteStatusSLEntityView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}