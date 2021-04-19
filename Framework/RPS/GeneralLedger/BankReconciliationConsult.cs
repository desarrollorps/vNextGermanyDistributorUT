    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.GeneralLedger.BankReconciliationConsult
{
    //RPS VERSION 1.0.0.0
    public partial class BankReconciliationConsult:Screen
    {
        public BankReconciliationConsult():base()
        {
            this.URL = "generalledger.bankreconciliationconsult";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            BankReconciliationConsultQueryView  = new BankReconciliationConsultQueryView(this); 
            BankReconciliationConsultQueryView.InitializeControls(); 
           
        }
      
            public BankReconciliationConsultQueryView BankReconciliationConsultQueryView {get; set; } 
    }
            
    public partial class BankReconciliationConsultQueryView : View
    {
        public BankReconciliationConsultQueryView(BankReconciliationConsult screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            IDBankAccountCompany = RPSControlFactory.CreateRPSComboBox<BankReconciliationConsultQueryView>("3218deda-cd6c-4d8d-b0ca-8b0caf194199","","",false, this);
 
            DateFrom = RPSControlFactory.CreateRPSTextBox<BankReconciliationConsultQueryView>("006f48b9-b592-4a18-a806-c55abca8513d","","",false, this);
 
            DateTo = RPSControlFactory.CreateRPSTextBox<BankReconciliationConsultQueryView>("61c717a2-f145-4da1-a206-d7eb1a83fac4","","",false, this);
 
            StatementNumber = RPSControlFactory.CreateRPSEnumComboBox<BankReconciliationConsultQueryView>("ac25d945-1816-401e-8672-10c602860e2f","","",false, this);
 
            IDCurrency = RPSControlFactory.CreateRPSComboBox<BankReconciliationConsultQueryView>("4b397b10-288f-48c7-9be6-7369456963ac","","",false, this);
 
            InitialDate = RPSControlFactory.CreateRPSTextBox<BankReconciliationConsultQueryView>("838d832d-63ba-4fa1-8424-af14ee75d958","","",false, this);
 
            InitialBalance = RPSControlFactory.CreateRPSFormattedTextBox<BankReconciliationConsultQueryView>("9402f248-f736-4da1-9743-583df8ac690f","","",false, this);
 
            EndDate = RPSControlFactory.CreateRPSTextBox<BankReconciliationConsultQueryView>("fad5d121-570d-45a0-96c5-b2a20b512716","","",false, this);
 
            EndBalance = RPSControlFactory.CreateRPSFormattedTextBox<BankReconciliationConsultQueryView>("9be45382-4aa7-44c5-9f3a-c5ae56df4548","","",false, this);
 
            DiffBalance = RPSControlFactory.CreateRPSFormattedTextBox<BankReconciliationConsultQueryView>("b4598a09-df3a-4233-b4d2-f7424a54e0dc","","",false, this);
 
            SumMovement = RPSControlFactory.CreateRPSFormattedTextBox<BankReconciliationConsultQueryView>("46bc68b7-9873-44c4-bc01-259aff31e1ae","","",false, this);
 
            ReportCommandButton = RPSControlFactory.CreateRPSButton<BankReconciliationConsultQueryView>( "e82844c6-5310-4ad7-b227-ca7ca23e7c8b","","",this);
 
            CollectionInit params_BankReconciliationConsult = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="2b03fa15-2f0a-469e-a8f8-7af85afca58c",CSSSelectorGrid="",XPathGrid=""};
            BankReconciliationConsult = RPSControlFactory.RPSCreateCollectionWithGrid<BankReconciliationConsultCollectionEditor<BankReconciliationConsultQueryView>,BankReconciliationConsultQueryView>( params_BankReconciliationConsult,this);
 

        }
        public IRPSComboBox<BankReconciliationConsultQueryView> IDBankAccountCompany { get; set; } 
        public IRPSTextBox<BankReconciliationConsultQueryView> DateFrom { get; set; } 
        public IRPSTextBox<BankReconciliationConsultQueryView> DateTo { get; set; } 
        public IRPSComboBox<BankReconciliationConsultQueryView> StatementNumber { get; set; } 
        public IRPSComboBox<BankReconciliationConsultQueryView> IDCurrency { get; set; } 
        public IRPSTextBox<BankReconciliationConsultQueryView> InitialDate { get; set; } 
        public IRPSTextBox<BankReconciliationConsultQueryView> InitialBalance { get; set; } 
        public IRPSTextBox<BankReconciliationConsultQueryView> EndDate { get; set; } 
        public IRPSTextBox<BankReconciliationConsultQueryView> EndBalance { get; set; } 
        public IRPSTextBox<BankReconciliationConsultQueryView> DiffBalance { get; set; } 
        public IRPSTextBox<BankReconciliationConsultQueryView> SumMovement { get; set; } 
        public IRPSButton<BankReconciliationConsultQueryView> ReportCommandButton { get; set; } 
        public BankReconciliationConsultCollectionEditor<BankReconciliationConsultQueryView> BankReconciliationConsult { get; set; } 
        public BankReconciliationConsult Screen { get; set; }
        public BankReconciliationConsultQueryView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class BankReconciliationConsultCollectionEditor<BankReconciliationConsultQueryView>:RPSCollectionEditor<BankReconciliationConsultQueryView> where BankReconciliationConsultQueryView : class, IView
    {
        public  BankReconciliationConsultGridView<BankReconciliationConsultQueryView> GridView {get;set;}
    }
    public partial class BankReconciliationConsultGridView <BankReconciliationConsultQueryView> :  RPSGridView<BankReconciliationConsultQueryView> where BankReconciliationConsultQueryView : class, IView
    {
        public BankReconciliationConsultGridView(BankReconciliationConsultQueryView currentView)
        {
            this.WebDriver = currentView.WebDriver;          
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            BankReconciliation_Status = RPSControlFactory.CreateRPSGridTextBox<BankReconciliationConsultQueryView>("","#2b03fa15-2f0a-469e-a8f8-7af85afca58c .ag-row[role='row']@ROWINDEX [col-id='cBankReconciliation_Status']","",false, this.CurrentView);
 
            BankReconciliation_Action = RPSControlFactory.CreateRPSGridTextBox<BankReconciliationConsultQueryView>("","#2b03fa15-2f0a-469e-a8f8-7af85afca58c .ag-row[role='row']@ROWINDEX [col-id='cBankReconciliation_Action']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<BankReconciliationConsultQueryView> BankReconciliation_Status { get; set; } 
        public IRPSGridTextBox<BankReconciliationConsultQueryView> BankReconciliation_Action { get; set; } 
                     
    }
 
    }
  
    

}