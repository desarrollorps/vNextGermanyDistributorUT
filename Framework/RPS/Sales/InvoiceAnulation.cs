    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.Sales.InvoiceAnulation
{
    //RPS VERSION 1.0.0.0
    public partial class InvoiceAnulation:Screen
    {
        public InvoiceAnulation():base()
        {
            this.URL = "sales.invoiceanulation";
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
            InvoiceSL = RPSControlFactory.CreateRPSComboBox<InvoiceAnulationView>("99f2d4c7-b76c-4fca-87ba-b8294b69f127","","",false, this);
 
            CompanyName = RPSControlFactory.CreateRPSTextBox<InvoiceAnulationView>("57afd79a-311c-43d8-82dd-8d52bb1d175b","","",false, this);
 
            InvoiceDate = RPSControlFactory.CreateRPSTextBox<InvoiceAnulationView>("f8ea5e43-c615-4034-9f4e-a5a7dfd21fd3","","",false, this);
 
            Reserve = RPSControlFactory.CreateRPSCheckBox<InvoiceAnulationView>("c37f7943-98a9-4e6c-befc-36ca1d87da59","","",false, this);
 
            CheckDirect = RPSControlFactory.CreateRPSCheckBox<InvoiceAnulationView>("25d5de73-8099-4eb9-a8fe-13910ea85377","","",false, this);
 
            DeleteDirectInvoice = RPSControlFactory.CreateRPSCheckBox<InvoiceAnulationView>("0f030f9a-08b6-4b1c-98ba-b6a8bf2623e7","","",false, this);
 
            AceptarCommand = RPSControlFactory.CreateRPSButton<InvoiceAnulationView>( "bf5f441c-fe8b-4d59-8b4a-47875f92f5e2","","",this);
 
            CollectionInit params_InvoiceAnulationConsult = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="8f179f7d-531d-43c2-b155-03624ca0dee3",CSSSelectorGrid="",XPathGrid=""};
            InvoiceAnulationConsult = RPSControlFactory.RPSCreateCollectionWithGrid<InvoiceAnulationConsultCollectionEditor<InvoiceAnulationView>,InvoiceAnulationView>( params_InvoiceAnulationConsult,this);
 

        }
        public IRPSComboBox<InvoiceAnulationView> InvoiceSL { get; set; } 
        public IRPSTextBox<InvoiceAnulationView> CompanyName { get; set; } 
        public IRPSTextBox<InvoiceAnulationView> InvoiceDate { get; set; } 
        public IRPSCheckbox<InvoiceAnulationView> Reserve { get; set; } 
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