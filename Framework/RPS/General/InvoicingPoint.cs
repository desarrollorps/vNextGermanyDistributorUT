    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.General.InvoicingPoint
{
    //RPS VERSION 1.0.0.0
    public partial class InvoicingPoint:Screen
    {
        public InvoicingPoint():base()
        {
            this.URL = "general.invoicingpoint";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            InvoicingPointCollectionView  = new InvoicingPointCollectionView(this); 
            InvoicingPointEntityView  = new InvoicingPointEntityView(this); 
            InvoicingPointCollectionView.InitializeControls(); 
            InvoicingPointEntityView.InitializeControls(); 
           
        }
      
            public InvoicingPointCollectionView InvoicingPointCollectionView {get; set; } 
            public InvoicingPointEntityView InvoicingPointEntityView {get; set; } 
    }
            
    public partial class InvoicingPointCollectionView : View
    {
        public InvoicingPointCollectionView(InvoicingPoint screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            NewButton = RPSControlFactory.RPSNewButton<InvoicingPointCollectionView,InvoicingPointEntityView>( this,Screen.InvoicingPointEntityView);
 
            CollectionInit params_MainConsult = new CollectionInit(){IDDescriptor = "db88a858-336a-4802-89af-752dafab258c",CSSSelectorDescriptor = "",XPathDescriptor = ""};
            MainConsult = RPSControlFactory.RPSCreateCollection<InvoicingPointCollectionView,InvoicingPointEntityView>( params_MainConsult,this,Screen.InvoicingPointEntityView);
 

        }
        public IRPSButton<InvoicingPointCollectionView,InvoicingPointEntityView> NewButton { get; set; } 
        public IRPSCollectionEditor<InvoicingPointCollectionView,InvoicingPointEntityView> MainConsult { get; set; } 
        public InvoicingPoint Screen { get; set; }
        public InvoicingPointCollectionView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class InvoicingPointEntityView : View
    {
        public InvoicingPointEntityView(InvoicingPoint screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            SaveButton = RPSControlFactory.RPSSaveButton<InvoicingPointEntityView>( this);
 
            DeleteButton = RPSControlFactory.RPSDeleteButton<InvoicingPointEntityView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<InvoicingPointEntityView,InvoicingPointCollectionView>( this,Screen.InvoicingPointCollectionView);
 
            BackButton = RPSControlFactory.RPSBackButton<InvoicingPointEntityView,InvoicingPointCollectionView>( this,Screen.InvoicingPointCollectionView);
 
            CodInvoicingPoint = RPSControlFactory.CreateRPSTextBox<InvoicingPointEntityView>("ece4d18a-595e-4730-b888-e21017b76ae5","","",true, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<InvoicingPointEntityView>("8835e68e-6baf-4367-b9aa-a4c71d66c63b","","",false, this);
 
            Main = RPSControlFactory.CreateRPSCheckBox<InvoicingPointEntityView>("2412f6a8-664e-43f6-8260-9983c1ebc293","","",true, this);
 
            CodCountry = RPSControlFactory.CreateRPSComboBox<InvoicingPointEntityView>("d0d789f8-0e88-4d2f-82f1-724d505ff0f0","","",false, this);
 
            ZipCode = RPSControlFactory.CreateRPSTextBox<InvoicingPointEntityView>("26b36dd9-0395-4736-bc39-84673b269376","","",false, this);
 
            IDState = RPSControlFactory.CreateRPSComboBox<InvoicingPointEntityView>("be90719b-e8be-44fb-97e6-1db2e67d091e","","",false, this);
 
            IDCounty = RPSControlFactory.CreateRPSComboBox<InvoicingPointEntityView>("6d68ff33-93d8-4d99-a45f-d95dfa13a1ef","","",false, this);
 
            Address = RPSControlFactory.CreateRPSTextBox<InvoicingPointEntityView>("5391d1dc-030b-4fdf-8734-58267085585f","","",false, this);
 
            City = RPSControlFactory.CreateRPSTextBox<InvoicingPointEntityView>("269481cc-7a03-42bf-a789-f91de0fc30f5","","",false, this);
 
            Phone1 = RPSControlFactory.CreateRPSTextBox<InvoicingPointEntityView>("6b1ab95d-5f36-4b20-8dda-71072a09d60f","","",false, this);
 
            Phone2 = RPSControlFactory.CreateRPSTextBox<InvoicingPointEntityView>("916e7ec4-e8b9-4379-87bf-e3f391d5281c","","",false, this);
 
            Fax = RPSControlFactory.CreateRPSTextBox<InvoicingPointEntityView>("ae456b38-6594-4944-9cb5-7a2e8fd2363c","","",false, this);
 
            Email = RPSControlFactory.CreateRPSEmailTextBox<InvoicingPointEntityView>("cd3fb018-fa52-44a4-ae95-15a07107b130","","",false, this);
 
            IDCodingSerieSalesQuote = RPSControlFactory.CreateRPSComboBox<InvoicingPointEntityView>("0da6dd82-0f3a-4222-8198-830790733948","","",false, this);
 
            IDCodingSerieOrderS = RPSControlFactory.CreateRPSComboBox<InvoicingPointEntityView>("03281eb6-62f7-4c6e-9a8d-5553378f841c","","",false, this);
 
            IDCodingSerieDeliveryNoteS = RPSControlFactory.CreateRPSComboBox<InvoicingPointEntityView>("2430e37e-5d3b-421b-8b20-915c2835b8f3","","",false, this);
 
            IDCodingSerieInvoiceS = RPSControlFactory.CreateRPSComboBox<InvoicingPointEntityView>("b69d6db5-87da-4826-b519-1951f3a66fd8","","",false, this);
 
            IDCodingSerieCreditInvoiceS = RPSControlFactory.CreateRPSComboBox<InvoicingPointEntityView>("3515d2b0-7af4-4476-9732-b84282d503c0","","",false, this);
 
            IDCodingSerieDebitNoteS = RPSControlFactory.CreateRPSComboBox<InvoicingPointEntityView>("7221038f-590c-4c54-aabf-961a2b676dcf","","",false, this);
 
            IDCodingSerieDeliveryNoPrintS = RPSControlFactory.CreateRPSComboBox<InvoicingPointEntityView>("9d5d4c96-4bec-415b-afdf-3390bdbb857c","","",false, this);
 
            IDCodingSerieFrameworkContract = RPSControlFactory.CreateRPSComboBox<InvoicingPointEntityView>("afbdc493-5472-40ec-90e1-d44a7bea062b","","",false, this);
 
            IDCodingSerieAdvanceInvoice = RPSControlFactory.CreateRPSComboBox<InvoicingPointEntityView>("e4735999-3c37-441d-a548-ad30a19b508a","","",false, this);
 
            IDCodingSerieInvoiceP = RPSControlFactory.CreateRPSComboBox<InvoicingPointEntityView>("c17011eb-4d13-4c92-b731-5cc40c308b5f","","",false, this);
 
            IDCodingSerieRetentionVoucher = RPSControlFactory.CreateRPSComboBox<InvoicingPointEntityView>("7aa75568-aa3e-4aae-ae9d-2c23e1ae39ed","","",false, this);
 

        }
        public IRPSSaveButton<InvoicingPointEntityView> SaveButton { get; set; } 
        public IRPSButton<InvoicingPointEntityView> DeleteButton { get; set; } 
        public IRPSButton<InvoicingPointEntityView,InvoicingPointCollectionView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<InvoicingPointEntityView,InvoicingPointCollectionView> BackButton { get; set; } 
        public IRPSTextBox<InvoicingPointEntityView> CodInvoicingPoint { get; set; } 
        public IRPSTextBox<InvoicingPointEntityView> Description { get; set; } 
        public IRPSCheckbox<InvoicingPointEntityView> Main { get; set; } 
        public IRPSComboBox<InvoicingPointEntityView> CodCountry { get; set; } 
        public IRPSTextBox<InvoicingPointEntityView> ZipCode { get; set; } 
        public IRPSComboBox<InvoicingPointEntityView> IDState { get; set; } 
        public IRPSComboBox<InvoicingPointEntityView> IDCounty { get; set; } 
        public IRPSTextBox<InvoicingPointEntityView> Address { get; set; } 
        public IRPSTextBox<InvoicingPointEntityView> City { get; set; } 
        public IRPSTextBox<InvoicingPointEntityView> Phone1 { get; set; } 
        public IRPSTextBox<InvoicingPointEntityView> Phone2 { get; set; } 
        public IRPSTextBox<InvoicingPointEntityView> Fax { get; set; } 
        public IRPSTextBox<InvoicingPointEntityView> Email { get; set; } 
        public IRPSComboBox<InvoicingPointEntityView> IDCodingSerieSalesQuote { get; set; } 
        public IRPSComboBox<InvoicingPointEntityView> IDCodingSerieOrderS { get; set; } 
        public IRPSComboBox<InvoicingPointEntityView> IDCodingSerieDeliveryNoteS { get; set; } 
        public IRPSComboBox<InvoicingPointEntityView> IDCodingSerieInvoiceS { get; set; } 
        public IRPSComboBox<InvoicingPointEntityView> IDCodingSerieCreditInvoiceS { get; set; } 
        public IRPSComboBox<InvoicingPointEntityView> IDCodingSerieDebitNoteS { get; set; } 
        public IRPSComboBox<InvoicingPointEntityView> IDCodingSerieDeliveryNoPrintS { get; set; } 
        public IRPSComboBox<InvoicingPointEntityView> IDCodingSerieFrameworkContract { get; set; } 
        public IRPSComboBox<InvoicingPointEntityView> IDCodingSerieAdvanceInvoice { get; set; } 
        public IRPSComboBox<InvoicingPointEntityView> IDCodingSerieInvoiceP { get; set; } 
        public IRPSComboBox<InvoicingPointEntityView> IDCodingSerieRetentionVoucher { get; set; } 
        public InvoicingPoint Screen { get; set; }
        public InvoicingPointEntityView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}