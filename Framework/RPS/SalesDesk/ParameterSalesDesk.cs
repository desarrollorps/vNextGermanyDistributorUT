    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.SalesDesk.ParameterSalesDesk
{
    //RPS VERSION 1.0.0.0
    public partial class ParameterSalesDesk:Screen
    {
        public ParameterSalesDesk():base()
        {
            this.URL = "salesdesk.parametersalesdesk";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            ParameterFacSLEntityView  = new ParameterFacSLEntityView(this); 
            ParameterFacSLEntityView.InitializeControls(); 
           
        }
      
            public ParameterFacSLEntityView ParameterFacSLEntityView {get; set; } 
    }
            
    public partial class ParameterFacSLEntityView : View
    {
        public ParameterFacSLEntityView(ParameterSalesDesk screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            OpenCashDaily = RPSControlFactory.CreateRPSCheckBox<ParameterFacSLEntityView>("f522373a-9d35-4e52-870c-112611a5afd4","","",true, this);
 
            IDCodingSerieAccountingTicket = RPSControlFactory.CreateRPSComboBox<ParameterFacSLEntityView>("e47b460a-c0e7-4eed-8c93-13e6de335759","","",false, this);
 
            IDCodingSerieAccountingTicketB = RPSControlFactory.CreateRPSComboBox<ParameterFacSLEntityView>("a0078ba8-49e2-4ac2-9450-6439a5e4f6fe","","",false, this);
 
            IDCommercialAgentClassificationTicket = RPSControlFactory.CreateRPSComboBox<ParameterFacSLEntityView>("41bab03d-01e6-4f43-bce8-1ea19e1516d1","","",false, this);
 
            ReplaceTicketsCommercialAgent = RPSControlFactory.CreateRPSCheckBox<ParameterFacSLEntityView>("d72d87c0-16db-4f13-8a14-8c1d8afc8d63","","",true, this);
 
            DeleteRestCommercialAgentTicket = RPSControlFactory.CreateRPSCheckBox<ParameterFacSLEntityView>("e5be4778-3500-4bb5-aca6-603c4ff3a201","","",true, this);
 
            GenerateReceivableFromAccountingTickets = RPSControlFactory.CreateRPSCheckBox<ParameterFacSLEntityView>("51dc39c6-0ba9-426e-a17d-31a01a831d51","","",true, this);
 
            IDCommercialAgentClassificationDeskInvoice = RPSControlFactory.CreateRPSComboBox<ParameterFacSLEntityView>("9f9f7875-a0d5-429e-b3c3-adbc9f3a1c6e","","",false, this);
 
            ReplaceDeskInvoiceCommercialAgent = RPSControlFactory.CreateRPSCheckBox<ParameterFacSLEntityView>("5481b54f-1d43-4f4c-bad1-c7ee464b17a0","","",true, this);
 
            DeleteRestCommercialAgentDeskInvoice = RPSControlFactory.CreateRPSCheckBox<ParameterFacSLEntityView>("0bb952fe-5189-4a34-aa6b-7b99751d8d15","","",true, this);
 

        }
        public IRPSCheckbox<ParameterFacSLEntityView> OpenCashDaily { get; set; } 
        public IRPSComboBox<ParameterFacSLEntityView> IDCodingSerieAccountingTicket { get; set; } 
        public IRPSComboBox<ParameterFacSLEntityView> IDCodingSerieAccountingTicketB { get; set; } 
        public IRPSComboBox<ParameterFacSLEntityView> IDCommercialAgentClassificationTicket { get; set; } 
        public IRPSCheckbox<ParameterFacSLEntityView> ReplaceTicketsCommercialAgent { get; set; } 
        public IRPSCheckbox<ParameterFacSLEntityView> DeleteRestCommercialAgentTicket { get; set; } 
        public IRPSCheckbox<ParameterFacSLEntityView> GenerateReceivableFromAccountingTickets { get; set; } 
        public IRPSComboBox<ParameterFacSLEntityView> IDCommercialAgentClassificationDeskInvoice { get; set; } 
        public IRPSCheckbox<ParameterFacSLEntityView> ReplaceDeskInvoiceCommercialAgent { get; set; } 
        public IRPSCheckbox<ParameterFacSLEntityView> DeleteRestCommercialAgentDeskInvoice { get; set; } 
        public ParameterSalesDesk Screen { get; set; }
        public ParameterFacSLEntityView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}