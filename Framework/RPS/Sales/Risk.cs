    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.Sales.Risk
{
    //RPS VERSION 1.0.0.0
    public partial class Risk:Screen
    {
        public Risk():base()
        {
            this.URL = "sales.risk";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            RiskQueryView  = new RiskQueryView(this); 
            RiskQueryView.InitializeControls(); 
           
        }
      
            public RiskQueryView RiskQueryView {get; set; } 
    }
            
    public partial class RiskQueryView : View
    {
        public RiskQueryView(Risk screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            IDCustomer = RPSControlFactory.CreateRPSComboBox<RiskQueryView>("efaf7119-cce0-45a5-92a2-9751ee6807f1","","",false, this);
 
            IDCustomerGroupSL = RPSControlFactory.CreateRPSComboBox<RiskQueryView>("982be904-2c97-47a2-b520-5fd088093658","","",false, this);
 
            IDCustomerGroupValueSL = RPSControlFactory.CreateRPSComboBox<RiskQueryView>("47d0b153-23e0-4630-9fdd-b9a35bfb84f4","","",false, this);
 
            ExceededRisk = RPSControlFactory.CreateRPSCheckBox<RiskQueryView>("f1366fad-662e-4b42-a846-0cb3ce5d1d3c","","",false, this);
 
            UpdateRisks = RPSControlFactory.CreateRPSCheckBox<RiskQueryView>("beab83cc-6dca-4db0-a077-37c5a05de1b0","","",false, this);
 
            CollectionInit params_RiskConsult = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="a7733e91-978c-4d0e-8a9e-929031f78834",CSSSelectorGrid="",XPathGrid=""};
            RiskConsult = RPSControlFactory.RPSCreateCollectionWithGrid<RiskConsultCollectionEditor<RiskQueryView>,RiskQueryView>( params_RiskConsult,this);
 

        }
        public IRPSComboBox<RiskQueryView> IDCustomer { get; set; } 
        public IRPSComboBox<RiskQueryView> IDCustomerGroupSL { get; set; } 
        public IRPSComboBox<RiskQueryView> IDCustomerGroupValueSL { get; set; } 
        public IRPSCheckbox<RiskQueryView> ExceededRisk { get; set; } 
        public IRPSCheckbox<RiskQueryView> UpdateRisks { get; set; } 
        public RiskConsultCollectionEditor<RiskQueryView> RiskConsult { get; set; } 
        public Risk Screen { get; set; }
        public RiskQueryView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class RiskConsultCollectionEditor<RiskQueryView>:RPSCollectionEditor<RiskQueryView> where RiskQueryView : class, IView
    {
        public  RiskConsultGridView<RiskQueryView> GridView {get;set;}
    }
    public partial class RiskConsultGridView <RiskQueryView> :  RPSGridView<RiskQueryView> where RiskQueryView : class, IView
    {
        public RiskConsultGridView(RiskQueryView currentView)
        {
            this.WebDriver = currentView.WebDriver;          
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {

        }
                     
    }
 
    }
  
    

}