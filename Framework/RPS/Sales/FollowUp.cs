    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.Sales.FollowUp
{
    //RPS VERSION 1.0.0.0
    public partial class FollowUp:Screen
    {
        public FollowUp():base()
        {
            this.URL = "sales.followup";
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
            UIOptSalesQuote = RPSControlFactory.CreateRPSOption<FollowUpQueryView>( "13dd5c84-064b-45ce-af7e-0c8067bc3855","","",this);
 
            UISalesQuoteSL = RPSControlFactory.CreateRPSComboBox<FollowUpQueryView>("e2039763-6638-484b-bda9-6c139eb7c7a5","","",false, this);
 
            UIOptOrder = RPSControlFactory.CreateRPSOption<FollowUpQueryView>( "278e4f79-7517-4550-9220-6fe36af551ea","","",this);
 
            UIOrderSL = RPSControlFactory.CreateRPSComboBox<FollowUpQueryView>("28d4e19e-f22f-4439-96b1-57adac4d0a34","","",false, this);
 
            UIOptDeliveryNote = RPSControlFactory.CreateRPSOption<FollowUpQueryView>( "ba431fb9-6450-4b04-b803-72a4820dc3e5","","",this);
 
            UIDeliveryNoteSL = RPSControlFactory.CreateRPSComboBox<FollowUpQueryView>("766dccb3-454a-4ea4-9132-aa14c9d41a71","","",false, this);
 
            UIOptInvoice = RPSControlFactory.CreateRPSOption<FollowUpQueryView>( "bc4b718f-8705-4c80-a9c4-66445d14171f","","",this);
 
            UIInvoiceSL = RPSControlFactory.CreateRPSComboBox<FollowUpQueryView>("848eb8f8-e856-44a1-802b-1032ef5de708","","",false, this);
 
            FrameworkContract = RPSControlFactory.CreateRPSOption<FollowUpQueryView>( "27e4e584-5fd0-45de-b4f6-864bbea02a55","","",this);
 
            IDFrameworkContractSL = RPSControlFactory.CreateRPSComboBox<FollowUpQueryView>("d22e35e7-e4c2-4205-bbc4-e7d1166cc2cb","","",false, this);
 
            UIOptProject = RPSControlFactory.CreateRPSOption<FollowUpQueryView>( "deeb6d7a-ce95-4bb0-985e-a7313aa42809","","",this);
 
            UIProject = RPSControlFactory.CreateRPSComboBox<FollowUpQueryView>("eb4e6280-48f6-4645-9132-b323653d69d0","","",false, this);
 
            UIOptManufacturingOrder = RPSControlFactory.CreateRPSOption<FollowUpQueryView>( "ec1ebb9c-96f9-46bb-93b6-7d56087a356a","","",this);
 
            UIManufacturingOrder = RPSControlFactory.CreateRPSComboBox<FollowUpQueryView>("6eb9046f-eccd-4c17-b1a2-8e4462bf4f30","","",false, this);
 
            UIOptInternalCode = RPSControlFactory.CreateRPSOption<FollowUpQueryView>( "4f3a6473-0f13-4409-82ac-d598a807b8bb","","",this);
 
            InternalCode = RPSControlFactory.CreateRPSTextBox<FollowUpQueryView>("9ebcd83f-43cb-4fcd-ac08-3f38aa4bda71","","",false, this);
 
            UIOptMaintenanceOrder = RPSControlFactory.CreateRPSOption<FollowUpQueryView>( "6f888519-0b1f-4461-8df6-5d4a56f6f0fb","","",this);
 
            UIMaintenanceOrder = RPSControlFactory.CreateRPSComboBox<FollowUpQueryView>("5e5517d4-f849-4db1-945f-65c8d120d299","","",false, this);
 
            maintenancecontract = RPSControlFactory.CreateRPSOption<FollowUpQueryView>( "60f3de7f-4d14-4cd1-b453-8dfcb3c17ed8","","",this);
 
            IDMaintenanceContract = RPSControlFactory.CreateRPSComboBox<FollowUpQueryView>("222818b9-5187-4420-8446-4945f2f37773","","",false, this);
 
            ordernumbercustomer = RPSControlFactory.CreateRPSOption<FollowUpQueryView>( "37b554c1-cdad-4f71-942f-4f862cbfceeb","","",this);
 
            OrderNumberCustomer = RPSControlFactory.CreateRPSTextBox<FollowUpQueryView>("af602ff3-1a23-4e48-9d1d-a87ae9e8658e","","",false, this);
 
            frameworkcontract = RPSControlFactory.CreateRPSOption<FollowUpQueryView>( "fe6c1558-de4b-4888-bccd-bf09974eb981","","",this);
 
            IDFrameworkContractSL1 = RPSControlFactory.CreateRPSComboBox<FollowUpQueryView>("7ad1f396-bd66-4df7-8413-33ee8ceadfc0","","",false, this);
 
            UIDateFrom = RPSControlFactory.CreateRPSTextBox<FollowUpQueryView>("461c4c8a-7523-429b-a6ef-7dd33517133b","","",false, this);
 
            UIDateTo = RPSControlFactory.CreateRPSTextBox<FollowUpQueryView>("ba08a1cb-70bd-4b3e-876c-9c939ede9c45","","",false, this);
 
            UILstCustomer = RPSControlFactory.CreateRPSCollectionComboBox<FollowUpQueryView>("7a2bcb9c-4c6d-4d00-a1f1-6e457371b902","","",false, this);
 
            SelectedProductLines = RPSControlFactory.CreateRPSCollectionComboBox<FollowUpQueryView>("a2441961-1f95-44ca-a9ef-67e88e8ba034","","",false, this);
 
            SelectedProductFamilies = RPSControlFactory.CreateRPSCollectionComboBox<FollowUpQueryView>("ed3e95d8-cb37-4e69-a7c6-776d70a2538b","","",false, this);
 
            SelectedProductSubFamilies = RPSControlFactory.CreateRPSCollectionComboBox<FollowUpQueryView>("fbf1275e-3c53-47bb-83d9-9cc41407fd9c","","",false, this);
 
            UILstArticle = RPSControlFactory.CreateRPSCollectionComboBox<FollowUpQueryView>("b5811816-bab8-4844-b6e4-a4c0f3b283fb","","",false, this);
 
            CustomerReference = RPSControlFactory.CreateRPSEnumComboBox<FollowUpQueryView>("6017263b-4848-409b-a654-9760fc3b4718","","",false, this);
 
            UISeries = RPSControlFactory.CreateRPSEnumComboBox<FollowUpQueryView>("81694373-18ed-4a25-af60-651fafffb2da","","",false, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<FollowUpQueryView>("edfdb636-b18b-4e85-a849-ce1e8a5a5a11","","",false, this);
 
            ReferenceCustomer = RPSControlFactory.CreateRPSTextBox<FollowUpQueryView>("8106bf11-f87d-4a67-b9cf-570d19c63e6a","","",false, this);
 
            SalesQuoteVersion = RPSControlFactory.CreateRPSTextBox<FollowUpQueryView>("37afce4c-b02b-44df-9012-e0e29c0e1695","","",false, this);
 
            SalesQuoteDate = RPSControlFactory.CreateRPSTextBox<FollowUpQueryView>("fc217467-2d3d-47e8-807e-b5133fd85931","","",false, this);
 
            SalesQuoteLineQuantitySecondUnit = RPSControlFactory.CreateRPSFormattedTextBox<FollowUpQueryView>("adfd93fb-dfae-4260-a1c6-bb083e367055","","",false, this);
 
            OrderNumberCustomer1 = RPSControlFactory.CreateRPSTextBox<FollowUpQueryView>("1bea614e-9274-4fd8-867c-3e6955744547","","",false, this);
 
            OrderDate = RPSControlFactory.CreateRPSTextBox<FollowUpQueryView>("08e240c5-a49e-46f9-bfd0-eafd76da5ec4","","",false, this);
 
            ReceptionDate = RPSControlFactory.CreateRPSTextBox<FollowUpQueryView>("f14f7c02-6a5a-402a-bd95-be8ff45ff718","","",false, this);
 
            ReceptionDemandDate = RPSControlFactory.CreateRPSTextBox<FollowUpQueryView>("48f48d01-2d10-4928-ae33-da40bf6921be","","",false, this);
 
            OrderLineQuantitySecondUnit = RPSControlFactory.CreateRPSFormattedTextBox<FollowUpQueryView>("0d39c777-def7-49ee-a314-cc79dc9b38f2","","",false, this);
 
            OrderLineQuantityPendingDelivery = RPSControlFactory.CreateRPSFormattedTextBox<FollowUpQueryView>("b867854b-07c6-428a-acf6-88fa0485f4cf","","",false, this);
 
            OrderLineQuantityPendingInvoice = RPSControlFactory.CreateRPSFormattedTextBox<FollowUpQueryView>("aab996fe-8a58-4203-9d9c-03e8c7131625","","",false, this);
 
            DeliveryNoteDate = RPSControlFactory.CreateRPSTextBox<FollowUpQueryView>("d78d4399-808f-4967-bb01-8913a04112fb","","",false, this);
 
            DeliveryNoteLineQuantitySecondUnit = RPSControlFactory.CreateRPSFormattedTextBox<FollowUpQueryView>("9e2bb76a-0519-4b25-907b-bca69874a0f4","","",false, this);
 
            DeliveryNoteLineQuantityPending = RPSControlFactory.CreateRPSFormattedTextBox<FollowUpQueryView>("485dcb07-6726-4e6e-b216-b748c2d040b2","","",false, this);
 
            DeliveryNoteSeries = RPSControlFactory.CreateRPSTextBox<FollowUpQueryView>("39a91e01-ba3a-4e19-bedf-b1e9f40e6f10","","",false, this);
 
            InvoiceDate = RPSControlFactory.CreateRPSTextBox<FollowUpQueryView>("804e3e54-7b52-4ee1-9c9c-969676cadfcf","","",false, this);
 
            PurchaseOrder = RPSControlFactory.CreateRPSTextBox<FollowUpQueryView>("636f395c-966d-4c1c-8c38-86f4d2aaa548","","",false, this);
 
            CollectionInit params_FollowOrderDeliveryNoteInvoice = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="b28e58e9-fa8e-4794-a8d5-fa2d70f07989",CSSSelectorGrid="",XPathGrid=""};
            FollowOrderDeliveryNoteInvoice = RPSControlFactory.RPSCreateCollectionWithGrid<FollowOrderDeliveryNoteInvoiceCollectionEditor<FollowUpQueryView>,FollowUpQueryView>( params_FollowOrderDeliveryNoteInvoice,this);
 

        }
        public IRPSOption<FollowUpQueryView> UIOptSalesQuote { get; set; } 
        public IRPSComboBox<FollowUpQueryView> UISalesQuoteSL { get; set; } 
        public IRPSOption<FollowUpQueryView> UIOptOrder { get; set; } 
        public IRPSComboBox<FollowUpQueryView> UIOrderSL { get; set; } 
        public IRPSOption<FollowUpQueryView> UIOptDeliveryNote { get; set; } 
        public IRPSComboBox<FollowUpQueryView> UIDeliveryNoteSL { get; set; } 
        public IRPSOption<FollowUpQueryView> UIOptInvoice { get; set; } 
        public IRPSComboBox<FollowUpQueryView> UIInvoiceSL { get; set; } 
        public IRPSOption<FollowUpQueryView> FrameworkContract { get; set; } 
        public IRPSComboBox<FollowUpQueryView> IDFrameworkContractSL { get; set; } 
        public IRPSOption<FollowUpQueryView> UIOptProject { get; set; } 
        public IRPSComboBox<FollowUpQueryView> UIProject { get; set; } 
        public IRPSOption<FollowUpQueryView> UIOptManufacturingOrder { get; set; } 
        public IRPSComboBox<FollowUpQueryView> UIManufacturingOrder { get; set; } 
        public IRPSOption<FollowUpQueryView> UIOptInternalCode { get; set; } 
        public IRPSTextBox<FollowUpQueryView> InternalCode { get; set; } 
        public IRPSOption<FollowUpQueryView> UIOptMaintenanceOrder { get; set; } 
        public IRPSComboBox<FollowUpQueryView> UIMaintenanceOrder { get; set; } 
        public IRPSOption<FollowUpQueryView> maintenancecontract { get; set; } 
        public IRPSComboBox<FollowUpQueryView> IDMaintenanceContract { get; set; } 
        public IRPSOption<FollowUpQueryView> ordernumbercustomer { get; set; } 
        public IRPSTextBox<FollowUpQueryView> OrderNumberCustomer { get; set; } 
        public IRPSOption<FollowUpQueryView> frameworkcontract { get; set; } 
        public IRPSComboBox<FollowUpQueryView> IDFrameworkContractSL1 { get; set; } 
        public IRPSTextBox<FollowUpQueryView> UIDateFrom { get; set; } 
        public IRPSTextBox<FollowUpQueryView> UIDateTo { get; set; } 
        public IRPSCollectionComboBox<FollowUpQueryView> UILstCustomer { get; set; } 
        public IRPSCollectionComboBox<FollowUpQueryView> SelectedProductLines { get; set; } 
        public IRPSCollectionComboBox<FollowUpQueryView> SelectedProductFamilies { get; set; } 
        public IRPSCollectionComboBox<FollowUpQueryView> SelectedProductSubFamilies { get; set; } 
        public IRPSCollectionComboBox<FollowUpQueryView> UILstArticle { get; set; } 
        public IRPSComboBox<FollowUpQueryView> CustomerReference { get; set; } 
        public IRPSComboBox<FollowUpQueryView> UISeries { get; set; } 
        public IRPSTextBox<FollowUpQueryView> Description { get; set; } 
        public IRPSTextBox<FollowUpQueryView> ReferenceCustomer { get; set; } 
        public IRPSTextBox<FollowUpQueryView> SalesQuoteVersion { get; set; } 
        public IRPSTextBox<FollowUpQueryView> SalesQuoteDate { get; set; } 
        public IRPSTextBox<FollowUpQueryView> SalesQuoteLineQuantitySecondUnit { get; set; } 
        public IRPSTextBox<FollowUpQueryView> OrderNumberCustomer1 { get; set; } 
        public IRPSTextBox<FollowUpQueryView> OrderDate { get; set; } 
        public IRPSTextBox<FollowUpQueryView> ReceptionDate { get; set; } 
        public IRPSTextBox<FollowUpQueryView> ReceptionDemandDate { get; set; } 
        public IRPSTextBox<FollowUpQueryView> OrderLineQuantitySecondUnit { get; set; } 
        public IRPSTextBox<FollowUpQueryView> OrderLineQuantityPendingDelivery { get; set; } 
        public IRPSTextBox<FollowUpQueryView> OrderLineQuantityPendingInvoice { get; set; } 
        public IRPSTextBox<FollowUpQueryView> DeliveryNoteDate { get; set; } 
        public IRPSTextBox<FollowUpQueryView> DeliveryNoteLineQuantitySecondUnit { get; set; } 
        public IRPSTextBox<FollowUpQueryView> DeliveryNoteLineQuantityPending { get; set; } 
        public IRPSTextBox<FollowUpQueryView> DeliveryNoteSeries { get; set; } 
        public IRPSTextBox<FollowUpQueryView> InvoiceDate { get; set; } 
        public IRPSTextBox<FollowUpQueryView> PurchaseOrder { get; set; } 
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
            Description = RPSControlFactory.CreateRPSGridTextBox<FollowUpQueryView>("","#b28e58e9-fa8e-4794-a8d5-fa2d70f07989 .ag-row[role='row']@ROWINDEX [col-id='cDescription']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<FollowUpQueryView> Description { get; set; } 
                     
    }
 
    }
  
    

}