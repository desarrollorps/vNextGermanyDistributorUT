    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.Sales.CustomerChangeDeliveryNoteSL
{
    //RPS VERSION 1.0.0.0
    public partial class CustomerChangeDeliveryNoteSL:Screen
    {
        public CustomerChangeDeliveryNoteSL():base()
        {
            this.URL = "sales.customerchangedeliverynotesl";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            CustomerChangeDeliveryNoteSLView  = new CustomerChangeDeliveryNoteSLView(this); 
            CustomerChangeDeliveryNoteSLView.InitializeControls(); 
           
        }
      
            public CustomerChangeDeliveryNoteSLView CustomerChangeDeliveryNoteSLView {get; set; } 
    }
            
    public partial class CustomerChangeDeliveryNoteSLView : View
    {
        public CustomerChangeDeliveryNoteSLView(CustomerChangeDeliveryNoteSL screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            DeliveryNoteSL = RPSControlFactory.CreateRPSComboBox<CustomerChangeDeliveryNoteSLView>("e941a22b-373c-4576-bf67-62f84e0f7a1e","","",false, this);
 
            ChangeHeaderCondition = RPSControlFactory.CreateRPSCheckBox<CustomerChangeDeliveryNoteSLView>("232e80cb-c3f3-429b-8914-67ef203041f8","","",false, this);
 
            Customer = RPSControlFactory.CreateRPSComboBox<CustomerChangeDeliveryNoteSLView>("8f68762e-a75c-4332-883f-1a041702bb4b","","",false, this);
 
            VATNumber = RPSControlFactory.CreateRPSTextBox<CustomerChangeDeliveryNoteSLView>("fe68b879-0be7-45b0-ab2c-22e42d499d78","","",false, this);
 
            CustomerMiscellaneousSL = RPSControlFactory.CreateRPSComboBox<CustomerChangeDeliveryNoteSLView>("f03fa652-0fe3-4cbf-9844-2ba0fb085716","","",false, this);
 
            IDNewCustomer = RPSControlFactory.CreateRPSComboBox<CustomerChangeDeliveryNoteSLView>("8af7efc8-285c-4a8a-9256-abfb2f85b1ca","","",false, this);
 
            NewVATNumber = RPSControlFactory.CreateRPSTextBox<CustomerChangeDeliveryNoteSLView>("1d9f53fc-bf42-4c84-9dbe-9c01a8de784c","","",false, this);
 
            NewCustomerMiscellaneousSL = RPSControlFactory.CreateRPSComboBox<CustomerChangeDeliveryNoteSLView>("799e9da5-305f-45e1-8a90-49dfcbc0c010","","",false, this);
 
            ExecuteApplyCustomerChange = RPSControlFactory.CreateRPSButton<CustomerChangeDeliveryNoteSLView>( "860e1c51-270c-4e11-a43a-4977d1fef34f","","",this);
 

        }
        public IRPSComboBox<CustomerChangeDeliveryNoteSLView> DeliveryNoteSL { get; set; } 
        public IRPSCheckbox<CustomerChangeDeliveryNoteSLView> ChangeHeaderCondition { get; set; } 
        public IRPSComboBox<CustomerChangeDeliveryNoteSLView> Customer { get; set; } 
        public IRPSTextBox<CustomerChangeDeliveryNoteSLView> VATNumber { get; set; } 
        public IRPSComboBox<CustomerChangeDeliveryNoteSLView> CustomerMiscellaneousSL { get; set; } 
        public IRPSComboBox<CustomerChangeDeliveryNoteSLView> IDNewCustomer { get; set; } 
        public IRPSTextBox<CustomerChangeDeliveryNoteSLView> NewVATNumber { get; set; } 
        public IRPSComboBox<CustomerChangeDeliveryNoteSLView> NewCustomerMiscellaneousSL { get; set; } 
        public IRPSButton<CustomerChangeDeliveryNoteSLView> ExecuteApplyCustomerChange { get; set; } 
        public CustomerChangeDeliveryNoteSL Screen { get; set; }
        public CustomerChangeDeliveryNoteSLView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}