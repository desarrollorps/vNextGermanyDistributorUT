    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.SalesDesk.CashPaymentSL
{
    //RPS VERSION 1.0.0.0
    public partial class CashPaymentSL:Screen
    {
        public CashPaymentSL():base()
        {
            this.URL = "salesdesk.cashpaymentsl";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            CashPaymentSLCollectionView  = new CashPaymentSLCollectionView(this); 
            CashPaymentSLEntityView  = new CashPaymentSLEntityView(this); 
            CashPaymentSLCollectionView.InitializeControls(); 
            CashPaymentSLEntityView.InitializeControls(); 
           
        }
      
            public CashPaymentSLCollectionView CashPaymentSLCollectionView {get; set; } 
            public CashPaymentSLEntityView CashPaymentSLEntityView {get; set; } 
    }
            
    public partial class CashPaymentSLCollectionView : View
    {
        public CashPaymentSLCollectionView(CashPaymentSL screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            NewButton = RPSControlFactory.RPSNewButton<CashPaymentSLCollectionView,CashPaymentSLEntityView>( this,Screen.CashPaymentSLEntityView);
 
            CollectionInit params_MainConsult = new CollectionInit(){IDDescriptor = "b43b3a3c-d687-423e-ba6c-b1b12c1b9329",CSSSelectorDescriptor = "",XPathDescriptor = ""};
            MainConsult = RPSControlFactory.RPSCreateCollection<CashPaymentSLCollectionView,CashPaymentSLEntityView>( params_MainConsult,this,Screen.CashPaymentSLEntityView);
 

        }
        public IRPSButton<CashPaymentSLCollectionView,CashPaymentSLEntityView> NewButton { get; set; } 
        public IRPSCollectionEditor<CashPaymentSLCollectionView,CashPaymentSLEntityView> MainConsult { get; set; } 
        public CashPaymentSL Screen { get; set; }
        public CashPaymentSLCollectionView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class CashPaymentSLEntityView : View
    {
        public CashPaymentSLEntityView(CashPaymentSL screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            SaveButton = RPSControlFactory.RPSSaveButton<CashPaymentSLEntityView>( this);
 
            DeleteButton = RPSControlFactory.RPSDeleteButton<CashPaymentSLEntityView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<CashPaymentSLEntityView,CashPaymentSLCollectionView>( this,Screen.CashPaymentSLCollectionView);
 
            BackButton = RPSControlFactory.RPSBackButton<CashPaymentSLEntityView,CashPaymentSLCollectionView>( this,Screen.CashPaymentSLCollectionView);
 
            CodCashPayment = RPSControlFactory.CreateRPSTextBox<CashPaymentSLEntityView>("262bb3c7-80e4-49c4-8616-a5c73b1e0206","","",true, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<CashPaymentSLEntityView>("a90c3f8e-eadc-424c-b8b5-e9200f16a4a5","","",false, this);
 
            CodUser = RPSControlFactory.CreateRPSComboBox<CashPaymentSLEntityView>("ca760d76-ad1b-4cfd-9cf8-0e4a4f0139e2","","",false, this);
 
            IDCustomerTicket = RPSControlFactory.CreateRPSComboBox<CashPaymentSLEntityView>("b44942ad-f845-471d-92ae-fa7b68dcbad8","","",false, this);
 
            OnlyCompanyCurrency = RPSControlFactory.CreateRPSCheckBox<CashPaymentSLEntityView>("89af154d-4fa2-4100-b962-cdcb5a3f16c4","","",true, this);
 
            IDCodingSerieTicket = RPSControlFactory.CreateRPSComboBox<CashPaymentSLEntityView>("15c58ede-0deb-4e66-84b4-e423961d870b","","",true, this);
 
            IDCodingSerieCreditTicket = RPSControlFactory.CreateRPSComboBox<CashPaymentSLEntityView>("dba83c56-6ab2-42da-a7c4-236019e3e3f5","","",true, this);
 
            IDCodingSerieInvoice = RPSControlFactory.CreateRPSComboBox<CashPaymentSLEntityView>("f4004060-dff1-4ceb-afdd-4508a5244f49","","",false, this);
 
            IDCodingSerieCreditInvoice = RPSControlFactory.CreateRPSComboBox<CashPaymentSLEntityView>("e90e2e3b-4de3-4a33-97b5-3b5dbb78c9f0","","",false, this);
 
            IDCodingSerieInvoiceB = RPSControlFactory.CreateRPSComboBox<CashPaymentSLEntityView>("d1ce57fc-a2c7-4b10-a6c3-044f297ce61a","","",false, this);
 
            IDCodingSerieCreditInvoiceB = RPSControlFactory.CreateRPSComboBox<CashPaymentSLEntityView>("1d448596-ff44-40e8-aa25-319f386eaaa7","","",false, this);
 

        }
        public IRPSSaveButton<CashPaymentSLEntityView> SaveButton { get; set; } 
        public IRPSButton<CashPaymentSLEntityView> DeleteButton { get; set; } 
        public IRPSButton<CashPaymentSLEntityView,CashPaymentSLCollectionView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<CashPaymentSLEntityView,CashPaymentSLCollectionView> BackButton { get; set; } 
        public IRPSTextBox<CashPaymentSLEntityView> CodCashPayment { get; set; } 
        public IRPSTextBox<CashPaymentSLEntityView> Description { get; set; } 
        public IRPSComboBox<CashPaymentSLEntityView> CodUser { get; set; } 
        public IRPSComboBox<CashPaymentSLEntityView> IDCustomerTicket { get; set; } 
        public IRPSCheckbox<CashPaymentSLEntityView> OnlyCompanyCurrency { get; set; } 
        public IRPSComboBox<CashPaymentSLEntityView> IDCodingSerieTicket { get; set; } 
        public IRPSComboBox<CashPaymentSLEntityView> IDCodingSerieCreditTicket { get; set; } 
        public IRPSComboBox<CashPaymentSLEntityView> IDCodingSerieInvoice { get; set; } 
        public IRPSComboBox<CashPaymentSLEntityView> IDCodingSerieCreditInvoice { get; set; } 
        public IRPSComboBox<CashPaymentSLEntityView> IDCodingSerieInvoiceB { get; set; } 
        public IRPSComboBox<CashPaymentSLEntityView> IDCodingSerieCreditInvoiceB { get; set; } 
        public CashPaymentSL Screen { get; set; }
        public CashPaymentSLEntityView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}