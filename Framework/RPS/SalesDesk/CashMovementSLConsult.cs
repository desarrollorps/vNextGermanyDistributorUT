    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.SalesDesk.CashMovementSLConsult
{
    //RPS VERSION 1.0.0.0
    public partial class CashMovementSLConsult:Screen
    {
        public CashMovementSLConsult():base()
        {
            this.URL = "salesdesk.cashmovementslconsult";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            CashMovementSLConsultQueryView  = new CashMovementSLConsultQueryView(this); 
            CashMovementSLConsultQueryView.InitializeControls(); 
           
        }
      
            public CashMovementSLConsultQueryView CashMovementSLConsultQueryView {get; set; } 
    }
            
    public partial class CashMovementSLConsultQueryView : View
    {
        public CashMovementSLConsultQueryView(CashMovementSLConsult screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            IDCashPaymentSLCollection = RPSControlFactory.CreateRPSCollectionComboBox<CashMovementSLConsultQueryView>("35dfbcbc-c08c-47fc-98fb-80e9df0c1661","","",false, this);
 
            DateFrom = RPSControlFactory.CreateRPSTextBox<CashMovementSLConsultQueryView>("b78a6c49-b55e-4524-ace6-3151d86452f4","","",false, this);
 
            DateTo = RPSControlFactory.CreateRPSTextBox<CashMovementSLConsultQueryView>("4f39a11b-4305-4677-b952-6556aecae814","","",false, this);
 
            Open = RPSControlFactory.CreateRPSCheckBox<CashMovementSLConsultQueryView>("fece7f7b-48d6-4aee-b328-3ed032eb219a","","",false, this);
 
            Input = RPSControlFactory.CreateRPSCheckBox<CashMovementSLConsultQueryView>("67c105d0-c0e8-43c8-ba0d-155a959a388b","","",false, this);
 
            Output = RPSControlFactory.CreateRPSCheckBox<CashMovementSLConsultQueryView>("3d14bfe4-d28b-4a73-9696-d84f015c9e16","","",false, this);
 
            Close = RPSControlFactory.CreateRPSCheckBox<CashMovementSLConsultQueryView>("cf4b4153-425c-4ea9-867b-6522fdffdc8e","","",false, this);
 
            CollectionInit params_CashMovementSLConsult = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="608f6b0a-7c86-4e2f-92f7-24e6f5a2a76f",CSSSelectorGrid="",XPathGrid=""};
            CashMovementSLConsult = RPSControlFactory.RPSCreateCollectionWithGrid<CashMovementSLConsultCollectionEditor<CashMovementSLConsultQueryView>,CashMovementSLConsultQueryView>( params_CashMovementSLConsult,this);
 

        }
        public IRPSCollectionComboBox<CashMovementSLConsultQueryView> IDCashPaymentSLCollection { get; set; } 
        public IRPSTextBox<CashMovementSLConsultQueryView> DateFrom { get; set; } 
        public IRPSTextBox<CashMovementSLConsultQueryView> DateTo { get; set; } 
        public IRPSCheckbox<CashMovementSLConsultQueryView> Open { get; set; } 
        public IRPSCheckbox<CashMovementSLConsultQueryView> Input { get; set; } 
        public IRPSCheckbox<CashMovementSLConsultQueryView> Output { get; set; } 
        public IRPSCheckbox<CashMovementSLConsultQueryView> Close { get; set; } 
        public CashMovementSLConsultCollectionEditor<CashMovementSLConsultQueryView> CashMovementSLConsult { get; set; } 
        public CashMovementSLConsult Screen { get; set; }
        public CashMovementSLConsultQueryView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class CashMovementSLConsultCollectionEditor<CashMovementSLConsultQueryView>:RPSCollectionEditor<CashMovementSLConsultQueryView> where CashMovementSLConsultQueryView : class, IView
    {
        public  CashMovementSLConsultGridView<CashMovementSLConsultQueryView> GridView {get;set;}
    }
    public partial class CashMovementSLConsultGridView <CashMovementSLConsultQueryView> :  RPSGridView<CashMovementSLConsultQueryView> where CashMovementSLConsultQueryView : class, IView
    {
        public CashMovementSLConsultGridView(CashMovementSLConsultQueryView currentView)
        {
            this.WebDriver = currentView.WebDriver;          
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            CashMovementSL_CashMovementDate = RPSControlFactory.CreateRPSGridTextBox<CashMovementSLConsultQueryView>("","#608f6b0a-7c86-4e2f-92f7-24e6f5a2a76f .ag-row[role='row']@ROWINDEX [col-id='cCashMovementSL_CashMovementDate']","",false, this.CurrentView);
 
            CashMovementSL_IntroductionDate = RPSControlFactory.CreateRPSGridTextBox<CashMovementSLConsultQueryView>("","#608f6b0a-7c86-4e2f-92f7-24e6f5a2a76f .ag-row[role='row']@ROWINDEX [col-id='cCashMovementSL_IntroductionDate']","",false, this.CurrentView);
 
            CashMovementSL_Description = RPSControlFactory.CreateRPSGridTextBox<CashMovementSLConsultQueryView>("","#608f6b0a-7c86-4e2f-92f7-24e6f5a2a76f .ag-row[role='row']@ROWINDEX [col-id='cCashMovementSL_Description']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<CashMovementSLConsultQueryView> CashMovementSL_CashMovementDate { get; set; } 
        public IRPSGridTextBox<CashMovementSLConsultQueryView> CashMovementSL_IntroductionDate { get; set; } 
        public IRPSGridTextBox<CashMovementSLConsultQueryView> CashMovementSL_Description { get; set; } 
                     
    }
 
    }
  
    

}