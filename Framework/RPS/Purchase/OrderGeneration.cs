    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.Purchase.OrderGeneration
{
    //RPS VERSION 1.0.0.0
    public partial class OrderGeneration:Screen
    {
        public OrderGeneration():base()
        {
            this.URL = "purchase.ordergeneration";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            OrderGenerationView  = new OrderGenerationView(this); 
            OrderGenerationView.InitializeControls(); 
           
        }
      
            public OrderGenerationView OrderGenerationView {get; set; } 
    }
            
    public partial class OrderGenerationView : View
    {
        public OrderGenerationView(OrderGeneration screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            PurchaseProposal = RPSControlFactory.CreateRPSCollectionComboBox<OrderGenerationView>("1c63edeb-bd26-436e-96b5-1cdd124f2766","","",false, this);
 
            Supplier = RPSControlFactory.CreateRPSCollectionComboBox<OrderGenerationView>("d9078424-f4e3-4287-b5b4-9d0f4ad9b78a","","",false, this);
 
            Article = RPSControlFactory.CreateRPSCollectionComboBox<OrderGenerationView>("765d31bd-4dd4-42a9-9df2-8aa26d6fe145","","",false, this);
 
            Project = RPSControlFactory.CreateRPSCollectionComboBox<OrderGenerationView>("ea867c04-da0e-4749-8f2d-f3e0015be11b","","",false, this);
 
            ManufacturingOrder = RPSControlFactory.CreateRPSCollectionComboBox<OrderGenerationView>("38b20fba-0ee3-4201-931b-2f4e3d5374d1","","",false, this);
 
            Site = RPSControlFactory.CreateRPSComboBox<OrderGenerationView>("afa75c95-5f50-4948-9d4e-714dc53d56e1","","",false, this);
 
            WareHouse = RPSControlFactory.CreateRPSComboBox<OrderGenerationView>("ef3ac8da-a542-4eba-bd3c-50c4ec160520","","",false, this);
 
            BreakBysite = RPSControlFactory.CreateRPSCheckBox<OrderGenerationView>("047005c4-4993-4b4d-8de1-49946fd4924b","","",false, this);
 
            PrintNavigationCommand = RPSControlFactory.CreateRPSButton<OrderGenerationView>( "3cd9d8ca-4b52-4a99-aebe-1d22fc09d152","","",this);
 
            CollectionInit params_OrderConsult = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="c110141e-992f-427c-b3ca-e8a234f39e47",CSSSelectorGrid="",XPathGrid=""};
            OrderConsult = RPSControlFactory.RPSCreateCollectionWithGrid<OrderConsultCollectionEditor<OrderGenerationView>,OrderGenerationView>( params_OrderConsult,this);
 

        }
        public IRPSCollectionComboBox<OrderGenerationView> PurchaseProposal { get; set; } 
        public IRPSCollectionComboBox<OrderGenerationView> Supplier { get; set; } 
        public IRPSCollectionComboBox<OrderGenerationView> Article { get; set; } 
        public IRPSCollectionComboBox<OrderGenerationView> Project { get; set; } 
        public IRPSCollectionComboBox<OrderGenerationView> ManufacturingOrder { get; set; } 
        public IRPSComboBox<OrderGenerationView> Site { get; set; } 
        public IRPSComboBox<OrderGenerationView> WareHouse { get; set; } 
        public IRPSCheckbox<OrderGenerationView> BreakBysite { get; set; } 
        public IRPSButton<OrderGenerationView> PrintNavigationCommand { get; set; } 
        public OrderConsultCollectionEditor<OrderGenerationView> OrderConsult { get; set; } 
        public OrderGeneration Screen { get; set; }
        public OrderGenerationView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class OrderConsultCollectionEditor<OrderGenerationView>:RPSCollectionEditor<OrderGenerationView> where OrderGenerationView : class, IView
    {
        public  OrderConsultGridView<OrderGenerationView> GridView {get;set;}
    }
    public partial class OrderConsultGridView <OrderGenerationView> :  RPSGridView<OrderGenerationView> where OrderGenerationView : class, IView
    {
        public OrderConsultGridView(OrderGenerationView currentView)
        {
            this.WebDriver = currentView.WebDriver;          
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            Order_OrderDate = RPSControlFactory.CreateRPSGridTextBox<OrderGenerationView>("","#c110141e-992f-427c-b3ca-e8a234f39e47 .ag-row[role='row']@ROWINDEX [col-id='cOrder_OrderDate']","",false, this.CurrentView);
 
            Order_ReceptionDate = RPSControlFactory.CreateRPSGridTextBox<OrderGenerationView>("","#c110141e-992f-427c-b3ca-e8a234f39e47 .ag-row[role='row']@ROWINDEX [col-id='cOrder_ReceptionDate']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<OrderGenerationView> Order_OrderDate { get; set; } 
        public IRPSGridTextBox<OrderGenerationView> Order_ReceptionDate { get; set; } 
                     
    }
 
    }
  
    

}