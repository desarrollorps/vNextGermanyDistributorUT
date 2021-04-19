    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.GeneralLedger.BankReconciliationAutomatic
{
    //RPS VERSION 1.0.0.0
    public partial class BankReconciliationAutomatic:Screen
    {
        public BankReconciliationAutomatic():base()
        {
            this.URL = "generalledger.bankreconciliationautomatic";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            BankReconciliationAutomaticView  = new BankReconciliationAutomaticView(this); 
            BankReconciliationAutomaticView.InitializeControls(); 
           
        }
      
            public BankReconciliationAutomaticView BankReconciliationAutomaticView {get; set; } 
    }
            
    public partial class BankReconciliationAutomaticView : View
    {
        public BankReconciliationAutomaticView(BankReconciliationAutomatic screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            IDBankAccountCompany = RPSControlFactory.CreateRPSComboBox<BankReconciliationAutomaticView>("29245853-3266-463d-a721-d3b9b5f00221","","",true, this);
 
            DateFrom = RPSControlFactory.CreateRPSTextBox<BankReconciliationAutomaticView>("273046e9-5d15-42cd-829d-315ace4fc5db","","",true, this);
 
            DateTo = RPSControlFactory.CreateRPSTextBox<BankReconciliationAutomaticView>("63c30894-312c-45ed-8ed3-65de4203ae81","","",true, this);
 
            StatementNumber = RPSControlFactory.CreateRPSEnumComboBox<BankReconciliationAutomaticView>("dbccfd5b-acc4-41b4-aeb8-ef686fdc2e89","","",false, this);
 
            bTryWithDateRange = RPSControlFactory.CreateRPSCheckBox<BankReconciliationAutomaticView>("83ed95aa-fbf2-41d7-9096-3464ab270092","","",false, this);
 
            AcceptCommand = RPSControlFactory.CreateRPSButton<BankReconciliationAutomaticView>( "f9a4db74-0cff-4901-af43-cba2f48bc650","","",this);
 
            CollectionInit params_AutomaticReconciliationConsult = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="c2e248a9-5cc2-4e3a-8155-13b8f0b379a4",CSSSelectorGrid="",XPathGrid=""};
            AutomaticReconciliationConsult = RPSControlFactory.RPSCreateCollectionWithGrid<AutomaticReconciliationConsultCollectionEditor<BankReconciliationAutomaticView>,BankReconciliationAutomaticView>( params_AutomaticReconciliationConsult,this);
 

        }
        public IRPSComboBox<BankReconciliationAutomaticView> IDBankAccountCompany { get; set; } 
        public IRPSTextBox<BankReconciliationAutomaticView> DateFrom { get; set; } 
        public IRPSTextBox<BankReconciliationAutomaticView> DateTo { get; set; } 
        public IRPSComboBox<BankReconciliationAutomaticView> StatementNumber { get; set; } 
        public IRPSCheckbox<BankReconciliationAutomaticView> bTryWithDateRange { get; set; } 
        public IRPSButton<BankReconciliationAutomaticView> AcceptCommand { get; set; } 
        public AutomaticReconciliationConsultCollectionEditor<BankReconciliationAutomaticView> AutomaticReconciliationConsult { get; set; } 
        public BankReconciliationAutomatic Screen { get; set; }
        public BankReconciliationAutomaticView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class AutomaticReconciliationConsultCollectionEditor<BankReconciliationAutomaticView>:RPSCollectionEditor<BankReconciliationAutomaticView> where BankReconciliationAutomaticView : class, IView
    {
        public  AutomaticReconciliationConsultGridView<BankReconciliationAutomaticView> GridView {get;set;}
    }
    public partial class AutomaticReconciliationConsultGridView <BankReconciliationAutomaticView> :  RPSGridView<BankReconciliationAutomaticView> where BankReconciliationAutomaticView : class, IView
    {
        public AutomaticReconciliationConsultGridView(BankReconciliationAutomaticView currentView)
        {
            this.WebDriver = currentView.WebDriver;          
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            LinkNavigationCommand = RPSControlFactory.CreateRPSGridButton<BankReconciliationAutomaticView>( "","#c2e248a9-5cc2-4e3a-8155-13b8f0b379a4 .ag-row[role='row']@ROWINDEX [col-id='cLinkNavigationCommand']","",this.CurrentView);
 
            Conciliated = RPSControlFactory.CreateRPSGridCheckBox<BankReconciliationAutomaticView>("","#c2e248a9-5cc2-4e3a-8155-13b8f0b379a4 .ag-row[role='row']@ROWINDEX [col-id='cConciliated']","",false, this.CurrentView);
 
            SignType = RPSControlFactory.CreateRPSGridEnumComboBox<BankReconciliationAutomaticView>("","#c2e248a9-5cc2-4e3a-8155-13b8f0b379a4 .ag-row[role='row']@ROWINDEX [col-id='cSignType']","",false, this.CurrentView);
 
            Extension = RPSControlFactory.CreateRPSGridTextBox<BankReconciliationAutomaticView>("","#c2e248a9-5cc2-4e3a-8155-13b8f0b379a4 .ag-row[role='row']@ROWINDEX [col-id='cExtension']","",false, this.CurrentView);
 

        }
        public IRPSGridButton<BankReconciliationAutomaticView> LinkNavigationCommand { get; set; } 
        public IRPSGridCheckbox<BankReconciliationAutomaticView> Conciliated { get; set; } 
        public IRPSGridComboBox<BankReconciliationAutomaticView> SignType { get; set; } 
        public IRPSGridTextBox<BankReconciliationAutomaticView> Extension { get; set; } 
                     
    }
 
    }
  
    

}