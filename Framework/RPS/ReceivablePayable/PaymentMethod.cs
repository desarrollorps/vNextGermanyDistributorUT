    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.ReceivablePayable.PaymentMethod
{
    //RPS VERSION 1.0.0.0
    public partial class PaymentMethod:Screen
    {
        public PaymentMethod():base()
        {
            this.URL = "receivablepayable.paymentmethod";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            PaymentMethodCollectionView  = new PaymentMethodCollectionView(this); 
            PaymentMethodEntityView  = new PaymentMethodEntityView(this); 
            PaymentMethodCollectionView.InitializeControls(); 
            PaymentMethodEntityView.InitializeControls(); 
           
        }
      
            public PaymentMethodCollectionView PaymentMethodCollectionView {get; set; } 
            public PaymentMethodEntityView PaymentMethodEntityView {get; set; } 
    }
            
    public partial class PaymentMethodCollectionView : View
    {
        public PaymentMethodCollectionView(PaymentMethod screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            NewButton = RPSControlFactory.RPSNewButton<PaymentMethodCollectionView,PaymentMethodEntityView>( this,Screen.PaymentMethodEntityView);
 
            CollectionInit params_MainConsult = new CollectionInit(){IDDescriptor = "d72360b9-6386-4c20-833e-744f15151a0e",CSSSelectorDescriptor = "",XPathDescriptor = ""};
            MainConsult = RPSControlFactory.RPSCreateCollection<PaymentMethodCollectionView,PaymentMethodEntityView>( params_MainConsult,this,Screen.PaymentMethodEntityView);
 

        }
        public IRPSButton<PaymentMethodCollectionView,PaymentMethodEntityView> NewButton { get; set; } 
        public IRPSCollectionEditor<PaymentMethodCollectionView,PaymentMethodEntityView> MainConsult { get; set; } 
        public PaymentMethod Screen { get; set; }
        public PaymentMethodCollectionView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class PaymentMethodEntityView : View
    {
        public PaymentMethodEntityView(PaymentMethod screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            SaveButton = RPSControlFactory.RPSSaveButton<PaymentMethodEntityView>( this);
 
            DeleteButton = RPSControlFactory.RPSDeleteButton<PaymentMethodEntityView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<PaymentMethodEntityView,PaymentMethodCollectionView>( this,Screen.PaymentMethodCollectionView);
 
            BackButton = RPSControlFactory.RPSBackButton<PaymentMethodEntityView,PaymentMethodCollectionView>( this,Screen.PaymentMethodCollectionView);
 
            CodPaymentMethod = RPSControlFactory.CreateRPSTextBox<PaymentMethodEntityView>("f2125a55-40b0-483a-9faa-b16ff205cd74","","",true, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<PaymentMethodEntityView>("064fa453-9825-4f3a-a98d-13bf0f3879dd","","",false, this);
 
            IDPaymentType = RPSControlFactory.CreateRPSComboBox<PaymentMethodEntityView>("d7d98866-652d-4a22-b6d9-ea459dcf10fa","","",true, this);
 
            IDPaymentTypeCash = RPSControlFactory.CreateRPSComboBox<PaymentMethodEntityView>("9462cba4-963c-4203-a36e-1a889e295439","","",false, this);
 
            IDPaymentStatusCash = RPSControlFactory.CreateRPSComboBox<PaymentMethodEntityView>("bb5651a7-66bb-4d59-8a89-a9ea35ad9c07","","",false, this);
 
            DraftNumber = RPSControlFactory.CreateRPSFormattedTextBox<PaymentMethodEntityView>("97bf22ef-9008-44b8-8043-7d45e79f349a","","",true, this);
 
            DueDateCalculation1 = RPSControlFactory.CreateRPSFormattedTextBox<PaymentMethodEntityView>("5de24afc-4f19-45ee-9db3-f689a11aab7f","","",true, this);
 
            GapBetweenDraft = RPSControlFactory.CreateRPSFormattedTextBox<PaymentMethodEntityView>("e9aa6f2b-7a75-44f7-be95-a7cbb355392d","","",true, this);
 
            CommercialMonth = RPSControlFactory.CreateRPSCheckBox<PaymentMethodEntityView>("72c35f68-2e7d-4951-871b-f7954cf86d04","","",true, this);
 
            CashDiscount1 = RPSControlFactory.CreateRPSFormattedTextBox<PaymentMethodEntityView>("95c66dbb-148a-4e6e-8def-5db4ea60083c","","",true, this);
 
            FinancialSurcharge1 = RPSControlFactory.CreateRPSFormattedTextBox<PaymentMethodEntityView>("9141939d-f8d2-4f1a-9f85-c1fa6b05cd0b","","",true, this);
 
            Limit = RPSControlFactory.CreateRPSCheckBox<PaymentMethodEntityView>("63e0912b-9383-422f-892f-5c8a4785aaa3","","",true, this);
 
            LimitDays = RPSControlFactory.CreateRPSFormattedTextBox<PaymentMethodEntityView>("98029f9a-63c9-4ecd-9be4-cd10208ff6ae","","",true, this);
 
            CD = RPSControlFactory.CreateRPSCheckBox<PaymentMethodEntityView>("22ef98b3-67d2-49c1-afe8-6c46f9c6d832","","",true, this);
 
            CDDueDateCalculation = RPSControlFactory.CreateRPSFormattedTextBox<PaymentMethodEntityView>("8fb0d300-7654-44ea-baaf-4470e64df8e3","","",true, this);
 
            CDPercentage = RPSControlFactory.CreateRPSFormattedTextBox<PaymentMethodEntityView>("de01a5da-2046-449a-a908-b1135da992f2","","",true, this);
 
            CDToleranceDays = RPSControlFactory.CreateRPSFormattedTextBox<PaymentMethodEntityView>("14030b06-258b-4891-ac8d-c8e7a1ebef1c","","",true, this);
 
            CDTolerancePercentage = RPSControlFactory.CreateRPSFormattedTextBox<PaymentMethodEntityView>("af1abd21-8843-4457-8b04-60ef53adffa8","","",true, this);
 

        }
        public IRPSSaveButton<PaymentMethodEntityView> SaveButton { get; set; } 
        public IRPSButton<PaymentMethodEntityView> DeleteButton { get; set; } 
        public IRPSButton<PaymentMethodEntityView,PaymentMethodCollectionView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<PaymentMethodEntityView,PaymentMethodCollectionView> BackButton { get; set; } 
        public IRPSTextBox<PaymentMethodEntityView> CodPaymentMethod { get; set; } 
        public IRPSTextBox<PaymentMethodEntityView> Description { get; set; } 
        public IRPSComboBox<PaymentMethodEntityView> IDPaymentType { get; set; } 
        public IRPSComboBox<PaymentMethodEntityView> IDPaymentTypeCash { get; set; } 
        public IRPSComboBox<PaymentMethodEntityView> IDPaymentStatusCash { get; set; } 
        public IRPSTextBox<PaymentMethodEntityView> DraftNumber { get; set; } 
        public IRPSTextBox<PaymentMethodEntityView> DueDateCalculation1 { get; set; } 
        public IRPSTextBox<PaymentMethodEntityView> GapBetweenDraft { get; set; } 
        public IRPSCheckbox<PaymentMethodEntityView> CommercialMonth { get; set; } 
        public IRPSTextBox<PaymentMethodEntityView> CashDiscount1 { get; set; } 
        public IRPSTextBox<PaymentMethodEntityView> FinancialSurcharge1 { get; set; } 
        public IRPSCheckbox<PaymentMethodEntityView> Limit { get; set; } 
        public IRPSTextBox<PaymentMethodEntityView> LimitDays { get; set; } 
        public IRPSCheckbox<PaymentMethodEntityView> CD { get; set; } 
        public IRPSTextBox<PaymentMethodEntityView> CDDueDateCalculation { get; set; } 
        public IRPSTextBox<PaymentMethodEntityView> CDPercentage { get; set; } 
        public IRPSTextBox<PaymentMethodEntityView> CDToleranceDays { get; set; } 
        public IRPSTextBox<PaymentMethodEntityView> CDTolerancePercentage { get; set; } 
        public PaymentMethod Screen { get; set; }
        public PaymentMethodEntityView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}