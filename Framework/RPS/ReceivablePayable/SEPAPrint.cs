    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.ReceivablePayable.SEPAPrint
{
    //RPS VERSION 1.0.0.0
    public partial class SEPAPrint:Screen
    {
        public SEPAPrint():base()
        {
            this.URL = "receivablepayable.sepaprint";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            SEPAPrintQueryView  = new SEPAPrintQueryView(this); 
            PrintChildDialogView  = new PrintChildDialogView(this); 
            SEPAPrintQueryView.InitializeControls(); 
            PrintChildDialogView.InitializeControls(); 
           
        }
      
            public SEPAPrintQueryView SEPAPrintQueryView {get; set; } 
            public PrintChildDialogView PrintChildDialogView {get; set; } 
    }
            
    public partial class SEPAPrintQueryView : View
    {
        public SEPAPrintQueryView(SEPAPrint screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            bSales = RPSControlFactory.CreateRPSCheckBox<SEPAPrintQueryView>("366a2433-410d-4b2d-8a30-6c480aecc86e","","",false, this);
 
            bPurchase = RPSControlFactory.CreateRPSCheckBox<SEPAPrintQueryView>("22c2675b-5b42-40dc-94ae-e43e2cdc325b","","",false, this);
 
            IDCustomer = RPSControlFactory.CreateRPSComboBox<SEPAPrintQueryView>("bf969939-abf4-4f45-b3e3-7ab56c4d4eb5","","",false, this);
 
            IDSupplier = RPSControlFactory.CreateRPSComboBox<SEPAPrintQueryView>("f42edf45-02fb-4be3-aec1-948a79d3b057","","",false, this);
 
            IDBankAccountCompany = RPSControlFactory.CreateRPSComboBox<SEPAPrintQueryView>("a87baa86-42d9-40fa-9f9e-efbe8e111f45","","",false, this);
 
            CodInvoice = RPSControlFactory.CreateRPSTextBox<SEPAPrintQueryView>("fc7d9a83-ece4-49fa-8a8b-ba772b69ec6b","","",false, this);
 
            Reference = RPSControlFactory.CreateRPSTextBox<SEPAPrintQueryView>("79548a4e-fa1e-4f3a-afb4-dbafb28eea35","","",false, this);
 
            RemittanceNumber = RPSControlFactory.CreateRPSTextBox<SEPAPrintQueryView>("c2a45696-9b3c-4f2f-8e0b-1c5e05f5039f","","",false, this);
 
            InvoiceDateFrom = RPSControlFactory.CreateRPSTextBox<SEPAPrintQueryView>("19026865-8e9a-4b5a-be6b-58d0d65131b0","","",false, this);
 
            InvoiceDateTo = RPSControlFactory.CreateRPSTextBox<SEPAPrintQueryView>("9598fd85-f2db-4c48-9853-8518477a7792","","",false, this);
 
            DueDateFrom = RPSControlFactory.CreateRPSTextBox<SEPAPrintQueryView>("f441f0ff-7732-4937-8477-691fdc65b57e","","",false, this);
 
            DueDateTo = RPSControlFactory.CreateRPSTextBox<SEPAPrintQueryView>("d787622f-eede-4a71-83ba-eacb98e98ea7","","",false, this);
 
            SEPAMessage = RPSControlFactory.CreateRPSTextBox<SEPAPrintQueryView>("437e283b-2481-4d64-8d3e-0222f3b9e461","","",false, this);
 
            SEPAPaymentDateFrom = RPSControlFactory.CreateRPSTextBox<SEPAPrintQueryView>("073fffed-344a-4a5e-9063-1292d29f8370","","",false, this);
 
            SEPAPaymentDateTo = RPSControlFactory.CreateRPSTextBox<SEPAPrintQueryView>("b6527d87-87a2-43b8-9384-954377ddee0a","","",false, this);
 
            SEPAFileDateFrom = RPSControlFactory.CreateRPSTextBox<SEPAPrintQueryView>("5a25230a-114d-4882-abfc-f67bc4766a52","","",false, this);
 
            SEPAFileDateTo = RPSControlFactory.CreateRPSTextBox<SEPAPrintQueryView>("d3120560-340b-414f-b8e2-9f4df7f8841c","","",false, this);
 
            PrintChildScreenCommandButton = RPSControlFactory.CreateRPSButtonToView<SEPAPrintQueryView,PrintChildDialogView>("b0aae85a-fa60-46d3-bc36-f6692a7ca82d","","", this,Screen.PrintChildDialogView);
 
            PrintChildMailCommandButton = RPSControlFactory.CreateRPSButtonToView<SEPAPrintQueryView,PrintChildDialogView>("ac02794b-f7d1-4717-b0b1-5c4fb209df64","","", this,Screen.PrintChildDialogView);
 
            CollectionInit params_GetDraftsQueryPrintSEPA = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="c11353f2-de5b-4354-8ca8-8ce21fac6b61",CSSSelectorGrid="",XPathGrid=""};
            GetDraftsQueryPrintSEPA = RPSControlFactory.RPSCreateCollectionWithGrid<GetDraftsQueryPrintSEPACollectionEditor<SEPAPrintQueryView,PrintChildDialogView>,SEPAPrintQueryView,PrintChildDialogView>( params_GetDraftsQueryPrintSEPA,this,Screen.PrintChildDialogView);
 

        }
        public IRPSCheckbox<SEPAPrintQueryView> bSales { get; set; } 
        public IRPSCheckbox<SEPAPrintQueryView> bPurchase { get; set; } 
        public IRPSComboBox<SEPAPrintQueryView> IDCustomer { get; set; } 
        public IRPSComboBox<SEPAPrintQueryView> IDSupplier { get; set; } 
        public IRPSComboBox<SEPAPrintQueryView> IDBankAccountCompany { get; set; } 
        public IRPSTextBox<SEPAPrintQueryView> CodInvoice { get; set; } 
        public IRPSTextBox<SEPAPrintQueryView> Reference { get; set; } 
        public IRPSTextBox<SEPAPrintQueryView> RemittanceNumber { get; set; } 
        public IRPSTextBox<SEPAPrintQueryView> InvoiceDateFrom { get; set; } 
        public IRPSTextBox<SEPAPrintQueryView> InvoiceDateTo { get; set; } 
        public IRPSTextBox<SEPAPrintQueryView> DueDateFrom { get; set; } 
        public IRPSTextBox<SEPAPrintQueryView> DueDateTo { get; set; } 
        public IRPSTextBox<SEPAPrintQueryView> SEPAMessage { get; set; } 
        public IRPSTextBox<SEPAPrintQueryView> SEPAPaymentDateFrom { get; set; } 
        public IRPSTextBox<SEPAPrintQueryView> SEPAPaymentDateTo { get; set; } 
        public IRPSTextBox<SEPAPrintQueryView> SEPAFileDateFrom { get; set; } 
        public IRPSTextBox<SEPAPrintQueryView> SEPAFileDateTo { get; set; } 
        public IRPSButton<SEPAPrintQueryView,PrintChildDialogView> PrintChildScreenCommandButton { get; set; } 
        public IRPSButton<SEPAPrintQueryView,PrintChildDialogView> PrintChildMailCommandButton { get; set; } 
        public GetDraftsQueryPrintSEPACollectionEditor<SEPAPrintQueryView,PrintChildDialogView> GetDraftsQueryPrintSEPA { get; set; } 
        public SEPAPrint Screen { get; set; }
        public SEPAPrintQueryView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class GetDraftsQueryPrintSEPACollectionEditor<SEPAPrintQueryView,PrintChildDialogView>:RPSCollectionEditor<SEPAPrintQueryView,PrintChildDialogView> where SEPAPrintQueryView : class, IView where PrintChildDialogView : class, IView
    {
        public  GetDraftsQueryPrintSEPAGridView<SEPAPrintQueryView,PrintChildDialogView> GridView {get;set;}
    }
    public partial class GetDraftsQueryPrintSEPAGridView <SEPAPrintQueryView,PrintChildDialogView> :  RPSGridView<SEPAPrintQueryView,PrintChildDialogView> where SEPAPrintQueryView : class, IView where PrintChildDialogView : class, IView
    {
        public GetDraftsQueryPrintSEPAGridView(SEPAPrintQueryView currentView,PrintChildDialogView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            InvoiceDate = RPSControlFactory.CreateRPSGridTextBox<SEPAPrintQueryView>("","#c11353f2-de5b-4354-8ca8-8ce21fac6b61 .ag-row[role='row']@ROWINDEX [col-id='cInvoiceDate']","",false, this.CurrentView);
 
            SEPAFileDate = RPSControlFactory.CreateRPSGridTextBox<SEPAPrintQueryView>("","#c11353f2-de5b-4354-8ca8-8ce21fac6b61 .ag-row[role='row']@ROWINDEX [col-id='cSEPAFileDate']","",false, this.CurrentView);
 
            SEPAPaymentDate = RPSControlFactory.CreateRPSGridTextBox<SEPAPrintQueryView>("","#c11353f2-de5b-4354-8ca8-8ce21fac6b61 .ag-row[role='row']@ROWINDEX [col-id='cSEPAPaymentDate']","",false, this.CurrentView);
 
            SEPAMessage = RPSControlFactory.CreateRPSGridTextBox<SEPAPrintQueryView>("","#c11353f2-de5b-4354-8ca8-8ce21fac6b61 .ag-row[role='row']@ROWINDEX [col-id='cSEPAMessage']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<SEPAPrintQueryView> InvoiceDate { get; set; } 
        public IRPSGridTextBox<SEPAPrintQueryView> SEPAFileDate { get; set; } 
        public IRPSGridTextBox<SEPAPrintQueryView> SEPAPaymentDate { get; set; } 
        public IRPSGridTextBox<SEPAPrintQueryView> SEPAMessage { get; set; } 
                     
    }
 
    }
  
            
    public partial class PrintChildDialogView : View
    {
        public PrintChildDialogView(SEPAPrint screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            CustomReportAP = RPSControlFactory.CreateRPSEnumComboBox<PrintChildDialogView>("b395760e-e304-4035-bded-b60315d0afa6","","",false, this);
 
            CustomReportAR = RPSControlFactory.CreateRPSEnumComboBox<PrintChildDialogView>("9113a5ed-7997-4ab1-8de9-59cf313b4bfe","","",false, this);
 
            OptionThirdLanguage = RPSControlFactory.CreateRPSOption<PrintChildDialogView>( "6b8437b3-c408-4360-a93e-652142875415","","",this);
 
            OtherLanguage = RPSControlFactory.CreateRPSOption<PrintChildDialogView>( "f7b45c7c-3a73-4e28-9d05-c716cf6e1a42","","",this);
 
            CodOtherLanguage = RPSControlFactory.CreateRPSComboBox<PrintChildDialogView>("555965d2-63c8-4308-8e3e-2cc9a910e248","","",false, this);
 

        }
        public IRPSComboBox<PrintChildDialogView> CustomReportAP { get; set; } 
        public IRPSComboBox<PrintChildDialogView> CustomReportAR { get; set; } 
        public IRPSOption<PrintChildDialogView> OptionThirdLanguage { get; set; } 
        public IRPSOption<PrintChildDialogView> OtherLanguage { get; set; } 
        public IRPSComboBox<PrintChildDialogView> CodOtherLanguage { get; set; } 
        public SEPAPrint Screen { get; set; }
        public PrintChildDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}