    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.Warehouse.Parameter
{
    //RPS VERSION 1.0.0.0
    public partial class Parameter:Screen
    {
        public Parameter():base()
        {
            this.URL = "warehouse.parameter";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            ParameterStockEntityView  = new ParameterStockEntityView(this); 
            ParameterStockEntityView.InitializeControls(); 
           
        }
      
            public ParameterStockEntityView ParameterStockEntityView {get; set; } 
    }
            
    public partial class ParameterStockEntityView : View
    {
        public ParameterStockEntityView(Parameter screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            RealCost = RPSControlFactory.CreateRPSEnumComboBox<ParameterStockEntityView>("00491389-972d-4da2-af96-954d34cd5140","","",true, this);
 
            CostArticle = RPSControlFactory.CreateRPSCheckBox<ParameterStockEntityView>("2dec09f7-89b1-4201-912c-21ca9b479074","","",true, this);
 
            PermanentInventory = RPSControlFactory.CreateRPSCheckBox<ParameterStockEntityView>("29971124-2d3b-42ba-97ff-ddf98834624b","","",true, this);
 
            PreliminaryMovement = RPSControlFactory.CreateRPSCheckBox<ParameterStockEntityView>("e6eed9ef-8d01-4806-955b-f28bf64dcf1b","","",true, this);
 
            CodLocationWarehouse = RPSControlFactory.CreateRPSTextBox<ParameterStockEntityView>("e3c71043-5467-43df-82ac-81211b5e5ae2","","",false, this);
 
            ClosedDate = RPSControlFactory.CreateRPSTextBox<ParameterStockEntityView>("bb51a380-c136-476a-8fa9-644e8ef1449e","","",false, this);
 
            NotMaterialTaskClosed = RPSControlFactory.CreateRPSCheckBox<ParameterStockEntityView>("38ff90fd-bd84-4f38-a876-f6a1d7c8674f","","",true, this);
 
            ValuationCostType = RPSControlFactory.CreateRPSEnumComboBox<ParameterStockEntityView>("a91cfe90-339c-45bf-901f-93dea7d9f6f4","","",true, this);
 
            DuplicateMCodeArticle = RPSControlFactory.CreateRPSCheckBox<ParameterStockEntityView>("b582d938-d11e-48c4-9485-20bb3895e8c7","","",true, this);
 
            IDArticleClassification = RPSControlFactory.CreateRPSComboBox<ParameterStockEntityView>("1c66d4f0-d364-4a11-96de-c811d6aee307","","",false, this);
 
            IDCodingSerieArticle = RPSControlFactory.CreateRPSComboBox<ParameterStockEntityView>("0cdd2996-db99-4fa7-8b7d-996242f0f2a4","","",false, this);
 
            CorrelativeCodingGroup = RPSControlFactory.CreateRPSCheckBox<ParameterStockEntityView>("ee27b3e8-ef61-4ea4-89e6-3ae65a6a67ee","","",true, this);
 
            OrderProductLine = RPSControlFactory.CreateRPSEnumComboBox<ParameterStockEntityView>("e2df5594-c429-4f5b-8862-6c50e74eafbd","","",true, this);
 
            OrderProductFamily = RPSControlFactory.CreateRPSEnumComboBox<ParameterStockEntityView>("f30b860a-7bd7-45cf-ae30-e22a2e7810d9","","",true, this);
 
            OrderProductSubFamily = RPSControlFactory.CreateRPSEnumComboBox<ParameterStockEntityView>("d8c32d36-41c8-4d29-8e50-8685869544ed","","",true, this);
 
            OrderCostSupplierArticle = RPSControlFactory.CreateRPSEnumComboBox<ParameterStockEntityView>("68669336-63e5-436a-b4de-dd15450aa8f4","","",true, this);
 
            OrderCostArticle = RPSControlFactory.CreateRPSEnumComboBox<ParameterStockEntityView>("1c9e913f-e7aa-458e-b719-45e0839fdcc4","","",true, this);
 
            CostsReconstruction = RPSControlFactory.CreateRPSCheckBox<ParameterStockEntityView>("4a14f738-34ef-4639-8947-d2c67596d607","","",true, this);
 
            SalesReconstruction = RPSControlFactory.CreateRPSCheckBox<ParameterStockEntityView>("9286d6d9-211d-4b66-9da5-97c94f3cd29e","","",true, this);
 
            ManufacturingReconstruction = RPSControlFactory.CreateRPSCheckBox<ParameterStockEntityView>("76cc48e2-413d-4388-be7b-ae2b897eb6e1","","",true, this);
 
            ProjectReconstruction = RPSControlFactory.CreateRPSCheckBox<ParameterStockEntityView>("da59d38b-6317-475f-838a-6136388625e1","","",false, this);
 
            MaintenanceReconstruction = RPSControlFactory.CreateRPSCheckBox<ParameterStockEntityView>("1d1372c5-20bc-414e-bba3-2736e1718570","","",false, this);
 
            MovementBeforeInventary = RPSControlFactory.CreateRPSCheckBox<ParameterStockEntityView>("d548e72b-9030-45ba-898f-778d75de9711","","",true, this);
 
            StockReconstruction = RPSControlFactory.CreateRPSCheckBox<ParameterStockEntityView>("9597bfad-2f76-49c0-bbf7-af4bd149977d","","",true, this);
 
            IDMovementTypeManufacturingE = RPSControlFactory.CreateRPSComboBox<ParameterStockEntityView>("31f69879-3872-4448-a7ce-55c1c105f3ff","","",true, this);
 
            IDMovementTypeProjectE = RPSControlFactory.CreateRPSComboBox<ParameterStockEntityView>("6e88ce0a-0815-4f92-a0ad-2da771f2cabb","","",true, this);
 
            IDMovementTypeMaintenanceE = RPSControlFactory.CreateRPSComboBox<ParameterStockEntityView>("86407d7f-d6b2-4082-b8dd-7338aec37501","","",true, this);
 
            IDMovementTypePurchaseE = RPSControlFactory.CreateRPSComboBox<ParameterStockEntityView>("79d923b1-1b23-400f-9bca-1fcf78090fba","","",true, this);
 
            IDMovementTypePurchaseQualityE = RPSControlFactory.CreateRPSComboBox<ParameterStockEntityView>("f68e3280-a307-4c6e-bd68-bfae0b109045","","",true, this);
 
            IDMovementTypeSalesE = RPSControlFactory.CreateRPSComboBox<ParameterStockEntityView>("ca51c16d-d732-404d-8361-20ad5de2174b","","",true, this);
 
            IDMovementTypeSalesTransferE = RPSControlFactory.CreateRPSComboBox<ParameterStockEntityView>("cb4c91b0-f31a-4470-a9fc-875cc707abde","","",true, this);
 
            IDMovementTypePurTransferE = RPSControlFactory.CreateRPSComboBox<ParameterStockEntityView>("945f5751-bc0a-491c-a953-3924667a152a","","",true, this);
 
            IDMovementTypeManufacturingON = RPSControlFactory.CreateRPSComboBox<ParameterStockEntityView>("104f2fa4-3173-4ed2-a195-6762c1b25cc5","","",true, this);
 
            IDMovementTypeManufacturingO = RPSControlFactory.CreateRPSComboBox<ParameterStockEntityView>("ff5d4244-693c-4546-abc1-04de9eeb7e82","","",true, this);
 
            IDMovementTypeProjectO = RPSControlFactory.CreateRPSComboBox<ParameterStockEntityView>("4d1523bf-b4a2-4ea4-a37b-7a7eff9e6ba4","","",true, this);
 
            IDMovementTypeMaintenanceO = RPSControlFactory.CreateRPSComboBox<ParameterStockEntityView>("f320c082-2b3a-45e2-8eb4-5ba3a33f6e3d","","",true, this);
 
            IDMovementTypePurchaseO = RPSControlFactory.CreateRPSComboBox<ParameterStockEntityView>("159d85d4-4947-4318-9958-651043090b08","","",true, this);
 
            IDMovementTypePurchaseQualityO = RPSControlFactory.CreateRPSComboBox<ParameterStockEntityView>("74327af2-740c-470c-a904-f6d40ea7fffc","","",true, this);
 
            IDMovementTypeSalesO = RPSControlFactory.CreateRPSComboBox<ParameterStockEntityView>("7539f8d5-6b10-4d43-9155-92c0bbaed4e8","","",true, this);
 
            IDMovementTypeSalesTransferO = RPSControlFactory.CreateRPSComboBox<ParameterStockEntityView>("8c953d05-30d0-4e0a-aa81-c178a80badac","","",true, this);
 
            IDMovementTypePurTransferO = RPSControlFactory.CreateRPSComboBox<ParameterStockEntityView>("d71ee1d1-68e8-4f54-9d2b-8ef1c21e4022","","",true, this);
 
            IDMovementTypeManufacturingEN = RPSControlFactory.CreateRPSComboBox<ParameterStockEntityView>("628514dd-6f0f-470f-b2c8-d982db1e4d06","","",true, this);
 
            IDMovementTypeTransferQuality = RPSControlFactory.CreateRPSComboBox<ParameterStockEntityView>("8c5a5731-5d12-4ccb-a621-13190d6a1c0f","","",false, this);
 
            IDMovTypeQualityAcceptation = RPSControlFactory.CreateRPSComboBox<ParameterStockEntityView>("02321534-15f0-4a16-af0a-3a85bf528867","","",false, this);
 
            IDCodingSerieEan = RPSControlFactory.CreateRPSComboBox<ParameterStockEntityView>("617a52cf-1693-4d87-8547-e4ba8b83f8d0","","",false, this);
 
            EanArticlePosition = RPSControlFactory.CreateRPSFormattedTextBox<ParameterStockEntityView>("f2bb661a-aeb5-44ff-983d-1350c181852d","","",true, this);
 
            PeriodDayNumber = RPSControlFactory.CreateRPSEnumComboBox<ParameterStockEntityView>("fee0498a-dd8d-44eb-9ab8-5a197c08e96a","","",true, this);
 
            ConsumePrevisionCalc = RPSControlFactory.CreateRPSEnumComboBox<ParameterStockEntityView>("f0d2cea1-b3e0-4928-bcac-a646e51a06c2","","",true, this);
 
            PeriodNumber = RPSControlFactory.CreateRPSFormattedTextBox<ParameterStockEntityView>("7ce36345-5400-4670-9e4d-0993b09bf691","","",true, this);
 
            CorrectionFactor = RPSControlFactory.CreateRPSFormattedTextBox<ParameterStockEntityView>("a0fe9af5-3c88-4101-bc2c-7ffac002e2b6","","",true, this);
 
            ShowCheckInCheckOut = RPSControlFactory.CreateRPSCheckBox<ParameterStockEntityView>("3a735108-08c5-45e9-868a-ec20d781fb06","","",true, this);
 
            AllowStartBeforeCheckIn = RPSControlFactory.CreateRPSCheckBox<ParameterStockEntityView>("1922ac2f-f87f-405f-9156-96f2c3508c98","","",true, this);
 
            KeepLastEntryDateSerie = RPSControlFactory.CreateRPSCheckBox<ParameterStockEntityView>("2712d866-ba0a-4eef-8e61-ffd74fa855fc","","",true, this);
 
            GeneralSection = RPSControlFactory.CreateRPSSection<ParameterStockEntityView>( "","ul li[rpsid='e47804d0-e1b2-4005-84c7-8bd9bfe9a4f5']","",this);
 
            DPSSection = RPSControlFactory.CreateRPSSection<ParameterStockEntityView>( "","ul li[rpsid='61bb4399-6533-47ec-b192-6fcd93537aca']","",this);
 

        }
        public IRPSComboBox<ParameterStockEntityView> RealCost { get; set; } 
        public IRPSCheckbox<ParameterStockEntityView> CostArticle { get; set; } 
        public IRPSCheckbox<ParameterStockEntityView> PermanentInventory { get; set; } 
        public IRPSCheckbox<ParameterStockEntityView> PreliminaryMovement { get; set; } 
        public IRPSTextBox<ParameterStockEntityView> CodLocationWarehouse { get; set; } 
        public IRPSTextBox<ParameterStockEntityView> ClosedDate { get; set; } 
        public IRPSCheckbox<ParameterStockEntityView> NotMaterialTaskClosed { get; set; } 
        public IRPSComboBox<ParameterStockEntityView> ValuationCostType { get; set; } 
        public IRPSCheckbox<ParameterStockEntityView> DuplicateMCodeArticle { get; set; } 
        public IRPSComboBox<ParameterStockEntityView> IDArticleClassification { get; set; } 
        public IRPSComboBox<ParameterStockEntityView> IDCodingSerieArticle { get; set; } 
        public IRPSCheckbox<ParameterStockEntityView> CorrelativeCodingGroup { get; set; } 
        public IRPSComboBox<ParameterStockEntityView> OrderProductLine { get; set; } 
        public IRPSComboBox<ParameterStockEntityView> OrderProductFamily { get; set; } 
        public IRPSComboBox<ParameterStockEntityView> OrderProductSubFamily { get; set; } 
        public IRPSComboBox<ParameterStockEntityView> OrderCostSupplierArticle { get; set; } 
        public IRPSComboBox<ParameterStockEntityView> OrderCostArticle { get; set; } 
        public IRPSCheckbox<ParameterStockEntityView> CostsReconstruction { get; set; } 
        public IRPSCheckbox<ParameterStockEntityView> SalesReconstruction { get; set; } 
        public IRPSCheckbox<ParameterStockEntityView> ManufacturingReconstruction { get; set; } 
        public IRPSCheckbox<ParameterStockEntityView> ProjectReconstruction { get; set; } 
        public IRPSCheckbox<ParameterStockEntityView> MaintenanceReconstruction { get; set; } 
        public IRPSCheckbox<ParameterStockEntityView> MovementBeforeInventary { get; set; } 
        public IRPSCheckbox<ParameterStockEntityView> StockReconstruction { get; set; } 
        public IRPSComboBox<ParameterStockEntityView> IDMovementTypeManufacturingE { get; set; } 
        public IRPSComboBox<ParameterStockEntityView> IDMovementTypeProjectE { get; set; } 
        public IRPSComboBox<ParameterStockEntityView> IDMovementTypeMaintenanceE { get; set; } 
        public IRPSComboBox<ParameterStockEntityView> IDMovementTypePurchaseE { get; set; } 
        public IRPSComboBox<ParameterStockEntityView> IDMovementTypePurchaseQualityE { get; set; } 
        public IRPSComboBox<ParameterStockEntityView> IDMovementTypeSalesE { get; set; } 
        public IRPSComboBox<ParameterStockEntityView> IDMovementTypeSalesTransferE { get; set; } 
        public IRPSComboBox<ParameterStockEntityView> IDMovementTypePurTransferE { get; set; } 
        public IRPSComboBox<ParameterStockEntityView> IDMovementTypeManufacturingON { get; set; } 
        public IRPSComboBox<ParameterStockEntityView> IDMovementTypeManufacturingO { get; set; } 
        public IRPSComboBox<ParameterStockEntityView> IDMovementTypeProjectO { get; set; } 
        public IRPSComboBox<ParameterStockEntityView> IDMovementTypeMaintenanceO { get; set; } 
        public IRPSComboBox<ParameterStockEntityView> IDMovementTypePurchaseO { get; set; } 
        public IRPSComboBox<ParameterStockEntityView> IDMovementTypePurchaseQualityO { get; set; } 
        public IRPSComboBox<ParameterStockEntityView> IDMovementTypeSalesO { get; set; } 
        public IRPSComboBox<ParameterStockEntityView> IDMovementTypeSalesTransferO { get; set; } 
        public IRPSComboBox<ParameterStockEntityView> IDMovementTypePurTransferO { get; set; } 
        public IRPSComboBox<ParameterStockEntityView> IDMovementTypeManufacturingEN { get; set; } 
        public IRPSComboBox<ParameterStockEntityView> IDMovementTypeTransferQuality { get; set; } 
        public IRPSComboBox<ParameterStockEntityView> IDMovTypeQualityAcceptation { get; set; } 
        public IRPSComboBox<ParameterStockEntityView> IDCodingSerieEan { get; set; } 
        public IRPSTextBox<ParameterStockEntityView> EanArticlePosition { get; set; } 
        public IRPSComboBox<ParameterStockEntityView> PeriodDayNumber { get; set; } 
        public IRPSComboBox<ParameterStockEntityView> ConsumePrevisionCalc { get; set; } 
        public IRPSTextBox<ParameterStockEntityView> PeriodNumber { get; set; } 
        public IRPSTextBox<ParameterStockEntityView> CorrectionFactor { get; set; } 
        public IRPSCheckbox<ParameterStockEntityView> ShowCheckInCheckOut { get; set; } 
        public IRPSCheckbox<ParameterStockEntityView> AllowStartBeforeCheckIn { get; set; } 
        public IRPSCheckbox<ParameterStockEntityView> KeepLastEntryDateSerie { get; set; } 
        public IRPSSection<ParameterStockEntityView> GeneralSection { get; set; } 
        public IRPSSection<ParameterStockEntityView> DPSSection { get; set; } 
        public Parameter Screen { get; set; }
        public ParameterStockEntityView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}