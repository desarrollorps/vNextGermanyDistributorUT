    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.Project.ImputationSupplier
{
    //RPS VERSION 1.0.0.0
    public partial class ImputationSupplier:Screen
    {
        public ImputationSupplier():base()
        {
            this.URL = "project.imputationsupplier";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            ImputationSupplierQueryView  = new ImputationSupplierQueryView(this); 
            ImputationSupplierQueryView.InitializeControls(); 
           
        }
      
            public ImputationSupplierQueryView ImputationSupplierQueryView {get; set; } 
    }
            
    public partial class ImputationSupplierQueryView : View
    {
        public ImputationSupplierQueryView(ImputationSupplier screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            Supplier = RPSControlFactory.CreateRPSCollectionComboBox<ImputationSupplierQueryView>("f4ba5fbc-3375-4ec2-90e9-1c623f53426c","","",false, this);
 
            DateFrom = RPSControlFactory.CreateRPSTextBox<ImputationSupplierQueryView>("048b720c-aa66-490d-9344-3a3656f9a378","","",false, this);
 
            DateTo = RPSControlFactory.CreateRPSTextBox<ImputationSupplierQueryView>("47ba5198-6cea-429a-ab12-a06a7f422216","","",false, this);
 
            Date = RPSControlFactory.CreateRPSTextBox<ImputationSupplierQueryView>("e01767a3-9ff5-40f0-9bc4-e0e9d27fb68d","","",false, this);
 
            HourTotal = RPSControlFactory.CreateRPSFormattedTextBox<ImputationSupplierQueryView>("7fc6ed37-ee16-488d-9a64-7029d450aea4","","",false, this);
 
            TotalAmount = RPSControlFactory.CreateRPSFormattedTextBox<ImputationSupplierQueryView>("8a9de895-1960-4b1e-ba1a-c5d83f2b0308","","",false, this);
 

        }
        public IRPSCollectionComboBox<ImputationSupplierQueryView> Supplier { get; set; } 
        public IRPSTextBox<ImputationSupplierQueryView> DateFrom { get; set; } 
        public IRPSTextBox<ImputationSupplierQueryView> DateTo { get; set; } 
        public IRPSTextBox<ImputationSupplierQueryView> Date { get; set; } 
        public IRPSTextBox<ImputationSupplierQueryView> HourTotal { get; set; } 
        public IRPSTextBox<ImputationSupplierQueryView> TotalAmount { get; set; } 
        public ImputationSupplier Screen { get; set; }
        public ImputationSupplierQueryView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}