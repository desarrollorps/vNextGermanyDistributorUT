    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.ReceivablePayable.NonPostedDrafts
{
    //RPS VERSION 1.0.0.0
    public partial class NonPostedDrafts:Screen
    {
        public NonPostedDrafts():base()
        {
            this.URL = "receivablepayable.nonposteddrafts";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            NonPostedDraftsQueryView  = new NonPostedDraftsQueryView(this); 
            NonPostedDraftsQueryView.InitializeControls(); 
           
        }
      
            public NonPostedDraftsQueryView NonPostedDraftsQueryView {get; set; } 
    }
            
    public partial class NonPostedDraftsQueryView : View
    {
        public NonPostedDraftsQueryView(NonPostedDrafts screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            Customer1 = RPSControlFactory.CreateRPSOption<NonPostedDraftsQueryView>( "a26dff1e-41ff-4537-9d5f-43fd209898b7","","",this);
 
            Supplier = RPSControlFactory.CreateRPSOption<NonPostedDraftsQueryView>( "cdceb623-5409-439b-b72c-7b8c80b81680","","",this);
 
            Customer = RPSControlFactory.CreateRPSComboBox<NonPostedDraftsQueryView>("886079a8-ed1a-46d4-a7c6-e31ccdfac81d","","",false, this);
 
            Supplier1 = RPSControlFactory.CreateRPSComboBox<NonPostedDraftsQueryView>("df26d6c1-fd7a-45f6-9a97-b87ce9b51b15","","",false, this);
 
            CodInvoice = RPSControlFactory.CreateRPSTextBox<NonPostedDraftsQueryView>("8ea6fda7-04a7-4adf-9168-d33b88129377","","",false, this);
 
            DateFromInvoice = RPSControlFactory.CreateRPSTextBox<NonPostedDraftsQueryView>("67b07444-84b2-4f98-bba2-402ef56db221","","",false, this);
 
            DateToInvoice = RPSControlFactory.CreateRPSTextBox<NonPostedDraftsQueryView>("f570c2fb-2364-4f69-993a-ca77a76bd0d9","","",false, this);
 
            DateFromDue = RPSControlFactory.CreateRPSTextBox<NonPostedDraftsQueryView>("5e33c14f-0205-453d-ab1c-8d8526ca007f","","",false, this);
 
            DateToDue = RPSControlFactory.CreateRPSTextBox<NonPostedDraftsQueryView>("4a3b44bd-2c8d-41ec-949d-8ae956ea9e3c","","",false, this);
 
            IDCurrency = RPSControlFactory.CreateRPSComboBox<NonPostedDraftsQueryView>("cc7eb208-4559-48da-9a72-02be6a62ad63","","",false, this);
 
            CustomerSupplier = RPSControlFactory.CreateRPSTextBox<NonPostedDraftsQueryView>("5979851e-1225-4612-906c-353c17023b2f","","",false, this);
 
            InvoiceDate = RPSControlFactory.CreateRPSTextBox<NonPostedDraftsQueryView>("78796620-6666-410e-bd8e-1b56c417e528","","",false, this);
 
            DraftNumber = RPSControlFactory.CreateRPSFormattedTextBox<NonPostedDraftsQueryView>("6f12137c-7ffe-4621-9fee-247e430fac9d","","",false, this);
 
            Advance = RPSControlFactory.CreateRPSCheckBox<NonPostedDraftsQueryView>("1499a5c1-3c2e-4df9-8ec5-c7a934a5039f","","",false, this);
 
            DueDate = RPSControlFactory.CreateRPSTextBox<NonPostedDraftsQueryView>("22158b09-ae23-4230-b83c-03a988bebd74","","",false, this);
 
            FixedChange = RPSControlFactory.CreateRPSCheckBox<NonPostedDraftsQueryView>("1c612139-bb63-4ec6-bb45-56c66b4ef0f3","","",false, this);
 
            Change = RPSControlFactory.CreateRPSFormattedTextBox<NonPostedDraftsQueryView>("b987d2e1-42e9-4f0e-9b68-ed461ea53e5b","","",false, this);
 
            CDDueDate = RPSControlFactory.CreateRPSTextBox<NonPostedDraftsQueryView>("068452a5-0334-45d1-90d0-9d1e02cd6769","","",false, this);
 
            CDToleranceDueDate = RPSControlFactory.CreateRPSTextBox<NonPostedDraftsQueryView>("3a233269-be68-4a9f-a6e7-cd53ea618104","","",false, this);
 
            ExecuteTransferCommandButton = RPSControlFactory.CreateRPSButton<NonPostedDraftsQueryView>( "ed098057-9381-4adc-af9b-65c4cc498340","","",this);
 
            CollectionInit params_GetNonPostedDrafts = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="73ff130b-f231-441f-8e82-694a5455d24b",CSSSelectorGrid="",XPathGrid=""};
            GetNonPostedDrafts = RPSControlFactory.RPSCreateCollectionWithGrid<GetNonPostedDraftsCollectionEditor<NonPostedDraftsQueryView>,NonPostedDraftsQueryView>( params_GetNonPostedDrafts,this);
 

        }
        public IRPSOption<NonPostedDraftsQueryView> Customer1 { get; set; } 
        public IRPSOption<NonPostedDraftsQueryView> Supplier { get; set; } 
        public IRPSComboBox<NonPostedDraftsQueryView> Customer { get; set; } 
        public IRPSComboBox<NonPostedDraftsQueryView> Supplier1 { get; set; } 
        public IRPSTextBox<NonPostedDraftsQueryView> CodInvoice { get; set; } 
        public IRPSTextBox<NonPostedDraftsQueryView> DateFromInvoice { get; set; } 
        public IRPSTextBox<NonPostedDraftsQueryView> DateToInvoice { get; set; } 
        public IRPSTextBox<NonPostedDraftsQueryView> DateFromDue { get; set; } 
        public IRPSTextBox<NonPostedDraftsQueryView> DateToDue { get; set; } 
        public IRPSComboBox<NonPostedDraftsQueryView> IDCurrency { get; set; } 
        public IRPSTextBox<NonPostedDraftsQueryView> CustomerSupplier { get; set; } 
        public IRPSTextBox<NonPostedDraftsQueryView> InvoiceDate { get; set; } 
        public IRPSTextBox<NonPostedDraftsQueryView> DraftNumber { get; set; } 
        public IRPSCheckbox<NonPostedDraftsQueryView> Advance { get; set; } 
        public IRPSTextBox<NonPostedDraftsQueryView> DueDate { get; set; } 
        public IRPSCheckbox<NonPostedDraftsQueryView> FixedChange { get; set; } 
        public IRPSTextBox<NonPostedDraftsQueryView> Change { get; set; } 
        public IRPSTextBox<NonPostedDraftsQueryView> CDDueDate { get; set; } 
        public IRPSTextBox<NonPostedDraftsQueryView> CDToleranceDueDate { get; set; } 
        public IRPSButton<NonPostedDraftsQueryView> ExecuteTransferCommandButton { get; set; } 
        public GetNonPostedDraftsCollectionEditor<NonPostedDraftsQueryView> GetNonPostedDrafts { get; set; } 
        public NonPostedDrafts Screen { get; set; }
        public NonPostedDraftsQueryView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class GetNonPostedDraftsCollectionEditor<NonPostedDraftsQueryView>:RPSCollectionEditor<NonPostedDraftsQueryView> where NonPostedDraftsQueryView : class, IView
    {
        public  GetNonPostedDraftsGridView<NonPostedDraftsQueryView> GridView {get;set;}
    }
    public partial class GetNonPostedDraftsGridView <NonPostedDraftsQueryView> :  RPSGridView<NonPostedDraftsQueryView> where NonPostedDraftsQueryView : class, IView
    {
        public GetNonPostedDraftsGridView(NonPostedDraftsQueryView currentView)
        {
            this.WebDriver = currentView.WebDriver;          
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            CustomerSupplier = RPSControlFactory.CreateRPSGridTextBox<NonPostedDraftsQueryView>("","#73ff130b-f231-441f-8e82-694a5455d24b .ag-row[role='row']@ROWINDEX [col-id='cCustomerSupplier']","",false, this.CurrentView);
 
            DraftNumber = RPSControlFactory.CreateRPSGridFormattedTextBox<NonPostedDraftsQueryView>("","#73ff130b-f231-441f-8e82-694a5455d24b .ag-row[role='row']@ROWINDEX [col-id='cDraftNumber']","",false, this.CurrentView);
 
            InvoiceDate = RPSControlFactory.CreateRPSGridTextBox<NonPostedDraftsQueryView>("","#73ff130b-f231-441f-8e82-694a5455d24b .ag-row[role='row']@ROWINDEX [col-id='cInvoiceDate']","",false, this.CurrentView);
 
            DueDate = RPSControlFactory.CreateRPSGridTextBox<NonPostedDraftsQueryView>("","#73ff130b-f231-441f-8e82-694a5455d24b .ag-row[role='row']@ROWINDEX [col-id='cDueDate']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<NonPostedDraftsQueryView> CustomerSupplier { get; set; } 
        public IRPSGridTextBox<NonPostedDraftsQueryView> DraftNumber { get; set; } 
        public IRPSGridTextBox<NonPostedDraftsQueryView> InvoiceDate { get; set; } 
        public IRPSGridTextBox<NonPostedDraftsQueryView> DueDate { get; set; } 
                     
    }
 
    }
  
    

}