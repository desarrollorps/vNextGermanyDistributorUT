    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.Purchase.PaymentMethod
{
    //RPS VERSION 1.0.0.0
    public partial class PaymentMethod:Screen
    {
        public PaymentMethod():base()
        {
            this.URL = "purchase.paymentmethod";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            PaymentMethodCollectionView  = new PaymentMethodCollectionView(this); 
            PaymentMethodEntityView  = new PaymentMethodEntityView(this); 
            PaymentMethodByLangView  = new PaymentMethodByLangView(this); 
            PaymentMethodCollectionView.InitializeControls(); 
            PaymentMethodEntityView.InitializeControls(); 
            PaymentMethodByLangView.InitializeControls(); 
           
        }
      
            public PaymentMethodCollectionView PaymentMethodCollectionView {get; set; } 
            public PaymentMethodEntityView PaymentMethodEntityView {get; set; } 
            public PaymentMethodByLangView PaymentMethodByLangView {get; set; } 
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
 
            CollectionInit params_MainConsult = new CollectionInit(){IDDescriptor = "e502272e-56a2-4cf8-ba4b-1ce2858ffa8d",CSSSelectorDescriptor = "",XPathDescriptor = ""};
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
 
            CodPaymentMethod = RPSControlFactory.CreateRPSTextBox<PaymentMethodEntityView>("282a0dba-98ab-42ce-8821-62d8a4e3aa61","","",true, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<PaymentMethodEntityView>("b7fc8eed-6fb3-4078-914e-f2f5455c6313","","",false, this);
 
            IDPaymentType = RPSControlFactory.CreateRPSComboBox<PaymentMethodEntityView>("fe39c92b-f78a-4bd2-9479-c1bd4f08444d","","",true, this);
 
            IDPaymentTypeCash = RPSControlFactory.CreateRPSComboBox<PaymentMethodEntityView>("dff32e20-2610-444d-b031-8d981f1f889e","","",false, this);
 
            IDPaymentStatusCash = RPSControlFactory.CreateRPSComboBox<PaymentMethodEntityView>("39e113b3-315a-4aab-a8da-fb3b35878b93","","",false, this);
 
            DraftNumber = RPSControlFactory.CreateRPSFormattedTextBox<PaymentMethodEntityView>("cf1052a9-1ee3-4864-b60a-b112afe601bd","","",true, this);
 
            DueDateCalculation1 = RPSControlFactory.CreateRPSFormattedTextBox<PaymentMethodEntityView>("035755cd-2a40-4cc2-95fc-670734169d7d","","",true, this);
 
            GapBetweenDraft = RPSControlFactory.CreateRPSFormattedTextBox<PaymentMethodEntityView>("48b7bfcb-ae8a-42b9-aa91-efc875fc893b","","",true, this);
 
            CommercialMonth = RPSControlFactory.CreateRPSCheckBox<PaymentMethodEntityView>("f6ff7323-d6fd-4aed-afd7-9aebf8e883eb","","",true, this);
 
            CashDiscount = RPSControlFactory.CreateRPSFormattedTextBox<PaymentMethodEntityView>("f3e4af49-23de-4355-8b1a-1034d52a77e9","","",true, this);
 
            FinancialSurcharge = RPSControlFactory.CreateRPSFormattedTextBox<PaymentMethodEntityView>("cd18ab7b-7da7-474c-8ebd-33860dc8cb32","","",true, this);
 
            Limit = RPSControlFactory.CreateRPSCheckBox<PaymentMethodEntityView>("cbbded95-0827-4c6e-a686-3de8dd65665f","","",true, this);
 
            LimitDays = RPSControlFactory.CreateRPSFormattedTextBox<PaymentMethodEntityView>("193cfb3a-700d-40f0-8a16-9b29793c8ca4","","",true, this);
 
            CD = RPSControlFactory.CreateRPSCheckBox<PaymentMethodEntityView>("6efcf6de-d712-4c1e-96df-299934763d71","","",true, this);
 
            CDDueDateCalculation = RPSControlFactory.CreateRPSFormattedTextBox<PaymentMethodEntityView>("7ee7facd-730e-4248-a0a6-7a2706ebbd14","","",true, this);
 
            CDPercentage = RPSControlFactory.CreateRPSFormattedTextBox<PaymentMethodEntityView>("fa5a5e13-d3aa-4b47-aef0-9f75449ea5ad","","",true, this);
 
            CDToleranceDays = RPSControlFactory.CreateRPSFormattedTextBox<PaymentMethodEntityView>("bc9491db-bde7-467c-8acf-10787cafe6e6","","",true, this);
 
            CDTolerancePercentage = RPSControlFactory.CreateRPSFormattedTextBox<PaymentMethodEntityView>("77d852f8-ed06-40d9-aa15-9f3730ce48f8","","",true, this);
 
            CollectionInit params_PaymentMethodByLangs = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="6bdd1428-c267-4512-97b9-a0ff44da4e08",CSSSelectorGrid="",XPathGrid=""};
            PaymentMethodByLangs = RPSControlFactory.RPSCreateCollectionWithGrid<PaymentMethodByLangsCollectionEditor<PaymentMethodEntityView,PaymentMethodByLangView>,PaymentMethodEntityView,PaymentMethodByLangView>( params_PaymentMethodByLangs,this,Screen.PaymentMethodByLangView);
 
            Section = RPSControlFactory.CreateRPSSection<PaymentMethodEntityView>( "","ul li[rpsid='79ab3cf0-0191-41a9-8124-78c749849fb3']","",this);
 
            Section1 = RPSControlFactory.CreateRPSSection<PaymentMethodEntityView>( "","ul li[rpsid='be1be041-9426-4550-ac60-f98b92064941']","",this);
 

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
        public IRPSTextBox<PaymentMethodEntityView> CashDiscount { get; set; } 
        public IRPSTextBox<PaymentMethodEntityView> FinancialSurcharge { get; set; } 
        public IRPSCheckbox<PaymentMethodEntityView> Limit { get; set; } 
        public IRPSTextBox<PaymentMethodEntityView> LimitDays { get; set; } 
        public IRPSCheckbox<PaymentMethodEntityView> CD { get; set; } 
        public IRPSTextBox<PaymentMethodEntityView> CDDueDateCalculation { get; set; } 
        public IRPSTextBox<PaymentMethodEntityView> CDPercentage { get; set; } 
        public IRPSTextBox<PaymentMethodEntityView> CDToleranceDays { get; set; } 
        public IRPSTextBox<PaymentMethodEntityView> CDTolerancePercentage { get; set; } 
        public PaymentMethodByLangsCollectionEditor<PaymentMethodEntityView,PaymentMethodByLangView> PaymentMethodByLangs { get; set; } 
        public IRPSSection<PaymentMethodEntityView> Section { get; set; } 
        public IRPSSection<PaymentMethodEntityView> Section1 { get; set; } 
        public PaymentMethod Screen { get; set; }
        public PaymentMethodEntityView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class PaymentMethodByLangsCollectionEditor<PaymentMethodEntityView,PaymentMethodByLangView>:RPSCollectionEditor<PaymentMethodEntityView,PaymentMethodByLangView> where PaymentMethodEntityView : class, IView where PaymentMethodByLangView : class, IView
    {
        public  PaymentMethodByLangsGridView<PaymentMethodEntityView,PaymentMethodByLangView> GridView {get;set;}
    }
    public partial class PaymentMethodByLangsGridView <PaymentMethodEntityView,PaymentMethodByLangView> :  RPSGridView<PaymentMethodEntityView,PaymentMethodByLangView> where PaymentMethodEntityView : class, IView where PaymentMethodByLangView : class, IView
    {
        public PaymentMethodByLangsGridView(PaymentMethodEntityView currentView,PaymentMethodByLangView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            CodLanguage = RPSControlFactory.CreateRPSGridComboBox<PaymentMethodEntityView>("","#6bdd1428-c267-4512-97b9-a0ff44da4e08 .ag-row[role='row']@ROWINDEX [col-id='cCodLanguage']","",true, this.CurrentView);
 
            Description = RPSControlFactory.CreateRPSGridTextBox<PaymentMethodEntityView>("","#6bdd1428-c267-4512-97b9-a0ff44da4e08 .ag-row[role='row']@ROWINDEX [col-id='cDescription']","",false, this.CurrentView);
 

        }
        public IRPSGridComboBox<PaymentMethodEntityView> CodLanguage { get; set; } 
        public IRPSGridTextBox<PaymentMethodEntityView> Description { get; set; } 
                     
    }
 
    }
  
            
    public partial class PaymentMethodByLangView : View
    {
        public PaymentMethodByLangView(PaymentMethod screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            DeleteButton = RPSControlFactory.RPSDeleteButton<PaymentMethodByLangView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<PaymentMethodByLangView,PaymentMethodEntityView>( this,Screen.PaymentMethodEntityView);
 
            BackButton = RPSControlFactory.RPSBackButton<PaymentMethodByLangView,PaymentMethodEntityView>( this,Screen.PaymentMethodEntityView);
 
            AcceptButton = RPSControlFactory.RPSAcceptButton<PaymentMethodByLangView,PaymentMethodEntityView>( this,Screen.PaymentMethodEntityView);
 
            CodLanguage = RPSControlFactory.CreateRPSComboBox<PaymentMethodByLangView>("7d0c7192-2a1f-4af6-adbb-39e7a408119d","","",true, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<PaymentMethodByLangView>("078ab16c-b01b-46e4-ab4b-7bff52e882c1","","",false, this);
 

        }
        public IRPSButton<PaymentMethodByLangView> DeleteButton { get; set; } 
        public IRPSButton<PaymentMethodByLangView,PaymentMethodEntityView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<PaymentMethodByLangView,PaymentMethodEntityView> BackButton { get; set; } 
        public IRPSAcceptButton<PaymentMethodByLangView,PaymentMethodEntityView> AcceptButton { get; set; } 
        public IRPSComboBox<PaymentMethodByLangView> CodLanguage { get; set; } 
        public IRPSTextBox<PaymentMethodByLangView> Description { get; set; } 
        public PaymentMethod Screen { get; set; }
        public PaymentMethodByLangView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}