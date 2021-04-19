    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.TaxModel.Intrastat
{
    //RPS VERSION 1.0.0.0
    public partial class Intrastat:Screen
    {
        public Intrastat():base()
        {
            this.URL = "taxmodel.intrastat";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            IntrastatView  = new IntrastatView(this); 
            IntrastatView.InitializeControls(); 
           
        }
      
            public IntrastatView IntrastatView {get; set; } 
    }
            
    public partial class IntrastatView : View
    {
        public IntrastatView(Intrastat screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            Exercise = RPSControlFactory.CreateRPSFormattedTextBox<IntrastatView>("39d5ff2e-6269-48cc-840c-4f8d92c92793","","",true, this);
 
            Month = RPSControlFactory.CreateRPSEnumComboBox<IntrastatView>("fc537f46-ee72-40f5-a930-aa2e33bea2f3","","",true, this);
 
            IncludeSales = RPSControlFactory.CreateRPSCheckBox<IntrastatView>("0d475fd1-50af-4d61-8f95-47e02828d410","","",false, this);
 
            IncludePurchases = RPSControlFactory.CreateRPSCheckBox<IntrastatView>("f96a3a50-1e1b-44f5-8fb6-aea302958c5a","","",false, this);
 
            ExcludeReturns = RPSControlFactory.CreateRPSCheckBox<IntrastatView>("afb1ee06-d823-4d1d-afb9-bb1d5636400f","","",false, this);
 
            UseAccountingDateForPurchases = RPSControlFactory.CreateRPSCheckBox<IntrastatView>("d6deb1b3-424b-4296-a14f-1e4d3392b1c1","","",false, this);
 
            ExecuteSetModIntrastatDataStorage = RPSControlFactory.CreateRPSButton<IntrastatView>( "c5e1d5d0-50f7-4d51-89ea-06c59a2c0182","","",this);
 
            Flow = RPSControlFactory.CreateRPSEnumComboBox<IntrastatView>("76f38f6b-4fad-4131-86b7-1f671e5beaff","","",false, this);
 
            CodCountry = RPSControlFactory.CreateRPSComboBox<IntrastatView>("04e43692-734c-4163-8891-ead00e79b476","","",false, this);
 
            CodStatistics = RPSControlFactory.CreateRPSTextBox<IntrastatView>("d8b64480-cb95-44fd-bc4a-a6080225a5bb","","",false, this);
 
            NetMass = RPSControlFactory.CreateRPSFormattedTextBox<IntrastatView>("591bcd95-c621-4e32-bda8-ece4b2d5ec27","","",false, this);
 
            ValueAmount = RPSControlFactory.CreateRPSFormattedTextBox<IntrastatView>("34d8ffa8-ccd5-4d3c-888d-30fe0e21bda2","","",false, this);
 
            PercentValue = RPSControlFactory.CreateRPSFormattedTextBox<IntrastatView>("d8b4799f-3285-4832-8963-97d793b24078","","",false, this);
 
            DeliveryTermCode = RPSControlFactory.CreateRPSComboBox<IntrastatView>("291119b6-c7be-4aa2-ab33-cbdf5efa2d58","","",false, this);
 
            BusinessTypeCode = RPSControlFactory.CreateRPSComboBox<IntrastatView>("07894ad4-b714-4cff-bda0-a15c0d9a0e0d","","",false, this);
 
            TransportMethodCode = RPSControlFactory.CreateRPSComboBox<IntrastatView>("4fef802a-a67d-489a-94eb-1129579f41a7","","",false, this);
 
            StatisticsRegime = RPSControlFactory.CreateRPSEnumComboBox<IntrastatView>("811c4be4-d7f5-47f2-b7aa-b7b299cda870","","",false, this);
 
            IDCounty = RPSControlFactory.CreateRPSComboBox<IntrastatView>("a258436d-9b18-4f85-9cd8-beb65b36b4bc","","",false, this);
 
            HarbourAirportCode = RPSControlFactory.CreateRPSComboBox<IntrastatView>("0873ec4c-e905-4877-ba66-358c57aa2cde","","",false, this);
 
            CodCountryOrigin = RPSControlFactory.CreateRPSComboBox<IntrastatView>("6275fc46-2c04-4d3f-a009-197ece4c975b","","",false, this);
 
            RequiresSupplementUnits = RPSControlFactory.CreateRPSCheckBox<IntrastatView>("0d02e5d7-7615-45cb-bab6-4de7a719d364","","",false, this);
 
            IDUnitSupplement = RPSControlFactory.CreateRPSComboBox<IntrastatView>("737a1c82-c1ae-4592-8bb9-c8c180523a76","","",false, this);
 
            SupplementUnits = RPSControlFactory.CreateRPSFormattedTextBox<IntrastatView>("ca6d2b25-08a7-4880-a982-68ad4f496800","","",false, this);
 
            CodDeliveryNote = RPSControlFactory.CreateRPSTextBox<IntrastatView>("bbb110a4-7492-48c8-99ed-a9faf5bfa436","","",false, this);
 
            CodInvoice = RPSControlFactory.CreateRPSTextBox<IntrastatView>("706d41a4-637f-411f-8e0b-f403bd99302e","","",false, this);
 
            PreGenerateModIntrastatButton = RPSControlFactory.CreateRPSButton<IntrastatView>( "9898733e-bb47-40fe-b894-d3e871a02f8a","","",this);
 
            CollectionInit params_GetModIntrastatData = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="2dba14aa-8bdc-4f12-acdf-cfc3869d4649",CSSSelectorGrid="",XPathGrid=""};
            GetModIntrastatData = RPSControlFactory.RPSCreateCollectionWithGrid<GetModIntrastatDataCollectionEditor<IntrastatView>,IntrastatView>( params_GetModIntrastatData,this);
 

        }
        public IRPSTextBox<IntrastatView> Exercise { get; set; } 
        public IRPSComboBox<IntrastatView> Month { get; set; } 
        public IRPSCheckbox<IntrastatView> IncludeSales { get; set; } 
        public IRPSCheckbox<IntrastatView> IncludePurchases { get; set; } 
        public IRPSCheckbox<IntrastatView> ExcludeReturns { get; set; } 
        public IRPSCheckbox<IntrastatView> UseAccountingDateForPurchases { get; set; } 
        public IRPSButton<IntrastatView> ExecuteSetModIntrastatDataStorage { get; set; } 
        public IRPSComboBox<IntrastatView> Flow { get; set; } 
        public IRPSComboBox<IntrastatView> CodCountry { get; set; } 
        public IRPSTextBox<IntrastatView> CodStatistics { get; set; } 
        public IRPSTextBox<IntrastatView> NetMass { get; set; } 
        public IRPSTextBox<IntrastatView> ValueAmount { get; set; } 
        public IRPSTextBox<IntrastatView> PercentValue { get; set; } 
        public IRPSComboBox<IntrastatView> DeliveryTermCode { get; set; } 
        public IRPSComboBox<IntrastatView> BusinessTypeCode { get; set; } 
        public IRPSComboBox<IntrastatView> TransportMethodCode { get; set; } 
        public IRPSComboBox<IntrastatView> StatisticsRegime { get; set; } 
        public IRPSComboBox<IntrastatView> IDCounty { get; set; } 
        public IRPSComboBox<IntrastatView> HarbourAirportCode { get; set; } 
        public IRPSComboBox<IntrastatView> CodCountryOrigin { get; set; } 
        public IRPSCheckbox<IntrastatView> RequiresSupplementUnits { get; set; } 
        public IRPSComboBox<IntrastatView> IDUnitSupplement { get; set; } 
        public IRPSTextBox<IntrastatView> SupplementUnits { get; set; } 
        public IRPSTextBox<IntrastatView> CodDeliveryNote { get; set; } 
        public IRPSTextBox<IntrastatView> CodInvoice { get; set; } 
        public IRPSButton<IntrastatView> PreGenerateModIntrastatButton { get; set; } 
        public GetModIntrastatDataCollectionEditor<IntrastatView> GetModIntrastatData { get; set; } 
        public Intrastat Screen { get; set; }
        public IntrastatView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class GetModIntrastatDataCollectionEditor<IntrastatView>:RPSCollectionEditor<IntrastatView> where IntrastatView : class, IView
    {
        public  GetModIntrastatDataGridView<IntrastatView> GridView {get;set;}
    }
    public partial class GetModIntrastatDataGridView <IntrastatView> :  RPSGridView<IntrastatView> where IntrastatView : class, IView
    {
        public GetModIntrastatDataGridView(IntrastatView currentView)
        {
            this.WebDriver = currentView.WebDriver;          
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            Error = RPSControlFactory.CreateRPSGridTextBox<IntrastatView>("","#2dba14aa-8bdc-4f12-acdf-cfc3869d4649 .ag-row[role='row']@ROWINDEX [col-id='cError']","",false, this.CurrentView);
 
            DeleteRow = RPSControlFactory.CreateRPSGridButton<IntrastatView>( "","#2dba14aa-8bdc-4f12-acdf-cfc3869d4649 .ag-row[role='row']@ROWINDEX [col-id='cDeleteRow']","",this.CurrentView);
 
            Flow = RPSControlFactory.CreateRPSGridEnumComboBox<IntrastatView>("","#2dba14aa-8bdc-4f12-acdf-cfc3869d4649 .ag-row[role='row']@ROWINDEX [col-id='cFlow']","",false, this.CurrentView);
 
            CodCountry = RPSControlFactory.CreateRPSGridComboBox<IntrastatView>("","#2dba14aa-8bdc-4f12-acdf-cfc3869d4649 .ag-row[role='row']@ROWINDEX [col-id='cCodCountry']","",false, this.CurrentView);
 
            CodStatistics = RPSControlFactory.CreateRPSGridTextBox<IntrastatView>("","#2dba14aa-8bdc-4f12-acdf-cfc3869d4649 .ag-row[role='row']@ROWINDEX [col-id='cCodStatistics']","",false, this.CurrentView);
 
            NetMass = RPSControlFactory.CreateRPSGridFormattedTextBox<IntrastatView>("","#2dba14aa-8bdc-4f12-acdf-cfc3869d4649 .ag-row[role='row']@ROWINDEX [col-id='cNetMass']","",false, this.CurrentView);
 
            ValueAmount = RPSControlFactory.CreateRPSGridFormattedTextBox<IntrastatView>("","#2dba14aa-8bdc-4f12-acdf-cfc3869d4649 .ag-row[role='row']@ROWINDEX [col-id='cValueAmount']","",false, this.CurrentView);
 
            PercentValue = RPSControlFactory.CreateRPSGridFormattedTextBox<IntrastatView>("","#2dba14aa-8bdc-4f12-acdf-cfc3869d4649 .ag-row[role='row']@ROWINDEX [col-id='cPercentValue']","",false, this.CurrentView);
 
            DeliveryTermCode = RPSControlFactory.CreateRPSGridComboBox<IntrastatView>("","#2dba14aa-8bdc-4f12-acdf-cfc3869d4649 .ag-row[role='row']@ROWINDEX [col-id='cDeliveryTermCode']","",false, this.CurrentView);
 
            BusinessTypeCode = RPSControlFactory.CreateRPSGridComboBox<IntrastatView>("","#2dba14aa-8bdc-4f12-acdf-cfc3869d4649 .ag-row[role='row']@ROWINDEX [col-id='cBusinessTypeCode']","",false, this.CurrentView);
 
            TransportMethodCode = RPSControlFactory.CreateRPSGridComboBox<IntrastatView>("","#2dba14aa-8bdc-4f12-acdf-cfc3869d4649 .ag-row[role='row']@ROWINDEX [col-id='cTransportMethodCode']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<IntrastatView> Error { get; set; } 
        public IRPSGridButton<IntrastatView> DeleteRow { get; set; } 
        public IRPSGridComboBox<IntrastatView> Flow { get; set; } 
        public IRPSGridComboBox<IntrastatView> CodCountry { get; set; } 
        public IRPSGridTextBox<IntrastatView> CodStatistics { get; set; } 
        public IRPSGridTextBox<IntrastatView> NetMass { get; set; } 
        public IRPSGridTextBox<IntrastatView> ValueAmount { get; set; } 
        public IRPSGridTextBox<IntrastatView> PercentValue { get; set; } 
        public IRPSGridComboBox<IntrastatView> DeliveryTermCode { get; set; } 
        public IRPSGridComboBox<IntrastatView> BusinessTypeCode { get; set; } 
        public IRPSGridComboBox<IntrastatView> TransportMethodCode { get; set; } 
                     
    }
 
    }
  
    

}