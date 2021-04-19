    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.General.DeliveryTerm
{
    //RPS VERSION 1.0.0.0
    public partial class DeliveryTerm:Screen
    {
        public DeliveryTerm():base()
        {
            this.URL = "general.deliveryterm";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            DeliveryTermCollectionView  = new DeliveryTermCollectionView(this); 
            DeliveryTermEntityView  = new DeliveryTermEntityView(this); 
            DeliveryTermCollectionView.InitializeControls(); 
            DeliveryTermEntityView.InitializeControls(); 
           
        }
      
            public DeliveryTermCollectionView DeliveryTermCollectionView {get; set; } 
            public DeliveryTermEntityView DeliveryTermEntityView {get; set; } 
    }
            
    public partial class DeliveryTermCollectionView : View
    {
        public DeliveryTermCollectionView(DeliveryTerm screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            NewButton = RPSControlFactory.RPSNewButton<DeliveryTermCollectionView,DeliveryTermEntityView>( this,Screen.DeliveryTermEntityView);
 
            CollectionInit params_MainConsult = new CollectionInit(){IDDescriptor = "6d5fd722-413f-49bc-8e55-98935d355869",CSSSelectorDescriptor = "",XPathDescriptor = ""};
            MainConsult = RPSControlFactory.RPSCreateCollection<DeliveryTermCollectionView,DeliveryTermEntityView>( params_MainConsult,this,Screen.DeliveryTermEntityView);
 

        }
        public IRPSButton<DeliveryTermCollectionView,DeliveryTermEntityView> NewButton { get; set; } 
        public IRPSCollectionEditor<DeliveryTermCollectionView,DeliveryTermEntityView> MainConsult { get; set; } 
        public DeliveryTerm Screen { get; set; }
        public DeliveryTermCollectionView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class DeliveryTermEntityView : View
    {
        public DeliveryTermEntityView(DeliveryTerm screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            SaveButton = RPSControlFactory.RPSSaveButton<DeliveryTermEntityView>( this);
 
            DeleteButton = RPSControlFactory.RPSDeleteButton<DeliveryTermEntityView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<DeliveryTermEntityView,DeliveryTermCollectionView>( this,Screen.DeliveryTermCollectionView);
 
            BackButton = RPSControlFactory.RPSBackButton<DeliveryTermEntityView,DeliveryTermCollectionView>( this,Screen.DeliveryTermCollectionView);
 
            CodDeliveryTerm = RPSControlFactory.CreateRPSTextBox<DeliveryTermEntityView>("8ed342bd-9151-4ffa-9c66-e7d85cdf3fd1","","",true, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<DeliveryTermEntityView>("b4f840da-7f5c-4447-9033-9f4edb18352b","","",false, this);
 
            CodIncoterm = RPSControlFactory.CreateRPSTextBox<DeliveryTermEntityView>("1b29f051-c1ab-43aa-9672-483f9fcd3cce","","",true, this);
 
            DeclarePlace = RPSControlFactory.CreateRPSTextBox<DeliveryTermEntityView>("c02dcba5-ecfb-4c7a-9c50-7fbb7fbde450","","",false, this);
 
            PercentPurchase = RPSControlFactory.CreateRPSFormattedTextBox<DeliveryTermEntityView>("bc7d3815-8921-4251-974c-74287933b4b0","","",true, this);
 
            BaseApplyPurchase = RPSControlFactory.CreateRPSEnumComboBox<DeliveryTermEntityView>("b5ca0985-3405-41bb-af10-a5e77794dd42","","",true, this);
 
            GoodsValuePurchase = RPSControlFactory.CreateRPSEnumComboBox<DeliveryTermEntityView>("f4892d25-78c2-42dd-9389-84e6c9026b6f","","",true, this);
 
            PercentSales = RPSControlFactory.CreateRPSFormattedTextBox<DeliveryTermEntityView>("2686c1d8-f0ca-49f0-9d64-804af0d6d116","","",true, this);
 
            BaseApplySales = RPSControlFactory.CreateRPSEnumComboBox<DeliveryTermEntityView>("ecc7fc16-84e1-4a87-b74e-b68e127deee1","","",true, this);
 
            GoodsValueSales = RPSControlFactory.CreateRPSEnumComboBox<DeliveryTermEntityView>("ce82add9-e175-4b87-b596-fc833393df15","","",true, this);
 

        }
        public IRPSSaveButton<DeliveryTermEntityView> SaveButton { get; set; } 
        public IRPSButton<DeliveryTermEntityView> DeleteButton { get; set; } 
        public IRPSButton<DeliveryTermEntityView,DeliveryTermCollectionView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<DeliveryTermEntityView,DeliveryTermCollectionView> BackButton { get; set; } 
        public IRPSTextBox<DeliveryTermEntityView> CodDeliveryTerm { get; set; } 
        public IRPSTextBox<DeliveryTermEntityView> Description { get; set; } 
        public IRPSTextBox<DeliveryTermEntityView> CodIncoterm { get; set; } 
        public IRPSTextBox<DeliveryTermEntityView> DeclarePlace { get; set; } 
        public IRPSTextBox<DeliveryTermEntityView> PercentPurchase { get; set; } 
        public IRPSComboBox<DeliveryTermEntityView> BaseApplyPurchase { get; set; } 
        public IRPSComboBox<DeliveryTermEntityView> GoodsValuePurchase { get; set; } 
        public IRPSTextBox<DeliveryTermEntityView> PercentSales { get; set; } 
        public IRPSComboBox<DeliveryTermEntityView> BaseApplySales { get; set; } 
        public IRPSComboBox<DeliveryTermEntityView> GoodsValueSales { get; set; } 
        public DeliveryTerm Screen { get; set; }
        public DeliveryTermEntityView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}