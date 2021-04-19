    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.ReceivablePayable.AgreementDD
{
    //RPS VERSION 1.0.0.0
    public partial class AgreementDD:Screen
    {
        public AgreementDD():base()
        {
            this.URL = "receivablepayable.agreementdd";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            AgreementDDCollectionView  = new AgreementDDCollectionView(this); 
            AgreementDDEntityView  = new AgreementDDEntityView(this); 
            PrintChildDialogView  = new PrintChildDialogView(this); 
            AgreementDDCollectionView.InitializeControls(); 
            AgreementDDEntityView.InitializeControls(); 
            PrintChildDialogView.InitializeControls(); 
           
        }
      
            public AgreementDDCollectionView AgreementDDCollectionView {get; set; } 
            public AgreementDDEntityView AgreementDDEntityView {get; set; } 
            public PrintChildDialogView PrintChildDialogView {get; set; } 
    }
            
    public partial class AgreementDDCollectionView : View
    {
        public AgreementDDCollectionView(AgreementDD screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            NewButton = RPSControlFactory.RPSNewButton<AgreementDDCollectionView,AgreementDDEntityView>( this,Screen.AgreementDDEntityView);
 
            CollectionInit params_MainConsult = new CollectionInit(){IDDescriptor = "e663e27d-50d7-42db-a062-1681015593a2",CSSSelectorDescriptor = "",XPathDescriptor = ""};
            MainConsult = RPSControlFactory.RPSCreateCollection<AgreementDDCollectionView,AgreementDDEntityView>( params_MainConsult,this,Screen.AgreementDDEntityView);
 

        }
        public IRPSButton<AgreementDDCollectionView,AgreementDDEntityView> NewButton { get; set; } 
        public IRPSCollectionEditor<AgreementDDCollectionView,AgreementDDEntityView> MainConsult { get; set; } 
        public AgreementDD Screen { get; set; }
        public AgreementDDCollectionView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class AgreementDDEntityView : View
    {
        public AgreementDDEntityView(AgreementDD screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            SaveButton = RPSControlFactory.RPSSaveButton<AgreementDDEntityView>( this);
 
            DeleteButton = RPSControlFactory.RPSDeleteButton<AgreementDDEntityView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<AgreementDDEntityView,AgreementDDCollectionView>( this,Screen.AgreementDDCollectionView);
 
            BackButton = RPSControlFactory.RPSBackButton<AgreementDDEntityView,AgreementDDCollectionView>( this,Screen.AgreementDDCollectionView);
 
            CustomerSupplier = RPSControlFactory.CreateRPSEnumComboBox<AgreementDDEntityView>("1b861bca-114c-49b6-b163-6b07a11e0fe0","","",true, this);
 
            IDCustomer = RPSControlFactory.CreateRPSComboBox<AgreementDDEntityView>("0e427cec-6adb-483d-807d-fd8c0ddb5aed","","",false, this);
 
            IDSupplier = RPSControlFactory.CreateRPSComboBox<AgreementDDEntityView>("0e4f918a-cb4c-4925-9933-4999fc744780","","",false, this);
 
            IDSupplierBankAccount = RPSControlFactory.CreateRPSComboBox<AgreementDDEntityView>("fa3032ed-5d37-4a87-935f-c6778f27c9a3","","",false, this);
 
            IDCustomerBankAccount = RPSControlFactory.CreateRPSComboBox<AgreementDDEntityView>("90f9ee07-634a-461f-8808-e09e3c631900","","",false, this);
 
            SWIFT = RPSControlFactory.CreateRPSTextBox<AgreementDDEntityView>("db824619-4e4e-4f57-8a30-aff8bdd80f2d","","",false, this);
 
            IBAN = RPSControlFactory.CreateRPSTextBox<AgreementDDEntityView>("b9526f11-0e66-4695-81b9-d92dfbe5e624","","",false, this);
 
            CodAgreementDD = RPSControlFactory.CreateRPSTextBox<AgreementDDEntityView>("7008e9b1-cb78-4d1a-a67b-6e02410f3149","","",true, this);
 
            AgreementDate = RPSControlFactory.CreateRPSTextBox<AgreementDDEntityView>("6d898c5c-d315-4381-a366-11406ff5ff7e","","",false, this);
 
            AgreementStatus = RPSControlFactory.CreateRPSEnumComboBox<AgreementDDEntityView>("6769dec0-c32b-46f9-969d-4c78b4a204f0","","",true, this);
 
            DDType = RPSControlFactory.CreateRPSEnumComboBox<AgreementDDEntityView>("e88a4230-735c-4b9b-bff8-6849f9d3b97f","","",true, this);
 
            AgreementType = RPSControlFactory.CreateRPSEnumComboBox<AgreementDDEntityView>("ae2b9f2f-0e77-421f-997d-e718495bf6d0","","",true, this);
 
            MonthsSinceLastUtilization = RPSControlFactory.CreateRPSFormattedTextBox<AgreementDDEntityView>("f61b930a-b086-428d-b0c1-eb7821c4dff2","","",false, this);
 
            FirstPaymentDate = RPSControlFactory.CreateRPSTextBox<AgreementDDEntityView>("482210b9-f5b8-4b19-a665-4d2611d6b81b","","",false, this);
 
            LastPaymentDate = RPSControlFactory.CreateRPSTextBox<AgreementDDEntityView>("1d370e16-feae-440a-8065-57e3dcd6f91f","","",false, this);
 
            SentPendingDraftCount = RPSControlFactory.CreateRPSFormattedTextBox<AgreementDDEntityView>("b31c9d02-4479-4226-a4f8-1999468fa5d7","","",false, this);
 
            SentNotPendingDraftCount = RPSControlFactory.CreateRPSFormattedTextBox<AgreementDDEntityView>("5be8d4d4-fa98-4bc9-853a-311279045342","","",false, this);
 
            NotSentPendingDraftCount = RPSControlFactory.CreateRPSFormattedTextBox<AgreementDDEntityView>("0daec143-6fb7-4889-9456-614b0ad65e4a","","",false, this);
 
            FirstUtilizationDone = RPSControlFactory.CreateRPSCheckBox<AgreementDDEntityView>("ddfb2658-431c-4c0b-85c4-eb02829e53cf","","",false, this);
 
            FinalUtilizationDone = RPSControlFactory.CreateRPSCheckBox<AgreementDDEntityView>("3f8bce3b-6d5a-4612-a70e-b6355c174f9d","","",false, this);
 
            FirstUtilizationReady = RPSControlFactory.CreateRPSCheckBox<AgreementDDEntityView>("2b4d60e4-1a6f-4bca-9102-e29ebec744ec","","",false, this);
 
            FinalUtilizationReady = RPSControlFactory.CreateRPSCheckBox<AgreementDDEntityView>("bb0f6437-85bd-436e-a11c-71cebd646717","","",false, this);
 
            ExecuteChangeDDTypeToInitialButton = RPSControlFactory.CreateRPSButton<AgreementDDEntityView>( "c89f2c0f-15fb-4e45-b043-5c056a12a68c","","",this);
 
            ExecuteChangeDDTypeToFinalButton = RPSControlFactory.CreateRPSButton<AgreementDDEntityView>( "20ae9263-5d26-48fd-9249-d6be5b432999","","",this);
 
            ExecuteChangeDDTypeToIntermediateButton = RPSControlFactory.CreateRPSButton<AgreementDDEntityView>( "07b297ab-adbc-497e-b2af-c624ce91125f","","",this);
 
            ExecuteNewAgreementFromCopyButton = RPSControlFactory.CreateRPSButton<AgreementDDEntityView>( "3e40a623-d252-4a88-b19e-96f4f2ba8833","","",this);
 
            PrintChildNavigationCommandButton = RPSControlFactory.CreateRPSButtonToView<AgreementDDEntityView,PrintChildDialogView>("b3f8af65-667c-4c8a-abd5-f2a0f34f16a6","","", this,Screen.PrintChildDialogView);
 
            PrintChildMailNavigationCommandButton = RPSControlFactory.CreateRPSButtonToView<AgreementDDEntityView,PrintChildDialogView>("94e0b302-d7f1-408d-ab19-474950b5e8c6","","", this,Screen.PrintChildDialogView);
 
            PrintChildClientMailNavigationCommandButton = RPSControlFactory.CreateRPSButtonToView<AgreementDDEntityView,PrintChildDialogView>("e7a14ef7-faa5-4840-86b9-544318146d46","","", this,Screen.PrintChildDialogView);
 
            CollectionInit params_GetSentTransactions = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="5941671a-864b-4835-b3e2-997cef757aae",CSSSelectorGrid="",XPathGrid=""};
            GetSentTransactions = RPSControlFactory.RPSCreateCollectionWithGrid<GetSentTransactionsCollectionEditor<AgreementDDEntityView,PrintChildDialogView>,AgreementDDEntityView,PrintChildDialogView>( params_GetSentTransactions,this,Screen.PrintChildDialogView);
 
            CollectionInit params_GetNotSentPendingTransactions = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="22cfec9a-85f5-40fc-937d-0431b66dbe75",CSSSelectorGrid="",XPathGrid=""};
            GetNotSentPendingTransactions = RPSControlFactory.RPSCreateCollectionWithGrid<GetNotSentPendingTransactionsCollectionEditor<AgreementDDEntityView,PrintChildDialogView>,AgreementDDEntityView,PrintChildDialogView>( params_GetNotSentPendingTransactions,this,Screen.PrintChildDialogView);
 
            General = RPSControlFactory.CreateRPSSection<AgreementDDEntityView>( "","ul li[rpsid='942eb6b5-7292-472a-bcdc-de8940859746']","",this);
 
            Sent = RPSControlFactory.CreateRPSSection<AgreementDDEntityView>( "","ul li[rpsid='020e7578-2401-4392-b8cd-872b40e1b320']","",this);
 
            Pending = RPSControlFactory.CreateRPSSection<AgreementDDEntityView>( "","ul li[rpsid='0753b412-730b-4235-b8a1-0b9a2bfdcf7a']","",this);
 

        }
        public IRPSSaveButton<AgreementDDEntityView> SaveButton { get; set; } 
        public IRPSButton<AgreementDDEntityView> DeleteButton { get; set; } 
        public IRPSButton<AgreementDDEntityView,AgreementDDCollectionView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<AgreementDDEntityView,AgreementDDCollectionView> BackButton { get; set; } 
        public IRPSComboBox<AgreementDDEntityView> CustomerSupplier { get; set; } 
        public IRPSComboBox<AgreementDDEntityView> IDCustomer { get; set; } 
        public IRPSComboBox<AgreementDDEntityView> IDSupplier { get; set; } 
        public IRPSComboBox<AgreementDDEntityView> IDSupplierBankAccount { get; set; } 
        public IRPSComboBox<AgreementDDEntityView> IDCustomerBankAccount { get; set; } 
        public IRPSTextBox<AgreementDDEntityView> SWIFT { get; set; } 
        public IRPSTextBox<AgreementDDEntityView> IBAN { get; set; } 
        public IRPSTextBox<AgreementDDEntityView> CodAgreementDD { get; set; } 
        public IRPSTextBox<AgreementDDEntityView> AgreementDate { get; set; } 
        public IRPSComboBox<AgreementDDEntityView> AgreementStatus { get; set; } 
        public IRPSComboBox<AgreementDDEntityView> DDType { get; set; } 
        public IRPSComboBox<AgreementDDEntityView> AgreementType { get; set; } 
        public IRPSTextBox<AgreementDDEntityView> MonthsSinceLastUtilization { get; set; } 
        public IRPSTextBox<AgreementDDEntityView> FirstPaymentDate { get; set; } 
        public IRPSTextBox<AgreementDDEntityView> LastPaymentDate { get; set; } 
        public IRPSTextBox<AgreementDDEntityView> SentPendingDraftCount { get; set; } 
        public IRPSTextBox<AgreementDDEntityView> SentNotPendingDraftCount { get; set; } 
        public IRPSTextBox<AgreementDDEntityView> NotSentPendingDraftCount { get; set; } 
        public IRPSCheckbox<AgreementDDEntityView> FirstUtilizationDone { get; set; } 
        public IRPSCheckbox<AgreementDDEntityView> FinalUtilizationDone { get; set; } 
        public IRPSCheckbox<AgreementDDEntityView> FirstUtilizationReady { get; set; } 
        public IRPSCheckbox<AgreementDDEntityView> FinalUtilizationReady { get; set; } 
        public IRPSButton<AgreementDDEntityView> ExecuteChangeDDTypeToInitialButton { get; set; } 
        public IRPSButton<AgreementDDEntityView> ExecuteChangeDDTypeToFinalButton { get; set; } 
        public IRPSButton<AgreementDDEntityView> ExecuteChangeDDTypeToIntermediateButton { get; set; } 
        public IRPSButton<AgreementDDEntityView> ExecuteNewAgreementFromCopyButton { get; set; } 
        public IRPSButton<AgreementDDEntityView,PrintChildDialogView> PrintChildNavigationCommandButton { get; set; } 
        public IRPSButton<AgreementDDEntityView,PrintChildDialogView> PrintChildMailNavigationCommandButton { get; set; } 
        public IRPSButton<AgreementDDEntityView,PrintChildDialogView> PrintChildClientMailNavigationCommandButton { get; set; } 
        public GetSentTransactionsCollectionEditor<AgreementDDEntityView,PrintChildDialogView> GetSentTransactions { get; set; } 
        public GetNotSentPendingTransactionsCollectionEditor<AgreementDDEntityView,PrintChildDialogView> GetNotSentPendingTransactions { get; set; } 
        public IRPSSection<AgreementDDEntityView> General { get; set; } 
        public IRPSSection<AgreementDDEntityView> Sent { get; set; } 
        public IRPSSection<AgreementDDEntityView> Pending { get; set; } 
        public AgreementDD Screen { get; set; }
        public AgreementDDEntityView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class GetSentTransactionsCollectionEditor<AgreementDDEntityView,PrintChildDialogView>:RPSCollectionEditor<AgreementDDEntityView,PrintChildDialogView> where AgreementDDEntityView : class, IView where PrintChildDialogView : class, IView
    {
        public  GetSentTransactionsGridView<AgreementDDEntityView,PrintChildDialogView> GridView {get;set;}
    }
    public partial class GetSentTransactionsGridView <AgreementDDEntityView,PrintChildDialogView> :  RPSGridView<AgreementDDEntityView,PrintChildDialogView> where AgreementDDEntityView : class, IView where PrintChildDialogView : class, IView
    {
        public GetSentTransactionsGridView(AgreementDDEntityView currentView,PrintChildDialogView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            DDTypeSeq = RPSControlFactory.CreateRPSGridEnumComboBox<AgreementDDEntityView>("","#5941671a-864b-4835-b3e2-997cef757aae .ag-row[role='row']@ROWINDEX [col-id='cDDTypeSeq']","",false, this.CurrentView);
 
            InvoiceDate = RPSControlFactory.CreateRPSGridTextBox<AgreementDDEntityView>("","#5941671a-864b-4835-b3e2-997cef757aae .ag-row[role='row']@ROWINDEX [col-id='cInvoiceDate']","",false, this.CurrentView);
 
            SEPAMessage = RPSControlFactory.CreateRPSGridTextBox<AgreementDDEntityView>("","#5941671a-864b-4835-b3e2-997cef757aae .ag-row[role='row']@ROWINDEX [col-id='cSEPAMessage']","",false, this.CurrentView);
 
            SEPAPaymentDate = RPSControlFactory.CreateRPSGridTextBox<AgreementDDEntityView>("","#5941671a-864b-4835-b3e2-997cef757aae .ag-row[role='row']@ROWINDEX [col-id='cSEPAPaymentDate']","",false, this.CurrentView);
 
            SEPAFileDate = RPSControlFactory.CreateRPSGridTextBox<AgreementDDEntityView>("","#5941671a-864b-4835-b3e2-997cef757aae .ag-row[role='row']@ROWINDEX [col-id='cSEPAFileDate']","",false, this.CurrentView);
 
            RemittanceNumber = RPSControlFactory.CreateRPSGridTextBox<AgreementDDEntityView>("","#5941671a-864b-4835-b3e2-997cef757aae .ag-row[role='row']@ROWINDEX [col-id='cRemittanceNumber']","",false, this.CurrentView);
 

        }
        public IRPSGridComboBox<AgreementDDEntityView> DDTypeSeq { get; set; } 
        public IRPSGridTextBox<AgreementDDEntityView> InvoiceDate { get; set; } 
        public IRPSGridTextBox<AgreementDDEntityView> SEPAMessage { get; set; } 
        public IRPSGridTextBox<AgreementDDEntityView> SEPAPaymentDate { get; set; } 
        public IRPSGridTextBox<AgreementDDEntityView> SEPAFileDate { get; set; } 
        public IRPSGridTextBox<AgreementDDEntityView> RemittanceNumber { get; set; } 
                     
    }
 
        public partial class GetNotSentPendingTransactionsCollectionEditor<AgreementDDEntityView,PrintChildDialogView>:RPSCollectionEditor<AgreementDDEntityView,PrintChildDialogView> where AgreementDDEntityView : class, IView where PrintChildDialogView : class, IView
    {
        public  GetNotSentPendingTransactionsGridView<AgreementDDEntityView,PrintChildDialogView> GridView {get;set;}
    }
    public partial class GetNotSentPendingTransactionsGridView <AgreementDDEntityView,PrintChildDialogView> :  RPSGridView<AgreementDDEntityView,PrintChildDialogView> where AgreementDDEntityView : class, IView where PrintChildDialogView : class, IView
    {
        public GetNotSentPendingTransactionsGridView(AgreementDDEntityView currentView,PrintChildDialogView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            DDTypeSeq = RPSControlFactory.CreateRPSGridEnumComboBox<AgreementDDEntityView>("","#22cfec9a-85f5-40fc-937d-0431b66dbe75 .ag-row[role='row']@ROWINDEX [col-id='cDDTypeSeq']","",false, this.CurrentView);
 
            InvoiceDate = RPSControlFactory.CreateRPSGridTextBox<AgreementDDEntityView>("","#22cfec9a-85f5-40fc-937d-0431b66dbe75 .ag-row[role='row']@ROWINDEX [col-id='cInvoiceDate']","",false, this.CurrentView);
 
            RemittanceNumber = RPSControlFactory.CreateRPSGridTextBox<AgreementDDEntityView>("","#22cfec9a-85f5-40fc-937d-0431b66dbe75 .ag-row[role='row']@ROWINDEX [col-id='cRemittanceNumber']","",false, this.CurrentView);
 

        }
        public IRPSGridComboBox<AgreementDDEntityView> DDTypeSeq { get; set; } 
        public IRPSGridTextBox<AgreementDDEntityView> InvoiceDate { get; set; } 
        public IRPSGridTextBox<AgreementDDEntityView> RemittanceNumber { get; set; } 
                     
    }
 
    }
  
            
    public partial class PrintChildDialogView : View
    {
        public PrintChildDialogView(AgreementDD screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            UpdateState = RPSControlFactory.CreateRPSCheckBox<PrintChildDialogView>("eaa2827a-f77a-46a4-9342-275606290184","","",false, this);
 
            CustomReport = RPSControlFactory.CreateRPSEnumComboBox<PrintChildDialogView>("b375299f-4786-4fb9-8ebb-fc5f7c2bbf1a","","",false, this);
 
            OptionThirdLanguage = RPSControlFactory.CreateRPSOption<PrintChildDialogView>( "fc371c88-9f0d-43f6-a8a2-18bb93cdfaae","","",this);
 
            OtherLanguage = RPSControlFactory.CreateRPSOption<PrintChildDialogView>( "c9867776-0394-417c-b2ea-89b5d7092a6b","","",this);
 
            CodOtherLanguage = RPSControlFactory.CreateRPSComboBox<PrintChildDialogView>("f5ee0cd1-68e6-494f-b987-dd6e9ea69ec2","","",false, this);
 

        }
        public IRPSCheckbox<PrintChildDialogView> UpdateState { get; set; } 
        public IRPSComboBox<PrintChildDialogView> CustomReport { get; set; } 
        public IRPSOption<PrintChildDialogView> OptionThirdLanguage { get; set; } 
        public IRPSOption<PrintChildDialogView> OtherLanguage { get; set; } 
        public IRPSComboBox<PrintChildDialogView> CodOtherLanguage { get; set; } 
        public AgreementDD Screen { get; set; }
        public PrintChildDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}