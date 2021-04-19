    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.Project.Profitability
{
    //RPS VERSION 1.0.0.0
    public partial class Profitability:Screen
    {
        public Profitability():base()
        {
            this.URL = "project.profitability";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            ProfitabilityQueryView  = new ProfitabilityQueryView(this); 
            ProfitabilityQueryView.InitializeControls(); 
           
        }
      
            public ProfitabilityQueryView ProfitabilityQueryView {get; set; } 
    }
            
    public partial class ProfitabilityQueryView : View
    {
        public ProfitabilityQueryView(Profitability screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            Site = RPSControlFactory.CreateRPSComboBox<ProfitabilityQueryView>("aa3397bf-8c95-468e-9765-810955ceae87","","",false, this);
 
            Project = RPSControlFactory.CreateRPSCollectionComboBox<ProfitabilityQueryView>("51a262e4-686f-4ac8-8b7d-b68cfe633445","","",false, this);
 
            Customer = RPSControlFactory.CreateRPSCollectionComboBox<ProfitabilityQueryView>("54f43393-5060-4d85-bec8-1bb8a48ce78b","","",false, this);
 
            Situation = RPSControlFactory.CreateRPSCollectionComboBox<ProfitabilityQueryView>("37d3c09c-d122-41cb-8cf2-10a62fda2184","","",false, this);
 
            GetManufacturingCosts = RPSControlFactory.CreateRPSCheckBox<ProfitabilityQueryView>("729d464a-8872-4401-a60f-d0d0bc634943","","",false, this);
 
            Project_CalcPercentProgress = RPSControlFactory.CreateRPSFormattedTextBox<ProfitabilityQueryView>("f1cb37fa-8199-4e00-b3ed-b9dfac42a139","","",false, this);
 
            Project_CalcAmountCostReal = RPSControlFactory.CreateRPSFormattedTextBox<ProfitabilityQueryView>("8357b399-4ea6-4ffd-9291-d6b5f495f75c","","",false, this);
 
            Project_CalcAmountCostInitial = RPSControlFactory.CreateRPSFormattedTextBox<ProfitabilityQueryView>("cc12f309-a816-4aaa-ac49-88eb67c0476d","","",false, this);
 
            Project_CalcAmountSale = RPSControlFactory.CreateRPSFormattedTextBox<ProfitabilityQueryView>("ab52bd8d-585f-4698-acaa-e685800425f6","","",false, this);
 
            Project_CalcAmountInOrders = RPSControlFactory.CreateRPSFormattedTextBox<ProfitabilityQueryView>("fa104c92-cfac-4831-9e3a-f21518d4faae","","",false, this);
 
            Project_CalcAmountCost = RPSControlFactory.CreateRPSFormattedTextBox<ProfitabilityQueryView>("f6012998-e41d-4e2d-aa25-a1d5c24bb1bb","","",false, this);
 
            Profit = RPSControlFactory.CreateRPSFormattedTextBox<ProfitabilityQueryView>("ccd8154a-a62f-43fc-a515-e8016f741d90","","",false, this);
 
            Project_PercentProfit = RPSControlFactory.CreateRPSFormattedTextBox<ProfitabilityQueryView>("27659d7c-de9c-43d8-8a0f-1f918e73fb35","","",false, this);
 
            AmountCostExpected = RPSControlFactory.CreateRPSFormattedTextBox<ProfitabilityQueryView>("1415b976-2c6b-4997-9ab8-d605f204df28","","",false, this);
 
            MarginExpected = RPSControlFactory.CreateRPSFormattedTextBox<ProfitabilityQueryView>("c2fd1fa7-f6df-4887-a45a-060e969d1ec5","","",false, this);
 
            PercentMargin = RPSControlFactory.CreateRPSFormattedTextBox<ProfitabilityQueryView>("2a6a747f-7104-4969-b220-ee586b78ee30","","",false, this);
 
            Project_CalcAmountInvoiced = RPSControlFactory.CreateRPSFormattedTextBox<ProfitabilityQueryView>("1bb5368a-fa93-4dd1-aaa4-1fa49dd30d78","","",false, this);
 
            AMOUNTPENDINGINVOICE = RPSControlFactory.CreateRPSFormattedTextBox<ProfitabilityQueryView>("7bd391ac-0112-4d1a-8f07-d78c40c73d57","","",false, this);
 
            PERCENTINVOICE = RPSControlFactory.CreateRPSFormattedTextBox<ProfitabilityQueryView>("23a9567b-e8ef-4591-afb0-041723f6a387","","",false, this);
 
            BALANCE = RPSControlFactory.CreateRPSFormattedTextBox<ProfitabilityQueryView>("35f407c0-0c78-4466-8d2a-1a3b19284166","","",false, this);
 
            CollectionInit params_Profitability = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="669f9452-f3d8-4ba3-b19e-5547e4bd5d00",CSSSelectorGrid="",XPathGrid=""};
            Profitability = RPSControlFactory.RPSCreateCollectionWithGrid<ProfitabilityCollectionEditor<ProfitabilityQueryView>,ProfitabilityQueryView>( params_Profitability,this);
 

        }
        public IRPSComboBox<ProfitabilityQueryView> Site { get; set; } 
        public IRPSCollectionComboBox<ProfitabilityQueryView> Project { get; set; } 
        public IRPSCollectionComboBox<ProfitabilityQueryView> Customer { get; set; } 
        public IRPSCollectionComboBox<ProfitabilityQueryView> Situation { get; set; } 
        public IRPSCheckbox<ProfitabilityQueryView> GetManufacturingCosts { get; set; } 
        public IRPSTextBox<ProfitabilityQueryView> Project_CalcPercentProgress { get; set; } 
        public IRPSTextBox<ProfitabilityQueryView> Project_CalcAmountCostReal { get; set; } 
        public IRPSTextBox<ProfitabilityQueryView> Project_CalcAmountCostInitial { get; set; } 
        public IRPSTextBox<ProfitabilityQueryView> Project_CalcAmountSale { get; set; } 
        public IRPSTextBox<ProfitabilityQueryView> Project_CalcAmountInOrders { get; set; } 
        public IRPSTextBox<ProfitabilityQueryView> Project_CalcAmountCost { get; set; } 
        public IRPSTextBox<ProfitabilityQueryView> Profit { get; set; } 
        public IRPSTextBox<ProfitabilityQueryView> Project_PercentProfit { get; set; } 
        public IRPSTextBox<ProfitabilityQueryView> AmountCostExpected { get; set; } 
        public IRPSTextBox<ProfitabilityQueryView> MarginExpected { get; set; } 
        public IRPSTextBox<ProfitabilityQueryView> PercentMargin { get; set; } 
        public IRPSTextBox<ProfitabilityQueryView> Project_CalcAmountInvoiced { get; set; } 
        public IRPSTextBox<ProfitabilityQueryView> AMOUNTPENDINGINVOICE { get; set; } 
        public IRPSTextBox<ProfitabilityQueryView> PERCENTINVOICE { get; set; } 
        public IRPSTextBox<ProfitabilityQueryView> BALANCE { get; set; } 
        public ProfitabilityCollectionEditor<ProfitabilityQueryView> Profitability { get; set; } 
        public Profitability Screen { get; set; }
        public ProfitabilityQueryView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class ProfitabilityCollectionEditor<ProfitabilityQueryView>:RPSCollectionEditor<ProfitabilityQueryView> where ProfitabilityQueryView : class, IView
    {
        public  ProfitabilityGridView<ProfitabilityQueryView> GridView {get;set;}
    }
    public partial class ProfitabilityGridView <ProfitabilityQueryView> :  RPSGridView<ProfitabilityQueryView> where ProfitabilityQueryView : class, IView
    {
        public ProfitabilityGridView(ProfitabilityQueryView currentView)
        {
            this.WebDriver = currentView.WebDriver;          
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            Project_CalcAmountCost = RPSControlFactory.CreateRPSGridFormattedTextBox<ProfitabilityQueryView>("","#669f9452-f3d8-4ba3-b19e-5547e4bd5d00 .ag-row[role='row']@ROWINDEX [col-id='cProject_CalcAmountCost']","",false, this.CurrentView);
 
            Project_CalcPercentProgress = RPSControlFactory.CreateRPSGridFormattedTextBox<ProfitabilityQueryView>("","#669f9452-f3d8-4ba3-b19e-5547e4bd5d00 .ag-row[role='row']@ROWINDEX [col-id='cProject_CalcPercentProgress']","",false, this.CurrentView);
 
            Project_CalcAmountCostReal = RPSControlFactory.CreateRPSGridFormattedTextBox<ProfitabilityQueryView>("","#669f9452-f3d8-4ba3-b19e-5547e4bd5d00 .ag-row[role='row']@ROWINDEX [col-id='cProject_CalcAmountCostReal']","",false, this.CurrentView);
 
            Project_CalcAmountSale = RPSControlFactory.CreateRPSGridFormattedTextBox<ProfitabilityQueryView>("","#669f9452-f3d8-4ba3-b19e-5547e4bd5d00 .ag-row[role='row']@ROWINDEX [col-id='cProject_CalcAmountSale']","",false, this.CurrentView);
 
            Project_PercentProfit = RPSControlFactory.CreateRPSGridFormattedTextBox<ProfitabilityQueryView>("","#669f9452-f3d8-4ba3-b19e-5547e4bd5d00 .ag-row[role='row']@ROWINDEX [col-id='cProject_PercentProfit']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<ProfitabilityQueryView> Project_CalcAmountCost { get; set; } 
        public IRPSGridTextBox<ProfitabilityQueryView> Project_CalcPercentProgress { get; set; } 
        public IRPSGridTextBox<ProfitabilityQueryView> Project_CalcAmountCostReal { get; set; } 
        public IRPSGridTextBox<ProfitabilityQueryView> Project_CalcAmountSale { get; set; } 
        public IRPSGridTextBox<ProfitabilityQueryView> Project_PercentProfit { get; set; } 
                     
    }
 
    }
  
    

}