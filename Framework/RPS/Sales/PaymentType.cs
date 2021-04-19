    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.Sales.PaymentType
{
    //RPS VERSION 1.0.0.0
    public partial class PaymentType:Screen
    {
        public PaymentType():base()
        {
            this.URL = "sales.paymenttype";
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
 
            CollectionInit params_MainConsult = new CollectionInit(){IDDescriptor = "a2dc3553-47aa-42e1-8f48-8e22b7173b8c",CSSSelectorDescriptor = "",XPathDescriptor = ""};
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
 
            CodPaymentType = RPSControlFactory.CreateRPSTextBox<PaymentTypeEntityView>("ffa34b69-34e6-4a37-b9e7-0651df70d477","","",true, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<PaymentTypeEntityView>("1ada1f3a-28db-494b-987a-a26bcc6f592a","","",false, this);
 
            Type = RPSControlFactory.CreateRPSEnumComboBox<PaymentTypeEntityView>("6d32914b-096f-4fbc-a008-3b920144408a","","",true, this);
 
            PaidType = RPSControlFactory.CreateRPSEnumComboBox<PaymentTypeEntityView>("5f100ec8-ad6a-41dc-9410-5bd01c4f2c03","","",true, this);
 
            Remittance = RPSControlFactory.CreateRPSCheckBox<PaymentTypeEntityView>("32f98f96-518d-4ef3-beb0-c7af39e6c739","","",true, this);
 
            CashCollector = RPSControlFactory.CreateRPSCheckBox<PaymentTypeEntityView>("63aa4a5a-8fae-468c-a1de-1092d277a9f9","","",true, this);
 

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