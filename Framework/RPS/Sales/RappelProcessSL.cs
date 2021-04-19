    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.Sales.RappelProcessSL
{
    //RPS VERSION 1.0.0.0
    public partial class RappelProcessSL:Screen
    {
        public RappelProcessSL():base()
        {
            this.URL = "sales.rappelprocesssl";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            RappelProcessSLQueryView  = new RappelProcessSLQueryView(this); 
            GenerateRappelChildDialogView  = new GenerateRappelChildDialogView(this); 
            RappelConsultChildDialogView  = new RappelConsultChildDialogView(this); 
            RappelProcessSLQueryView.InitializeControls(); 
            GenerateRappelChildDialogView.InitializeControls(); 
            RappelConsultChildDialogView.InitializeControls(); 
           
        }
      
            public RappelProcessSLQueryView RappelProcessSLQueryView {get; set; } 
            public GenerateRappelChildDialogView GenerateRappelChildDialogView {get; set; } 
            public RappelConsultChildDialogView RappelConsultChildDialogView {get; set; } 
    }
            
    public partial class RappelProcessSLQueryView : View
    {
        public RappelProcessSLQueryView(RappelProcessSL screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            OrderWithoutCharge = RPSControlFactory.CreateRPSOption<RappelProcessSLQueryView>( "75ba1c24-1b96-4e0e-a76c-52711af8c918","","",this);
 
            PromotionGift = RPSControlFactory.CreateRPSOption<RappelProcessSLQueryView>( "e8fe1eba-2531-4fec-984e-e0a7430f3a4b","","",this);
 
            DeliveryNote = RPSControlFactory.CreateRPSOption<RappelProcessSLQueryView>( "a5116493-eac4-49c8-8ff2-3dd6083cf0a9","","",this);
 
            bFinalizeDeliveryNote = RPSControlFactory.CreateRPSCheckBox<RappelProcessSLQueryView>("633353af-bf97-4863-b6a0-94163c41a115","","",false, this);
 
            BuyDeliveryNote = RPSControlFactory.CreateRPSOption<RappelProcessSLQueryView>( "b9aa2eb8-fe57-4061-8cc9-456ef8a07983","","",this);
 
            DateFrom = RPSControlFactory.CreateRPSTextBox<RappelProcessSLQueryView>("32b2bb50-e958-4b07-9691-959489055a1f","","",false, this);
 
            DateTo = RPSControlFactory.CreateRPSTextBox<RappelProcessSLQueryView>("705dca90-1e83-491b-b8b5-822b9f99b76a","","",false, this);
 
            LastCalculationDateFrom = RPSControlFactory.CreateRPSTextBox<RappelProcessSLQueryView>("4ceeb1e3-835e-432b-b9e8-ad18fd67d82a","","",false, this);
 
            LastCalculationDateTo = RPSControlFactory.CreateRPSTextBox<RappelProcessSLQueryView>("9cd384eb-038e-415a-b0d8-27cecf7d0713","","",false, this);
 
            Customers = RPSControlFactory.CreateRPSOption<RappelProcessSLQueryView>( "32c7b002-b49d-4a9e-89c0-67cacec1b2c1","","",this);
 
            Customer = RPSControlFactory.CreateRPSCollectionComboBox<RappelProcessSLQueryView>("11035157-063b-4071-a41e-da95eb589f42","","",false, this);
 
            CustomerGroup = RPSControlFactory.CreateRPSOption<RappelProcessSLQueryView>( "6b27729d-8448-4efe-8360-b1789f3f1156","","",this);
 
            CustomerGroupSL = RPSControlFactory.CreateRPSCollectionComboBox<RappelProcessSLQueryView>("1c4b3e49-3442-43f3-a193-62f7553aa3ea","","",false, this);
 
            ExecuteGenerateCommandButton = RPSControlFactory.CreateRPSButton<RappelProcessSLQueryView>( "2eeae923-5a56-4169-a158-4d5254d5ae0c","","",this);
 
            CollectionInit params_RappelSLProcessMainQuery = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="0edfb8a6-84c7-4101-94d4-cc84845fa0fa",CSSSelectorGrid="",XPathGrid=""};
            RappelSLProcessMainQuery = RPSControlFactory.RPSCreateCollectionWithGrid<RappelSLProcessMainQueryCollectionEditor<RappelProcessSLQueryView,GenerateRappelChildDialogView>,RappelProcessSLQueryView,GenerateRappelChildDialogView>( params_RappelSLProcessMainQuery,this,Screen.GenerateRappelChildDialogView);
 

        }
        public IRPSOption<RappelProcessSLQueryView> OrderWithoutCharge { get; set; } 
        public IRPSOption<RappelProcessSLQueryView> PromotionGift { get; set; } 
        public IRPSOption<RappelProcessSLQueryView> DeliveryNote { get; set; } 
        public IRPSCheckbox<RappelProcessSLQueryView> bFinalizeDeliveryNote { get; set; } 
        public IRPSOption<RappelProcessSLQueryView> BuyDeliveryNote { get; set; } 
        public IRPSTextBox<RappelProcessSLQueryView> DateFrom { get; set; } 
        public IRPSTextBox<RappelProcessSLQueryView> DateTo { get; set; } 
        public IRPSTextBox<RappelProcessSLQueryView> LastCalculationDateFrom { get; set; } 
        public IRPSTextBox<RappelProcessSLQueryView> LastCalculationDateTo { get; set; } 
        public IRPSOption<RappelProcessSLQueryView> Customers { get; set; } 
        public IRPSCollectionComboBox<RappelProcessSLQueryView> Customer { get; set; } 
        public IRPSOption<RappelProcessSLQueryView> CustomerGroup { get; set; } 
        public IRPSCollectionComboBox<RappelProcessSLQueryView> CustomerGroupSL { get; set; } 
        public IRPSButton<RappelProcessSLQueryView> ExecuteGenerateCommandButton { get; set; } 
        public RappelSLProcessMainQueryCollectionEditor<RappelProcessSLQueryView,GenerateRappelChildDialogView> RappelSLProcessMainQuery { get; set; } 
        public RappelProcessSL Screen { get; set; }
        public RappelProcessSLQueryView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class RappelSLProcessMainQueryCollectionEditor<RappelProcessSLQueryView,GenerateRappelChildDialogView>:RPSCollectionEditor<RappelProcessSLQueryView,GenerateRappelChildDialogView> where RappelProcessSLQueryView : class, IView where GenerateRappelChildDialogView : class, IView
    {
        public  RappelSLProcessMainQueryGridView<RappelProcessSLQueryView,GenerateRappelChildDialogView> GridView {get;set;}
    }
    public partial class RappelSLProcessMainQueryGridView <RappelProcessSLQueryView,GenerateRappelChildDialogView> :  RPSGridView<RappelProcessSLQueryView,GenerateRappelChildDialogView> where RappelProcessSLQueryView : class, IView where GenerateRappelChildDialogView : class, IView
    {
        public RappelSLProcessMainQueryGridView(RappelProcessSLQueryView currentView,GenerateRappelChildDialogView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            RappelAgreementSL_CodRappelAgreement = RPSControlFactory.CreateRPSGridTextBox<RappelProcessSLQueryView>("","#0edfb8a6-84c7-4101-94d4-cc84845fa0fa .ag-row[role='row']@ROWINDEX [col-id='cRappelAgreementSL_CodRappelAgreement']","",false, this.CurrentView);
 
            RappelAgreementSL_Description = RPSControlFactory.CreateRPSGridTextBox<RappelProcessSLQueryView>("","#0edfb8a6-84c7-4101-94d4-cc84845fa0fa .ag-row[role='row']@ROWINDEX [col-id='cRappelAgreementSL_Description']","",false, this.CurrentView);
 
            RappelAgreementSL_DateFrom = RPSControlFactory.CreateRPSGridTextBox<RappelProcessSLQueryView>("","#0edfb8a6-84c7-4101-94d4-cc84845fa0fa .ag-row[role='row']@ROWINDEX [col-id='cRappelAgreementSL_DateFrom']","",false, this.CurrentView);
 
            RappelAgreementSL_DateTo = RPSControlFactory.CreateRPSGridTextBox<RappelProcessSLQueryView>("","#0edfb8a6-84c7-4101-94d4-cc84845fa0fa .ag-row[role='row']@ROWINDEX [col-id='cRappelAgreementSL_DateTo']","",false, this.CurrentView);
 
            RappelAgreementSL_Periodicity = RPSControlFactory.CreateRPSGridTextBox<RappelProcessSLQueryView>("","#0edfb8a6-84c7-4101-94d4-cc84845fa0fa .ag-row[role='row']@ROWINDEX [col-id='cRappelAgreementSL_Periodicity']","",false, this.CurrentView);
 
            RappelAgreementSL_BaseApply = RPSControlFactory.CreateRPSGridTextBox<RappelProcessSLQueryView>("","#0edfb8a6-84c7-4101-94d4-cc84845fa0fa .ag-row[role='row']@ROWINDEX [col-id='cRappelAgreementSL_BaseApply']","",false, this.CurrentView);
 
            RappelAgreementSL_RappelType = RPSControlFactory.CreateRPSGridTextBox<RappelProcessSLQueryView>("","#0edfb8a6-84c7-4101-94d4-cc84845fa0fa .ag-row[role='row']@ROWINDEX [col-id='cRappelAgreementSL_RappelType']","",false, this.CurrentView);
 
            RappelAgreementSL_MinimunValue = RPSControlFactory.CreateRPSGridFormattedTextBox<RappelProcessSLQueryView>("","#0edfb8a6-84c7-4101-94d4-cc84845fa0fa .ag-row[role='row']@ROWINDEX [col-id='cRappelAgreementSL_MinimunValue']","",false, this.CurrentView);
 
            RappelAgreementSL_Percentage_Amount = RPSControlFactory.CreateRPSGridFormattedTextBox<RappelProcessSLQueryView>("","#0edfb8a6-84c7-4101-94d4-cc84845fa0fa .ag-row[role='row']@ROWINDEX [col-id='cRappelAgreementSL_Percentage_Amount']","",false, this.CurrentView);
 
            RappelAgreementSL_DocumentType = RPSControlFactory.CreateRPSGridTextBox<RappelProcessSLQueryView>("","#0edfb8a6-84c7-4101-94d4-cc84845fa0fa .ag-row[role='row']@ROWINDEX [col-id='cRappelAgreementSL_DocumentType']","",false, this.CurrentView);
 
            RappelAgreementSL_LastCalculationDate = RPSControlFactory.CreateRPSGridTextBox<RappelProcessSLQueryView>("","#0edfb8a6-84c7-4101-94d4-cc84845fa0fa .ag-row[role='row']@ROWINDEX [col-id='cRappelAgreementSL_LastCalculationDate']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<RappelProcessSLQueryView> RappelAgreementSL_CodRappelAgreement { get; set; } 
        public IRPSGridTextBox<RappelProcessSLQueryView> RappelAgreementSL_Description { get; set; } 
        public IRPSGridTextBox<RappelProcessSLQueryView> RappelAgreementSL_DateFrom { get; set; } 
        public IRPSGridTextBox<RappelProcessSLQueryView> RappelAgreementSL_DateTo { get; set; } 
        public IRPSGridTextBox<RappelProcessSLQueryView> RappelAgreementSL_Periodicity { get; set; } 
        public IRPSGridTextBox<RappelProcessSLQueryView> RappelAgreementSL_BaseApply { get; set; } 
        public IRPSGridTextBox<RappelProcessSLQueryView> RappelAgreementSL_RappelType { get; set; } 
        public IRPSGridTextBox<RappelProcessSLQueryView> RappelAgreementSL_MinimunValue { get; set; } 
        public IRPSGridTextBox<RappelProcessSLQueryView> RappelAgreementSL_Percentage_Amount { get; set; } 
        public IRPSGridTextBox<RappelProcessSLQueryView> RappelAgreementSL_DocumentType { get; set; } 
        public IRPSGridTextBox<RappelProcessSLQueryView> RappelAgreementSL_LastCalculationDate { get; set; } 
                     
    }
 
    }
  
            
    public partial class GenerateRappelChildDialogView : View
    {
        public GenerateRappelChildDialogView(RappelProcessSL screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            CodDeliveryNote = RPSControlFactory.CreateRPSTextBox<GenerateRappelChildDialogView>("90667aaf-ea1b-4c21-9b25-501309b713f6","","",false, this);
 
            CodOrder = RPSControlFactory.CreateRPSTextBox<GenerateRappelChildDialogView>("f419bb66-9dd1-4007-8df5-ab764ca3059e","","",false, this);
 

        }
        public IRPSTextBox<GenerateRappelChildDialogView> CodDeliveryNote { get; set; } 
        public IRPSTextBox<GenerateRappelChildDialogView> CodOrder { get; set; } 
        public RappelProcessSL Screen { get; set; }
        public GenerateRappelChildDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class RappelConsultChildDialogView : View
    {
        public RappelConsultChildDialogView(RappelProcessSL screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            CollectionInit params_RappelSLConsult = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="8dad5a57-6769-44a4-ac63-0a85f08a0335",CSSSelectorGrid="",XPathGrid=""};
            RappelSLConsult = RPSControlFactory.RPSCreateCollectionWithGrid<RappelSLConsultCollectionEditor<RappelConsultChildDialogView>,RappelConsultChildDialogView>( params_RappelSLConsult,this);
 

        }
        public RappelSLConsultCollectionEditor<RappelConsultChildDialogView> RappelSLConsult { get; set; } 
        public RappelProcessSL Screen { get; set; }
        public RappelConsultChildDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class RappelSLConsultCollectionEditor<RappelConsultChildDialogView>:RPSCollectionEditor<RappelConsultChildDialogView> where RappelConsultChildDialogView : class, IView
    {
        public  RappelSLConsultGridView<RappelConsultChildDialogView> GridView {get;set;}
    }
    public partial class RappelSLConsultGridView <RappelConsultChildDialogView> :  RPSGridView<RappelConsultChildDialogView> where RappelConsultChildDialogView : class, IView
    {
        public RappelSLConsultGridView(RappelConsultChildDialogView currentView)
        {
            this.WebDriver = currentView.WebDriver;          
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            RappelSL_DateFrom = RPSControlFactory.CreateRPSGridTextBox<RappelConsultChildDialogView>("","#8dad5a57-6769-44a4-ac63-0a85f08a0335 .ag-row[role='row']@ROWINDEX [col-id='cRappelSL_DateFrom']","",false, this.CurrentView);
 
            RappelSL_LastCalculationDate = RPSControlFactory.CreateRPSGridTextBox<RappelConsultChildDialogView>("","#8dad5a57-6769-44a4-ac63-0a85f08a0335 .ag-row[role='row']@ROWINDEX [col-id='cRappelSL_LastCalculationDate']","",false, this.CurrentView);
 
            RappelSL_Base = RPSControlFactory.CreateRPSGridFormattedTextBox<RappelConsultChildDialogView>("","#8dad5a57-6769-44a4-ac63-0a85f08a0335 .ag-row[role='row']@ROWINDEX [col-id='cRappelSL_Base']","",false, this.CurrentView);
 
            RappelSL_Amount = RPSControlFactory.CreateRPSGridFormattedTextBox<RappelConsultChildDialogView>("","#8dad5a57-6769-44a4-ac63-0a85f08a0335 .ag-row[role='row']@ROWINDEX [col-id='cRappelSL_Amount']","",false, this.CurrentView);
 
            RappelSL_Quantity = RPSControlFactory.CreateRPSGridFormattedTextBox<RappelConsultChildDialogView>("","#8dad5a57-6769-44a4-ac63-0a85f08a0335 .ag-row[role='row']@ROWINDEX [col-id='cRappelSL_Quantity']","",false, this.CurrentView);
 
            RappelSL_Status = RPSControlFactory.CreateRPSGridTextBox<RappelConsultChildDialogView>("","#8dad5a57-6769-44a4-ac63-0a85f08a0335 .ag-row[role='row']@ROWINDEX [col-id='cRappelSL_Status']","",false, this.CurrentView);
 
            RappelSL_CodOrder = RPSControlFactory.CreateRPSGridTextBox<RappelConsultChildDialogView>("","#8dad5a57-6769-44a4-ac63-0a85f08a0335 .ag-row[role='row']@ROWINDEX [col-id='cRappelSL_CodOrder']","",false, this.CurrentView);
 
            RappelSL_CodMerchandiseGift = RPSControlFactory.CreateRPSGridTextBox<RappelConsultChildDialogView>("","#8dad5a57-6769-44a4-ac63-0a85f08a0335 .ag-row[role='row']@ROWINDEX [col-id='cRappelSL_CodMerchandiseGift']","",false, this.CurrentView);
 
            RappelSL_CodDeliveryNote = RPSControlFactory.CreateRPSGridTextBox<RappelConsultChildDialogView>("","#8dad5a57-6769-44a4-ac63-0a85f08a0335 .ag-row[role='row']@ROWINDEX [col-id='cRappelSL_CodDeliveryNote']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<RappelConsultChildDialogView> RappelSL_DateFrom { get; set; } 
        public IRPSGridTextBox<RappelConsultChildDialogView> RappelSL_LastCalculationDate { get; set; } 
        public IRPSGridTextBox<RappelConsultChildDialogView> RappelSL_Base { get; set; } 
        public IRPSGridTextBox<RappelConsultChildDialogView> RappelSL_Amount { get; set; } 
        public IRPSGridTextBox<RappelConsultChildDialogView> RappelSL_Quantity { get; set; } 
        public IRPSGridTextBox<RappelConsultChildDialogView> RappelSL_Status { get; set; } 
        public IRPSGridTextBox<RappelConsultChildDialogView> RappelSL_CodOrder { get; set; } 
        public IRPSGridTextBox<RappelConsultChildDialogView> RappelSL_CodMerchandiseGift { get; set; } 
        public IRPSGridTextBox<RappelConsultChildDialogView> RappelSL_CodDeliveryNote { get; set; } 
                     
    }
 
    }
  
    

}