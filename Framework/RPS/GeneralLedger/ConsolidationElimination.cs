    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.GeneralLedger.ConsolidationElimination
{
    //RPS VERSION 1.0.0.0
    public partial class ConsolidationElimination:Screen
    {
        public ConsolidationElimination():base()
        {
            this.URL = "generalledger.consolidationelimination";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            ConsolidationEliminationView  = new ConsolidationEliminationView(this); 
            ConsolidationEliminationView.InitializeControls(); 
           
        }
      
            public ConsolidationEliminationView ConsolidationEliminationView {get; set; } 
    }
            
    public partial class ConsolidationEliminationView : View
    {
        public ConsolidationEliminationView(ConsolidationElimination screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            DateFrom = RPSControlFactory.CreateRPSTextBox<ConsolidationEliminationView>("163e3fea-72ee-4d84-801e-686ebeccd17b","","",false, this);
 
            DateTo = RPSControlFactory.CreateRPSTextBox<ConsolidationEliminationView>("f7160c4f-f94f-4cf0-803a-e79efd5933a6","","",false, this);
 
            Date = RPSControlFactory.CreateRPSTextBox<ConsolidationEliminationView>("88e595e8-c9eb-4cb1-850e-70f8350345b9","","",false, this);
 
            Automatic = RPSControlFactory.CreateRPSOption<ConsolidationEliminationView>( "ad5ff9df-8aa7-4c17-b100-05f1bd638750","","",this);
 
            IDVoucherSeriesBook = RPSControlFactory.CreateRPSComboBox<ConsolidationEliminationView>("d1323183-98b1-4ff7-8ecb-5fbb434d114f","","",false, this);
 
            Funds = RPSControlFactory.CreateRPSCheckBox<ConsolidationEliminationView>("4ad70926-62ce-467e-89b0-fce22545686b","","",false, this);
 
            PurchaseSales = RPSControlFactory.CreateRPSCheckBox<ConsolidationEliminationView>("169d0f3a-8279-4d3f-a3b0-64e9b6da3781","","",false, this);
 
            SupplierCustomer = RPSControlFactory.CreateRPSCheckBox<ConsolidationEliminationView>("d77839d4-85fd-4a40-aebe-cb7575239d9a","","",false, this);
 
            Voucher = RPSControlFactory.CreateRPSOption<ConsolidationEliminationView>( "f554e1b9-9493-4419-a3cf-99d2ff37d1dc","","",this);
 
            AcceptCommandButton = RPSControlFactory.CreateRPSButton<ConsolidationEliminationView>( "fb58741c-913f-496a-b89a-04efea312577","","",this);
 
            CollectionInit params_EliminationSettingsConsult = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="414debdb-2d07-4467-a2bf-0a0d0ab5cd62",CSSSelectorGrid="",XPathGrid=""};
            EliminationSettingsConsult = RPSControlFactory.RPSCreateCollectionWithGrid<EliminationSettingsConsultCollectionEditor<ConsolidationEliminationView>,ConsolidationEliminationView>( params_EliminationSettingsConsult,this);
 

        }
        public IRPSTextBox<ConsolidationEliminationView> DateFrom { get; set; } 
        public IRPSTextBox<ConsolidationEliminationView> DateTo { get; set; } 
        public IRPSTextBox<ConsolidationEliminationView> Date { get; set; } 
        public IRPSOption<ConsolidationEliminationView> Automatic { get; set; } 
        public IRPSComboBox<ConsolidationEliminationView> IDVoucherSeriesBook { get; set; } 
        public IRPSCheckbox<ConsolidationEliminationView> Funds { get; set; } 
        public IRPSCheckbox<ConsolidationEliminationView> PurchaseSales { get; set; } 
        public IRPSCheckbox<ConsolidationEliminationView> SupplierCustomer { get; set; } 
        public IRPSOption<ConsolidationEliminationView> Voucher { get; set; } 
        public IRPSButton<ConsolidationEliminationView> AcceptCommandButton { get; set; } 
        public EliminationSettingsConsultCollectionEditor<ConsolidationEliminationView> EliminationSettingsConsult { get; set; } 
        public ConsolidationElimination Screen { get; set; }
        public ConsolidationEliminationView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class EliminationSettingsConsultCollectionEditor<ConsolidationEliminationView>:RPSCollectionEditor<ConsolidationEliminationView> where ConsolidationEliminationView : class, IView
    {
        public  EliminationSettingsConsultGridView<ConsolidationEliminationView> GridView {get;set;}
    }
    public partial class EliminationSettingsConsultGridView <ConsolidationEliminationView> :  RPSGridView<ConsolidationEliminationView> where ConsolidationEliminationView : class, IView
    {
        public EliminationSettingsConsultGridView(ConsolidationEliminationView currentView)
        {
            this.WebDriver = currentView.WebDriver;          
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            Order = RPSControlFactory.CreateRPSGridFormattedTextBox<ConsolidationEliminationView>("","#414debdb-2d07-4467-a2bf-0a0d0ab5cd62 .ag-row[role='row']@ROWINDEX [col-id='cOrder']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<ConsolidationEliminationView> Order { get; set; } 
                     
    }
 
    }
  
    

}