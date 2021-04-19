    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.Purchase.PaymentType
{
    //RPS VERSION 1.0.0.0
    public partial class PaymentType:Screen
    {
        public PaymentType():base()
        {
            this.URL = "purchase.paymenttype";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            PaymentTypeCollectionView  = new PaymentTypeCollectionView(this); 
            PaymentTypeEntityView  = new PaymentTypeEntityView(this); 
            PaymentTypeCollectionView.InitializeControls(); 
            PaymentTypeEntityView.InitializeControls(); 
           
        }
      
            public PaymentTypeCollectionView PaymentTypeCollectionView {get; set; } 
            public PaymentTypeEntityView PaymentTypeEntityView {get; set; } 
    }
            
    public partial class PaymentTypeCollectionView : View
    {
        public PaymentTypeCollectionView(PaymentType screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            NewButton = RPSControlFactory.RPSNewButton<PaymentTypeCollectionView,PaymentTypeEntityView>( this,Screen.PaymentTypeEntityView);
 
            CollectionInit params_MainConsult = new CollectionInit(){IDDescriptor = "9d393aa0-16a3-4c11-96a3-c652b055a16c",CSSSelectorDescriptor = "",XPathDescriptor = ""};
            MainConsult = RPSControlFactory.RPSCreateCollection<PaymentTypeCollectionView,PaymentTypeEntityView>( params_MainConsult,this,Screen.PaymentTypeEntityView);
 

        }
        public IRPSButton<PaymentTypeCollectionView,PaymentTypeEntityView> NewButton { get; set; } 
        public IRPSCollectionEditor<PaymentTypeCollectionView,PaymentTypeEntityView> MainConsult { get; set; } 
        public PaymentType Screen { get; set; }
        public PaymentTypeCollectionView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class PaymentTypeEntityView : View
    {
        public PaymentTypeEntityView(PaymentType screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            SaveButton = RPSControlFactory.RPSSaveButton<PaymentTypeEntityView>( this);
 
            DeleteButton = RPSControlFactory.RPSDeleteButton<PaymentTypeEntityView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<PaymentTypeEntityView,PaymentTypeCollectionView>( this,Screen.PaymentTypeCollectionView);
 
            BackButton = RPSControlFactory.RPSBackButton<PaymentTypeEntityView,PaymentTypeCollectionView>( this,Screen.PaymentTypeCollectionView);
 
            CodPaymentType = RPSControlFactory.CreateRPSTextBox<PaymentTypeEntityView>("f866c5a2-ebf9-4d13-acc6-fa3c40c839e1","","",true, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<PaymentTypeEntityView>("dea71574-b42c-42b8-93c3-e46edeb84821","","",false, this);
 
            Type = RPSControlFactory.CreateRPSEnumComboBox<PaymentTypeEntityView>("ab500c63-f60f-43b4-81de-c78be79548a9","","",true, this);
 
            PaidType = RPSControlFactory.CreateRPSEnumComboBox<PaymentTypeEntityView>("7187365f-7477-410b-8c51-34eca55ab515","","",true, this);
 
            Remittance = RPSControlFactory.CreateRPSCheckBox<PaymentTypeEntityView>("c34731f5-c136-4408-b732-ff29e3d7a4e6","","",true, this);
 
            CashCollector = RPSControlFactory.CreateRPSCheckBox<PaymentTypeEntityView>("2419ab02-b6eb-4901-b591-3744e8e24ace","","",true, this);
 

        }
        public IRPSSaveButton<PaymentTypeEntityView> SaveButton { get; set; } 
        public IRPSButton<PaymentTypeEntityView> DeleteButton { get; set; } 
        public IRPSButton<PaymentTypeEntityView,PaymentTypeCollectionView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<PaymentTypeEntityView,PaymentTypeCollectionView> BackButton { get; set; } 
        public IRPSTextBox<PaymentTypeEntityView> CodPaymentType { get; set; } 
        public IRPSTextBox<PaymentTypeEntityView> Description { get; set; } 
        public IRPSComboBox<PaymentTypeEntityView> Type { get; set; } 
        public IRPSComboBox<PaymentTypeEntityView> PaidType { get; set; } 
        public IRPSCheckbox<PaymentTypeEntityView> Remittance { get; set; } 
        public IRPSCheckbox<PaymentTypeEntityView> CashCollector { get; set; } 
        public PaymentType Screen { get; set; }
        public PaymentTypeEntityView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}