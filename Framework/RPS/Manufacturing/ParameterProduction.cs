    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.Manufacturing.ParameterProduction
{
    //RPS VERSION 1.0.0.0
    public partial class ParameterProduction:Screen
    {
        public ParameterProduction():base()
        {
            this.URL = "manufacturing.parameterproduction";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            ParameterProductionEntityView  = new ParameterProductionEntityView(this); 
            ParameterNotifyMOView  = new ParameterNotifyMOView(this); 
            ParameterProductionEntityView.InitializeControls(); 
            ParameterNotifyMOView.InitializeControls(); 
           
        }
      
            public ParameterProductionEntityView ParameterProductionEntityView {get; set; } 
            public ParameterNotifyMOView ParameterNotifyMOView {get; set; } 
    }
            
    public partial class ParameterProductionEntityView : View
    {
        public ParameterProductionEntityView(ParameterProduction screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            ArticlesType34Treatment = RPSControlFactory.CreateRPSEnumComboBox<ParameterProductionEntityView>("da2e14e4-2e05-4e6f-b279-13dfb9bd2147","","",true, this);
 
            IDRouteMain = RPSControlFactory.CreateRPSComboBox<ParameterProductionEntityView>("17e56a7a-400a-4589-95fd-a03bda97496e","","",true, this);
 
            IDHourTypeDefault = RPSControlFactory.CreateRPSComboBox<ParameterProductionEntityView>("96215ecd-0374-41f9-aff6-a338c05c974c","","",false, this);
 
            TimeUnitDefault = RPSControlFactory.CreateRPSEnumComboBox<ParameterProductionEntityView>("087c7fc2-a39c-478f-874f-99957eabedcb","","",true, this);
 
            ControlUserStructure = RPSControlFactory.CreateRPSCheckBox<ParameterProductionEntityView>("9bad307e-6eb7-427e-9257-0d95e1032dbe","","",true, this);
 
            ControlUserManufacturing = RPSControlFactory.CreateRPSCheckBox<ParameterProductionEntityView>("69eb876a-5c57-4728-924c-357180115d9b","","",true, this);
 
            IDCodingSerieManufacturingOrder = RPSControlFactory.CreateRPSComboBox<ParameterProductionEntityView>("70f976b1-9e26-44c5-9119-b1e5e8469600","","",false, this);
 
            IDCodingSerieMultiImputation = RPSControlFactory.CreateRPSComboBox<ParameterProductionEntityView>("c82b8c59-738a-43a4-b827-b1bae63010f2","","",false, this);
 
            IDCodingSerieGroupingNumber = RPSControlFactory.CreateRPSComboBox<ParameterProductionEntityView>("bdd9ba2b-9d94-4803-9003-3a0d53b62aa0","","",false, this);
 
            IDCreateDefaultSituation = RPSControlFactory.CreateRPSComboBox<ParameterProductionEntityView>("3943cf3f-eb8e-44f4-b252-00a2a1095ab1","","",true, this);
 
            IDLaunchedDefaultSituation = RPSControlFactory.CreateRPSComboBox<ParameterProductionEntityView>("4ab4cf44-5b29-4dd3-bf5c-d6de73b829e0","","",true, this);
 
            IDClosedDefaultSituation = RPSControlFactory.CreateRPSComboBox<ParameterProductionEntityView>("d734b8ed-deee-43cc-92fd-882f92bd60a7","","",true, this);
 
            IDMOSituationImputed = RPSControlFactory.CreateRPSComboBox<ParameterProductionEntityView>("61169066-2290-43dd-a9f1-36294b62c5da","","",false, this);
 
            IDStructureType = RPSControlFactory.CreateRPSComboBox<ParameterProductionEntityView>("98a4f096-cbcb-48b2-ad04-5c0fedec61c6","","",false, this);
 
            AlternativeArticles = RPSControlFactory.CreateRPSCheckBox<ParameterProductionEntityView>("f46e2de2-dfcc-4acf-8d50-93b1a940dc31","","",true, this);
 
            CreateQualityLevels = RPSControlFactory.CreateRPSCheckBox<ParameterProductionEntityView>("4f3370a1-6a6f-4919-953a-16635faabf9e","","",true, this);
 
            ManualPlanning = RPSControlFactory.CreateRPSCheckBox<ParameterProductionEntityView>("2a7dae94-cd72-4031-818c-c1cac16b81df","","",true, this);
 
            TaskMaterialExit = RPSControlFactory.CreateRPSCheckBox<ParameterProductionEntityView>("fe31e9bb-c46b-42a9-8c84-b91531f276c7","","",true, this);
 
            ImputationQuantityType = RPSControlFactory.CreateRPSEnumComboBox<ParameterProductionEntityView>("04abd760-a5a5-4b4c-9ca8-023e403c9ffb","","",true, this);
 
            WorkSheetNumberCodingType = RPSControlFactory.CreateRPSEnumComboBox<ParameterProductionEntityView>("54458d5f-de59-4792-a063-e9da1d165112","","",true, this);
 
            IDCodingSerieWorkSheetNumber = RPSControlFactory.CreateRPSComboBox<ParameterProductionEntityView>("027636c1-1d3e-41e7-ba99-6becfbc66621","","",false, this);
 
            ImputationStyle = RPSControlFactory.CreateRPSEnumComboBox<ParameterProductionEntityView>("a065a8df-ad80-475f-8f50-7fc6e7045494","","",true, this);
 
            PendingTime = RPSControlFactory.CreateRPSEnumComboBox<ParameterProductionEntityView>("41484c4b-fcaf-4aa5-b091-878bac27cfa6","","",true, this);
 
            MinimumLevelProd = RPSControlFactory.CreateRPSFormattedTextBox<ParameterProductionEntityView>("153ea3bb-6875-409b-8dfb-7785821f648f","","",true, this);
 
            MediumLevelProd = RPSControlFactory.CreateRPSFormattedTextBox<ParameterProductionEntityView>("7545d911-8aaf-4fa8-9d8b-d6461d4d5c53","","",true, this);
 
            ManPriceCalculation = RPSControlFactory.CreateRPSEnumComboBox<ParameterProductionEntityView>("a8b73a48-f396-4268-adad-db8a24fdcd21","","",true, this);
 
            CostCalculationType = RPSControlFactory.CreateRPSEnumComboBox<ParameterProductionEntityView>("6c29602f-780b-4039-b1aa-768eaddec19a","","",true, this);
 
            ToPriorityLow = RPSControlFactory.CreateRPSFormattedTextBox<ParameterProductionEntityView>("aa1eb3dc-a9c4-474f-bace-42ca9b77c64d","","",true, this);
 
            ToPriorityMedium = RPSControlFactory.CreateRPSFormattedTextBox<ParameterProductionEntityView>("ffbe8fa9-2134-42cb-ba98-b8e5b39dcfcd","","",true, this);
 
            MultiImputationGenerateAuto = RPSControlFactory.CreateRPSCheckBox<ParameterProductionEntityView>("2f60c6b4-1049-4f75-b2c4-044ee5305598","","",true, this);
 
            PercentCompleted = RPSControlFactory.CreateRPSFormattedTextBox<ParameterProductionEntityView>("bc528e71-9012-4707-9563-520878739569","","",true, this);
 
            UpdateEntryPeriodOpen = RPSControlFactory.CreateRPSCheckBox<ParameterProductionEntityView>("cc124707-1510-4656-bc85-5f87790ba668","","",true, this);
 
            AutomaticCodification = RPSControlFactory.CreateRPSCheckBox<ParameterProductionEntityView>("5ffc1555-d02d-44d7-8d79-883081d9d4e5","","",true, this);
 
            PrecodeGroup = RPSControlFactory.CreateRPSTextBox<ParameterProductionEntityView>("f83b9d03-0924-4bd9-90ee-37509fc4ae45","","",false, this);
 
            LengthGroup = RPSControlFactory.CreateRPSFormattedTextBox<ParameterProductionEntityView>("d32cd892-7f89-474e-9695-8f4fab5c93d2","","",true, this);
 
            PrecodeTask = RPSControlFactory.CreateRPSTextBox<ParameterProductionEntityView>("954445cf-de3e-4631-bfbf-990c2e7fd01c","","",false, this);
 
            LengthTask = RPSControlFactory.CreateRPSFormattedTextBox<ParameterProductionEntityView>("6ef38d94-b271-4101-acfa-03461ef8c1de","","",true, this);
 
            PrecodeMaterial = RPSControlFactory.CreateRPSTextBox<ParameterProductionEntityView>("74670d25-18f0-4dd1-b532-8c0981488d62","","",false, this);
 
            LengthMaterial = RPSControlFactory.CreateRPSFormattedTextBox<ParameterProductionEntityView>("cbfd88a9-edee-4ce8-b76d-12445b11b73c","","",true, this);
 
            PrecodeEmployee = RPSControlFactory.CreateRPSTextBox<ParameterProductionEntityView>("d908ea5d-6561-43f4-9a46-a3cd33668cad","","",false, this);
 
            LengthEmployee = RPSControlFactory.CreateRPSFormattedTextBox<ParameterProductionEntityView>("ca5957ec-78fb-45b2-846f-b604e38a47f3","","",true, this);
 
            PrecodeMachine = RPSControlFactory.CreateRPSTextBox<ParameterProductionEntityView>("154e5a0d-cfe8-45c3-9e24-a626fe4d3541","","",false, this);
 
            LengthMachine = RPSControlFactory.CreateRPSFormattedTextBox<ParameterProductionEntityView>("958b5844-f3eb-4caa-8080-638c76b435e0","","",true, this);
 
            PrecodeTool = RPSControlFactory.CreateRPSTextBox<ParameterProductionEntityView>("d5cfd351-ba7b-4fd6-8b56-f1d88cb41a02","","",false, this);
 
            LengthTool = RPSControlFactory.CreateRPSFormattedTextBox<ParameterProductionEntityView>("9b777a43-2dee-45a1-9750-c4db5e9cd08c","","",true, this);
 
            PrecodeCostComponent = RPSControlFactory.CreateRPSTextBox<ParameterProductionEntityView>("b3c0edb2-4af1-4798-a4dd-8acc2387de3b","","",false, this);
 
            LengthCostComponent = RPSControlFactory.CreateRPSFormattedTextBox<ParameterProductionEntityView>("2460c13b-1185-4330-81d0-b4578ba2b796","","",true, this);
 
            PrintRoadMap = RPSControlFactory.CreateRPSCheckBox<ParameterProductionEntityView>("5dbb48a5-e491-45e6-84f2-482c98e3d157","","",true, this);
 
            PrintWorkSheet = RPSControlFactory.CreateRPSCheckBox<ParameterProductionEntityView>("8e5bb0e5-4691-44b3-86e5-a573bcb4fcda","","",true, this);
 
            PrintSheetEnd = RPSControlFactory.CreateRPSCheckBox<ParameterProductionEntityView>("013bc839-8c20-4a92-b8f2-a651fedd788a","","",true, this);
 
            PrintTicketMaterial = RPSControlFactory.CreateRPSCheckBox<ParameterProductionEntityView>("4a6301c8-9d0a-4633-a303-09b3fb7540af","","",true, this);
 
            PrintEntryMaterial = RPSControlFactory.CreateRPSCheckBox<ParameterProductionEntityView>("b5b36b99-9af6-47f5-b810-4f2228993c6a","","",true, this);
 
            PrintLabels = RPSControlFactory.CreateRPSCheckBox<ParameterProductionEntityView>("f5ef2b17-4aaf-4f78-87a9-4c264e181983","","",true, this);
 
            PrintQualityControl = RPSControlFactory.CreateRPSCheckBox<ParameterProductionEntityView>("fb42138e-cea4-42d6-8c10-913bce11c5c4","","",true, this);
 
            PrintMap = RPSControlFactory.CreateRPSCheckBox<ParameterProductionEntityView>("ba508aa0-94fb-4419-abbb-78264f4a8880","","",true, this);
 
            PrintMapManufacturedProduct = RPSControlFactory.CreateRPSCheckBox<ParameterProductionEntityView>("32c30ea9-5adc-40ad-bd4a-ad840446bdd9","","",true, this);
 
            MapManufacturedProductSource = RPSControlFactory.CreateRPSEnumComboBox<ParameterProductionEntityView>("6ae799d5-72d5-4365-b277-4aebe73f05ee","","",true, this);
 
            PrintMapMaterials = RPSControlFactory.CreateRPSCheckBox<ParameterProductionEntityView>("3fedfb15-225e-4935-8ca0-2dcacb882365","","",true, this);
 
            MapMaterialsSource = RPSControlFactory.CreateRPSEnumComboBox<ParameterProductionEntityView>("07653584-1328-4c2b-bcc6-f5ce240748e6","","",true, this);
 
            PrintMapTasks = RPSControlFactory.CreateRPSCheckBox<ParameterProductionEntityView>("03211d73-fad5-4a0e-bdff-e408c96d84c3","","",true, this);
 
            ShowCheckinCheckout = RPSControlFactory.CreateRPSCheckBox<ParameterProductionEntityView>("f2a2e7dc-fd54-4345-b709-8958d177f042","","",true, this);
 
            ProposePendingQuantities = RPSControlFactory.CreateRPSCheckBox<ParameterProductionEntityView>("a447d5ba-9410-4d19-8bf9-e3bc753c2ae6","","",true, this);
 
            CollectionInit params_ParameterNotifyMOs = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="8552e2ee-d8b3-493f-8848-d9f1025b4357",CSSSelectorGrid="",XPathGrid=""};
            ParameterNotifyMOs = RPSControlFactory.RPSCreateCollectionWithGrid<ParameterNotifyMOsCollectionEditor<ParameterProductionEntityView,ParameterNotifyMOView>,ParameterProductionEntityView,ParameterNotifyMOView>( params_ParameterNotifyMOs,this,Screen.ParameterNotifyMOView);
 
            SectionGeneral = RPSControlFactory.CreateRPSSection<ParameterProductionEntityView>( "","ul li[rpsid='98232a20-4147-4785-ba75-fbb41fa1c9cb']","",this);
 
            SectionAutomaticCodification = RPSControlFactory.CreateRPSSection<ParameterProductionEntityView>( "","ul li[rpsid='2658e13e-bbbc-412a-b43f-6083c9541c0f']","",this);
 
            PrintDefaultValues = RPSControlFactory.CreateRPSSection<ParameterProductionEntityView>( "","ul li[rpsid='d246bcf0-04ee-4352-a9b7-0d74f073dfb5']","",this);
 
            Notify = RPSControlFactory.CreateRPSSection<ParameterProductionEntityView>( "","ul li[rpsid='38b6c3af-c0e0-486a-8b4d-00441191ec20']","",this);
 
            DPS = RPSControlFactory.CreateRPSSection<ParameterProductionEntityView>( "","ul li[rpsid='46aec08c-7189-48a2-8503-e71c329dcd6d']","",this);
 

        }
        public IRPSComboBox<ParameterProductionEntityView> ArticlesType34Treatment { get; set; } 
        public IRPSComboBox<ParameterProductionEntityView> IDRouteMain { get; set; } 
        public IRPSComboBox<ParameterProductionEntityView> IDHourTypeDefault { get; set; } 
        public IRPSComboBox<ParameterProductionEntityView> TimeUnitDefault { get; set; } 
        public IRPSCheckbox<ParameterProductionEntityView> ControlUserStructure { get; set; } 
        public IRPSCheckbox<ParameterProductionEntityView> ControlUserManufacturing { get; set; } 
        public IRPSComboBox<ParameterProductionEntityView> IDCodingSerieManufacturingOrder { get; set; } 
        public IRPSComboBox<ParameterProductionEntityView> IDCodingSerieMultiImputation { get; set; } 
        public IRPSComboBox<ParameterProductionEntityView> IDCodingSerieGroupingNumber { get; set; } 
        public IRPSComboBox<ParameterProductionEntityView> IDCreateDefaultSituation { get; set; } 
        public IRPSComboBox<ParameterProductionEntityView> IDLaunchedDefaultSituation { get; set; } 
        public IRPSComboBox<ParameterProductionEntityView> IDClosedDefaultSituation { get; set; } 
        public IRPSComboBox<ParameterProductionEntityView> IDMOSituationImputed { get; set; } 
        public IRPSComboBox<ParameterProductionEntityView> IDStructureType { get; set; } 
        public IRPSCheckbox<ParameterProductionEntityView> AlternativeArticles { get; set; } 
        public IRPSCheckbox<ParameterProductionEntityView> CreateQualityLevels { get; set; } 
        public IRPSCheckbox<ParameterProductionEntityView> ManualPlanning { get; set; } 
        public IRPSCheckbox<ParameterProductionEntityView> TaskMaterialExit { get; set; } 
        public IRPSComboBox<ParameterProductionEntityView> ImputationQuantityType { get; set; } 
        public IRPSComboBox<ParameterProductionEntityView> WorkSheetNumberCodingType { get; set; } 
        public IRPSComboBox<ParameterProductionEntityView> IDCodingSerieWorkSheetNumber { get; set; } 
        public IRPSComboBox<ParameterProductionEntityView> ImputationStyle { get; set; } 
        public IRPSComboBox<ParameterProductionEntityView> PendingTime { get; set; } 
        public IRPSTextBox<ParameterProductionEntityView> MinimumLevelProd { get; set; } 
        public IRPSTextBox<ParameterProductionEntityView> MediumLevelProd { get; set; } 
        public IRPSComboBox<ParameterProductionEntityView> ManPriceCalculation { get; set; } 
        public IRPSComboBox<ParameterProductionEntityView> CostCalculationType { get; set; } 
        public IRPSTextBox<ParameterProductionEntityView> ToPriorityLow { get; set; } 
        public IRPSTextBox<ParameterProductionEntityView> ToPriorityMedium { get; set; } 
        public IRPSCheckbox<ParameterProductionEntityView> MultiImputationGenerateAuto { get; set; } 
        public IRPSTextBox<ParameterProductionEntityView> PercentCompleted { get; set; } 
        public IRPSCheckbox<ParameterProductionEntityView> UpdateEntryPeriodOpen { get; set; } 
        public IRPSCheckbox<ParameterProductionEntityView> AutomaticCodification { get; set; } 
        public IRPSTextBox<ParameterProductionEntityView> PrecodeGroup { get; set; } 
        public IRPSTextBox<ParameterProductionEntityView> LengthGroup { get; set; } 
        public IRPSTextBox<ParameterProductionEntityView> PrecodeTask { get; set; } 
        public IRPSTextBox<ParameterProductionEntityView> LengthTask { get; set; } 
        public IRPSTextBox<ParameterProductionEntityView> PrecodeMaterial { get; set; } 
        public IRPSTextBox<ParameterProductionEntityView> LengthMaterial { get; set; } 
        public IRPSTextBox<ParameterProductionEntityView> PrecodeEmployee { get; set; } 
        public IRPSTextBox<ParameterProductionEntityView> LengthEmployee { get; set; } 
        public IRPSTextBox<ParameterProductionEntityView> PrecodeMachine { get; set; } 
        public IRPSTextBox<ParameterProductionEntityView> LengthMachine { get; set; } 
        public IRPSTextBox<ParameterProductionEntityView> PrecodeTool { get; set; } 
        public IRPSTextBox<ParameterProductionEntityView> LengthTool { get; set; } 
        public IRPSTextBox<ParameterProductionEntityView> PrecodeCostComponent { get; set; } 
        public IRPSTextBox<ParameterProductionEntityView> LengthCostComponent { get; set; } 
        public IRPSCheckbox<ParameterProductionEntityView> PrintRoadMap { get; set; } 
        public IRPSCheckbox<ParameterProductionEntityView> PrintWorkSheet { get; set; } 
        public IRPSCheckbox<ParameterProductionEntityView> PrintSheetEnd { get; set; } 
        public IRPSCheckbox<ParameterProductionEntityView> PrintTicketMaterial { get; set; } 
        public IRPSCheckbox<ParameterProductionEntityView> PrintEntryMaterial { get; set; } 
        public IRPSCheckbox<ParameterProductionEntityView> PrintLabels { get; set; } 
        public IRPSCheckbox<ParameterProductionEntityView> PrintQualityControl { get; set; } 
        public IRPSCheckbox<ParameterProductionEntityView> PrintMap { get; set; } 
        public IRPSCheckbox<ParameterProductionEntityView> PrintMapManufacturedProduct { get; set; } 
        public IRPSComboBox<ParameterProductionEntityView> MapManufacturedProductSource { get; set; } 
        public IRPSCheckbox<ParameterProductionEntityView> PrintMapMaterials { get; set; } 
        public IRPSComboBox<ParameterProductionEntityView> MapMaterialsSource { get; set; } 
        public IRPSCheckbox<ParameterProductionEntityView> PrintMapTasks { get; set; } 
        public IRPSCheckbox<ParameterProductionEntityView> ShowCheckinCheckout { get; set; } 
        public IRPSCheckbox<ParameterProductionEntityView> ProposePendingQuantities { get; set; } 
        public ParameterNotifyMOsCollectionEditor<ParameterProductionEntityView,ParameterNotifyMOView> ParameterNotifyMOs { get; set; } 
        public IRPSSection<ParameterProductionEntityView> SectionGeneral { get; set; } 
        public IRPSSection<ParameterProductionEntityView> SectionAutomaticCodification { get; set; } 
        public IRPSSection<ParameterProductionEntityView> PrintDefaultValues { get; set; } 
        public IRPSSection<ParameterProductionEntityView> Notify { get; set; } 
        public IRPSSection<ParameterProductionEntityView> DPS { get; set; } 
        public ParameterProduction Screen { get; set; }
        public ParameterProductionEntityView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class ParameterNotifyMOsCollectionEditor<ParameterProductionEntityView,ParameterNotifyMOView>:RPSCollectionEditor<ParameterProductionEntityView,ParameterNotifyMOView> where ParameterProductionEntityView : class, IView where ParameterNotifyMOView : class, IView
    {
        public  ParameterNotifyMOsGridView<ParameterProductionEntityView,ParameterNotifyMOView> GridView {get;set;}
    }
    public partial class ParameterNotifyMOsGridView <ParameterProductionEntityView,ParameterNotifyMOView> :  RPSGridView<ParameterProductionEntityView,ParameterNotifyMOView> where ParameterProductionEntityView : class, IView where ParameterNotifyMOView : class, IView
    {
        public ParameterNotifyMOsGridView(ParameterProductionEntityView currentView,ParameterNotifyMOView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            CodUser = RPSControlFactory.CreateRPSGridComboBox<ParameterProductionEntityView>("","#8552e2ee-d8b3-493f-8848-d9f1025b4357 .ag-row[role='row']@ROWINDEX [col-id='cCodUser']","",false, this.CurrentView);
 
            CodRole = RPSControlFactory.CreateRPSGridComboBox<ParameterProductionEntityView>("","#8552e2ee-d8b3-493f-8848-d9f1025b4357 .ag-row[role='row']@ROWINDEX [col-id='cCodRole']","",false, this.CurrentView);
 

        }
        public IRPSGridComboBox<ParameterProductionEntityView> CodUser { get; set; } 
        public IRPSGridComboBox<ParameterProductionEntityView> CodRole { get; set; } 
                     
    }
 
    }
  
            
    public partial class ParameterNotifyMOView : View
    {
        public ParameterNotifyMOView(ParameterProduction screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            DeleteButton = RPSControlFactory.RPSDeleteButton<ParameterNotifyMOView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<ParameterNotifyMOView,ParameterProductionEntityView>( this,Screen.ParameterProductionEntityView);
 
            BackButton = RPSControlFactory.RPSBackButton<ParameterNotifyMOView,ParameterProductionEntityView>( this,Screen.ParameterProductionEntityView);
 
            AcceptButton = RPSControlFactory.RPSAcceptButton<ParameterNotifyMOView,ParameterProductionEntityView>( this,Screen.ParameterProductionEntityView);
 
            CodUser = RPSControlFactory.CreateRPSComboBox<ParameterNotifyMOView>("49e84fee-af39-40a9-99b3-aa3308e045ab","","",false, this);
 
            CodRole = RPSControlFactory.CreateRPSComboBox<ParameterNotifyMOView>("9e443744-02bf-47e9-805e-917014107e6f","","",false, this);
 

        }
        public IRPSButton<ParameterNotifyMOView> DeleteButton { get; set; } 
        public IRPSButton<ParameterNotifyMOView,ParameterProductionEntityView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<ParameterNotifyMOView,ParameterProductionEntityView> BackButton { get; set; } 
        public IRPSAcceptButton<ParameterNotifyMOView,ParameterProductionEntityView> AcceptButton { get; set; } 
        public IRPSComboBox<ParameterNotifyMOView> CodUser { get; set; } 
        public IRPSComboBox<ParameterNotifyMOView> CodRole { get; set; } 
        public ParameterProduction Screen { get; set; }
        public ParameterNotifyMOView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}