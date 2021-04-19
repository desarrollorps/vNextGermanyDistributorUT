    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.Manufacturing.InternalCode
{
    //RPS VERSION 1.0.0.0
    public partial class InternalCode:Screen
    {
        public InternalCode():base()
        {
            this.URL = "manufacturing.internalcode";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            InternalCodeView  = new InternalCodeView(this); 
            InternalCodeView.InitializeControls(); 
           
        }
      
            public InternalCodeView InternalCodeView {get; set; } 
    }
            
    public partial class InternalCodeView : View
    {
        public InternalCodeView(InternalCode screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            InternalCode = RPSControlFactory.CreateRPSTextBox<InternalCodeView>("160572e6-d5f7-4d26-a807-e9cfd84a98f8","","",false, this);
 
            ExecuteManufacturingOrderInternalCode = RPSControlFactory.CreateRPSButton<InternalCodeView>( "72298602-0818-4e6b-a23c-b96a20582401","","",this);
 
            CollectionInit params_ManufacturingOrderInternalCode = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="2ea8f2f2-af45-46ca-8a81-04eedcf5ab60",CSSSelectorGrid="",XPathGrid=""};
            ManufacturingOrderInternalCode = RPSControlFactory.RPSCreateCollectionWithGrid<ManufacturingOrderInternalCodeCollectionEditor<InternalCodeView>,InternalCodeView>( params_ManufacturingOrderInternalCode,this);
 
            CollectionInit params_PurchaseProposalInternalCode = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="02feed74-6304-4275-9db5-5edb48a2d61a",CSSSelectorGrid="",XPathGrid=""};
            PurchaseProposalInternalCode = RPSControlFactory.RPSCreateCollectionWithGrid<PurchaseProposalInternalCodeCollectionEditor<InternalCodeView>,InternalCodeView>( params_PurchaseProposalInternalCode,this);
 
            CollectionInit params_OrderLineInternalCode = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="d4e439b4-c8a8-4431-9757-381454b644bb",CSSSelectorGrid="",XPathGrid=""};
            OrderLineInternalCode = RPSControlFactory.RPSCreateCollectionWithGrid<OrderLineInternalCodeCollectionEditor<InternalCodeView>,InternalCodeView>( params_OrderLineInternalCode,this);
 
            CollectionInit params_OrderSLInternalCode = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="1096678d-81d5-45a1-a5f7-7a87730488f1",CSSSelectorGrid="",XPathGrid=""};
            OrderSLInternalCode = RPSControlFactory.RPSCreateCollectionWithGrid<OrderSLInternalCodeCollectionEditor<InternalCodeView>,InternalCodeView>( params_OrderSLInternalCode,this);
 
            SectionManufacturingOrder = RPSControlFactory.CreateRPSSection<InternalCodeView>( "","ul li[rpsid='d4415d25-26e3-4f58-b0e7-7d8ad1fd38a0']","",this);
 
            SectionPurchaseProposal = RPSControlFactory.CreateRPSSection<InternalCodeView>( "","ul li[rpsid='71989758-6ffd-4b54-a383-73b7561f0b04']","",this);
 
            SectionPurchaseOrderLine = RPSControlFactory.CreateRPSSection<InternalCodeView>( "","ul li[rpsid='d490a67f-f354-4d7f-bac2-7de2f74a60fa']","",this);
 
            SectionOrderSL = RPSControlFactory.CreateRPSSection<InternalCodeView>( "","ul li[rpsid='de7c1100-11e6-4228-86f0-55d7c2745f7b']","",this);
 

        }
        public IRPSTextBox<InternalCodeView> InternalCode { get; set; } 
        public IRPSButton<InternalCodeView> ExecuteManufacturingOrderInternalCode { get; set; } 
        public ManufacturingOrderInternalCodeCollectionEditor<InternalCodeView> ManufacturingOrderInternalCode { get; set; } 
        public PurchaseProposalInternalCodeCollectionEditor<InternalCodeView> PurchaseProposalInternalCode { get; set; } 
        public OrderLineInternalCodeCollectionEditor<InternalCodeView> OrderLineInternalCode { get; set; } 
        public OrderSLInternalCodeCollectionEditor<InternalCodeView> OrderSLInternalCode { get; set; } 
        public IRPSSection<InternalCodeView> SectionManufacturingOrder { get; set; } 
        public IRPSSection<InternalCodeView> SectionPurchaseProposal { get; set; } 
        public IRPSSection<InternalCodeView> SectionPurchaseOrderLine { get; set; } 
        public IRPSSection<InternalCodeView> SectionOrderSL { get; set; } 
        public InternalCode Screen { get; set; }
        public InternalCodeView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class ManufacturingOrderInternalCodeCollectionEditor<InternalCodeView>:RPSCollectionEditor<InternalCodeView> where InternalCodeView : class, IView
    {
        public  ManufacturingOrderInternalCodeGridView<InternalCodeView> GridView {get;set;}
    }
    public partial class ManufacturingOrderInternalCodeGridView <InternalCodeView> :  RPSGridView<InternalCodeView> where InternalCodeView : class, IView
    {
        public ManufacturingOrderInternalCodeGridView(InternalCodeView currentView)
        {
            this.WebDriver = currentView.WebDriver;          
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            PlannedEndDate = RPSControlFactory.CreateRPSGridTextBox<InternalCodeView>("","#2ea8f2f2-af45-46ca-8a81-04eedcf5ab60 .ag-row[role='row']@ROWINDEX [col-id='cPlannedEndDate']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<InternalCodeView> PlannedEndDate { get; set; } 
                     
    }
 
        public partial class PurchaseProposalInternalCodeCollectionEditor<InternalCodeView>:RPSCollectionEditor<InternalCodeView> where InternalCodeView : class, IView
    {
        public  PurchaseProposalInternalCodeGridView<InternalCodeView> GridView {get;set;}
    }
    public partial class PurchaseProposalInternalCodeGridView <InternalCodeView> :  RPSGridView<InternalCodeView> where InternalCodeView : class, IView
    {
        public PurchaseProposalInternalCodeGridView(InternalCodeView currentView)
        {
            this.WebDriver = currentView.WebDriver;          
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            ReceptionDate = RPSControlFactory.CreateRPSGridTextBox<InternalCodeView>("","#02feed74-6304-4275-9db5-5edb48a2d61a .ag-row[role='row']@ROWINDEX [col-id='cReceptionDate']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<InternalCodeView> ReceptionDate { get; set; } 
                     
    }
 
        public partial class OrderLineInternalCodeCollectionEditor<InternalCodeView>:RPSCollectionEditor<InternalCodeView> where InternalCodeView : class, IView
    {
        public  OrderLineInternalCodeGridView<InternalCodeView> GridView {get;set;}
    }
    public partial class OrderLineInternalCodeGridView <InternalCodeView> :  RPSGridView<InternalCodeView> where InternalCodeView : class, IView
    {
        public OrderLineInternalCodeGridView(InternalCodeView currentView)
        {
            this.WebDriver = currentView.WebDriver;          
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            NumLine = RPSControlFactory.CreateRPSGridFormattedTextBox<InternalCodeView>("","#d4e439b4-c8a8-4431-9757-381454b644bb .ag-row[role='row']@ROWINDEX [col-id='cNumLine']","",false, this.CurrentView);
 
            ReceptionDate = RPSControlFactory.CreateRPSGridTextBox<InternalCodeView>("","#d4e439b4-c8a8-4431-9757-381454b644bb .ag-row[role='row']@ROWINDEX [col-id='cReceptionDate']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<InternalCodeView> NumLine { get; set; } 
        public IRPSGridTextBox<InternalCodeView> ReceptionDate { get; set; } 
                     
    }
 
        public partial class OrderSLInternalCodeCollectionEditor<InternalCodeView>:RPSCollectionEditor<InternalCodeView> where InternalCodeView : class, IView
    {
        public  OrderSLInternalCodeGridView<InternalCodeView> GridView {get;set;}
    }
    public partial class OrderSLInternalCodeGridView <InternalCodeView> :  RPSGridView<InternalCodeView> where InternalCodeView : class, IView
    {
        public OrderSLInternalCodeGridView(InternalCodeView currentView)
        {
            this.WebDriver = currentView.WebDriver;          
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            NumLine = RPSControlFactory.CreateRPSGridFormattedTextBox<InternalCodeView>("","#1096678d-81d5-45a1-a5f7-7a87730488f1 .ag-row[role='row']@ROWINDEX [col-id='cNumLine']","",false, this.CurrentView);
 
            ReceptionDate = RPSControlFactory.CreateRPSGridTextBox<InternalCodeView>("","#1096678d-81d5-45a1-a5f7-7a87730488f1 .ag-row[role='row']@ROWINDEX [col-id='cReceptionDate']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<InternalCodeView> NumLine { get; set; } 
        public IRPSGridTextBox<InternalCodeView> ReceptionDate { get; set; } 
                     
    }
 
    }
  
    

}