    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.Sales.CustomerCommissionGroupSL
{
    //RPS VERSION 1.0.0.0
    public partial class CustomerCommissionGroupSL:Screen
    {
        public CustomerCommissionGroupSL():base()
        {
            this.URL = "sales.customercommissiongroupsl";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            CustomerCommissionGroupSLCollectionView  = new CustomerCommissionGroupSLCollectionView(this); 
            CustomerCommissionGroupSLEntityView  = new CustomerCommissionGroupSLEntityView(this); 
            CustomerCommissionGroupSLCollectionView.InitializeControls(); 
            CustomerCommissionGroupSLEntityView.InitializeControls(); 
           
        }
      
            public CustomerCommissionGroupSLCollectionView CustomerCommissionGroupSLCollectionView {get; set; } 
            public CustomerCommissionGroupSLEntityView CustomerCommissionGroupSLEntityView {get; set; } 
    }
            
    public partial class CustomerCommissionGroupSLCollectionView : View
    {
        public CustomerCommissionGroupSLCollectionView(CustomerCommissionGroupSL screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            NewButton = RPSControlFactory.RPSNewButton<CustomerCommissionGroupSLCollectionView,CustomerCommissionGroupSLEntityView>( this,Screen.CustomerCommissionGroupSLEntityView);
 
            CollectionInit params_MainConsult = new CollectionInit(){IDDescriptor = "780741e5-8802-41a4-a799-fc7497e4044d",CSSSelectorDescriptor = "",XPathDescriptor = ""};
            MainConsult = RPSControlFactory.RPSCreateCollection<CustomerCommissionGroupSLCollectionView,CustomerCommissionGroupSLEntityView>( params_MainConsult,this,Screen.CustomerCommissionGroupSLEntityView);
 

        }
        public IRPSButton<CustomerCommissionGroupSLCollectionView,CustomerCommissionGroupSLEntityView> NewButton { get; set; } 
        public IRPSCollectionEditor<CustomerCommissionGroupSLCollectionView,CustomerCommissionGroupSLEntityView> MainConsult { get; set; } 
        public CustomerCommissionGroupSL Screen { get; set; }
        public CustomerCommissionGroupSLCollectionView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class CustomerCommissionGroupSLEntityView : View
    {
        public CustomerCommissionGroupSLEntityView(CustomerCommissionGroupSL screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            SaveButton = RPSControlFactory.RPSSaveButton<CustomerCommissionGroupSLEntityView>( this);
 
            DeleteButton = RPSControlFactory.RPSDeleteButton<CustomerCommissionGroupSLEntityView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<CustomerCommissionGroupSLEntityView,CustomerCommissionGroupSLCollectionView>( this,Screen.CustomerCommissionGroupSLCollectionView);
 
            BackButton = RPSControlFactory.RPSBackButton<CustomerCommissionGroupSLEntityView,CustomerCommissionGroupSLCollectionView>( this,Screen.CustomerCommissionGroupSLCollectionView);
 
            CodCustomerCommissionGroup = RPSControlFactory.CreateRPSTextBox<CustomerCommissionGroupSLEntityView>("7b725d45-3b23-4016-a720-ec7c73bafda0","","",true, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<CustomerCommissionGroupSLEntityView>("0eb7c60a-7b05-44df-bf5f-42401bf9ce83","","",false, this);
 

        }
        public IRPSSaveButton<CustomerCommissionGroupSLEntityView> SaveButton { get; set; } 
        public IRPSButton<CustomerCommissionGroupSLEntityView> DeleteButton { get; set; } 
        public IRPSButton<CustomerCommissionGroupSLEntityView,CustomerCommissionGroupSLCollectionView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<CustomerCommissionGroupSLEntityView,CustomerCommissionGroupSLCollectionView> BackButton { get; set; } 
        public IRPSTextBox<CustomerCommissionGroupSLEntityView> CodCustomerCommissionGroup { get; set; } 
        public IRPSTextBox<CustomerCommissionGroupSLEntityView> Description { get; set; } 
        public CustomerCommissionGroupSL Screen { get; set; }
        public CustomerCommissionGroupSLEntityView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}