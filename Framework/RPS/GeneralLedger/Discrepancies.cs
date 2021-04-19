    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.GeneralLedger.Discrepancies
{
    //RPS VERSION 1.0.0.0
    public partial class Discrepancies:Screen
    {
        public Discrepancies():base()
        {
            this.URL = "generalledger.discrepancies";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            DiscrepanciesQueryView  = new DiscrepanciesQueryView(this); 
            DiscrepanciesQueryView.InitializeControls(); 
           
        }
      
            public DiscrepanciesQueryView DiscrepanciesQueryView {get; set; } 
    }
            
    public partial class DiscrepanciesQueryView : View
    {
        public DiscrepanciesQueryView(Discrepancies screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            CheckSales = RPSControlFactory.CreateRPSCheckBox<DiscrepanciesQueryView>("8a326329-af6f-4c0b-994b-db6a79222fdd","","",false, this);
 
            Customer = RPSControlFactory.CreateRPSCollectionComboBox<DiscrepanciesQueryView>("fff1901a-6f12-4a05-a767-3843a1cf8752","","",false, this);
 
            CheckPurchases = RPSControlFactory.CreateRPSCheckBox<DiscrepanciesQueryView>("eb5b0590-122d-4827-a5f0-41ed3219ef87","","",false, this);
 
            Supplier = RPSControlFactory.CreateRPSCollectionComboBox<DiscrepanciesQueryView>("21a07a69-8f04-474c-a002-3c3aeaa4744e","","",false, this);
 
            GroupByAccount = RPSControlFactory.CreateRPSCheckBox<DiscrepanciesQueryView>("be17f44a-9f8f-415d-ab42-966358620e36","","",false, this);
 
            CollectionInit params_Discrepancies = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="b28d8c9c-88cc-49af-b055-7e8639d6b040",CSSSelectorGrid="",XPathGrid=""};
            Discrepancies = RPSControlFactory.RPSCreateCollectionWithGrid<DiscrepanciesCollectionEditor<DiscrepanciesQueryView>,DiscrepanciesQueryView>( params_Discrepancies,this);
 

        }
        public IRPSCheckbox<DiscrepanciesQueryView> CheckSales { get; set; } 
        public IRPSCollectionComboBox<DiscrepanciesQueryView> Customer { get; set; } 
        public IRPSCheckbox<DiscrepanciesQueryView> CheckPurchases { get; set; } 
        public IRPSCollectionComboBox<DiscrepanciesQueryView> Supplier { get; set; } 
        public IRPSCheckbox<DiscrepanciesQueryView> GroupByAccount { get; set; } 
        public DiscrepanciesCollectionEditor<DiscrepanciesQueryView> Discrepancies { get; set; } 
        public Discrepancies Screen { get; set; }
        public DiscrepanciesQueryView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class DiscrepanciesCollectionEditor<DiscrepanciesQueryView>:RPSCollectionEditor<DiscrepanciesQueryView> where DiscrepanciesQueryView : class, IView
    {
        public  DiscrepanciesGridView<DiscrepanciesQueryView> GridView {get;set;}
    }
    public partial class DiscrepanciesGridView <DiscrepanciesQueryView> :  RPSGridView<DiscrepanciesQueryView> where DiscrepanciesQueryView : class, IView
    {
        public DiscrepanciesGridView(DiscrepanciesQueryView currentView)
        {
            this.WebDriver = currentView.WebDriver;          
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            ThirdType = RPSControlFactory.CreateRPSGridTextBox<DiscrepanciesQueryView>("","#b28d8c9c-88cc-49af-b055-7e8639d6b040 .ag-row[role='row']@ROWINDEX [col-id='cThirdType']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<DiscrepanciesQueryView> ThirdType { get; set; } 
                     
    }
 
    }
  
    

}