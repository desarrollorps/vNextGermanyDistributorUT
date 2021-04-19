    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.Purchase.SupplierRFQList
{
    //RPS VERSION 1.0.0.0
    public partial class SupplierRFQList:Screen
    {
        public SupplierRFQList():base()
        {
            this.URL = "purchase.supplierrfqlist";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            SupplierRFQListQueryView  = new SupplierRFQListQueryView(this); 
            EmailChildDialogView  = new EmailChildDialogView(this); 
            SupplierRFQListQueryView.InitializeControls(); 
            EmailChildDialogView.InitializeControls(); 
           
        }
      
            public SupplierRFQListQueryView SupplierRFQListQueryView {get; set; } 
            public EmailChildDialogView EmailChildDialogView {get; set; } 
    }
            
    public partial class SupplierRFQListQueryView : View
    {
        public SupplierRFQListQueryView(SupplierRFQList screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            UILstSupplier = RPSControlFactory.CreateRPSCollectionComboBox<SupplierRFQListQueryView>("164d2bb8-6e23-4884-9edf-81205cdffb64","","",false, this);
 
            UISupplierRFQFrom = RPSControlFactory.CreateRPSComboBox<SupplierRFQListQueryView>("5448f2a7-401e-4d13-80c4-a7f176e6f519","","",false, this);
 
            UISupplierRFQTo = RPSControlFactory.CreateRPSComboBox<SupplierRFQListQueryView>("fde26961-e564-4a78-9ffd-35e26353c508","","",false, this);
 
            UISupplierRFQDateFrom = RPSControlFactory.CreateRPSTextBox<SupplierRFQListQueryView>("d9e530a5-f227-4c82-8ced-fe4a06f7ef7d","","",false, this);
 
            UISupplierRFQDateTo = RPSControlFactory.CreateRPSTextBox<SupplierRFQListQueryView>("b869c44f-809d-40be-9199-4f0199823ab3","","",false, this);
 
            UIAll = RPSControlFactory.CreateRPSOption<SupplierRFQListQueryView>( "6a68dc9e-ee5c-476a-acab-cde365b1e51e","","",this);
 
            UIPendingList = RPSControlFactory.CreateRPSOption<SupplierRFQListQueryView>( "2a06f29e-2676-49f2-bf2d-cff3ffb65c42","","",this);
 
            UIList = RPSControlFactory.CreateRPSOption<SupplierRFQListQueryView>( "ace66c6b-44b6-4385-a23c-51ff559d87cb","","",this);
 
            UIAll1 = RPSControlFactory.CreateRPSOption<SupplierRFQListQueryView>( "048e3d1d-da56-498a-b852-3632a9f6633e","","",this);
 
            UIPendingToReceive = RPSControlFactory.CreateRPSOption<SupplierRFQListQueryView>( "3a15d296-4872-4796-8a6c-0bf088aae9b0","","",this);
 
            UIOptSupplier = RPSControlFactory.CreateRPSOption<SupplierRFQListQueryView>( "1ddcb44e-00f0-4e43-a2b7-bed79e5740f5","","",this);
 
            UIOptSelectedLanguage = RPSControlFactory.CreateRPSOption<SupplierRFQListQueryView>( "73312f4c-4869-4c79-a398-599f1b5ae5e4","","",this);
 
            Language = RPSControlFactory.CreateRPSComboBox<SupplierRFQListQueryView>("ce81bb43-c0ee-4cc8-9d9a-446f4d3d140d","","",false, this);
 
            UIPrintSpecificReport = RPSControlFactory.CreateRPSCheckBox<SupplierRFQListQueryView>("3d78676c-d52b-4927-9d54-f02d217399da","","",false, this);
 
            UICustomReportSupplierRFQ = RPSControlFactory.CreateRPSComboBox<SupplierRFQListQueryView>("331e6800-f94e-431c-9ddd-43d2240c2d0a","","",false, this);
 
            bClaim = RPSControlFactory.CreateRPSCheckBox<SupplierRFQListQueryView>("496da890-ea50-411d-8252-171fdc689eb3","","",false, this);
 
            UIDocumentsArticle = RPSControlFactory.CreateRPSCheckBox<SupplierRFQListQueryView>("0f28cdd3-4872-4e05-997b-384fe58d7a03","","",false, this);
 
            UIOptAllDocuments = RPSControlFactory.CreateRPSOption<SupplierRFQListQueryView>( "93f15c29-b70b-43ab-a167-96825e127696","","",this);
 
            UIOptByDocument = RPSControlFactory.CreateRPSOption<SupplierRFQListQueryView>( "db4bedc8-14aa-4508-8787-af6bd0391be1","","",this);
 
            UIDocumentsSupplierRFQ = RPSControlFactory.CreateRPSCheckBox<SupplierRFQListQueryView>("dc2a16d7-936e-4090-8235-593a7a3af56b","","",false, this);
 
            UIOptAllDocuments1 = RPSControlFactory.CreateRPSOption<SupplierRFQListQueryView>( "edb3257a-13e0-41d4-a1a1-fa63e137add8","","",this);
 
            UIOptByDocument1 = RPSControlFactory.CreateRPSOption<SupplierRFQListQueryView>( "cadace8b-6fc5-47cc-8142-88f0b424c27c","","",this);
 
            UIDocumentsMaterial = RPSControlFactory.CreateRPSCheckBox<SupplierRFQListQueryView>("1b236992-c0c9-4236-b8ee-ec7a644b859c","","",false, this);
 
            UIOptAllDocuments2 = RPSControlFactory.CreateRPSOption<SupplierRFQListQueryView>( "3b2e38f4-621a-4387-a9dc-c8228a47c57a","","",this);
 
            UIOptByDocument2 = RPSControlFactory.CreateRPSOption<SupplierRFQListQueryView>( "893c9bd1-7287-46bf-b91b-b1284cc009b2","","",this);
 
            UIClientMail = RPSControlFactory.CreateRPSCheckBox<SupplierRFQListQueryView>("c756c03a-c321-4340-8d69-f4b2e01f281e","","",false, this);
 
            EmailChildNavigationCommandButton = RPSControlFactory.CreateRPSButtonToView<SupplierRFQListQueryView,EmailChildDialogView>("c4b5d6e7-a272-4e54-a153-775a774ae300","","", this,Screen.EmailChildDialogView);
 

        }
        public IRPSCollectionComboBox<SupplierRFQListQueryView> UILstSupplier { get; set; } 
        public IRPSComboBox<SupplierRFQListQueryView> UISupplierRFQFrom { get; set; } 
        public IRPSComboBox<SupplierRFQListQueryView> UISupplierRFQTo { get; set; } 
        public IRPSTextBox<SupplierRFQListQueryView> UISupplierRFQDateFrom { get; set; } 
        public IRPSTextBox<SupplierRFQListQueryView> UISupplierRFQDateTo { get; set; } 
        public IRPSOption<SupplierRFQListQueryView> UIAll { get; set; } 
        public IRPSOption<SupplierRFQListQueryView> UIPendingList { get; set; } 
        public IRPSOption<SupplierRFQListQueryView> UIList { get; set; } 
        public IRPSOption<SupplierRFQListQueryView> UIAll1 { get; set; } 
        public IRPSOption<SupplierRFQListQueryView> UIPendingToReceive { get; set; } 
        public IRPSOption<SupplierRFQListQueryView> UIOptSupplier { get; set; } 
        public IRPSOption<SupplierRFQListQueryView> UIOptSelectedLanguage { get; set; } 
        public IRPSComboBox<SupplierRFQListQueryView> Language { get; set; } 
        public IRPSCheckbox<SupplierRFQListQueryView> UIPrintSpecificReport { get; set; } 
        public IRPSComboBox<SupplierRFQListQueryView> UICustomReportSupplierRFQ { get; set; } 
        public IRPSCheckbox<SupplierRFQListQueryView> bClaim { get; set; } 
        public IRPSCheckbox<SupplierRFQListQueryView> UIDocumentsArticle { get; set; } 
        public IRPSOption<SupplierRFQListQueryView> UIOptAllDocuments { get; set; } 
        public IRPSOption<SupplierRFQListQueryView> UIOptByDocument { get; set; } 
        public IRPSCheckbox<SupplierRFQListQueryView> UIDocumentsSupplierRFQ { get; set; } 
        public IRPSOption<SupplierRFQListQueryView> UIOptAllDocuments1 { get; set; } 
        public IRPSOption<SupplierRFQListQueryView> UIOptByDocument1 { get; set; } 
        public IRPSCheckbox<SupplierRFQListQueryView> UIDocumentsMaterial { get; set; } 
        public IRPSOption<SupplierRFQListQueryView> UIOptAllDocuments2 { get; set; } 
        public IRPSOption<SupplierRFQListQueryView> UIOptByDocument2 { get; set; } 
        public IRPSCheckbox<SupplierRFQListQueryView> UIClientMail { get; set; } 
        public IRPSButton<SupplierRFQListQueryView,EmailChildDialogView> EmailChildNavigationCommandButton { get; set; } 
        public SupplierRFQList Screen { get; set; }
        public SupplierRFQListQueryView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class EmailChildDialogView : View
    {
        public EmailChildDialogView(SupplierRFQList screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            CollectionInit params_SupplierRFQReprintPrintableQuery2 = new CollectionInit(){IDDescriptor = "ecd814c9-4b1c-46a9-950b-49f11b20c412",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="3f5bee0f-d6ae-4111-a404-0516b0e95b29",CSSSelectorGrid="",XPathGrid=""};
            SupplierRFQReprintPrintableQuery2 = RPSControlFactory.RPSCreateCollectionWithGrid<SupplierRFQReprintPrintableQuery2CollectionEditor<EmailChildDialogView>,EmailChildDialogView>( params_SupplierRFQReprintPrintableQuery2,this);
 

        }
        public SupplierRFQReprintPrintableQuery2CollectionEditor<EmailChildDialogView> SupplierRFQReprintPrintableQuery2 { get; set; } 
        public SupplierRFQList Screen { get; set; }
        public EmailChildDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class SupplierRFQReprintPrintableQuery2CollectionEditor<EmailChildDialogView>:RPSCollectionEditor<EmailChildDialogView> where EmailChildDialogView : class, IView
    {
        public  SupplierRFQReprintPrintableQuery2GridView<EmailChildDialogView> GridView {get;set;}
    }
    public partial class SupplierRFQReprintPrintableQuery2GridView <EmailChildDialogView> :  RPSGridView<EmailChildDialogView> where EmailChildDialogView : class, IView
    {
        public SupplierRFQReprintPrintableQuery2GridView(EmailChildDialogView currentView)
        {
            this.WebDriver = currentView.WebDriver;          
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            SupplierRequestQuotation_SupplierRFQDate = RPSControlFactory.CreateRPSGridTextBox<EmailChildDialogView>("","#3f5bee0f-d6ae-4111-a404-0516b0e95b29 .ag-row[role='row']@ROWINDEX [col-id='cSupplierRequestQuotation_SupplierRFQDate']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<EmailChildDialogView> SupplierRequestQuotation_SupplierRFQDate { get; set; } 
                     
    }
 
    }
  
    

}