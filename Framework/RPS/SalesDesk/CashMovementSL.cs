    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.SalesDesk.CashMovementSL
{
    //RPS VERSION 1.0.0.0
    public partial class CashMovementSL:Screen
    {
        public CashMovementSL():base()
        {
            this.URL = "salesdesk.cashmovementsl";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            CashMovementSLVMCollectionView  = new CashMovementSLVMCollectionView(this); 
            CashMovementSLVMEntityView  = new CashMovementSLVMEntityView(this); 
            CashMovementSLVMCollectionView.InitializeControls(); 
            CashMovementSLVMEntityView.InitializeControls(); 
           
        }
      
            public CashMovementSLVMCollectionView CashMovementSLVMCollectionView {get; set; } 
            public CashMovementSLVMEntityView CashMovementSLVMEntityView {get; set; } 
    }
            
    public partial class CashMovementSLVMCollectionView : View
    {
        public CashMovementSLVMCollectionView(CashMovementSL screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            IDCashMovementTypeSL = RPSControlFactory.CreateRPSComboBox<CashMovementSLVMCollectionView>("bdc50aaa-55e0-4719-ae16-2e55e3aa549a","","",false, this);
 
            eMovementType = RPSControlFactory.CreateRPSEnumComboBox<CashMovementSLVMCollectionView>("ad317a3b-1824-4f24-97f0-9b173aeab599","","",false, this);
 
            MovementDateTime = RPSControlFactory.CreateRPSTextBox<CashMovementSLVMCollectionView>("882c6503-fdc0-49e8-a9ef-d28bf95f5067","","",true, this);
 
            CollectionInit params_CashMovementSLDummySourceQuery = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="aeb583a1-f6c7-421a-8f30-cc26ef012668",CSSSelectorGrid="",XPathGrid=""};
            CashMovementSLDummySourceQuery = RPSControlFactory.RPSCreateCollectionWithGrid<CashMovementSLDummySourceQueryCollectionEditor<CashMovementSLVMCollectionView,CashMovementSLVMEntityView>,CashMovementSLVMCollectionView,CashMovementSLVMEntityView>( params_CashMovementSLDummySourceQuery,this,Screen.CashMovementSLVMEntityView);
 

        }
        public IRPSComboBox<CashMovementSLVMCollectionView> IDCashMovementTypeSL { get; set; } 
        public IRPSComboBox<CashMovementSLVMCollectionView> eMovementType { get; set; } 
        public IRPSTextBox<CashMovementSLVMCollectionView> MovementDateTime { get; set; } 
        public CashMovementSLDummySourceQueryCollectionEditor<CashMovementSLVMCollectionView,CashMovementSLVMEntityView> CashMovementSLDummySourceQuery { get; set; } 
        public CashMovementSL Screen { get; set; }
        public CashMovementSLVMCollectionView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class CashMovementSLDummySourceQueryCollectionEditor<CashMovementSLVMCollectionView,CashMovementSLVMEntityView>:RPSCollectionEditor<CashMovementSLVMCollectionView,CashMovementSLVMEntityView> where CashMovementSLVMCollectionView : class, IView where CashMovementSLVMEntityView : class, IView
    {
        public  CashMovementSLDummySourceQueryGridView<CashMovementSLVMCollectionView,CashMovementSLVMEntityView> GridView {get;set;}
    }
    public partial class CashMovementSLDummySourceQueryGridView <CashMovementSLVMCollectionView,CashMovementSLVMEntityView> :  RPSGridView<CashMovementSLVMCollectionView,CashMovementSLVMEntityView> where CashMovementSLVMCollectionView : class, IView where CashMovementSLVMEntityView : class, IView
    {
        public CashMovementSLDummySourceQueryGridView(CashMovementSLVMCollectionView currentView,CashMovementSLVMEntityView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            IDPaymentMethod = RPSControlFactory.CreateRPSGridComboBox<CashMovementSLVMCollectionView>("","#aeb583a1-f6c7-421a-8f30-cc26ef012668 .ag-row[role='row']@ROWINDEX [col-id='cIDPaymentMethod']","",true, this.CurrentView);
 
            IDCurrency = RPSControlFactory.CreateRPSGridComboBox<CashMovementSLVMCollectionView>("","#aeb583a1-f6c7-421a-8f30-cc26ef012668 .ag-row[role='row']@ROWINDEX [col-id='cIDCurrency']","",true, this.CurrentView);
 
            CashMovementDate = RPSControlFactory.CreateRPSGridTextBox<CashMovementSLVMCollectionView>("","#aeb583a1-f6c7-421a-8f30-cc26ef012668 .ag-row[role='row']@ROWINDEX [col-id='cCashMovementDate']","",true, this.CurrentView);
 
            AmountCalculated = RPSControlFactory.CreateRPSGridFormattedTextBox<CashMovementSLVMCollectionView>("","#aeb583a1-f6c7-421a-8f30-cc26ef012668 .ag-row[role='row']@ROWINDEX [col-id='cAmountCalculated']","",false, this.CurrentView);
 
            Amount = RPSControlFactory.CreateRPSGridFormattedTextBox<CashMovementSLVMCollectionView>("","#aeb583a1-f6c7-421a-8f30-cc26ef012668 .ag-row[role='row']@ROWINDEX [col-id='cAmount']","",true, this.CurrentView);
 
            Description = RPSControlFactory.CreateRPSGridTextBox<CashMovementSLVMCollectionView>("","#aeb583a1-f6c7-421a-8f30-cc26ef012668 .ag-row[role='row']@ROWINDEX [col-id='cDescription']","",false, this.CurrentView);
 
            IDCustomer = RPSControlFactory.CreateRPSGridComboBox<CashMovementSLVMCollectionView>("","#aeb583a1-f6c7-421a-8f30-cc26ef012668 .ag-row[role='row']@ROWINDEX [col-id='cIDCustomer']","",false, this.CurrentView);
 
            Supplier = RPSControlFactory.CreateRPSGridEnumComboBox<CashMovementSLVMCollectionView>("","#aeb583a1-f6c7-421a-8f30-cc26ef012668 .ag-row[role='row']@ROWINDEX [col-id='cSupplier']","",false, this.CurrentView);
 
            IDInvoice = RPSControlFactory.CreateRPSGridComboBox<CashMovementSLVMCollectionView>("","#aeb583a1-f6c7-421a-8f30-cc26ef012668 .ag-row[role='row']@ROWINDEX [col-id='cIDInvoice']","",false, this.CurrentView);
 
            InvoicePurchase = RPSControlFactory.CreateRPSGridTextBox<CashMovementSLVMCollectionView>("","#aeb583a1-f6c7-421a-8f30-cc26ef012668 .ag-row[role='row']@ROWINDEX [col-id='cInvoicePurchase']","",false, this.CurrentView);
 

        }
        public IRPSGridComboBox<CashMovementSLVMCollectionView> IDPaymentMethod { get; set; } 
        public IRPSGridComboBox<CashMovementSLVMCollectionView> IDCurrency { get; set; } 
        public IRPSGridTextBox<CashMovementSLVMCollectionView> CashMovementDate { get; set; } 
        public IRPSGridTextBox<CashMovementSLVMCollectionView> AmountCalculated { get; set; } 
        public IRPSGridTextBox<CashMovementSLVMCollectionView> Amount { get; set; } 
        public IRPSGridTextBox<CashMovementSLVMCollectionView> Description { get; set; } 
        public IRPSGridComboBox<CashMovementSLVMCollectionView> IDCustomer { get; set; } 
        public IRPSGridComboBox<CashMovementSLVMCollectionView> Supplier { get; set; } 
        public IRPSGridComboBox<CashMovementSLVMCollectionView> IDInvoice { get; set; } 
        public IRPSGridTextBox<CashMovementSLVMCollectionView> InvoicePurchase { get; set; } 
                     
    }
 
    }
  
            
    public partial class CashMovementSLVMEntityView : View
    {
        public CashMovementSLVMEntityView(CashMovementSL screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            DeleteButton = RPSControlFactory.RPSDeleteButton<CashMovementSLVMEntityView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<CashMovementSLVMEntityView,CashMovementSLVMCollectionView>( this,Screen.CashMovementSLVMCollectionView);
 
            BackButton = RPSControlFactory.RPSBackButton<CashMovementSLVMEntityView,CashMovementSLVMCollectionView>( this,Screen.CashMovementSLVMCollectionView);
 
            AcceptButton = RPSControlFactory.RPSAcceptButton<CashMovementSLVMEntityView,CashMovementSLVMCollectionView>( this,Screen.CashMovementSLVMCollectionView);
 
            IDCashPayment = RPSControlFactory.CreateRPSComboBox<CashMovementSLVMEntityView>("fcee6fe3-4157-43c0-9e96-1d1719da0dbd","","",true, this);
 
            IDCommercialAgent = RPSControlFactory.CreateRPSComboBox<CashMovementSLVMEntityView>("157e5e74-ad01-4c14-ba3a-638db3ae2bc0","","",true, this);
 
            IDCashMovementType = RPSControlFactory.CreateRPSComboBox<CashMovementSLVMEntityView>("bec65bff-0365-40fe-bb48-9f39ebe0ad92","","",true, this);
 
            IDPaymentMethod = RPSControlFactory.CreateRPSComboBox<CashMovementSLVMEntityView>("4df3cbc3-243d-48b0-8b50-dcfe858d20ac","","",true, this);
 
            CashMovementDate = RPSControlFactory.CreateRPSTextBox<CashMovementSLVMEntityView>("dff6d5a4-8ebb-43ab-ab9e-bbef2eeeff26","","",true, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<CashMovementSLVMEntityView>("87cace58-b179-4a21-a075-d55fb9dbd897","","",false, this);
 
            IDCurrency = RPSControlFactory.CreateRPSComboBox<CashMovementSLVMEntityView>("95f67019-42a4-442b-b9d4-51df755e5f36","","",true, this);
 
            AmountCalculated = RPSControlFactory.CreateRPSFormattedTextBox<CashMovementSLVMEntityView>("4ae4673e-99f3-42c8-91a9-7d26f7349487","","",false, this);
 
            Amount = RPSControlFactory.CreateRPSFormattedTextBox<CashMovementSLVMEntityView>("c7d6e41c-da51-4b9e-99a9-b4a0cf31fe32","","",true, this);
 
            IDCustomer = RPSControlFactory.CreateRPSComboBox<CashMovementSLVMEntityView>("e1372a80-038f-4027-a2ac-d93f1bed5176","","",false, this);
 
            Supplier = RPSControlFactory.CreateRPSEnumComboBox<CashMovementSLVMEntityView>("22b2e82d-15ea-4039-b2a5-67fe7b3e2e30","","",false, this);
 
            IDInvoice = RPSControlFactory.CreateRPSComboBox<CashMovementSLVMEntityView>("99675f98-4d5f-4209-b3c6-9732d361540e","","",false, this);
 
            InvoicePurchase = RPSControlFactory.CreateRPSTextBox<CashMovementSLVMEntityView>("7b2dfdb6-5380-4795-93b5-45c702c7d9cb","","",false, this);
 

        }
        public IRPSButton<CashMovementSLVMEntityView> DeleteButton { get; set; } 
        public IRPSButton<CashMovementSLVMEntityView,CashMovementSLVMCollectionView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<CashMovementSLVMEntityView,CashMovementSLVMCollectionView> BackButton { get; set; } 
        public IRPSAcceptButton<CashMovementSLVMEntityView,CashMovementSLVMCollectionView> AcceptButton { get; set; } 
        public IRPSComboBox<CashMovementSLVMEntityView> IDCashPayment { get; set; } 
        public IRPSComboBox<CashMovementSLVMEntityView> IDCommercialAgent { get; set; } 
        public IRPSComboBox<CashMovementSLVMEntityView> IDCashMovementType { get; set; } 
        public IRPSComboBox<CashMovementSLVMEntityView> IDPaymentMethod { get; set; } 
        public IRPSTextBox<CashMovementSLVMEntityView> CashMovementDate { get; set; } 
        public IRPSTextBox<CashMovementSLVMEntityView> Description { get; set; } 
        public IRPSComboBox<CashMovementSLVMEntityView> IDCurrency { get; set; } 
        public IRPSTextBox<CashMovementSLVMEntityView> AmountCalculated { get; set; } 
        public IRPSTextBox<CashMovementSLVMEntityView> Amount { get; set; } 
        public IRPSComboBox<CashMovementSLVMEntityView> IDCustomer { get; set; } 
        public IRPSComboBox<CashMovementSLVMEntityView> Supplier { get; set; } 
        public IRPSComboBox<CashMovementSLVMEntityView> IDInvoice { get; set; } 
        public IRPSTextBox<CashMovementSLVMEntityView> InvoicePurchase { get; set; } 
        public CashMovementSL Screen { get; set; }
        public CashMovementSLVMEntityView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}