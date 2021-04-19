    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.Sales.AutoInvoice
{
    //RPS VERSION 1.0.0.0
    public partial class AutoInvoice:Screen
    {
        public AutoInvoice():base()
        {
            this.URL = "sales.autoinvoice";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            AutoInvoiceQueryView  = new AutoInvoiceQueryView(this); 
            GenerateInvoiceChildDialogView  = new GenerateInvoiceChildDialogView(this); 
            AutoInvoiceQueryView.InitializeControls(); 
            GenerateInvoiceChildDialogView.InitializeControls(); 
           
        }
      
            public AutoInvoiceQueryView AutoInvoiceQueryView {get; set; } 
            public GenerateInvoiceChildDialogView GenerateInvoiceChildDialogView {get; set; } 
    }
            
    public partial class AutoInvoiceQueryView : View
    {
        public AutoInvoiceQueryView(AutoInvoice screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            IDCustomer = RPSControlFactory.CreateRPSComboBox<AutoInvoiceQueryView>("23c5700e-265e-4682-b6ca-66230bb08c62","","",false, this);
 
            AutoInvoiceAmount = RPSControlFactory.CreateRPSFormattedTextBox<AutoInvoiceQueryView>("26ead6ac-838c-4952-ad56-85df48053405","","",false, this);
 
            AmountLines = RPSControlFactory.CreateRPSFormattedTextBox<AutoInvoiceQueryView>("353ba1b8-0ffc-4913-a0e5-ec10ff5fc805","","",false, this);
 
            Diff = RPSControlFactory.CreateRPSFormattedTextBox<AutoInvoiceQueryView>("00b5c792-0b69-4e22-8fb6-f7928b23730b","","",false, this);
 
            GenerateInvoiceChildNavigationCommand = RPSControlFactory.CreateRPSButtonToView<AutoInvoiceQueryView,GenerateInvoiceChildDialogView>("ebd54f1c-01cd-4344-85fd-19bd8c36fefb","","", this,Screen.GenerateInvoiceChildDialogView);
 
            CollectionInit params_DeliveryNoteLineSLAutoInvoice = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="54d27428-8840-4d5d-b0cd-baa8dcb2f41f",CSSSelectorGrid="",XPathGrid=""};
            DeliveryNoteLineSLAutoInvoice = RPSControlFactory.RPSCreateCollectionWithGrid<DeliveryNoteLineSLAutoInvoiceCollectionEditor<AutoInvoiceQueryView,GenerateInvoiceChildDialogView>,AutoInvoiceQueryView,GenerateInvoiceChildDialogView>( params_DeliveryNoteLineSLAutoInvoice,this,Screen.GenerateInvoiceChildDialogView);
 

        }
        public IRPSComboBox<AutoInvoiceQueryView> IDCustomer { get; set; } 
        public IRPSTextBox<AutoInvoiceQueryView> AutoInvoiceAmount { get; set; } 
        public IRPSTextBox<AutoInvoiceQueryView> AmountLines { get; set; } 
        public IRPSTextBox<AutoInvoiceQueryView> Diff { get; set; } 
        public IRPSButton<AutoInvoiceQueryView,GenerateInvoiceChildDialogView> GenerateInvoiceChildNavigationCommand { get; set; } 
        public DeliveryNoteLineSLAutoInvoiceCollectionEditor<AutoInvoiceQueryView,GenerateInvoiceChildDialogView> DeliveryNoteLineSLAutoInvoice { get; set; } 
        public AutoInvoice Screen { get; set; }
        public AutoInvoiceQueryView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class DeliveryNoteLineSLAutoInvoiceCollectionEditor<AutoInvoiceQueryView,GenerateInvoiceChildDialogView>:RPSCollectionEditor<AutoInvoiceQueryView,GenerateInvoiceChildDialogView> where AutoInvoiceQueryView : class, IView where GenerateInvoiceChildDialogView : class, IView
    {
        public  DeliveryNoteLineSLAutoInvoiceGridView<AutoInvoiceQueryView,GenerateInvoiceChildDialogView> GridView {get;set;}
    }
    public partial class DeliveryNoteLineSLAutoInvoiceGridView <AutoInvoiceQueryView,GenerateInvoiceChildDialogView> :  RPSGridView<AutoInvoiceQueryView,GenerateInvoiceChildDialogView> where AutoInvoiceQueryView : class, IView where GenerateInvoiceChildDialogView : class, IView
    {
        public DeliveryNoteLineSLAutoInvoiceGridView(AutoInvoiceQueryView currentView,GenerateInvoiceChildDialogView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            DeliveryNoteLineSL_Ordenation = RPSControlFactory.CreateRPSGridFormattedTextBox<AutoInvoiceQueryView>("","#54d27428-8840-4d5d-b0cd-baa8dcb2f41f .ag-row[role='row']@ROWINDEX [col-id='cDeliveryNoteLineSL_Ordenation']","",false, this.CurrentView);
 
            DeliveryNoteSL_DeliveryNoteDate = RPSControlFactory.CreateRPSGridTextBox<AutoInvoiceQueryView>("","#54d27428-8840-4d5d-b0cd-baa8dcb2f41f .ag-row[role='row']@ROWINDEX [col-id='cDeliveryNoteSL_DeliveryNoteDate']","",false, this.CurrentView);
 
            QuantityPendingInvoice = RPSControlFactory.CreateRPSGridFormattedTextBox<AutoInvoiceQueryView>("","#54d27428-8840-4d5d-b0cd-baa8dcb2f41f .ag-row[role='row']@ROWINDEX [col-id='cQuantityPendingInvoice']","",false, this.CurrentView);
 
            QuantityToInvoice = RPSControlFactory.CreateRPSGridFormattedTextBox<AutoInvoiceQueryView>("","#54d27428-8840-4d5d-b0cd-baa8dcb2f41f .ag-row[role='row']@ROWINDEX [col-id='cQuantityToInvoice']","",false, this.CurrentView);
 
            QuantitySecondUnitPendingInvoice = RPSControlFactory.CreateRPSGridFormattedTextBox<AutoInvoiceQueryView>("","#54d27428-8840-4d5d-b0cd-baa8dcb2f41f .ag-row[role='row']@ROWINDEX [col-id='cQuantitySecondUnitPendingInvoice']","",false, this.CurrentView);
 
            QuantitySecondUnitToInvoice = RPSControlFactory.CreateRPSGridFormattedTextBox<AutoInvoiceQueryView>("","#54d27428-8840-4d5d-b0cd-baa8dcb2f41f .ag-row[role='row']@ROWINDEX [col-id='cQuantitySecondUnitToInvoice']","",false, this.CurrentView);
 
            PriceToInvoice = RPSControlFactory.CreateRPSGridFormattedTextBox<AutoInvoiceQueryView>("","#54d27428-8840-4d5d-b0cd-baa8dcb2f41f .ag-row[role='row']@ROWINDEX [col-id='cPriceToInvoice']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<AutoInvoiceQueryView> DeliveryNoteLineSL_Ordenation { get; set; } 
        public IRPSGridTextBox<AutoInvoiceQueryView> DeliveryNoteSL_DeliveryNoteDate { get; set; } 
        public IRPSGridTextBox<AutoInvoiceQueryView> QuantityPendingInvoice { get; set; } 
        public IRPSGridTextBox<AutoInvoiceQueryView> QuantityToInvoice { get; set; } 
        public IRPSGridTextBox<AutoInvoiceQueryView> QuantitySecondUnitPendingInvoice { get; set; } 
        public IRPSGridTextBox<AutoInvoiceQueryView> QuantitySecondUnitToInvoice { get; set; } 
        public IRPSGridTextBox<AutoInvoiceQueryView> PriceToInvoice { get; set; } 
                     
    }
 
    }
  
            
    public partial class GenerateInvoiceChildDialogView : View
    {
        public GenerateInvoiceChildDialogView(AutoInvoice screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            CodAutoInvoice = RPSControlFactory.CreateRPSTextBox<GenerateInvoiceChildDialogView>("a372c44b-9430-41cf-b96b-2f07c8526022","","",false, this);
 
            InvoiceDate = RPSControlFactory.CreateRPSTextBox<GenerateInvoiceChildDialogView>("d9859d0d-33a3-43b9-94e1-3dedcd2be418","","",false, this);
 
            AutoInvoiceDate = RPSControlFactory.CreateRPSTextBox<GenerateInvoiceChildDialogView>("088fdeba-a284-4165-a10a-2791e8eeff2e","","",false, this);
 
            IDCodingSeries = RPSControlFactory.CreateRPSComboBox<GenerateInvoiceChildDialogView>("f8165a31-7272-4fcc-9465-fda7f01f35c9","","",false, this);
 

        }
        public IRPSTextBox<GenerateInvoiceChildDialogView> CodAutoInvoice { get; set; } 
        public IRPSTextBox<GenerateInvoiceChildDialogView> InvoiceDate { get; set; } 
        public IRPSTextBox<GenerateInvoiceChildDialogView> AutoInvoiceDate { get; set; } 
        public IRPSComboBox<GenerateInvoiceChildDialogView> IDCodingSeries { get; set; } 
        public AutoInvoice Screen { get; set; }
        public GenerateInvoiceChildDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}