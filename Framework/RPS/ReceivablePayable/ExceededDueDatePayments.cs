    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.ReceivablePayable.ExceededDueDatePayments
{
    //RPS VERSION 1.0.0.0
    public partial class ExceededDueDatePayments:Screen
    {
        public ExceededDueDatePayments():base()
        {
            this.URL = "receivablepayable.exceededduedatepayments";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            ExceededDueDatePaymentsView  = new ExceededDueDatePaymentsView(this); 
            ExceededDueDatePaymentsView.InitializeControls(); 
           
        }
      
            public ExceededDueDatePaymentsView ExceededDueDatePaymentsView {get; set; } 
    }
            
    public partial class ExceededDueDatePaymentsView : View
    {
        public ExceededDueDatePaymentsView(ExceededDueDatePayments screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            Year = RPSControlFactory.CreateRPSFormattedTextBox<ExceededDueDatePaymentsView>("608c799a-5d63-44de-acb4-56bc9eaab92e","","",true, this);
 
            CheckLimitDays = RPSControlFactory.CreateRPSCheckBox<ExceededDueDatePaymentsView>("085d0ac7-47ea-4d33-95ac-1fd557e0ea72","","",false, this);
 
            LimitDays = RPSControlFactory.CreateRPSFormattedTextBox<ExceededDueDatePaymentsView>("d51db507-1eaa-4993-a047-b5e3e757c14b","","",false, this);
 
            CheckCustomerExceededDueDatePaid = RPSControlFactory.CreateRPSCheckBox<ExceededDueDatePaymentsView>("072daa41-c8ec-4266-85a3-fc4b4fa25074","","",false, this);
 
            CheckCustomerExceededDueDatePending = RPSControlFactory.CreateRPSCheckBox<ExceededDueDatePaymentsView>("8e989774-85a4-4b99-a755-98555114a337","","",false, this);
 
            IDCustomer = RPSControlFactory.CreateRPSCollectionComboBox<ExceededDueDatePaymentsView>("e675a859-0f5f-4aff-8fc6-da4049240ad1","","",false, this);
 
            CheckSupplierExceededDueDatePaid = RPSControlFactory.CreateRPSCheckBox<ExceededDueDatePaymentsView>("cf724e7f-f707-4a31-9631-93151b742e45","","",false, this);
 
            CheckSupplierExceededDueDatePending = RPSControlFactory.CreateRPSCheckBox<ExceededDueDatePaymentsView>("0ad684ef-8304-48b9-bedb-d071bbbdb809","","",false, this);
 
            IDSupplier = RPSControlFactory.CreateRPSCollectionComboBox<ExceededDueDatePaymentsView>("334bb607-43ce-4c60-bec1-d4f5697d540e","","",false, this);
 
            PrintCommand = RPSControlFactory.CreateRPSButton<ExceededDueDatePaymentsView>( "f140840d-bd2c-49db-8b4b-5a351127ac9e","","",this);
 

        }
        public IRPSTextBox<ExceededDueDatePaymentsView> Year { get; set; } 
        public IRPSCheckbox<ExceededDueDatePaymentsView> CheckLimitDays { get; set; } 
        public IRPSTextBox<ExceededDueDatePaymentsView> LimitDays { get; set; } 
        public IRPSCheckbox<ExceededDueDatePaymentsView> CheckCustomerExceededDueDatePaid { get; set; } 
        public IRPSCheckbox<ExceededDueDatePaymentsView> CheckCustomerExceededDueDatePending { get; set; } 
        public IRPSCollectionComboBox<ExceededDueDatePaymentsView> IDCustomer { get; set; } 
        public IRPSCheckbox<ExceededDueDatePaymentsView> CheckSupplierExceededDueDatePaid { get; set; } 
        public IRPSCheckbox<ExceededDueDatePaymentsView> CheckSupplierExceededDueDatePending { get; set; } 
        public IRPSCollectionComboBox<ExceededDueDatePaymentsView> IDSupplier { get; set; } 
        public IRPSButton<ExceededDueDatePaymentsView> PrintCommand { get; set; } 
        public ExceededDueDatePayments Screen { get; set; }
        public ExceededDueDatePaymentsView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}