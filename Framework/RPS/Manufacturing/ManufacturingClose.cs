    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.Manufacturing.ManufacturingClose
{
    //RPS VERSION 1.0.0.0
    public partial class ManufacturingClose:Screen
    {
        public ManufacturingClose():base()
        {
            this.URL = "manufacturing.manufacturingclose";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            ManufacturingCloseQueryView  = new ManufacturingCloseQueryView(this); 
            CloseManufacturingOrderChildDialogView  = new CloseManufacturingOrderChildDialogView(this); 
            ManufacturingOrderDetailsDialogView  = new ManufacturingOrderDetailsDialogView(this); 
            ManufacturingCloseQueryView.InitializeControls(); 
            CloseManufacturingOrderChildDialogView.InitializeControls(); 
            ManufacturingOrderDetailsDialogView.InitializeControls(); 
           
        }
      
            public ManufacturingCloseQueryView ManufacturingCloseQueryView {get; set; } 
            public CloseManufacturingOrderChildDialogView CloseManufacturingOrderChildDialogView {get; set; } 
            public ManufacturingOrderDetailsDialogView ManufacturingOrderDetailsDialogView {get; set; } 
    }
            
    public partial class ManufacturingCloseQueryView : View
    {
        public ManufacturingCloseQueryView(ManufacturingClose screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            Site = RPSControlFactory.CreateRPSComboBox<ManufacturingCloseQueryView>("9a6638c5-eb19-4fad-8aec-0e984dc7d925","","",false, this);
 
            ManufacturingOrder = RPSControlFactory.CreateRPSCollectionComboBox<ManufacturingCloseQueryView>("fa541431-6238-4e2e-9bae-4c12be5ff187","","",false, this);
 
            Article = RPSControlFactory.CreateRPSCollectionComboBox<ManufacturingCloseQueryView>("91889087-9e41-43b5-8ecc-8e4caca6aa43","","",false, this);
 
            UIInternalCode = RPSControlFactory.CreateRPSTextBox<ManufacturingCloseQueryView>("2a43adc7-6dcf-48a4-b4a9-ff847abee754","","",false, this);
 
            Perecentage = RPSControlFactory.CreateRPSFormattedTextBox<ManufacturingCloseQueryView>("9a3a9c12-7cac-4d3b-8702-36cc6ba961d0","","",false, this);
 
            TaskCheck = RPSControlFactory.CreateRPSCheckBox<ManufacturingCloseQueryView>("a3d1ea90-c312-46dc-93d2-32f8aa578ec6","","",false, this);
 
            TimeCheck = RPSControlFactory.CreateRPSCheckBox<ManufacturingCloseQueryView>("6764e3da-9aaf-42b7-b9ed-28d6a4deca30","","",false, this);
 
            QuantityCheck = RPSControlFactory.CreateRPSCheckBox<ManufacturingCloseQueryView>("d44e4d89-dcee-4f30-b87d-8abc94708a41","","",false, this);
 
            ImputedQuantityMats = RPSControlFactory.CreateRPSCheckBox<ManufacturingCloseQueryView>("9c4caaa8-3ed0-4bdf-8bee-a68335c7b6d7","","",false, this);
 
            EstimatedCheck = RPSControlFactory.CreateRPSCheckBox<ManufacturingCloseQueryView>("c02c249c-609a-48da-819b-2dc6f927bf4a","","",false, this);
 
            Quantity = RPSControlFactory.CreateRPSFormattedTextBox<ManufacturingCloseQueryView>("109a030b-f68f-49af-9740-0d68552c778c","","",false, this);
 
            ControlProductSerieTracking = RPSControlFactory.CreateRPSCheckBox<ManufacturingCloseQueryView>("e402a674-345b-40d4-8a93-915aa7fdba3d","","",false, this);
 
            CloseManufacturingOrderChildNavigationCommandButton = RPSControlFactory.CreateRPSButtonToView<ManufacturingCloseQueryView,CloseManufacturingOrderChildDialogView>("54627621-fa3a-41ff-80c1-f8e4633a821a","","", this,Screen.CloseManufacturingOrderChildDialogView);
 
            CollectionInit params_ManufacturingOrderCloseReport = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="0d60a20e-8cca-441f-9b8b-6c3de292165b",CSSSelectorGrid="",XPathGrid=""};
            ManufacturingOrderCloseReport = RPSControlFactory.RPSCreateCollectionWithGrid<ManufacturingOrderCloseReportCollectionEditor<ManufacturingCloseQueryView,CloseManufacturingOrderChildDialogView>,ManufacturingCloseQueryView,CloseManufacturingOrderChildDialogView>( params_ManufacturingOrderCloseReport,this,Screen.CloseManufacturingOrderChildDialogView);
 

        }
        public IRPSComboBox<ManufacturingCloseQueryView> Site { get; set; } 
        public IRPSCollectionComboBox<ManufacturingCloseQueryView> ManufacturingOrder { get; set; } 
        public IRPSCollectionComboBox<ManufacturingCloseQueryView> Article { get; set; } 
        public IRPSTextBox<ManufacturingCloseQueryView> UIInternalCode { get; set; } 
        public IRPSTextBox<ManufacturingCloseQueryView> Perecentage { get; set; } 
        public IRPSCheckbox<ManufacturingCloseQueryView> TaskCheck { get; set; } 
        public IRPSCheckbox<ManufacturingCloseQueryView> TimeCheck { get; set; } 
        public IRPSCheckbox<ManufacturingCloseQueryView> QuantityCheck { get; set; } 
        public IRPSCheckbox<ManufacturingCloseQueryView> ImputedQuantityMats { get; set; } 
        public IRPSCheckbox<ManufacturingCloseQueryView> EstimatedCheck { get; set; } 
        public IRPSTextBox<ManufacturingCloseQueryView> Quantity { get; set; } 
        public IRPSCheckbox<ManufacturingCloseQueryView> ControlProductSerieTracking { get; set; } 
        public IRPSButton<ManufacturingCloseQueryView,CloseManufacturingOrderChildDialogView> CloseManufacturingOrderChildNavigationCommandButton { get; set; } 
        public ManufacturingOrderCloseReportCollectionEditor<ManufacturingCloseQueryView,CloseManufacturingOrderChildDialogView> ManufacturingOrderCloseReport { get; set; } 
        public ManufacturingClose Screen { get; set; }
        public ManufacturingCloseQueryView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class ManufacturingOrderCloseReportCollectionEditor<ManufacturingCloseQueryView,CloseManufacturingOrderChildDialogView>:RPSCollectionEditor<ManufacturingCloseQueryView,CloseManufacturingOrderChildDialogView> where ManufacturingCloseQueryView : class, IView where CloseManufacturingOrderChildDialogView : class, IView
    {
        public  ManufacturingOrderCloseReportGridView<ManufacturingCloseQueryView,CloseManufacturingOrderChildDialogView> GridView {get;set;}
    }
    public partial class ManufacturingOrderCloseReportGridView <ManufacturingCloseQueryView,CloseManufacturingOrderChildDialogView> :  RPSGridView<ManufacturingCloseQueryView,CloseManufacturingOrderChildDialogView> where ManufacturingCloseQueryView : class, IView where CloseManufacturingOrderChildDialogView : class, IView
    {
        public ManufacturingOrderCloseReportGridView(ManufacturingCloseQueryView currentView,CloseManufacturingOrderChildDialogView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            NumTask = RPSControlFactory.CreateRPSGridFormattedTextBox<ManufacturingCloseQueryView>("","#0d60a20e-8cca-441f-9b8b-6c3de292165b .ag-row[role='row']@ROWINDEX [col-id='cNumTask']","",false, this.CurrentView);
 
            NumTaskCompleted = RPSControlFactory.CreateRPSGridFormattedTextBox<ManufacturingCloseQueryView>("","#0d60a20e-8cca-441f-9b8b-6c3de292165b .ag-row[role='row']@ROWINDEX [col-id='cNumTaskCompleted']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<ManufacturingCloseQueryView> NumTask { get; set; } 
        public IRPSGridTextBox<ManufacturingCloseQueryView> NumTaskCompleted { get; set; } 
                     
    }
 
    }
  
            
    public partial class CloseManufacturingOrderChildDialogView : View
    {
        public CloseManufacturingOrderChildDialogView(ManufacturingClose screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            NewDateTimeProperty = RPSControlFactory.CreateRPSTextBox<CloseManufacturingOrderChildDialogView>("8217c87b-7e57-4954-92c6-e6d8bf8f995a","","",false, this);
 
            ManufacturingOrderSituation = RPSControlFactory.CreateRPSComboBox<CloseManufacturingOrderChildDialogView>("ab74f43a-15f1-4fe8-9f03-f945f22f5f58","","",false, this);
 

        }
        public IRPSTextBox<CloseManufacturingOrderChildDialogView> NewDateTimeProperty { get; set; } 
        public IRPSComboBox<CloseManufacturingOrderChildDialogView> ManufacturingOrderSituation { get; set; } 
        public ManufacturingClose Screen { get; set; }
        public CloseManufacturingOrderChildDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class ManufacturingOrderDetailsDialogView : View
    {
        public ManufacturingOrderDetailsDialogView(ManufacturingClose screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {

        }
        public ManufacturingClose Screen { get; set; }
        public ManufacturingOrderDetailsDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}