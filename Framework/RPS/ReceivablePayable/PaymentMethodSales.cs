    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.ReceivablePayable.PaymentMethodSales
{
    //RPS VERSION 1.0.0.0
    public partial class PaymentMethodSales:Screen
    {
        public PaymentMethodSales():base()
        {
            this.URL = "receivablepayable.paymentmethodsales";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            PaymentMethodSLCollectionView  = new PaymentMethodSLCollectionView(this); 
            PaymentMethodSLEntityView  = new PaymentMethodSLEntityView(this); 
            PaymentMethodSLCollectionView.InitializeControls(); 
            PaymentMethodSLEntityView.InitializeControls(); 
           
        }
      
            public PaymentMethodSLCollectionView PaymentMethodSLCollectionView {get; set; } 
            public PaymentMethodSLEntityView PaymentMethodSLEntityView {get; set; } 
    }
            
    public partial class PaymentMethodSLCollectionView : View
    {
        public PaymentMethodSLCollectionView(PaymentMethodSales screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            NewButton = RPSControlFactory.RPSNewButton<PaymentMethodSLCollectionView,PaymentMethodSLEntityView>( this,Screen.PaymentMethodSLEntityView);
 
            CollectionInit params_MainConsult = new CollectionInit(){IDDescriptor = "f21e2442-ad33-4645-8121-d3864a58db6c",CSSSelectorDescriptor = "",XPathDescriptor = ""};
            MainConsult = RPSControlFactory.RPSCreateCollection<PaymentMethodSLCollectionView,PaymentMethodSLEntityView>( params_MainConsult,this,Screen.PaymentMethodSLEntityView);
 

        }
        public IRPSButton<PaymentMethodSLCollectionView,PaymentMethodSLEntityView> NewButton { get; set; } 
        public IRPSCollectionEditor<PaymentMethodSLCollectionView,PaymentMethodSLEntityView> MainConsult { get; set; } 
        public PaymentMethodSales Screen { get; set; }
        public PaymentMethodSLCollectionView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class PaymentMethodSLEntityView : View
    {
        public PaymentMethodSLEntityView(PaymentMethodSales screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            SaveButton = RPSControlFactory.RPSSaveButton<PaymentMethodSLEntityView>( this);
 
            DeleteButton = RPSControlFactory.RPSDeleteButton<PaymentMethodSLEntityView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<PaymentMethodSLEntityView,PaymentMethodSLCollectionView>( this,Screen.PaymentMethodSLCollectionView);
 
            BackButton = RPSControlFactory.RPSBackButton<PaymentMethodSLEntityView,PaymentMethodSLCollectionView>( this,Screen.PaymentMethodSLCollectionView);
 
            CodPaymentMethod = RPSControlFactory.CreateRPSTextBox<PaymentMethodSLEntityView>("3a8a1645-81b9-4e93-b2f4-0d00230e6602","","",true, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<PaymentMethodSLEntityView>("cacbc547-1e5c-4040-b71b-76060635698f","","",false, this);
 
            IDPaymentType = RPSControlFactory.CreateRPSComboBox<PaymentMethodSLEntityView>("a9f99902-620f-4f8c-90f3-8128111e90cc","","",true, this);
 
            IDPaymentTypeCash = RPSControlFactory.CreateRPSComboBox<PaymentMethodSLEntityView>("76eadd89-667d-4c0a-bb2e-1228d5a68b6e","","",false, this);
 
            IDPaymentStatusCash = RPSControlFactory.CreateRPSComboBox<PaymentMethodSLEntityView>("fdf6f57e-06c8-47dd-8d8a-e1fac1b01fe2","","",false, this);
 
            DraftNumber = RPSControlFactory.CreateRPSFormattedTextBox<PaymentMethodSLEntityView>("9b49adbf-5c6d-4312-95d9-2cd0ccbc6fed","","",true, this);
 
            DueDateCalculation1 = RPSControlFactory.CreateRPSFormattedTextBox<PaymentMethodSLEntityView>("1a9fb6bf-c7de-450f-91ee-7fa3a5adb6fa","","",true, this);
 
            GapBetweenDraft = RPSControlFactory.CreateRPSFormattedTextBox<PaymentMethodSLEntityView>("d27d339a-0b83-4b2e-85b1-550e4b0cfc45","","",true, this);
 
            CommercialMonth = RPSControlFactory.CreateRPSCheckBox<PaymentMethodSLEntityView>("0f01a65c-0dc1-4bcf-b769-36b47e1d9b1f","","",true, this);
 
            CashDiscount1 = RPSControlFactory.CreateRPSFormattedTextBox<PaymentMethodSLEntityView>("9d169a34-e8ed-437b-a34b-01e0d4e6e2c4","","",true, this);
 
            FinancialSurcharge1 = RPSControlFactory.CreateRPSFormattedTextBox<PaymentMethodSLEntityView>("efd2624c-60d0-4ba5-8669-0d3a9100cf20","","",true, this);
 
            SalesDesk = RPSControlFactory.CreateRPSCheckBox<PaymentMethodSLEntityView>("c49b1b0d-674f-4773-84e0-969a4434eed6","","",true, this);
 
            Limit = RPSControlFactory.CreateRPSCheckBox<PaymentMethodSLEntityView>("6624f36b-48a5-494f-8adc-eb302d805946","","",true, this);
 
            LimitDays = RPSControlFactory.CreateRPSFormattedTextBox<PaymentMethodSLEntityView>("561fc274-db7a-4ec2-8377-6292c9a10ae5","","",true, this);
 
            CD = RPSControlFactory.CreateRPSCheckBox<PaymentMethodSLEntityView>("a818e8cb-ea48-4a93-bfc9-865f90de201b","","",true, this);
 
            CDDueDateCalculation = RPSControlFactory.CreateRPSFormattedTextBox<PaymentMethodSLEntityView>("08b0b00d-cd09-42e0-9398-02e2076db7ec","","",true, this);
 
            CDPercentage = RPSControlFactory.CreateRPSFormattedTextBox<PaymentMethodSLEntityView>("7dc55f5d-fb51-4b97-8b0d-d55bbb69e33d","","",true, this);
 
            CDToleranceDays = RPSControlFactory.CreateRPSFormattedTextBox<PaymentMethodSLEntityView>("05633955-10d6-4744-9aa4-759ccf40ae14","","",true, this);
 
            CDTolerancePercentage = RPSControlFactory.CreateRPSFormattedTextBox<PaymentMethodSLEntityView>("279d5988-c8fa-43d8-9280-0f1c938fe143","","",true, this);
 

        }
        public IRPSSaveButton<PaymentMethodSLEntityView> SaveButton { get; set; } 
        public IRPSButton<PaymentMethodSLEntityView> DeleteButton { get; set; } 
        public IRPSButton<PaymentMethodSLEntityView,PaymentMethodSLCollectionView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<PaymentMethodSLEntityView,PaymentMethodSLCollectionView> BackButton { get; set; } 
        public IRPSTextBox<PaymentMethodSLEntityView> CodPaymentMethod { get; set; } 
        public IRPSTextBox<PaymentMethodSLEntityView> Description { get; set; } 
        public IRPSComboBox<PaymentMethodSLEntityView> IDPaymentType { get; set; } 
        public IRPSComboBox<PaymentMethodSLEntityView> IDPaymentTypeCash { get; set; } 
        public IRPSComboBox<PaymentMethodSLEntityView> IDPaymentStatusCash { get; set; } 
        public IRPSTextBox<PaymentMethodSLEntityView> DraftNumber { get; set; } 
        public IRPSTextBox<PaymentMethodSLEntityView> DueDateCalculation1 { get; set; } 
        public IRPSTextBox<PaymentMethodSLEntityView> GapBetweenDraft { get; set; } 
        public IRPSCheckbox<PaymentMethodSLEntityView> CommercialMonth { get; set; } 
        public IRPSTextBox<PaymentMethodSLEntityView> CashDiscount1 { get; set; } 
        public IRPSTextBox<PaymentMethodSLEntityView> FinancialSurcharge1 { get; set; } 
        public IRPSCheckbox<PaymentMethodSLEntityView> SalesDesk { get; set; } 
        public IRPSCheckbox<PaymentMethodSLEntityView> Limit { get; set; } 
        public IRPSTextBox<PaymentMethodSLEntityView> LimitDays { get; set; } 
        public IRPSCheckbox<PaymentMethodSLEntityView> CD { get; set; } 
        public IRPSTextBox<PaymentMethodSLEntityView> CDDueDateCalculation { get; set; } 
        public IRPSTextBox<PaymentMethodSLEntityView> CDPercentage { get; set; } 
        public IRPSTextBox<PaymentMethodSLEntityView> CDToleranceDays { get; set; } 
        public IRPSTextBox<PaymentMethodSLEntityView> CDTolerancePercentage { get; set; } 
        public PaymentMethodSales Screen { get; set; }
        public PaymentMethodSLEntityView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}