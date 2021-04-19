    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.Project.AdjustmentBudget
{
    //RPS VERSION 1.0.0.0
    public partial class AdjustmentBudget:Screen
    {
        public AdjustmentBudget():base()
        {
            this.URL = "project.adjustmentbudget";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            AdjustmentBudgetQueryView  = new AdjustmentBudgetQueryView(this); 
            AdjustementBudgetChangeDialogDialogView  = new AdjustementBudgetChangeDialogDialogView(this); 
            AdjustmentBudgetQueryView.InitializeControls(); 
            AdjustementBudgetChangeDialogDialogView.InitializeControls(); 
           
        }
      
            public AdjustmentBudgetQueryView AdjustmentBudgetQueryView {get; set; } 
            public AdjustementBudgetChangeDialogDialogView AdjustementBudgetChangeDialogDialogView {get; set; } 
    }
            
    public partial class AdjustmentBudgetQueryView : View
    {
        public AdjustmentBudgetQueryView(AdjustmentBudget screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            IDProject = RPSControlFactory.CreateRPSComboBox<AdjustmentBudgetQueryView>("ce355a05-b15e-40be-b87e-d14989cfe1de","","",false, this);
 
            Customer = RPSControlFactory.CreateRPSComboBox<AdjustmentBudgetQueryView>("e9e32173-1997-4534-92d3-649175fa9b78","","",false, this);
 
            IDPotentialCustomer = RPSControlFactory.CreateRPSComboBox<AdjustmentBudgetQueryView>("350ea66a-11a5-4001-9f32-ab0e91d6ac8e","","",false, this);
 
            SalesAmountTotal = RPSControlFactory.CreateRPSFormattedTextBox<AdjustmentBudgetQueryView>("eb637f4b-e0ae-4199-be20-fe7345e130c5","","",false, this);
 
            SalesAmountTotalCalculated = RPSControlFactory.CreateRPSFormattedTextBox<AdjustmentBudgetQueryView>("6b73e386-1329-47c7-a775-c2d9eb956a8c","","",false, this);
 
            SalesAmountBlocked = RPSControlFactory.CreateRPSFormattedTextBox<AdjustmentBudgetQueryView>("14af355d-e9ab-4141-9bc3-50eca185e549","","",false, this);
 
            SalesQuoteSL = RPSControlFactory.CreateRPSComboBox<AdjustmentBudgetQueryView>("43e723e0-d4bf-4587-91fe-bd54294010f9","","",false, this);
 
            SalesOfferTotal = RPSControlFactory.CreateRPSFormattedTextBox<AdjustmentBudgetQueryView>("ac2738b5-431e-47f3-8313-bbad69be2df6","","",false, this);
 
            CostAmountTotal = RPSControlFactory.CreateRPSFormattedTextBox<AdjustmentBudgetQueryView>("92c474f2-85d2-44aa-87e7-76c71a98e8e3","","",false, this);
 
            CostAmountBlocked = RPSControlFactory.CreateRPSFormattedTextBox<AdjustmentBudgetQueryView>("9abb57e6-adc5-4143-b6c8-4549c4cca98c","","",false, this);
 
            OrderSL = RPSControlFactory.CreateRPSComboBox<AdjustmentBudgetQueryView>("500dea21-5d53-4fc3-8841-77f60cd4ea37","","",false, this);
 
            SalesOrderTotal = RPSControlFactory.CreateRPSFormattedTextBox<AdjustmentBudgetQueryView>("b620fcc9-b4fc-4281-b8cb-bfa277071059","","",false, this);
 
            DescrTask = RPSControlFactory.CreateRPSTextBox<AdjustmentBudgetQueryView>("ecfbeead-0d7c-4aff-bd27-7c4a6d4b07b6","","",false, this);
 
            DescrBudgetCategory = RPSControlFactory.CreateRPSTextBox<AdjustmentBudgetQueryView>("04ddf937-d241-4ed1-b725-9e2074f43441","","",false, this);
 
            Resource = RPSControlFactory.CreateRPSTextBox<AdjustmentBudgetQueryView>("56441572-36fb-4c04-863f-bf70a66f62e0","","",false, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<AdjustmentBudgetQueryView>("2e1cd61a-495e-4f66-a1fc-1d62a8fce703","","",false, this);
 
            Blocked = RPSControlFactory.CreateRPSCheckBox<AdjustmentBudgetQueryView>("a8e67a39-8788-45f8-8808-7fe2bb664728","","",false, this);
 
            PercentMargin = RPSControlFactory.CreateRPSFormattedTextBox<AdjustmentBudgetQueryView>("50e378af-c757-4792-8e99-5dbe65e1b7de","","",false, this);
 
            eTypeProfit = RPSControlFactory.CreateRPSEnumComboBox<AdjustmentBudgetQueryView>("4146ad12-3363-4d5d-9a73-345d812a8200","","",false, this);
 
            PercentProfit = RPSControlFactory.CreateRPSFormattedTextBox<AdjustmentBudgetQueryView>("a2ac65d9-d4d3-4b28-ba80-49cc9d729d30","","",false, this);
 
            PriceSaleTheoricValue = RPSControlFactory.CreateRPSFormattedTextBox<AdjustmentBudgetQueryView>("90cb5333-a07e-4759-bfd7-6986a81f1f29","","",false, this);
 
            CalculatedSalesAmountPrice = RPSControlFactory.CreateRPSFormattedTextBox<AdjustmentBudgetQueryView>("360a73ae-ab85-4255-b6ad-199c28324150","","",false, this);
 
            UpdateProjectBudgetCommandButton = RPSControlFactory.CreateRPSButton<AdjustmentBudgetQueryView>( "acee7c42-cfc1-4d53-b2eb-028473ef70f6","","",this);
 
            AdjustementBudgetChangeDialogNavigationCommandButton = RPSControlFactory.CreateRPSButtonToView<AdjustmentBudgetQueryView,AdjustementBudgetChangeDialogDialogView>("72b2e64a-3e9e-4cf8-9b15-98812ec2ae0c","","", this,Screen.AdjustementBudgetChangeDialogDialogView);
 
            CollectionInit params_AdjustmentBudgetProjectConsult = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="7f7f12d3-ad73-4453-8193-9927e6a89fdd",CSSSelectorGrid="",XPathGrid=""};
            AdjustmentBudgetProjectConsult = RPSControlFactory.RPSCreateCollectionWithGrid<AdjustmentBudgetProjectConsultCollectionEditor<AdjustmentBudgetQueryView,AdjustementBudgetChangeDialogDialogView>,AdjustmentBudgetQueryView,AdjustementBudgetChangeDialogDialogView>( params_AdjustmentBudgetProjectConsult,this,Screen.AdjustementBudgetChangeDialogDialogView);
 

        }
        public IRPSComboBox<AdjustmentBudgetQueryView> IDProject { get; set; } 
        public IRPSComboBox<AdjustmentBudgetQueryView> Customer { get; set; } 
        public IRPSComboBox<AdjustmentBudgetQueryView> IDPotentialCustomer { get; set; } 
        public IRPSTextBox<AdjustmentBudgetQueryView> SalesAmountTotal { get; set; } 
        public IRPSTextBox<AdjustmentBudgetQueryView> SalesAmountTotalCalculated { get; set; } 
        public IRPSTextBox<AdjustmentBudgetQueryView> SalesAmountBlocked { get; set; } 
        public IRPSComboBox<AdjustmentBudgetQueryView> SalesQuoteSL { get; set; } 
        public IRPSTextBox<AdjustmentBudgetQueryView> SalesOfferTotal { get; set; } 
        public IRPSTextBox<AdjustmentBudgetQueryView> CostAmountTotal { get; set; } 
        public IRPSTextBox<AdjustmentBudgetQueryView> CostAmountBlocked { get; set; } 
        public IRPSComboBox<AdjustmentBudgetQueryView> OrderSL { get; set; } 
        public IRPSTextBox<AdjustmentBudgetQueryView> SalesOrderTotal { get; set; } 
        public IRPSTextBox<AdjustmentBudgetQueryView> DescrTask { get; set; } 
        public IRPSTextBox<AdjustmentBudgetQueryView> DescrBudgetCategory { get; set; } 
        public IRPSTextBox<AdjustmentBudgetQueryView> Resource { get; set; } 
        public IRPSTextBox<AdjustmentBudgetQueryView> Description { get; set; } 
        public IRPSCheckbox<AdjustmentBudgetQueryView> Blocked { get; set; } 
        public IRPSTextBox<AdjustmentBudgetQueryView> PercentMargin { get; set; } 
        public IRPSComboBox<AdjustmentBudgetQueryView> eTypeProfit { get; set; } 
        public IRPSTextBox<AdjustmentBudgetQueryView> PercentProfit { get; set; } 
        public IRPSTextBox<AdjustmentBudgetQueryView> PriceSaleTheoricValue { get; set; } 
        public IRPSTextBox<AdjustmentBudgetQueryView> CalculatedSalesAmountPrice { get; set; } 
        public IRPSButton<AdjustmentBudgetQueryView> UpdateProjectBudgetCommandButton { get; set; } 
        public IRPSButton<AdjustmentBudgetQueryView,AdjustementBudgetChangeDialogDialogView> AdjustementBudgetChangeDialogNavigationCommandButton { get; set; } 
        public AdjustmentBudgetProjectConsultCollectionEditor<AdjustmentBudgetQueryView,AdjustementBudgetChangeDialogDialogView> AdjustmentBudgetProjectConsult { get; set; } 
        public AdjustmentBudget Screen { get; set; }
        public AdjustmentBudgetQueryView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class AdjustmentBudgetProjectConsultCollectionEditor<AdjustmentBudgetQueryView,AdjustementBudgetChangeDialogDialogView>:RPSCollectionEditor<AdjustmentBudgetQueryView,AdjustementBudgetChangeDialogDialogView> where AdjustmentBudgetQueryView : class, IView where AdjustementBudgetChangeDialogDialogView : class, IView
    {
        public  AdjustmentBudgetProjectConsultGridView<AdjustmentBudgetQueryView,AdjustementBudgetChangeDialogDialogView> GridView {get;set;}
    }
    public partial class AdjustmentBudgetProjectConsultGridView <AdjustmentBudgetQueryView,AdjustementBudgetChangeDialogDialogView> :  RPSGridView<AdjustmentBudgetQueryView,AdjustementBudgetChangeDialogDialogView> where AdjustmentBudgetQueryView : class, IView where AdjustementBudgetChangeDialogDialogView : class, IView
    {
        public AdjustmentBudgetProjectConsultGridView(AdjustmentBudgetQueryView currentView,AdjustementBudgetChangeDialogDialogView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            DescrTask = RPSControlFactory.CreateRPSGridTextBox<AdjustmentBudgetQueryView>("","#7f7f12d3-ad73-4453-8193-9927e6a89fdd .ag-row[role='row']@ROWINDEX [col-id='cDescrTask']","",false, this.CurrentView);
 
            Resource = RPSControlFactory.CreateRPSGridTextBox<AdjustmentBudgetQueryView>("","#7f7f12d3-ad73-4453-8193-9927e6a89fdd .ag-row[role='row']@ROWINDEX [col-id='cResource']","",false, this.CurrentView);
 
            Description = RPSControlFactory.CreateRPSGridTextBox<AdjustmentBudgetQueryView>("","#7f7f12d3-ad73-4453-8193-9927e6a89fdd .ag-row[role='row']@ROWINDEX [col-id='cDescription']","",false, this.CurrentView);
 
            eTypeProfit = RPSControlFactory.CreateRPSGridEnumComboBox<AdjustmentBudgetQueryView>("","#7f7f12d3-ad73-4453-8193-9927e6a89fdd .ag-row[role='row']@ROWINDEX [col-id='ceTypeProfit']","",false, this.CurrentView);
 
            PercentProfit = RPSControlFactory.CreateRPSGridFormattedTextBox<AdjustmentBudgetQueryView>("","#7f7f12d3-ad73-4453-8193-9927e6a89fdd .ag-row[role='row']@ROWINDEX [col-id='cPercentProfit']","",false, this.CurrentView);
 
            PriceSaleTheoricValue = RPSControlFactory.CreateRPSGridFormattedTextBox<AdjustmentBudgetQueryView>("","#7f7f12d3-ad73-4453-8193-9927e6a89fdd .ag-row[role='row']@ROWINDEX [col-id='cPriceSaleTheoricValue']","",false, this.CurrentView);
 
            CalculatedSalesAmountPrice = RPSControlFactory.CreateRPSGridFormattedTextBox<AdjustmentBudgetQueryView>("","#7f7f12d3-ad73-4453-8193-9927e6a89fdd .ag-row[role='row']@ROWINDEX [col-id='cCalculatedSalesAmountPrice']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<AdjustmentBudgetQueryView> DescrTask { get; set; } 
        public IRPSGridTextBox<AdjustmentBudgetQueryView> Resource { get; set; } 
        public IRPSGridTextBox<AdjustmentBudgetQueryView> Description { get; set; } 
        public IRPSGridComboBox<AdjustmentBudgetQueryView> eTypeProfit { get; set; } 
        public IRPSGridTextBox<AdjustmentBudgetQueryView> PercentProfit { get; set; } 
        public IRPSGridTextBox<AdjustmentBudgetQueryView> PriceSaleTheoricValue { get; set; } 
        public IRPSGridTextBox<AdjustmentBudgetQueryView> CalculatedSalesAmountPrice { get; set; } 
                     
    }
 
    }
  
            
    public partial class AdjustementBudgetChangeDialogDialogView : View
    {
        public AdjustementBudgetChangeDialogDialogView(AdjustmentBudget screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            optAdjustAmount = RPSControlFactory.CreateRPSOption<AdjustementBudgetChangeDialogDialogView>( "8c56e8bd-1d84-4f64-aa6b-cb0c6b1adfe5","","",this);
 
            NewAmount = RPSControlFactory.CreateRPSFormattedTextBox<AdjustementBudgetChangeDialogDialogView>("432e7b9f-5c43-4611-aa0f-e17ca37f7ef6","","",false, this);
 
            optProportionalToAmount = RPSControlFactory.CreateRPSOption<AdjustementBudgetChangeDialogDialogView>( "26530eac-2d65-455e-9ccb-9386599c604f","","",this);
 
            optProportionalToMargin = RPSControlFactory.CreateRPSOption<AdjustementBudgetChangeDialogDialogView>( "9fa1f9bd-88b1-4b24-a946-5b279475f11b","","",this);
 
            optAdjustPercent = RPSControlFactory.CreateRPSOption<AdjustementBudgetChangeDialogDialogView>( "7c62d22b-0c73-475d-bd82-e2d1c2eeceb0","","",this);
 
            NewMargin = RPSControlFactory.CreateRPSFormattedTextBox<AdjustementBudgetChangeDialogDialogView>("bc7d31ac-bb94-45b2-944c-bdb35ea7c62b","","",false, this);
 

        }
        public IRPSOption<AdjustementBudgetChangeDialogDialogView> optAdjustAmount { get; set; } 
        public IRPSTextBox<AdjustementBudgetChangeDialogDialogView> NewAmount { get; set; } 
        public IRPSOption<AdjustementBudgetChangeDialogDialogView> optProportionalToAmount { get; set; } 
        public IRPSOption<AdjustementBudgetChangeDialogDialogView> optProportionalToMargin { get; set; } 
        public IRPSOption<AdjustementBudgetChangeDialogDialogView> optAdjustPercent { get; set; } 
        public IRPSTextBox<AdjustementBudgetChangeDialogDialogView> NewMargin { get; set; } 
        public AdjustmentBudget Screen { get; set; }
        public AdjustementBudgetChangeDialogDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}