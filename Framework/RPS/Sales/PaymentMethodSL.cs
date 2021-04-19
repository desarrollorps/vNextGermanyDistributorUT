    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.Sales.PaymentMethodSL
{
    //RPS VERSION 1.0.0.0
    public partial class PaymentMethodSL:Screen
    {
        public PaymentMethodSL():base()
        {
            this.URL = "sales.paymentmethodsl";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            PaymentMethodSLCollectionView  = new PaymentMethodSLCollectionView(this); 
            PaymentMethodSLEntityView  = new PaymentMethodSLEntityView(this); 
            PaymentMethodByLangSLView  = new PaymentMethodByLangSLView(this); 
            PaymentMethodSLCollectionView.InitializeControls(); 
            PaymentMethodSLEntityView.InitializeControls(); 
            PaymentMethodByLangSLView.InitializeControls(); 
           
        }
      
            public PaymentMethodSLCollectionView PaymentMethodSLCollectionView {get; set; } 
            public PaymentMethodSLEntityView PaymentMethodSLEntityView {get; set; } 
            public PaymentMethodByLangSLView PaymentMethodByLangSLView {get; set; } 
    }
            
    public partial class PaymentMethodSLCollectionView : View
    {
        public PaymentMethodSLCollectionView(PaymentMethodSL screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            NewButton = RPSControlFactory.RPSNewButton<PaymentMethodSLCollectionView,PaymentMethodSLEntityView>( this,Screen.PaymentMethodSLEntityView);
 
            CollectionInit params_MainConsult = new CollectionInit(){IDDescriptor = "3ad937bf-cf0a-4654-a683-53f9ed49e74f",CSSSelectorDescriptor = "",XPathDescriptor = ""};
            MainConsult = RPSControlFactory.RPSCreateCollection<PaymentMethodSLCollectionView,PaymentMethodSLEntityView>( params_MainConsult,this,Screen.PaymentMethodSLEntityView);
 

        }
        public IRPSButton<PaymentMethodSLCollectionView,PaymentMethodSLEntityView> NewButton { get; set; } 
        public IRPSCollectionEditor<PaymentMethodSLCollectionView,PaymentMethodSLEntityView> MainConsult { get; set; } 
        public PaymentMethodSL Screen { get; set; }
        public PaymentMethodSLCollectionView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class PaymentMethodSLEntityView : View
    {
        public PaymentMethodSLEntityView(PaymentMethodSL screen) : base()
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
 
            CodPaymentMethod = RPSControlFactory.CreateRPSTextBox<PaymentMethodSLEntityView>("034b99bf-0bc3-4281-bd52-a6c55b11f32c","","",true, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<PaymentMethodSLEntityView>("a3708e21-4dac-42ed-8aad-4c3c3ed6626b","","",false, this);
 
            IDPaymentType = RPSControlFactory.CreateRPSComboBox<PaymentMethodSLEntityView>("9091fb12-8032-48d3-817a-2c7facb5aec5","","",true, this);
 
            IDPaymentTypeCash = RPSControlFactory.CreateRPSComboBox<PaymentMethodSLEntityView>("201bc331-92c8-4026-adb8-c62919e8a5b2","","",false, this);
 
            IDPaymentStatusCash = RPSControlFactory.CreateRPSComboBox<PaymentMethodSLEntityView>("c910d77c-7e09-4016-a3c5-9bd34cc06fd3","","",false, this);
 
            DraftNumber = RPSControlFactory.CreateRPSFormattedTextBox<PaymentMethodSLEntityView>("b51b4272-c352-4c87-9224-114a9fc0e255","","",true, this);
 
            DueDateCalculation1 = RPSControlFactory.CreateRPSFormattedTextBox<PaymentMethodSLEntityView>("8498a278-cc9f-47f9-984f-5bfa832bb98b","","",true, this);
 
            GapBetweenDraft = RPSControlFactory.CreateRPSFormattedTextBox<PaymentMethodSLEntityView>("3e7d80a7-d725-44b3-b4e8-2ab0af4083a2","","",true, this);
 
            CommercialMonth = RPSControlFactory.CreateRPSCheckBox<PaymentMethodSLEntityView>("e012513a-77d9-43e1-ab07-a3de51b03b58","","",true, this);
 
            CashDiscount = RPSControlFactory.CreateRPSFormattedTextBox<PaymentMethodSLEntityView>("98c43e82-cab5-4932-a02c-b99d6a41d67d","","",true, this);
 
            FinancialSurcharge = RPSControlFactory.CreateRPSFormattedTextBox<PaymentMethodSLEntityView>("87ac79fb-2115-4f22-bba2-39ba4c513897","","",true, this);
 
            SalesDesk = RPSControlFactory.CreateRPSCheckBox<PaymentMethodSLEntityView>("6db07c2d-9ba8-4323-a3d8-1fd53a019174","","",true, this);
 
            Limit = RPSControlFactory.CreateRPSCheckBox<PaymentMethodSLEntityView>("15bb8b28-422d-4339-b651-675fbdf672a5","","",true, this);
 
            LimitDays = RPSControlFactory.CreateRPSFormattedTextBox<PaymentMethodSLEntityView>("6a5f4d56-368c-42aa-8108-9ef3084a1d8c","","",true, this);
 
            CD = RPSControlFactory.CreateRPSCheckBox<PaymentMethodSLEntityView>("ea43c91a-b3e4-45c2-a12b-7659301a01b8","","",true, this);
 
            CDDueDateCalculation = RPSControlFactory.CreateRPSFormattedTextBox<PaymentMethodSLEntityView>("445a4dfa-f117-4879-9cb8-8d4718ae0775","","",true, this);
 
            CDPercentage = RPSControlFactory.CreateRPSFormattedTextBox<PaymentMethodSLEntityView>("068dbe5d-3656-4916-87d2-009cfd0ec104","","",true, this);
 
            CDToleranceDays = RPSControlFactory.CreateRPSFormattedTextBox<PaymentMethodSLEntityView>("b4aaca00-462d-499d-a3f9-f1e3f46c0659","","",true, this);
 
            CDTolerancePercentage = RPSControlFactory.CreateRPSFormattedTextBox<PaymentMethodSLEntityView>("1df1a258-f64e-4a56-9e7c-4293e2bca751","","",true, this);
 
            CollectionInit params_PaymentMethodByLangSLs = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="d789c705-91b2-475f-99f4-5d77256d6d7b",CSSSelectorGrid="",XPathGrid=""};
            PaymentMethodByLangSLs = RPSControlFactory.RPSCreateCollectionWithGrid<PaymentMethodByLangSLsCollectionEditor<PaymentMethodSLEntityView,PaymentMethodByLangSLView>,PaymentMethodSLEntityView,PaymentMethodByLangSLView>( params_PaymentMethodByLangSLs,this,Screen.PaymentMethodByLangSLView);
 
            GeneralData = RPSControlFactory.CreateRPSSection<PaymentMethodSLEntityView>( "","ul li[rpsid='d90f2ca8-678f-4c67-9c25-6b54463fb774']","",this);
 
            PaymentMethodByLangSL = RPSControlFactory.CreateRPSSection<PaymentMethodSLEntityView>( "","ul li[rpsid='3e8a937d-86d9-46c7-9fe2-0cdb4539d406']","",this);
 

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
        public IRPSTextBox<PaymentMethodSLEntityView> CashDiscount { get; set; } 
        public IRPSTextBox<PaymentMethodSLEntityView> FinancialSurcharge { get; set; } 
        public IRPSCheckbox<PaymentMethodSLEntityView> SalesDesk { get; set; } 
        public IRPSCheckbox<PaymentMethodSLEntityView> Limit { get; set; } 
        public IRPSTextBox<PaymentMethodSLEntityView> LimitDays { get; set; } 
        public IRPSCheckbox<PaymentMethodSLEntityView> CD { get; set; } 
        public IRPSTextBox<PaymentMethodSLEntityView> CDDueDateCalculation { get; set; } 
        public IRPSTextBox<PaymentMethodSLEntityView> CDPercentage { get; set; } 
        public IRPSTextBox<PaymentMethodSLEntityView> CDToleranceDays { get; set; } 
        public IRPSTextBox<PaymentMethodSLEntityView> CDTolerancePercentage { get; set; } 
        public PaymentMethodByLangSLsCollectionEditor<PaymentMethodSLEntityView,PaymentMethodByLangSLView> PaymentMethodByLangSLs { get; set; } 
        public IRPSSection<PaymentMethodSLEntityView> GeneralData { get; set; } 
        public IRPSSection<PaymentMethodSLEntityView> PaymentMethodByLangSL { get; set; } 
        public PaymentMethodSL Screen { get; set; }
        public PaymentMethodSLEntityView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class PaymentMethodByLangSLsCollectionEditor<PaymentMethodSLEntityView,PaymentMethodByLangSLView>:RPSCollectionEditor<PaymentMethodSLEntityView,PaymentMethodByLangSLView> where PaymentMethodSLEntityView : class, IView where PaymentMethodByLangSLView : class, IView
    {
        public  PaymentMethodByLangSLsGridView<PaymentMethodSLEntityView,PaymentMethodByLangSLView> GridView {get;set;}
    }
    public partial class PaymentMethodByLangSLsGridView <PaymentMethodSLEntityView,PaymentMethodByLangSLView> :  RPSGridView<PaymentMethodSLEntityView,PaymentMethodByLangSLView> where PaymentMethodSLEntityView : class, IView where PaymentMethodByLangSLView : class, IView
    {
        public PaymentMethodByLangSLsGridView(PaymentMethodSLEntityView currentView,PaymentMethodByLangSLView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            CodLanguage = RPSControlFactory.CreateRPSGridComboBox<PaymentMethodSLEntityView>("","#d789c705-91b2-475f-99f4-5d77256d6d7b .ag-row[role='row']@ROWINDEX [col-id='cCodLanguage']","",true, this.CurrentView);
 
            Description = RPSControlFactory.CreateRPSGridTextBox<PaymentMethodSLEntityView>("","#d789c705-91b2-475f-99f4-5d77256d6d7b .ag-row[role='row']@ROWINDEX [col-id='cDescription']","",false, this.CurrentView);
 

        }
        public IRPSGridComboBox<PaymentMethodSLEntityView> CodLanguage { get; set; } 
        public IRPSGridTextBox<PaymentMethodSLEntityView> Description { get; set; } 
                     
    }
 
    }
  
            
    public partial class PaymentMethodByLangSLView : View
    {
        public PaymentMethodByLangSLView(PaymentMethodSL screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            DeleteButton = RPSControlFactory.RPSDeleteButton<PaymentMethodByLangSLView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<PaymentMethodByLangSLView,PaymentMethodSLEntityView>( this,Screen.PaymentMethodSLEntityView);
 
            BackButton = RPSControlFactory.RPSBackButton<PaymentMethodByLangSLView,PaymentMethodSLEntityView>( this,Screen.PaymentMethodSLEntityView);
 
            AcceptButton = RPSControlFactory.RPSAcceptButton<PaymentMethodByLangSLView,PaymentMethodSLEntityView>( this,Screen.PaymentMethodSLEntityView);
 
            CodLanguage = RPSControlFactory.CreateRPSComboBox<PaymentMethodByLangSLView>("46b73e8a-fa41-40db-9cda-46f629b2c69d","","",true, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<PaymentMethodByLangSLView>("c3766a25-c365-4fcc-97f9-37aef4e500c1","","",false, this);
 

        }
        public IRPSButton<PaymentMethodByLangSLView> DeleteButton { get; set; } 
        public IRPSButton<PaymentMethodByLangSLView,PaymentMethodSLEntityView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<PaymentMethodByLangSLView,PaymentMethodSLEntityView> BackButton { get; set; } 
        public IRPSAcceptButton<PaymentMethodByLangSLView,PaymentMethodSLEntityView> AcceptButton { get; set; } 
        public IRPSComboBox<PaymentMethodByLangSLView> CodLanguage { get; set; } 
        public IRPSTextBox<PaymentMethodByLangSLView> Description { get; set; } 
        public PaymentMethodSL Screen { get; set; }
        public PaymentMethodByLangSLView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}