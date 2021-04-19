    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.ReceivablePayable.Remittance
{
    //RPS VERSION 1.0.0.0
    public partial class Remittance:Screen
    {
        public Remittance():base()
        {
            this.URL = "receivablepayable.remittance";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            RemittanceView  = new RemittanceView(this); 
            SearchRemittanceDialogView  = new SearchRemittanceDialogView(this); 
            PrintChildDialogView  = new PrintChildDialogView(this); 
            DateChangeChildDialogView  = new DateChangeChildDialogView(this); 
            SituationChangeChildDialogView  = new SituationChangeChildDialogView(this); 
            AccTransactionsResultChildDialogView  = new AccTransactionsResultChildDialogView(this); 
            RemittanceView.InitializeControls(); 
            SearchRemittanceDialogView.InitializeControls(); 
            PrintChildDialogView.InitializeControls(); 
            DateChangeChildDialogView.InitializeControls(); 
            SituationChangeChildDialogView.InitializeControls(); 
            AccTransactionsResultChildDialogView.InitializeControls(); 
           
        }
      
            public RemittanceView RemittanceView {get; set; } 
            public SearchRemittanceDialogView SearchRemittanceDialogView {get; set; } 
            public PrintChildDialogView PrintChildDialogView {get; set; } 
            public DateChangeChildDialogView DateChangeChildDialogView {get; set; } 
            public SituationChangeChildDialogView SituationChangeChildDialogView {get; set; } 
            public AccTransactionsResultChildDialogView AccTransactionsResultChildDialogView {get; set; } 
    }
            
    public partial class RemittanceView : View
    {
        public RemittanceView(Remittance screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            IDBankAccountCompany = RPSControlFactory.CreateRPSComboBox<RemittanceView>("2970f6ed-2485-4055-b17b-fea2652c3934","","",false, this);
 
            RemittanceNumber = RPSControlFactory.CreateRPSTextBox<RemittanceView>("4a4de17b-9a7b-43e9-83d6-a6ad7c44187f","","",false, this);
 
            OkCommand = RPSControlFactory.CreateRPSButton<RemittanceView>( "da724426-693b-4e63-98b0-e92f20756cac","","",this);
 
            RemittanceDate = RPSControlFactory.CreateRPSTextBox<RemittanceView>("483db6b0-29ca-4a7e-9551-9da40f63a7d2","","",false, this);
 
            PaymentType = RPSControlFactory.CreateRPSComboBox<RemittanceView>("4ead31e2-c057-4d79-8eb7-6ca15dd22f02","","",false, this);
 
            PaymentStatus = RPSControlFactory.CreateRPSComboBox<RemittanceView>("72c08f09-bb13-4ea2-8e30-c467f03efea3","","",false, this);
 
            CustomerSupplier = RPSControlFactory.CreateRPSEnumComboBox<RemittanceView>("64b1e72b-1e9f-458d-aaa4-f66d422de571","","",false, this);
 
            TotalAmountCurrency = RPSControlFactory.CreateRPSFormattedTextBox<RemittanceView>("cd51d778-52fe-4ecb-bab6-06c3d565e7b1","","",false, this);
 
            TotalAmount = RPSControlFactory.CreateRPSFormattedTextBox<RemittanceView>("ad9c4074-2672-4e47-b497-e3d7d897cc30","","",false, this);
 
            InterestAmount = RPSControlFactory.CreateRPSFormattedTextBox<RemittanceView>("324e476d-5ade-428b-9312-4c903fb77ce7","","",false, this);
 
            CommissionAmount = RPSControlFactory.CreateRPSFormattedTextBox<RemittanceView>("ca2d34d7-a2fa-4ac4-8b58-d8f8807c5bee","","",false, this);
 
            ExpensesAmount = RPSControlFactory.CreateRPSFormattedTextBox<RemittanceView>("7a4b04f6-9f75-4795-a076-2d7bee5ac536","","",false, this);
 
            RPTransactions_CustomerSupplier = RPSControlFactory.CreateRPSTextBox<RemittanceView>("6563b805-aad0-48d6-8e8d-5e6387c7f74a","","",false, this);
 
            RPTransactions_InvoiceDate = RPSControlFactory.CreateRPSTextBox<RemittanceView>("87437d88-3633-4a00-9be0-bf1faddef260","","",false, this);
 
            RPTransactions_DraftNumber = RPSControlFactory.CreateRPSFormattedTextBox<RemittanceView>("7387a5f0-7762-4863-856a-f0d3292b5940","","",false, this);
 
            RPTransactions_DueDate = RPSControlFactory.CreateRPSTextBox<RemittanceView>("94a357f8-9eb0-4693-b465-841c840fdec0","","",false, this);
 
            RPTransactions_StatementNumber = RPSControlFactory.CreateRPSTextBox<RemittanceView>("2612590c-3c0b-410d-abb7-50e3c287cff9","","",false, this);
 
            RPTransactions_RefNumber = RPSControlFactory.CreateRPSTextBox<RemittanceView>("57d390f2-c33a-4a61-b275-6181738f7da5","","",false, this);
 
            RPTransactions_RefDate = RPSControlFactory.CreateRPSTextBox<RemittanceView>("028aca88-4f97-47ab-99e6-bcd4825a6108","","",false, this);
 
            RPTransactions_CodFromInvoice = RPSControlFactory.CreateRPSTextBox<RemittanceView>("c6b07b04-45f7-4718-9e20-1520a3725cf2","","",false, this);
 
            RPTransactions_Advance = RPSControlFactory.CreateRPSCheckBox<RemittanceView>("028c7497-5dd8-41c9-96ab-6f0cf7521b68","","",false, this);
 
            RPTransactions_Change = RPSControlFactory.CreateRPSFormattedTextBox<RemittanceView>("7324a637-a2a7-4175-826f-873a1a96b51c","","",false, this);
 
            RPTransactions_FixedChange = RPSControlFactory.CreateRPSCheckBox<RemittanceView>("f4249a27-c3ba-4330-9d1d-64aae755a892","","",false, this);
 
            RPTransactions_CollectionDate = RPSControlFactory.CreateRPSTextBox<RemittanceView>("6050e210-2181-4893-a4b1-1728c11382f2","","",false, this);
 
            RPTransactions_CDDueDate = RPSControlFactory.CreateRPSTextBox<RemittanceView>("242d4222-f0b4-4c9a-9103-52536f738aa8","","",false, this);
 
            RPTransactions_CDToleranceDueDate = RPSControlFactory.CreateRPSTextBox<RemittanceView>("4da8a022-cecd-4e5d-8436-05db7d239dd4","","",false, this);
 
            PrintChildNavigationCommandButton = RPSControlFactory.CreateRPSButtonToView<RemittanceView,PrintChildDialogView>("e9d92422-7f51-449a-99b5-a9e7a98a3df6","","", this,Screen.PrintChildDialogView);
 
            DateChangeChildNavigationCommandButton = RPSControlFactory.CreateRPSButtonToView<RemittanceView,DateChangeChildDialogView>("ed726df8-fcd7-4bca-b7b9-60e1a9ee36f6","","", this,Screen.DateChangeChildDialogView);
 
            RemoveRemittanceCommandButton = RPSControlFactory.CreateRPSButton<RemittanceView>( "10742b6c-4405-4c03-a875-7b0568b1207f","","",this);
 
            DraftQueryManagementCommandButton = RPSControlFactory.CreateRPSButton<RemittanceView>( "46802bfa-815a-4e5c-926d-f6cdeb31f734","","",this);
 
            RecalculateExpensesRemittanceCommandButton = RPSControlFactory.CreateRPSButton<RemittanceView>( "fccb2466-4aae-436c-91a0-707d8d667338","","",this);
 
            CollectionInit params_GetRPTransactionsRemittanceNumberAllProperties = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="e66f2607-1eba-4984-9bc7-af31788ef58f",CSSSelectorGrid="",XPathGrid=""};
            GetRPTransactionsRemittanceNumberAllProperties = RPSControlFactory.RPSCreateCollectionWithGrid<GetRPTransactionsRemittanceNumberAllPropertiesCollectionEditor<RemittanceView,SearchRemittanceDialogView>,RemittanceView,SearchRemittanceDialogView>( params_GetRPTransactionsRemittanceNumberAllProperties,this,Screen.SearchRemittanceDialogView);
 

        }
        public IRPSComboBox<RemittanceView> IDBankAccountCompany { get; set; } 
        public IRPSTextBox<RemittanceView> RemittanceNumber { get; set; } 
        public IRPSButton<RemittanceView> OkCommand { get; set; } 
        public IRPSTextBox<RemittanceView> RemittanceDate { get; set; } 
        public IRPSComboBox<RemittanceView> PaymentType { get; set; } 
        public IRPSComboBox<RemittanceView> PaymentStatus { get; set; } 
        public IRPSComboBox<RemittanceView> CustomerSupplier { get; set; } 
        public IRPSTextBox<RemittanceView> TotalAmountCurrency { get; set; } 
        public IRPSTextBox<RemittanceView> TotalAmount { get; set; } 
        public IRPSTextBox<RemittanceView> InterestAmount { get; set; } 
        public IRPSTextBox<RemittanceView> CommissionAmount { get; set; } 
        public IRPSTextBox<RemittanceView> ExpensesAmount { get; set; } 
        public IRPSTextBox<RemittanceView> RPTransactions_CustomerSupplier { get; set; } 
        public IRPSTextBox<RemittanceView> RPTransactions_InvoiceDate { get; set; } 
        public IRPSTextBox<RemittanceView> RPTransactions_DraftNumber { get; set; } 
        public IRPSTextBox<RemittanceView> RPTransactions_DueDate { get; set; } 
        public IRPSTextBox<RemittanceView> RPTransactions_StatementNumber { get; set; } 
        public IRPSTextBox<RemittanceView> RPTransactions_RefNumber { get; set; } 
        public IRPSTextBox<RemittanceView> RPTransactions_RefDate { get; set; } 
        public IRPSTextBox<RemittanceView> RPTransactions_CodFromInvoice { get; set; } 
        public IRPSCheckbox<RemittanceView> RPTransactions_Advance { get; set; } 
        public IRPSTextBox<RemittanceView> RPTransactions_Change { get; set; } 
        public IRPSCheckbox<RemittanceView> RPTransactions_FixedChange { get; set; } 
        public IRPSTextBox<RemittanceView> RPTransactions_CollectionDate { get; set; } 
        public IRPSTextBox<RemittanceView> RPTransactions_CDDueDate { get; set; } 
        public IRPSTextBox<RemittanceView> RPTransactions_CDToleranceDueDate { get; set; } 
        public IRPSButton<RemittanceView,PrintChildDialogView> PrintChildNavigationCommandButton { get; set; } 
        public IRPSButton<RemittanceView,DateChangeChildDialogView> DateChangeChildNavigationCommandButton { get; set; } 
        public IRPSButton<RemittanceView> RemoveRemittanceCommandButton { get; set; } 
        public IRPSButton<RemittanceView> DraftQueryManagementCommandButton { get; set; } 
        public IRPSButton<RemittanceView> RecalculateExpensesRemittanceCommandButton { get; set; } 
        public GetRPTransactionsRemittanceNumberAllPropertiesCollectionEditor<RemittanceView,SearchRemittanceDialogView> GetRPTransactionsRemittanceNumberAllProperties { get; set; } 
        public Remittance Screen { get; set; }
        public RemittanceView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class GetRPTransactionsRemittanceNumberAllPropertiesCollectionEditor<RemittanceView,SearchRemittanceDialogView>:RPSCollectionEditor<RemittanceView,SearchRemittanceDialogView> where RemittanceView : class, IView where SearchRemittanceDialogView : class, IView
    {
        public  GetRPTransactionsRemittanceNumberAllPropertiesGridView<RemittanceView,SearchRemittanceDialogView> GridView {get;set;}
    }
    public partial class GetRPTransactionsRemittanceNumberAllPropertiesGridView <RemittanceView,SearchRemittanceDialogView> :  RPSGridView<RemittanceView,SearchRemittanceDialogView> where RemittanceView : class, IView where SearchRemittanceDialogView : class, IView
    {
        public GetRPTransactionsRemittanceNumberAllPropertiesGridView(RemittanceView currentView,SearchRemittanceDialogView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            RPTransactions_InvoiceDate = RPSControlFactory.CreateRPSGridTextBox<RemittanceView>("","#e66f2607-1eba-4984-9bc7-af31788ef58f .ag-row[role='row']@ROWINDEX [col-id='cRPTransactions_InvoiceDate']","",false, this.CurrentView);
 
            RPTransactions_RefNumber = RPSControlFactory.CreateRPSGridTextBox<RemittanceView>("","#e66f2607-1eba-4984-9bc7-af31788ef58f .ag-row[role='row']@ROWINDEX [col-id='cRPTransactions_RefNumber']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<RemittanceView> RPTransactions_InvoiceDate { get; set; } 
        public IRPSGridTextBox<RemittanceView> RPTransactions_RefNumber { get; set; } 
                     
    }
 
    }
  
            
    public partial class SearchRemittanceDialogView : View
    {
        public SearchRemittanceDialogView(Remittance screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            RemittanceNumber = RPSControlFactory.CreateRPSTextBox<SearchRemittanceDialogView>("51e3897d-be93-4c68-809f-6543ec75000d","","",false, this);
 
            IDBankAccountCompany = RPSControlFactory.CreateRPSComboBox<SearchRemittanceDialogView>("cc78cc4f-5781-41a5-a744-957fc96b075d","","",false, this);
 
            DateFrom = RPSControlFactory.CreateRPSTextBox<SearchRemittanceDialogView>("a578c490-426f-4940-b20b-246353eef2da","","",false, this);
 
            DateTo = RPSControlFactory.CreateRPSTextBox<SearchRemittanceDialogView>("b0986722-9eff-4c45-8f32-5aeb4385c63a","","",false, this);
 
            bExcludeFinal = RPSControlFactory.CreateRPSCheckBox<SearchRemittanceDialogView>("d2bef543-6654-413f-b30c-e0f138d4206a","","",false, this);
 
            ExecuteGetRemittanceNumbers = RPSControlFactory.CreateRPSButton<SearchRemittanceDialogView>( "0bd27487-5eb0-48ff-a520-d1a766bf7b60","","",this);
 
            CollectionInit params_GetRemittanceNumbers = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="d04132ee-3382-4bc9-b2c2-b21d8be9f215",CSSSelectorGrid="",XPathGrid=""};
            GetRemittanceNumbers = RPSControlFactory.RPSCreateCollectionWithGrid<GetRemittanceNumbersCollectionEditor<SearchRemittanceDialogView>,SearchRemittanceDialogView>( params_GetRemittanceNumbers,this);
 

        }
        public IRPSTextBox<SearchRemittanceDialogView> RemittanceNumber { get; set; } 
        public IRPSComboBox<SearchRemittanceDialogView> IDBankAccountCompany { get; set; } 
        public IRPSTextBox<SearchRemittanceDialogView> DateFrom { get; set; } 
        public IRPSTextBox<SearchRemittanceDialogView> DateTo { get; set; } 
        public IRPSCheckbox<SearchRemittanceDialogView> bExcludeFinal { get; set; } 
        public IRPSButton<SearchRemittanceDialogView> ExecuteGetRemittanceNumbers { get; set; } 
        public GetRemittanceNumbersCollectionEditor<SearchRemittanceDialogView> GetRemittanceNumbers { get; set; } 
        public Remittance Screen { get; set; }
        public SearchRemittanceDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class GetRemittanceNumbersCollectionEditor<SearchRemittanceDialogView>:RPSCollectionEditor<SearchRemittanceDialogView> where SearchRemittanceDialogView : class, IView
    {
        public  GetRemittanceNumbersGridView<SearchRemittanceDialogView> GridView {get;set;}
    }
    public partial class GetRemittanceNumbersGridView <SearchRemittanceDialogView> :  RPSGridView<SearchRemittanceDialogView> where SearchRemittanceDialogView : class, IView
    {
        public GetRemittanceNumbersGridView(SearchRemittanceDialogView currentView)
        {
            this.WebDriver = currentView.WebDriver;          
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            RemittanceNumber = RPSControlFactory.CreateRPSGridTextBox<SearchRemittanceDialogView>("","#d04132ee-3382-4bc9-b2c2-b21d8be9f215 .ag-row[role='row']@ROWINDEX [col-id='cRemittanceNumber']","",false, this.CurrentView);
 
            RemittanceDate = RPSControlFactory.CreateRPSGridTextBox<SearchRemittanceDialogView>("","#d04132ee-3382-4bc9-b2c2-b21d8be9f215 .ag-row[role='row']@ROWINDEX [col-id='cRemittanceDate']","",false, this.CurrentView);
 
            CustomerSupplier = RPSControlFactory.CreateRPSGridEnumComboBox<SearchRemittanceDialogView>("","#d04132ee-3382-4bc9-b2c2-b21d8be9f215 .ag-row[role='row']@ROWINDEX [col-id='cCustomerSupplier']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<SearchRemittanceDialogView> RemittanceNumber { get; set; } 
        public IRPSGridTextBox<SearchRemittanceDialogView> RemittanceDate { get; set; } 
        public IRPSGridComboBox<SearchRemittanceDialogView> CustomerSupplier { get; set; } 
                     
    }
 
    }
  
            
    public partial class PrintChildDialogView : View
    {
        public PrintChildDialogView(Remittance screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            ChangeStatus = RPSControlFactory.CreateRPSCheckBox<PrintChildDialogView>("0c3d6e7c-0a09-4de4-adec-1e85ef925d44","","",false, this);
 
            NewAccountingDate = RPSControlFactory.CreateRPSTextBox<PrintChildDialogView>("6f9595b3-2de0-4759-8ebf-28e1c6bcb0a6","","",false, this);
 
            PaymentStatus = RPSControlFactory.CreateRPSComboBox<PrintChildDialogView>("9d779632-465f-4a61-9e62-e5bedb047c91","","",false, this);
 

        }
        public IRPSCheckbox<PrintChildDialogView> ChangeStatus { get; set; } 
        public IRPSTextBox<PrintChildDialogView> NewAccountingDate { get; set; } 
        public IRPSComboBox<PrintChildDialogView> PaymentStatus { get; set; } 
        public Remittance Screen { get; set; }
        public PrintChildDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class DateChangeChildDialogView : View
    {
        public DateChangeChildDialogView(Remittance screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            NewDate = RPSControlFactory.CreateRPSTextBox<DateChangeChildDialogView>("b55a4e68-a5d5-471a-b699-7e0681ffde0e","","",false, this);
 

        }
        public IRPSTextBox<DateChangeChildDialogView> NewDate { get; set; } 
        public Remittance Screen { get; set; }
        public DateChangeChildDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class SituationChangeChildDialogView : View
    {
        public SituationChangeChildDialogView(Remittance screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            NewAccountingDate = RPSControlFactory.CreateRPSTextBox<SituationChangeChildDialogView>("15a1ef75-0b0c-4ce6-bfd9-7dbe02679e3e","","",false, this);
 
            PaymentStatus = RPSControlFactory.CreateRPSComboBox<SituationChangeChildDialogView>("a2a7f34b-07c0-4fa8-9c6c-29eff4e92161","","",false, this);
 
            IDUnpaidCause = RPSControlFactory.CreateRPSComboBox<SituationChangeChildDialogView>("4ffe5714-f24f-49e3-a33a-13a20f5fbdec","","",false, this);
 
            returnExpenses = RPSControlFactory.CreateRPSFormattedTextBox<SituationChangeChildDialogView>("b2bcc8c3-85e8-47a0-9e55-9ba72fd7a9dc","","",false, this);
 
            ReturnDate = RPSControlFactory.CreateRPSTextBox<SituationChangeChildDialogView>("8f3471e8-d93a-46eb-bf92-5f9566e16cf3","","",false, this);
 

        }
        public IRPSTextBox<SituationChangeChildDialogView> NewAccountingDate { get; set; } 
        public IRPSComboBox<SituationChangeChildDialogView> PaymentStatus { get; set; } 
        public IRPSComboBox<SituationChangeChildDialogView> IDUnpaidCause { get; set; } 
        public IRPSTextBox<SituationChangeChildDialogView> returnExpenses { get; set; } 
        public IRPSTextBox<SituationChangeChildDialogView> ReturnDate { get; set; } 
        public Remittance Screen { get; set; }
        public SituationChangeChildDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class AccTransactionsResultChildDialogView : View
    {
        public AccTransactionsResultChildDialogView(Remittance screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            IDACCTransactionsResult = RPSControlFactory.CreateRPSComboBox<AccTransactionsResultChildDialogView>("378e7fd4-76fc-45e8-82f7-0929b453225d","","",false, this);
 

        }
        public IRPSComboBox<AccTransactionsResultChildDialogView> IDACCTransactionsResult { get; set; } 
        public Remittance Screen { get; set; }
        public AccTransactionsResultChildDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}