    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.SalesCRM.SalesQuotePrint
{
    //RPS VERSION 1.0.0.0
    public partial class SalesQuotePrint:Screen
    {
        public SalesQuotePrint():base()
        {
            this.URL = "salescrm.salesquoteprint";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            SalesQuotePrintQueryView  = new SalesQuotePrintQueryView(this); 
            EmailChildDialogView  = new EmailChildDialogView(this); 
            SalesQuotePrintQueryView.InitializeControls(); 
            EmailChildDialogView.InitializeControls(); 
           
        }
      
            public SalesQuotePrintQueryView SalesQuotePrintQueryView {get; set; } 
            public EmailChildDialogView EmailChildDialogView {get; set; } 
    }
            
    public partial class SalesQuotePrintQueryView : View
    {
        public SalesQuotePrintQueryView(SalesQuotePrint screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            Customer = RPSControlFactory.CreateRPSOption<SalesQuotePrintQueryView>( "1056cf9b-0baa-4c10-bf54-81556dfb2ee9","","",this);
 
            Customer2 = RPSControlFactory.CreateRPSCollectionComboBox<SalesQuotePrintQueryView>("4bdb9fc5-e489-43ff-aa71-cc733b41ce27","","",false, this);
 
            PotentialCustomer = RPSControlFactory.CreateRPSOption<SalesQuotePrintQueryView>( "68dcce8c-5bfc-4b73-80c8-0e306f576efe","","",this);
 
            PotentialCustomerSL2 = RPSControlFactory.CreateRPSCollectionComboBox<SalesQuotePrintQueryView>("ce5353b7-1726-45e7-918e-b1ec6eb43ec6","","",false, this);
 
            SalesQuoteSLFROM = RPSControlFactory.CreateRPSComboBox<SalesQuotePrintQueryView>("4e4cac19-64d8-45a7-8d23-e6084f7ca680","","",false, this);
 
            SalesQuoteSLTO = RPSControlFactory.CreateRPSComboBox<SalesQuotePrintQueryView>("dda161c5-e278-40fb-98d2-97f5bb6a7a21","","",false, this);
 
            DateFrom = RPSControlFactory.CreateRPSTextBox<SalesQuotePrintQueryView>("b990a01c-f668-46ff-b430-8e9758cbd53e","","",false, this);
 
            DateTo = RPSControlFactory.CreateRPSTextBox<SalesQuotePrintQueryView>("492a855d-9ddc-4185-b0b4-0529416aeace","","",false, this);
 
            All = RPSControlFactory.CreateRPSOption<SalesQuotePrintQueryView>( "19ac8f5a-56e3-4e39-adab-854e09760ebc","","",this);
 
            Pending = RPSControlFactory.CreateRPSOption<SalesQuotePrintQueryView>( "e3550c72-27c7-4ac4-9d5b-d42db4a212f1","","",this);
 
            Accepted = RPSControlFactory.CreateRPSOption<SalesQuotePrintQueryView>( "dec736be-34bf-48e7-afd3-ae154a500e90","","",this);
 
            SalesQuoteStatusSL = RPSControlFactory.CreateRPSComboBox<SalesQuotePrintQueryView>("f8e76ec6-772a-490b-9f33-8921787327eb","","",false, this);
 
            CustomerLanguage = RPSControlFactory.CreateRPSOption<SalesQuotePrintQueryView>( "ba31e2ac-fd6d-4c21-af9c-4d1412dc74b2","","",this);
 
            ChosenLanguage = RPSControlFactory.CreateRPSOption<SalesQuotePrintQueryView>( "e8f0e902-9bab-4d90-ae3e-f809d869a42f","","",this);
 
            Language = RPSControlFactory.CreateRPSComboBox<SalesQuotePrintQueryView>("948f4f60-85d2-447e-aa0b-11cc8e97381e","","",false, this);
 
            UIPrintSpecificReport = RPSControlFactory.CreateRPSCheckBox<SalesQuotePrintQueryView>("6e9dd6be-fa44-49e4-a04f-7c562bc1bd8d","","",false, this);
 
            CustomReport = RPSControlFactory.CreateRPSComboBox<SalesQuotePrintQueryView>("0d457161-3498-4c3a-8c0f-0a3377da7fef","","",false, this);
 
            UIDocumentsArticle = RPSControlFactory.CreateRPSCheckBox<SalesQuotePrintQueryView>("0f28cdd3-4872-4e05-997b-384fe58d7a03","","",false, this);
 
            UIOptAllDocuments = RPSControlFactory.CreateRPSOption<SalesQuotePrintQueryView>( "93f15c29-b70b-43ab-a167-96825e127696","","",this);
 
            UIOptByDocument = RPSControlFactory.CreateRPSOption<SalesQuotePrintQueryView>( "db4bedc8-14aa-4508-8787-af6bd0391be1","","",this);
 
            UIDocumentsSalesQuote = RPSControlFactory.CreateRPSCheckBox<SalesQuotePrintQueryView>("2604fbeb-b630-40a3-a307-fec4dcd574a4","","",false, this);
 
            UIOptAllDocuments1 = RPSControlFactory.CreateRPSOption<SalesQuotePrintQueryView>( "0fdb60d1-936b-4128-83ad-df55c19d1e4b","","",this);
 
            UIOptByDocument1 = RPSControlFactory.CreateRPSOption<SalesQuotePrintQueryView>( "fac75093-6449-4e0c-92cc-2d09f8c616cd","","",this);
 
            UIClientMail = RPSControlFactory.CreateRPSCheckBox<SalesQuotePrintQueryView>("2567d95f-f108-4663-ae90-af8ddbf23a59","","",false, this);
 
            EmailChildNavigationCommandButton = RPSControlFactory.CreateRPSButtonToView<SalesQuotePrintQueryView,EmailChildDialogView>("1e0f7d3d-303a-4b07-a3c5-0bbeb56bf6aa","","", this,Screen.EmailChildDialogView);
 
            CollectionInit params_SalesQuotePrintableQuery = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="a6953763-4eee-4065-8e09-3d1b96d333e9",CSSSelectorGrid="",XPathGrid=""};
            SalesQuotePrintableQuery = RPSControlFactory.RPSCreateCollectionWithGrid<SalesQuotePrintableQueryCollectionEditor<SalesQuotePrintQueryView,EmailChildDialogView>,SalesQuotePrintQueryView,EmailChildDialogView>( params_SalesQuotePrintableQuery,this,Screen.EmailChildDialogView);
 

        }
        public IRPSOption<SalesQuotePrintQueryView> Customer { get; set; } 
        public IRPSCollectionComboBox<SalesQuotePrintQueryView> Customer2 { get; set; } 
        public IRPSOption<SalesQuotePrintQueryView> PotentialCustomer { get; set; } 
        public IRPSCollectionComboBox<SalesQuotePrintQueryView> PotentialCustomerSL2 { get; set; } 
        public IRPSComboBox<SalesQuotePrintQueryView> SalesQuoteSLFROM { get; set; } 
        public IRPSComboBox<SalesQuotePrintQueryView> SalesQuoteSLTO { get; set; } 
        public IRPSTextBox<SalesQuotePrintQueryView> DateFrom { get; set; } 
        public IRPSTextBox<SalesQuotePrintQueryView> DateTo { get; set; } 
        public IRPSOption<SalesQuotePrintQueryView> All { get; set; } 
        public IRPSOption<SalesQuotePrintQueryView> Pending { get; set; } 
        public IRPSOption<SalesQuotePrintQueryView> Accepted { get; set; } 
        public IRPSComboBox<SalesQuotePrintQueryView> SalesQuoteStatusSL { get; set; } 
        public IRPSOption<SalesQuotePrintQueryView> CustomerLanguage { get; set; } 
        public IRPSOption<SalesQuotePrintQueryView> ChosenLanguage { get; set; } 
        public IRPSComboBox<SalesQuotePrintQueryView> Language { get; set; } 
        public IRPSCheckbox<SalesQuotePrintQueryView> UIPrintSpecificReport { get; set; } 
        public IRPSComboBox<SalesQuotePrintQueryView> CustomReport { get; set; } 
        public IRPSCheckbox<SalesQuotePrintQueryView> UIDocumentsArticle { get; set; } 
        public IRPSOption<SalesQuotePrintQueryView> UIOptAllDocuments { get; set; } 
        public IRPSOption<SalesQuotePrintQueryView> UIOptByDocument { get; set; } 
        public IRPSCheckbox<SalesQuotePrintQueryView> UIDocumentsSalesQuote { get; set; } 
        public IRPSOption<SalesQuotePrintQueryView> UIOptAllDocuments1 { get; set; } 
        public IRPSOption<SalesQuotePrintQueryView> UIOptByDocument1 { get; set; } 
        public IRPSCheckbox<SalesQuotePrintQueryView> UIClientMail { get; set; } 
        public IRPSButton<SalesQuotePrintQueryView,EmailChildDialogView> EmailChildNavigationCommandButton { get; set; } 
        public SalesQuotePrintableQueryCollectionEditor<SalesQuotePrintQueryView,EmailChildDialogView> SalesQuotePrintableQuery { get; set; } 
        public SalesQuotePrint Screen { get; set; }
        public SalesQuotePrintQueryView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class SalesQuotePrintableQueryCollectionEditor<SalesQuotePrintQueryView,EmailChildDialogView>:RPSCollectionEditor<SalesQuotePrintQueryView,EmailChildDialogView> where SalesQuotePrintQueryView : class, IView where EmailChildDialogView : class, IView
    {
        public  SalesQuotePrintableQueryGridView<SalesQuotePrintQueryView,EmailChildDialogView> GridView {get;set;}
    }
    public partial class SalesQuotePrintableQueryGridView <SalesQuotePrintQueryView,EmailChildDialogView> :  RPSGridView<SalesQuotePrintQueryView,EmailChildDialogView> where SalesQuotePrintQueryView : class, IView where EmailChildDialogView : class, IView
    {
        public SalesQuotePrintableQueryGridView(SalesQuotePrintQueryView currentView,EmailChildDialogView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            SalesQuoteSL_SalesQuoteDate = RPSControlFactory.CreateRPSGridTextBox<SalesQuotePrintQueryView>("","#a6953763-4eee-4065-8e09-3d1b96d333e9 .ag-row[role='row']@ROWINDEX [col-id='cSalesQuoteSL_SalesQuoteDate']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<SalesQuotePrintQueryView> SalesQuoteSL_SalesQuoteDate { get; set; } 
                     
    }
 
    }
  
            
    public partial class EmailChildDialogView : View
    {
        public EmailChildDialogView(SalesQuotePrint screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            CollectionInit params_SalesQuotePrintableQuery = new CollectionInit(){IDDescriptor = "3203d219-0820-4320-a87d-14a623afe7fc",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="4d2b3ace-4af9-4a02-807e-f8a8f954c27e",CSSSelectorGrid="",XPathGrid=""};
            SalesQuotePrintableQuery = RPSControlFactory.RPSCreateCollectionWithGrid<SalesQuotePrintableQueryCollectionEditor<EmailChildDialogView>,EmailChildDialogView>( params_SalesQuotePrintableQuery,this);
 

        }
        public SalesQuotePrintableQueryCollectionEditor<EmailChildDialogView> SalesQuotePrintableQuery { get; set; } 
        public SalesQuotePrint Screen { get; set; }
        public EmailChildDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class SalesQuotePrintableQueryCollectionEditor<EmailChildDialogView>:RPSCollectionEditor<EmailChildDialogView> where EmailChildDialogView : class, IView
    {
        public  SalesQuotePrintableQueryGridView<EmailChildDialogView> GridView {get;set;}
    }
    public partial class SalesQuotePrintableQueryGridView <EmailChildDialogView> :  RPSGridView<EmailChildDialogView> where EmailChildDialogView : class, IView
    {
        public SalesQuotePrintableQueryGridView(EmailChildDialogView currentView)
        {
            this.WebDriver = currentView.WebDriver;          
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            SalesQuoteSL_SalesQuoteDate = RPSControlFactory.CreateRPSGridTextBox<EmailChildDialogView>("","#4d2b3ace-4af9-4a02-807e-f8a8f954c27e .ag-row[role='row']@ROWINDEX [col-id='cSalesQuoteSL_SalesQuoteDate']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<EmailChildDialogView> SalesQuoteSL_SalesQuoteDate { get; set; } 
                     
    }
 
    }
  
    

}