    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.Purchase.OrderAdvanceInvoice
{
    //RPS VERSION 1.0.0.0
    public partial class OrderAdvanceInvoice:Screen
    {
        public OrderAdvanceInvoice():base()
        {
            this.URL = "purchase.orderadvanceinvoice";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            OrderAdvanceInvoiceView  = new OrderAdvanceInvoiceView(this); 
            InvoicePaymentView  = new InvoicePaymentView(this); 
            InvoiceView  = new InvoiceView(this); 
            OrderAdvanceInvoiceView.InitializeControls(); 
            InvoicePaymentView.InitializeControls(); 
            InvoiceView.InitializeControls(); 
           
        }
      
            public OrderAdvanceInvoiceView OrderAdvanceInvoiceView {get; set; } 
            public InvoicePaymentView InvoicePaymentView {get; set; } 
            public InvoiceView InvoiceView {get; set; } 
    }
            
    public partial class OrderAdvanceInvoiceView : View
    {
        public OrderAdvanceInvoiceView(OrderAdvanceInvoice screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            Order = RPSControlFactory.CreateRPSComboBox<OrderAdvanceInvoiceView>("82551e36-abc4-4047-8cdd-56fdcd29f6d0","","",true, this);
 
            OrderAdvanceDateFrom = RPSControlFactory.CreateRPSTextBox<OrderAdvanceInvoiceView>("3031ef52-6961-444e-9c3b-b3423921f494","","",false, this);
 
            OrderAdvanceDateTo = RPSControlFactory.CreateRPSTextBox<OrderAdvanceInvoiceView>("4959991b-406d-46f8-93d4-7c717852bc07","","",false, this);
 
            NewInvoice = RPSControlFactory.CreateRPSTextBox<OrderAdvanceInvoiceView>("9977f346-77d3-45cf-a247-87acb1066df7","","",true, this);
 
            InvoiceDate = RPSControlFactory.CreateRPSTextBox<OrderAdvanceInvoiceView>("ef00e515-3c56-43c2-a4c7-172e53978586","","",true, this);
 
            AccountingDate = RPSControlFactory.CreateRPSTextBox<OrderAdvanceInvoiceView>("6baa4ef2-a5d9-440f-badd-33e789cdcc1d","","",true, this);
 
            GenerateInvoice = RPSControlFactory.CreateRPSButton<OrderAdvanceInvoiceView>( "fd9960e4-67e1-4026-9216-b41fd748c6de","","",this);
 

        }
        public IRPSComboBox<OrderAdvanceInvoiceView> Order { get; set; } 
        public IRPSTextBox<OrderAdvanceInvoiceView> OrderAdvanceDateFrom { get; set; } 
        public IRPSTextBox<OrderAdvanceInvoiceView> OrderAdvanceDateTo { get; set; } 
        public IRPSTextBox<OrderAdvanceInvoiceView> NewInvoice { get; set; } 
        public IRPSTextBox<OrderAdvanceInvoiceView> InvoiceDate { get; set; } 
        public IRPSTextBox<OrderAdvanceInvoiceView> AccountingDate { get; set; } 
        public IRPSButton<OrderAdvanceInvoiceView> GenerateInvoice { get; set; } 
        public OrderAdvanceInvoice Screen { get; set; }
        public OrderAdvanceInvoiceView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class InvoicePaymentView : View
    {
        public InvoicePaymentView(OrderAdvanceInvoice screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            DeleteButton = RPSControlFactory.RPSDeleteButton<InvoicePaymentView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<InvoicePaymentView,InvoiceView>( this,Screen.InvoiceView);
 
            BackButton = RPSControlFactory.RPSBackButton<InvoicePaymentView,InvoiceView>( this,Screen.InvoiceView);
 
            AcceptButton = RPSControlFactory.RPSAcceptButton<InvoicePaymentView,InvoiceView>( this,Screen.InvoiceView);
 
            IDPaymentMethod = RPSControlFactory.CreateRPSComboBox<InvoicePaymentView>("f891d14c-2bb1-4636-a567-da2bc40e80cf","","",false, this);
 
            NumPayment = RPSControlFactory.CreateRPSFormattedTextBox<InvoicePaymentView>("3086e16f-dfc8-460d-923b-d6a701536d9e","","",true, this);
 
            Date = RPSControlFactory.CreateRPSTextBox<InvoicePaymentView>("1aa58fe8-73b5-4f09-9d68-188ba60ff43e","","",true, this);
 
            Amount = RPSControlFactory.CreateRPSFormattedTextBox<InvoicePaymentView>("30bbcea0-e234-4b7c-b81e-e6ef81a59afe","","",true, this);
 
            CDDate = RPSControlFactory.CreateRPSTextBox<InvoicePaymentView>("46e0d750-85fd-4061-ba23-decfc1e66804","","",false, this);
 
            CDAmount = RPSControlFactory.CreateRPSFormattedTextBox<InvoicePaymentView>("3950b87c-5cc4-4c63-87b6-ed28cfacfa4f","","",true, this);
 
            CDToleranceDate = RPSControlFactory.CreateRPSTextBox<InvoicePaymentView>("e96575b0-1021-4d08-bdb3-77d4ff00d6f6","","",false, this);
 
            CDToleranceAmount = RPSControlFactory.CreateRPSFormattedTextBox<InvoicePaymentView>("b07c4caf-67a9-4710-b8b7-6038a14d438e","","",true, this);
 
            CDPercentage = RPSControlFactory.CreateRPSFormattedTextBox<InvoicePaymentView>("79f456af-a0b8-48a0-8905-3802df700faf","","",true, this);
 

        }
        public IRPSButton<InvoicePaymentView> DeleteButton { get; set; } 
        public IRPSButton<InvoicePaymentView,InvoiceView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<InvoicePaymentView,InvoiceView> BackButton { get; set; } 
        public IRPSAcceptButton<InvoicePaymentView,InvoiceView> AcceptButton { get; set; } 
        public IRPSComboBox<InvoicePaymentView> IDPaymentMethod { get; set; } 
        public IRPSTextBox<InvoicePaymentView> NumPayment { get; set; } 
        public IRPSTextBox<InvoicePaymentView> Date { get; set; } 
        public IRPSTextBox<InvoicePaymentView> Amount { get; set; } 
        public IRPSTextBox<InvoicePaymentView> CDDate { get; set; } 
        public IRPSTextBox<InvoicePaymentView> CDAmount { get; set; } 
        public IRPSTextBox<InvoicePaymentView> CDToleranceDate { get; set; } 
        public IRPSTextBox<InvoicePaymentView> CDToleranceAmount { get; set; } 
        public IRPSTextBox<InvoicePaymentView> CDPercentage { get; set; } 
        public OrderAdvanceInvoice Screen { get; set; }
        public InvoicePaymentView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class InvoiceView : View
    {
        public InvoiceView(OrderAdvanceInvoice screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            SaveButton = RPSControlFactory.RPSSaveButton<InvoiceView>( this);
 
            DeleteButton = RPSControlFactory.RPSDeleteButton<InvoiceView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<InvoiceView,OrderAdvanceInvoiceView>( this,Screen.OrderAdvanceInvoiceView);
 
            BackButton = RPSControlFactory.RPSBackButton<InvoiceView,OrderAdvanceInvoiceView>( this,Screen.OrderAdvanceInvoiceView);
 
            CompanyName1 = RPSControlFactory.CreateRPSTextBox<InvoiceView>("5321109a-27a8-41c4-bb2e-142e826de6b3","","",false, this);
 
            VATNumber = RPSControlFactory.CreateRPSTextBox<InvoiceView>("40ed3beb-cf1f-4b60-808c-14cb896cdff0","","",false, this);
 
            TotalCalc = RPSControlFactory.CreateRPSFormattedTextBox<InvoiceView>("5ad6be59-2337-4fdd-b009-d10f7accefb3","","",false, this);
 
            Print = RPSControlFactory.CreateRPSCheckBox<InvoiceView>("2bba8ae1-d15c-4854-80f0-04325e61b1ca","","",false, this);
 
            TotalInvoice = RPSControlFactory.CreateRPSFormattedTextBox<InvoiceView>("d4f8a9ad-5dcc-4990-bc51-ef57b53df7c9","","",true, this);
 
            TotalBase = RPSControlFactory.CreateRPSFormattedTextBox<InvoiceView>("97437cfa-36fd-4ebb-8ea2-77e54379906b","","",false, this);
 
            RetentionPercent = RPSControlFactory.CreateRPSFormattedTextBox<InvoiceView>("952f9557-6dee-4cd9-bbaf-4f707a477c24","","",true, this);
 
            VATAmount = RPSControlFactory.CreateRPSFormattedTextBox<InvoiceView>("b8d1e8aa-b3cf-452d-aa93-508e9148110d","","",true, this);
 
            SurchargeAmount = RPSControlFactory.CreateRPSFormattedTextBox<InvoiceView>("2f80f2bf-8c15-4c0f-9f96-e8ef300a0a18","","",true, this);
 
            Retention = RPSControlFactory.CreateRPSFormattedTextBox<InvoiceView>("33a3a276-63af-4eee-a2e1-c3da57584d91","","",true, this);
 
            TotalTaxInvoice = RPSControlFactory.CreateRPSFormattedTextBox<InvoiceView>("f5f1efd1-b457-4748-928c-4b55c42c19e0","","",false, this);
 
            FinancialSurchargeAmount = RPSControlFactory.CreateRPSFormattedTextBox<InvoiceView>("bfe2cb21-9dfe-4ff6-b72b-531802c67dd0","","",true, this);
 
            Discount1 = RPSControlFactory.CreateRPSFormattedTextBox<InvoiceView>("1c505c9c-683f-41d7-99ad-64986afe45ec","","",true, this);
 
            Discount2 = RPSControlFactory.CreateRPSFormattedTextBox<InvoiceView>("40596688-679d-4f97-b1b4-32ec99786f09","","",true, this);
 
            Discount3 = RPSControlFactory.CreateRPSFormattedTextBox<InvoiceView>("ac4d8498-e705-4b33-a530-122e04a5eef6","","",true, this);
 
            FinancialSurcharge = RPSControlFactory.CreateRPSFormattedTextBox<InvoiceView>("a78974d3-747d-4067-b406-4bc41e9ce152","","",true, this);
 
            CashDiscount = RPSControlFactory.CreateRPSFormattedTextBox<InvoiceView>("8477c4ca-aae0-4b50-a3ab-a3465cedb7ff","","",true, this);
 
            VATBase1 = RPSControlFactory.CreateRPSFormattedTextBox<InvoiceView>("793e730f-5151-4b89-8939-ecec4986d09f","","",true, this);
 
            VATBase2 = RPSControlFactory.CreateRPSFormattedTextBox<InvoiceView>("5565fae3-d946-4a12-9a96-32a67ce438ea","","",true, this);
 
            VATBase3 = RPSControlFactory.CreateRPSFormattedTextBox<InvoiceView>("df26f2cb-7f75-4491-a3d9-0ac3ef653c48","","",true, this);
 
            VATBase4 = RPSControlFactory.CreateRPSFormattedTextBox<InvoiceView>("3599344b-64b0-47f7-a7d9-81ff0d4002b4","","",true, this);
 
            VATBase5 = RPSControlFactory.CreateRPSFormattedTextBox<InvoiceView>("5b207dc9-7ec4-4086-820b-05a4cd17a21f","","",true, this);
 
            VATBase6 = RPSControlFactory.CreateRPSFormattedTextBox<InvoiceView>("8dd4b4cd-131c-448a-9160-767abcf46405","","",true, this);
 
            VATAmount1 = RPSControlFactory.CreateRPSFormattedTextBox<InvoiceView>("b826348b-6e8d-4902-acba-c72a162ce384","","",true, this);
 
            VATAmount2 = RPSControlFactory.CreateRPSFormattedTextBox<InvoiceView>("95cd8f8d-a711-49eb-8885-357c660675ae","","",true, this);
 
            VATAmount3 = RPSControlFactory.CreateRPSFormattedTextBox<InvoiceView>("9031e1a8-fe2f-4fd3-aa5b-ec2612cf5d71","","",true, this);
 
            VATAmount4 = RPSControlFactory.CreateRPSFormattedTextBox<InvoiceView>("be90a161-4d84-4a12-9a8e-f5cce1e6cba7","","",true, this);
 
            VATAmount5 = RPSControlFactory.CreateRPSFormattedTextBox<InvoiceView>("989b1140-601c-49a5-a30a-168dc9f0582e","","",true, this);
 
            VATAmount6 = RPSControlFactory.CreateRPSFormattedTextBox<InvoiceView>("92f2666f-e082-4ae2-961d-06dabaa8bb03","","",true, this);
 
            SurchargeAmount1 = RPSControlFactory.CreateRPSFormattedTextBox<InvoiceView>("83b168bf-5216-4f18-9927-5719c2a9e85c","","",true, this);
 
            SurchargeAmount2 = RPSControlFactory.CreateRPSFormattedTextBox<InvoiceView>("4070b448-6081-4ad3-9c6a-94f470dbaca6","","",true, this);
 
            SurchargeAmount3 = RPSControlFactory.CreateRPSFormattedTextBox<InvoiceView>("57c8d6f3-2032-49ef-bb38-f1260b808eed","","",true, this);
 
            SurchargeAmount4 = RPSControlFactory.CreateRPSFormattedTextBox<InvoiceView>("be56f611-c25b-4bd3-b6e1-b39b0153939c","","",true, this);
 
            SurchargeAmount5 = RPSControlFactory.CreateRPSFormattedTextBox<InvoiceView>("b786cbc1-ad38-4123-a749-d69fd2a4497e","","",true, this);
 
            SurchargeAmount6 = RPSControlFactory.CreateRPSFormattedTextBox<InvoiceView>("ef61be4d-fd60-4306-b8b5-afc4e2169f1a","","",true, this);
 
            UIOptSupplier = RPSControlFactory.CreateRPSOption<InvoiceView>( "32fb7aa7-c55f-4b98-ae32-86ab6462b3c5","","",this);
 
            UIOptSelected = RPSControlFactory.CreateRPSOption<InvoiceView>( "73dadcc0-dab4-44f7-a9f9-b7ce9cc2168e","","",this);
 
            Language = RPSControlFactory.CreateRPSComboBox<InvoiceView>("4fca428d-145e-4f15-b8f8-1b8b5ee86c38","","",false, this);
 
            UIPrintSpecificReport = RPSControlFactory.CreateRPSCheckBox<InvoiceView>("9c1df401-bd50-43fb-b41e-113600e64cc3","","",false, this);
 
            CustomReport = RPSControlFactory.CreateRPSComboBox<InvoiceView>("1b07afc5-e77d-4fd1-a233-ef923865c809","","",false, this);
 
            CollectionInit params_InvoicePayments1 = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="11d8e5ab-56bd-4400-9505-61df9e340517",CSSSelectorGrid="",XPathGrid=""};
            InvoicePayments1 = RPSControlFactory.RPSCreateCollectionWithGrid<InvoicePayments1CollectionEditor<InvoiceView,InvoicePaymentView>,InvoiceView,InvoicePaymentView>( params_InvoicePayments1,this,Screen.InvoicePaymentView);
 
            CollectionInit params_GetACCTransactionsTempFromPurchase = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="8a231bfc-4469-4014-8a5e-795355d69c3c",CSSSelectorGrid="",XPathGrid=""};
            GetACCTransactionsTempFromPurchase = RPSControlFactory.RPSCreateCollectionWithGrid<GetACCTransactionsTempFromPurchaseCollectionEditor<InvoiceView,InvoicePaymentView>,InvoiceView,InvoicePaymentView>( params_GetACCTransactionsTempFromPurchase,this,Screen.InvoicePaymentView);
 
            CollectionInit params_GetACCTransactionsTempAnalyticFromPurchase = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="29fa13ac-6c4a-4a78-b8a4-8d69847fcb36",CSSSelectorGrid="",XPathGrid=""};
            GetACCTransactionsTempAnalyticFromPurchase = RPSControlFactory.RPSCreateCollectionWithGrid<GetACCTransactionsTempAnalyticFromPurchaseCollectionEditor<InvoiceView,InvoicePaymentView>,InvoiceView,InvoicePaymentView>( params_GetACCTransactionsTempAnalyticFromPurchase,this,Screen.InvoicePaymentView);
 
            Section = RPSControlFactory.CreateRPSSection<InvoiceView>( "","ul li[rpsid='c76b22dd-6926-47d4-88cd-a9f6bf5e5670']","",this);
 
            SectionPayment = RPSControlFactory.CreateRPSSection<InvoiceView>( "","ul li[rpsid='4ff0a422-9a84-408d-8f38-f811c0afdf71']","",this);
 
            SectionGeneralLedger = RPSControlFactory.CreateRPSSection<InvoiceView>( "","ul li[rpsid='3b83db3b-d4d6-4b2e-a37d-25301075741c']","",this);
 
            SectionAnalytic = RPSControlFactory.CreateRPSSection<InvoiceView>( "","ul li[rpsid='0581c55e-485c-44bd-92ac-f9afca765af5']","",this);
 
            PrintSection = RPSControlFactory.CreateRPSSection<InvoiceView>( "","ul li[rpsid='153d5f8d-8159-4195-8028-7c53365bd067']","",this);
 

        }
        public IRPSSaveButton<InvoiceView> SaveButton { get; set; } 
        public IRPSButton<InvoiceView> DeleteButton { get; set; } 
        public IRPSButton<InvoiceView,OrderAdvanceInvoiceView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<InvoiceView,OrderAdvanceInvoiceView> BackButton { get; set; } 
        public IRPSTextBox<InvoiceView> CompanyName1 { get; set; } 
        public IRPSTextBox<InvoiceView> VATNumber { get; set; } 
        public IRPSTextBox<InvoiceView> TotalCalc { get; set; } 
        public IRPSCheckbox<InvoiceView> Print { get; set; } 
        public IRPSTextBox<InvoiceView> TotalInvoice { get; set; } 
        public IRPSTextBox<InvoiceView> TotalBase { get; set; } 
        public IRPSTextBox<InvoiceView> RetentionPercent { get; set; } 
        public IRPSTextBox<InvoiceView> VATAmount { get; set; } 
        public IRPSTextBox<InvoiceView> SurchargeAmount { get; set; } 
        public IRPSTextBox<InvoiceView> Retention { get; set; } 
        public IRPSTextBox<InvoiceView> TotalTaxInvoice { get; set; } 
        public IRPSTextBox<InvoiceView> FinancialSurchargeAmount { get; set; } 
        public IRPSTextBox<InvoiceView> Discount1 { get; set; } 
        public IRPSTextBox<InvoiceView> Discount2 { get; set; } 
        public IRPSTextBox<InvoiceView> Discount3 { get; set; } 
        public IRPSTextBox<InvoiceView> FinancialSurcharge { get; set; } 
        public IRPSTextBox<InvoiceView> CashDiscount { get; set; } 
        public IRPSTextBox<InvoiceView> VATBase1 { get; set; } 
        public IRPSTextBox<InvoiceView> VATBase2 { get; set; } 
        public IRPSTextBox<InvoiceView> VATBase3 { get; set; } 
        public IRPSTextBox<InvoiceView> VATBase4 { get; set; } 
        public IRPSTextBox<InvoiceView> VATBase5 { get; set; } 
        public IRPSTextBox<InvoiceView> VATBase6 { get; set; } 
        public IRPSTextBox<InvoiceView> VATAmount1 { get; set; } 
        public IRPSTextBox<InvoiceView> VATAmount2 { get; set; } 
        public IRPSTextBox<InvoiceView> VATAmount3 { get; set; } 
        public IRPSTextBox<InvoiceView> VATAmount4 { get; set; } 
        public IRPSTextBox<InvoiceView> VATAmount5 { get; set; } 
        public IRPSTextBox<InvoiceView> VATAmount6 { get; set; } 
        public IRPSTextBox<InvoiceView> SurchargeAmount1 { get; set; } 
        public IRPSTextBox<InvoiceView> SurchargeAmount2 { get; set; } 
        public IRPSTextBox<InvoiceView> SurchargeAmount3 { get; set; } 
        public IRPSTextBox<InvoiceView> SurchargeAmount4 { get; set; } 
        public IRPSTextBox<InvoiceView> SurchargeAmount5 { get; set; } 
        public IRPSTextBox<InvoiceView> SurchargeAmount6 { get; set; } 
        public IRPSOption<InvoiceView> UIOptSupplier { get; set; } 
        public IRPSOption<InvoiceView> UIOptSelected { get; set; } 
        public IRPSComboBox<InvoiceView> Language { get; set; } 
        public IRPSCheckbox<InvoiceView> UIPrintSpecificReport { get; set; } 
        public IRPSComboBox<InvoiceView> CustomReport { get; set; } 
        public InvoicePayments1CollectionEditor<InvoiceView,InvoicePaymentView> InvoicePayments1 { get; set; } 
        public GetACCTransactionsTempFromPurchaseCollectionEditor<InvoiceView,InvoicePaymentView> GetACCTransactionsTempFromPurchase { get; set; } 
        public GetACCTransactionsTempAnalyticFromPurchaseCollectionEditor<InvoiceView,InvoicePaymentView> GetACCTransactionsTempAnalyticFromPurchase { get; set; } 
        public IRPSSection<InvoiceView> Section { get; set; } 
        public IRPSSection<InvoiceView> SectionPayment { get; set; } 
        public IRPSSection<InvoiceView> SectionGeneralLedger { get; set; } 
        public IRPSSection<InvoiceView> SectionAnalytic { get; set; } 
        public IRPSSection<InvoiceView> PrintSection { get; set; } 
        public OrderAdvanceInvoice Screen { get; set; }
        public InvoiceView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class InvoicePayments1CollectionEditor<InvoiceView,InvoicePaymentView>:RPSCollectionEditor<InvoiceView,InvoicePaymentView> where InvoiceView : class, IView where InvoicePaymentView : class, IView
    {
        public  InvoicePayments1GridView<InvoiceView,InvoicePaymentView> GridView {get;set;}
    }
    public partial class InvoicePayments1GridView <InvoiceView,InvoicePaymentView> :  RPSGridView<InvoiceView,InvoicePaymentView> where InvoiceView : class, IView where InvoicePaymentView : class, IView
    {
        public InvoicePayments1GridView(InvoiceView currentView,InvoicePaymentView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            IDPaymentMethod = RPSControlFactory.CreateRPSGridComboBox<InvoiceView>("","#11d8e5ab-56bd-4400-9505-61df9e340517 .ag-row[role='row']@ROWINDEX [col-id='cIDPaymentMethod']","",false, this.CurrentView);
 
            NumPayment = RPSControlFactory.CreateRPSGridFormattedTextBox<InvoiceView>("","#11d8e5ab-56bd-4400-9505-61df9e340517 .ag-row[role='row']@ROWINDEX [col-id='cNumPayment']","",true, this.CurrentView);
 
            Date = RPSControlFactory.CreateRPSGridTextBox<InvoiceView>("","#11d8e5ab-56bd-4400-9505-61df9e340517 .ag-row[role='row']@ROWINDEX [col-id='cDate']","",true, this.CurrentView);
 
            Amount = RPSControlFactory.CreateRPSGridFormattedTextBox<InvoiceView>("","#11d8e5ab-56bd-4400-9505-61df9e340517 .ag-row[role='row']@ROWINDEX [col-id='cAmount']","",true, this.CurrentView);
 

        }
        public IRPSGridComboBox<InvoiceView> IDPaymentMethod { get; set; } 
        public IRPSGridTextBox<InvoiceView> NumPayment { get; set; } 
        public IRPSGridTextBox<InvoiceView> Date { get; set; } 
        public IRPSGridTextBox<InvoiceView> Amount { get; set; } 
                     
    }
 
        public partial class GetACCTransactionsTempFromPurchaseCollectionEditor<InvoiceView,InvoicePaymentView>:RPSCollectionEditor<InvoiceView,InvoicePaymentView> where InvoiceView : class, IView where InvoicePaymentView : class, IView
    {
        public  GetACCTransactionsTempFromPurchaseGridView<InvoiceView,InvoicePaymentView> GridView {get;set;}
    }
    public partial class GetACCTransactionsTempFromPurchaseGridView <InvoiceView,InvoicePaymentView> :  RPSGridView<InvoiceView,InvoicePaymentView> where InvoiceView : class, IView where InvoicePaymentView : class, IView
    {
        public GetACCTransactionsTempFromPurchaseGridView(InvoiceView currentView,InvoicePaymentView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            SignType = RPSControlFactory.CreateRPSGridTextBox<InvoiceView>("","#8a231bfc-4469-4014-8a5e-795355d69c3c .ag-row[role='row']@ROWINDEX [col-id='cSignType']","",false, this.CurrentView);
 
            Extension = RPSControlFactory.CreateRPSGridTextBox<InvoiceView>("","#8a231bfc-4469-4014-8a5e-795355d69c3c .ag-row[role='row']@ROWINDEX [col-id='cExtension']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<InvoiceView> SignType { get; set; } 
        public IRPSGridTextBox<InvoiceView> Extension { get; set; } 
                     
    }
 
        public partial class GetACCTransactionsTempAnalyticFromPurchaseCollectionEditor<InvoiceView,InvoicePaymentView>:RPSCollectionEditor<InvoiceView,InvoicePaymentView> where InvoiceView : class, IView where InvoicePaymentView : class, IView
    {
        public  GetACCTransactionsTempAnalyticFromPurchaseGridView<InvoiceView,InvoicePaymentView> GridView {get;set;}
    }
    public partial class GetACCTransactionsTempAnalyticFromPurchaseGridView <InvoiceView,InvoicePaymentView> :  RPSGridView<InvoiceView,InvoicePaymentView> where InvoiceView : class, IView where InvoicePaymentView : class, IView
    {
        public GetACCTransactionsTempAnalyticFromPurchaseGridView(InvoiceView currentView,InvoicePaymentView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {

        }
                     
    }
 
    }
  
    

}