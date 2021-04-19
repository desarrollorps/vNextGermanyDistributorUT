    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.Manufacturing.ImputationMaterialMO
{
    //RPS VERSION 1.0.0.0
    public partial class ImputationMaterialMO:Screen
    {
        public ImputationMaterialMO():base()
        {
            this.URL = "manufacturing.imputationmaterialmo";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            ImputationMaterialMOVMQueryView  = new ImputationMaterialMOVMQueryView(this); 
            ImputationMaterialMOVMEntityView  = new ImputationMaterialMOVMEntityView(this); 
            ImputationMaterialMOVMQueryView.InitializeControls(); 
            ImputationMaterialMOVMEntityView.InitializeControls(); 
           
        }
      
            public ImputationMaterialMOVMQueryView ImputationMaterialMOVMQueryView {get; set; } 
            public ImputationMaterialMOVMEntityView ImputationMaterialMOVMEntityView {get; set; } 
    }
            
    public partial class ImputationMaterialMOVMQueryView : View
    {
        public ImputationMaterialMOVMQueryView(ImputationMaterialMO screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            NewButton = RPSControlFactory.RPSNewButton<ImputationMaterialMOVMQueryView,ImputationMaterialMOVMEntityView>( this,Screen.ImputationMaterialMOVMEntityView);
 
            ConsultButton = RPSControlFactory.RPSConsultButton<ImputationMaterialMOVMQueryView>( this);
 
            Site = RPSControlFactory.CreateRPSComboBox<ImputationMaterialMOVMQueryView>("b52b9766-dac7-44fc-9fe1-33259388b949","","",false, this);
 
            ManufacturingOrder = RPSControlFactory.CreateRPSCollectionComboBox<ImputationMaterialMOVMQueryView>("0089a30a-0e51-4165-8ad2-9b78f0f0c806","","",false, this);
 
            MOTask = RPSControlFactory.CreateRPSCollectionComboBox<ImputationMaterialMOVMQueryView>("46e6bdcb-c3f7-499e-bd9b-a864b9424637","","",false, this);
 
            DateFrom = RPSControlFactory.CreateRPSTextBox<ImputationMaterialMOVMQueryView>("a6faf3e9-304f-46d8-9c2c-82a0bdc67372","","",false, this);
 
            DateTo = RPSControlFactory.CreateRPSTextBox<ImputationMaterialMOVMQueryView>("367e925d-8145-4d85-ba08-d916dccce16f","","",false, this);
 
            Article = RPSControlFactory.CreateRPSCollectionComboBox<ImputationMaterialMOVMQueryView>("f2d2a945-1b12-49bf-8043-b8d67db56c78","","",false, this);
 
            UIInternalCode = RPSControlFactory.CreateRPSTextBox<ImputationMaterialMOVMQueryView>("6dfbd610-e2bc-4139-b4c4-ae056eb617a5","","",false, this);
 
            DeleteCommandButton = RPSControlFactory.CreateRPSButton<ImputationMaterialMOVMQueryView>( "b1f0e693-4c98-4d85-ad0f-571ba185690e","","",this);
 
            CollectionInit params_ImputationMaterialMO = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="c78ab4ed-53b7-43cd-be15-68d0b3c5f0e8",CSSSelectorGrid="",XPathGrid=""};
            ImputationMaterialMO = RPSControlFactory.RPSCreateCollectionWithGrid<ImputationMaterialMOCollectionEditor<ImputationMaterialMOVMQueryView,ImputationMaterialMOVMEntityView>,ImputationMaterialMOVMQueryView,ImputationMaterialMOVMEntityView>( params_ImputationMaterialMO,this,Screen.ImputationMaterialMOVMEntityView);
 

        }
        public IRPSButton<ImputationMaterialMOVMQueryView,ImputationMaterialMOVMEntityView> NewButton { get; set; } 
        public IRPSButton<ImputationMaterialMOVMQueryView> ConsultButton { get; set; } 
        public IRPSComboBox<ImputationMaterialMOVMQueryView> Site { get; set; } 
        public IRPSCollectionComboBox<ImputationMaterialMOVMQueryView> ManufacturingOrder { get; set; } 
        public IRPSCollectionComboBox<ImputationMaterialMOVMQueryView> MOTask { get; set; } 
        public IRPSTextBox<ImputationMaterialMOVMQueryView> DateFrom { get; set; } 
        public IRPSTextBox<ImputationMaterialMOVMQueryView> DateTo { get; set; } 
        public IRPSCollectionComboBox<ImputationMaterialMOVMQueryView> Article { get; set; } 
        public IRPSTextBox<ImputationMaterialMOVMQueryView> UIInternalCode { get; set; } 
        public IRPSButton<ImputationMaterialMOVMQueryView> DeleteCommandButton { get; set; } 
        public ImputationMaterialMOCollectionEditor<ImputationMaterialMOVMQueryView,ImputationMaterialMOVMEntityView> ImputationMaterialMO { get; set; } 
        public ImputationMaterialMO Screen { get; set; }
        public ImputationMaterialMOVMQueryView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class ImputationMaterialMOCollectionEditor<ImputationMaterialMOVMQueryView,ImputationMaterialMOVMEntityView>:RPSCollectionEditor<ImputationMaterialMOVMQueryView,ImputationMaterialMOVMEntityView> where ImputationMaterialMOVMQueryView : class, IView where ImputationMaterialMOVMEntityView : class, IView
    {
        public  ImputationMaterialMOGridView<ImputationMaterialMOVMQueryView,ImputationMaterialMOVMEntityView> GridView {get;set;}
    }
    public partial class ImputationMaterialMOGridView <ImputationMaterialMOVMQueryView,ImputationMaterialMOVMEntityView> :  RPSGridView<ImputationMaterialMOVMQueryView,ImputationMaterialMOVMEntityView> where ImputationMaterialMOVMQueryView : class, IView where ImputationMaterialMOVMEntityView : class, IView
    {
        public ImputationMaterialMOGridView(ImputationMaterialMOVMQueryView currentView,ImputationMaterialMOVMEntityView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            ImputationMaterialMO_ImputationDate = RPSControlFactory.CreateRPSGridTextBox<ImputationMaterialMOVMQueryView>("","#c78ab4ed-53b7-43cd-be15-68d0b3c5f0e8 .ag-row[role='row']@ROWINDEX [col-id='cImputationMaterialMO_ImputationDate']","",false, this.CurrentView);
 
            ImputationMaterialMO_CostAmountReal = RPSControlFactory.CreateRPSGridFormattedTextBox<ImputationMaterialMOVMQueryView>("","#c78ab4ed-53b7-43cd-be15-68d0b3c5f0e8 .ag-row[role='row']@ROWINDEX [col-id='cImputationMaterialMO_CostAmountReal']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<ImputationMaterialMOVMQueryView> ImputationMaterialMO_ImputationDate { get; set; } 
        public IRPSGridTextBox<ImputationMaterialMOVMQueryView> ImputationMaterialMO_CostAmountReal { get; set; } 
                     
    }
 
    }
  
            
    public partial class ImputationMaterialMOVMEntityView : View
    {
        public ImputationMaterialMOVMEntityView(ImputationMaterialMO screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            SaveButton = RPSControlFactory.RPSSaveButton<ImputationMaterialMOVMEntityView>( this);
 
            DeleteButton = RPSControlFactory.RPSDeleteButton<ImputationMaterialMOVMEntityView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<ImputationMaterialMOVMEntityView,ImputationMaterialMOVMQueryView>( this,Screen.ImputationMaterialMOVMQueryView);
 
            BackButton = RPSControlFactory.RPSBackButton<ImputationMaterialMOVMEntityView,ImputationMaterialMOVMQueryView>( this,Screen.ImputationMaterialMOVMQueryView);
 
            ImputationDate = RPSControlFactory.CreateRPSTextBox<ImputationMaterialMOVMEntityView>("169faf89-8ead-422d-8222-de7a02e5eac1","","",true, this);
 
            IDManufacturingOrder = RPSControlFactory.CreateRPSComboBox<ImputationMaterialMOVMEntityView>("4ceebd79-0506-4993-bb70-4f217535f5bf","","",true, this);
 
            IDMOTask = RPSControlFactory.CreateRPSComboBox<ImputationMaterialMOVMEntityView>("407876c5-5bbe-455a-972a-e01d6e83bf1c","","",true, this);
 
            IDMOMaterial = RPSControlFactory.CreateRPSComboBox<ImputationMaterialMOVMEntityView>("d788ea4f-e051-4a09-bfe5-e9700fa243d7","","",false, this);
 
            IDArticle = RPSControlFactory.CreateRPSComboBox<ImputationMaterialMOVMEntityView>("55b44d05-9531-4a58-914a-a3c8f9d83e9e","","",true, this);
 
            Quantity = RPSControlFactory.CreateRPSFormattedTextBox<ImputationMaterialMOVMEntityView>("d7f6e05d-79db-4205-ad45-0d53c7b45e10","","",true, this);
 
            QuantitySecondUnit = RPSControlFactory.CreateRPSFormattedTextBox<ImputationMaterialMOVMEntityView>("51cc77af-deec-4d8d-9a57-485a193809b9","","",true, this);
 
            QuantityOriginal = RPSControlFactory.CreateRPSFormattedTextBox<ImputationMaterialMOVMEntityView>("1018b1a6-1a02-4010-bb0d-5e41000f1acd","","",false, this);
 
            IDSite = RPSControlFactory.CreateRPSComboBox<ImputationMaterialMOVMEntityView>("02d3604b-8b05-4d6f-9881-34415b82ee69","","",true, this);
 
            IDWarehouse = RPSControlFactory.CreateRPSComboBox<ImputationMaterialMOVMEntityView>("fab33060-d557-417b-bd7f-405afd34bcd5","","",true, this);
 
            Series = RPSControlFactory.CreateRPSEnumComboBox<ImputationMaterialMOVMEntityView>("2a993077-c045-46db-93ba-ab70636ae2c5","","",false, this);
 
            IDLocationWarehouse = RPSControlFactory.CreateRPSComboBox<ImputationMaterialMOVMEntityView>("f1bf0902-3e19-446a-8832-6eecf4e8e2ed","","",false, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<ImputationMaterialMOVMEntityView>("6857518f-d743-41a5-8430-1247d9a2ea31","","",false, this);
 
            CostPriceReal = RPSControlFactory.CreateRPSFormattedTextBox<ImputationMaterialMOVMEntityView>("3da47bee-c3be-47ce-9749-d0318f741031","","",true, this);
 
            CostAmountReal = RPSControlFactory.CreateRPSFormattedTextBox<ImputationMaterialMOVMEntityView>("e33b610e-ddfc-4ead-8592-38854faaabd9","","",true, this);
 
            SeriesEntryProduct = RPSControlFactory.CreateRPSEnumComboBox<ImputationMaterialMOVMEntityView>("9b82b30e-796e-4168-839c-cd866f543aee","","",false, this);
 
            ExpiryDate = RPSControlFactory.CreateRPSTextBox<ImputationMaterialMOVMEntityView>("d8a5c0ec-74e6-4579-a1ba-676f1308848d","","",false, this);
 
            IDOrderLine = RPSControlFactory.CreateRPSEnumComboBox<ImputationMaterialMOVMEntityView>("90cef0ba-046f-4274-a4c0-42a9ddccbcf9","","",false, this);
 
            DeliveryNote = RPSControlFactory.CreateRPSComboBox<ImputationMaterialMOVMEntityView>("bda5da92-b6a2-494c-9a74-382b9b332073","","",false, this);
 
            DocumentNumber = RPSControlFactory.CreateRPSTextBox<ImputationMaterialMOVMEntityView>("098b4a24-a0d2-40cd-a56e-110c5389debe","","",false, this);
 
            IsPosting = RPSControlFactory.CreateRPSCheckBox<ImputationMaterialMOVMEntityView>("bfe503ad-aa1e-444e-86fc-8d19f4f8dbf0","","",true, this);
 
            LinkNavigationCommandButton = RPSControlFactory.CreateRPSButton<ImputationMaterialMOVMEntityView>( "193405c4-c883-4176-aa52-d2c4c1685d22","","",this);
 
            WarehouseMovementNavigationCommandButton = RPSControlFactory.CreateRPSButton<ImputationMaterialMOVMEntityView>( "76619ab3-728b-4bc2-a195-edb430a397ab","","",this);
 

        }
        public IRPSSaveButton<ImputationMaterialMOVMEntityView> SaveButton { get; set; } 
        public IRPSButton<ImputationMaterialMOVMEntityView> DeleteButton { get; set; } 
        public IRPSButton<ImputationMaterialMOVMEntityView,ImputationMaterialMOVMQueryView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<ImputationMaterialMOVMEntityView,ImputationMaterialMOVMQueryView> BackButton { get; set; } 
        public IRPSTextBox<ImputationMaterialMOVMEntityView> ImputationDate { get; set; } 
        public IRPSComboBox<ImputationMaterialMOVMEntityView> IDManufacturingOrder { get; set; } 
        public IRPSComboBox<ImputationMaterialMOVMEntityView> IDMOTask { get; set; } 
        public IRPSComboBox<ImputationMaterialMOVMEntityView> IDMOMaterial { get; set; } 
        public IRPSComboBox<ImputationMaterialMOVMEntityView> IDArticle { get; set; } 
        public IRPSTextBox<ImputationMaterialMOVMEntityView> Quantity { get; set; } 
        public IRPSTextBox<ImputationMaterialMOVMEntityView> QuantitySecondUnit { get; set; } 
        public IRPSTextBox<ImputationMaterialMOVMEntityView> QuantityOriginal { get; set; } 
        public IRPSComboBox<ImputationMaterialMOVMEntityView> IDSite { get; set; } 
        public IRPSComboBox<ImputationMaterialMOVMEntityView> IDWarehouse { get; set; } 
        public IRPSComboBox<ImputationMaterialMOVMEntityView> Series { get; set; } 
        public IRPSComboBox<ImputationMaterialMOVMEntityView> IDLocationWarehouse { get; set; } 
        public IRPSTextBox<ImputationMaterialMOVMEntityView> Description { get; set; } 
        public IRPSTextBox<ImputationMaterialMOVMEntityView> CostPriceReal { get; set; } 
        public IRPSTextBox<ImputationMaterialMOVMEntityView> CostAmountReal { get; set; } 
        public IRPSComboBox<ImputationMaterialMOVMEntityView> SeriesEntryProduct { get; set; } 
        public IRPSTextBox<ImputationMaterialMOVMEntityView> ExpiryDate { get; set; } 
        public IRPSComboBox<ImputationMaterialMOVMEntityView> IDOrderLine { get; set; } 
        public IRPSComboBox<ImputationMaterialMOVMEntityView> DeliveryNote { get; set; } 
        public IRPSTextBox<ImputationMaterialMOVMEntityView> DocumentNumber { get; set; } 
        public IRPSCheckbox<ImputationMaterialMOVMEntityView> IsPosting { get; set; } 
        public IRPSButton<ImputationMaterialMOVMEntityView> LinkNavigationCommandButton { get; set; } 
        public IRPSButton<ImputationMaterialMOVMEntityView> WarehouseMovementNavigationCommandButton { get; set; } 
        public ImputationMaterialMO Screen { get; set; }
        public ImputationMaterialMOVMEntityView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}