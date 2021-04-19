    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.Sales.OrderSituationSL
{
    //RPS VERSION 1.0.0.0
    public partial class OrderSituationSL:Screen
    {
        public OrderSituationSL():base()
        {
            this.URL = "sales.ordersituationsl";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            OrderSituationSLCollectionView  = new OrderSituationSLCollectionView(this); 
            OrderSituationSLEntityView  = new OrderSituationSLEntityView(this); 
            OrderSituationSLCollectionView.InitializeControls(); 
            OrderSituationSLEntityView.InitializeControls(); 
           
        }
      
            public OrderSituationSLCollectionView OrderSituationSLCollectionView {get; set; } 
            public OrderSituationSLEntityView OrderSituationSLEntityView {get; set; } 
    }
            
    public partial class OrderSituationSLCollectionView : View
    {
        public OrderSituationSLCollectionView(OrderSituationSL screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            NewButton = RPSControlFactory.RPSNewButton<OrderSituationSLCollectionView,OrderSituationSLEntityView>( this,Screen.OrderSituationSLEntityView);
 
            CollectionInit params_MainConsult = new CollectionInit(){IDDescriptor = "cf12a8d3-3d74-43a8-88c2-64770ca1dcd6",CSSSelectorDescriptor = "",XPathDescriptor = ""};
            MainConsult = RPSControlFactory.RPSCreateCollection<OrderSituationSLCollectionView,OrderSituationSLEntityView>( params_MainConsult,this,Screen.OrderSituationSLEntityView);
 

        }
        public IRPSButton<OrderSituationSLCollectionView,OrderSituationSLEntityView> NewButton { get; set; } 
        public IRPSCollectionEditor<OrderSituationSLCollectionView,OrderSituationSLEntityView> MainConsult { get; set; } 
        public OrderSituationSL Screen { get; set; }
        public OrderSituationSLCollectionView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class OrderSituationSLEntityView : View
    {
        public OrderSituationSLEntityView(OrderSituationSL screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            SaveButton = RPSControlFactory.RPSSaveButton<OrderSituationSLEntityView>( this);
 
            DeleteButton = RPSControlFactory.RPSDeleteButton<OrderSituationSLEntityView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<OrderSituationSLEntityView,OrderSituationSLCollectionView>( this,Screen.OrderSituationSLCollectionView);
 
            BackButton = RPSControlFactory.RPSBackButton<OrderSituationSLEntityView,OrderSituationSLCollectionView>( this,Screen.OrderSituationSLCollectionView);
 
            CodOrderSituation = RPSControlFactory.CreateRPSTextBox<OrderSituationSLEntityView>("b577b2fc-066e-4a28-9c1f-4a97b0b46a4c","","",true, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<OrderSituationSLEntityView>("b727228e-ef2a-41fe-9b48-8fad3e1fe4d6","","",false, this);
 
            SituationType = RPSControlFactory.CreateRPSEnumComboBox<OrderSituationSLEntityView>("2166b8e1-b5df-4862-9efb-cb54f7c078b2","","",true, this);
 

        }
        public IRPSSaveButton<OrderSituationSLEntityView> SaveButton { get; set; } 
        public IRPSButton<OrderSituationSLEntityView> DeleteButton { get; set; } 
        public IRPSButton<OrderSituationSLEntityView,OrderSituationSLCollectionView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<OrderSituationSLEntityView,OrderSituationSLCollectionView> BackButton { get; set; } 
        public IRPSTextBox<OrderSituationSLEntityView> CodOrderSituation { get; set; } 
        public IRPSTextBox<OrderSituationSLEntityView> Description { get; set; } 
        public IRPSComboBox<OrderSituationSLEntityView> SituationType { get; set; } 
        public OrderSituationSL Screen { get; set; }
        public OrderSituationSLEntityView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}