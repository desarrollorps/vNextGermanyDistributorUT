    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.Purchase.RappelCalculation
{
    //RPS VERSION 1.0.0.0
    public partial class RappelCalculation:Screen
    {
        public RappelCalculation():base()
        {
            this.URL = "purchase.rappelcalculation";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            RappelCalculationQueryView  = new RappelCalculationQueryView(this); 
            RappelsChildDialogView  = new RappelsChildDialogView(this); 
            RappelCalculationQueryView.InitializeControls(); 
            RappelsChildDialogView.InitializeControls(); 
           
        }
      
            public RappelCalculationQueryView RappelCalculationQueryView {get; set; } 
            public RappelsChildDialogView RappelsChildDialogView {get; set; } 
    }
            
    public partial class RappelCalculationQueryView : View
    {
        public RappelCalculationQueryView(RappelCalculation screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            UIDateFrom = RPSControlFactory.CreateRPSTextBox<RappelCalculationQueryView>("cd4982d3-d577-4cab-8b4a-2af53cb35142","","",false, this);
 
            UIDateTo = RPSControlFactory.CreateRPSTextBox<RappelCalculationQueryView>("fa2494da-6a7d-43db-9c0d-97f459468895","","",false, this);
 
            UIlsIDSupplier = RPSControlFactory.CreateRPSCollectionComboBox<RappelCalculationQueryView>("b70773b7-de93-4f97-b863-25d71103f4f4","","",false, this);
 
            Monthly = RPSControlFactory.CreateRPSCheckBox<RappelCalculationQueryView>("0b99ccac-9378-4145-8e56-a00fbb2f5447","","",false, this);
 
            Bimonthly = RPSControlFactory.CreateRPSCheckBox<RappelCalculationQueryView>("430fc3e5-9db5-4179-bb3e-484d9df3caf3","","",false, this);
 
            Quarterly = RPSControlFactory.CreateRPSCheckBox<RappelCalculationQueryView>("3ee7e734-8d7c-458f-981d-12df5444d734","","",false, this);
 
            FourMonthPeriod = RPSControlFactory.CreateRPSCheckBox<RappelCalculationQueryView>("4921a077-7e9c-405b-9288-785b2ed891a9","","",false, this);
 
            HalfYearly = RPSControlFactory.CreateRPSCheckBox<RappelCalculationQueryView>("2809116d-a2ac-4bb4-8389-30b9d89de4a5","","",false, this);
 
            Annual = RPSControlFactory.CreateRPSCheckBox<RappelCalculationQueryView>("67d0cb55-50a1-4076-a3ad-b82211445e4b","","",false, this);
 
            RappelCalculationCommandButton = RPSControlFactory.CreateRPSButton<RappelCalculationQueryView>( "9a4fb811-0f41-483d-9af7-174cc7fa556f","","",this);
 
            CollectionInit params_RappelAgreementConsult = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="c760e7db-142f-4bb6-9239-8464a1a31c22",CSSSelectorGrid="",XPathGrid=""};
            RappelAgreementConsult = RPSControlFactory.RPSCreateCollectionWithGrid<RappelAgreementConsultCollectionEditor<RappelCalculationQueryView>,RappelCalculationQueryView>( params_RappelAgreementConsult,this);
 

        }
        public IRPSTextBox<RappelCalculationQueryView> UIDateFrom { get; set; } 
        public IRPSTextBox<RappelCalculationQueryView> UIDateTo { get; set; } 
        public IRPSCollectionComboBox<RappelCalculationQueryView> UIlsIDSupplier { get; set; } 
        public IRPSCheckbox<RappelCalculationQueryView> Monthly { get; set; } 
        public IRPSCheckbox<RappelCalculationQueryView> Bimonthly { get; set; } 
        public IRPSCheckbox<RappelCalculationQueryView> Quarterly { get; set; } 
        public IRPSCheckbox<RappelCalculationQueryView> FourMonthPeriod { get; set; } 
        public IRPSCheckbox<RappelCalculationQueryView> HalfYearly { get; set; } 
        public IRPSCheckbox<RappelCalculationQueryView> Annual { get; set; } 
        public IRPSButton<RappelCalculationQueryView> RappelCalculationCommandButton { get; set; } 
        public RappelAgreementConsultCollectionEditor<RappelCalculationQueryView> RappelAgreementConsult { get; set; } 
        public RappelCalculation Screen { get; set; }
        public RappelCalculationQueryView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class RappelAgreementConsultCollectionEditor<RappelCalculationQueryView>:RPSCollectionEditor<RappelCalculationQueryView> where RappelCalculationQueryView : class, IView
    {
        public  RappelAgreementConsultGridView<RappelCalculationQueryView> GridView {get;set;}
    }
    public partial class RappelAgreementConsultGridView <RappelCalculationQueryView> :  RPSGridView<RappelCalculationQueryView> where RappelCalculationQueryView : class, IView
    {
        public RappelAgreementConsultGridView(RappelCalculationQueryView currentView)
        {
            this.WebDriver = currentView.WebDriver;          
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            RappelAgreement_CodRappelAgreement = RPSControlFactory.CreateRPSGridTextBox<RappelCalculationQueryView>("","#c760e7db-142f-4bb6-9239-8464a1a31c22 .ag-row[role='row']@ROWINDEX [col-id='cRappelAgreement_CodRappelAgreement']","",false, this.CurrentView);
 
            RappelAgreement_DateFrom = RPSControlFactory.CreateRPSGridTextBox<RappelCalculationQueryView>("","#c760e7db-142f-4bb6-9239-8464a1a31c22 .ag-row[role='row']@ROWINDEX [col-id='cRappelAgreement_DateFrom']","",false, this.CurrentView);
 
            RappelAgreement_DateTo = RPSControlFactory.CreateRPSGridTextBox<RappelCalculationQueryView>("","#c760e7db-142f-4bb6-9239-8464a1a31c22 .ag-row[role='row']@ROWINDEX [col-id='cRappelAgreement_DateTo']","",false, this.CurrentView);
 
            RappelAgreement_RappelType = RPSControlFactory.CreateRPSGridTextBox<RappelCalculationQueryView>("","#c760e7db-142f-4bb6-9239-8464a1a31c22 .ag-row[role='row']@ROWINDEX [col-id='cRappelAgreement_RappelType']","",false, this.CurrentView);
 
            RappelAgreement_Periodicity = RPSControlFactory.CreateRPSGridTextBox<RappelCalculationQueryView>("","#c760e7db-142f-4bb6-9239-8464a1a31c22 .ag-row[role='row']@ROWINDEX [col-id='cRappelAgreement_Periodicity']","",false, this.CurrentView);
 
            RappelAgreement_MinimunValue = RPSControlFactory.CreateRPSGridFormattedTextBox<RappelCalculationQueryView>("","#c760e7db-142f-4bb6-9239-8464a1a31c22 .ag-row[role='row']@ROWINDEX [col-id='cRappelAgreement_MinimunValue']","",false, this.CurrentView);
 
            RappelAgreement_Percentage_Amount = RPSControlFactory.CreateRPSGridFormattedTextBox<RappelCalculationQueryView>("","#c760e7db-142f-4bb6-9239-8464a1a31c22 .ag-row[role='row']@ROWINDEX [col-id='cRappelAgreement_Percentage_Amount']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<RappelCalculationQueryView> RappelAgreement_CodRappelAgreement { get; set; } 
        public IRPSGridTextBox<RappelCalculationQueryView> RappelAgreement_DateFrom { get; set; } 
        public IRPSGridTextBox<RappelCalculationQueryView> RappelAgreement_DateTo { get; set; } 
        public IRPSGridTextBox<RappelCalculationQueryView> RappelAgreement_RappelType { get; set; } 
        public IRPSGridTextBox<RappelCalculationQueryView> RappelAgreement_Periodicity { get; set; } 
        public IRPSGridTextBox<RappelCalculationQueryView> RappelAgreement_MinimunValue { get; set; } 
        public IRPSGridTextBox<RappelCalculationQueryView> RappelAgreement_Percentage_Amount { get; set; } 
                     
    }
 
    }
  
            
    public partial class RappelsChildDialogView : View
    {
        public RappelsChildDialogView(RappelCalculation screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            CollectionInit params_RappelConsult = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="0445dd02-44f1-4054-928b-178acb78e59a",CSSSelectorGrid="",XPathGrid=""};
            RappelConsult = RPSControlFactory.RPSCreateCollectionWithGrid<RappelConsultCollectionEditor<RappelsChildDialogView>,RappelsChildDialogView>( params_RappelConsult,this);
 

        }
        public RappelConsultCollectionEditor<RappelsChildDialogView> RappelConsult { get; set; } 
        public RappelCalculation Screen { get; set; }
        public RappelsChildDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class RappelConsultCollectionEditor<RappelsChildDialogView>:RPSCollectionEditor<RappelsChildDialogView> where RappelsChildDialogView : class, IView
    {
        public  RappelConsultGridView<RappelsChildDialogView> GridView {get;set;}
    }
    public partial class RappelConsultGridView <RappelsChildDialogView> :  RPSGridView<RappelsChildDialogView> where RappelsChildDialogView : class, IView
    {
        public RappelConsultGridView(RappelsChildDialogView currentView)
        {
            this.WebDriver = currentView.WebDriver;          
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            Rappel_DateFrom = RPSControlFactory.CreateRPSGridTextBox<RappelsChildDialogView>("","#0445dd02-44f1-4054-928b-178acb78e59a .ag-row[role='row']@ROWINDEX [col-id='cRappel_DateFrom']","",false, this.CurrentView);
 
            Rappel_LastCalculationDate = RPSControlFactory.CreateRPSGridTextBox<RappelsChildDialogView>("","#0445dd02-44f1-4054-928b-178acb78e59a .ag-row[role='row']@ROWINDEX [col-id='cRappel_LastCalculationDate']","",false, this.CurrentView);
 
            Rappel_Base = RPSControlFactory.CreateRPSGridFormattedTextBox<RappelsChildDialogView>("","#0445dd02-44f1-4054-928b-178acb78e59a .ag-row[role='row']@ROWINDEX [col-id='cRappel_Base']","",false, this.CurrentView);
 
            Rappel_Amount = RPSControlFactory.CreateRPSGridFormattedTextBox<RappelsChildDialogView>("","#0445dd02-44f1-4054-928b-178acb78e59a .ag-row[role='row']@ROWINDEX [col-id='cRappel_Amount']","",false, this.CurrentView);
 
            Rappel_Quantity = RPSControlFactory.CreateRPSGridFormattedTextBox<RappelsChildDialogView>("","#0445dd02-44f1-4054-928b-178acb78e59a .ag-row[role='row']@ROWINDEX [col-id='cRappel_Quantity']","",false, this.CurrentView);
 
            Rappel_Status = RPSControlFactory.CreateRPSGridTextBox<RappelsChildDialogView>("","#0445dd02-44f1-4054-928b-178acb78e59a .ag-row[role='row']@ROWINDEX [col-id='cRappel_Status']","",false, this.CurrentView);
 
            Rappel_CodOrder = RPSControlFactory.CreateRPSGridTextBox<RappelsChildDialogView>("","#0445dd02-44f1-4054-928b-178acb78e59a .ag-row[role='row']@ROWINDEX [col-id='cRappel_CodOrder']","",false, this.CurrentView);
 
            Rappel_CodMerchandiseGift = RPSControlFactory.CreateRPSGridTextBox<RappelsChildDialogView>("","#0445dd02-44f1-4054-928b-178acb78e59a .ag-row[role='row']@ROWINDEX [col-id='cRappel_CodMerchandiseGift']","",false, this.CurrentView);
 
            Rappel_CodDeliveryNote = RPSControlFactory.CreateRPSGridTextBox<RappelsChildDialogView>("","#0445dd02-44f1-4054-928b-178acb78e59a .ag-row[role='row']@ROWINDEX [col-id='cRappel_CodDeliveryNote']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<RappelsChildDialogView> Rappel_DateFrom { get; set; } 
        public IRPSGridTextBox<RappelsChildDialogView> Rappel_LastCalculationDate { get; set; } 
        public IRPSGridTextBox<RappelsChildDialogView> Rappel_Base { get; set; } 
        public IRPSGridTextBox<RappelsChildDialogView> Rappel_Amount { get; set; } 
        public IRPSGridTextBox<RappelsChildDialogView> Rappel_Quantity { get; set; } 
        public IRPSGridTextBox<RappelsChildDialogView> Rappel_Status { get; set; } 
        public IRPSGridTextBox<RappelsChildDialogView> Rappel_CodOrder { get; set; } 
        public IRPSGridTextBox<RappelsChildDialogView> Rappel_CodMerchandiseGift { get; set; } 
        public IRPSGridTextBox<RappelsChildDialogView> Rappel_CodDeliveryNote { get; set; } 
                     
    }
 
    }
  
    

}