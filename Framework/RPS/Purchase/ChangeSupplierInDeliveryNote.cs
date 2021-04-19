    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.Purchase.ChangeSupplierInDeliveryNote
{
    //RPS VERSION 1.0.0.0
    public partial class ChangeSupplierInDeliveryNote:Screen
    {
        public ChangeSupplierInDeliveryNote():base()
        {
            this.URL = "purchase.changesupplierindeliverynote";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            ChangeSupplierInDeliveryNoteView  = new ChangeSupplierInDeliveryNoteView(this); 
            ChangeSupplierInDeliveryNoteView.InitializeControls(); 
           
        }
      
            public ChangeSupplierInDeliveryNoteView ChangeSupplierInDeliveryNoteView {get; set; } 
    }
            
    public partial class ChangeSupplierInDeliveryNoteView : View
    {
        public ChangeSupplierInDeliveryNoteView(ChangeSupplierInDeliveryNote screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            DeliveryNote = RPSControlFactory.CreateRPSComboBox<ChangeSupplierInDeliveryNoteView>("faf9a134-d0c0-4e48-8cd9-a6a50a8f8bcc","","",false, this);
 
            ChangeHeaderCondition = RPSControlFactory.CreateRPSCheckBox<ChangeSupplierInDeliveryNoteView>("9bd4de3f-a0d9-4767-884d-8bc3dd5074bb","","",false, this);
 
            Supplier = RPSControlFactory.CreateRPSComboBox<ChangeSupplierInDeliveryNoteView>("6b583880-dbb6-40c6-a36d-457a58859f79","","",false, this);
 
            VATNumber = RPSControlFactory.CreateRPSTextBox<ChangeSupplierInDeliveryNoteView>("d92c9c4e-35a4-4e5c-b9b2-d2ede2f755ee","","",false, this);
 
            IDNewSupplier = RPSControlFactory.CreateRPSComboBox<ChangeSupplierInDeliveryNoteView>("8ab0bae2-3576-4223-8b95-f26c55d0ada5","","",false, this);
 
            NewVATNumber = RPSControlFactory.CreateRPSTextBox<ChangeSupplierInDeliveryNoteView>("12f2ca48-25e9-4acc-909c-437b4a5bca73","","",false, this);
 
            ExecuteApplySupplierChange = RPSControlFactory.CreateRPSButton<ChangeSupplierInDeliveryNoteView>( "bcd6030f-ee23-40cb-9cc0-ab862c112288","","",this);
 

        }
        public IRPSComboBox<ChangeSupplierInDeliveryNoteView> DeliveryNote { get; set; } 
        public IRPSCheckbox<ChangeSupplierInDeliveryNoteView> ChangeHeaderCondition { get; set; } 
        public IRPSComboBox<ChangeSupplierInDeliveryNoteView> Supplier { get; set; } 
        public IRPSTextBox<ChangeSupplierInDeliveryNoteView> VATNumber { get; set; } 
        public IRPSComboBox<ChangeSupplierInDeliveryNoteView> IDNewSupplier { get; set; } 
        public IRPSTextBox<ChangeSupplierInDeliveryNoteView> NewVATNumber { get; set; } 
        public IRPSButton<ChangeSupplierInDeliveryNoteView> ExecuteApplySupplierChange { get; set; } 
        public ChangeSupplierInDeliveryNote Screen { get; set; }
        public ChangeSupplierInDeliveryNoteView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}