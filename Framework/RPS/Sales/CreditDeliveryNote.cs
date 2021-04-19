    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.Sales.CreditDeliveryNote
{
    //RPS VERSION 1.0.0.0
    public partial class CreditDeliveryNote:Screen
    {
        public CreditDeliveryNote():base()
        {
            this.URL = "sales.creditdeliverynote";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            CreditDeliveryNoteView  = new CreditDeliveryNoteView(this); 
            GenerateCreditDeliveryNoteProcessResultDialogView  = new GenerateCreditDeliveryNoteProcessResultDialogView(this); 
            CreditDeliveryNoteView.InitializeControls(); 
            GenerateCreditDeliveryNoteProcessResultDialogView.InitializeControls(); 
           
        }
      
            public CreditDeliveryNoteView CreditDeliveryNoteView {get; set; } 
            public GenerateCreditDeliveryNoteProcessResultDialogView GenerateCreditDeliveryNoteProcessResultDialogView {get; set; } 
    }
            
    public partial class CreditDeliveryNoteView : View
    {
        public CreditDeliveryNoteView(CreditDeliveryNote screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            UIDeliveryNoteSL = RPSControlFactory.CreateRPSComboBox<CreditDeliveryNoteView>("8ef5aa7d-4ac8-45e3-82cd-a2f2f20ca54d","","",false, this);
 
            UICustomer = RPSControlFactory.CreateRPSComboBox<CreditDeliveryNoteView>("528f8c6e-595a-4255-b7e2-d6a4b97c795f","","",false, this);
 
            UIDeliveryNoteDate = RPSControlFactory.CreateRPSTextBox<CreditDeliveryNoteView>("b41208e9-9515-4c84-ae40-f1f046f1b2d3","","",false, this);
 
            Transport = RPSControlFactory.CreateRPSFormattedTextBox<CreditDeliveryNoteView>("120e6c5d-9971-4695-9c86-522b7f9b6d33","","",false, this);
 
            UICreditDate = RPSControlFactory.CreateRPSTextBox<CreditDeliveryNoteView>("644af7e4-18ba-4d8f-b2f0-8fb5b23afe9e","","",false, this);
 
            UIReturnCauseSL = RPSControlFactory.CreateRPSComboBox<CreditDeliveryNoteView>("68ed5881-0120-4ae2-bac2-33604a9b6c01","","",false, this);
 
            UIOptTotal = RPSControlFactory.CreateRPSOption<CreditDeliveryNoteView>( "85da230c-f7b9-45a8-8467-4749ba706c45","","",this);
 
            UIOptPartial = RPSControlFactory.CreateRPSOption<CreditDeliveryNoteView>( "11a407d2-b8bc-49ef-a523-a646847284b1","","",this);
 
            UINoImputationCostIndirect = RPSControlFactory.CreateRPSCheckBox<CreditDeliveryNoteView>("976c5ed5-32bf-4fca-b43d-b26156757362","","",false, this);
 
            UIOrderComplete = RPSControlFactory.CreateRPSCheckBox<CreditDeliveryNoteView>("8f2eb446-13ac-4e40-afe1-5b2af49d5c6e","","",false, this);
 
            UIDeliveryNoteFinalized = RPSControlFactory.CreateRPSCheckBox<CreditDeliveryNoteView>("6d7610f6-f81b-479a-809f-80b0568430c2","","",false, this);
 
            UIRequiredPrint = RPSControlFactory.CreateRPSCheckBox<CreditDeliveryNoteView>("5c75d24f-282d-4c86-a229-881e02b51a9f","","",false, this);
 
            UIDeliveryNoteCodingSeries = RPSControlFactory.CreateRPSComboBox<CreditDeliveryNoteView>("be9e2f3b-4b91-4e9d-bb41-8755878772b7","","",false, this);
 
            UIInvoiceCodingSeries = RPSControlFactory.CreateRPSComboBox<CreditDeliveryNoteView>("84459edb-9f25-42fa-befa-c45b39126a6d","","",false, this);
 
            UIOptInvoiceWarehouse = RPSControlFactory.CreateRPSOption<CreditDeliveryNoteView>( "6085d4f8-934f-489a-a1a1-1afdb7b3d26a","","",this);
 
            UIOptNewWarehouse = RPSControlFactory.CreateRPSOption<CreditDeliveryNoteView>( "41c52b40-ecb0-4f39-a7e5-deea6d45e6bb","","",this);
 
            UISite = RPSControlFactory.CreateRPSComboBox<CreditDeliveryNoteView>("591e65eb-4f59-41c4-b684-86daac6db9e5","","",false, this);
 
            UIWareHouse = RPSControlFactory.CreateRPSComboBox<CreditDeliveryNoteView>("6745c092-5679-44e5-a77e-5412e5225c4f","","",false, this);
 
            IDLocationWarehouse = RPSControlFactory.CreateRPSComboBox<CreditDeliveryNoteView>("31604284-f6f5-4076-a65e-2e4e79c75f2f","","",false, this);
 
            CollectionInit params_DeliveryNoteCreditLines = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="46acfdde-ed7f-4653-b967-098b53367fbb",CSSSelectorGrid="",XPathGrid=""};
            DeliveryNoteCreditLines = RPSControlFactory.RPSCreateCollectionWithGrid<DeliveryNoteCreditLinesCollectionEditor<CreditDeliveryNoteView,GenerateCreditDeliveryNoteProcessResultDialogView>,CreditDeliveryNoteView,GenerateCreditDeliveryNoteProcessResultDialogView>( params_DeliveryNoteCreditLines,this,Screen.GenerateCreditDeliveryNoteProcessResultDialogView);
 

        }
        public IRPSComboBox<CreditDeliveryNoteView> UIDeliveryNoteSL { get; set; } 
        public IRPSComboBox<CreditDeliveryNoteView> UICustomer { get; set; } 
        public IRPSTextBox<CreditDeliveryNoteView> UIDeliveryNoteDate { get; set; } 
        public IRPSTextBox<CreditDeliveryNoteView> Transport { get; set; } 
        public IRPSTextBox<CreditDeliveryNoteView> UICreditDate { get; set; } 
        public IRPSComboBox<CreditDeliveryNoteView> UIReturnCauseSL { get; set; } 
        public IRPSOption<CreditDeliveryNoteView> UIOptTotal { get; set; } 
        public IRPSOption<CreditDeliveryNoteView> UIOptPartial { get; set; } 
        public IRPSCheckbox<CreditDeliveryNoteView> UINoImputationCostIndirect { get; set; } 
        public IRPSCheckbox<CreditDeliveryNoteView> UIOrderComplete { get; set; } 
        public IRPSCheckbox<CreditDeliveryNoteView> UIDeliveryNoteFinalized { get; set; } 
        public IRPSCheckbox<CreditDeliveryNoteView> UIRequiredPrint { get; set; } 
        public IRPSComboBox<CreditDeliveryNoteView> UIDeliveryNoteCodingSeries { get; set; } 
        public IRPSComboBox<CreditDeliveryNoteView> UIInvoiceCodingSeries { get; set; } 
        public IRPSOption<CreditDeliveryNoteView> UIOptInvoiceWarehouse { get; set; } 
        public IRPSOption<CreditDeliveryNoteView> UIOptNewWarehouse { get; set; } 
        public IRPSComboBox<CreditDeliveryNoteView> UISite { get; set; } 
        public IRPSComboBox<CreditDeliveryNoteView> UIWareHouse { get; set; } 
        public IRPSComboBox<CreditDeliveryNoteView> IDLocationWarehouse { get; set; } 
        public DeliveryNoteCreditLinesCollectionEditor<CreditDeliveryNoteView,GenerateCreditDeliveryNoteProcessResultDialogView> DeliveryNoteCreditLines { get; set; } 
        public CreditDeliveryNote Screen { get; set; }
        public CreditDeliveryNoteView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class DeliveryNoteCreditLinesCollectionEditor<CreditDeliveryNoteView,GenerateCreditDeliveryNoteProcessResultDialogView>:RPSCollectionEditor<CreditDeliveryNoteView,GenerateCreditDeliveryNoteProcessResultDialogView> where CreditDeliveryNoteView : class, IView where GenerateCreditDeliveryNoteProcessResultDialogView : class, IView
    {
        public  DeliveryNoteCreditLinesGridView<CreditDeliveryNoteView,GenerateCreditDeliveryNoteProcessResultDialogView> GridView {get;set;}
    }
    public partial class DeliveryNoteCreditLinesGridView <CreditDeliveryNoteView,GenerateCreditDeliveryNoteProcessResultDialogView> :  RPSGridView<CreditDeliveryNoteView,GenerateCreditDeliveryNoteProcessResultDialogView> where CreditDeliveryNoteView : class, IView where GenerateCreditDeliveryNoteProcessResultDialogView : class, IView
    {
        public DeliveryNoteCreditLinesGridView(CreditDeliveryNoteView currentView,GenerateCreditDeliveryNoteProcessResultDialogView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            DeliveryNoteLineSL_Ordenation = RPSControlFactory.CreateRPSGridFormattedTextBox<CreditDeliveryNoteView>("","#46acfdde-ed7f-4653-b967-098b53367fbb .ag-row[role='row']@ROWINDEX [col-id='cDeliveryNoteLineSL_Ordenation']","",false, this.CurrentView);
 
            RETURNCAUSE = RPSControlFactory.CreateRPSGridComboBox<CreditDeliveryNoteView>("","#46acfdde-ed7f-4653-b967-098b53367fbb .ag-row[role='row']@ROWINDEX [col-id='cRETURNCAUSE']","",false, this.CurrentView);
 
            DeliveryNoteLineSL_Quantity = RPSControlFactory.CreateRPSGridFormattedTextBox<CreditDeliveryNoteView>("","#46acfdde-ed7f-4653-b967-098b53367fbb .ag-row[role='row']@ROWINDEX [col-id='cDeliveryNoteLineSL_Quantity']","",false, this.CurrentView);
 
            DeliveryNoteLineSL_QuantitySecondUnit = RPSControlFactory.CreateRPSGridFormattedTextBox<CreditDeliveryNoteView>("","#46acfdde-ed7f-4653-b967-098b53367fbb .ag-row[role='row']@ROWINDEX [col-id='cDeliveryNoteLineSL_QuantitySecondUnit']","",false, this.CurrentView);
 
            DeliveryNoteLineSL_Series = RPSControlFactory.CreateRPSGridTextBox<CreditDeliveryNoteView>("","#46acfdde-ed7f-4653-b967-098b53367fbb .ag-row[role='row']@ROWINDEX [col-id='cDeliveryNoteLineSL_Series']","",false, this.CurrentView);
 
            CREDITQUANTITY = RPSControlFactory.CreateRPSGridFormattedTextBox<CreditDeliveryNoteView>("","#46acfdde-ed7f-4653-b967-098b53367fbb .ag-row[role='row']@ROWINDEX [col-id='cCREDITQUANTITY']","",false, this.CurrentView);
 
            CREDITQUANTITYSECONDUNIT = RPSControlFactory.CreateRPSGridFormattedTextBox<CreditDeliveryNoteView>("","#46acfdde-ed7f-4653-b967-098b53367fbb .ag-row[role='row']@ROWINDEX [col-id='cCREDITQUANTITYSECONDUNIT']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<CreditDeliveryNoteView> DeliveryNoteLineSL_Ordenation { get; set; } 
        public IRPSGridComboBox<CreditDeliveryNoteView> RETURNCAUSE { get; set; } 
        public IRPSGridTextBox<CreditDeliveryNoteView> DeliveryNoteLineSL_Quantity { get; set; } 
        public IRPSGridTextBox<CreditDeliveryNoteView> DeliveryNoteLineSL_QuantitySecondUnit { get; set; } 
        public IRPSGridTextBox<CreditDeliveryNoteView> DeliveryNoteLineSL_Series { get; set; } 
        public IRPSGridTextBox<CreditDeliveryNoteView> CREDITQUANTITY { get; set; } 
        public IRPSGridTextBox<CreditDeliveryNoteView> CREDITQUANTITYSECONDUNIT { get; set; } 
                     
    }
 
    }
  
            
    public partial class GenerateCreditDeliveryNoteProcessResultDialogView : View
    {
        public GenerateCreditDeliveryNoteProcessResultDialogView(CreditDeliveryNote screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            CollectionInit params_DeliveryNoteSLConsult = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="99f790cb-3562-4163-80c5-0d4591fb0852",CSSSelectorGrid="",XPathGrid=""};
            DeliveryNoteSLConsult = RPSControlFactory.RPSCreateCollectionWithGrid<DeliveryNoteSLConsultCollectionEditor<GenerateCreditDeliveryNoteProcessResultDialogView>,GenerateCreditDeliveryNoteProcessResultDialogView>( params_DeliveryNoteSLConsult,this);
 

        }
        public DeliveryNoteSLConsultCollectionEditor<GenerateCreditDeliveryNoteProcessResultDialogView> DeliveryNoteSLConsult { get; set; } 
        public CreditDeliveryNote Screen { get; set; }
        public GenerateCreditDeliveryNoteProcessResultDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class DeliveryNoteSLConsultCollectionEditor<GenerateCreditDeliveryNoteProcessResultDialogView>:RPSCollectionEditor<GenerateCreditDeliveryNoteProcessResultDialogView> where GenerateCreditDeliveryNoteProcessResultDialogView : class, IView
    {
        public  DeliveryNoteSLConsultGridView<GenerateCreditDeliveryNoteProcessResultDialogView> GridView {get;set;}
    }
    public partial class DeliveryNoteSLConsultGridView <GenerateCreditDeliveryNoteProcessResultDialogView> :  RPSGridView<GenerateCreditDeliveryNoteProcessResultDialogView> where GenerateCreditDeliveryNoteProcessResultDialogView : class, IView
    {
        public DeliveryNoteSLConsultGridView(GenerateCreditDeliveryNoteProcessResultDialogView currentView)
        {
            this.WebDriver = currentView.WebDriver;          
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            DeliveryNoteSL_DeliveryNoteDate = RPSControlFactory.CreateRPSGridTextBox<GenerateCreditDeliveryNoteProcessResultDialogView>("","#99f790cb-3562-4163-80c5-0d4591fb0852 .ag-row[role='row']@ROWINDEX [col-id='cDeliveryNoteSL_DeliveryNoteDate']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<GenerateCreditDeliveryNoteProcessResultDialogView> DeliveryNoteSL_DeliveryNoteDate { get; set; } 
                     
    }
 
    }
  
    

}