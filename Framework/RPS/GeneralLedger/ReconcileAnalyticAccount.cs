    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.GeneralLedger.ReconcileAnalyticAccount
{
    //RPS VERSION 1.0.0.0
    public partial class ReconcileAnalyticAccount:Screen
    {
        public ReconcileAnalyticAccount():base()
        {
            this.URL = "generalledger.reconcileanalyticaccount";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            ReconcileAnalyticAccountQueryView  = new ReconcileAnalyticAccountQueryView(this); 
            ReconcileAnalyticAccountQueryView.InitializeControls(); 
           
        }
      
            public ReconcileAnalyticAccountQueryView ReconcileAnalyticAccountQueryView {get; set; } 
    }
            
    public partial class ReconcileAnalyticAccountQueryView : View
    {
        public ReconcileAnalyticAccountQueryView(ReconcileAnalyticAccount screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            IDDimension = RPSControlFactory.CreateRPSComboBox<ReconcileAnalyticAccountQueryView>("1d14bf8d-b4d4-4017-bc38-55d363a989d0","","",false, this);
 
            DateFrom = RPSControlFactory.CreateRPSTextBox<ReconcileAnalyticAccountQueryView>("1f140dab-546f-43f9-a4a3-87a44d5cfbd6","","",false, this);
 
            DateTo = RPSControlFactory.CreateRPSTextBox<ReconcileAnalyticAccountQueryView>("3ad8b7ca-1dc9-4ef1-a1ca-0b544d4d3a61","","",false, this);
 
            IDAccountList = RPSControlFactory.CreateRPSCollectionComboBox<ReconcileAnalyticAccountQueryView>("acf973b1-7d66-48e0-b4cf-b3f42d94eace","","",false, this);
 
            IDAccountGroupList = RPSControlFactory.CreateRPSCollectionComboBox<ReconcileAnalyticAccountQueryView>("63e41447-5f7d-49c5-9a24-f8016898a848","","",false, this);
 
            IDAccountClusterList = RPSControlFactory.CreateRPSCollectionComboBox<ReconcileAnalyticAccountQueryView>("32bac667-2dca-420d-bf8b-b8ae7c255d4e","","",false, this);
 
            CollectionInit params_ReconcileAnalyticAccount = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="30013d8b-87f1-4584-b8f2-06234303b07b",CSSSelectorGrid="",XPathGrid=""};
            ReconcileAnalyticAccount = RPSControlFactory.RPSCreateCollectionWithGrid<ReconcileAnalyticAccountCollectionEditor<ReconcileAnalyticAccountQueryView>,ReconcileAnalyticAccountQueryView>( params_ReconcileAnalyticAccount,this);
 

        }
        public IRPSComboBox<ReconcileAnalyticAccountQueryView> IDDimension { get; set; } 
        public IRPSTextBox<ReconcileAnalyticAccountQueryView> DateFrom { get; set; } 
        public IRPSTextBox<ReconcileAnalyticAccountQueryView> DateTo { get; set; } 
        public IRPSCollectionComboBox<ReconcileAnalyticAccountQueryView> IDAccountList { get; set; } 
        public IRPSCollectionComboBox<ReconcileAnalyticAccountQueryView> IDAccountGroupList { get; set; } 
        public IRPSCollectionComboBox<ReconcileAnalyticAccountQueryView> IDAccountClusterList { get; set; } 
        public ReconcileAnalyticAccountCollectionEditor<ReconcileAnalyticAccountQueryView> ReconcileAnalyticAccount { get; set; } 
        public ReconcileAnalyticAccount Screen { get; set; }
        public ReconcileAnalyticAccountQueryView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class ReconcileAnalyticAccountCollectionEditor<ReconcileAnalyticAccountQueryView>:RPSCollectionEditor<ReconcileAnalyticAccountQueryView> where ReconcileAnalyticAccountQueryView : class, IView
    {
        public  ReconcileAnalyticAccountGridView<ReconcileAnalyticAccountQueryView> GridView {get;set;}
    }
    public partial class ReconcileAnalyticAccountGridView <ReconcileAnalyticAccountQueryView> :  RPSGridView<ReconcileAnalyticAccountQueryView> where ReconcileAnalyticAccountQueryView : class, IView
    {
        public ReconcileAnalyticAccountGridView(ReconcileAnalyticAccountQueryView currentView)
        {
            this.WebDriver = currentView.WebDriver;          
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            SignType = RPSControlFactory.CreateRPSGridEnumComboBox<ReconcileAnalyticAccountQueryView>("","#30013d8b-87f1-4584-b8f2-06234303b07b .ag-row[role='row']@ROWINDEX [col-id='cSignType']","",false, this.CurrentView);
 
            HasAccountAnlytic = RPSControlFactory.CreateRPSGridCheckBox<ReconcileAnalyticAccountQueryView>("","#30013d8b-87f1-4584-b8f2-06234303b07b .ag-row[role='row']@ROWINDEX [col-id='cHasAccountAnlytic']","",false, this.CurrentView);
 
            HasAccTransactionAnlytic = RPSControlFactory.CreateRPSGridCheckBox<ReconcileAnalyticAccountQueryView>("","#30013d8b-87f1-4584-b8f2-06234303b07b .ag-row[role='row']@ROWINDEX [col-id='cHasAccTransactionAnlytic']","",false, this.CurrentView);
 

        }
        public IRPSGridComboBox<ReconcileAnalyticAccountQueryView> SignType { get; set; } 
        public IRPSGridCheckbox<ReconcileAnalyticAccountQueryView> HasAccountAnlytic { get; set; } 
        public IRPSGridCheckbox<ReconcileAnalyticAccountQueryView> HasAccTransactionAnlytic { get; set; } 
                     
    }
 
    }
  
    

}