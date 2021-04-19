    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.SalesCRM.ParameterFacSL
{
    //RPS VERSION 1.0.0.0
    public partial class ParameterFacSL:Screen
    {
        public ParameterFacSL():base()
        {
            this.URL = "salescrm.parameterfacsl";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            ParameterFacSLEntityView  = new ParameterFacSLEntityView(this); 
            ParameterFacSLEntityView.InitializeControls(); 
           
        }
      
            public ParameterFacSLEntityView ParameterFacSLEntityView {get; set; } 
    }
            
    public partial class ParameterFacSLEntityView : View
    {
        public ParameterFacSLEntityView(ParameterFacSL screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            IDCodingSerieOportunity = RPSControlFactory.CreateRPSComboBox<ParameterFacSLEntityView>("25deae51-a14f-4a04-ab0a-5fe3870477fa","","",false, this);
 
            IDCodingSerieActivity = RPSControlFactory.CreateRPSComboBox<ParameterFacSLEntityView>("ad8760ee-aa8c-4bf5-9930-e9da0e37fbfe","","",false, this);
 
            IDCodingSeriePotentialCustomer = RPSControlFactory.CreateRPSComboBox<ParameterFacSLEntityView>("be994acf-79ef-4fe8-92c2-7f76d9ccb5e5","","",false, this);
 
            IDCodingSerieQuotation = RPSControlFactory.CreateRPSComboBox<ParameterFacSLEntityView>("2bd1d831-143b-4ee3-90a7-bf47da74d7b4","","",false, this);
 
            IDLeadSource = RPSControlFactory.CreateRPSComboBox<ParameterFacSLEntityView>("06702cad-cae5-4711-90dd-d82dcfb23d8b","","",false, this);
 
            IDSalesMethod = RPSControlFactory.CreateRPSComboBox<ParameterFacSLEntityView>("e710bcbf-7861-4a94-af43-886ebee7486f","","",false, this);
 
            KMPrice = RPSControlFactory.CreateRPSFormattedTextBox<ParameterFacSLEntityView>("9a0df9cd-f6f6-41ff-a2bf-8db7fb9faba6","","",true, this);
 
            ActivityRealTime = RPSControlFactory.CreateRPSCheckBox<ParameterFacSLEntityView>("012c0605-e3a7-43ff-bed7-a79d59b07f95","","",true, this);
 
            IDSalesQuoteStatusInitial = RPSControlFactory.CreateRPSComboBox<ParameterFacSLEntityView>("bab52bfc-e551-4216-85d8-9982ca2c63c6","","",true, this);
 
            IDSalesQuoteStatusRejected = RPSControlFactory.CreateRPSComboBox<ParameterFacSLEntityView>("9b736423-12ab-4654-ab87-6d9f010dacc4","","",true, this);
 
            IDSalesQuoteType = RPSControlFactory.CreateRPSComboBox<ParameterFacSLEntityView>("3d1b9e91-0728-4492-8f33-e109d8316e41","","",false, this);
 
            IDSalesQuoteTemplate = RPSControlFactory.CreateRPSComboBox<ParameterFacSLEntityView>("5a6e723b-3bae-4fab-9097-fd775509ee41","","",false, this);
 
            SalesQuoteEffectiveDays = RPSControlFactory.CreateRPSFormattedTextBox<ParameterFacSLEntityView>("7f3788db-01d0-41ba-9578-e7b1de61f57c","","",true, this);
 
            IDArticleSQuoteOption = RPSControlFactory.CreateRPSComboBox<ParameterFacSLEntityView>("6349722e-a29b-4d1f-a38e-5c0d47a465b3","","",false, this);
 
            IDArticleSQuoteHeader = RPSControlFactory.CreateRPSComboBox<ParameterFacSLEntityView>("54c37ffc-f2b6-4fe7-ba70-441385c3ab67","","",false, this);
 
            IDDocumentCategorySalesQuote = RPSControlFactory.CreateRPSComboBox<ParameterFacSLEntityView>("15fa740d-1d0b-4ec3-b912-f7561e9ec032","","",false, this);
 
            ZippedDocuments = RPSControlFactory.CreateRPSCheckBox<ParameterFacSLEntityView>("95c06445-10f2-46e0-a07b-3eb96b8bfd3c","","",true, this);
 
            IDSupplierQuotation = RPSControlFactory.CreateRPSComboBox<ParameterFacSLEntityView>("69bf193b-6f37-49a7-8496-8b19c3c9aa24","","",false, this);
 
            CollectionInit params_ParameterFacQuotationSLs = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="3fc62663-5ee4-4dd3-b484-2464d37d90c3",CSSSelectorGrid="",XPathGrid=""};
            ParameterFacQuotationSLs = RPSControlFactory.RPSCreateCollectionWithGrid<ParameterFacQuotationSLsCollectionEditor<ParameterFacSLEntityView>,ParameterFacSLEntityView>( params_ParameterFacQuotationSLs,this);
 
            GeneralDataSection = RPSControlFactory.CreateRPSSection<ParameterFacSLEntityView>( "","ul li[rpsid='8d7c9819-dc5d-453d-954c-0c4c08844171']","",this);
 
            QuotationsSection = RPSControlFactory.CreateRPSSection<ParameterFacSLEntityView>( "","ul li[rpsid='be76cb36-9179-4674-9b2e-5ebd2b37831c']","",this);
 

        }
        public IRPSComboBox<ParameterFacSLEntityView> IDCodingSerieOportunity { get; set; } 
        public IRPSComboBox<ParameterFacSLEntityView> IDCodingSerieActivity { get; set; } 
        public IRPSComboBox<ParameterFacSLEntityView> IDCodingSeriePotentialCustomer { get; set; } 
        public IRPSComboBox<ParameterFacSLEntityView> IDCodingSerieQuotation { get; set; } 
        public IRPSComboBox<ParameterFacSLEntityView> IDLeadSource { get; set; } 
        public IRPSComboBox<ParameterFacSLEntityView> IDSalesMethod { get; set; } 
        public IRPSTextBox<ParameterFacSLEntityView> KMPrice { get; set; } 
        public IRPSCheckbox<ParameterFacSLEntityView> ActivityRealTime { get; set; } 
        public IRPSComboBox<ParameterFacSLEntityView> IDSalesQuoteStatusInitial { get; set; } 
        public IRPSComboBox<ParameterFacSLEntityView> IDSalesQuoteStatusRejected { get; set; } 
        public IRPSComboBox<ParameterFacSLEntityView> IDSalesQuoteType { get; set; } 
        public IRPSComboBox<ParameterFacSLEntityView> IDSalesQuoteTemplate { get; set; } 
        public IRPSTextBox<ParameterFacSLEntityView> SalesQuoteEffectiveDays { get; set; } 
        public IRPSComboBox<ParameterFacSLEntityView> IDArticleSQuoteOption { get; set; } 
        public IRPSComboBox<ParameterFacSLEntityView> IDArticleSQuoteHeader { get; set; } 
        public IRPSComboBox<ParameterFacSLEntityView> IDDocumentCategorySalesQuote { get; set; } 
        public IRPSCheckbox<ParameterFacSLEntityView> ZippedDocuments { get; set; } 
        public IRPSComboBox<ParameterFacSLEntityView> IDSupplierQuotation { get; set; } 
        public ParameterFacQuotationSLsCollectionEditor<ParameterFacSLEntityView> ParameterFacQuotationSLs { get; set; } 
        public IRPSSection<ParameterFacSLEntityView> GeneralDataSection { get; set; } 
        public IRPSSection<ParameterFacSLEntityView> QuotationsSection { get; set; } 
        public ParameterFacSL Screen { get; set; }
        public ParameterFacSLEntityView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class ParameterFacQuotationSLsCollectionEditor<ParameterFacSLEntityView>:RPSCollectionEditor<ParameterFacSLEntityView> where ParameterFacSLEntityView : class, IView
    {
        public  ParameterFacQuotationSLsGridView<ParameterFacSLEntityView> GridView {get;set;}
    }
    public partial class ParameterFacQuotationSLsGridView <ParameterFacSLEntityView> :  RPSGridView<ParameterFacSLEntityView> where ParameterFacSLEntityView : class, IView
    {
        public ParameterFacQuotationSLsGridView(ParameterFacSLEntityView currentView)
        {
            this.WebDriver = currentView.WebDriver;          
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            Quantity = RPSControlFactory.CreateRPSGridFormattedTextBox<ParameterFacSLEntityView>("","#3fc62663-5ee4-4dd3-b484-2464d37d90c3 .ag-row[role='row']@ROWINDEX [col-id='cQuantity']","",true, this.CurrentView);
 
            Default = RPSControlFactory.CreateRPSGridCheckBox<ParameterFacSLEntityView>("","#3fc62663-5ee4-4dd3-b484-2464d37d90c3 .ag-row[role='row']@ROWINDEX [col-id='cDefault']","",true, this.CurrentView);
 

        }
        public IRPSGridTextBox<ParameterFacSLEntityView> Quantity { get; set; } 
        public IRPSGridCheckbox<ParameterFacSLEntityView> Default { get; set; } 
                     
    }
 
    }
  
    

}