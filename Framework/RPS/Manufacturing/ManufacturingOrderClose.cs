    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.Manufacturing.ManufacturingOrderClose
{
    //RPS VERSION 1.0.0.0
    public partial class ManufacturingOrderClose:Screen
    {
        public ManufacturingOrderClose():base()
        {
            this.URL = "manufacturing.manufacturingorderclose";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            ManufacturingOrderClosingView  = new ManufacturingOrderClosingView(this); 
            ManufacturingOrderClosingView.InitializeControls(); 
           
        }
      
            public ManufacturingOrderClosingView ManufacturingOrderClosingView {get; set; } 
    }
            
    public partial class ManufacturingOrderClosingView : View
    {
        public ManufacturingOrderClosingView(ManufacturingOrderClose screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            Site = RPSControlFactory.CreateRPSComboBox<ManufacturingOrderClosingView>("7f79f01e-6c87-49fe-be38-59438e6f9391","","",false, this);
 
            All = RPSControlFactory.CreateRPSOption<ManufacturingOrderClosingView>( "bd6e358d-116d-4cab-b764-232397e4f269","","",this);
 
            Selection = RPSControlFactory.CreateRPSOption<ManufacturingOrderClosingView>( "1b59788a-a1aa-4d6c-8670-5744a15d6e56","","",this);
 
            ManufacturingOrder = RPSControlFactory.CreateRPSCollectionComboBox<ManufacturingOrderClosingView>("d854a022-7511-447c-8500-f1e0cd094784","","",false, this);
 
            FromTo = RPSControlFactory.CreateRPSOption<ManufacturingOrderClosingView>( "78ad0285-5758-4d1c-893d-af8223ce4eed","","",this);
 
            FromManufacturingOrder = RPSControlFactory.CreateRPSComboBox<ManufacturingOrderClosingView>("3da5028e-54f1-4a9f-b957-5c9462fa1bce","","",false, this);
 
            ToManufacturingOrder = RPSControlFactory.CreateRPSComboBox<ManufacturingOrderClosingView>("96375fbd-58f3-4eb2-8316-fff7aa45e123","","",false, this);
 
            InternalCode = RPSControlFactory.CreateRPSTextBox<ManufacturingOrderClosingView>("80f6c32f-2e44-414e-ae4d-3a42b59d98cf","","",false, this);
 
            ManufacturingOrderSituation = RPSControlFactory.CreateRPSComboBox<ManufacturingOrderClosingView>("a35b40f5-a29f-495e-b268-035e53e8ccc5","","",false, this);
 
            CloseDate = RPSControlFactory.CreateRPSTextBox<ManufacturingOrderClosingView>("24978453-a154-4d0d-a4e5-e37f7374a2a3","","",false, this);
 
            KeepExistingClosingDate = RPSControlFactory.CreateRPSCheckBox<ManufacturingOrderClosingView>("579371f0-203b-48f2-9dbd-112d635b4af6","","",false, this);
 
            ControlProductSerieTracking = RPSControlFactory.CreateRPSCheckBox<ManufacturingOrderClosingView>("ea6e6df6-f8d1-4d5c-9f15-1dc67f711fdd","","",false, this);
 
            Close = RPSControlFactory.CreateRPSOption<ManufacturingOrderClosingView>( "493cad70-423d-4e77-b33e-d0dc9a9a546a","","",this);
 
            Recalculate = RPSControlFactory.CreateRPSOption<ManufacturingOrderClosingView>( "4170a3d9-57a4-443f-951b-d0ca69dfde51","","",this);
 
            AcceptCommButton = RPSControlFactory.CreateRPSButton<ManufacturingOrderClosingView>( "908d7139-df3c-4eb1-bfda-3ed453a2cc3f","","",this);
 

        }
        public IRPSComboBox<ManufacturingOrderClosingView> Site { get; set; } 
        public IRPSOption<ManufacturingOrderClosingView> All { get; set; } 
        public IRPSOption<ManufacturingOrderClosingView> Selection { get; set; } 
        public IRPSCollectionComboBox<ManufacturingOrderClosingView> ManufacturingOrder { get; set; } 
        public IRPSOption<ManufacturingOrderClosingView> FromTo { get; set; } 
        public IRPSComboBox<ManufacturingOrderClosingView> FromManufacturingOrder { get; set; } 
        public IRPSComboBox<ManufacturingOrderClosingView> ToManufacturingOrder { get; set; } 
        public IRPSTextBox<ManufacturingOrderClosingView> InternalCode { get; set; } 
        public IRPSComboBox<ManufacturingOrderClosingView> ManufacturingOrderSituation { get; set; } 
        public IRPSTextBox<ManufacturingOrderClosingView> CloseDate { get; set; } 
        public IRPSCheckbox<ManufacturingOrderClosingView> KeepExistingClosingDate { get; set; } 
        public IRPSCheckbox<ManufacturingOrderClosingView> ControlProductSerieTracking { get; set; } 
        public IRPSOption<ManufacturingOrderClosingView> Close { get; set; } 
        public IRPSOption<ManufacturingOrderClosingView> Recalculate { get; set; } 
        public IRPSButton<ManufacturingOrderClosingView> AcceptCommButton { get; set; } 
        public ManufacturingOrderClose Screen { get; set; }
        public ManufacturingOrderClosingView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}