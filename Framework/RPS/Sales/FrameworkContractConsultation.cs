    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.Sales.FrameworkContractConsultation
{
    //RPS VERSION 1.0.0.0
    public partial class FrameworkContractConsultation:Screen
    {
        public FrameworkContractConsultation():base()
        {
            this.URL = "sales.frameworkcontractconsultation";
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
            IDFrameworkContractFilter = RPSControlFactory.CreateRPSCollectionComboBox<FrameworkContractConsultationQueryView>("69a5d831-f32a-471a-9c41-4167bbda66ab","","",false, this);
 
            IDFrameworkContractCustomerFilter = RPSControlFactory.CreateRPSCollectionComboBox<FrameworkContractConsultationQueryView>("a47ff6aa-d6d0-4275-98fc-9a0a7ffd4320","","",false, this);
 
            IDFrameworkContractStatus = RPSControlFactory.CreateRPSComboBox<FrameworkContractConsultationQueryView>("32482c32-7741-4744-8cee-5d97713a47e7","","",false, this);
 
            eStatusType = RPSControlFactory.CreateRPSEnumComboBox<FrameworkContractConsultationQueryView>("d39e61bb-49a7-49c3-8d83-0571b8b1728d","","",false, this);
 
            IseStatusTypesAll = RPSControlFactory.CreateRPSCheckBox<FrameworkContractConsultationQueryView>("1ef00aab-ed42-4352-b2d0-99875eac290d","","",false, this);
 
            FrameworkContractDateFromFilter = RPSControlFactory.CreateRPSTextBox<FrameworkContractConsultationQueryView>("d06934c5-92b0-410b-9af7-49defc145cbc","","",false, this);
 
            FrameworkContractDateToFilter = RPSControlFactory.CreateRPSTextBox<FrameworkContractConsultationQueryView>("6532f97a-01ec-412c-bb24-8b2d1c610570","","",false, this);
 
            AllCurrentlyActive = RPSControlFactory.CreateRPSCheckBox<FrameworkContractConsultationQueryView>("6d878dbc-5cd5-4c6a-8ac3-fcecd8298bf2","","",false, this);
 
            IDProductLinesFilter = RPSControlFactory.CreateRPSCollectionComboBox<FrameworkContractConsultationQueryView>("09884a5d-2ee9-4ca0-9f32-4a3b6eaea544","","",false, this);
 
            IDProductFamiliesFilter = RPSControlFactory.CreateRPSCollectionComboBox<FrameworkContractConsultationQueryView>("5914fd50-6ba8-48da-90e5-d048c8da6b33","","",false, this);
 
            IDProductSubFamiliesFilter = RPSControlFactory.CreateRPSCollectionComboBox<FrameworkContractConsultationQueryView>("157a089d-22fd-48df-a523-9e5adaacc208","","",false, this);
 
            IDFrameworkContractArticleFilter = RPSControlFactory.CreateRPSCollectionComboBox<FrameworkContractConsultationQueryView>("5f073c31-d77b-464e-a9ef-e8aa3d742885","","",false, this);
 
            ReferenceCustomer = RPSControlFactory.CreateRPSEnumComboBox<FrameworkContractConsultationQueryView>("97fcd95f-fbdd-41c8-b3d6-0fed701293b1","","",false, this);
 
            IDSalesQuoteFilter = RPSControlFactory.CreateRPSCollectionComboBox<FrameworkContractConsultationQueryView>("cda659af-50ba-4153-b595-449542707f0f","","",false, this);
 
            IDOrderFilter = RPSControlFactory.CreateRPSCollectionComboBox<FrameworkContractConsultationQueryView>("2ef00208-e98e-4920-a502-3f5342784254","","",false, this);
 
            CollectionInit params_FrameworkContractConsultation = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="d748c0e0-2249-4908-b2ec-09176f7d587b",CSSSelectorGrid="",XPathGrid=""};
            FrameworkContractConsultation = RPSControlFactory.RPSCreateCollectionWithGrid<FrameworkContractConsultationCollectionEditor<FrameworkContractConsultationQueryView>,FrameworkContractConsultationQueryView>( params_FrameworkContractConsultation,this);
 
            CollectionInit params_FrameworkContractLineConsultation = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="5c2ea476-49d7-45d5-b07b-cfdb6d8ce365",CSSSelectorGrid="",XPathGrid=""};
            FrameworkContractLineConsultation = RPSControlFactory.RPSCreateCollectionWithGrid<FrameworkContractLineConsultationCollectionEditor<FrameworkContractConsultationQueryView>,FrameworkContractConsultationQueryView>( params_FrameworkContractLineConsultation,this);
 
            CollectionInit params_CuDistGetOrderLinesForFCLine = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="0e671907-c6dd-4238-9a6a-e1d5bbf961e2",CSSSelectorGrid="",XPathGrid=""};
            CuDistGetOrderLinesForFCLine = RPSControlFactory.RPSCreateCollectionWithGrid<CuDistGetOrderLinesForFCLineCollectionEditor<FrameworkContractConsultationQueryView>,FrameworkContractConsultationQueryView>( params_CuDistGetOrderLinesForFCLine,this);
 

        }
        public IRPSCollectionComboBox<FrameworkContractConsultationQueryView> IDFrameworkContractFilter { get; set; } 
        public IRPSCollectionComboBox<FrameworkContractConsultationQueryView> IDFrameworkContractCustomerFilter { get; set; } 
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
        public IRPSComboBox<FrameworkContractConsultationQueryView> ReferenceCustomer { get; set; } 
        public IRPSCollectionComboBox<FrameworkContractConsultationQueryView> IDSalesQuoteFilter { get; set; } 
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
            FrameworkContractSL_DateFrom = RPSControlFactory.CreateRPSGridTextBox<FrameworkContractConsultationQueryView>("","#d748c0e0-2249-4908-b2ec-09176f7d587b .ag-row[role='row']@ROWINDEX [col-id='cFrameworkContractSL_DateFrom']","",false, this.CurrentView);
 
            FrameworkContractSL_DateTo = RPSControlFactory.CreateRPSGridTextBox<FrameworkContractConsultationQueryView>("","#d748c0e0-2249-4908-b2ec-09176f7d587b .ag-row[role='row']@ROWINDEX [col-id='cFrameworkContractSL_DateTo']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<FrameworkContractConsultationQueryView> FrameworkContractSL_DateFrom { get; set; } 
        public IRPSGridTextBox<FrameworkContractConsultationQueryView> FrameworkContractSL_DateTo { get; set; } 
                     
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
            FrameworkContractLineSL_Quantity = RPSControlFactory.CreateRPSGridFormattedTextBox<FrameworkContractConsultationQueryView>("","#5c2ea476-49d7-45d5-b07b-cfdb6d8ce365 .ag-row[role='row']@ROWINDEX [col-id='cFrameworkContractLineSL_Quantity']","",false, this.CurrentView);
 
            FrameworkContractLineSL_OrderQuantity = RPSControlFactory.CreateRPSGridFormattedTextBox<FrameworkContractConsultationQueryView>("","#5c2ea476-49d7-45d5-b07b-cfdb6d8ce365 .ag-row[role='row']@ROWINDEX [col-id='cFrameworkContractLineSL_OrderQuantity']","",false, this.CurrentView);
 
            FrameworkContractLineSL_PercentVAT = RPSControlFactory.CreateRPSGridFormattedTextBox<FrameworkContractConsultationQueryView>("","#5c2ea476-49d7-45d5-b07b-cfdb6d8ce365 .ag-row[role='row']@ROWINDEX [col-id='cFrameworkContractLineSL_PercentVAT']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<FrameworkContractConsultationQueryView> FrameworkContractLineSL_Quantity { get; set; } 
        public IRPSGridTextBox<FrameworkContractConsultationQueryView> FrameworkContractLineSL_OrderQuantity { get; set; } 
        public IRPSGridTextBox<FrameworkContractConsultationQueryView> FrameworkContractLineSL_PercentVAT { get; set; } 
                     
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
            CodOrder = RPSControlFactory.CreateRPSGridTextBox<FrameworkContractConsultationQueryView>("","#0e671907-c6dd-4238-9a6a-e1d5bbf961e2 .ag-row[role='row']@ROWINDEX [col-id='cCodOrder']","",false, this.CurrentView);
 
            NumLine = RPSControlFactory.CreateRPSGridFormattedTextBox<FrameworkContractConsultationQueryView>("","#0e671907-c6dd-4238-9a6a-e1d5bbf961e2 .ag-row[role='row']@ROWINDEX [col-id='cNumLine']","",false, this.CurrentView);
 
            OrderDate = RPSControlFactory.CreateRPSGridTextBox<FrameworkContractConsultationQueryView>("","#0e671907-c6dd-4238-9a6a-e1d5bbf961e2 .ag-row[role='row']@ROWINDEX [col-id='cOrderDate']","",false, this.CurrentView);
 
            Quantity = RPSControlFactory.CreateRPSGridFormattedTextBox<FrameworkContractConsultationQueryView>("","#0e671907-c6dd-4238-9a6a-e1d5bbf961e2 .ag-row[role='row']@ROWINDEX [col-id='cQuantity']","",false, this.CurrentView);
 
            CodUnitQuantity = RPSControlFactory.CreateRPSGridTextBox<FrameworkContractConsultationQueryView>("","#0e671907-c6dd-4238-9a6a-e1d5bbf961e2 .ag-row[role='row']@ROWINDEX [col-id='cCodUnitQuantity']","",false, this.CurrentView);
 
            DescUnitQuantity = RPSControlFactory.CreateRPSGridTextBox<FrameworkContractConsultationQueryView>("","#0e671907-c6dd-4238-9a6a-e1d5bbf961e2 .ag-row[role='row']@ROWINDEX [col-id='cDescUnitQuantity']","",false, this.CurrentView);
 
            Price = RPSControlFactory.CreateRPSGridFormattedTextBox<FrameworkContractConsultationQueryView>("","#0e671907-c6dd-4238-9a6a-e1d5bbf961e2 .ag-row[role='row']@ROWINDEX [col-id='cPrice']","",false, this.CurrentView);
 
            ReceptionDate = RPSControlFactory.CreateRPSGridTextBox<FrameworkContractConsultationQueryView>("","#0e671907-c6dd-4238-9a6a-e1d5bbf961e2 .ag-row[role='row']@ROWINDEX [col-id='cReceptionDate']","",false, this.CurrentView);
 
            ReceptionDemandDate = RPSControlFactory.CreateRPSGridTextBox<FrameworkContractConsultationQueryView>("","#0e671907-c6dd-4238-9a6a-e1d5bbf961e2 .ag-row[role='row']@ROWINDEX [col-id='cReceptionDemandDate']","",false, this.CurrentView);
 
            ReceivedQuantity = RPSControlFactory.CreateRPSGridTextBox<FrameworkContractConsultationQueryView>("","#0e671907-c6dd-4238-9a6a-e1d5bbf961e2 .ag-row[role='row']@ROWINDEX [col-id='cReceivedQuantity']","",false, this.CurrentView);
 
            PendingReceive = RPSControlFactory.CreateRPSGridCheckBox<FrameworkContractConsultationQueryView>("","#0e671907-c6dd-4238-9a6a-e1d5bbf961e2 .ag-row[role='row']@ROWINDEX [col-id='cPendingReceive']","",false, this.CurrentView);
 
            InvoicedQuantity = RPSControlFactory.CreateRPSGridFormattedTextBox<FrameworkContractConsultationQueryView>("","#0e671907-c6dd-4238-9a6a-e1d5bbf961e2 .ag-row[role='row']@ROWINDEX [col-id='cInvoicedQuantity']","",false, this.CurrentView);
 

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