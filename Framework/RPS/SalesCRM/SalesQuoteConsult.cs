    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.SalesCRM.SalesQuoteConsult
{
    //RPS VERSION 1.0.0.0
    public partial class SalesQuoteConsult:Screen
    {
        public SalesQuoteConsult():base()
        {
            this.URL = "salescrm.salesquoteconsult";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            SalesQuoteConsultQueryView  = new SalesQuoteConsultQueryView(this); 
            SalesQuoteConsultQueryView.InitializeControls(); 
           
        }
      
            public SalesQuoteConsultQueryView SalesQuoteConsultQueryView {get; set; } 
    }
            
    public partial class SalesQuoteConsultQueryView : View
    {
        public SalesQuoteConsultQueryView(SalesQuoteConsult screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            SalesQuotesSelected = RPSControlFactory.CreateRPSCollectionComboBox<SalesQuoteConsultQueryView>("82b90f4d-8946-4b2f-8c23-bda3db0f888e","","",false, this);
 
            SalesQuoteStatusSL = RPSControlFactory.CreateRPSComboBox<SalesQuoteConsultQueryView>("a0506c59-343f-4ee8-bc3e-ee492d4d752e","","",false, this);
 
            SalesQuoteTypeSL = RPSControlFactory.CreateRPSComboBox<SalesQuoteConsultQueryView>("aef438e4-20aa-4a10-b622-4b130cc9b4d9","","",false, this);
 
            SalesQuoteDateFrom = RPSControlFactory.CreateRPSTextBox<SalesQuoteConsultQueryView>("f04ce786-26c3-4702-b42a-c4cd7c509f4d","","",false, this);
 
            SalesQuoteDateTo = RPSControlFactory.CreateRPSTextBox<SalesQuoteConsultQueryView>("6701bfb1-0407-4b44-bdd5-f636adbce45a","","",false, this);
 
            DiscardedOffersSelected = RPSControlFactory.CreateRPSCheckBox<SalesQuoteConsultQueryView>("b117456b-fed5-484f-b156-9be555400be3","","",false, this);
 
            ReceptionDateFrom = RPSControlFactory.CreateRPSTextBox<SalesQuoteConsultQueryView>("48ae7c37-266a-46d8-9728-c407255d30d9","","",false, this);
 
            ReceptionDateTo = RPSControlFactory.CreateRPSTextBox<SalesQuoteConsultQueryView>("5035f637-568d-4ac3-8f8b-99f47c25c33d","","",false, this);
 
            DiscardedGroupsSelected = RPSControlFactory.CreateRPSCheckBox<SalesQuoteConsultQueryView>("2d44c890-5552-4dbb-ba7b-693c1a6a418a","","",false, this);
 
            SalesQuoteCustomerList = RPSControlFactory.CreateRPSCollectionComboBox<SalesQuoteConsultQueryView>("7f236749-39b9-4545-a08c-69b4974629d8","","",false, this);
 
            SalesQuotePotentialCustomerList = RPSControlFactory.CreateRPSCollectionComboBox<SalesQuoteConsultQueryView>("4384b14c-69f9-4571-b906-ea39d21d1b4a","","",false, this);
 
            SelectedProductLines = RPSControlFactory.CreateRPSCollectionComboBox<SalesQuoteConsultQueryView>("1a550f62-4c39-41d7-85d3-85d470f4ff29","","",false, this);
 
            SelectedProductFamilies = RPSControlFactory.CreateRPSCollectionComboBox<SalesQuoteConsultQueryView>("4b826fba-cea3-4167-ae49-a76a0e7c2661","","",false, this);
 
            SelectedProductSubFamilies = RPSControlFactory.CreateRPSCollectionComboBox<SalesQuoteConsultQueryView>("a3884b3c-4d29-4726-9de3-9378086dc307","","",false, this);
 
            SelectedArticles = RPSControlFactory.CreateRPSCollectionComboBox<SalesQuoteConsultQueryView>("64222c0b-9ec2-4085-9e8e-790b8621369a","","",false, this);
 
            ReferenceCustomer = RPSControlFactory.CreateRPSEnumComboBox<SalesQuoteConsultQueryView>("dff66dfe-f7cb-4298-87e3-b1061947cf9b","","",false, this);
 
            OportunitySL = RPSControlFactory.CreateRPSComboBox<SalesQuoteConsultQueryView>("80d612a6-d738-42d1-891a-e47bc32ab6a5","","",false, this);
 
            OrderSL = RPSControlFactory.CreateRPSComboBox<SalesQuoteConsultQueryView>("a3a72375-f043-493e-90a0-f895910c8310","","",false, this);
 
            FrameworkContractSL = RPSControlFactory.CreateRPSComboBox<SalesQuoteConsultQueryView>("953d1ff2-ac96-42ef-9b9a-ad355d9f2092","","",false, this);
 
            SelectedQuotations = RPSControlFactory.CreateRPSCollectionComboBox<SalesQuoteConsultQueryView>("70e63ade-21ce-49c0-acf8-f3ea65296c3c","","",false, this);
 
            OnlySalesQuotesRelatedToQuotations = RPSControlFactory.CreateRPSCheckBox<SalesQuoteConsultQueryView>("577096cb-c8cb-40d5-be0e-86209ba0fbc7","","",false, this);
 
            PendingGeneratedArticle = RPSControlFactory.CreateRPSOption<SalesQuoteConsultQueryView>( "3533ba0c-e447-4f81-ab1d-7239191bd6d9","","",this);
 
            GeneratedArticle = RPSControlFactory.CreateRPSOption<SalesQuoteConsultQueryView>( "587b4bb8-7977-4d47-a0db-e041700c8ea1","","",this);
 
            AllArticleStatuses = RPSControlFactory.CreateRPSOption<SalesQuoteConsultQueryView>( "888a7ba7-4a94-4d2d-a71a-47125d524ddd","","",this);
 
            Pending = RPSControlFactory.CreateRPSCheckBox<SalesQuoteConsultQueryView>("6e37bc06-155b-4f30-947a-a612c1e080b2","","",false, this);
 
            EffectiveDate = RPSControlFactory.CreateRPSCheckBox<SalesQuoteConsultQueryView>("3858acdc-dfe7-4f11-8f80-f6def3e6d78c","","",false, this);
 
            Accepted = RPSControlFactory.CreateRPSCheckBox<SalesQuoteConsultQueryView>("240e977a-a3a2-47b2-8512-5513f1fe6020","","",false, this);
 
            WithoutOrder = RPSControlFactory.CreateRPSCheckBox<SalesQuoteConsultQueryView>("352a0211-1bcf-4c08-a46f-090a29841ddd","","",false, this);
 
            FrameworkContract = RPSControlFactory.CreateRPSCheckBox<SalesQuoteConsultQueryView>("f9222fed-38ad-45fc-8961-07b69967ffd8","","",false, this);
 
            TotalOrder = RPSControlFactory.CreateRPSCheckBox<SalesQuoteConsultQueryView>("44e04442-6aaf-4d65-b072-16a776cf3948","","",false, this);
 
            PartialOrder = RPSControlFactory.CreateRPSCheckBox<SalesQuoteConsultQueryView>("bd99350c-70be-4fd9-880b-9db64a02cb2b","","",false, this);
 
            Rejected = RPSControlFactory.CreateRPSCheckBox<SalesQuoteConsultQueryView>("f50bd20e-cca8-442f-96ac-b8f8f173cb4b","","",false, this);
 
            CollectionInit params_SalesQuoteConsultQuery = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="8d9c1282-6759-4eb8-955a-a861038ef413",CSSSelectorGrid="",XPathGrid=""};
            SalesQuoteConsultQuery = RPSControlFactory.RPSCreateCollectionWithGrid<SalesQuoteConsultQueryCollectionEditor<SalesQuoteConsultQueryView>,SalesQuoteConsultQueryView>( params_SalesQuoteConsultQuery,this);
 
            CollectionInit params_SalesQuoteLinesConsultQuery = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="2186363f-c2e9-436f-bd48-1ac6dabde76b",CSSSelectorGrid="",XPathGrid=""};
            SalesQuoteLinesConsultQuery = RPSControlFactory.RPSCreateCollectionWithGrid<SalesQuoteLinesConsultQueryCollectionEditor<SalesQuoteConsultQueryView>,SalesQuoteConsultQueryView>( params_SalesQuoteLinesConsultQuery,this);
 

        }
        public IRPSCollectionComboBox<SalesQuoteConsultQueryView> SalesQuotesSelected { get; set; } 
        public IRPSComboBox<SalesQuoteConsultQueryView> SalesQuoteStatusSL { get; set; } 
        public IRPSComboBox<SalesQuoteConsultQueryView> SalesQuoteTypeSL { get; set; } 
        public IRPSTextBox<SalesQuoteConsultQueryView> SalesQuoteDateFrom { get; set; } 
        public IRPSTextBox<SalesQuoteConsultQueryView> SalesQuoteDateTo { get; set; } 
        public IRPSCheckbox<SalesQuoteConsultQueryView> DiscardedOffersSelected { get; set; } 
        public IRPSTextBox<SalesQuoteConsultQueryView> ReceptionDateFrom { get; set; } 
        public IRPSTextBox<SalesQuoteConsultQueryView> ReceptionDateTo { get; set; } 
        public IRPSCheckbox<SalesQuoteConsultQueryView> DiscardedGroupsSelected { get; set; } 
        public IRPSCollectionComboBox<SalesQuoteConsultQueryView> SalesQuoteCustomerList { get; set; } 
        public IRPSCollectionComboBox<SalesQuoteConsultQueryView> SalesQuotePotentialCustomerList { get; set; } 
        public IRPSCollectionComboBox<SalesQuoteConsultQueryView> SelectedProductLines { get; set; } 
        public IRPSCollectionComboBox<SalesQuoteConsultQueryView> SelectedProductFamilies { get; set; } 
        public IRPSCollectionComboBox<SalesQuoteConsultQueryView> SelectedProductSubFamilies { get; set; } 
        public IRPSCollectionComboBox<SalesQuoteConsultQueryView> SelectedArticles { get; set; } 
        public IRPSComboBox<SalesQuoteConsultQueryView> ReferenceCustomer { get; set; } 
        public IRPSComboBox<SalesQuoteConsultQueryView> OportunitySL { get; set; } 
        public IRPSComboBox<SalesQuoteConsultQueryView> OrderSL { get; set; } 
        public IRPSComboBox<SalesQuoteConsultQueryView> FrameworkContractSL { get; set; } 
        public IRPSCollectionComboBox<SalesQuoteConsultQueryView> SelectedQuotations { get; set; } 
        public IRPSCheckbox<SalesQuoteConsultQueryView> OnlySalesQuotesRelatedToQuotations { get; set; } 
        public IRPSOption<SalesQuoteConsultQueryView> PendingGeneratedArticle { get; set; } 
        public IRPSOption<SalesQuoteConsultQueryView> GeneratedArticle { get; set; } 
        public IRPSOption<SalesQuoteConsultQueryView> AllArticleStatuses { get; set; } 
        public IRPSCheckbox<SalesQuoteConsultQueryView> Pending { get; set; } 
        public IRPSCheckbox<SalesQuoteConsultQueryView> EffectiveDate { get; set; } 
        public IRPSCheckbox<SalesQuoteConsultQueryView> Accepted { get; set; } 
        public IRPSCheckbox<SalesQuoteConsultQueryView> WithoutOrder { get; set; } 
        public IRPSCheckbox<SalesQuoteConsultQueryView> FrameworkContract { get; set; } 
        public IRPSCheckbox<SalesQuoteConsultQueryView> TotalOrder { get; set; } 
        public IRPSCheckbox<SalesQuoteConsultQueryView> PartialOrder { get; set; } 
        public IRPSCheckbox<SalesQuoteConsultQueryView> Rejected { get; set; } 
        public SalesQuoteConsultQueryCollectionEditor<SalesQuoteConsultQueryView> SalesQuoteConsultQuery { get; set; } 
        public SalesQuoteLinesConsultQueryCollectionEditor<SalesQuoteConsultQueryView> SalesQuoteLinesConsultQuery { get; set; } 
        public SalesQuoteConsult Screen { get; set; }
        public SalesQuoteConsultQueryView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class SalesQuoteConsultQueryCollectionEditor<SalesQuoteConsultQueryView>:RPSCollectionEditor<SalesQuoteConsultQueryView> where SalesQuoteConsultQueryView : class, IView
    {
        public  SalesQuoteConsultQueryGridView<SalesQuoteConsultQueryView> GridView {get;set;}
    }
    public partial class SalesQuoteConsultQueryGridView <SalesQuoteConsultQueryView> :  RPSGridView<SalesQuoteConsultQueryView> where SalesQuoteConsultQueryView : class, IView
    {
        public SalesQuoteConsultQueryGridView(SalesQuoteConsultQueryView currentView)
        {
            this.WebDriver = currentView.WebDriver;          
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            SalesQuoteSL_SalesQuoteDate = RPSControlFactory.CreateRPSGridTextBox<SalesQuoteConsultQueryView>("","#8d9c1282-6759-4eb8-955a-a861038ef413 .ag-row[role='row']@ROWINDEX [col-id='cSalesQuoteSL_SalesQuoteDate']","",false, this.CurrentView);
 
            SalesQuoteSL_ReceptionDate = RPSControlFactory.CreateRPSGridTextBox<SalesQuoteConsultQueryView>("","#8d9c1282-6759-4eb8-955a-a861038ef413 .ag-row[role='row']@ROWINDEX [col-id='cSalesQuoteSL_ReceptionDate']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<SalesQuoteConsultQueryView> SalesQuoteSL_SalesQuoteDate { get; set; } 
        public IRPSGridTextBox<SalesQuoteConsultQueryView> SalesQuoteSL_ReceptionDate { get; set; } 
                     
    }
 
        public partial class SalesQuoteLinesConsultQueryCollectionEditor<SalesQuoteConsultQueryView>:RPSCollectionEditor<SalesQuoteConsultQueryView> where SalesQuoteConsultQueryView : class, IView
    {
        public  SalesQuoteLinesConsultQueryGridView<SalesQuoteConsultQueryView> GridView {get;set;}
    }
    public partial class SalesQuoteLinesConsultQueryGridView <SalesQuoteConsultQueryView> :  RPSGridView<SalesQuoteConsultQueryView> where SalesQuoteConsultQueryView : class, IView
    {
        public SalesQuoteLinesConsultQueryGridView(SalesQuoteConsultQueryView currentView)
        {
            this.WebDriver = currentView.WebDriver;          
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            SalesQuoteLineSL_Description = RPSControlFactory.CreateRPSGridTextBox<SalesQuoteConsultQueryView>("","#2186363f-c2e9-436f-bd48-1ac6dabde76b .ag-row[role='row']@ROWINDEX [col-id='cSalesQuoteLineSL_Description']","",false, this.CurrentView);
 
            SalesQuoteLineSL_ReferenceCustomer = RPSControlFactory.CreateRPSGridTextBox<SalesQuoteConsultQueryView>("","#2186363f-c2e9-436f-bd48-1ac6dabde76b .ag-row[role='row']@ROWINDEX [col-id='cSalesQuoteLineSL_ReferenceCustomer']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<SalesQuoteConsultQueryView> SalesQuoteLineSL_Description { get; set; } 
        public IRPSGridTextBox<SalesQuoteConsultQueryView> SalesQuoteLineSL_ReferenceCustomer { get; set; } 
                     
    }
 
    }
  
    

}