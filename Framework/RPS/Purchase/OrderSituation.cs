    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.Purchase.OrderSituation
{
    //RPS VERSION 1.0.0.0
    public partial class OrderSituation:Screen
    {
        public OrderSituation():base()
        {
            this.URL = "purchase.ordersituation";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            OrderSituationCollectionView  = new OrderSituationCollectionView(this); 
            OrderSituationEntityView  = new OrderSituationEntityView(this); 
            OrderSituationCollectionView.InitializeControls(); 
            OrderSituationEntityView.InitializeControls(); 
           
        }
      
            public OrderSituationCollectionView OrderSituationCollectionView {get; set; } 
            public OrderSituationEntityView OrderSituationEntityView {get; set; } 
    }
            
    public partial class OrderSituationCollectionView : View
    {
        public OrderSituationCollectionView(OrderSituation screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            NewButton = RPSControlFactory.RPSNewButton<OrderSituationCollectionView,OrderSituationEntityView>( this,Screen.OrderSituationEntityView);
 
            CollectionInit params_MainConsult = new CollectionInit(){IDDescriptor = "958dee28-ebc7-41c5-972c-0199625200a3",CSSSelectorDescriptor = "",XPathDescriptor = ""};
            MainConsult = RPSControlFactory.RPSCreateCollection<OrderSituationCollectionView,OrderSituationEntityView>( params_MainConsult,this,Screen.OrderSituationEntityView);
 

        }
        public IRPSButton<OrderSituationCollectionView,OrderSituationEntityView> NewButton { get; set; } 
        public IRPSCollectionEditor<OrderSituationCollectionView,OrderSituationEntityView> MainConsult { get; set; } 
        public OrderSituation Screen { get; set; }
        public OrderSituationCollectionView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class OrderSituationEntityView : View
    {
        public OrderSituationEntityView(OrderSituation screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            SaveButton = RPSControlFactory.RPSSaveButton<OrderSituationEntityView>( this);
 
            DeleteButton = RPSControlFactory.RPSDeleteButton<OrderSituationEntityView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<OrderSituationEntityView,OrderSituationCollectionView>( this,Screen.OrderSituationCollectionView);
 
            BackButton = RPSControlFactory.RPSBackButton<OrderSituationEntityView,OrderSituationCollectionView>( this,Screen.OrderSituationCollectionView);
 
            CodOrderSituation = RPSControlFactory.CreateRPSTextBox<OrderSituationEntityView>("b577b2fc-066e-4a28-9c1f-4a97b0b46a4c","","",true, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<OrderSituationEntityView>("b727228e-ef2a-41fe-9b48-8fad3e1fe4d6","","",false, this);
 
            SituationType = RPSControlFactory.CreateRPSEnumComboBox<OrderSituationEntityView>("2166b8e1-b5df-4862-9efb-cb54f7c078b2","","",true, this);
 

        }
        public IRPSSaveButton<OrderSituationEntityView> SaveButton { get; set; } 
        public IRPSButton<OrderSituationEntityView> DeleteButton { get; set; } 
        public IRPSButton<OrderSituationEntityView,OrderSituationCollectionView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<OrderSituationEntityView,OrderSituationCollectionView> BackButton { get; set; } 
        public IRPSTextBox<OrderSituationEntityView> CodOrderSituation { get; set; } 
        public IRPSTextBox<OrderSituationEntityView> Description { get; set; } 
        public IRPSComboBox<OrderSituationEntityView> SituationType { get; set; } 
        public OrderSituation Screen { get; set; }
        public OrderSituationEntityView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}