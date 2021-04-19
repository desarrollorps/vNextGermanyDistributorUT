    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.Manufacturing.CuDistExcelImportMaterial
{
    //RPS VERSION 1.0.0.0
    public partial class CuDistExcelImportMaterial:Screen
    {
        public CuDistExcelImportMaterial():base()
        {
            this.URL = "manufacturing.cudistexcelimportmaterial";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            CuDistExcelImportMaterialView  = new CuDistExcelImportMaterialView(this); 
            CuDistExcelImportMaterialView.InitializeControls(); 
           
        }
      
            public CuDistExcelImportMaterialView CuDistExcelImportMaterialView {get; set; } 
    }
            
    public partial class CuDistExcelImportMaterialView : View
    {
        public CuDistExcelImportMaterialView(CuDistExcelImportMaterial screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            IDSite = RPSControlFactory.CreateRPSComboBox<CuDistExcelImportMaterialView>("fca5b5c6-0650-4ded-b9f9-3b9876d13203","","",false, this);
 
            IDArticle = RPSControlFactory.CreateRPSComboBox<CuDistExcelImportMaterialView>("0dd92655-2d13-43a7-bea1-2ac8e254f23d","","",false, this);
 
            LoadExcelCommand = RPSControlFactory.CreateRPSButton<CuDistExcelImportMaterialView>( "1ff25550-159e-4cba-97f9-baa03b2dc6c5","","",this);
 
            IDStructure = RPSControlFactory.CreateRPSComboBox<CuDistExcelImportMaterialView>("29c2940e-d45d-4a6f-be11-0e23510b0442","","",false, this);
 
            ImportCommand = RPSControlFactory.CreateRPSButton<CuDistExcelImportMaterialView>( "d478d846-08ab-42ff-9d63-0b6aa7d5f24a","","",this);
 
            IDTask = RPSControlFactory.CreateRPSComboBox<CuDistExcelImportMaterialView>("488bf0cf-6ef5-4fb9-a3f3-f4d90f8ae158","","",false, this);
 
            IDCuDistExcelStrImport = RPSControlFactory.CreateRPSComboBox<CuDistExcelImportMaterialView>("83acfd31-e537-4f31-a349-00d276f0224d","","",false, this);
 
            DeleteMissingMaterials = RPSControlFactory.CreateRPSCheckBox<CuDistExcelImportMaterialView>("5d7e9b71-8032-4e8a-99fa-09b76af04bad","","",false, this);
 
            CollectionInit params_ImportMaterialsCollection = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="a0b15a60-2c2d-4b84-a9c8-b8c5a47a2b01",CSSSelectorGrid="",XPathGrid=""};
            ImportMaterialsCollection = RPSControlFactory.RPSCreateCollectionWithGrid<ImportMaterialsCollectionCollectionEditor<CuDistExcelImportMaterialView>,CuDistExcelImportMaterialView>( params_ImportMaterialsCollection,this);
 

        }
        public IRPSComboBox<CuDistExcelImportMaterialView> IDSite { get; set; } 
        public IRPSComboBox<CuDistExcelImportMaterialView> IDArticle { get; set; } 
        public IRPSButton<CuDistExcelImportMaterialView> LoadExcelCommand { get; set; } 
        public IRPSComboBox<CuDistExcelImportMaterialView> IDStructure { get; set; } 
        public IRPSButton<CuDistExcelImportMaterialView> ImportCommand { get; set; } 
        public IRPSComboBox<CuDistExcelImportMaterialView> IDTask { get; set; } 
        public IRPSComboBox<CuDistExcelImportMaterialView> IDCuDistExcelStrImport { get; set; } 
        public IRPSCheckbox<CuDistExcelImportMaterialView> DeleteMissingMaterials { get; set; } 
        public ImportMaterialsCollectionCollectionEditor<CuDistExcelImportMaterialView> ImportMaterialsCollection { get; set; } 
        public CuDistExcelImportMaterial Screen { get; set; }
        public CuDistExcelImportMaterialView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class ImportMaterialsCollectionCollectionEditor<CuDistExcelImportMaterialView>:RPSCollectionEditor<CuDistExcelImportMaterialView> where CuDistExcelImportMaterialView : class, IView
    {
        public  ImportMaterialsCollectionGridView<CuDistExcelImportMaterialView> GridView {get;set;}
    }
    public partial class ImportMaterialsCollectionGridView <CuDistExcelImportMaterialView> :  RPSGridView<CuDistExcelImportMaterialView> where CuDistExcelImportMaterialView : class, IView
    {
        public ImportMaterialsCollectionGridView(CuDistExcelImportMaterialView currentView)
        {
            this.WebDriver = currentView.WebDriver;          
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            ActionTypeDesc = RPSControlFactory.CreateRPSGridTextBox<CuDistExcelImportMaterialView>("","#a0b15a60-2c2d-4b84-a9c8-b8c5a47a2b01 .ag-row[role='row']@ROWINDEX [col-id='cActionTypeDesc']","",false, this.CurrentView);
 
            CodMaterial = RPSControlFactory.CreateRPSGridTextBox<CuDistExcelImportMaterialView>("","#a0b15a60-2c2d-4b84-a9c8-b8c5a47a2b01 .ag-row[role='row']@ROWINDEX [col-id='cCodMaterial']","",false, this.CurrentView);
 
            IDArticle = RPSControlFactory.CreateRPSGridComboBox<CuDistExcelImportMaterialView>("","#a0b15a60-2c2d-4b84-a9c8-b8c5a47a2b01 .ag-row[role='row']@ROWINDEX [col-id='cIDArticle']","",false, this.CurrentView);
 
            Description = RPSControlFactory.CreateRPSGridTextBox<CuDistExcelImportMaterialView>("","#a0b15a60-2c2d-4b84-a9c8-b8c5a47a2b01 .ag-row[role='row']@ROWINDEX [col-id='cDescription']","",false, this.CurrentView);
 
            Quantity = RPSControlFactory.CreateRPSGridFormattedTextBox<CuDistExcelImportMaterialView>("","#a0b15a60-2c2d-4b84-a9c8-b8c5a47a2b01 .ag-row[role='row']@ROWINDEX [col-id='cQuantity']","",false, this.CurrentView);
 
            ContentLot = RPSControlFactory.CreateRPSGridFormattedTextBox<CuDistExcelImportMaterialView>("","#a0b15a60-2c2d-4b84-a9c8-b8c5a47a2b01 .ag-row[role='row']@ROWINDEX [col-id='cContentLot']","",false, this.CurrentView);
 
            Notes = RPSControlFactory.CreateRPSGridMemoTextBox<CuDistExcelImportMaterialView>("","#a0b15a60-2c2d-4b84-a9c8-b8c5a47a2b01 .ag-row[role='row']@ROWINDEX [col-id='cNotes']","",false, this.CurrentView);
 
            IDSite = RPSControlFactory.CreateRPSGridComboBox<CuDistExcelImportMaterialView>("","#a0b15a60-2c2d-4b84-a9c8-b8c5a47a2b01 .ag-row[role='row']@ROWINDEX [col-id='cIDSite']","",false, this.CurrentView);
 
            IDWareHouse = RPSControlFactory.CreateRPSGridComboBox<CuDistExcelImportMaterialView>("","#a0b15a60-2c2d-4b84-a9c8-b8c5a47a2b01 .ag-row[role='row']@ROWINDEX [col-id='cIDWareHouse']","",false, this.CurrentView);
 
            MakeAutomaticOutput = RPSControlFactory.CreateRPSGridCheckBox<CuDistExcelImportMaterialView>("","#a0b15a60-2c2d-4b84-a9c8-b8c5a47a2b01 .ag-row[role='row']@ROWINDEX [col-id='cMakeAutomaticOutput']","",false, this.CurrentView);
 
            ImputationCostUpdated = RPSControlFactory.CreateRPSGridCheckBox<CuDistExcelImportMaterialView>("","#a0b15a60-2c2d-4b84-a9c8-b8c5a47a2b01 .ag-row[role='row']@ROWINDEX [col-id='cImputationCostUpdated']","",false, this.CurrentView);
 
            IDBudgetCategory = RPSControlFactory.CreateRPSGridComboBox<CuDistExcelImportMaterialView>("","#a0b15a60-2c2d-4b84-a9c8-b8c5a47a2b01 .ag-row[role='row']@ROWINDEX [col-id='cIDBudgetCategory']","",false, this.CurrentView);
 
            QuantityElements = RPSControlFactory.CreateRPSGridFormattedTextBox<CuDistExcelImportMaterialView>("","#a0b15a60-2c2d-4b84-a9c8-b8c5a47a2b01 .ag-row[role='row']@ROWINDEX [col-id='cQuantityElements']","",false, this.CurrentView);
 
            CompensatingFactor = RPSControlFactory.CreateRPSGridFormattedTextBox<CuDistExcelImportMaterialView>("","#a0b15a60-2c2d-4b84-a9c8-b8c5a47a2b01 .ag-row[role='row']@ROWINDEX [col-id='cCompensatingFactor']","",false, this.CurrentView);
 
            Potency = RPSControlFactory.CreateRPSGridFormattedTextBox<CuDistExcelImportMaterialView>("","#a0b15a60-2c2d-4b84-a9c8-b8c5a47a2b01 .ag-row[role='row']@ROWINDEX [col-id='cPotency']","",false, this.CurrentView);
 
            AdvanceDays = RPSControlFactory.CreateRPSGridFormattedTextBox<CuDistExcelImportMaterialView>("","#a0b15a60-2c2d-4b84-a9c8-b8c5a47a2b01 .ag-row[role='row']@ROWINDEX [col-id='cAdvanceDays']","",false, this.CurrentView);
 
            eMaterialType = RPSControlFactory.CreateRPSGridEnumComboBox<CuDistExcelImportMaterialView>("","#a0b15a60-2c2d-4b84-a9c8-b8c5a47a2b01 .ag-row[role='row']@ROWINDEX [col-id='ceMaterialType']","",false, this.CurrentView);
 
            UseAlternativeArticles = RPSControlFactory.CreateRPSGridCheckBox<CuDistExcelImportMaterialView>("","#a0b15a60-2c2d-4b84-a9c8-b8c5a47a2b01 .ag-row[role='row']@ROWINDEX [col-id='cUseAlternativeArticles']","",false, this.CurrentView);
 
            eArticleType = RPSControlFactory.CreateRPSGridEnumComboBox<CuDistExcelImportMaterialView>("","#a0b15a60-2c2d-4b84-a9c8-b8c5a47a2b01 .ag-row[role='row']@ROWINDEX [col-id='ceArticleType']","",false, this.CurrentView);
 
            eQuantityType = RPSControlFactory.CreateRPSGridEnumComboBox<CuDistExcelImportMaterialView>("","#a0b15a60-2c2d-4b84-a9c8-b8c5a47a2b01 .ag-row[role='row']@ROWINDEX [col-id='ceQuantityType']","",false, this.CurrentView);
 
            ModifiedProperties = RPSControlFactory.CreateRPSGridMemoTextBox<CuDistExcelImportMaterialView>("","#a0b15a60-2c2d-4b84-a9c8-b8c5a47a2b01 .ag-row[role='row']@ROWINDEX [col-id='cModifiedProperties']","",false, this.CurrentView);
 
            MaterialExist = RPSControlFactory.CreateRPSGridCheckBox<CuDistExcelImportMaterialView>("","#a0b15a60-2c2d-4b84-a9c8-b8c5a47a2b01 .ag-row[role='row']@ROWINDEX [col-id='cMaterialExist']","",false, this.CurrentView);
 
            Import = RPSControlFactory.CreateRPSGridCheckBox<CuDistExcelImportMaterialView>("","#a0b15a60-2c2d-4b84-a9c8-b8c5a47a2b01 .ag-row[role='row']@ROWINDEX [col-id='cImport']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<CuDistExcelImportMaterialView> ActionTypeDesc { get; set; } 
        public IRPSGridTextBox<CuDistExcelImportMaterialView> CodMaterial { get; set; } 
        public IRPSGridComboBox<CuDistExcelImportMaterialView> IDArticle { get; set; } 
        public IRPSGridTextBox<CuDistExcelImportMaterialView> Description { get; set; } 
        public IRPSGridTextBox<CuDistExcelImportMaterialView> Quantity { get; set; } 
        public IRPSGridTextBox<CuDistExcelImportMaterialView> ContentLot { get; set; } 
        public IRPSGridTextBox<CuDistExcelImportMaterialView> Notes { get; set; } 
        public IRPSGridComboBox<CuDistExcelImportMaterialView> IDSite { get; set; } 
        public IRPSGridComboBox<CuDistExcelImportMaterialView> IDWareHouse { get; set; } 
        public IRPSGridCheckbox<CuDistExcelImportMaterialView> MakeAutomaticOutput { get; set; } 
        public IRPSGridCheckbox<CuDistExcelImportMaterialView> ImputationCostUpdated { get; set; } 
        public IRPSGridComboBox<CuDistExcelImportMaterialView> IDBudgetCategory { get; set; } 
        public IRPSGridTextBox<CuDistExcelImportMaterialView> QuantityElements { get; set; } 
        public IRPSGridTextBox<CuDistExcelImportMaterialView> CompensatingFactor { get; set; } 
        public IRPSGridTextBox<CuDistExcelImportMaterialView> Potency { get; set; } 
        public IRPSGridTextBox<CuDistExcelImportMaterialView> AdvanceDays { get; set; } 
        public IRPSGridComboBox<CuDistExcelImportMaterialView> eMaterialType { get; set; } 
        public IRPSGridCheckbox<CuDistExcelImportMaterialView> UseAlternativeArticles { get; set; } 
        public IRPSGridComboBox<CuDistExcelImportMaterialView> eArticleType { get; set; } 
        public IRPSGridComboBox<CuDistExcelImportMaterialView> eQuantityType { get; set; } 
        public IRPSGridTextBox<CuDistExcelImportMaterialView> ModifiedProperties { get; set; } 
        public IRPSGridCheckbox<CuDistExcelImportMaterialView> MaterialExist { get; set; } 
        public IRPSGridCheckbox<CuDistExcelImportMaterialView> Import { get; set; } 
                     
    }
 
    }
  
    

}