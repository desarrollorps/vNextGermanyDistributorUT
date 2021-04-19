    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.SalesCRM.SalesPrevision
{
    //RPS VERSION 1.0.0.0
    public partial class SalesPrevision:Screen
    {
        public SalesPrevision():base()
        {
            this.URL = "salescrm.salesprevision";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            SalesPrevisionQueryView  = new SalesPrevisionQueryView(this); 
            SalesPrevisionQueryView.InitializeControls(); 
           
        }
      
            public SalesPrevisionQueryView SalesPrevisionQueryView {get; set; } 
    }
            
    public partial class SalesPrevisionQueryView : View
    {
        public SalesPrevisionQueryView(SalesPrevision screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            DateCloseFrom = RPSControlFactory.CreateRPSTextBox<SalesPrevisionQueryView>("18f2553d-21c2-4900-9616-0d6faee1fbe7","","",false, this);
 
            DateCloseTo = RPSControlFactory.CreateRPSTextBox<SalesPrevisionQueryView>("3a413855-3fb6-4feb-91f5-c06d7857666c","","",false, this);
 
            Probability = RPSControlFactory.CreateRPSFormattedTextBox<SalesPrevisionQueryView>("7d80d301-2ac2-456d-bd28-aec6af3d0818","","",false, this);
 
            lsIDCommercialAgent = RPSControlFactory.CreateRPSCollectionComboBox<SalesPrevisionQueryView>("1916f499-2b74-4b6c-b438-91470a300335","","",false, this);
 
            lsIDCustomer = RPSControlFactory.CreateRPSCollectionComboBox<SalesPrevisionQueryView>("911eafa5-94b0-4d79-b40e-cba74e04793d","","",false, this);
 
            lsIDPotentialCustomer = RPSControlFactory.CreateRPSCollectionComboBox<SalesPrevisionQueryView>("189d5234-bda2-4626-9407-3c9df1d4b80e","","",false, this);
 
            CollectionInit params_OportunitySalesPrevisionConsult = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="ee57ae32-3a71-425f-b7d8-591623ecb480",CSSSelectorGrid="",XPathGrid=""};
            OportunitySalesPrevisionConsult = RPSControlFactory.RPSCreateCollectionWithGrid<OportunitySalesPrevisionConsultCollectionEditor<SalesPrevisionQueryView>,SalesPrevisionQueryView>( params_OportunitySalesPrevisionConsult,this);
 

        }
        public IRPSTextBox<SalesPrevisionQueryView> DateCloseFrom { get; set; } 
        public IRPSTextBox<SalesPrevisionQueryView> DateCloseTo { get; set; } 
        public IRPSTextBox<SalesPrevisionQueryView> Probability { get; set; } 
        public IRPSCollectionComboBox<SalesPrevisionQueryView> lsIDCommercialAgent { get; set; } 
        public IRPSCollectionComboBox<SalesPrevisionQueryView> lsIDCustomer { get; set; } 
        public IRPSCollectionComboBox<SalesPrevisionQueryView> lsIDPotentialCustomer { get; set; } 
        public OportunitySalesPrevisionConsultCollectionEditor<SalesPrevisionQueryView> OportunitySalesPrevisionConsult { get; set; } 
        public SalesPrevision Screen { get; set; }
        public SalesPrevisionQueryView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class OportunitySalesPrevisionConsultCollectionEditor<SalesPrevisionQueryView>:RPSCollectionEditor<SalesPrevisionQueryView> where SalesPrevisionQueryView : class, IView
    {
        public  OportunitySalesPrevisionConsultGridView<SalesPrevisionQueryView> GridView {get;set;}
    }
    public partial class OportunitySalesPrevisionConsultGridView <SalesPrevisionQueryView> :  RPSGridView<SalesPrevisionQueryView> where SalesPrevisionQueryView : class, IView
    {
        public OportunitySalesPrevisionConsultGridView(SalesPrevisionQueryView currentView)
        {
            this.WebDriver = currentView.WebDriver;          
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            OportunitySL_EstimatedCloseDate = RPSControlFactory.CreateRPSGridTextBox<SalesPrevisionQueryView>("","#ee57ae32-3a71-425f-b7d8-591623ecb480 .ag-row[role='row']@ROWINDEX [col-id='cOportunitySL_EstimatedCloseDate']","",false, this.CurrentView);
 
            IDCuDistProductTypeSL = RPSControlFactory.CreateRPSGridComboBox<SalesPrevisionQueryView>("","#ee57ae32-3a71-425f-b7d8-591623ecb480 .ag-row[role='row']@ROWINDEX [col-id='cIDCuDistProductTypeSL']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<SalesPrevisionQueryView> OportunitySL_EstimatedCloseDate { get; set; } 
        public IRPSGridComboBox<SalesPrevisionQueryView> IDCuDistProductTypeSL { get; set; } 
                     
    }
 
    }
  
    

}