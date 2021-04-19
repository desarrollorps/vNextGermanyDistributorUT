    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.Manufacturing.ManufacturingOrderLaunch
{
    //RPS VERSION 1.0.0.0
    public partial class ManufacturingOrderLaunch:Screen
    {
        public ManufacturingOrderLaunch():base()
        {
            this.URL = "manufacturing.manufacturingorderlaunch";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            ManufacturingOrderLaunchView  = new ManufacturingOrderLaunchView(this); 
            ManufacturingOrderLaunchView.InitializeControls(); 
           
        }
      
            public ManufacturingOrderLaunchView ManufacturingOrderLaunchView {get; set; } 
    }
            
    public partial class ManufacturingOrderLaunchView : View
    {
        public ManufacturingOrderLaunchView(ManufacturingOrderLaunch screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            Site = RPSControlFactory.CreateRPSComboBox<ManufacturingOrderLaunchView>("a4047802-f59c-48ef-9303-91b5201fc1db","","",false, this);
 
            All = RPSControlFactory.CreateRPSOption<ManufacturingOrderLaunchView>( "606a70b9-a4b5-4a1f-8b1d-96f2585c4881","","",this);
 
            Selected = RPSControlFactory.CreateRPSOption<ManufacturingOrderLaunchView>( "374e8050-1e6b-4818-9cbb-0fb8e5413ece","","",this);
 
            ManufacturingOrder = RPSControlFactory.CreateRPSCollectionComboBox<ManufacturingOrderLaunchView>("5a43d6cf-8efa-4a1b-a46b-c2a3c2f298bb","","",false, this);
 
            FromTo = RPSControlFactory.CreateRPSOption<ManufacturingOrderLaunchView>( "1a77abb5-e032-42fa-9538-08ca09711ff1","","",this);
 
            FromManufacturingOrder = RPSControlFactory.CreateRPSComboBox<ManufacturingOrderLaunchView>("d09e2fde-e721-4707-962c-d6607dea3fb3","","",false, this);
 
            ToManufacturingOrder = RPSControlFactory.CreateRPSComboBox<ManufacturingOrderLaunchView>("d3d27c70-7771-42b9-8463-91cdbee7a941","","",false, this);
 
            Project = RPSControlFactory.CreateRPSCollectionComboBox<ManufacturingOrderLaunchView>("43acfdcf-ee20-4a3f-a73e-69dececeac4e","","",false, this);
 
            InternalCode = RPSControlFactory.CreateRPSTextBox<ManufacturingOrderLaunchView>("63b9767a-b7e8-4605-a1fa-5fce06554a96","","",false, this);
 
            ManufacturingOrderSituation = RPSControlFactory.CreateRPSComboBox<ManufacturingOrderLaunchView>("0e7bfc66-8818-4fd4-87fa-372f195a74f8","","",false, this);
 
            LaunchDate = RPSControlFactory.CreateRPSTextBox<ManufacturingOrderLaunchView>("38fb3b22-6add-4fef-8138-fb024a558853","","",false, this);
 
            PrintDocumentation = RPSControlFactory.CreateRPSCheckBox<ManufacturingOrderLaunchView>("d927594f-e46d-44ff-a455-8e66537051e7","","",false, this);
 
            RoadMap = RPSControlFactory.CreateRPSCheckBox<ManufacturingOrderLaunchView>("5486cbec-7feb-4547-868d-ce1ca387dc3b","","",false, this);
 
            WorkSheet = RPSControlFactory.CreateRPSCheckBox<ManufacturingOrderLaunchView>("1304cb79-21db-44df-8548-49f9542c7914","","",false, this);
 
            SheetEnd = RPSControlFactory.CreateRPSCheckBox<ManufacturingOrderLaunchView>("0a11c38b-4cd3-4cd1-8da8-848fb2bd7b2e","","",false, this);
 
            EntryMaterial = RPSControlFactory.CreateRPSCheckBox<ManufacturingOrderLaunchView>("7a8d63f8-96b2-4989-bd55-d5ce3161f225","","",false, this);
 
            TicketMaterial = RPSControlFactory.CreateRPSCheckBox<ManufacturingOrderLaunchView>("51d47a5e-4506-4aa6-9f46-2a167ae855e0","","",false, this);
 
            Labels = RPSControlFactory.CreateRPSCheckBox<ManufacturingOrderLaunchView>("bb762ce6-3961-493e-b39d-da27b33043ac","","",false, this);
 
            ControlSheetVersion = RPSControlFactory.CreateRPSCheckBox<ManufacturingOrderLaunchView>("ac2c5933-2c06-40ea-9375-b8e432f62aa5","","",false, this);
 
            Map = RPSControlFactory.CreateRPSCheckBox<ManufacturingOrderLaunchView>("ba7fe93b-28a4-4966-ae2d-a714f065f3ce","","",false, this);
 
            bManufacturedProduct = RPSControlFactory.CreateRPSCheckBox<ManufacturingOrderLaunchView>("4c009d55-b7fb-465e-a540-7296c188b3e3","","",false, this);
 
            bMaterials = RPSControlFactory.CreateRPSCheckBox<ManufacturingOrderLaunchView>("e2fdc334-d25b-48a9-a17a-1a9b54e51022","","",false, this);
 
            bTasks = RPSControlFactory.CreateRPSCheckBox<ManufacturingOrderLaunchView>("b7ddcdf8-df18-446e-aa74-d97c0301a7a7","","",false, this);
 
            IsCompressedOrDecompressed = RPSControlFactory.CreateRPSCheckBox<ManufacturingOrderLaunchView>("9efe7f51-f762-41ee-9b58-e3c2602443d5","","",false, this);
 
            Manufactured_Product = RPSControlFactory.CreateRPSEnumComboBox<ManufacturingOrderLaunchView>("881c337d-1b4b-4b66-abda-4dfacb8b95a8","","",false, this);
 
            Materials = RPSControlFactory.CreateRPSEnumComboBox<ManufacturingOrderLaunchView>("46817065-df36-42f9-8750-bd68ab93d78d","","",false, this);
 
            ExecuteLaunchManufacturingOrder = RPSControlFactory.CreateRPSButton<ManufacturingOrderLaunchView>( "edd01f87-1f26-4835-b1ea-9998648d886c","","",this);
 

        }
        public IRPSComboBox<ManufacturingOrderLaunchView> Site { get; set; } 
        public IRPSOption<ManufacturingOrderLaunchView> All { get; set; } 
        public IRPSOption<ManufacturingOrderLaunchView> Selected { get; set; } 
        public IRPSCollectionComboBox<ManufacturingOrderLaunchView> ManufacturingOrder { get; set; } 
        public IRPSOption<ManufacturingOrderLaunchView> FromTo { get; set; } 
        public IRPSComboBox<ManufacturingOrderLaunchView> FromManufacturingOrder { get; set; } 
        public IRPSComboBox<ManufacturingOrderLaunchView> ToManufacturingOrder { get; set; } 
        public IRPSCollectionComboBox<ManufacturingOrderLaunchView> Project { get; set; } 
        public IRPSTextBox<ManufacturingOrderLaunchView> InternalCode { get; set; } 
        public IRPSComboBox<ManufacturingOrderLaunchView> ManufacturingOrderSituation { get; set; } 
        public IRPSTextBox<ManufacturingOrderLaunchView> LaunchDate { get; set; } 
        public IRPSCheckbox<ManufacturingOrderLaunchView> PrintDocumentation { get; set; } 
        public IRPSCheckbox<ManufacturingOrderLaunchView> RoadMap { get; set; } 
        public IRPSCheckbox<ManufacturingOrderLaunchView> WorkSheet { get; set; } 
        public IRPSCheckbox<ManufacturingOrderLaunchView> SheetEnd { get; set; } 
        public IRPSCheckbox<ManufacturingOrderLaunchView> EntryMaterial { get; set; } 
        public IRPSCheckbox<ManufacturingOrderLaunchView> TicketMaterial { get; set; } 
        public IRPSCheckbox<ManufacturingOrderLaunchView> Labels { get; set; } 
        public IRPSCheckbox<ManufacturingOrderLaunchView> ControlSheetVersion { get; set; } 
        public IRPSCheckbox<ManufacturingOrderLaunchView> Map { get; set; } 
        public IRPSCheckbox<ManufacturingOrderLaunchView> bManufacturedProduct { get; set; } 
        public IRPSCheckbox<ManufacturingOrderLaunchView> bMaterials { get; set; } 
        public IRPSCheckbox<ManufacturingOrderLaunchView> bTasks { get; set; } 
        public IRPSCheckbox<ManufacturingOrderLaunchView> IsCompressedOrDecompressed { get; set; } 
        public IRPSComboBox<ManufacturingOrderLaunchView> Manufactured_Product { get; set; } 
        public IRPSComboBox<ManufacturingOrderLaunchView> Materials { get; set; } 
        public IRPSButton<ManufacturingOrderLaunchView> ExecuteLaunchManufacturingOrder { get; set; } 
        public ManufacturingOrderLaunch Screen { get; set; }
        public ManufacturingOrderLaunchView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}