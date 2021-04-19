    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.ReceivablePayable.PaymentStatus
{
    //RPS VERSION 1.0.0.0
    public partial class PaymentStatus:Screen
    {
        public PaymentStatus():base()
        {
            this.URL = "receivablepayable.paymentstatus";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            PaymentStatusCollectionView  = new PaymentStatusCollectionView(this); 
            PaymentStatusEntityView  = new PaymentStatusEntityView(this); 
            PaymentStatusCollectionView.InitializeControls(); 
            PaymentStatusEntityView.InitializeControls(); 
           
        }
      
            public PaymentStatusCollectionView PaymentStatusCollectionView {get; set; } 
            public PaymentStatusEntityView PaymentStatusEntityView {get; set; } 
    }
            
    public partial class PaymentStatusCollectionView : View
    {
        public PaymentStatusCollectionView(PaymentStatus screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            NewButton = RPSControlFactory.RPSNewButton<PaymentStatusCollectionView,PaymentStatusEntityView>( this,Screen.PaymentStatusEntityView);
 
            CollectionInit params_MainConsult = new CollectionInit(){IDDescriptor = "4d7c7f2c-040c-46f8-9cf1-11560110dfee",CSSSelectorDescriptor = "",XPathDescriptor = ""};
            MainConsult = RPSControlFactory.RPSCreateCollection<PaymentStatusCollectionView,PaymentStatusEntityView>( params_MainConsult,this,Screen.PaymentStatusEntityView);
 

        }
        public IRPSButton<PaymentStatusCollectionView,PaymentStatusEntityView> NewButton { get; set; } 
        public IRPSCollectionEditor<PaymentStatusCollectionView,PaymentStatusEntityView> MainConsult { get; set; } 
        public PaymentStatus Screen { get; set; }
        public PaymentStatusCollectionView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class PaymentStatusEntityView : View
    {
        public PaymentStatusEntityView(PaymentStatus screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            SaveButton = RPSControlFactory.RPSSaveButton<PaymentStatusEntityView>( this);
 
            DeleteButton = RPSControlFactory.RPSDeleteButton<PaymentStatusEntityView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<PaymentStatusEntityView,PaymentStatusCollectionView>( this,Screen.PaymentStatusCollectionView);
 
            BackButton = RPSControlFactory.RPSBackButton<PaymentStatusEntityView,PaymentStatusCollectionView>( this,Screen.PaymentStatusCollectionView);
 
            CodPaymentStatus = RPSControlFactory.CreateRPSTextBox<PaymentStatusEntityView>("5c8e143f-6c38-4d19-a2c4-c930cb864670","","",true, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<PaymentStatusEntityView>("0554a181-fe22-464a-b5d4-16019148e278","","",false, this);
 
            Pending = RPSControlFactory.CreateRPSCheckBox<PaymentStatusEntityView>("18e314e3-5a46-40bc-9f83-39d66b626af9","","",true, this);
 
            RiskCustomer = RPSControlFactory.CreateRPSCheckBox<PaymentStatusEntityView>("295a93cd-1438-4d44-b202-2ce3c8525e31","","",true, this);
 
            RiskBank = RPSControlFactory.CreateRPSCheckBox<PaymentStatusEntityView>("3b5a5ca1-364e-465b-b860-7c0555bcea67","","",true, this);
 
            Unpaid = RPSControlFactory.CreateRPSCheckBox<PaymentStatusEntityView>("bf6b5223-86dc-4c55-9c65-d97708f4b0e8","","",true, this);
 

        }
        public IRPSSaveButton<PaymentStatusEntityView> SaveButton { get; set; } 
        public IRPSButton<PaymentStatusEntityView> DeleteButton { get; set; } 
        public IRPSButton<PaymentStatusEntityView,PaymentStatusCollectionView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<PaymentStatusEntityView,PaymentStatusCollectionView> BackButton { get; set; } 
        public IRPSTextBox<PaymentStatusEntityView> CodPaymentStatus { get; set; } 
        public IRPSTextBox<PaymentStatusEntityView> Description { get; set; } 
        public IRPSCheckbox<PaymentStatusEntityView> Pending { get; set; } 
        public IRPSCheckbox<PaymentStatusEntityView> RiskCustomer { get; set; } 
        public IRPSCheckbox<PaymentStatusEntityView> RiskBank { get; set; } 
        public IRPSCheckbox<PaymentStatusEntityView> Unpaid { get; set; } 
        public PaymentStatus Screen { get; set; }
        public PaymentStatusEntityView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}