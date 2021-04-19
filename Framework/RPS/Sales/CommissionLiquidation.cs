    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.Sales.CommissionLiquidation
{
    //RPS VERSION 1.0.0.0
    public partial class CommissionLiquidation:Screen
    {
        public CommissionLiquidation():base()
        {
            this.URL = "sales.commissionliquidation";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            CommissionLiquidationQueryView  = new CommissionLiquidationQueryView(this); 
            UpdateChildViewModelDialogView  = new UpdateChildViewModelDialogView(this); 
            CommissionLiquidationQueryView.InitializeControls(); 
            UpdateChildViewModelDialogView.InitializeControls(); 
           
        }
      
            public CommissionLiquidationQueryView CommissionLiquidationQueryView {get; set; } 
            public UpdateChildViewModelDialogView UpdateChildViewModelDialogView {get; set; } 
    }
            
    public partial class CommissionLiquidationQueryView : View
    {
        public CommissionLiquidationQueryView(CommissionLiquidation screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            CommercialAgentSL = RPSControlFactory.CreateRPSCollectionComboBox<CommissionLiquidationQueryView>("63ff4883-f843-4bb1-8f15-edb42fd692aa","","",false, this);
 
            DateFrom = RPSControlFactory.CreateRPSTextBox<CommissionLiquidationQueryView>("5fcd759c-12b6-4648-8f06-03498bff27bb","","",false, this);
 
            DateTo = RPSControlFactory.CreateRPSTextBox<CommissionLiquidationQueryView>("dfef5eb4-2d65-4d8b-8d58-f7dea0360553","","",false, this);
 
            TotalCollectedInvoices = RPSControlFactory.CreateRPSCheckBox<CommissionLiquidationQueryView>("24df9024-557f-4622-ae7d-6a633bce9502","","",false, this);
 
            Liquidationdate = RPSControlFactory.CreateRPSTextBox<CommissionLiquidationQueryView>("201fce44-56d7-496d-b6ae-f0ae9077cefe","","",false, this);
 
            PaymentDateFrom = RPSControlFactory.CreateRPSTextBox<CommissionLiquidationQueryView>("de7a1b1f-1c00-4e15-8722-6874ba109b10","","",false, this);
 
            PaymentDateTo = RPSControlFactory.CreateRPSTextBox<CommissionLiquidationQueryView>("a0cc45a6-43fd-4b36-ae78-3fc6722d0ddb","","",false, this);
 
            Date = RPSControlFactory.CreateRPSTextBox<CommissionLiquidationQueryView>("b60fdaab-b15f-49d8-b510-422be948389d","","",false, this);
 
            PaymentDate = RPSControlFactory.CreateRPSTextBox<CommissionLiquidationQueryView>("65c727eb-6015-4a7b-b19a-115e7c94b123","","",false, this);
 
            UpdateChildViewModelNavigationCommandButton = RPSControlFactory.CreateRPSButtonToView<CommissionLiquidationQueryView,UpdateChildViewModelDialogView>("5de303ea-9ba7-431f-91b1-5a438ba42960","","", this,Screen.UpdateChildViewModelDialogView);
 
            CollectionInit params_CommissionLiquidationQuery = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="921ed07d-4068-497f-9f4d-b6cdc470fb44",CSSSelectorGrid="",XPathGrid=""};
            CommissionLiquidationQuery = RPSControlFactory.RPSCreateCollectionWithGrid<CommissionLiquidationQueryCollectionEditor<CommissionLiquidationQueryView,UpdateChildViewModelDialogView>,CommissionLiquidationQueryView,UpdateChildViewModelDialogView>( params_CommissionLiquidationQuery,this,Screen.UpdateChildViewModelDialogView);
 

        }
        public IRPSCollectionComboBox<CommissionLiquidationQueryView> CommercialAgentSL { get; set; } 
        public IRPSTextBox<CommissionLiquidationQueryView> DateFrom { get; set; } 
        public IRPSTextBox<CommissionLiquidationQueryView> DateTo { get; set; } 
        public IRPSCheckbox<CommissionLiquidationQueryView> TotalCollectedInvoices { get; set; } 
        public IRPSTextBox<CommissionLiquidationQueryView> Liquidationdate { get; set; } 
        public IRPSTextBox<CommissionLiquidationQueryView> PaymentDateFrom { get; set; } 
        public IRPSTextBox<CommissionLiquidationQueryView> PaymentDateTo { get; set; } 
        public IRPSTextBox<CommissionLiquidationQueryView> Date { get; set; } 
        public IRPSTextBox<CommissionLiquidationQueryView> PaymentDate { get; set; } 
        public IRPSButton<CommissionLiquidationQueryView,UpdateChildViewModelDialogView> UpdateChildViewModelNavigationCommandButton { get; set; } 
        public CommissionLiquidationQueryCollectionEditor<CommissionLiquidationQueryView,UpdateChildViewModelDialogView> CommissionLiquidationQuery { get; set; } 
        public CommissionLiquidation Screen { get; set; }
        public CommissionLiquidationQueryView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class CommissionLiquidationQueryCollectionEditor<CommissionLiquidationQueryView,UpdateChildViewModelDialogView>:RPSCollectionEditor<CommissionLiquidationQueryView,UpdateChildViewModelDialogView> where CommissionLiquidationQueryView : class, IView where UpdateChildViewModelDialogView : class, IView
    {
        public  CommissionLiquidationQueryGridView<CommissionLiquidationQueryView,UpdateChildViewModelDialogView> GridView {get;set;}
    }
    public partial class CommissionLiquidationQueryGridView <CommissionLiquidationQueryView,UpdateChildViewModelDialogView> :  RPSGridView<CommissionLiquidationQueryView,UpdateChildViewModelDialogView> where CommissionLiquidationQueryView : class, IView where UpdateChildViewModelDialogView : class, IView
    {
        public CommissionLiquidationQueryGridView(CommissionLiquidationQueryView currentView,UpdateChildViewModelDialogView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            Date = RPSControlFactory.CreateRPSGridTextBox<CommissionLiquidationQueryView>("","#921ed07d-4068-497f-9f4d-b6cdc470fb44 .ag-row[role='row']@ROWINDEX [col-id='cDate']","",false, this.CurrentView);
 
            PaymentDate = RPSControlFactory.CreateRPSGridTextBox<CommissionLiquidationQueryView>("","#921ed07d-4068-497f-9f4d-b6cdc470fb44 .ag-row[role='row']@ROWINDEX [col-id='cPaymentDate']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<CommissionLiquidationQueryView> Date { get; set; } 
        public IRPSGridTextBox<CommissionLiquidationQueryView> PaymentDate { get; set; } 
                     
    }
 
    }
  
            
    public partial class UpdateChildViewModelDialogView : View
    {
        public UpdateChildViewModelDialogView(CommissionLiquidation screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            GenerateOrder = RPSControlFactory.CreateRPSCheckBox<UpdateChildViewModelDialogView>("a8f7b75c-d439-4e67-ada8-f7f9fd18808d","","",false, this);
 
            OrderDate = RPSControlFactory.CreateRPSTextBox<UpdateChildViewModelDialogView>("daf375d2-d05d-4bd5-9e4d-10bc89ff3661","","",false, this);
 

        }
        public IRPSCheckbox<UpdateChildViewModelDialogView> GenerateOrder { get; set; } 
        public IRPSTextBox<UpdateChildViewModelDialogView> OrderDate { get; set; } 
        public CommissionLiquidation Screen { get; set; }
        public UpdateChildViewModelDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}