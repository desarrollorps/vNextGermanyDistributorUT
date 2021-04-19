    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.GeneralLedger.ThirdByAmountReport
{
    //RPS VERSION 1.0.0.0
    public partial class ThirdByAmountReport:Screen
    {
        public ThirdByAmountReport():base()
        {
            this.URL = "generalledger.thirdbyamountreport";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            ThirdByAmountReportView  = new ThirdByAmountReportView(this); 
            ReportLetterChildDialogView  = new ReportLetterChildDialogView(this); 
            ThirdByAmountReportView.InitializeControls(); 
            ReportLetterChildDialogView.InitializeControls(); 
           
        }
      
            public ThirdByAmountReportView ThirdByAmountReportView {get; set; } 
            public ReportLetterChildDialogView ReportLetterChildDialogView {get; set; } 
    }
            
    public partial class ThirdByAmountReportView : View
    {
        public ThirdByAmountReportView(ThirdByAmountReport screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            DateFrom = RPSControlFactory.CreateRPSTextBox<ThirdByAmountReportView>("0f3a4754-873a-452b-a090-e3814be6990f","","",true, this);
 
            DateTo = RPSControlFactory.CreateRPSTextBox<ThirdByAmountReportView>("74eead02-56ce-4b62-baea-9e7d1a4d6322","","",true, this);
 
            CheckCustomer = RPSControlFactory.CreateRPSCheckBox<ThirdByAmountReportView>("a38f3f31-ac5d-40a2-ac23-164b1786b157","","",false, this);
 
            CheckSupplier = RPSControlFactory.CreateRPSCheckBox<ThirdByAmountReportView>("446c0276-5d58-4cfc-818a-014d51e2b5bf","","",false, this);
 
            VATNumber = RPSControlFactory.CreateRPSOption<ThirdByAmountReportView>( "f32539e7-9304-457b-87ca-3377c7968871","","",this);
 
            Third = RPSControlFactory.CreateRPSOption<ThirdByAmountReportView>( "b859761d-3642-4209-8af6-9af9ad003210","","",this);
 
            WithoutFilter = RPSControlFactory.CreateRPSOption<ThirdByAmountReportView>( "0207a4ca-49da-41dc-ae49-86600ed616d8","","",this);
 
            TaxBase = RPSControlFactory.CreateRPSOption<ThirdByAmountReportView>( "ad4bd5e5-904e-4def-883a-d3107e5541a6","","",this);
 
            TotalAmount = RPSControlFactory.CreateRPSOption<ThirdByAmountReportView>( "05845802-d627-4e8a-a0cc-acc38e0dab2e","","",this);
 
            MinimumAmount = RPSControlFactory.CreateRPSFormattedTextBox<ThirdByAmountReportView>("ba968006-4e68-4d5f-aeb7-abf5300de318","","",false, this);
 
            VoucherTypeSales = RPSControlFactory.CreateRPSCollectionComboBox<ThirdByAmountReportView>("6ae20e4e-314f-4fb5-a96f-0f6acf343d89","","",false, this);
 
            VoucherTypePurchase = RPSControlFactory.CreateRPSCollectionComboBox<ThirdByAmountReportView>("c77201ba-eb9b-4eda-97aa-6af7265fca12","","",false, this);
 
            All = RPSControlFactory.CreateRPSOption<ThirdByAmountReportView>( "08bc0153-205b-4102-b635-caa9d0cb9288","","",this);
 
            UE = RPSControlFactory.CreateRPSOption<ThirdByAmountReportView>( "94573baf-4fdc-4ed9-a693-34ca676aaad9","","",this);
 
            MultipleSelection = RPSControlFactory.CreateRPSOption<ThirdByAmountReportView>( "f80339e3-6e35-4225-b31d-3249e1f87bc4","","",this);
 
            Country = RPSControlFactory.CreateRPSCollectionComboBox<ThirdByAmountReportView>("17af0881-0bfa-485c-b685-3fd01c2f9190","","",false, this);
 
            Customer = RPSControlFactory.CreateRPSCollectionComboBox<ThirdByAmountReportView>("f0c386d5-ba5f-42c1-9e4c-258457aa3421","","",false, this);
 
            Supplier = RPSControlFactory.CreateRPSCollectionComboBox<ThirdByAmountReportView>("ed782689-bd37-4eb0-a3a2-8a6acea3d342","","",false, this);
 
            PrintCommand = RPSControlFactory.CreateRPSButton<ThirdByAmountReportView>( "9b1b1235-411e-4ec4-88e2-09756b96c0b7","","",this);
 
            ReportLetterChildNavigationCommand = RPSControlFactory.CreateRPSButtonToView<ThirdByAmountReportView,ReportLetterChildDialogView>("20df48f2-605b-4ea6-8010-e398f037d2f6","","", this,Screen.ReportLetterChildDialogView);
 

        }
        public IRPSTextBox<ThirdByAmountReportView> DateFrom { get; set; } 
        public IRPSTextBox<ThirdByAmountReportView> DateTo { get; set; } 
        public IRPSCheckbox<ThirdByAmountReportView> CheckCustomer { get; set; } 
        public IRPSCheckbox<ThirdByAmountReportView> CheckSupplier { get; set; } 
        public IRPSOption<ThirdByAmountReportView> VATNumber { get; set; } 
        public IRPSOption<ThirdByAmountReportView> Third { get; set; } 
        public IRPSOption<ThirdByAmountReportView> WithoutFilter { get; set; } 
        public IRPSOption<ThirdByAmountReportView> TaxBase { get; set; } 
        public IRPSOption<ThirdByAmountReportView> TotalAmount { get; set; } 
        public IRPSTextBox<ThirdByAmountReportView> MinimumAmount { get; set; } 
        public IRPSCollectionComboBox<ThirdByAmountReportView> VoucherTypeSales { get; set; } 
        public IRPSCollectionComboBox<ThirdByAmountReportView> VoucherTypePurchase { get; set; } 
        public IRPSOption<ThirdByAmountReportView> All { get; set; } 
        public IRPSOption<ThirdByAmountReportView> UE { get; set; } 
        public IRPSOption<ThirdByAmountReportView> MultipleSelection { get; set; } 
        public IRPSCollectionComboBox<ThirdByAmountReportView> Country { get; set; } 
        public IRPSCollectionComboBox<ThirdByAmountReportView> Customer { get; set; } 
        public IRPSCollectionComboBox<ThirdByAmountReportView> Supplier { get; set; } 
        public IRPSButton<ThirdByAmountReportView> PrintCommand { get; set; } 
        public IRPSButton<ThirdByAmountReportView,ReportLetterChildDialogView> ReportLetterChildNavigationCommand { get; set; } 
        public ThirdByAmountReport Screen { get; set; }
        public ThirdByAmountReportView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class ReportLetterChildDialogView : View
    {
        public ReportLetterChildDialogView(ThirdByAmountReport screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            Report = RPSControlFactory.CreateRPSEnumComboBox<ReportLetterChildDialogView>("1a7a80f0-ebc8-48f1-8301-b71b183f876e","","",false, this);
 
            ThirdLanguage = RPSControlFactory.CreateRPSOption<ReportLetterChildDialogView>( "850801d8-299b-4640-b170-a21cf8098ed8","","",this);
 
            OtherLanguage = RPSControlFactory.CreateRPSOption<ReportLetterChildDialogView>( "66e2fc7b-a1b7-45d4-8793-2591e9976671","","",this);
 
            Language = RPSControlFactory.CreateRPSComboBox<ReportLetterChildDialogView>("8b2a8d4d-0dc0-4b97-b5ae-ed614efd87b9","","",false, this);
 
            MyEmail = RPSControlFactory.CreateRPSCheckBox<ReportLetterChildDialogView>("3ff46904-b9fa-4227-9805-2290dde9831d","","",false, this);
 
            PrintCommand = RPSControlFactory.CreateRPSButton<ReportLetterChildDialogView>( "cb4f3c1b-8b03-492d-ba2c-c00411d607f7","","",this);
 
            SendCommand = RPSControlFactory.CreateRPSButton<ReportLetterChildDialogView>( "a11c7af8-c0dd-432e-acc4-2985e18c9fcd","","",this);
 
            CancelCommand = RPSControlFactory.CreateRPSButton<ReportLetterChildDialogView>( "c8fe7231-7025-4a4a-8c1a-a4e55460372c","","",this);
 

        }
        public IRPSComboBox<ReportLetterChildDialogView> Report { get; set; } 
        public IRPSOption<ReportLetterChildDialogView> ThirdLanguage { get; set; } 
        public IRPSOption<ReportLetterChildDialogView> OtherLanguage { get; set; } 
        public IRPSComboBox<ReportLetterChildDialogView> Language { get; set; } 
        public IRPSCheckbox<ReportLetterChildDialogView> MyEmail { get; set; } 
        public IRPSButton<ReportLetterChildDialogView> PrintCommand { get; set; } 
        public IRPSButton<ReportLetterChildDialogView> SendCommand { get; set; } 
        public IRPSButton<ReportLetterChildDialogView> CancelCommand { get; set; } 
        public ThirdByAmountReport Screen { get; set; }
        public ReportLetterChildDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}