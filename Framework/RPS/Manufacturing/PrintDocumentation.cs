    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.Manufacturing.PrintDocumentation
{
    //RPS VERSION 1.0.0.0
    public partial class PrintDocumentation:Screen
    {
        public PrintDocumentation():base()
        {
            this.URL = "manufacturing.printdocumentation";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            PrintDocumentationView  = new PrintDocumentationView(this); 
            PrintDocumentationView.InitializeControls(); 
           
        }
      
            public PrintDocumentationView PrintDocumentationView {get; set; } 
    }
            
    public partial class PrintDocumentationView : View
    {
        public PrintDocumentationView(PrintDocumentation screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            Site = RPSControlFactory.CreateRPSComboBox<PrintDocumentationView>("9b7e400f-0559-490b-abaf-4692b88c2ad7","","",false, this);
 
            All = RPSControlFactory.CreateRPSOption<PrintDocumentationView>( "aecac591-8094-4986-87e8-aa7384a56bac","","",this);
 
            Selected = RPSControlFactory.CreateRPSOption<PrintDocumentationView>( "5bd60e62-d634-4a0f-941b-535073bf4356","","",this);
 
            ManufacturingOrders = RPSControlFactory.CreateRPSCollectionComboBox<PrintDocumentationView>("5382f2d0-ebc6-4b29-82fa-7e7948c5f8cb","","",false, this);
 
            FromTo = RPSControlFactory.CreateRPSOption<PrintDocumentationView>( "036f526b-77a5-4130-b03b-ad791e979530","","",this);
 
            FromManufacturingOrder = RPSControlFactory.CreateRPSComboBox<PrintDocumentationView>("723aaef8-5302-4495-a518-8607ba4aaf43","","",false, this);
 
            ToManufacturingOrder = RPSControlFactory.CreateRPSComboBox<PrintDocumentationView>("d1eefb96-eeea-462c-87a7-a90802efc5c1","","",false, this);
 
            Projects = RPSControlFactory.CreateRPSCollectionComboBox<PrintDocumentationView>("a69c4577-7338-407d-8f6d-e812cee99e4f","","",false, this);
 
            InternalCode = RPSControlFactory.CreateRPSTextBox<PrintDocumentationView>("d13ec998-539e-42db-b620-b0302ffef4f0","","",false, this);
 
            SituationChange = RPSControlFactory.CreateRPSCheckBox<PrintDocumentationView>("ff433cf8-cda7-4ce3-944c-e5624ff1a386","","",false, this);
 
            ManufacturingOrderSituation = RPSControlFactory.CreateRPSComboBox<PrintDocumentationView>("7bb25362-ddd0-40d2-8f54-67ff4f1eb56d","","",false, this);
 
            ChangeDate = RPSControlFactory.CreateRPSTextBox<PrintDocumentationView>("8a2c1b3a-97fd-49ed-b8b8-76cecfbf6494","","",false, this);
 
            RoadMap = RPSControlFactory.CreateRPSCheckBox<PrintDocumentationView>("5486cbec-7feb-4547-868d-ce1ca387dc3b","","",false, this);
 
            WorkSheet = RPSControlFactory.CreateRPSCheckBox<PrintDocumentationView>("1304cb79-21db-44df-8548-49f9542c7914","","",false, this);
 
            SheetEnd = RPSControlFactory.CreateRPSCheckBox<PrintDocumentationView>("0a11c38b-4cd3-4cd1-8da8-848fb2bd7b2e","","",false, this);
 
            TicketMaterial = RPSControlFactory.CreateRPSCheckBox<PrintDocumentationView>("51d47a5e-4506-4aa6-9f46-2a167ae855e0","","",false, this);
 
            EntryMaterial = RPSControlFactory.CreateRPSCheckBox<PrintDocumentationView>("7a8d63f8-96b2-4989-bd55-d5ce3161f225","","",false, this);
 
            Labels = RPSControlFactory.CreateRPSCheckBox<PrintDocumentationView>("bb762ce6-3961-493e-b39d-da27b33043ac","","",false, this);
 
            ControlSheetVersion = RPSControlFactory.CreateRPSCheckBox<PrintDocumentationView>("7e494bf6-3ae6-4a1a-aff0-28be63e4b31f","","",false, this);
 
            Map = RPSControlFactory.CreateRPSCheckBox<PrintDocumentationView>("d1332e64-5d0e-49b2-8e6d-45dd39a08249","","",false, this);
 
            bManufacturedProduct = RPSControlFactory.CreateRPSCheckBox<PrintDocumentationView>("0d9cd2ca-044b-49f7-a090-714d05d924fd","","",false, this);
 
            bMaterials = RPSControlFactory.CreateRPSCheckBox<PrintDocumentationView>("18997817-10a2-4299-8a88-fde4c544ffb0","","",false, this);
 
            bTasks = RPSControlFactory.CreateRPSCheckBox<PrintDocumentationView>("6773d21a-d493-4b6a-83c8-42b5c6169baa","","",false, this);
 
            IsCompressedOrDecompressed = RPSControlFactory.CreateRPSCheckBox<PrintDocumentationView>("287070ef-03e8-4b5e-a4c5-2784ec072fa9","","",false, this);
 
            Manufactured_Product = RPSControlFactory.CreateRPSEnumComboBox<PrintDocumentationView>("2687abd8-7a72-4f96-88cd-48073a570787","","",false, this);
 
            Materials = RPSControlFactory.CreateRPSEnumComboBox<PrintDocumentationView>("fd814475-0052-4ddf-9696-8cc7aef5de77","","",false, this);
 
            PrintCommandButton = RPSControlFactory.CreateRPSButton<PrintDocumentationView>( "0f4b98d3-fb32-4795-9326-6b6fab4abf8a","","",this);
 

        }
        public IRPSComboBox<PrintDocumentationView> Site { get; set; } 
        public IRPSOption<PrintDocumentationView> All { get; set; } 
        public IRPSOption<PrintDocumentationView> Selected { get; set; } 
        public IRPSCollectionComboBox<PrintDocumentationView> ManufacturingOrders { get; set; } 
        public IRPSOption<PrintDocumentationView> FromTo { get; set; } 
        public IRPSComboBox<PrintDocumentationView> FromManufacturingOrder { get; set; } 
        public IRPSComboBox<PrintDocumentationView> ToManufacturingOrder { get; set; } 
        public IRPSCollectionComboBox<PrintDocumentationView> Projects { get; set; } 
        public IRPSTextBox<PrintDocumentationView> InternalCode { get; set; } 
        public IRPSCheckbox<PrintDocumentationView> SituationChange { get; set; } 
        public IRPSComboBox<PrintDocumentationView> ManufacturingOrderSituation { get; set; } 
        public IRPSTextBox<PrintDocumentationView> ChangeDate { get; set; } 
        public IRPSCheckbox<PrintDocumentationView> RoadMap { get; set; } 
        public IRPSCheckbox<PrintDocumentationView> WorkSheet { get; set; } 
        public IRPSCheckbox<PrintDocumentationView> SheetEnd { get; set; } 
        public IRPSCheckbox<PrintDocumentationView> TicketMaterial { get; set; } 
        public IRPSCheckbox<PrintDocumentationView> EntryMaterial { get; set; } 
        public IRPSCheckbox<PrintDocumentationView> Labels { get; set; } 
        public IRPSCheckbox<PrintDocumentationView> ControlSheetVersion { get; set; } 
        public IRPSCheckbox<PrintDocumentationView> Map { get; set; } 
        public IRPSCheckbox<PrintDocumentationView> bManufacturedProduct { get; set; } 
        public IRPSCheckbox<PrintDocumentationView> bMaterials { get; set; } 
        public IRPSCheckbox<PrintDocumentationView> bTasks { get; set; } 
        public IRPSCheckbox<PrintDocumentationView> IsCompressedOrDecompressed { get; set; } 
        public IRPSComboBox<PrintDocumentationView> Manufactured_Product { get; set; } 
        public IRPSComboBox<PrintDocumentationView> Materials { get; set; } 
        public IRPSButton<PrintDocumentationView> PrintCommandButton { get; set; } 
        public PrintDocumentation Screen { get; set; }
        public PrintDocumentationView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}