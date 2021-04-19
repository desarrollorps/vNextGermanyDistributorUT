    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.SalesCRM.QuotationSLConsult
{
    //RPS VERSION 1.0.0.0
    public partial class QuotationSLConsult:Screen
    {
        public QuotationSLConsult():base()
        {
            this.URL = "salescrm.quotationslconsult";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            QuotationSLConsultQueryView  = new QuotationSLConsultQueryView(this); 
            QuotationSLConsultQueryView.InitializeControls(); 
           
        }
      
            public QuotationSLConsultQueryView QuotationSLConsultQueryView {get; set; } 
    }
            
    public partial class QuotationSLConsultQueryView : View
    {
        public QuotationSLConsultQueryView(QuotationSLConsult screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            QuotationSL = RPSControlFactory.CreateRPSCollectionComboBox<QuotationSLConsultQueryView>("e275d30c-6870-4218-a8b6-7aed8712bc7f","","",false, this);
 
            IDSalesQuoteFilter = RPSControlFactory.CreateRPSCollectionComboBox<QuotationSLConsultQueryView>("1c3ea828-7a32-41b1-8fc5-0ded97d77640","","",false, this);
 
            IDOportunitySL = RPSControlFactory.CreateRPSCollectionComboBox<QuotationSLConsultQueryView>("d0e5dec6-0a82-4f10-977d-c9c2c353f5c6","","",false, this);
 
            QuotationDateFromFilter = RPSControlFactory.CreateRPSTextBox<QuotationSLConsultQueryView>("96feaeff-0b9b-4cf2-90f4-b6506055ff56","","",false, this);
 
            QuotationDateToFilter = RPSControlFactory.CreateRPSTextBox<QuotationSLConsultQueryView>("42c68e70-50c2-4559-94a9-ff7b8a404224","","",false, this);
 
            All = RPSControlFactory.CreateRPSOption<QuotationSLConsultQueryView>( "6ab69c92-f0e0-4c34-8a18-048707417018","","",this);
 
            Generated = RPSControlFactory.CreateRPSOption<QuotationSLConsultQueryView>( "50c473aa-aea9-4676-8cba-a1b8f4b9fc70","","",this);
 
            NonGenerated = RPSControlFactory.CreateRPSOption<QuotationSLConsultQueryView>( "a3435004-9ddc-4586-ad86-52f7a10f31da","","",this);
 
            All1 = RPSControlFactory.CreateRPSOption<QuotationSLConsultQueryView>( "f2b5c125-ee44-4834-8190-c5c2f4e37e87","","",this);
 
            Generated1 = RPSControlFactory.CreateRPSOption<QuotationSLConsultQueryView>( "6b9f9c0f-df4c-4983-beab-02536b67b007","","",this);
 
            NonGenerated1 = RPSControlFactory.CreateRPSOption<QuotationSLConsultQueryView>( "162760f6-df1e-40bf-b5ca-aabca542da68","","",this);
 
            QuotationCustomerList = RPSControlFactory.CreateRPSCollectionComboBox<QuotationSLConsultQueryView>("22113ce9-f7ef-4f8c-8195-28b6c85375b8","","",false, this);
 
            QuotationPotentialCustomerSLList = RPSControlFactory.CreateRPSCollectionComboBox<QuotationSLConsultQueryView>("53ab2a54-a9f7-42c4-bcca-7041e70df2e3","","",false, this);
 
            IDProductLinesFilter = RPSControlFactory.CreateRPSCollectionComboBox<QuotationSLConsultQueryView>("64a6ba3a-fe4a-44c2-ab4a-d6d5f2889abc","","",false, this);
 
            IDProductFamiliesFilter = RPSControlFactory.CreateRPSCollectionComboBox<QuotationSLConsultQueryView>("68c93e93-9aaa-4b89-adc2-d150a49e042f","","",false, this);
 
            IDProductSubFamiliesFilter = RPSControlFactory.CreateRPSCollectionComboBox<QuotationSLConsultQueryView>("a08fb489-cabb-4ca7-9e85-eff67b3d508e","","",false, this);
 
            IDQuotationArticleFilter = RPSControlFactory.CreateRPSCollectionComboBox<QuotationSLConsultQueryView>("1f31800f-17ff-4249-94de-29ce2819a8ae","","",false, this);
 
            IDQuotationAssembly = RPSControlFactory.CreateRPSComboBox<QuotationSLConsultQueryView>("fcf45017-7c7f-4147-ac24-f43172e1266d","","",false, this);
 
            QuotationSLDate = RPSControlFactory.CreateRPSTextBox<QuotationSLConsultQueryView>("7523e2e9-74d4-4ee2-9e92-48f94acc5dc0","","",false, this);
 
            SalesQuoteLineSLOrdenation = RPSControlFactory.CreateRPSFormattedTextBox<QuotationSLConsultQueryView>("ad2277d4-e4fe-4f39-b513-8f756eb562d8","","",false, this);
 
            SalesQuoteSLDate = RPSControlFactory.CreateRPSTextBox<QuotationSLConsultQueryView>("307949eb-21e0-4ccd-9fac-1352861745cd","","",false, this);
 
            OpportunitySLStatus = RPSControlFactory.CreateRPSTextBox<QuotationSLConsultQueryView>("4c4072fd-469d-4230-8228-dc6ae45ff1b0","","",false, this);
 
            CollectionInit params_QuotationConsult = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="f5a4df67-b990-44e8-8a40-58695d316b41",CSSSelectorGrid="",XPathGrid=""};
            QuotationConsult = RPSControlFactory.RPSCreateCollectionWithGrid<QuotationConsultCollectionEditor<QuotationSLConsultQueryView>,QuotationSLConsultQueryView>( params_QuotationConsult,this);
 

        }
        public IRPSCollectionComboBox<QuotationSLConsultQueryView> QuotationSL { get; set; } 
        public IRPSCollectionComboBox<QuotationSLConsultQueryView> IDSalesQuoteFilter { get; set; } 
        public IRPSCollectionComboBox<QuotationSLConsultQueryView> IDOportunitySL { get; set; } 
        public IRPSTextBox<QuotationSLConsultQueryView> QuotationDateFromFilter { get; set; } 
        public IRPSTextBox<QuotationSLConsultQueryView> QuotationDateToFilter { get; set; } 
        public IRPSOption<QuotationSLConsultQueryView> All { get; set; } 
        public IRPSOption<QuotationSLConsultQueryView> Generated { get; set; } 
        public IRPSOption<QuotationSLConsultQueryView> NonGenerated { get; set; } 
        public IRPSOption<QuotationSLConsultQueryView> All1 { get; set; } 
        public IRPSOption<QuotationSLConsultQueryView> Generated1 { get; set; } 
        public IRPSOption<QuotationSLConsultQueryView> NonGenerated1 { get; set; } 
        public IRPSCollectionComboBox<QuotationSLConsultQueryView> QuotationCustomerList { get; set; } 
        public IRPSCollectionComboBox<QuotationSLConsultQueryView> QuotationPotentialCustomerSLList { get; set; } 
        public IRPSCollectionComboBox<QuotationSLConsultQueryView> IDProductLinesFilter { get; set; } 
        public IRPSCollectionComboBox<QuotationSLConsultQueryView> IDProductFamiliesFilter { get; set; } 
        public IRPSCollectionComboBox<QuotationSLConsultQueryView> IDProductSubFamiliesFilter { get; set; } 
        public IRPSCollectionComboBox<QuotationSLConsultQueryView> IDQuotationArticleFilter { get; set; } 
        public IRPSComboBox<QuotationSLConsultQueryView> IDQuotationAssembly { get; set; } 
        public IRPSTextBox<QuotationSLConsultQueryView> QuotationSLDate { get; set; } 
        public IRPSTextBox<QuotationSLConsultQueryView> SalesQuoteLineSLOrdenation { get; set; } 
        public IRPSTextBox<QuotationSLConsultQueryView> SalesQuoteSLDate { get; set; } 
        public IRPSTextBox<QuotationSLConsultQueryView> OpportunitySLStatus { get; set; } 
        public QuotationConsultCollectionEditor<QuotationSLConsultQueryView> QuotationConsult { get; set; } 
        public QuotationSLConsult Screen { get; set; }
        public QuotationSLConsultQueryView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class QuotationConsultCollectionEditor<QuotationSLConsultQueryView>:RPSCollectionEditor<QuotationSLConsultQueryView> where QuotationSLConsultQueryView : class, IView
    {
        public  QuotationConsultGridView<QuotationSLConsultQueryView> GridView {get;set;}
    }
    public partial class QuotationConsultGridView <QuotationSLConsultQueryView> :  RPSGridView<QuotationSLConsultQueryView> where QuotationSLConsultQueryView : class, IView
    {
        public QuotationConsultGridView(QuotationSLConsultQueryView currentView)
        {
            this.WebDriver = currentView.WebDriver;          
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            QuotationSLDate = RPSControlFactory.CreateRPSGridTextBox<QuotationSLConsultQueryView>("","#f5a4df67-b990-44e8-8a40-58695d316b41 .ag-row[role='row']@ROWINDEX [col-id='cQuotationSLDate']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<QuotationSLConsultQueryView> QuotationSLDate { get; set; } 
                     
    }
 
    }
  
    

}