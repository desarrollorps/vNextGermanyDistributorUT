    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.GeneralLedger.VATBalance
{
    //RPS VERSION 1.0.0.0
    public partial class VATBalance:Screen
    {
        public VATBalance():base()
        {
            this.URL = "generalledger.vatbalance";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            VATBalanceQueryView  = new VATBalanceQueryView(this); 
            InsertAccTransactionChildDialogView  = new InsertAccTransactionChildDialogView(this); 
            VATBalanceQueryView.InitializeControls(); 
            InsertAccTransactionChildDialogView.InitializeControls(); 
           
        }
      
            public VATBalanceQueryView VATBalanceQueryView {get; set; } 
            public InsertAccTransactionChildDialogView InsertAccTransactionChildDialogView {get; set; } 
    }
            
    public partial class VATBalanceQueryView : View
    {
        public VATBalanceQueryView(VATBalance screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            DateFrom = RPSControlFactory.CreateRPSTextBox<VATBalanceQueryView>("4a40d1c6-9962-4b03-b195-72f932d83d24","","",false, this);
 
            DateTo = RPSControlFactory.CreateRPSTextBox<VATBalanceQueryView>("8da090bb-36cd-418a-80b1-901d66dda959","","",false, this);
 
            IDAccountList = RPSControlFactory.CreateRPSCollectionComboBox<VATBalanceQueryView>("13785df7-442b-402e-a7f2-960bd5a3fa7b","","",false, this);
 
            IDAccountGroupList = RPSControlFactory.CreateRPSCollectionComboBox<VATBalanceQueryView>("d9060bef-6138-4b52-aef0-cd54ec0acc24","","",false, this);
 
            IDAccountClusterList = RPSControlFactory.CreateRPSCollectionComboBox<VATBalanceQueryView>("10063bb5-8ed5-4441-a9d0-53ea1ef5f48f","","",false, this);
 
            DiferenceToPay = RPSControlFactory.CreateRPSFormattedTextBox<VATBalanceQueryView>("3fcb2938-a8a4-4c1e-a51f-def69dc9c28a","","",false, this);
 
            DiferenceToReceive = RPSControlFactory.CreateRPSFormattedTextBox<VATBalanceQueryView>("03619382-f82f-4e6a-bfa7-d47834c9ef4c","","",false, this);
 
            InsertAccTransactionChildNavigationCommandButton = RPSControlFactory.CreateRPSButtonToView<VATBalanceQueryView,InsertAccTransactionChildDialogView>("bf0e328e-0113-482c-9f08-5da3eef8fc00","","", this,Screen.InsertAccTransactionChildDialogView);
 
            CollectionInit params_VATBalance = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="f458f938-9d2e-4fda-8ac6-8e559f7a57f9",CSSSelectorGrid="",XPathGrid=""};
            VATBalance = RPSControlFactory.RPSCreateCollectionWithGrid<VATBalanceCollectionEditor<VATBalanceQueryView,InsertAccTransactionChildDialogView>,VATBalanceQueryView,InsertAccTransactionChildDialogView>( params_VATBalance,this,Screen.InsertAccTransactionChildDialogView);
 

        }
        public IRPSTextBox<VATBalanceQueryView> DateFrom { get; set; } 
        public IRPSTextBox<VATBalanceQueryView> DateTo { get; set; } 
        public IRPSCollectionComboBox<VATBalanceQueryView> IDAccountList { get; set; } 
        public IRPSCollectionComboBox<VATBalanceQueryView> IDAccountGroupList { get; set; } 
        public IRPSCollectionComboBox<VATBalanceQueryView> IDAccountClusterList { get; set; } 
        public IRPSTextBox<VATBalanceQueryView> DiferenceToPay { get; set; } 
        public IRPSTextBox<VATBalanceQueryView> DiferenceToReceive { get; set; } 
        public IRPSButton<VATBalanceQueryView,InsertAccTransactionChildDialogView> InsertAccTransactionChildNavigationCommandButton { get; set; } 
        public VATBalanceCollectionEditor<VATBalanceQueryView,InsertAccTransactionChildDialogView> VATBalance { get; set; } 
        public VATBalance Screen { get; set; }
        public VATBalanceQueryView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class VATBalanceCollectionEditor<VATBalanceQueryView,InsertAccTransactionChildDialogView>:RPSCollectionEditor<VATBalanceQueryView,InsertAccTransactionChildDialogView> where VATBalanceQueryView : class, IView where InsertAccTransactionChildDialogView : class, IView
    {
        public  VATBalanceGridView<VATBalanceQueryView,InsertAccTransactionChildDialogView> GridView {get;set;}
    }
    public partial class VATBalanceGridView <VATBalanceQueryView,InsertAccTransactionChildDialogView> :  RPSGridView<VATBalanceQueryView,InsertAccTransactionChildDialogView> where VATBalanceQueryView : class, IView where InsertAccTransactionChildDialogView : class, IView
    {
        public VATBalanceGridView(VATBalanceQueryView currentView,InsertAccTransactionChildDialogView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {

        }
                     
    }
 
    }
  
            
    public partial class InsertAccTransactionChildDialogView : View
    {
        public InsertAccTransactionChildDialogView(VATBalance screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            Difference = RPSControlFactory.CreateRPSFormattedTextBox<InsertAccTransactionChildDialogView>("9f7b8d1f-cf0a-4928-a42d-e1ab42eca7ae","","",false, this);
 
            AccountingDate = RPSControlFactory.CreateRPSTextBox<InsertAccTransactionChildDialogView>("c0f44468-d532-4ef7-8ae4-91453d6dc6b8","","",true, this);
 
            IDAccount = RPSControlFactory.CreateRPSComboBox<InsertAccTransactionChildDialogView>("d62f567f-ec1e-42a6-b546-9ae2aee745f5","","",true, this);
 
            IDVoucherType = RPSControlFactory.CreateRPSComboBox<InsertAccTransactionChildDialogView>("a1322f89-07cc-4fba-8e66-914692fcce89","","",true, this);
 
            IDVoucherSeriesBook = RPSControlFactory.CreateRPSComboBox<InsertAccTransactionChildDialogView>("5dd5b5aa-5042-4aec-b72f-7e7a59845178","","",true, this);
 
            IDAccConcept = RPSControlFactory.CreateRPSComboBox<InsertAccTransactionChildDialogView>("470f7b97-01b5-41ba-bf53-5896afc62c0f","","",false, this);
 

        }
        public IRPSTextBox<InsertAccTransactionChildDialogView> Difference { get; set; } 
        public IRPSTextBox<InsertAccTransactionChildDialogView> AccountingDate { get; set; } 
        public IRPSComboBox<InsertAccTransactionChildDialogView> IDAccount { get; set; } 
        public IRPSComboBox<InsertAccTransactionChildDialogView> IDVoucherType { get; set; } 
        public IRPSComboBox<InsertAccTransactionChildDialogView> IDVoucherSeriesBook { get; set; } 
        public IRPSComboBox<InsertAccTransactionChildDialogView> IDAccConcept { get; set; } 
        public VATBalance Screen { get; set; }
        public InsertAccTransactionChildDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}