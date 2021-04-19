    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.SalesCRM.OpportunityAnalysis
{
    //RPS VERSION 1.0.0.0
    public partial class OpportunityAnalysis:Screen
    {
        public OpportunityAnalysis():base()
        {
            this.URL = "salescrm.opportunityanalysis";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            OpportunityAnalysisQueryView  = new OpportunityAnalysisQueryView(this); 
            OpportunityAnalysisQueryView.InitializeControls(); 
           
        }
      
            public OpportunityAnalysisQueryView OpportunityAnalysisQueryView {get; set; } 
    }
            
    public partial class OpportunityAnalysisQueryView : View
    {
        public OpportunityAnalysisQueryView(OpportunityAnalysis screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            DateFrom = RPSControlFactory.CreateRPSTextBox<OpportunityAnalysisQueryView>("a872578f-697a-443b-b5c8-d9c77617eac9","","",false, this);
 
            DateTo = RPSControlFactory.CreateRPSTextBox<OpportunityAnalysisQueryView>("cabeeeb0-72e9-4b16-8d1b-3ca2b9d42572","","",false, this);
 
            SalesQuoteAccept = RPSControlFactory.CreateRPSCheckBox<OpportunityAnalysisQueryView>("93ee5136-58cb-450c-91bd-bd3ef33d67f8","","",false, this);
 
            lsIDCommercialAgent = RPSControlFactory.CreateRPSCollectionComboBox<OpportunityAnalysisQueryView>("d3b4cbbb-7c9d-4546-bdaa-23d5be4e41c1","","",false, this);
 
            lsIDCustomer = RPSControlFactory.CreateRPSCollectionComboBox<OpportunityAnalysisQueryView>("eea757e6-4fe3-4fad-8810-cfe2f914096d","","",false, this);
 
            lsIDPotentialCustomer = RPSControlFactory.CreateRPSCollectionComboBox<OpportunityAnalysisQueryView>("85f3be6a-2a30-49f6-83ac-bde6499977cb","","",false, this);
 
            ownerType = RPSControlFactory.CreateRPSTextBox<OpportunityAnalysisQueryView>("cf188a88-28a2-4b26-8be7-2b30f79f0847","","",false, this);
 
            OportunitySL_OportunityDate = RPSControlFactory.CreateRPSTextBox<OpportunityAnalysisQueryView>("c5762460-f3b9-4219-aa61-c663797fff30","","",false, this);
 
            OportunitySL_EstimatedCloseDate = RPSControlFactory.CreateRPSTextBox<OpportunityAnalysisQueryView>("e224fdb8-423c-465f-9fa6-6bda9ed5c36e","","",false, this);
 
            OportunitySL_Status = RPSControlFactory.CreateRPSTextBox<OpportunityAnalysisQueryView>("7c394cf4-84a1-42db-a05b-c6255f3b670c","","",false, this);
 
            OportunitySL_CloseDate = RPSControlFactory.CreateRPSTextBox<OpportunityAnalysisQueryView>("77cb8466-f258-4052-ba24-eab468fc191e","","",false, this);
 
            CollectionInit params_OportunityAnalysisConsult = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="0a68cbf7-8248-4930-bee6-35ee5e150b52",CSSSelectorGrid="",XPathGrid=""};
            OportunityAnalysisConsult = RPSControlFactory.RPSCreateCollectionWithGrid<OportunityAnalysisConsultCollectionEditor<OpportunityAnalysisQueryView>,OpportunityAnalysisQueryView>( params_OportunityAnalysisConsult,this);
 

        }
        public IRPSTextBox<OpportunityAnalysisQueryView> DateFrom { get; set; } 
        public IRPSTextBox<OpportunityAnalysisQueryView> DateTo { get; set; } 
        public IRPSCheckbox<OpportunityAnalysisQueryView> SalesQuoteAccept { get; set; } 
        public IRPSCollectionComboBox<OpportunityAnalysisQueryView> lsIDCommercialAgent { get; set; } 
        public IRPSCollectionComboBox<OpportunityAnalysisQueryView> lsIDCustomer { get; set; } 
        public IRPSCollectionComboBox<OpportunityAnalysisQueryView> lsIDPotentialCustomer { get; set; } 
        public IRPSTextBox<OpportunityAnalysisQueryView> ownerType { get; set; } 
        public IRPSTextBox<OpportunityAnalysisQueryView> OportunitySL_OportunityDate { get; set; } 
        public IRPSTextBox<OpportunityAnalysisQueryView> OportunitySL_EstimatedCloseDate { get; set; } 
        public IRPSTextBox<OpportunityAnalysisQueryView> OportunitySL_Status { get; set; } 
        public IRPSTextBox<OpportunityAnalysisQueryView> OportunitySL_CloseDate { get; set; } 
        public OportunityAnalysisConsultCollectionEditor<OpportunityAnalysisQueryView> OportunityAnalysisConsult { get; set; } 
        public OpportunityAnalysis Screen { get; set; }
        public OpportunityAnalysisQueryView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class OportunityAnalysisConsultCollectionEditor<OpportunityAnalysisQueryView>:RPSCollectionEditor<OpportunityAnalysisQueryView> where OpportunityAnalysisQueryView : class, IView
    {
        public  OportunityAnalysisConsultGridView<OpportunityAnalysisQueryView> GridView {get;set;}
    }
    public partial class OportunityAnalysisConsultGridView <OpportunityAnalysisQueryView> :  RPSGridView<OpportunityAnalysisQueryView> where OpportunityAnalysisQueryView : class, IView
    {
        public OportunityAnalysisConsultGridView(OpportunityAnalysisQueryView currentView)
        {
            this.WebDriver = currentView.WebDriver;          
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            OportunitySL_Status = RPSControlFactory.CreateRPSGridTextBox<OpportunityAnalysisQueryView>("","#0a68cbf7-8248-4930-bee6-35ee5e150b52 .ag-row[role='row']@ROWINDEX [col-id='cOportunitySL_Status']","",false, this.CurrentView);
 
            IDCuDistProductType = RPSControlFactory.CreateRPSGridComboBox<OpportunityAnalysisQueryView>("","#0a68cbf7-8248-4930-bee6-35ee5e150b52 .ag-row[role='row']@ROWINDEX [col-id='cIDCuDistProductType']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<OpportunityAnalysisQueryView> OportunitySL_Status { get; set; } 
        public IRPSGridComboBox<OpportunityAnalysisQueryView> IDCuDistProductType { get; set; } 
                     
    }
 
    }
  
    

}