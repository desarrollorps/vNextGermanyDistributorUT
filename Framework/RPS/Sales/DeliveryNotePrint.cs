    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.Sales.DeliveryNotePrint
{
    //RPS VERSION 1.0.0.0
    public partial class DeliveryNotePrint:Screen
    {
        public DeliveryNotePrint():base()
        {
            this.URL = "sales.deliverynoteprint";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            DeliveryNotePrintQueryView  = new DeliveryNotePrintQueryView(this); 
            EmailChildDialogView  = new EmailChildDialogView(this); 
            DeliveryNotePrintQueryView.InitializeControls(); 
            EmailChildDialogView.InitializeControls(); 
           
        }
      
            public DeliveryNotePrintQueryView DeliveryNotePrintQueryView {get; set; } 
            public EmailChildDialogView EmailChildDialogView {get; set; } 
    }
            
    public partial class DeliveryNotePrintQueryView : View
    {
        public DeliveryNotePrintQueryView(DeliveryNotePrint screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            UILstCustomer = RPSControlFactory.CreateRPSCollectionComboBox<DeliveryNotePrintQueryView>("fcb201d7-cad3-45d0-89da-ab5c7e8b02d5","","",false, this);
 
            UIDeliveryNoteFrom = RPSControlFactory.CreateRPSComboBox<DeliveryNotePrintQueryView>("d5dbec2a-8033-4500-96b1-79a9a600d864","","",false, this);
 
            UIDeliveryNoteTo = RPSControlFactory.CreateRPSComboBox<DeliveryNotePrintQueryView>("68ce8a60-a7ea-4eba-9654-7fffb7d49c3e","","",false, this);
 
            UIDateTimeFrom = RPSControlFactory.CreateRPSTextBox<DeliveryNotePrintQueryView>("34b18462-2055-4119-8299-04e871602b4d","","",false, this);
 
            UIDateTimeTo = RPSControlFactory.CreateRPSTextBox<DeliveryNotePrintQueryView>("a31794ed-3619-49e6-abd9-11dd1efb9bbc","","",false, this);
 
            CustomerLanguage = RPSControlFactory.CreateRPSOption<DeliveryNotePrintQueryView>( "abe45fab-dd71-4774-861b-7ccef6e35818","","",this);
 
            SelectedLanguage = RPSControlFactory.CreateRPSOption<DeliveryNotePrintQueryView>( "50052d0f-1656-4e67-bcce-6a49f4b0f2b2","","",this);
 
            UIPrintOptionsIDLanguage = RPSControlFactory.CreateRPSComboBox<DeliveryNotePrintQueryView>("9021e96b-c466-4bb8-8cc7-eb6351466d81","","",false, this);
 
            CustomerCopy = RPSControlFactory.CreateRPSOption<DeliveryNotePrintQueryView>( "4349bca3-aea5-4785-900c-ca1f4fd78b78","","",this);
 
            SelectedCopy = RPSControlFactory.CreateRPSOption<DeliveryNotePrintQueryView>( "afaa2aa0-7cdc-45c7-8466-c44deea8e57f","","",this);
 
            UINumCopies = RPSControlFactory.CreateRPSFormattedTextBox<DeliveryNotePrintQueryView>("3fbac8da-c363-4a2c-ac09-41296d0ddc61","","",false, this);
 
            DeliveryNoteNumber = RPSControlFactory.CreateRPSOption<DeliveryNotePrintQueryView>( "cf85c5a1-393b-4525-b702-66d14ef926de","","",this);
 
            SpecificOrder = RPSControlFactory.CreateRPSOption<DeliveryNotePrintQueryView>( "f932a7a4-1c68-465b-b3ae-2a6ab9a806a0","","",this);
 
            UIPrintSpecificReport = RPSControlFactory.CreateRPSCheckBox<DeliveryNotePrintQueryView>("08984647-ec97-4074-ae22-19e028245cdf","","",false, this);
 
            UICodDeliveryNoteReport = RPSControlFactory.CreateRPSComboBox<DeliveryNotePrintQueryView>("f39615ee-96b7-48b2-a48d-dc117e9cc5ac","","",false, this);
 
            UIPrintQualityCerts = RPSControlFactory.CreateRPSCheckBox<DeliveryNotePrintQueryView>("b4ca79b7-e575-473f-86d2-7b810461a96c","","",false, this);
 
            UICodQualityCertReport = RPSControlFactory.CreateRPSComboBox<DeliveryNotePrintQueryView>("a5b2b97c-17ca-454e-8c4b-a7a75e1d62cf","","",false, this);
 
            UIClientMail = RPSControlFactory.CreateRPSCheckBox<DeliveryNotePrintQueryView>("759c3a36-a57e-4f33-86d4-ac644837d7f8","","",false, this);
 
            EmailChildNavigationCommandButton = RPSControlFactory.CreateRPSButtonToView<DeliveryNotePrintQueryView,EmailChildDialogView>("02fd100e-6e9f-4315-a9c0-382d51b5ecda","","", this,Screen.EmailChildDialogView);
 
            CollectionInit params_DeliveryNotePrintPrintableQuery = new CollectionInit(){IDDescriptor = "698196dc-d491-46eb-a70a-949b43f74924",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="06f6e3d3-9656-404e-b4cf-6b45b257ad80",CSSSelectorGrid="",XPathGrid=""};
            DeliveryNotePrintPrintableQuery = RPSControlFactory.RPSCreateCollectionWithGrid<DeliveryNotePrintPrintableQueryCollectionEditor<DeliveryNotePrintQueryView,EmailChildDialogView>,DeliveryNotePrintQueryView,EmailChildDialogView>( params_DeliveryNotePrintPrintableQuery,this,Screen.EmailChildDialogView);
 

        }
        public IRPSCollectionComboBox<DeliveryNotePrintQueryView> UILstCustomer { get; set; } 
        public IRPSComboBox<DeliveryNotePrintQueryView> UIDeliveryNoteFrom { get; set; } 
        public IRPSComboBox<DeliveryNotePrintQueryView> UIDeliveryNoteTo { get; set; } 
        public IRPSTextBox<DeliveryNotePrintQueryView> UIDateTimeFrom { get; set; } 
        public IRPSTextBox<DeliveryNotePrintQueryView> UIDateTimeTo { get; set; } 
        public IRPSOption<DeliveryNotePrintQueryView> CustomerLanguage { get; set; } 
        public IRPSOption<DeliveryNotePrintQueryView> SelectedLanguage { get; set; } 
        public IRPSComboBox<DeliveryNotePrintQueryView> UIPrintOptionsIDLanguage { get; set; } 
        public IRPSOption<DeliveryNotePrintQueryView> CustomerCopy { get; set; } 
        public IRPSOption<DeliveryNotePrintQueryView> SelectedCopy { get; set; } 
        public IRPSTextBox<DeliveryNotePrintQueryView> UINumCopies { get; set; } 
        public IRPSOption<DeliveryNotePrintQueryView> DeliveryNoteNumber { get; set; } 
        public IRPSOption<DeliveryNotePrintQueryView> SpecificOrder { get; set; } 
        public IRPSCheckbox<DeliveryNotePrintQueryView> UIPrintSpecificReport { get; set; } 
        public IRPSComboBox<DeliveryNotePrintQueryView> UICodDeliveryNoteReport { get; set; } 
        public IRPSCheckbox<DeliveryNotePrintQueryView> UIPrintQualityCerts { get; set; } 
        public IRPSComboBox<DeliveryNotePrintQueryView> UICodQualityCertReport { get; set; } 
        public IRPSCheckbox<DeliveryNotePrintQueryView> UIClientMail { get; set; } 
        public IRPSButton<DeliveryNotePrintQueryView,EmailChildDialogView> EmailChildNavigationCommandButton { get; set; } 
        public DeliveryNotePrintPrintableQueryCollectionEditor<DeliveryNotePrintQueryView,EmailChildDialogView> DeliveryNotePrintPrintableQuery { get; set; } 
        public DeliveryNotePrint Screen { get; set; }
        public DeliveryNotePrintQueryView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class DeliveryNotePrintPrintableQueryCollectionEditor<DeliveryNotePrintQueryView,EmailChildDialogView>:RPSCollectionEditor<DeliveryNotePrintQueryView,EmailChildDialogView> where DeliveryNotePrintQueryView : class, IView where EmailChildDialogView : class, IView
    {
        public  DeliveryNotePrintPrintableQueryGridView<DeliveryNotePrintQueryView,EmailChildDialogView> GridView {get;set;}
    }
    public partial class DeliveryNotePrintPrintableQueryGridView <DeliveryNotePrintQueryView,EmailChildDialogView> :  RPSGridView<DeliveryNotePrintQueryView,EmailChildDialogView> where DeliveryNotePrintQueryView : class, IView where EmailChildDialogView : class, IView
    {
        public DeliveryNotePrintPrintableQueryGridView(DeliveryNotePrintQueryView currentView,EmailChildDialogView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            DeliveryNoteSL_DeliveryNoteDate = RPSControlFactory.CreateRPSGridTextBox<DeliveryNotePrintQueryView>("","#06f6e3d3-9656-404e-b4cf-6b45b257ad80 .ag-row[role='row']@ROWINDEX [col-id='cDeliveryNoteSL_DeliveryNoteDate']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<DeliveryNotePrintQueryView> DeliveryNoteSL_DeliveryNoteDate { get; set; } 
                     
    }
 
    }
  
            
    public partial class EmailChildDialogView : View
    {
        public EmailChildDialogView(DeliveryNotePrint screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            CollectionInit params_DeliveryNotePrintPrintableQuery = new CollectionInit(){IDDescriptor = "b8a9424c-f3a1-448f-92fb-65dacf79abb5",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="1e2500e4-54f2-41b7-9b8d-ef3e42001ce6",CSSSelectorGrid="",XPathGrid=""};
            DeliveryNotePrintPrintableQuery = RPSControlFactory.RPSCreateCollectionWithGrid<DeliveryNotePrintPrintableQueryCollectionEditor<EmailChildDialogView>,EmailChildDialogView>( params_DeliveryNotePrintPrintableQuery,this);
 

        }
        public DeliveryNotePrintPrintableQueryCollectionEditor<EmailChildDialogView> DeliveryNotePrintPrintableQuery { get; set; } 
        public DeliveryNotePrint Screen { get; set; }
        public EmailChildDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class DeliveryNotePrintPrintableQueryCollectionEditor<EmailChildDialogView>:RPSCollectionEditor<EmailChildDialogView> where EmailChildDialogView : class, IView
    {
        public  DeliveryNotePrintPrintableQueryGridView<EmailChildDialogView> GridView {get;set;}
    }
    public partial class DeliveryNotePrintPrintableQueryGridView <EmailChildDialogView> :  RPSGridView<EmailChildDialogView> where EmailChildDialogView : class, IView
    {
        public DeliveryNotePrintPrintableQueryGridView(EmailChildDialogView currentView)
        {
            this.WebDriver = currentView.WebDriver;          
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            DeliveryNoteSL_DeliveryNoteDate = RPSControlFactory.CreateRPSGridTextBox<EmailChildDialogView>("","#1e2500e4-54f2-41b7-9b8d-ef3e42001ce6 .ag-row[role='row']@ROWINDEX [col-id='cDeliveryNoteSL_DeliveryNoteDate']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<EmailChildDialogView> DeliveryNoteSL_DeliveryNoteDate { get; set; } 
                     
    }
 
    }
  
    

}