    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.GeneralLedger.BankExchangeRateDifferences
{
    //RPS VERSION 1.0.0.0
    public partial class BankExchangeRateDifferences:Screen
    {
        public BankExchangeRateDifferences():base()
        {
            this.URL = "generalledger.bankexchangeratedifferences";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            BankExchangeRateDifferencesView  = new BankExchangeRateDifferencesView(this); 
            BankExchangeRateDifferencesView.InitializeControls(); 
           
        }
      
            public BankExchangeRateDifferencesView BankExchangeRateDifferencesView {get; set; } 
    }
            
    public partial class BankExchangeRateDifferencesView : View
    {
        public BankExchangeRateDifferencesView(BankExchangeRateDifferences screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            BankAccountCompany = RPSControlFactory.CreateRPSComboBox<BankExchangeRateDifferencesView>("71bfd7a4-b46d-450a-a4aa-e0f71e2b0f40","","",false, this);
 
            Currency = RPSControlFactory.CreateRPSComboBox<BankExchangeRateDifferencesView>("a1a0f25e-aed2-471c-a9a9-f532e5c06fde","","",false, this);
 
            DateFrom = RPSControlFactory.CreateRPSTextBox<BankExchangeRateDifferencesView>("4242ff38-8628-448f-9fe6-b81389443214","","",false, this);
 
            ChangeFrom = RPSControlFactory.CreateRPSFormattedTextBox<BankExchangeRateDifferencesView>("535825aa-e0ac-4457-87cd-70763186b79d","","",false, this);
 
            DateTo = RPSControlFactory.CreateRPSTextBox<BankExchangeRateDifferencesView>("0478373d-603c-4174-a9d1-e61d1dca4138","","",false, this);
 
            ChangeTo = RPSControlFactory.CreateRPSFormattedTextBox<BankExchangeRateDifferencesView>("b0e5222c-6976-4157-a08a-be246427dee9","","",false, this);
 
            InitialCurrencyAmount = RPSControlFactory.CreateRPSFormattedTextBox<BankExchangeRateDifferencesView>("9342ef8a-1e30-47a3-bb78-5131c127c974","","",false, this);
 
            InitialLocalAmount = RPSControlFactory.CreateRPSFormattedTextBox<BankExchangeRateDifferencesView>("032360e9-b0db-40fb-b87c-5f2dd0d6bacb","","",false, this);
 
            ChangeFrom1 = RPSControlFactory.CreateRPSFormattedTextBox<BankExchangeRateDifferencesView>("62a14121-1539-4f07-b7fe-7ad75a5fb935","","",false, this);
 
            RecordsCurrencyAmount = RPSControlFactory.CreateRPSFormattedTextBox<BankExchangeRateDifferencesView>("d592f483-cd68-4ae8-8284-39754f950b1c","","",false, this);
 
            RecordsLocalAmount = RPSControlFactory.CreateRPSFormattedTextBox<BankExchangeRateDifferencesView>("8023247d-ec75-42dc-9c3f-78df33e518f9","","",false, this);
 
            FinalCurrencyAmount = RPSControlFactory.CreateRPSFormattedTextBox<BankExchangeRateDifferencesView>("7f33abca-9ce6-4ce9-882d-c745d2589c8b","","",false, this);
 
            FinalLocalAmount = RPSControlFactory.CreateRPSFormattedTextBox<BankExchangeRateDifferencesView>("7feb45a5-5051-4b79-95da-2e380a583ed8","","",false, this);
 
            AverageChange = RPSControlFactory.CreateRPSFormattedTextBox<BankExchangeRateDifferencesView>("914e8169-1cc4-4ea3-bc33-a758ec297bc7","","",false, this);
 
            TargetLocalAmount = RPSControlFactory.CreateRPSFormattedTextBox<BankExchangeRateDifferencesView>("332aad01-8f0a-4c2d-8b25-9a5c487a188e","","",false, this);
 
            ChangeTo1 = RPSControlFactory.CreateRPSFormattedTextBox<BankExchangeRateDifferencesView>("4961f2a3-bf70-4263-af6d-8897282c520f","","",false, this);
 
            FinalCurrencyAmount1 = RPSControlFactory.CreateRPSFormattedTextBox<BankExchangeRateDifferencesView>("e682dbe1-7e70-40d2-a62a-5eb6aed94cb4","","",false, this);
 
            FinalLocalAmount1 = RPSControlFactory.CreateRPSFormattedTextBox<BankExchangeRateDifferencesView>("d85d890e-cf23-4e98-aedc-1846bf4d2605","","",false, this);
 
            ChangeTo2 = RPSControlFactory.CreateRPSFormattedTextBox<BankExchangeRateDifferencesView>("f4de21fa-c81d-430c-a96b-f7f2303727b2","","",false, this);
 
            DifferenceAmount = RPSControlFactory.CreateRPSFormattedTextBox<BankExchangeRateDifferencesView>("926c3c59-554d-4cd1-b638-eeb45d42995f","","",false, this);
 
            ChangeDifference = RPSControlFactory.CreateRPSFormattedTextBox<BankExchangeRateDifferencesView>("36b16b00-11af-429f-a908-7ced2765b12e","","",false, this);
 
            MssError = RPSControlFactory.CreateRPSTextBox<BankExchangeRateDifferencesView>("4a66f53c-3720-4031-a08a-e29f49fdc9d4","","",false, this);
 
            LossAccount = RPSControlFactory.CreateRPSComboBox<BankExchangeRateDifferencesView>("0befd07c-8023-470d-9b70-edad4b6ab175","","",false, this);
 
            ProfitAccount = RPSControlFactory.CreateRPSComboBox<BankExchangeRateDifferencesView>("95d2705c-c7f4-488f-9b34-a7c6ce5d2f60","","",false, this);
 
            VoucherType = RPSControlFactory.CreateRPSComboBox<BankExchangeRateDifferencesView>("285e95e7-f2b1-416b-9793-571fe48b6e93","","",false, this);
 
            VoucherSeriesBook = RPSControlFactory.CreateRPSComboBox<BankExchangeRateDifferencesView>("dd715fd6-74ac-4996-9859-951c5e70a08e","","",false, this);
 
            AccConcept = RPSControlFactory.CreateRPSComboBox<BankExchangeRateDifferencesView>("a228030b-4b92-458e-a3a6-07e18ae49a6f","","",false, this);
 
            Extension = RPSControlFactory.CreateRPSTextBox<BankExchangeRateDifferencesView>("b445a0d8-f656-4dce-8c3c-f87960ae37bb","","",false, this);
 
            VoucherDate = RPSControlFactory.CreateRPSTextBox<BankExchangeRateDifferencesView>("01a2d97a-4e12-4c74-be22-8f14d2744da3","","",false, this);
 
            CheckReverseVoucher = RPSControlFactory.CreateRPSCheckBox<BankExchangeRateDifferencesView>("20d34422-3ee8-4f24-baec-a52a80948198","","",false, this);
 
            ReverseDate = RPSControlFactory.CreateRPSTextBox<BankExchangeRateDifferencesView>("bd54a7b7-3bc8-4887-be6d-ea4624251ac5","","",false, this);
 

        }
        public IRPSComboBox<BankExchangeRateDifferencesView> BankAccountCompany { get; set; } 
        public IRPSComboBox<BankExchangeRateDifferencesView> Currency { get; set; } 
        public IRPSTextBox<BankExchangeRateDifferencesView> DateFrom { get; set; } 
        public IRPSTextBox<BankExchangeRateDifferencesView> ChangeFrom { get; set; } 
        public IRPSTextBox<BankExchangeRateDifferencesView> DateTo { get; set; } 
        public IRPSTextBox<BankExchangeRateDifferencesView> ChangeTo { get; set; } 
        public IRPSTextBox<BankExchangeRateDifferencesView> InitialCurrencyAmount { get; set; } 
        public IRPSTextBox<BankExchangeRateDifferencesView> InitialLocalAmount { get; set; } 
        public IRPSTextBox<BankExchangeRateDifferencesView> ChangeFrom1 { get; set; } 
        public IRPSTextBox<BankExchangeRateDifferencesView> RecordsCurrencyAmount { get; set; } 
        public IRPSTextBox<BankExchangeRateDifferencesView> RecordsLocalAmount { get; set; } 
        public IRPSTextBox<BankExchangeRateDifferencesView> FinalCurrencyAmount { get; set; } 
        public IRPSTextBox<BankExchangeRateDifferencesView> FinalLocalAmount { get; set; } 
        public IRPSTextBox<BankExchangeRateDifferencesView> AverageChange { get; set; } 
        public IRPSTextBox<BankExchangeRateDifferencesView> TargetLocalAmount { get; set; } 
        public IRPSTextBox<BankExchangeRateDifferencesView> ChangeTo1 { get; set; } 
        public IRPSTextBox<BankExchangeRateDifferencesView> FinalCurrencyAmount1 { get; set; } 
        public IRPSTextBox<BankExchangeRateDifferencesView> FinalLocalAmount1 { get; set; } 
        public IRPSTextBox<BankExchangeRateDifferencesView> ChangeTo2 { get; set; } 
        public IRPSTextBox<BankExchangeRateDifferencesView> DifferenceAmount { get; set; } 
        public IRPSTextBox<BankExchangeRateDifferencesView> ChangeDifference { get; set; } 
        public IRPSTextBox<BankExchangeRateDifferencesView> MssError { get; set; } 
        public IRPSComboBox<BankExchangeRateDifferencesView> LossAccount { get; set; } 
        public IRPSComboBox<BankExchangeRateDifferencesView> ProfitAccount { get; set; } 
        public IRPSComboBox<BankExchangeRateDifferencesView> VoucherType { get; set; } 
        public IRPSComboBox<BankExchangeRateDifferencesView> VoucherSeriesBook { get; set; } 
        public IRPSComboBox<BankExchangeRateDifferencesView> AccConcept { get; set; } 
        public IRPSTextBox<BankExchangeRateDifferencesView> Extension { get; set; } 
        public IRPSTextBox<BankExchangeRateDifferencesView> VoucherDate { get; set; } 
        public IRPSCheckbox<BankExchangeRateDifferencesView> CheckReverseVoucher { get; set; } 
        public IRPSTextBox<BankExchangeRateDifferencesView> ReverseDate { get; set; } 
        public BankExchangeRateDifferences Screen { get; set; }
        public BankExchangeRateDifferencesView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}