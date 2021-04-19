    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.Purchase.RetentionInvoice
{
    //RPS VERSION 1.0.0.0
    public partial class RetentionInvoice:Screen
    {
        public RetentionInvoice():base()
        {
            this.URL = "purchase.retentioninvoice";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            RetentionInvoiceCollectionView  = new RetentionInvoiceCollectionView(this); 
            RetentionInvoiceEntityView  = new RetentionInvoiceEntityView(this); 
            RetentionInvoiceDetailView  = new RetentionInvoiceDetailView(this); 
            RetentionInvoicePrintDialogView  = new RetentionInvoicePrintDialogView(this); 
            RetentionInvoiceCollectionView.InitializeControls(); 
            RetentionInvoiceEntityView.InitializeControls(); 
            RetentionInvoiceDetailView.InitializeControls(); 
            RetentionInvoicePrintDialogView.InitializeControls(); 
           
        }
      
            public RetentionInvoiceCollectionView RetentionInvoiceCollectionView {get; set; } 
            public RetentionInvoiceEntityView RetentionInvoiceEntityView {get; set; } 
            public RetentionInvoiceDetailView RetentionInvoiceDetailView {get; set; } 
            public RetentionInvoicePrintDialogView RetentionInvoicePrintDialogView {get; set; } 
    }
            
    public partial class RetentionInvoiceCollectionView : View
    {
        public RetentionInvoiceCollectionView(RetentionInvoice screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            NewButton = RPSControlFactory.RPSNewButton<RetentionInvoiceCollectionView,RetentionInvoiceEntityView>( this,Screen.RetentionInvoiceEntityView);
 
            CollectionInit params_MainConsult = new CollectionInit(){IDDescriptor = "4d3045cb-d8d4-45dd-b917-5e2d8a556284",CSSSelectorDescriptor = "",XPathDescriptor = ""};
            MainConsult = RPSControlFactory.RPSCreateCollection<RetentionInvoiceCollectionView,RetentionInvoiceEntityView>( params_MainConsult,this,Screen.RetentionInvoiceEntityView);
 

        }
        public IRPSButton<RetentionInvoiceCollectionView,RetentionInvoiceEntityView> NewButton { get; set; } 
        public IRPSCollectionEditor<RetentionInvoiceCollectionView,RetentionInvoiceEntityView> MainConsult { get; set; } 
        public RetentionInvoice Screen { get; set; }
        public RetentionInvoiceCollectionView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class RetentionInvoiceEntityView : View
    {
        public RetentionInvoiceEntityView(RetentionInvoice screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            SaveButton = RPSControlFactory.RPSSaveButton<RetentionInvoiceEntityView>( this);
 
            DeleteButton = RPSControlFactory.RPSDeleteButton<RetentionInvoiceEntityView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<RetentionInvoiceEntityView,RetentionInvoiceCollectionView>( this,Screen.RetentionInvoiceCollectionView);
 
            BackButton = RPSControlFactory.RPSBackButton<RetentionInvoiceEntityView,RetentionInvoiceCollectionView>( this,Screen.RetentionInvoiceCollectionView);
 
            IDSupplier = RPSControlFactory.CreateRPSComboBox<RetentionInvoiceEntityView>("f5414e95-c388-40d6-b328-1e8a800fb26a","","",true, this);
 
            IDSupplierMiscellaneous = RPSControlFactory.CreateRPSComboBox<RetentionInvoiceEntityView>("2fb55fcc-73e2-411a-b69b-4c611e27f6b4","","",false, this);
 
            CodInvoice = RPSControlFactory.CreateRPSTextBox<RetentionInvoiceEntityView>("37941a8d-2a84-4d1e-adca-f170b26789b1","","",true, this);
 
            InvoiceDate = RPSControlFactory.CreateRPSTextBox<RetentionInvoiceEntityView>("29d5c64e-d6c5-4312-a26d-fe5977e3965a","","",true, this);
 
            AccoutingDate = RPSControlFactory.CreateRPSTextBox<RetentionInvoiceEntityView>("0443847a-4a6b-45f3-87ca-de25d88bbdcd","","",true, this);
 
            CodInvoiceRetention = RPSControlFactory.CreateRPSTextBox<RetentionInvoiceEntityView>("d1c49687-eb21-472b-981e-86daf01537f5","","",false, this);
 
            RetentionDate = RPSControlFactory.CreateRPSTextBox<RetentionInvoiceEntityView>("e9a7b165-70af-48aa-a188-3fe1539a01d7","","",false, this);
 
            TrueReportCommandButton = RPSControlFactory.CreateRPSButton<RetentionInvoiceEntityView>( "c2c883fe-42e0-4784-b1c9-0bde4ead9c62","","",this);
 
            ExecuteRetentionInvoiceEmailButton = RPSControlFactory.CreateRPSButton<RetentionInvoiceEntityView>( "5d706a75-7ed6-4b85-8018-903bc632a20d","","",this);
 
            RetentionInvoicePrintNavigationCommandButton = RPSControlFactory.CreateRPSButtonToView<RetentionInvoiceEntityView,RetentionInvoicePrintDialogView>("638a99eb-3a24-409f-ba1f-4e1d447c056b","","", this,Screen.RetentionInvoicePrintDialogView);
 
            ExecuteCancelRetentionInvoiceButton = RPSControlFactory.CreateRPSButton<RetentionInvoiceEntityView>( "31057b0a-b43e-4168-9de0-1fe38de44edc","","",this);
 
            CollectionInit params_RetentionInvoiceDetails = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="3defddcc-a583-43c7-b75f-fe0673b0f29b",CSSSelectorGrid="",XPathGrid=""};
            RetentionInvoiceDetails = RPSControlFactory.RPSCreateCollectionWithGrid<RetentionInvoiceDetailsCollectionEditor<RetentionInvoiceEntityView,RetentionInvoiceDetailView>,RetentionInvoiceEntityView,RetentionInvoiceDetailView>( params_RetentionInvoiceDetails,this,Screen.RetentionInvoiceDetailView);
 

        }
        public IRPSSaveButton<RetentionInvoiceEntityView> SaveButton { get; set; } 
        public IRPSButton<RetentionInvoiceEntityView> DeleteButton { get; set; } 
        public IRPSButton<RetentionInvoiceEntityView,RetentionInvoiceCollectionView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<RetentionInvoiceEntityView,RetentionInvoiceCollectionView> BackButton { get; set; } 
        public IRPSComboBox<RetentionInvoiceEntityView> IDSupplier { get; set; } 
        public IRPSComboBox<RetentionInvoiceEntityView> IDSupplierMiscellaneous { get; set; } 
        public IRPSTextBox<RetentionInvoiceEntityView> CodInvoice { get; set; } 
        public IRPSTextBox<RetentionInvoiceEntityView> InvoiceDate { get; set; } 
        public IRPSTextBox<RetentionInvoiceEntityView> AccoutingDate { get; set; } 
        public IRPSTextBox<RetentionInvoiceEntityView> CodInvoiceRetention { get; set; } 
        public IRPSTextBox<RetentionInvoiceEntityView> RetentionDate { get; set; } 
        public IRPSButton<RetentionInvoiceEntityView> TrueReportCommandButton { get; set; } 
        public IRPSButton<RetentionInvoiceEntityView> ExecuteRetentionInvoiceEmailButton { get; set; } 
        public IRPSButton<RetentionInvoiceEntityView,RetentionInvoicePrintDialogView> RetentionInvoicePrintNavigationCommandButton { get; set; } 
        public IRPSButton<RetentionInvoiceEntityView> ExecuteCancelRetentionInvoiceButton { get; set; } 
        public RetentionInvoiceDetailsCollectionEditor<RetentionInvoiceEntityView,RetentionInvoiceDetailView> RetentionInvoiceDetails { get; set; } 
        public RetentionInvoice Screen { get; set; }
        public RetentionInvoiceEntityView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class RetentionInvoiceDetailsCollectionEditor<RetentionInvoiceEntityView,RetentionInvoiceDetailView>:RPSCollectionEditor<RetentionInvoiceEntityView,RetentionInvoiceDetailView> where RetentionInvoiceEntityView : class, IView where RetentionInvoiceDetailView : class, IView
    {
        public  RetentionInvoiceDetailsGridView<RetentionInvoiceEntityView,RetentionInvoiceDetailView> GridView {get;set;}
    }
    public partial class RetentionInvoiceDetailsGridView <RetentionInvoiceEntityView,RetentionInvoiceDetailView> :  RPSGridView<RetentionInvoiceEntityView,RetentionInvoiceDetailView> where RetentionInvoiceEntityView : class, IView where RetentionInvoiceDetailView : class, IView
    {
        public RetentionInvoiceDetailsGridView(RetentionInvoiceEntityView currentView,RetentionInvoiceDetailView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            IDTax = RPSControlFactory.CreateRPSGridComboBox<RetentionInvoiceEntityView>("","#3defddcc-a583-43c7-b75f-fe0673b0f29b .ag-row[role='row']@ROWINDEX [col-id='cIDTax']","",false, this.CurrentView);
 
            IDTaxValue = RPSControlFactory.CreateRPSGridComboBox<RetentionInvoiceEntityView>("","#3defddcc-a583-43c7-b75f-fe0673b0f29b .ag-row[role='row']@ROWINDEX [col-id='cIDTaxValue']","",false, this.CurrentView);
 
            Base = RPSControlFactory.CreateRPSGridFormattedTextBox<RetentionInvoiceEntityView>("","#3defddcc-a583-43c7-b75f-fe0673b0f29b .ag-row[role='row']@ROWINDEX [col-id='cBase']","",true, this.CurrentView);
 
            RetentionPercent = RPSControlFactory.CreateRPSGridFormattedTextBox<RetentionInvoiceEntityView>("","#3defddcc-a583-43c7-b75f-fe0673b0f29b .ag-row[role='row']@ROWINDEX [col-id='cRetentionPercent']","",true, this.CurrentView);
 
            AmountRetention = RPSControlFactory.CreateRPSGridFormattedTextBox<RetentionInvoiceEntityView>("","#3defddcc-a583-43c7-b75f-fe0673b0f29b .ag-row[role='row']@ROWINDEX [col-id='cAmountRetention']","",true, this.CurrentView);
 

        }
        public IRPSGridComboBox<RetentionInvoiceEntityView> IDTax { get; set; } 
        public IRPSGridComboBox<RetentionInvoiceEntityView> IDTaxValue { get; set; } 
        public IRPSGridTextBox<RetentionInvoiceEntityView> Base { get; set; } 
        public IRPSGridTextBox<RetentionInvoiceEntityView> RetentionPercent { get; set; } 
        public IRPSGridTextBox<RetentionInvoiceEntityView> AmountRetention { get; set; } 
                     
    }
 
    }
  
            
    public partial class RetentionInvoiceDetailView : View
    {
        public RetentionInvoiceDetailView(RetentionInvoice screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            DeleteButton = RPSControlFactory.RPSDeleteButton<RetentionInvoiceDetailView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<RetentionInvoiceDetailView,RetentionInvoiceEntityView>( this,Screen.RetentionInvoiceEntityView);
 
            BackButton = RPSControlFactory.RPSBackButton<RetentionInvoiceDetailView,RetentionInvoiceEntityView>( this,Screen.RetentionInvoiceEntityView);
 
            AcceptButton = RPSControlFactory.RPSAcceptButton<RetentionInvoiceDetailView,RetentionInvoiceEntityView>( this,Screen.RetentionInvoiceEntityView);
 
            IDTax = RPSControlFactory.CreateRPSComboBox<RetentionInvoiceDetailView>("dc1dc5ec-b8e9-4d5b-95b4-a89883491fa4","","",false, this);
 
            IDTaxValue = RPSControlFactory.CreateRPSComboBox<RetentionInvoiceDetailView>("4d7bc05d-5109-4d80-b53a-086a95687e28","","",false, this);
 
            Base = RPSControlFactory.CreateRPSFormattedTextBox<RetentionInvoiceDetailView>("20dbd68e-ccce-408b-a96f-ad359db018fc","","",true, this);
 
            RetentionPercent = RPSControlFactory.CreateRPSFormattedTextBox<RetentionInvoiceDetailView>("ce113cc9-7be1-464a-84b7-f4dafe60d2ac","","",true, this);
 
            AmountRetention = RPSControlFactory.CreateRPSFormattedTextBox<RetentionInvoiceDetailView>("60e0210a-e1f7-4135-8848-8ab0a78dbb1f","","",true, this);
 

        }
        public IRPSButton<RetentionInvoiceDetailView> DeleteButton { get; set; } 
        public IRPSButton<RetentionInvoiceDetailView,RetentionInvoiceEntityView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<RetentionInvoiceDetailView,RetentionInvoiceEntityView> BackButton { get; set; } 
        public IRPSAcceptButton<RetentionInvoiceDetailView,RetentionInvoiceEntityView> AcceptButton { get; set; } 
        public IRPSComboBox<RetentionInvoiceDetailView> IDTax { get; set; } 
        public IRPSComboBox<RetentionInvoiceDetailView> IDTaxValue { get; set; } 
        public IRPSTextBox<RetentionInvoiceDetailView> Base { get; set; } 
        public IRPSTextBox<RetentionInvoiceDetailView> RetentionPercent { get; set; } 
        public IRPSTextBox<RetentionInvoiceDetailView> AmountRetention { get; set; } 
        public RetentionInvoice Screen { get; set; }
        public RetentionInvoiceDetailView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class RetentionInvoicePrintDialogView : View
    {
        public RetentionInvoicePrintDialogView(RetentionInvoice screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            UIOptSupplier = RPSControlFactory.CreateRPSOption<RetentionInvoicePrintDialogView>( "487d5fb8-853d-4fc3-987c-301a25177f28","","",this);
 
            UIOptSelected = RPSControlFactory.CreateRPSOption<RetentionInvoicePrintDialogView>( "8b12961e-cb7c-4591-ac02-bbca26843961","","",this);
 
            UIPrintOptionsIDLanguage = RPSControlFactory.CreateRPSComboBox<RetentionInvoicePrintDialogView>("bad798a5-0838-429c-937b-414d127fa987","","",false, this);
 
            UIPrintSpecificReport = RPSControlFactory.CreateRPSCheckBox<RetentionInvoicePrintDialogView>("23f50b0e-8b8c-48a2-bc74-cfc27bf5ac6e","","",false, this);
 
            UICodOrderReport = RPSControlFactory.CreateRPSComboBox<RetentionInvoicePrintDialogView>("604969fe-5c2c-49d7-b576-bc510400f99d","","",false, this);
 

        }
        public IRPSOption<RetentionInvoicePrintDialogView> UIOptSupplier { get; set; } 
        public IRPSOption<RetentionInvoicePrintDialogView> UIOptSelected { get; set; } 
        public IRPSComboBox<RetentionInvoicePrintDialogView> UIPrintOptionsIDLanguage { get; set; } 
        public IRPSCheckbox<RetentionInvoicePrintDialogView> UIPrintSpecificReport { get; set; } 
        public IRPSComboBox<RetentionInvoicePrintDialogView> UICodOrderReport { get; set; } 
        public RetentionInvoice Screen { get; set; }
        public RetentionInvoicePrintDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}