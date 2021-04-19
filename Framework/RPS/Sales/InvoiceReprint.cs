    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.Sales.InvoiceReprint
{
    //RPS VERSION 1.0.0.0
    public partial class InvoiceReprint:Screen
    {
        public InvoiceReprint():base()
        {
            this.URL = "sales.invoicereprint";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            InvoiceReprintQueryView  = new InvoiceReprintQueryView(this); 
            EmailChildDialogView  = new EmailChildDialogView(this); 
            InvoiceReprintQueryView.InitializeControls(); 
            EmailChildDialogView.InitializeControls(); 
           
        }
      
            public InvoiceReprintQueryView InvoiceReprintQueryView {get; set; } 
            public EmailChildDialogView EmailChildDialogView {get; set; } 
    }
            
    public partial class InvoiceReprintQueryView : View
    {
        public InvoiceReprintQueryView(InvoiceReprint screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            Customer = RPSControlFactory.CreateRPSCollectionComboBox<InvoiceReprintQueryView>("e7d06dd0-7547-459e-a5c3-a4a3f3c5e635","","",false, this);
 
            FromInvoice = RPSControlFactory.CreateRPSComboBox<InvoiceReprintQueryView>("b9b53b4c-895f-4afb-b65c-d87c5fe8ccbe","","",false, this);
 
            ToInvoice = RPSControlFactory.CreateRPSComboBox<InvoiceReprintQueryView>("38a98e3e-0f1a-4c38-9e02-9dc599ac027c","","",false, this);
 
            UIInvoiceDateFrom = RPSControlFactory.CreateRPSTextBox<InvoiceReprintQueryView>("abe74d4a-cfe1-4902-83d2-82f978896e33","","",false, this);
 
            UIDateTo = RPSControlFactory.CreateRPSTextBox<InvoiceReprintQueryView>("4c8c12a4-d800-4cb6-871c-74fc2d1c0f2d","","",false, this);
 
            InvoicingTypeSL = RPSControlFactory.CreateRPSCollectionComboBox<InvoiceReprintQueryView>("21e6a929-a583-4785-8a6a-9281e75c69d8","","",false, this);
 
            InvoiceTypeGroupSL = RPSControlFactory.CreateRPSCollectionComboBox<InvoiceReprintQueryView>("d49ffeba-8372-43d6-bf29-7be65c098d07","","",false, this);
 
            bPendingOnly = RPSControlFactory.CreateRPSCheckBox<InvoiceReprintQueryView>("7cec15ba-8e00-4e3d-ba7a-6533caa53594","","",false, this);
 
            Customer1 = RPSControlFactory.CreateRPSOption<InvoiceReprintQueryView>( "d8187010-1318-4952-b642-a169d8617e19","","",this);
 
            Language = RPSControlFactory.CreateRPSOption<InvoiceReprintQueryView>( "0c9de6ad-7042-4e67-be5d-32d61df2ccf4","","",this);
 
            Language1 = RPSControlFactory.CreateRPSComboBox<InvoiceReprintQueryView>("c050463d-aeb5-4e2d-8802-a46f9f05b0d7","","",false, this);
 
            CustomerCopies = RPSControlFactory.CreateRPSOption<InvoiceReprintQueryView>( "a6e94b3c-72c4-4990-80de-dfde81c1071b","","",this);
 
            Copies = RPSControlFactory.CreateRPSOption<InvoiceReprintQueryView>( "5f8309b3-5ed0-4d58-a078-b9ed86a59724","","",this);
 
            UINumCopies = RPSControlFactory.CreateRPSFormattedTextBox<InvoiceReprintQueryView>("8f4fef66-f0be-4389-ac0a-1c569a4eda1a","","",false, this);
 
            OrderNumber = RPSControlFactory.CreateRPSOption<InvoiceReprintQueryView>( "e1dc89f2-272d-4ed1-8615-f2e694baf582","","",this);
 
            Customer2 = RPSControlFactory.CreateRPSOption<InvoiceReprintQueryView>( "4e44a672-8c8a-4bbc-a58e-c65457e8d482","","",this);
 
            SpecificOrder = RPSControlFactory.CreateRPSOption<InvoiceReprintQueryView>( "72f5b0fe-4346-46cf-be99-da48713ed09f","","",this);
 
            UseSpecificReport = RPSControlFactory.CreateRPSCheckBox<InvoiceReprintQueryView>("bf489dae-4870-48a5-99d2-7ad472951b14","","",false, this);
 
            CustomReport = RPSControlFactory.CreateRPSComboBox<InvoiceReprintQueryView>("2c4fb73b-1eb4-43f0-8ed1-8b1ddddf78e2","","",false, this);
 
            UIClientMail = RPSControlFactory.CreateRPSCheckBox<InvoiceReprintQueryView>("53689df8-f780-48e6-aa4f-a61c4c91f769","","",false, this);
 
            EmailChildNavigationCommandButton = RPSControlFactory.CreateRPSButtonToView<InvoiceReprintQueryView,EmailChildDialogView>("f184f93f-175f-4b44-9059-58ae1ce21eff","","", this,Screen.EmailChildDialogView);
 
            CollectionInit params_InvoiceReprintPrintableQuery = new CollectionInit(){IDDescriptor = "3f17dab5-c9f4-486c-b8ed-ec7eb23c4537",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="afb244e9-f586-44e6-8af4-0a31d134cfd3",CSSSelectorGrid="",XPathGrid=""};
            InvoiceReprintPrintableQuery = RPSControlFactory.RPSCreateCollectionWithGrid<InvoiceReprintPrintableQueryCollectionEditor<InvoiceReprintQueryView,EmailChildDialogView>,InvoiceReprintQueryView,EmailChildDialogView>( params_InvoiceReprintPrintableQuery,this,Screen.EmailChildDialogView);
 

        }
        public IRPSCollectionComboBox<InvoiceReprintQueryView> Customer { get; set; } 
        public IRPSComboBox<InvoiceReprintQueryView> FromInvoice { get; set; } 
        public IRPSComboBox<InvoiceReprintQueryView> ToInvoice { get; set; } 
        public IRPSTextBox<InvoiceReprintQueryView> UIInvoiceDateFrom { get; set; } 
        public IRPSTextBox<InvoiceReprintQueryView> UIDateTo { get; set; } 
        public IRPSCollectionComboBox<InvoiceReprintQueryView> InvoicingTypeSL { get; set; } 
        public IRPSCollectionComboBox<InvoiceReprintQueryView> InvoiceTypeGroupSL { get; set; } 
        public IRPSCheckbox<InvoiceReprintQueryView> bPendingOnly { get; set; } 
        public IRPSOption<InvoiceReprintQueryView> Customer1 { get; set; } 
        public IRPSOption<InvoiceReprintQueryView> Language { get; set; } 
        public IRPSComboBox<InvoiceReprintQueryView> Language1 { get; set; } 
        public IRPSOption<InvoiceReprintQueryView> CustomerCopies { get; set; } 
        public IRPSOption<InvoiceReprintQueryView> Copies { get; set; } 
        public IRPSTextBox<InvoiceReprintQueryView> UINumCopies { get; set; } 
        public IRPSOption<InvoiceReprintQueryView> OrderNumber { get; set; } 
        public IRPSOption<InvoiceReprintQueryView> Customer2 { get; set; } 
        public IRPSOption<InvoiceReprintQueryView> SpecificOrder { get; set; } 
        public IRPSCheckbox<InvoiceReprintQueryView> UseSpecificReport { get; set; } 
        public IRPSComboBox<InvoiceReprintQueryView> CustomReport { get; set; } 
        public IRPSCheckbox<InvoiceReprintQueryView> UIClientMail { get; set; } 
        public IRPSButton<InvoiceReprintQueryView,EmailChildDialogView> EmailChildNavigationCommandButton { get; set; } 
        public InvoiceReprintPrintableQueryCollectionEditor<InvoiceReprintQueryView,EmailChildDialogView> InvoiceReprintPrintableQuery { get; set; } 
        public InvoiceReprint Screen { get; set; }
        public InvoiceReprintQueryView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class InvoiceReprintPrintableQueryCollectionEditor<InvoiceReprintQueryView,EmailChildDialogView>:RPSCollectionEditor<InvoiceReprintQueryView,EmailChildDialogView> where InvoiceReprintQueryView : class, IView where EmailChildDialogView : class, IView
    {
        public  InvoiceReprintPrintableQueryGridView<InvoiceReprintQueryView,EmailChildDialogView> GridView {get;set;}
    }
    public partial class InvoiceReprintPrintableQueryGridView <InvoiceReprintQueryView,EmailChildDialogView> :  RPSGridView<InvoiceReprintQueryView,EmailChildDialogView> where InvoiceReprintQueryView : class, IView where EmailChildDialogView : class, IView
    {
        public InvoiceReprintPrintableQueryGridView(InvoiceReprintQueryView currentView,EmailChildDialogView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            InvoiceSL_InvoiceDate = RPSControlFactory.CreateRPSGridTextBox<InvoiceReprintQueryView>("","#afb244e9-f586-44e6-8af4-0a31d134cfd3 .ag-row[role='row']@ROWINDEX [col-id='cInvoiceSL_InvoiceDate']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<InvoiceReprintQueryView> InvoiceSL_InvoiceDate { get; set; } 
                     
    }
 
    }
  
            
    public partial class EmailChildDialogView : View
    {
        public EmailChildDialogView(InvoiceReprint screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            CollectionInit params_InvoiceReprintPrintableQuery = new CollectionInit(){IDDescriptor = "53967e37-f556-4599-9623-eec3c21524ec",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="27730698-9670-4d10-a61b-c4570878b7c9",CSSSelectorGrid="",XPathGrid=""};
            InvoiceReprintPrintableQuery = RPSControlFactory.RPSCreateCollectionWithGrid<InvoiceReprintPrintableQueryCollectionEditor<EmailChildDialogView>,EmailChildDialogView>( params_InvoiceReprintPrintableQuery,this);
 

        }
        public InvoiceReprintPrintableQueryCollectionEditor<EmailChildDialogView> InvoiceReprintPrintableQuery { get; set; } 
        public InvoiceReprint Screen { get; set; }
        public EmailChildDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class InvoiceReprintPrintableQueryCollectionEditor<EmailChildDialogView>:RPSCollectionEditor<EmailChildDialogView> where EmailChildDialogView : class, IView
    {
        public  InvoiceReprintPrintableQueryGridView<EmailChildDialogView> GridView {get;set;}
    }
    public partial class InvoiceReprintPrintableQueryGridView <EmailChildDialogView> :  RPSGridView<EmailChildDialogView> where EmailChildDialogView : class, IView
    {
        public InvoiceReprintPrintableQueryGridView(EmailChildDialogView currentView)
        {
            this.WebDriver = currentView.WebDriver;          
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            InvoiceSL_InvoiceDate = RPSControlFactory.CreateRPSGridTextBox<EmailChildDialogView>("","#27730698-9670-4d10-a61b-c4570878b7c9 .ag-row[role='row']@ROWINDEX [col-id='cInvoiceSL_InvoiceDate']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<EmailChildDialogView> InvoiceSL_InvoiceDate { get; set; } 
                     
    }
 
    }
  
    

}