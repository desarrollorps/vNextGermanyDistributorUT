    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.Sales.DeliveryNoteSLConsult
{
    //RPS VERSION 1.0.0.0
    public partial class DeliveryNoteSLConsult:Screen
    {
        public DeliveryNoteSLConsult():base()
        {
            this.URL = "sales.deliverynoteslconsult";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            DeliveryNoteSLConsultQueryView  = new DeliveryNoteSLConsultQueryView(this); 
            DeliveryNoteSLConsultQueryView.InitializeControls(); 
           
        }
      
            public DeliveryNoteSLConsultQueryView DeliveryNoteSLConsultQueryView {get; set; } 
    }
            
    public partial class DeliveryNoteSLConsultQueryView : View
    {
        public DeliveryNoteSLConsultQueryView(DeliveryNoteSLConsult screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            LsDeliveryNoteSLFilter = RPSControlFactory.CreateRPSCollectionComboBox<DeliveryNoteSLConsultQueryView>("f77369d7-177e-4d0e-8890-76e2555e38a5","","",false, this);
 
            lsIDCustomerFilter = RPSControlFactory.CreateRPSCollectionComboBox<DeliveryNoteSLConsultQueryView>("41607f70-84e1-41a2-a053-9e96c48170da","","",false, this);
 
            DateFromFilter = RPSControlFactory.CreateRPSTextBox<DeliveryNoteSLConsultQueryView>("159e92dc-1c66-436c-b145-9e70e65f872a","","",false, this);
 
            DateToFilter = RPSControlFactory.CreateRPSTextBox<DeliveryNoteSLConsultQueryView>("88e36af8-4c5a-4378-b9f7-e82d8a491c3a","","",false, this);
 
            All = RPSControlFactory.CreateRPSOption<DeliveryNoteSLConsultQueryView>( "cd245f60-373b-48b6-a9cf-663f11c711b0","","",this);
 
            Preliminary = RPSControlFactory.CreateRPSCheckBox<DeliveryNoteSLConsultQueryView>("c2fbf75e-1762-4518-b072-4cbbbf46924d","","",false, this);
 
            PendingInvoice = RPSControlFactory.CreateRPSOption<DeliveryNoteSLConsultQueryView>( "d8548fef-301c-46a3-8b27-6707d4e77620","","",this);
 
            Registered = RPSControlFactory.CreateRPSCheckBox<DeliveryNoteSLConsultQueryView>("1d6f8bd1-7dd4-48b5-af95-ad57df3bd1d0","","",false, this);
 
            PendingTransferDeliveyNotes = RPSControlFactory.CreateRPSOption<DeliveryNoteSLConsultQueryView>( "dca1c134-e9ea-4d73-8965-0a666bfb1086","","",this);
 
            Finalized = RPSControlFactory.CreateRPSCheckBox<DeliveryNoteSLConsultQueryView>("b6ca5cbf-8c74-40ed-8954-d564d8b914c8","","",false, this);
 
            Empresa = RPSControlFactory.CreateRPSOption<DeliveryNoteSLConsultQueryView>( "7a3bfcb1-a6c9-4042-90af-954233e13ece","","",this);
 
            Albaran = RPSControlFactory.CreateRPSOption<DeliveryNoteSLConsultQueryView>( "692b8c2d-1272-417c-bcf4-7c75e991d068","","",this);
 
            SelectedProductLines = RPSControlFactory.CreateRPSCollectionComboBox<DeliveryNoteSLConsultQueryView>("91c93b44-4919-4294-91c1-76cb025c3f89","","",false, this);
 
            SelectedProductFamilies = RPSControlFactory.CreateRPSCollectionComboBox<DeliveryNoteSLConsultQueryView>("e3e9042d-7632-497f-aa64-d020b86a3707","","",false, this);
 
            SelectedProductSubFamilies = RPSControlFactory.CreateRPSCollectionComboBox<DeliveryNoteSLConsultQueryView>("397fe40b-43b7-408b-aaa5-b99dba398b5f","","",false, this);
 
            LsArticleFilter = RPSControlFactory.CreateRPSCollectionComboBox<DeliveryNoteSLConsultQueryView>("875a63bc-ddac-4a5c-a5e1-3cb0198a43a8","","",false, this);
 
            ReferenceCustomer = RPSControlFactory.CreateRPSEnumComboBox<DeliveryNoteSLConsultQueryView>("08b82659-d624-4e95-bf48-67da46be2e41","","",false, this);
 
            SalesQuoteFilter = RPSControlFactory.CreateRPSComboBox<DeliveryNoteSLConsultQueryView>("be52e3aa-720c-4959-8224-2a284c58e26f","","",false, this);
 
            OrderNumberCustomer = RPSControlFactory.CreateRPSTextBox<DeliveryNoteSLConsultQueryView>("6e0acbdf-423e-47c7-b420-4ee92a8dcb2b","","",false, this);
 
            IDProject = RPSControlFactory.CreateRPSComboBox<DeliveryNoteSLConsultQueryView>("82f47588-c4d6-4b72-b44d-43a9d16102c9","","",false, this);
 
            IDManufacturingOrder = RPSControlFactory.CreateRPSComboBox<DeliveryNoteSLConsultQueryView>("5b180625-e2f7-4227-b05a-6e6bc158541d","","",false, this);
 
            InternalCode = RPSControlFactory.CreateRPSTextBox<DeliveryNoteSLConsultQueryView>("c1a120bb-1ae5-4560-a3e6-0fdd21da7943","","",false, this);
 
            IDOrderSLFilter = RPSControlFactory.CreateRPSComboBox<DeliveryNoteSLConsultQueryView>("0e2eeba9-3862-48f2-afe8-f0352a42ee34","","",false, this);
 
            IDMaintenanceOrder = RPSControlFactory.CreateRPSComboBox<DeliveryNoteSLConsultQueryView>("9ba5249b-5d33-4081-8442-c25b695af6fe","","",false, this);
 
            IDFrameworkContractSL = RPSControlFactory.CreateRPSComboBox<DeliveryNoteSLConsultQueryView>("15258785-9dd1-4623-ae54-84e19a2de4b6","","",false, this);
 
            IDMaintenanceContract = RPSControlFactory.CreateRPSComboBox<DeliveryNoteSLConsultQueryView>("ed76c12d-5014-4005-84e6-7b1c79bab26c","","",false, this);
 
            CollectionInit params_DeliveryNoteSLConsult = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="ab0b5f4f-5ef8-4901-816d-d0d882f3fc3a",CSSSelectorGrid="",XPathGrid=""};
            DeliveryNoteSLConsult = RPSControlFactory.RPSCreateCollectionWithGrid<DeliveryNoteSLConsultCollectionEditor<DeliveryNoteSLConsultQueryView>,DeliveryNoteSLConsultQueryView>( params_DeliveryNoteSLConsult,this);
 
            CollectionInit params_DeliveryNoteLineSLConsult = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="a1c6a7d7-fa49-4ac5-9fb2-c84ff05489a6",CSSSelectorGrid="",XPathGrid=""};
            DeliveryNoteLineSLConsult = RPSControlFactory.RPSCreateCollectionWithGrid<DeliveryNoteLineSLConsultCollectionEditor<DeliveryNoteSLConsultQueryView>,DeliveryNoteSLConsultQueryView>( params_DeliveryNoteLineSLConsult,this);
 

        }
        public IRPSCollectionComboBox<DeliveryNoteSLConsultQueryView> LsDeliveryNoteSLFilter { get; set; } 
        public IRPSCollectionComboBox<DeliveryNoteSLConsultQueryView> lsIDCustomerFilter { get; set; } 
        public IRPSTextBox<DeliveryNoteSLConsultQueryView> DateFromFilter { get; set; } 
        public IRPSTextBox<DeliveryNoteSLConsultQueryView> DateToFilter { get; set; } 
        public IRPSOption<DeliveryNoteSLConsultQueryView> All { get; set; } 
        public IRPSCheckbox<DeliveryNoteSLConsultQueryView> Preliminary { get; set; } 
        public IRPSOption<DeliveryNoteSLConsultQueryView> PendingInvoice { get; set; } 
        public IRPSCheckbox<DeliveryNoteSLConsultQueryView> Registered { get; set; } 
        public IRPSOption<DeliveryNoteSLConsultQueryView> PendingTransferDeliveyNotes { get; set; } 
        public IRPSCheckbox<DeliveryNoteSLConsultQueryView> Finalized { get; set; } 
        public IRPSOption<DeliveryNoteSLConsultQueryView> Empresa { get; set; } 
        public IRPSOption<DeliveryNoteSLConsultQueryView> Albaran { get; set; } 
        public IRPSCollectionComboBox<DeliveryNoteSLConsultQueryView> SelectedProductLines { get; set; } 
        public IRPSCollectionComboBox<DeliveryNoteSLConsultQueryView> SelectedProductFamilies { get; set; } 
        public IRPSCollectionComboBox<DeliveryNoteSLConsultQueryView> SelectedProductSubFamilies { get; set; } 
        public IRPSCollectionComboBox<DeliveryNoteSLConsultQueryView> LsArticleFilter { get; set; } 
        public IRPSComboBox<DeliveryNoteSLConsultQueryView> ReferenceCustomer { get; set; } 
        public IRPSComboBox<DeliveryNoteSLConsultQueryView> SalesQuoteFilter { get; set; } 
        public IRPSTextBox<DeliveryNoteSLConsultQueryView> OrderNumberCustomer { get; set; } 
        public IRPSComboBox<DeliveryNoteSLConsultQueryView> IDProject { get; set; } 
        public IRPSComboBox<DeliveryNoteSLConsultQueryView> IDManufacturingOrder { get; set; } 
        public IRPSTextBox<DeliveryNoteSLConsultQueryView> InternalCode { get; set; } 
        public IRPSComboBox<DeliveryNoteSLConsultQueryView> IDOrderSLFilter { get; set; } 
        public IRPSComboBox<DeliveryNoteSLConsultQueryView> IDMaintenanceOrder { get; set; } 
        public IRPSComboBox<DeliveryNoteSLConsultQueryView> IDFrameworkContractSL { get; set; } 
        public IRPSComboBox<DeliveryNoteSLConsultQueryView> IDMaintenanceContract { get; set; } 
        public DeliveryNoteSLConsultCollectionEditor<DeliveryNoteSLConsultQueryView> DeliveryNoteSLConsult { get; set; } 
        public DeliveryNoteLineSLConsultCollectionEditor<DeliveryNoteSLConsultQueryView> DeliveryNoteLineSLConsult { get; set; } 
        public DeliveryNoteSLConsult Screen { get; set; }
        public DeliveryNoteSLConsultQueryView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class DeliveryNoteSLConsultCollectionEditor<DeliveryNoteSLConsultQueryView>:RPSCollectionEditor<DeliveryNoteSLConsultQueryView> where DeliveryNoteSLConsultQueryView : class, IView
    {
        public  DeliveryNoteSLConsultGridView<DeliveryNoteSLConsultQueryView> GridView {get;set;}
    }
    public partial class DeliveryNoteSLConsultGridView <DeliveryNoteSLConsultQueryView> :  RPSGridView<DeliveryNoteSLConsultQueryView> where DeliveryNoteSLConsultQueryView : class, IView
    {
        public DeliveryNoteSLConsultGridView(DeliveryNoteSLConsultQueryView currentView)
        {
            this.WebDriver = currentView.WebDriver;          
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            CustomerMiscellaneousSL_Description = RPSControlFactory.CreateRPSGridTextBox<DeliveryNoteSLConsultQueryView>("","#ab0b5f4f-5ef8-4901-816d-d0d882f3fc3a .ag-row[role='row']@ROWINDEX [col-id='cCustomerMiscellaneousSL_Description']","",false, this.CurrentView);
 
            DeliveryNoteSL_DeliveryNoteDate = RPSControlFactory.CreateRPSGridTextBox<DeliveryNoteSLConsultQueryView>("","#ab0b5f4f-5ef8-4901-816d-d0d882f3fc3a .ag-row[role='row']@ROWINDEX [col-id='cDeliveryNoteSL_DeliveryNoteDate']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<DeliveryNoteSLConsultQueryView> CustomerMiscellaneousSL_Description { get; set; } 
        public IRPSGridTextBox<DeliveryNoteSLConsultQueryView> DeliveryNoteSL_DeliveryNoteDate { get; set; } 
                     
    }
 
        public partial class DeliveryNoteLineSLConsultCollectionEditor<DeliveryNoteSLConsultQueryView>:RPSCollectionEditor<DeliveryNoteSLConsultQueryView> where DeliveryNoteSLConsultQueryView : class, IView
    {
        public  DeliveryNoteLineSLConsultGridView<DeliveryNoteSLConsultQueryView> GridView {get;set;}
    }
    public partial class DeliveryNoteLineSLConsultGridView <DeliveryNoteSLConsultQueryView> :  RPSGridView<DeliveryNoteSLConsultQueryView> where DeliveryNoteSLConsultQueryView : class, IView
    {
        public DeliveryNoteLineSLConsultGridView(DeliveryNoteSLConsultQueryView currentView)
        {
            this.WebDriver = currentView.WebDriver;          
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            OrderLineSL_ReferenceCustomer = RPSControlFactory.CreateRPSGridTextBox<DeliveryNoteSLConsultQueryView>("","#a1c6a7d7-fa49-4ac5-9fb2-c84ff05489a6 .ag-row[role='row']@ROWINDEX [col-id='cOrderLineSL_ReferenceCustomer']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<DeliveryNoteSLConsultQueryView> OrderLineSL_ReferenceCustomer { get; set; } 
                     
    }
 
    }
  
    

}