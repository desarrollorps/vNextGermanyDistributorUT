    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.Purchase.RappelProcess
{
    //RPS VERSION 1.0.0.0
    public partial class RappelProcess:Screen
    {
        public RappelProcess():base()
        {
            this.URL = "purchase.rappelprocess";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            RappelProcessQueryView  = new RappelProcessQueryView(this); 
            GenerateRappelChildDialogView  = new GenerateRappelChildDialogView(this); 
            RappelConsultChildDialogView  = new RappelConsultChildDialogView(this); 
            RappelProcessQueryView.InitializeControls(); 
            GenerateRappelChildDialogView.InitializeControls(); 
            RappelConsultChildDialogView.InitializeControls(); 
           
        }
      
            public RappelProcessQueryView RappelProcessQueryView {get; set; } 
            public GenerateRappelChildDialogView GenerateRappelChildDialogView {get; set; } 
            public RappelConsultChildDialogView RappelConsultChildDialogView {get; set; } 
    }
            
    public partial class RappelProcessQueryView : View
    {
        public RappelProcessQueryView(RappelProcess screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            OrderWithoutCharge = RPSControlFactory.CreateRPSOption<RappelProcessQueryView>( "d14b6ace-564e-4cee-8632-4aa94148cccb","","",this);
 
            PromotionGift = RPSControlFactory.CreateRPSOption<RappelProcessQueryView>( "9037c7e7-8af6-4881-9248-7e2e7bdf837d","","",this);
 
            CreditNote = RPSControlFactory.CreateRPSOption<RappelProcessQueryView>( "c60ec068-30eb-482d-91fe-d0ad7ec15b36","","",this);
 
            bFinalizeDeliveryNote = RPSControlFactory.CreateRPSCheckBox<RappelProcessQueryView>("642501bb-b79a-4e59-9489-d0b937dfe3c6","","",false, this);
 
            SalesCharge = RPSControlFactory.CreateRPSOption<RappelProcessQueryView>( "c9daad19-509f-472a-ba8d-19fd9e34a496","","",this);
 
            Supplier = RPSControlFactory.CreateRPSCollectionComboBox<RappelProcessQueryView>("2d67d595-c962-4788-aa03-dcbafffe274c","","",false, this);
 
            PeriodDateFrom = RPSControlFactory.CreateRPSTextBox<RappelProcessQueryView>("0acc022d-ffa4-443a-b2bf-40a3d491f485","","",false, this);
 
            PeriodDateTo = RPSControlFactory.CreateRPSTextBox<RappelProcessQueryView>("352948e1-93bd-4cc0-b0c4-b4d328c08cfc","","",false, this);
 
            LastCalculationDateFrom = RPSControlFactory.CreateRPSTextBox<RappelProcessQueryView>("faaab7c1-f264-4ce4-aa4d-2a9f7ecc77fb","","",false, this);
 
            LastCalculationDateTo = RPSControlFactory.CreateRPSTextBox<RappelProcessQueryView>("b7464cc1-2c32-4c6d-bb2d-7433b8ce967f","","",false, this);
 
            ExecuteGenerateCommandButton = RPSControlFactory.CreateRPSButton<RappelProcessQueryView>( "ac08a259-2f36-4c4a-886f-914edeaa2fcb","","",this);
 
            CollectionInit params_RappelProcessMainQuery = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="8cbb2084-98d2-4616-b032-22734197edd2",CSSSelectorGrid="",XPathGrid=""};
            RappelProcessMainQuery = RPSControlFactory.RPSCreateCollectionWithGrid<RappelProcessMainQueryCollectionEditor<RappelProcessQueryView,GenerateRappelChildDialogView>,RappelProcessQueryView,GenerateRappelChildDialogView>( params_RappelProcessMainQuery,this,Screen.GenerateRappelChildDialogView);
 

        }
        public IRPSOption<RappelProcessQueryView> OrderWithoutCharge { get; set; } 
        public IRPSOption<RappelProcessQueryView> PromotionGift { get; set; } 
        public IRPSOption<RappelProcessQueryView> CreditNote { get; set; } 
        public IRPSCheckbox<RappelProcessQueryView> bFinalizeDeliveryNote { get; set; } 
        public IRPSOption<RappelProcessQueryView> SalesCharge { get; set; } 
        public IRPSCollectionComboBox<RappelProcessQueryView> Supplier { get; set; } 
        public IRPSTextBox<RappelProcessQueryView> PeriodDateFrom { get; set; } 
        public IRPSTextBox<RappelProcessQueryView> PeriodDateTo { get; set; } 
        public IRPSTextBox<RappelProcessQueryView> LastCalculationDateFrom { get; set; } 
        public IRPSTextBox<RappelProcessQueryView> LastCalculationDateTo { get; set; } 
        public IRPSButton<RappelProcessQueryView> ExecuteGenerateCommandButton { get; set; } 
        public RappelProcessMainQueryCollectionEditor<RappelProcessQueryView,GenerateRappelChildDialogView> RappelProcessMainQuery { get; set; } 
        public RappelProcess Screen { get; set; }
        public RappelProcessQueryView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class RappelProcessMainQueryCollectionEditor<RappelProcessQueryView,GenerateRappelChildDialogView>:RPSCollectionEditor<RappelProcessQueryView,GenerateRappelChildDialogView> where RappelProcessQueryView : class, IView where GenerateRappelChildDialogView : class, IView
    {
        public  RappelProcessMainQueryGridView<RappelProcessQueryView,GenerateRappelChildDialogView> GridView {get;set;}
    }
    public partial class RappelProcessMainQueryGridView <RappelProcessQueryView,GenerateRappelChildDialogView> :  RPSGridView<RappelProcessQueryView,GenerateRappelChildDialogView> where RappelProcessQueryView : class, IView where GenerateRappelChildDialogView : class, IView
    {
        public RappelProcessMainQueryGridView(RappelProcessQueryView currentView,GenerateRappelChildDialogView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            RappelAgreement_CodRappelAgreement = RPSControlFactory.CreateRPSGridTextBox<RappelProcessQueryView>("","#8cbb2084-98d2-4616-b032-22734197edd2 .ag-row[role='row']@ROWINDEX [col-id='cRappelAgreement_CodRappelAgreement']","",false, this.CurrentView);
 
            RappelAgreement_DateFrom = RPSControlFactory.CreateRPSGridTextBox<RappelProcessQueryView>("","#8cbb2084-98d2-4616-b032-22734197edd2 .ag-row[role='row']@ROWINDEX [col-id='cRappelAgreement_DateFrom']","",false, this.CurrentView);
 
            RappelAgreement_DateTo = RPSControlFactory.CreateRPSGridTextBox<RappelProcessQueryView>("","#8cbb2084-98d2-4616-b032-22734197edd2 .ag-row[role='row']@ROWINDEX [col-id='cRappelAgreement_DateTo']","",false, this.CurrentView);
 
            RappelAgreement_Periodicity = RPSControlFactory.CreateRPSGridTextBox<RappelProcessQueryView>("","#8cbb2084-98d2-4616-b032-22734197edd2 .ag-row[role='row']@ROWINDEX [col-id='cRappelAgreement_Periodicity']","",false, this.CurrentView);
 
            RappelAgreement_BaseApply = RPSControlFactory.CreateRPSGridTextBox<RappelProcessQueryView>("","#8cbb2084-98d2-4616-b032-22734197edd2 .ag-row[role='row']@ROWINDEX [col-id='cRappelAgreement_BaseApply']","",false, this.CurrentView);
 
            RappelAgreement_RappelType = RPSControlFactory.CreateRPSGridTextBox<RappelProcessQueryView>("","#8cbb2084-98d2-4616-b032-22734197edd2 .ag-row[role='row']@ROWINDEX [col-id='cRappelAgreement_RappelType']","",false, this.CurrentView);
 
            RappelAgreement_MinimunValue = RPSControlFactory.CreateRPSGridFormattedTextBox<RappelProcessQueryView>("","#8cbb2084-98d2-4616-b032-22734197edd2 .ag-row[role='row']@ROWINDEX [col-id='cRappelAgreement_MinimunValue']","",false, this.CurrentView);
 
            RappelAgreement_Percentage_Amount = RPSControlFactory.CreateRPSGridFormattedTextBox<RappelProcessQueryView>("","#8cbb2084-98d2-4616-b032-22734197edd2 .ag-row[role='row']@ROWINDEX [col-id='cRappelAgreement_Percentage_Amount']","",false, this.CurrentView);
 
            RappelAgreement_DocumentType = RPSControlFactory.CreateRPSGridTextBox<RappelProcessQueryView>("","#8cbb2084-98d2-4616-b032-22734197edd2 .ag-row[role='row']@ROWINDEX [col-id='cRappelAgreement_DocumentType']","",false, this.CurrentView);
 
            RappelAgreement_LastCalculationDate = RPSControlFactory.CreateRPSGridTextBox<RappelProcessQueryView>("","#8cbb2084-98d2-4616-b032-22734197edd2 .ag-row[role='row']@ROWINDEX [col-id='cRappelAgreement_LastCalculationDate']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<RappelProcessQueryView> RappelAgreement_CodRappelAgreement { get; set; } 
        public IRPSGridTextBox<RappelProcessQueryView> RappelAgreement_DateFrom { get; set; } 
        public IRPSGridTextBox<RappelProcessQueryView> RappelAgreement_DateTo { get; set; } 
        public IRPSGridTextBox<RappelProcessQueryView> RappelAgreement_Periodicity { get; set; } 
        public IRPSGridTextBox<RappelProcessQueryView> RappelAgreement_BaseApply { get; set; } 
        public IRPSGridTextBox<RappelProcessQueryView> RappelAgreement_RappelType { get; set; } 
        public IRPSGridTextBox<RappelProcessQueryView> RappelAgreement_MinimunValue { get; set; } 
        public IRPSGridTextBox<RappelProcessQueryView> RappelAgreement_Percentage_Amount { get; set; } 
        public IRPSGridTextBox<RappelProcessQueryView> RappelAgreement_DocumentType { get; set; } 
        public IRPSGridTextBox<RappelProcessQueryView> RappelAgreement_LastCalculationDate { get; set; } 
                     
    }
 
    }
  
            
    public partial class GenerateRappelChildDialogView : View
    {
        public GenerateRappelChildDialogView(RappelProcess screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            CodDeliveryNote = RPSControlFactory.CreateRPSTextBox<GenerateRappelChildDialogView>("953c7219-84e4-4995-8f54-d58e31933078","","",false, this);
 

        }
        public IRPSTextBox<GenerateRappelChildDialogView> CodDeliveryNote { get; set; } 
        public RappelProcess Screen { get; set; }
        public GenerateRappelChildDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class RappelConsultChildDialogView : View
    {
        public RappelConsultChildDialogView(RappelProcess screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            CollectionInit params_RappelConsult = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="cdd752f2-e858-4317-a321-45d36f80a00a",CSSSelectorGrid="",XPathGrid=""};
            RappelConsult = RPSControlFactory.RPSCreateCollectionWithGrid<RappelConsultCollectionEditor<RappelConsultChildDialogView>,RappelConsultChildDialogView>( params_RappelConsult,this);
 

        }
        public RappelConsultCollectionEditor<RappelConsultChildDialogView> RappelConsult { get; set; } 
        public RappelProcess Screen { get; set; }
        public RappelConsultChildDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class RappelConsultCollectionEditor<RappelConsultChildDialogView>:RPSCollectionEditor<RappelConsultChildDialogView> where RappelConsultChildDialogView : class, IView
    {
        public  RappelConsultGridView<RappelConsultChildDialogView> GridView {get;set;}
    }
    public partial class RappelConsultGridView <RappelConsultChildDialogView> :  RPSGridView<RappelConsultChildDialogView> where RappelConsultChildDialogView : class, IView
    {
        public RappelConsultGridView(RappelConsultChildDialogView currentView)
        {
            this.WebDriver = currentView.WebDriver;          
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            Rappel_DateFrom = RPSControlFactory.CreateRPSGridTextBox<RappelConsultChildDialogView>("","#cdd752f2-e858-4317-a321-45d36f80a00a .ag-row[role='row']@ROWINDEX [col-id='cRappel_DateFrom']","",false, this.CurrentView);
 
            Rappel_LastCalculationDate = RPSControlFactory.CreateRPSGridTextBox<RappelConsultChildDialogView>("","#cdd752f2-e858-4317-a321-45d36f80a00a .ag-row[role='row']@ROWINDEX [col-id='cRappel_LastCalculationDate']","",false, this.CurrentView);
 
            Rappel_Base = RPSControlFactory.CreateRPSGridFormattedTextBox<RappelConsultChildDialogView>("","#cdd752f2-e858-4317-a321-45d36f80a00a .ag-row[role='row']@ROWINDEX [col-id='cRappel_Base']","",false, this.CurrentView);
 
            Rappel_Amount = RPSControlFactory.CreateRPSGridFormattedTextBox<RappelConsultChildDialogView>("","#cdd752f2-e858-4317-a321-45d36f80a00a .ag-row[role='row']@ROWINDEX [col-id='cRappel_Amount']","",false, this.CurrentView);
 
            Rappel_Quantity = RPSControlFactory.CreateRPSGridFormattedTextBox<RappelConsultChildDialogView>("","#cdd752f2-e858-4317-a321-45d36f80a00a .ag-row[role='row']@ROWINDEX [col-id='cRappel_Quantity']","",false, this.CurrentView);
 
            Rappel_Status = RPSControlFactory.CreateRPSGridTextBox<RappelConsultChildDialogView>("","#cdd752f2-e858-4317-a321-45d36f80a00a .ag-row[role='row']@ROWINDEX [col-id='cRappel_Status']","",false, this.CurrentView);
 
            Rappel_CodOrder = RPSControlFactory.CreateRPSGridTextBox<RappelConsultChildDialogView>("","#cdd752f2-e858-4317-a321-45d36f80a00a .ag-row[role='row']@ROWINDEX [col-id='cRappel_CodOrder']","",false, this.CurrentView);
 
            Rappel_CodMerchandiseGift = RPSControlFactory.CreateRPSGridTextBox<RappelConsultChildDialogView>("","#cdd752f2-e858-4317-a321-45d36f80a00a .ag-row[role='row']@ROWINDEX [col-id='cRappel_CodMerchandiseGift']","",false, this.CurrentView);
 
            Rappel_CodDeliveryNote = RPSControlFactory.CreateRPSGridTextBox<RappelConsultChildDialogView>("","#cdd752f2-e858-4317-a321-45d36f80a00a .ag-row[role='row']@ROWINDEX [col-id='cRappel_CodDeliveryNote']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<RappelConsultChildDialogView> Rappel_DateFrom { get; set; } 
        public IRPSGridTextBox<RappelConsultChildDialogView> Rappel_LastCalculationDate { get; set; } 
        public IRPSGridTextBox<RappelConsultChildDialogView> Rappel_Base { get; set; } 
        public IRPSGridTextBox<RappelConsultChildDialogView> Rappel_Amount { get; set; } 
        public IRPSGridTextBox<RappelConsultChildDialogView> Rappel_Quantity { get; set; } 
        public IRPSGridTextBox<RappelConsultChildDialogView> Rappel_Status { get; set; } 
        public IRPSGridTextBox<RappelConsultChildDialogView> Rappel_CodOrder { get; set; } 
        public IRPSGridTextBox<RappelConsultChildDialogView> Rappel_CodMerchandiseGift { get; set; } 
        public IRPSGridTextBox<RappelConsultChildDialogView> Rappel_CodDeliveryNote { get; set; } 
                     
    }
 
    }
  
    

}