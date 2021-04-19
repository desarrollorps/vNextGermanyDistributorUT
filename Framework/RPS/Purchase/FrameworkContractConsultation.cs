    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.Purchase.FrameworkContractConsultation
{
    //RPS VERSION 1.0.0.0
    public partial class FrameworkContractConsultation:Screen
    {
        public FrameworkContractConsultation():base()
        {
            this.URL = "purchase.frameworkcontractconsultation";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            FrameworkContractConsultationQueryView  = new FrameworkContractConsultationQueryView(this); 
            FrameworkContractConsultationQueryView.InitializeControls(); 
           
        }
      
            public FrameworkContractConsultationQueryView FrameworkContractConsultationQueryView {get; set; } 
    }
            
    public partial class FrameworkContractConsultationQueryView : View
    {
        public FrameworkContractConsultationQueryView(FrameworkContractConsultation screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            IDFrameworkContractFilter = RPSControlFactory.CreateRPSCollectionComboBox<FrameworkContractConsultationQueryView>("783ec32b-4eaa-431e-b946-3612c61e09e3","","",false, this);
 
            IDFrameworkContractSupplierFilter = RPSControlFactory.CreateRPSCollectionComboBox<FrameworkContractConsultationQueryView>("c91e54bb-14f0-4470-ae0a-c5bd65c23612","","",false, this);
 
            IDFrameworkContractStatus = RPSControlFactory.CreateRPSComboBox<FrameworkContractConsultationQueryView>("d3e8dc63-f055-4cfc-b343-a134fc3104e2","","",false, this);
 
            eStatusType = RPSControlFactory.CreateRPSEnumComboBox<FrameworkContractConsultationQueryView>("88db699a-3ebc-4392-a81d-6c16890eea2d","","",false, this);
 
            IseStatusTypesAll = RPSControlFactory.CreateRPSCheckBox<FrameworkContractConsultationQueryView>("1ef00aab-ed42-4352-b2d0-99875eac290d","","",false, this);
 
            FrameworkContractDateFromFilter = RPSControlFactory.CreateRPSTextBox<FrameworkContractConsultationQueryView>("d06934c5-92b0-410b-9af7-49defc145cbc","","",false, this);
 
            FrameworkContractDateToFilter = RPSControlFactory.CreateRPSTextBox<FrameworkContractConsultationQueryView>("6532f97a-01ec-412c-bb24-8b2d1c610570","","",false, this);
 
            AllCurrentlyActive = RPSControlFactory.CreateRPSCheckBox<FrameworkContractConsultationQueryView>("6d878dbc-5cd5-4c6a-8ac3-fcecd8298bf2","","",false, this);
 
            IDProductLinesFilter = RPSControlFactory.CreateRPSCollectionComboBox<FrameworkContractConsultationQueryView>("4bbd4db0-e5e4-4169-9021-40cb92e82a72","","",false, this);
 
            IDProductFamiliesFilter = RPSControlFactory.CreateRPSCollectionComboBox<FrameworkContractConsultationQueryView>("1c6b543a-ae6d-4cbc-a93f-805c40ec7ac8","","",false, this);
 
            IDProductSubFamiliesFilter = RPSControlFactory.CreateRPSCollectionComboBox<FrameworkContractConsultationQueryView>("60db2bf0-e07d-4392-8274-b000ce4181bf","","",false, this);
 
            IDFrameworkContractArticleFilter = RPSControlFactory.CreateRPSCollectionComboBox<FrameworkContractConsultationQueryView>("e6ea1841-45b0-44ec-a52b-fe8d7e121fc5","","",false, this);
 
            SupplierReference = RPSControlFactory.CreateRPSEnumComboBox<FrameworkContractConsultationQueryView>("42e39564-737f-4ff6-8d84-890eb90937f1","","",false, this);
 
            IDSupplierRequestQuotationFilter = RPSControlFactory.CreateRPSCollectionComboBox<FrameworkContractConsultationQueryView>("7b07747b-fe04-4da0-8e77-3de581374fab","","",false, this);
 
            IDOrderFilter = RPSControlFactory.CreateRPSCollectionComboBox<FrameworkContractConsultationQueryView>("5f2b74f6-ed1d-48ab-b448-def97805a406","","",false, this);
 
            CollectionInit params_FrameworkContractConsultation = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="dc5bded0-f15a-4c68-948f-e5fc36c1407c",CSSSelectorGrid="",XPathGrid=""};
            FrameworkContractConsultation = RPSControlFactory.RPSCreateCollectionWithGrid<FrameworkContractConsultationCollectionEditor<FrameworkContractConsultationQueryView>,FrameworkContractConsultationQueryView>( params_FrameworkContractConsultation,this);
 
            CollectionInit params_FrameworkContractLineConsultation = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="db16033d-a356-429d-979e-46ab8ecce706",CSSSelectorGrid="",XPathGrid=""};
            FrameworkContractLineConsultation = RPSControlFactory.RPSCreateCollectionWithGrid<FrameworkContractLineConsultationCollectionEditor<FrameworkContractConsultationQueryView>,FrameworkContractConsultationQueryView>( params_FrameworkContractLineConsultation,this);
 
            CollectionInit params_CuDistGetOrderLinesForFCLine = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="4af5c43d-701e-48e2-81f1-7b6328cb81da",CSSSelectorGrid="",XPathGrid=""};
            CuDistGetOrderLinesForFCLine = RPSControlFactory.RPSCreateCollectionWithGrid<CuDistGetOrderLinesForFCLineCollectionEditor<FrameworkContractConsultationQueryView>,FrameworkContractConsultationQueryView>( params_CuDistGetOrderLinesForFCLine,this);
 

        }
        public IRPSCollectionComboBox<FrameworkContractConsultationQueryView> IDFrameworkContractFilter { get; set; } 
        public IRPSCollectionComboBox<FrameworkContractConsultationQueryView> IDFrameworkContractSupplierFilter { get; set; } 
        public IRPSComboBox<FrameworkContractConsultationQueryView> IDFrameworkContractStatus { get; set; } 
        public IRPSComboBox<FrameworkContractConsultationQueryView> eStatusType { get; set; } 
        public IRPSCheckbox<FrameworkContractConsultationQueryView> IseStatusTypesAll { get; set; } 
        public IRPSTextBox<FrameworkContractConsultationQueryView> FrameworkContractDateFromFilter { get; set; } 
        public IRPSTextBox<FrameworkContractConsultationQueryView> FrameworkContractDateToFilter { get; set; } 
        public IRPSCheckbox<FrameworkContractConsultationQueryView> AllCurrentlyActive { get; set; } 
        public IRPSCollectionComboBox<FrameworkContractConsultationQueryView> IDProductLinesFilter { get; set; } 
        public IRPSCollectionComboBox<FrameworkContractConsultationQueryView> IDProductFamiliesFilter { get; set; } 
        public IRPSCollectionComboBox<FrameworkContractConsultationQueryView> IDProductSubFamiliesFilter { get; set; } 
        public IRPSCollectionComboBox<FrameworkContractConsultationQueryView> IDFrameworkContractArticleFilter { get; set; } 
        public IRPSComboBox<FrameworkContractConsultationQueryView> SupplierReference { get; set; } 
        public IRPSCollectionComboBox<FrameworkContractConsultationQueryView> IDSupplierRequestQuotationFilter { get; set; } 
        public IRPSCollectionComboBox<FrameworkContractConsultationQueryView> IDOrderFilter { get; set; } 
        public FrameworkContractConsultationCollectionEditor<FrameworkContractConsultationQueryView> FrameworkContractConsultation { get; set; } 
        public FrameworkContractLineConsultationCollectionEditor<FrameworkContractConsultationQueryView> FrameworkContractLineConsultation { get; set; } 
        public CuDistGetOrderLinesForFCLineCollectionEditor<FrameworkContractConsultationQueryView> CuDistGetOrderLinesForFCLine { get; set; } 
        public FrameworkContractConsultation Screen { get; set; }
        public FrameworkContractConsultationQueryView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class FrameworkContractConsultationCollectionEditor<FrameworkContractConsultationQueryView>:RPSCollectionEditor<FrameworkContractConsultationQueryView> where FrameworkContractConsultationQueryView : class, IView
    {
        public  FrameworkContractConsultationGridView<FrameworkContractConsultationQueryView> GridView {get;set;}
    }
    public partial class FrameworkContractConsultationGridView <FrameworkContractConsultationQueryView> :  RPSGridView<FrameworkContractConsultationQueryView> where FrameworkContractConsultationQueryView : class, IView
    {
        public FrameworkContractConsultationGridView(FrameworkContractConsultationQueryView currentView)
        {
            this.WebDriver = currentView.WebDriver;          
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            FrameworkContract_DateFrom = RPSControlFactory.CreateRPSGridTextBox<FrameworkContractConsultationQueryView>("","#dc5bded0-f15a-4c68-948f-e5fc36c1407c .ag-row[role='row']@ROWINDEX [col-id='cFrameworkContract_DateFrom']","",false, this.CurrentView);
 
            FrameworkContract_DateTo = RPSControlFactory.CreateRPSGridTextBox<FrameworkContractConsultationQueryView>("","#dc5bded0-f15a-4c68-948f-e5fc36c1407c .ag-row[role='row']@ROWINDEX [col-id='cFrameworkContract_DateTo']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<FrameworkContractConsultationQueryView> FrameworkContract_DateFrom { get; set; } 
        public IRPSGridTextBox<FrameworkContractConsultationQueryView> FrameworkContract_DateTo { get; set; } 
                     
    }
 
        public partial class FrameworkContractLineConsultationCollectionEditor<FrameworkContractConsultationQueryView>:RPSCollectionEditor<FrameworkContractConsultationQueryView> where FrameworkContractConsultationQueryView : class, IView
    {
        public  FrameworkContractLineConsultationGridView<FrameworkContractConsultationQueryView> GridView {get;set;}
    }
    public partial class FrameworkContractLineConsultationGridView <FrameworkContractConsultationQueryView> :  RPSGridView<FrameworkContractConsultationQueryView> where FrameworkContractConsultationQueryView : class, IView
    {
        public FrameworkContractLineConsultationGridView(FrameworkContractConsultationQueryView currentView)
        {
            this.WebDriver = currentView.WebDriver;          
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            FrameworkContractLine_Quantity = RPSControlFactory.CreateRPSGridFormattedTextBox<FrameworkContractConsultationQueryView>("","#db16033d-a356-429d-979e-46ab8ecce706 .ag-row[role='row']@ROWINDEX [col-id='cFrameworkContractLine_Quantity']","",false, this.CurrentView);
 
            FrameworkContractLine_OrderQuantity = RPSControlFactory.CreateRPSGridFormattedTextBox<FrameworkContractConsultationQueryView>("","#db16033d-a356-429d-979e-46ab8ecce706 .ag-row[role='row']@ROWINDEX [col-id='cFrameworkContractLine_OrderQuantity']","",false, this.CurrentView);
 
            FrameworkContractLine_PercentVAT = RPSControlFactory.CreateRPSGridFormattedTextBox<FrameworkContractConsultationQueryView>("","#db16033d-a356-429d-979e-46ab8ecce706 .ag-row[role='row']@ROWINDEX [col-id='cFrameworkContractLine_PercentVAT']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<FrameworkContractConsultationQueryView> FrameworkContractLine_Quantity { get; set; } 
        public IRPSGridTextBox<FrameworkContractConsultationQueryView> FrameworkContractLine_OrderQuantity { get; set; } 
        public IRPSGridTextBox<FrameworkContractConsultationQueryView> FrameworkContractLine_PercentVAT { get; set; } 
                     
    }
 
        public partial class CuDistGetOrderLinesForFCLineCollectionEditor<FrameworkContractConsultationQueryView>:RPSCollectionEditor<FrameworkContractConsultationQueryView> where FrameworkContractConsultationQueryView : class, IView
    {
        public  CuDistGetOrderLinesForFCLineGridView<FrameworkContractConsultationQueryView> GridView {get;set;}
    }
    public partial class CuDistGetOrderLinesForFCLineGridView <FrameworkContractConsultationQueryView> :  RPSGridView<FrameworkContractConsultationQueryView> where FrameworkContractConsultationQueryView : class, IView
    {
        public CuDistGetOrderLinesForFCLineGridView(FrameworkContractConsultationQueryView currentView)
        {
            this.WebDriver = currentView.WebDriver;          
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            CodOrder = RPSControlFactory.CreateRPSGridTextBox<FrameworkContractConsultationQueryView>("","#4af5c43d-701e-48e2-81f1-7b6328cb81da .ag-row[role='row']@ROWINDEX [col-id='cCodOrder']","",false, this.CurrentView);
 
            NumLine = RPSControlFactory.CreateRPSGridFormattedTextBox<FrameworkContractConsultationQueryView>("","#4af5c43d-701e-48e2-81f1-7b6328cb81da .ag-row[role='row']@ROWINDEX [col-id='cNumLine']","",false, this.CurrentView);
 
            OrderDate = RPSControlFactory.CreateRPSGridTextBox<FrameworkContractConsultationQueryView>("","#4af5c43d-701e-48e2-81f1-7b6328cb81da .ag-row[role='row']@ROWINDEX [col-id='cOrderDate']","",false, this.CurrentView);
 
            Quantity = RPSControlFactory.CreateRPSGridFormattedTextBox<FrameworkContractConsultationQueryView>("","#4af5c43d-701e-48e2-81f1-7b6328cb81da .ag-row[role='row']@ROWINDEX [col-id='cQuantity']","",false, this.CurrentView);
 
            CodUnitQuantity = RPSControlFactory.CreateRPSGridTextBox<FrameworkContractConsultationQueryView>("","#4af5c43d-701e-48e2-81f1-7b6328cb81da .ag-row[role='row']@ROWINDEX [col-id='cCodUnitQuantity']","",false, this.CurrentView);
 
            DescUnitQuantity = RPSControlFactory.CreateRPSGridTextBox<FrameworkContractConsultationQueryView>("","#4af5c43d-701e-48e2-81f1-7b6328cb81da .ag-row[role='row']@ROWINDEX [col-id='cDescUnitQuantity']","",false, this.CurrentView);
 
            Price = RPSControlFactory.CreateRPSGridFormattedTextBox<FrameworkContractConsultationQueryView>("","#4af5c43d-701e-48e2-81f1-7b6328cb81da .ag-row[role='row']@ROWINDEX [col-id='cPrice']","",false, this.CurrentView);
 
            ReceptionDate = RPSControlFactory.CreateRPSGridTextBox<FrameworkContractConsultationQueryView>("","#4af5c43d-701e-48e2-81f1-7b6328cb81da .ag-row[role='row']@ROWINDEX [col-id='cReceptionDate']","",false, this.CurrentView);
 
            ReceptionDemandDate = RPSControlFactory.CreateRPSGridTextBox<FrameworkContractConsultationQueryView>("","#4af5c43d-701e-48e2-81f1-7b6328cb81da .ag-row[role='row']@ROWINDEX [col-id='cReceptionDemandDate']","",false, this.CurrentView);
 
            ReceivedQuantity = RPSControlFactory.CreateRPSGridTextBox<FrameworkContractConsultationQueryView>("","#4af5c43d-701e-48e2-81f1-7b6328cb81da .ag-row[role='row']@ROWINDEX [col-id='cReceivedQuantity']","",false, this.CurrentView);
 
            PendingReceive = RPSControlFactory.CreateRPSGridCheckBox<FrameworkContractConsultationQueryView>("","#4af5c43d-701e-48e2-81f1-7b6328cb81da .ag-row[role='row']@ROWINDEX [col-id='cPendingReceive']","",false, this.CurrentView);
 
            InvoicedQuantity = RPSControlFactory.CreateRPSGridFormattedTextBox<FrameworkContractConsultationQueryView>("","#4af5c43d-701e-48e2-81f1-7b6328cb81da .ag-row[role='row']@ROWINDEX [col-id='cInvoicedQuantity']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<FrameworkContractConsultationQueryView> CodOrder { get; set; } 
        public IRPSGridTextBox<FrameworkContractConsultationQueryView> NumLine { get; set; } 
        public IRPSGridTextBox<FrameworkContractConsultationQueryView> OrderDate { get; set; } 
        public IRPSGridTextBox<FrameworkContractConsultationQueryView> Quantity { get; set; } 
        public IRPSGridTextBox<FrameworkContractConsultationQueryView> CodUnitQuantity { get; set; } 
        public IRPSGridTextBox<FrameworkContractConsultationQueryView> DescUnitQuantity { get; set; } 
        public IRPSGridTextBox<FrameworkContractConsultationQueryView> Price { get; set; } 
        public IRPSGridTextBox<FrameworkContractConsultationQueryView> ReceptionDate { get; set; } 
        public IRPSGridTextBox<FrameworkContractConsultationQueryView> ReceptionDemandDate { get; set; } 
        public IRPSGridTextBox<FrameworkContractConsultationQueryView> ReceivedQuantity { get; set; } 
        public IRPSGridCheckbox<FrameworkContractConsultationQueryView> PendingReceive { get; set; } 
        public IRPSGridTextBox<FrameworkContractConsultationQueryView> InvoicedQuantity { get; set; } 
                     
    }
 
    }
  
    

}