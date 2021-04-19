    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.Purchase.InvoiceAnulation
{
    //RPS VERSION 1.0.0.0
    public partial class InvoiceAnulation:Screen
    {
        public InvoiceAnulation():base()
        {
            this.URL = "purchase.invoiceanulation";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            InvoiceAnulationView  = new InvoiceAnulationView(this); 
            InvoiceAnulationView.InitializeControls(); 
           
        }
      
            public InvoiceAnulationView InvoiceAnulationView {get; set; } 
    }
            
    public partial class InvoiceAnulationView : View
    {
        public InvoiceAnulationView(InvoiceAnulation screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            Supplier = RPSControlFactory.CreateRPSComboBox<InvoiceAnulationView>("30707fca-618d-48ea-b17d-96ff40356991","","",true, this);
 
            Invoice = RPSControlFactory.CreateRPSComboBox<InvoiceAnulationView>("5f8c473a-83eb-4ca3-86e0-aa19ee4a1dbe","","",true, this);
 
            InvoiceDate = RPSControlFactory.CreateRPSTextBox<InvoiceAnulationView>("fb22e6d1-33cd-45a6-86c2-808c9265f8c3","","",false, this);
 
            CheckDirect = RPSControlFactory.CreateRPSCheckBox<InvoiceAnulationView>("bc30b213-5f3e-44b2-94ec-50773a8605bf","","",false, this);
 
            DeleteDirectInvoice = RPSControlFactory.CreateRPSCheckBox<InvoiceAnulationView>("213988f6-09ce-4556-975f-7503afdc1151","","",false, this);
 
            AceptarCommand = RPSControlFactory.CreateRPSButton<InvoiceAnulationView>( "a2cdeaa3-25e7-4ad3-82de-b3c212a979a5","","",this);
 
            CollectionInit params_InvoiceAnulationConsult = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="7a5da18f-d5cf-4205-ac57-6a7afa91e662",CSSSelectorGrid="",XPathGrid=""};
            InvoiceAnulationConsult = RPSControlFactory.RPSCreateCollectionWithGrid<InvoiceAnulationConsultCollectionEditor<InvoiceAnulationView>,InvoiceAnulationView>( params_InvoiceAnulationConsult,this);
 

        }
        public IRPSComboBox<InvoiceAnulationView> Supplier { get; set; } 
        public IRPSComboBox<InvoiceAnulationView> Invoice { get; set; } 
        public IRPSTextBox<InvoiceAnulationView> InvoiceDate { get; set; } 
        public IRPSCheckbox<InvoiceAnulationView> CheckDirect { get; set; } 
        public IRPSCheckbox<InvoiceAnulationView> DeleteDirectInvoice { get; set; } 
        public IRPSButton<InvoiceAnulationView> AceptarCommand { get; set; } 
        public InvoiceAnulationConsultCollectionEditor<InvoiceAnulationView> InvoiceAnulationConsult { get; set; } 
        public InvoiceAnulation Screen { get; set; }
        public InvoiceAnulationView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class InvoiceAnulationConsultCollectionEditor<InvoiceAnulationView>:RPSCollectionEditor<InvoiceAnulationView> where InvoiceAnulationView : class, IView
    {
        public  InvoiceAnulationConsultGridView<InvoiceAnulationView> GridView {get;set;}
    }
    public partial class InvoiceAnulationConsultGridView <InvoiceAnulationView> :  RPSGridView<InvoiceAnulationView> where InvoiceAnulationView : class, IView
    {
        public InvoiceAnulationConsultGridView(InvoiceAnulationView currentView)
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