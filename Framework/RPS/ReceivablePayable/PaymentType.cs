    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.ReceivablePayable.PaymentType
{
    //RPS VERSION 1.0.0.0
    public partial class PaymentType:Screen
    {
        public PaymentType():base()
        {
            this.URL = "receivablepayable.paymenttype";
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
 
            CollectionInit params_MainConsult = new CollectionInit(){IDDescriptor = "7c81c16c-af45-43cb-9051-cd660f28ccd4",CSSSelectorDescriptor = "",XPathDescriptor = ""};
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
 
            CodPaymentType = RPSControlFactory.CreateRPSTextBox<PaymentTypeEntityView>("72462225-dab1-48e1-a85e-1c2f177508dd","","",true, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<PaymentTypeEntityView>("d38f6c0c-f6fd-4045-a194-2d77a88e1211","","",false, this);
 
            Type = RPSControlFactory.CreateRPSEnumComboBox<PaymentTypeEntityView>("ca7eb30a-e1c3-475b-81a7-d20349a33ddf","","",true, this);
 
            Remittance = RPSControlFactory.CreateRPSCheckBox<PaymentTypeEntityView>("1f3ed598-0676-42f9-89f8-a2b74297de05","","",true, this);
 
            CashCollector = RPSControlFactory.CreateRPSCheckBox<PaymentTypeEntityView>("ca4fa590-e67b-4693-ac3d-44a66be61488","","",true, this);
 
            PaidType = RPSControlFactory.CreateRPSEnumComboBox<PaymentTypeEntityView>("a258ab80-182b-4a27-b93d-35f0a478edf6","","",true, this);
 

        }
        public IRPSSaveButton<PaymentTypeEntityView> SaveButton { get; set; } 
        public IRPSButton<PaymentTypeEntityView> DeleteButton { get; set; } 
        public IRPSButton<PaymentTypeEntityView,PaymentTypeCollectionView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<PaymentTypeEntityView,PaymentTypeCollectionView> BackButton { get; set; } 
        public IRPSTextBox<PaymentTypeEntityView> CodPaymentType { get; set; } 
        public IRPSTextBox<PaymentTypeEntityView> Description { get; set; } 
        public IRPSComboBox<PaymentTypeEntityView> Type { get; set; } 
        public IRPSCheckbox<PaymentTypeEntityView> Remittance { get; set; } 
        public IRPSCheckbox<PaymentTypeEntityView> CashCollector { get; set; } 
        public IRPSComboBox<PaymentTypeEntityView> PaidType { get; set; } 
        public PaymentType Screen { get; set; }
        public PaymentTypeEntityView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}