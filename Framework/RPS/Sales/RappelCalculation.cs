    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.Sales.RappelCalculation
{
    //RPS VERSION 1.0.0.0
    public partial class RappelCalculation:Screen
    {
        public RappelCalculation():base()
        {
            this.URL = "sales.rappelcalculation";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            RappelCalculationQueryView  = new RappelCalculationQueryView(this); 
            RappelsChildDialogView  = new RappelsChildDialogView(this); 
            RappelCalculationChildDialogView  = new RappelCalculationChildDialogView(this); 
            RappelCalculationQueryView.InitializeControls(); 
            RappelsChildDialogView.InitializeControls(); 
            RappelCalculationChildDialogView.InitializeControls(); 
           
        }
      
            public RappelCalculationQueryView RappelCalculationQueryView {get; set; } 
            public RappelsChildDialogView RappelsChildDialogView {get; set; } 
            public RappelCalculationChildDialogView RappelCalculationChildDialogView {get; set; } 
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
            UIDateFrom = RPSControlFactory.CreateRPSTextBox<RappelCalculationQueryView>("1a0bf2ba-c140-4c6a-8244-f4926e25398e","","",false, this);
 
            UIDateTo = RPSControlFactory.CreateRPSTextBox<RappelCalculationQueryView>("cc417c11-eabb-40ae-89a3-7fe7bb8f881e","","",false, this);
 
            Customer = RPSControlFactory.CreateRPSOption<RappelCalculationQueryView>( "4e17db38-4fd7-4ece-ac93-800296367bdf","","",this);
 
            UIlsIDCustomer = RPSControlFactory.CreateRPSCollectionComboBox<RappelCalculationQueryView>("e2e876c5-4576-41b7-a5c7-675d86bf6d2c","","",false, this);
 
            CustomerGroup = RPSControlFactory.CreateRPSOption<RappelCalculationQueryView>( "2837ac13-01c0-425e-84c8-93ee32a1391c","","",this);
 
            UIlsIDCustomerGroupSL = RPSControlFactory.CreateRPSCollectionComboBox<RappelCalculationQueryView>("fcd5913f-b00a-402e-a987-8768ca497d66","","",false, this);
 
            Monthly = RPSControlFactory.CreateRPSCheckBox<RappelCalculationQueryView>("28837de2-3503-45ed-a8c7-a93f2c50e04d","","",false, this);
 
            Bimonthly = RPSControlFactory.CreateRPSCheckBox<RappelCalculationQueryView>("d287b138-d8fc-4996-ae22-36b6fbc64679","","",false, this);
 
            Quarterly = RPSControlFactory.CreateRPSCheckBox<RappelCalculationQueryView>("4897e880-8530-4322-a3bd-6ea19db808a2","","",false, this);
 
            FourMonthPeriod = RPSControlFactory.CreateRPSCheckBox<RappelCalculationQueryView>("3ddd656a-f420-4aed-a741-6ce36ef2a610","","",false, this);
 
            HalfYearly = RPSControlFactory.CreateRPSCheckBox<RappelCalculationQueryView>("293d3531-4d56-4081-aeb0-1b738990ee94","","",false, this);
 
            Annual = RPSControlFactory.CreateRPSCheckBox<RappelCalculationQueryView>("d39e610c-30a6-475d-be91-243382dc42cd","","",false, this);
 
            RappelCalculationChildNavigationCommandButton = RPSControlFactory.CreateRPSButtonToView<RappelCalculationQueryView,RappelCalculationChildDialogView>("cea3ce4e-3e25-4b48-b9f3-a07afbfcf66f","","", this,Screen.RappelCalculationChildDialogView);
 
            CollectionInit params_RappelAgreementSLConsult = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="dbba0904-2503-419f-aae9-6d0f1e3b48ba",CSSSelectorGrid="",XPathGrid=""};
            RappelAgreementSLConsult = RPSControlFactory.RPSCreateCollectionWithGrid<RappelAgreementSLConsultCollectionEditor<RappelCalculationQueryView,RappelCalculationChildDialogView>,RappelCalculationQueryView,RappelCalculationChildDialogView>( params_RappelAgreementSLConsult,this,Screen.RappelCalculationChildDialogView);
 

        }
        public IRPSTextBox<RappelCalculationQueryView> UIDateFrom { get; set; } 
        public IRPSTextBox<RappelCalculationQueryView> UIDateTo { get; set; } 
        public IRPSOption<RappelCalculationQueryView> Customer { get; set; } 
        public IRPSCollectionComboBox<RappelCalculationQueryView> UIlsIDCustomer { get; set; } 
        public IRPSOption<RappelCalculationQueryView> CustomerGroup { get; set; } 
        public IRPSCollectionComboBox<RappelCalculationQueryView> UIlsIDCustomerGroupSL { get; set; } 
        public IRPSCheckbox<RappelCalculationQueryView> Monthly { get; set; } 
        public IRPSCheckbox<RappelCalculationQueryView> Bimonthly { get; set; } 
        public IRPSCheckbox<RappelCalculationQueryView> Quarterly { get; set; } 
        public IRPSCheckbox<RappelCalculationQueryView> FourMonthPeriod { get; set; } 
        public IRPSCheckbox<RappelCalculationQueryView> HalfYearly { get; set; } 
        public IRPSCheckbox<RappelCalculationQueryView> Annual { get; set; } 
        public IRPSButton<RappelCalculationQueryView,RappelCalculationChildDialogView> RappelCalculationChildNavigationCommandButton { get; set; } 
        public RappelAgreementSLConsultCollectionEditor<RappelCalculationQueryView,RappelCalculationChildDialogView> RappelAgreementSLConsult { get; set; } 
        public RappelCalculation Screen { get; set; }
        public RappelCalculationQueryView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class RappelAgreementSLConsultCollectionEditor<RappelCalculationQueryView,RappelCalculationChildDialogView>:RPSCollectionEditor<RappelCalculationQueryView,RappelCalculationChildDialogView> where RappelCalculationQueryView : class, IView where RappelCalculationChildDialogView : class, IView
    {
        public  RappelAgreementSLConsultGridView<RappelCalculationQueryView,RappelCalculationChildDialogView> GridView {get;set;}
    }
    public partial class RappelAgreementSLConsultGridView <RappelCalculationQueryView,RappelCalculationChildDialogView> :  RPSGridView<RappelCalculationQueryView,RappelCalculationChildDialogView> where RappelCalculationQueryView : class, IView where RappelCalculationChildDialogView : class, IView
    {
        public RappelAgreementSLConsultGridView(RappelCalculationQueryView currentView,RappelCalculationChildDialogView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            RappelAgreementSL_CodRappelAgreement = RPSControlFactory.CreateRPSGridTextBox<RappelCalculationQueryView>("","#dbba0904-2503-419f-aae9-6d0f1e3b48ba .ag-row[role='row']@ROWINDEX [col-id='cRappelAgreementSL_CodRappelAgreement']","",false, this.CurrentView);
 
            RappelAgreementSL_DateFrom = RPSControlFactory.CreateRPSGridTextBox<RappelCalculationQueryView>("","#dbba0904-2503-419f-aae9-6d0f1e3b48ba .ag-row[role='row']@ROWINDEX [col-id='cRappelAgreementSL_DateFrom']","",false, this.CurrentView);
 
            RappelAgreementSL_DateTo = RPSControlFactory.CreateRPSGridTextBox<RappelCalculationQueryView>("","#dbba0904-2503-419f-aae9-6d0f1e3b48ba .ag-row[role='row']@ROWINDEX [col-id='cRappelAgreementSL_DateTo']","",false, this.CurrentView);
 
            RappelAgreementSL_RappelType = RPSControlFactory.CreateRPSGridTextBox<RappelCalculationQueryView>("","#dbba0904-2503-419f-aae9-6d0f1e3b48ba .ag-row[role='row']@ROWINDEX [col-id='cRappelAgreementSL_RappelType']","",false, this.CurrentView);
 
            RappelAgreementSL_Periodicity = RPSControlFactory.CreateRPSGridTextBox<RappelCalculationQueryView>("","#dbba0904-2503-419f-aae9-6d0f1e3b48ba .ag-row[role='row']@ROWINDEX [col-id='cRappelAgreementSL_Periodicity']","",false, this.CurrentView);
 
            RappelAgreementSL_MinimunValue = RPSControlFactory.CreateRPSGridFormattedTextBox<RappelCalculationQueryView>("","#dbba0904-2503-419f-aae9-6d0f1e3b48ba .ag-row[role='row']@ROWINDEX [col-id='cRappelAgreementSL_MinimunValue']","",false, this.CurrentView);
 
            RappelAgreementSL_Percentage_Amount = RPSControlFactory.CreateRPSGridFormattedTextBox<RappelCalculationQueryView>("","#dbba0904-2503-419f-aae9-6d0f1e3b48ba .ag-row[role='row']@ROWINDEX [col-id='cRappelAgreementSL_Percentage_Amount']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<RappelCalculationQueryView> RappelAgreementSL_CodRappelAgreement { get; set; } 
        public IRPSGridTextBox<RappelCalculationQueryView> RappelAgreementSL_DateFrom { get; set; } 
        public IRPSGridTextBox<RappelCalculationQueryView> RappelAgreementSL_DateTo { get; set; } 
        public IRPSGridTextBox<RappelCalculationQueryView> RappelAgreementSL_RappelType { get; set; } 
        public IRPSGridTextBox<RappelCalculationQueryView> RappelAgreementSL_Periodicity { get; set; } 
        public IRPSGridTextBox<RappelCalculationQueryView> RappelAgreementSL_MinimunValue { get; set; } 
        public IRPSGridTextBox<RappelCalculationQueryView> RappelAgreementSL_Percentage_Amount { get; set; } 
                     
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
            CollectionInit params_RappelSLConsult = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="8811f1bd-e826-409d-9327-2e621c1f8276",CSSSelectorGrid="",XPathGrid=""};
            RappelSLConsult = RPSControlFactory.RPSCreateCollectionWithGrid<RappelSLConsultCollectionEditor<RappelsChildDialogView>,RappelsChildDialogView>( params_RappelSLConsult,this);
 

        }
        public RappelSLConsultCollectionEditor<RappelsChildDialogView> RappelSLConsult { get; set; } 
        public RappelCalculation Screen { get; set; }
        public RappelsChildDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class RappelSLConsultCollectionEditor<RappelsChildDialogView>:RPSCollectionEditor<RappelsChildDialogView> where RappelsChildDialogView : class, IView
    {
        public  RappelSLConsultGridView<RappelsChildDialogView> GridView {get;set;}
    }
    public partial class RappelSLConsultGridView <RappelsChildDialogView> :  RPSGridView<RappelsChildDialogView> where RappelsChildDialogView : class, IView
    {
        public RappelSLConsultGridView(RappelsChildDialogView currentView)
        {
            this.WebDriver = currentView.WebDriver;          
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            RappelSL_DateFrom = RPSControlFactory.CreateRPSGridTextBox<RappelsChildDialogView>("","#8811f1bd-e826-409d-9327-2e621c1f8276 .ag-row[role='row']@ROWINDEX [col-id='cRappelSL_DateFrom']","",false, this.CurrentView);
 
            RappelSL_LastCalculationDate = RPSControlFactory.CreateRPSGridTextBox<RappelsChildDialogView>("","#8811f1bd-e826-409d-9327-2e621c1f8276 .ag-row[role='row']@ROWINDEX [col-id='cRappelSL_LastCalculationDate']","",false, this.CurrentView);
 
            RappelSL_Base = RPSControlFactory.CreateRPSGridFormattedTextBox<RappelsChildDialogView>("","#8811f1bd-e826-409d-9327-2e621c1f8276 .ag-row[role='row']@ROWINDEX [col-id='cRappelSL_Base']","",false, this.CurrentView);
 
            RappelSL_Amount = RPSControlFactory.CreateRPSGridFormattedTextBox<RappelsChildDialogView>("","#8811f1bd-e826-409d-9327-2e621c1f8276 .ag-row[role='row']@ROWINDEX [col-id='cRappelSL_Amount']","",false, this.CurrentView);
 
            RappelSL_Quantity = RPSControlFactory.CreateRPSGridFormattedTextBox<RappelsChildDialogView>("","#8811f1bd-e826-409d-9327-2e621c1f8276 .ag-row[role='row']@ROWINDEX [col-id='cRappelSL_Quantity']","",false, this.CurrentView);
 
            RappelSL_Status = RPSControlFactory.CreateRPSGridTextBox<RappelsChildDialogView>("","#8811f1bd-e826-409d-9327-2e621c1f8276 .ag-row[role='row']@ROWINDEX [col-id='cRappelSL_Status']","",false, this.CurrentView);
 
            RappelSL_CodOrder = RPSControlFactory.CreateRPSGridTextBox<RappelsChildDialogView>("","#8811f1bd-e826-409d-9327-2e621c1f8276 .ag-row[role='row']@ROWINDEX [col-id='cRappelSL_CodOrder']","",false, this.CurrentView);
 
            RappelSL_CodMerchandiseGift = RPSControlFactory.CreateRPSGridTextBox<RappelsChildDialogView>("","#8811f1bd-e826-409d-9327-2e621c1f8276 .ag-row[role='row']@ROWINDEX [col-id='cRappelSL_CodMerchandiseGift']","",false, this.CurrentView);
 
            RappelSL_CodDeliveryNote = RPSControlFactory.CreateRPSGridTextBox<RappelsChildDialogView>("","#8811f1bd-e826-409d-9327-2e621c1f8276 .ag-row[role='row']@ROWINDEX [col-id='cRappelSL_CodDeliveryNote']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<RappelsChildDialogView> RappelSL_DateFrom { get; set; } 
        public IRPSGridTextBox<RappelsChildDialogView> RappelSL_LastCalculationDate { get; set; } 
        public IRPSGridTextBox<RappelsChildDialogView> RappelSL_Base { get; set; } 
        public IRPSGridTextBox<RappelsChildDialogView> RappelSL_Amount { get; set; } 
        public IRPSGridTextBox<RappelsChildDialogView> RappelSL_Quantity { get; set; } 
        public IRPSGridTextBox<RappelsChildDialogView> RappelSL_Status { get; set; } 
        public IRPSGridTextBox<RappelsChildDialogView> RappelSL_CodOrder { get; set; } 
        public IRPSGridTextBox<RappelsChildDialogView> RappelSL_CodMerchandiseGift { get; set; } 
        public IRPSGridTextBox<RappelsChildDialogView> RappelSL_CodDeliveryNote { get; set; } 
                     
    }
 
    }
  
            
    public partial class RappelCalculationChildDialogView : View
    {
        public RappelCalculationChildDialogView(RappelCalculation screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            UICalculationDate = RPSControlFactory.CreateRPSTextBox<RappelCalculationChildDialogView>("9d474a48-bde4-41df-9d22-f4a9ccda449e","","",true, this);
 
            UIRappelsValidated = RPSControlFactory.CreateRPSCheckBox<RappelCalculationChildDialogView>("df7d2ed9-4c84-4878-bb84-358e4725900c","","",true, this);
 
            UIAdjustToCompletePeriods = RPSControlFactory.CreateRPSCheckBox<RappelCalculationChildDialogView>("a5516bdd-1434-4217-bf6c-e3e65a61e948","","",true, this);
 

        }
        public IRPSTextBox<RappelCalculationChildDialogView> UICalculationDate { get; set; } 
        public IRPSCheckbox<RappelCalculationChildDialogView> UIRappelsValidated { get; set; } 
        public IRPSCheckbox<RappelCalculationChildDialogView> UIAdjustToCompletePeriods { get; set; } 
        public RappelCalculation Screen { get; set; }
        public RappelCalculationChildDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}