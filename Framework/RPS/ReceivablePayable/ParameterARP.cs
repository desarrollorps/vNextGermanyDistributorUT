    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.ReceivablePayable.ParameterARP
{
    //RPS VERSION 1.0.0.0
    public partial class ParameterARP:Screen
    {
        public ParameterARP():base()
        {
            this.URL = "receivablepayable.parameterarp";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            ParameterARPEntityView  = new ParameterARPEntityView(this); 
            ParameterARPStampView  = new ParameterARPStampView(this); 
            ParameterARPEntityView.InitializeControls(); 
            ParameterARPStampView.InitializeControls(); 
           
        }
      
            public ParameterARPEntityView ParameterARPEntityView {get; set; } 
            public ParameterARPStampView ParameterARPStampView {get; set; } 
    }
            
    public partial class ParameterARPEntityView : View
    {
        public ParameterARPEntityView(ParameterARP screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            DirectPurchase = RPSControlFactory.CreateRPSCheckBox<ParameterARPEntityView>("35b92a87-441c-4235-9218-502a1c20e1a2","","",true, this);
 
            PurTransferARPInvZero = RPSControlFactory.CreateRPSCheckBox<ParameterARPEntityView>("1eff1e98-2f8a-42c8-8f59-4a4cecdd76e3","","",true, this);
 
            HistoryChangesAP = RPSControlFactory.CreateRPSEnumComboBox<ParameterARPEntityView>("a26a1247-c21a-49f3-9179-a40c708b755b","","",true, this);
 
            IDPaymentStatusAPInitial = RPSControlFactory.CreateRPSComboBox<ParameterARPEntityView>("acdacd04-3b03-4479-9722-c6d4a81062cc","","",true, this);
 
            IDPaymentStatusAPFinal = RPSControlFactory.CreateRPSComboBox<ParameterARPEntityView>("ff3a2673-ae09-4958-84e7-1dc9bd32b507","","",true, this);
 
            DirectSales = RPSControlFactory.CreateRPSCheckBox<ParameterARPEntityView>("cacfa7e2-8448-4ebe-ad9a-2f85096b04e7","","",true, this);
 
            FacTransferARPInvZero = RPSControlFactory.CreateRPSCheckBox<ParameterARPEntityView>("a9765a00-015b-4e12-9b91-0ac55308c2fb","","",true, this);
 
            HistoryChangesAR = RPSControlFactory.CreateRPSEnumComboBox<ParameterARPEntityView>("1bab4c26-3fa0-4573-b32c-2e531e8bfaf2","","",true, this);
 
            IDPaymentStatusARInitial = RPSControlFactory.CreateRPSComboBox<ParameterARPEntityView>("67fdf1bb-26b0-4297-b2cd-9d3956b57f3c","","",true, this);
 
            IDPaymentStatusARFinal = RPSControlFactory.CreateRPSComboBox<ParameterARPEntityView>("14a57eee-b75a-4121-bc36-3bf3478da3cc","","",true, this);
 
            LastBillNumber = RPSControlFactory.CreateRPSFormattedTextBox<ParameterARPEntityView>("c0097394-f754-4f92-ac85-5d24c809f944","","",true, this);
 
            EditManualDrafts = RPSControlFactory.CreateRPSCheckBox<ParameterARPEntityView>("e772065e-2975-4020-9e9c-faadf624d6b2","","",true, this);
 
            CreateAccountFormuled = RPSControlFactory.CreateRPSCheckBox<ParameterARPEntityView>("50a0bf11-f63e-457c-a95a-9f964d743020","","",true, this);
 
            IDCodingSeriesSEPAMessageCT = RPSControlFactory.CreateRPSComboBox<ParameterARPEntityView>("08319d00-9bb5-44ab-b2b3-fa1742f9ee2a","","",false, this);
 
            IDCodingSeriesSEPAMessageDD = RPSControlFactory.CreateRPSComboBox<ParameterARPEntityView>("2b3b757a-9aac-47bb-9b29-6f87246bac8a","","",false, this);
 
            IDCodingSeriesSEPAPayment = RPSControlFactory.CreateRPSComboBox<ParameterARPEntityView>("347921f6-2a62-4309-8d53-da77193c7b4a","","",false, this);
 
            PaymentReportCT = RPSControlFactory.CreateRPSCheckBox<ParameterARPEntityView>("1f2f412a-e9ec-4afe-9492-34f3353d1349","","",true, this);
 
            PaymentReportDD = RPSControlFactory.CreateRPSCheckBox<ParameterARPEntityView>("c594ecca-47b6-439a-aed6-44eaabb8a0e9","","",true, this);
 
            IDCodingSeriesAgreementDD = RPSControlFactory.CreateRPSComboBox<ParameterARPEntityView>("e1b562ce-f114-42dc-93d3-bef796e90675","","",false, this);
 
            UseVatNumber = RPSControlFactory.CreateRPSOption<ParameterARPEntityView>( "9a536475-4a0c-419b-af71-b25f5ef05542","","",this);
 
            UseNat = RPSControlFactory.CreateRPSOption<ParameterARPEntityView>( "ac42a78c-d5cf-4107-aef3-74d5a2d2cb20","","",this);
 
            NATCreditor = RPSControlFactory.CreateRPSTextBox<ParameterARPEntityView>("1b357b12-8c38-41d8-83d5-a09183fb035e","","",false, this);
 
            IDCodingSeriesEvidenceAR = RPSControlFactory.CreateRPSComboBox<ParameterARPEntityView>("a2d5e383-0055-4d5c-907f-16bc34979c95","","",false, this);
 
            IDCodingSeriesEvidenceAP = RPSControlFactory.CreateRPSComboBox<ParameterARPEntityView>("0b582102-bb86-4879-9336-752027b3595f","","",false, this);
 
            CollectionInit params_ParameterARPStamps = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="4aea8bf4-bef2-47e3-8b62-69c7d834f61f",CSSSelectorGrid="",XPathGrid=""};
            ParameterARPStamps = RPSControlFactory.RPSCreateCollectionWithGrid<ParameterARPStampsCollectionEditor<ParameterARPEntityView,ParameterARPStampView>,ParameterARPEntityView,ParameterARPStampView>( params_ParameterARPStamps,this,Screen.ParameterARPStampView);
 
            SectionGeneral = RPSControlFactory.CreateRPSSection<ParameterARPEntityView>( "","ul li[rpsid='5f2089a9-3fd3-42bb-8e3f-dbd265e0fe1a']","",this);
 
            SectionTimbres = RPSControlFactory.CreateRPSSection<ParameterARPEntityView>( "","ul li[rpsid='6988cec2-d0fc-47dd-a9e6-17ec8cb6c8ce']","",this);
 

        }
        public IRPSCheckbox<ParameterARPEntityView> DirectPurchase { get; set; } 
        public IRPSCheckbox<ParameterARPEntityView> PurTransferARPInvZero { get; set; } 
        public IRPSComboBox<ParameterARPEntityView> HistoryChangesAP { get; set; } 
        public IRPSComboBox<ParameterARPEntityView> IDPaymentStatusAPInitial { get; set; } 
        public IRPSComboBox<ParameterARPEntityView> IDPaymentStatusAPFinal { get; set; } 
        public IRPSCheckbox<ParameterARPEntityView> DirectSales { get; set; } 
        public IRPSCheckbox<ParameterARPEntityView> FacTransferARPInvZero { get; set; } 
        public IRPSComboBox<ParameterARPEntityView> HistoryChangesAR { get; set; } 
        public IRPSComboBox<ParameterARPEntityView> IDPaymentStatusARInitial { get; set; } 
        public IRPSComboBox<ParameterARPEntityView> IDPaymentStatusARFinal { get; set; } 
        public IRPSTextBox<ParameterARPEntityView> LastBillNumber { get; set; } 
        public IRPSCheckbox<ParameterARPEntityView> EditManualDrafts { get; set; } 
        public IRPSCheckbox<ParameterARPEntityView> CreateAccountFormuled { get; set; } 
        public IRPSComboBox<ParameterARPEntityView> IDCodingSeriesSEPAMessageCT { get; set; } 
        public IRPSComboBox<ParameterARPEntityView> IDCodingSeriesSEPAMessageDD { get; set; } 
        public IRPSComboBox<ParameterARPEntityView> IDCodingSeriesSEPAPayment { get; set; } 
        public IRPSCheckbox<ParameterARPEntityView> PaymentReportCT { get; set; } 
        public IRPSCheckbox<ParameterARPEntityView> PaymentReportDD { get; set; } 
        public IRPSComboBox<ParameterARPEntityView> IDCodingSeriesAgreementDD { get; set; } 
        public IRPSOption<ParameterARPEntityView> UseVatNumber { get; set; } 
        public IRPSOption<ParameterARPEntityView> UseNat { get; set; } 
        public IRPSTextBox<ParameterARPEntityView> NATCreditor { get; set; } 
        public IRPSComboBox<ParameterARPEntityView> IDCodingSeriesEvidenceAR { get; set; } 
        public IRPSComboBox<ParameterARPEntityView> IDCodingSeriesEvidenceAP { get; set; } 
        public ParameterARPStampsCollectionEditor<ParameterARPEntityView,ParameterARPStampView> ParameterARPStamps { get; set; } 
        public IRPSSection<ParameterARPEntityView> SectionGeneral { get; set; } 
        public IRPSSection<ParameterARPEntityView> SectionTimbres { get; set; } 
        public ParameterARP Screen { get; set; }
        public ParameterARPEntityView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class ParameterARPStampsCollectionEditor<ParameterARPEntityView,ParameterARPStampView>:RPSCollectionEditor<ParameterARPEntityView,ParameterARPStampView> where ParameterARPEntityView : class, IView where ParameterARPStampView : class, IView
    {
        public  ParameterARPStampsGridView<ParameterARPEntityView,ParameterARPStampView> GridView {get;set;}
    }
    public partial class ParameterARPStampsGridView <ParameterARPEntityView,ParameterARPStampView> :  RPSGridView<ParameterARPEntityView,ParameterARPStampView> where ParameterARPEntityView : class, IView where ParameterARPStampView : class, IView
    {
        public ParameterARPStampsGridView(ParameterARPEntityView currentView,ParameterARPStampView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            PostageStampTo = RPSControlFactory.CreateRPSGridFormattedTextBox<ParameterARPEntityView>("","#4aea8bf4-bef2-47e3-8b62-69c7d834f61f .ag-row[role='row']@ROWINDEX [col-id='cPostageStampTo']","",true, this.CurrentView);
 
            PostageStampAmount = RPSControlFactory.CreateRPSGridFormattedTextBox<ParameterARPEntityView>("","#4aea8bf4-bef2-47e3-8b62-69c7d834f61f .ag-row[role='row']@ROWINDEX [col-id='cPostageStampAmount']","",true, this.CurrentView);
 

        }
        public IRPSGridTextBox<ParameterARPEntityView> PostageStampTo { get; set; } 
        public IRPSGridTextBox<ParameterARPEntityView> PostageStampAmount { get; set; } 
                     
    }
 
    }
  
            
    public partial class ParameterARPStampView : View
    {
        public ParameterARPStampView(ParameterARP screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            DeleteButton = RPSControlFactory.RPSDeleteButton<ParameterARPStampView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<ParameterARPStampView,ParameterARPEntityView>( this,Screen.ParameterARPEntityView);
 
            BackButton = RPSControlFactory.RPSBackButton<ParameterARPStampView,ParameterARPEntityView>( this,Screen.ParameterARPEntityView);
 
            AcceptButton = RPSControlFactory.RPSAcceptButton<ParameterARPStampView,ParameterARPEntityView>( this,Screen.ParameterARPEntityView);
 
            PostageStampAmount = RPSControlFactory.CreateRPSFormattedTextBox<ParameterARPStampView>("3f46e715-2d1a-4cda-a59c-c338c5793c48","","",true, this);
 
            PostageStampTo = RPSControlFactory.CreateRPSFormattedTextBox<ParameterARPStampView>("10fac455-0e57-4552-9136-65ac81b468c5","","",true, this);
 

        }
        public IRPSButton<ParameterARPStampView> DeleteButton { get; set; } 
        public IRPSButton<ParameterARPStampView,ParameterARPEntityView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<ParameterARPStampView,ParameterARPEntityView> BackButton { get; set; } 
        public IRPSAcceptButton<ParameterARPStampView,ParameterARPEntityView> AcceptButton { get; set; } 
        public IRPSTextBox<ParameterARPStampView> PostageStampAmount { get; set; } 
        public IRPSTextBox<ParameterARPStampView> PostageStampTo { get; set; } 
        public ParameterARP Screen { get; set; }
        public ParameterARPStampView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}