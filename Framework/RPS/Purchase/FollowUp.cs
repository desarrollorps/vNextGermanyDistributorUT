    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.Purchase.FollowUp
{
    //RPS VERSION 1.0.0.0
    public partial class FollowUp:Screen
    {
        public FollowUp():base()
        {
            this.URL = "purchase.followup";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            FollowUpQueryView  = new FollowUpQueryView(this); 
            FollowUpQueryView.InitializeControls(); 
           
        }
      
            public FollowUpQueryView FollowUpQueryView {get; set; } 
    }
            
    public partial class FollowUpQueryView : View
    {
        public FollowUpQueryView(FollowUp screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            UIOptSRQ = RPSControlFactory.CreateRPSOption<FollowUpQueryView>( "ebc2c03f-13cd-419e-89ef-6c410a59ac69","","",this);
 
            UISupplierRequestQuotation = RPSControlFactory.CreateRPSComboBox<FollowUpQueryView>("7fbabfcf-96f9-44f6-ace9-93f6b12061c8","","",false, this);
 
            UIOptOrder = RPSControlFactory.CreateRPSOption<FollowUpQueryView>( "6fb1c574-31b9-45ba-b267-091a0374530a","","",this);
 
            UIOrder = RPSControlFactory.CreateRPSComboBox<FollowUpQueryView>("b0c02b85-28b9-4f61-80cc-309a9bf746bf","","",false, this);
 
            UIOptDeliveryNote = RPSControlFactory.CreateRPSOption<FollowUpQueryView>( "6de12a9e-fa36-43cb-9402-82435627bb74","","",this);
 
            UIDeliveryNote = RPSControlFactory.CreateRPSComboBox<FollowUpQueryView>("c9d827df-3870-4c8a-a249-6303288ebfe7","","",false, this);
 
            UIOptInvoice = RPSControlFactory.CreateRPSOption<FollowUpQueryView>( "7ce0e29f-f7a7-44e7-ac39-050a498ae46d","","",this);
 
            UIInvoice = RPSControlFactory.CreateRPSComboBox<FollowUpQueryView>("6772e183-70d3-42b8-95e0-395a9856d3dd","","",false, this);
 
            FrameworkContract = RPSControlFactory.CreateRPSOption<FollowUpQueryView>( "c85cc3b1-49c7-4ff9-bdde-8443279b14d5","","",this);
 
            IDFrameworkContract = RPSControlFactory.CreateRPSComboBox<FollowUpQueryView>("ca79d9a6-5a64-4693-98ea-e142b3f2a63a","","",false, this);
 
            UIOptProject = RPSControlFactory.CreateRPSOption<FollowUpQueryView>( "57b72fc3-1e01-4a42-bbef-5156f5168b39","","",this);
 
            UIProject = RPSControlFactory.CreateRPSComboBox<FollowUpQueryView>("80bf2629-bb44-424b-9b0e-d71fda1b50a7","","",false, this);
 
            manufacturingOrder = RPSControlFactory.CreateRPSOption<FollowUpQueryView>( "4c7e4113-ed22-42ac-b409-253818e3c25b","","",this);
 
            UIManufacturingOrder = RPSControlFactory.CreateRPSComboBox<FollowUpQueryView>("6a415a3d-a857-46be-aacd-2e0fd6d27958","","",false, this);
 
            salesOrder = RPSControlFactory.CreateRPSOption<FollowUpQueryView>( "b65c8fe9-e879-4ef9-9746-53f07bb71cef","","",this);
 
            UIOrderSL = RPSControlFactory.CreateRPSComboBox<FollowUpQueryView>("c166625b-8467-466c-b45a-0c0a54e0b6b6","","",false, this);
 
            articleStructure = RPSControlFactory.CreateRPSOption<FollowUpQueryView>( "a1c8e9ac-ebf2-4f03-b918-fc6d2c4b0eff","","",this);
 
            UIArticleStructure = RPSControlFactory.CreateRPSComboBox<FollowUpQueryView>("4629d1c8-5405-435c-8fa5-53cd5b49aaee","","",false, this);
 
            internalCode = RPSControlFactory.CreateRPSOption<FollowUpQueryView>( "9caa7187-5f23-4b73-a276-d8aef333802f","","",this);
 
            UIInternalCode = RPSControlFactory.CreateRPSTextBox<FollowUpQueryView>("3d8d01b8-79ef-4400-9e1f-70b16e902d3f","","",false, this);
 
            orderNumberSupplier = RPSControlFactory.CreateRPSOption<FollowUpQueryView>( "2eba2536-c759-4d19-8ca3-dc3b9ebee715","","",this);
 
            UIOrderNumberSupplier = RPSControlFactory.CreateRPSTextBox<FollowUpQueryView>("9029497d-c43e-4c0f-b074-32ee636a9a8b","","",false, this);
 
            maintenanceOrder = RPSControlFactory.CreateRPSOption<FollowUpQueryView>( "414ebd4d-90cf-42f6-9c99-449dc061ebe4","","",this);
 
            UIIDMaintenanceOrder = RPSControlFactory.CreateRPSComboBox<FollowUpQueryView>("bb8fe5f3-48ac-47f7-8e08-38e94754b9f2","","",false, this);
 
            maintenancecontract = RPSControlFactory.CreateRPSOption<FollowUpQueryView>( "288ec17b-6cc1-4696-bf01-641822aa589a","","",this);
 
            IDMaintenanceContract = RPSControlFactory.CreateRPSComboBox<FollowUpQueryView>("7b7bcfe9-c05e-40c1-b1c6-70c33bb931e0","","",false, this);
 
            frameworkcontract = RPSControlFactory.CreateRPSOption<FollowUpQueryView>( "a9cf5025-30c2-4d7d-9509-a451a1e81f2e","","",this);
 
            IDFrameworkContract1 = RPSControlFactory.CreateRPSComboBox<FollowUpQueryView>("2bd9557b-e5bd-40b3-942b-38831433b74f","","",false, this);
 
            UIDateFrom = RPSControlFactory.CreateRPSTextBox<FollowUpQueryView>("87bda2c8-1077-462e-928d-8f9c0d488c0b","","",false, this);
 
            UIDateTo = RPSControlFactory.CreateRPSTextBox<FollowUpQueryView>("023a4974-9413-40da-8628-ce630c832294","","",false, this);
 
            UILstSupplier = RPSControlFactory.CreateRPSCollectionComboBox<FollowUpQueryView>("47a34984-ae99-4454-bc59-baba2c6d2c37","","",false, this);
 
            IDSupplierGroup = RPSControlFactory.CreateRPSCollectionComboBox<FollowUpQueryView>("ecfe31b2-f0a6-4e25-98b6-577113aefdb6","","",false, this);
 
            IDProductLine = RPSControlFactory.CreateRPSCollectionComboBox<FollowUpQueryView>("ca94c093-5ef8-46fa-920a-97498425d831","","",false, this);
 
            IDProductFamily = RPSControlFactory.CreateRPSCollectionComboBox<FollowUpQueryView>("df16139c-7fc8-45b1-8e99-e444847a4ced","","",false, this);
 
            IDProductSubFamily = RPSControlFactory.CreateRPSCollectionComboBox<FollowUpQueryView>("814ab6f4-83e4-4035-8043-705cec72daf7","","",false, this);
 
            UILstArticle = RPSControlFactory.CreateRPSCollectionComboBox<FollowUpQueryView>("5746b59c-b8e7-4b5b-8241-6519012c4532","","",false, this);
 
            UIRefSupplier = RPSControlFactory.CreateRPSEnumComboBox<FollowUpQueryView>("b1081277-9d2b-433a-8775-9ac58f34cf0a","","",false, this);
 
            UISeries = RPSControlFactory.CreateRPSEnumComboBox<FollowUpQueryView>("c2108ebb-1ec0-46d6-b9a4-2d5e9c263f38","","",false, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<FollowUpQueryView>("aafbe57c-c052-4089-ac47-1e762fabe541","","",false, this);
 
            OrderDate = RPSControlFactory.CreateRPSTextBox<FollowUpQueryView>("157add1b-6af8-471c-ad03-a35d641b7932","","",false, this);
 
            ReceptionDate = RPSControlFactory.CreateRPSTextBox<FollowUpQueryView>("992a6de0-ac81-42eb-af12-b9cd036d9b43","","",false, this);
 
            ReceptionDemandDate = RPSControlFactory.CreateRPSTextBox<FollowUpQueryView>("234a26f6-0024-4b00-aa82-2740854539f7","","",false, this);
 
            OrderLineQuantitySecondUnit = RPSControlFactory.CreateRPSFormattedTextBox<FollowUpQueryView>("9172b6b8-922d-40ff-8d71-f89f0730d839","","",false, this);
 
            OrderLineQuantityPendingReceive = RPSControlFactory.CreateRPSFormattedTextBox<FollowUpQueryView>("6eecd514-c6b5-4ed2-bab6-92770cdb9db1","","",false, this);
 
            OrderLineQuantityPendingInvoice = RPSControlFactory.CreateRPSFormattedTextBox<FollowUpQueryView>("8ad48899-1fa9-496c-be06-d244e4ccc532","","",false, this);
 
            DeliveryNoteDate = RPSControlFactory.CreateRPSTextBox<FollowUpQueryView>("8da16042-2502-4f31-abaa-6916030629ad","","",false, this);
 
            DeliveryNoteLineQuantitySecondUnit = RPSControlFactory.CreateRPSFormattedTextBox<FollowUpQueryView>("07230321-29af-4697-a196-ae7bdc6dd2ff","","",false, this);
 
            DeliveryNoteLineQuantityPending = RPSControlFactory.CreateRPSFormattedTextBox<FollowUpQueryView>("4dcacea8-89af-4648-b7c8-e2a34f8cfb0c","","",false, this);
 
            DeliveryNoteSerie = RPSControlFactory.CreateRPSTextBox<FollowUpQueryView>("4b161026-58da-4a4d-9007-6743647f1f5f","","",false, this);
 
            InvoiceDate = RPSControlFactory.CreateRPSTextBox<FollowUpQueryView>("c9a9a1e2-2dfa-471c-a459-a748f589d98c","","",false, this);
 
            CollectionInit params_FollowOrderDeliveryNoteInvoice = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="cc5de5fc-399c-40f6-ae2a-815a2b331fc4",CSSSelectorGrid="",XPathGrid=""};
            FollowOrderDeliveryNoteInvoice = RPSControlFactory.RPSCreateCollectionWithGrid<FollowOrderDeliveryNoteInvoiceCollectionEditor<FollowUpQueryView>,FollowUpQueryView>( params_FollowOrderDeliveryNoteInvoice,this);
 

        }
        public IRPSOption<FollowUpQueryView> UIOptSRQ { get; set; } 
        public IRPSComboBox<FollowUpQueryView> UISupplierRequestQuotation { get; set; } 
        public IRPSOption<FollowUpQueryView> UIOptOrder { get; set; } 
        public IRPSComboBox<FollowUpQueryView> UIOrder { get; set; } 
        public IRPSOption<FollowUpQueryView> UIOptDeliveryNote { get; set; } 
        public IRPSComboBox<FollowUpQueryView> UIDeliveryNote { get; set; } 
        public IRPSOption<FollowUpQueryView> UIOptInvoice { get; set; } 
        public IRPSComboBox<FollowUpQueryView> UIInvoice { get; set; } 
        public IRPSOption<FollowUpQueryView> FrameworkContract { get; set; } 
        public IRPSComboBox<FollowUpQueryView> IDFrameworkContract { get; set; } 
        public IRPSOption<FollowUpQueryView> UIOptProject { get; set; } 
        public IRPSComboBox<FollowUpQueryView> UIProject { get; set; } 
        public IRPSOption<FollowUpQueryView> manufacturingOrder { get; set; } 
        public IRPSComboBox<FollowUpQueryView> UIManufacturingOrder { get; set; } 
        public IRPSOption<FollowUpQueryView> salesOrder { get; set; } 
        public IRPSComboBox<FollowUpQueryView> UIOrderSL { get; set; } 
        public IRPSOption<FollowUpQueryView> articleStructure { get; set; } 
        public IRPSComboBox<FollowUpQueryView> UIArticleStructure { get; set; } 
        public IRPSOption<FollowUpQueryView> internalCode { get; set; } 
        public IRPSTextBox<FollowUpQueryView> UIInternalCode { get; set; } 
        public IRPSOption<FollowUpQueryView> orderNumberSupplier { get; set; } 
        public IRPSTextBox<FollowUpQueryView> UIOrderNumberSupplier { get; set; } 
        public IRPSOption<FollowUpQueryView> maintenanceOrder { get; set; } 
        public IRPSComboBox<FollowUpQueryView> UIIDMaintenanceOrder { get; set; } 
        public IRPSOption<FollowUpQueryView> maintenancecontract { get; set; } 
        public IRPSComboBox<FollowUpQueryView> IDMaintenanceContract { get; set; } 
        public IRPSOption<FollowUpQueryView> frameworkcontract { get; set; } 
        public IRPSComboBox<FollowUpQueryView> IDFrameworkContract1 { get; set; } 
        public IRPSTextBox<FollowUpQueryView> UIDateFrom { get; set; } 
        public IRPSTextBox<FollowUpQueryView> UIDateTo { get; set; } 
        public IRPSCollectionComboBox<FollowUpQueryView> UILstSupplier { get; set; } 
        public IRPSCollectionComboBox<FollowUpQueryView> IDSupplierGroup { get; set; } 
        public IRPSCollectionComboBox<FollowUpQueryView> IDProductLine { get; set; } 
        public IRPSCollectionComboBox<FollowUpQueryView> IDProductFamily { get; set; } 
        public IRPSCollectionComboBox<FollowUpQueryView> IDProductSubFamily { get; set; } 
        public IRPSCollectionComboBox<FollowUpQueryView> UILstArticle { get; set; } 
        public IRPSComboBox<FollowUpQueryView> UIRefSupplier { get; set; } 
        public IRPSComboBox<FollowUpQueryView> UISeries { get; set; } 
        public IRPSTextBox<FollowUpQueryView> Description { get; set; } 
        public IRPSTextBox<FollowUpQueryView> OrderDate { get; set; } 
        public IRPSTextBox<FollowUpQueryView> ReceptionDate { get; set; } 
        public IRPSTextBox<FollowUpQueryView> ReceptionDemandDate { get; set; } 
        public IRPSTextBox<FollowUpQueryView> OrderLineQuantitySecondUnit { get; set; } 
        public IRPSTextBox<FollowUpQueryView> OrderLineQuantityPendingReceive { get; set; } 
        public IRPSTextBox<FollowUpQueryView> OrderLineQuantityPendingInvoice { get; set; } 
        public IRPSTextBox<FollowUpQueryView> DeliveryNoteDate { get; set; } 
        public IRPSTextBox<FollowUpQueryView> DeliveryNoteLineQuantitySecondUnit { get; set; } 
        public IRPSTextBox<FollowUpQueryView> DeliveryNoteLineQuantityPending { get; set; } 
        public IRPSTextBox<FollowUpQueryView> DeliveryNoteSerie { get; set; } 
        public IRPSTextBox<FollowUpQueryView> InvoiceDate { get; set; } 
        public FollowOrderDeliveryNoteInvoiceCollectionEditor<FollowUpQueryView> FollowOrderDeliveryNoteInvoice { get; set; } 
        public FollowUp Screen { get; set; }
        public FollowUpQueryView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class FollowOrderDeliveryNoteInvoiceCollectionEditor<FollowUpQueryView>:RPSCollectionEditor<FollowUpQueryView> where FollowUpQueryView : class, IView
    {
        public  FollowOrderDeliveryNoteInvoiceGridView<FollowUpQueryView> GridView {get;set;}
    }
    public partial class FollowOrderDeliveryNoteInvoiceGridView <FollowUpQueryView> :  RPSGridView<FollowUpQueryView> where FollowUpQueryView : class, IView
    {
        public FollowOrderDeliveryNoteInvoiceGridView(FollowUpQueryView currentView)
        {
            this.WebDriver = currentView.WebDriver;          
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            Description = RPSControlFactory.CreateRPSGridTextBox<FollowUpQueryView>("","#cc5de5fc-399c-40f6-ae2a-815a2b331fc4 .ag-row[role='row']@ROWINDEX [col-id='cDescription']","",false, this.CurrentView);
 
            RefSupplier = RPSControlFactory.CreateRPSGridTextBox<FollowUpQueryView>("","#cc5de5fc-399c-40f6-ae2a-815a2b331fc4 .ag-row[role='row']@ROWINDEX [col-id='cRefSupplier']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<FollowUpQueryView> Description { get; set; } 
        public IRPSGridTextBox<FollowUpQueryView> RefSupplier { get; set; } 
                     
    }
 
    }
  
    

}