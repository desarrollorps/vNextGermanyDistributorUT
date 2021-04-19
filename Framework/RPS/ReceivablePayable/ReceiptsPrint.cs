    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.ReceivablePayable.ReceiptsPrint
{
    //RPS VERSION 1.0.0.0
    public partial class ReceiptsPrint:Screen
    {
        public ReceiptsPrint():base()
        {
            this.URL = "receivablepayable.receiptsprint";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            ReceiptsPrintView  = new ReceiptsPrintView(this); 
            ReceiptsPrintView.InitializeControls(); 
           
        }
      
            public ReceiptsPrintView ReceiptsPrintView {get; set; } 
    }
            
    public partial class ReceiptsPrintView : View
    {
        public ReceiptsPrintView(ReceiptsPrint screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            IDCashCollectorList = RPSControlFactory.CreateRPSCollectionComboBox<ReceiptsPrintView>("a4188ee5-1cb0-4390-acd6-9e9df8ad5e1c","","",false, this);
 
            bExcludeFinal = RPSControlFactory.CreateRPSCheckBox<ReceiptsPrintView>("bd541d7c-d47f-447d-9c24-86a0d112dd01","","",false, this);
 
            bOnlySentDrafts = RPSControlFactory.CreateRPSCheckBox<ReceiptsPrintView>("34042fe0-ec91-42ab-aec1-917d3e8e3d2c","","",false, this);
 
            SentDateFrom = RPSControlFactory.CreateRPSTextBox<ReceiptsPrintView>("a3faa88d-edce-43e9-9d9a-236900bbce61","","",false, this);
 
            SentDateTo = RPSControlFactory.CreateRPSTextBox<ReceiptsPrintView>("a2a42019-abcb-4ce5-ae2c-efcd75891bc5","","",false, this);
 
            bFilterBySentNumber = RPSControlFactory.CreateRPSCheckBox<ReceiptsPrintView>("ba76b4cb-e1b9-48ce-93f1-ccb23af43854","","",false, this);
 
            SentNumberFrom = RPSControlFactory.CreateRPSFormattedTextBox<ReceiptsPrintView>("2296a585-cd16-43bd-b317-d8c3f1d0c791","","",false, this);
 
            SentNumberTo = RPSControlFactory.CreateRPSFormattedTextBox<ReceiptsPrintView>("a3c3b526-f501-437f-abc9-e1293faac157","","",false, this);
 
            PaymentCity = RPSControlFactory.CreateRPSTextBox<ReceiptsPrintView>("8c59cf6b-85c7-4881-9f7c-5979da766f28","","",true, this);
 
            PaymentDate = RPSControlFactory.CreateRPSTextBox<ReceiptsPrintView>("57ffe179-829f-4355-ac4a-249d904745ae","","",true, this);
 
            CodReport = RPSControlFactory.CreateRPSEnumComboBox<ReceiptsPrintView>("f23894b0-c0a8-4401-91cd-67e47d008cb8","","",false, this);
 
            MyEmail = RPSControlFactory.CreateRPSCheckBox<ReceiptsPrintView>("78106166-435f-45cb-b29e-f4d1ee539114","","",false, this);
 
            ReportCommandButton = RPSControlFactory.CreateRPSButton<ReceiptsPrintView>( "dd7159f0-dd4e-4858-920b-76995cec6961","","",this);
 
            ExecuteReceiptsReportByEmailButton = RPSControlFactory.CreateRPSButton<ReceiptsPrintView>( "f6df8aad-9a75-4eeb-bad4-3bfe3cad7ebb","","",this);
 

        }
        public IRPSCollectionComboBox<ReceiptsPrintView> IDCashCollectorList { get; set; } 
        public IRPSCheckbox<ReceiptsPrintView> bExcludeFinal { get; set; } 
        public IRPSCheckbox<ReceiptsPrintView> bOnlySentDrafts { get; set; } 
        public IRPSTextBox<ReceiptsPrintView> SentDateFrom { get; set; } 
        public IRPSTextBox<ReceiptsPrintView> SentDateTo { get; set; } 
        public IRPSCheckbox<ReceiptsPrintView> bFilterBySentNumber { get; set; } 
        public IRPSTextBox<ReceiptsPrintView> SentNumberFrom { get; set; } 
        public IRPSTextBox<ReceiptsPrintView> SentNumberTo { get; set; } 
        public IRPSTextBox<ReceiptsPrintView> PaymentCity { get; set; } 
        public IRPSTextBox<ReceiptsPrintView> PaymentDate { get; set; } 
        public IRPSComboBox<ReceiptsPrintView> CodReport { get; set; } 
        public IRPSCheckbox<ReceiptsPrintView> MyEmail { get; set; } 
        public IRPSButton<ReceiptsPrintView> ReportCommandButton { get; set; } 
        public IRPSButton<ReceiptsPrintView> ExecuteReceiptsReportByEmailButton { get; set; } 
        public ReceiptsPrint Screen { get; set; }
        public ReceiptsPrintView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}