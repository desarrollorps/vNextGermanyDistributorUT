    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.Manufacturing.ImputationMaterialUpdate
{
    //RPS VERSION 1.0.0.0
    public partial class ImputationMaterialUpdate:Screen
    {
        public ImputationMaterialUpdate():base()
        {
            this.URL = "manufacturing.imputationmaterialupdate";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            ImputationMaterialMOVMQueryView  = new ImputationMaterialMOVMQueryView(this); 
            ImputationMaterialMOVMEntityView  = new ImputationMaterialMOVMEntityView(this); 
            ImputationEntryProductView  = new ImputationEntryProductView(this); 
            ImputationMaterialMOVMQueryView.InitializeControls(); 
            ImputationMaterialMOVMEntityView.InitializeControls(); 
            ImputationEntryProductView.InitializeControls(); 
           
        }
      
            public ImputationMaterialMOVMQueryView ImputationMaterialMOVMQueryView {get; set; } 
            public ImputationMaterialMOVMEntityView ImputationMaterialMOVMEntityView {get; set; } 
            public ImputationEntryProductView ImputationEntryProductView {get; set; } 
    }
            
    public partial class ImputationMaterialMOVMQueryView : View
    {
        public ImputationMaterialMOVMQueryView(ImputationMaterialUpdate screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            NewButton = RPSControlFactory.RPSNewButton<ImputationMaterialMOVMQueryView,ImputationMaterialMOVMEntityView>( this,Screen.ImputationMaterialMOVMEntityView);
 
            ConsultButton = RPSControlFactory.RPSConsultButton<ImputationMaterialMOVMQueryView>( this);
 
            NewEntryNavigationCommandButton = RPSControlFactory.CreateRPSButton<ImputationMaterialMOVMQueryView>( "6c9b5491-7b80-410e-823e-ab6a53633622","","",this);
 
            NewImputationNavigationCommandButton = RPSControlFactory.CreateRPSButton<ImputationMaterialMOVMQueryView>( "6d75de09-bba6-424c-ac29-18d4ed59d0fc","","",this);
 
            AcceptCommandButton = RPSControlFactory.CreateRPSButton<ImputationMaterialMOVMQueryView>( "427fc4cf-5e2f-4a3b-ba07-538aa3e0cc3c","","",this);
 
            CollectionInit params_ImputationEntryProductUpdate = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="129c4d82-e1cc-4be5-9d36-690d343ba081",CSSSelectorGrid="",XPathGrid=""};
            ImputationEntryProductUpdate = RPSControlFactory.RPSCreateCollectionWithGrid<ImputationEntryProductUpdateCollectionEditor<ImputationMaterialMOVMQueryView,ImputationMaterialMOVMEntityView>,ImputationMaterialMOVMQueryView,ImputationMaterialMOVMEntityView>( params_ImputationEntryProductUpdate,this,Screen.ImputationMaterialMOVMEntityView);
 
            CollectionInit params_ImputationMaterialUpdateMO = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="236e9bf7-2505-40cc-81b1-e51a5b9c2bc3",CSSSelectorGrid="",XPathGrid=""};
            ImputationMaterialUpdateMO = RPSControlFactory.RPSCreateCollectionWithGrid<ImputationMaterialUpdateMOCollectionEditor<ImputationMaterialMOVMQueryView,ImputationMaterialMOVMEntityView>,ImputationMaterialMOVMQueryView,ImputationMaterialMOVMEntityView>( params_ImputationMaterialUpdateMO,this,Screen.ImputationMaterialMOVMEntityView);
 

        }
        public IRPSButton<ImputationMaterialMOVMQueryView,ImputationMaterialMOVMEntityView> NewButton { get; set; } 
        public IRPSButton<ImputationMaterialMOVMQueryView> ConsultButton { get; set; } 
        public IRPSButton<ImputationMaterialMOVMQueryView> NewEntryNavigationCommandButton { get; set; } 
        public IRPSButton<ImputationMaterialMOVMQueryView> NewImputationNavigationCommandButton { get; set; } 
        public IRPSButton<ImputationMaterialMOVMQueryView> AcceptCommandButton { get; set; } 
        public ImputationEntryProductUpdateCollectionEditor<ImputationMaterialMOVMQueryView,ImputationMaterialMOVMEntityView> ImputationEntryProductUpdate { get; set; } 
        public ImputationMaterialUpdateMOCollectionEditor<ImputationMaterialMOVMQueryView,ImputationMaterialMOVMEntityView> ImputationMaterialUpdateMO { get; set; } 
        public ImputationMaterialUpdate Screen { get; set; }
        public ImputationMaterialMOVMQueryView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class ImputationEntryProductUpdateCollectionEditor<ImputationMaterialMOVMQueryView,ImputationMaterialMOVMEntityView>:RPSCollectionEditor<ImputationMaterialMOVMQueryView,ImputationMaterialMOVMEntityView> where ImputationMaterialMOVMQueryView : class, IView where ImputationMaterialMOVMEntityView : class, IView
    {
        public  ImputationEntryProductUpdateGridView<ImputationMaterialMOVMQueryView,ImputationMaterialMOVMEntityView> GridView {get;set;}
    }
    public partial class ImputationEntryProductUpdateGridView <ImputationMaterialMOVMQueryView,ImputationMaterialMOVMEntityView> :  RPSGridView<ImputationMaterialMOVMQueryView,ImputationMaterialMOVMEntityView> where ImputationMaterialMOVMQueryView : class, IView where ImputationMaterialMOVMEntityView : class, IView
    {
        public ImputationEntryProductUpdateGridView(ImputationMaterialMOVMQueryView currentView,ImputationMaterialMOVMEntityView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            ImputationEntryProduct_ImputationDate = RPSControlFactory.CreateRPSGridTextBox<ImputationMaterialMOVMQueryView>("","#129c4d82-e1cc-4be5-9d36-690d343ba081 .ag-row[role='row']@ROWINDEX [col-id='cImputationEntryProduct_ImputationDate']","",false, this.CurrentView);
 
            ImputationEntryProduct_Quantity = RPSControlFactory.CreateRPSGridFormattedTextBox<ImputationMaterialMOVMQueryView>("","#129c4d82-e1cc-4be5-9d36-690d343ba081 .ag-row[role='row']@ROWINDEX [col-id='cImputationEntryProduct_Quantity']","",false, this.CurrentView);
 
            ImputationEntryProduct_Series = RPSControlFactory.CreateRPSGridTextBox<ImputationMaterialMOVMQueryView>("","#129c4d82-e1cc-4be5-9d36-690d343ba081 .ag-row[role='row']@ROWINDEX [col-id='cImputationEntryProduct_Series']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<ImputationMaterialMOVMQueryView> ImputationEntryProduct_ImputationDate { get; set; } 
        public IRPSGridTextBox<ImputationMaterialMOVMQueryView> ImputationEntryProduct_Quantity { get; set; } 
        public IRPSGridTextBox<ImputationMaterialMOVMQueryView> ImputationEntryProduct_Series { get; set; } 
                     
    }
 
        public partial class ImputationMaterialUpdateMOCollectionEditor<ImputationMaterialMOVMQueryView,ImputationMaterialMOVMEntityView>:RPSCollectionEditor<ImputationMaterialMOVMQueryView,ImputationMaterialMOVMEntityView> where ImputationMaterialMOVMQueryView : class, IView where ImputationMaterialMOVMEntityView : class, IView
    {
        public  ImputationMaterialUpdateMOGridView<ImputationMaterialMOVMQueryView,ImputationMaterialMOVMEntityView> GridView {get;set;}
    }
    public partial class ImputationMaterialUpdateMOGridView <ImputationMaterialMOVMQueryView,ImputationMaterialMOVMEntityView> :  RPSGridView<ImputationMaterialMOVMQueryView,ImputationMaterialMOVMEntityView> where ImputationMaterialMOVMQueryView : class, IView where ImputationMaterialMOVMEntityView : class, IView
    {
        public ImputationMaterialUpdateMOGridView(ImputationMaterialMOVMQueryView currentView,ImputationMaterialMOVMEntityView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            ImputationMaterialMO_ImputationDate = RPSControlFactory.CreateRPSGridTextBox<ImputationMaterialMOVMQueryView>("","#236e9bf7-2505-40cc-81b1-e51a5b9c2bc3 .ag-row[role='row']@ROWINDEX [col-id='cImputationMaterialMO_ImputationDate']","",false, this.CurrentView);
 
            ImputationMaterialMO_CostAmountReal = RPSControlFactory.CreateRPSGridFormattedTextBox<ImputationMaterialMOVMQueryView>("","#236e9bf7-2505-40cc-81b1-e51a5b9c2bc3 .ag-row[role='row']@ROWINDEX [col-id='cImputationMaterialMO_CostAmountReal']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<ImputationMaterialMOVMQueryView> ImputationMaterialMO_ImputationDate { get; set; } 
        public IRPSGridTextBox<ImputationMaterialMOVMQueryView> ImputationMaterialMO_CostAmountReal { get; set; } 
                     
    }
 
    }
  
            
    public partial class ImputationMaterialMOVMEntityView : View
    {
        public ImputationMaterialMOVMEntityView(ImputationMaterialUpdate screen) : base()
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
 
            ImputationDate = RPSControlFactory.CreateRPSTextBox<ImputationMaterialMOVMEntityView>("28858a98-bd15-4c6d-85d5-d95e12b3ea49","","",true, this);
 
            IDMOMaterial = RPSControlFactory.CreateRPSComboBox<ImputationMaterialMOVMEntityView>("ebdf7a46-fd84-46fe-9811-77fbda281745","","",false, this);
 
            IDArticle = RPSControlFactory.CreateRPSComboBox<ImputationMaterialMOVMEntityView>("97b5dcca-ffeb-43bc-b6f6-54a0d543be62","","",true, this);
 
            Quantity = RPSControlFactory.CreateRPSFormattedTextBox<ImputationMaterialMOVMEntityView>("3015f873-4ac6-4e0a-aab8-94c886920985","","",true, this);
 
            QuantitySecondUnit = RPSControlFactory.CreateRPSFormattedTextBox<ImputationMaterialMOVMEntityView>("4a4b840d-0a9c-4ec1-a85e-3a55d5ebfd59","","",true, this);
 
            IDSite = RPSControlFactory.CreateRPSComboBox<ImputationMaterialMOVMEntityView>("e1c48939-844b-4a19-bc1b-8504ee403c1a","","",true, this);
 
            IDWarehouse = RPSControlFactory.CreateRPSComboBox<ImputationMaterialMOVMEntityView>("6beb8a64-3cd1-4b1e-85d0-105207bd1efd","","",true, this);
 
            Series = RPSControlFactory.CreateRPSEnumComboBox<ImputationMaterialMOVMEntityView>("b015635e-18aa-4ce7-9291-f31af0cbc3cd","","",false, this);
 
            IDLocationWarehouse = RPSControlFactory.CreateRPSComboBox<ImputationMaterialMOVMEntityView>("615994e5-1243-42ad-bc43-ef94d37d3690","","",false, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<ImputationMaterialMOVMEntityView>("9155451a-2a13-4a37-a567-92cab3facbac","","",false, this);
 
            CostPriceReal = RPSControlFactory.CreateRPSFormattedTextBox<ImputationMaterialMOVMEntityView>("bf270922-43f6-4f63-820c-bb865a89de1b","","",true, this);
 
            CostAmountReal = RPSControlFactory.CreateRPSFormattedTextBox<ImputationMaterialMOVMEntityView>("c21ec349-953a-4553-9996-e0e07c5ca45e","","",true, this);
 
            SeriesEntryProduct = RPSControlFactory.CreateRPSEnumComboBox<ImputationMaterialMOVMEntityView>("fcb58347-e11c-4c54-8562-c2494faae358","","",false, this);
 
            IDOrderLine = RPSControlFactory.CreateRPSTextBox<ImputationMaterialMOVMEntityView>("04f1f3d4-50b2-4014-9c13-a8df7d78f083","","",false, this);
 
            DeliveryNote = RPSControlFactory.CreateRPSComboBox<ImputationMaterialMOVMEntityView>("42ac37b4-22c9-483c-9be8-77300f8fa6ed","","",false, this);
 
            DocumentNumber = RPSControlFactory.CreateRPSTextBox<ImputationMaterialMOVMEntityView>("a34fe8e9-cab9-4a03-8bf2-b45ba38e7ae9","","",false, this);
 
            IsPosting = RPSControlFactory.CreateRPSCheckBox<ImputationMaterialMOVMEntityView>("d364f5b6-0c62-45a3-98ed-5a8f69f84639","","",true, this);
 

        }
        public IRPSSaveButton<ImputationMaterialMOVMEntityView> SaveButton { get; set; } 
        public IRPSButton<ImputationMaterialMOVMEntityView> DeleteButton { get; set; } 
        public IRPSButton<ImputationMaterialMOVMEntityView,ImputationMaterialMOVMQueryView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<ImputationMaterialMOVMEntityView,ImputationMaterialMOVMQueryView> BackButton { get; set; } 
        public IRPSTextBox<ImputationMaterialMOVMEntityView> ImputationDate { get; set; } 
        public IRPSComboBox<ImputationMaterialMOVMEntityView> IDMOMaterial { get; set; } 
        public IRPSComboBox<ImputationMaterialMOVMEntityView> IDArticle { get; set; } 
        public IRPSTextBox<ImputationMaterialMOVMEntityView> Quantity { get; set; } 
        public IRPSTextBox<ImputationMaterialMOVMEntityView> QuantitySecondUnit { get; set; } 
        public IRPSComboBox<ImputationMaterialMOVMEntityView> IDSite { get; set; } 
        public IRPSComboBox<ImputationMaterialMOVMEntityView> IDWarehouse { get; set; } 
        public IRPSComboBox<ImputationMaterialMOVMEntityView> Series { get; set; } 
        public IRPSComboBox<ImputationMaterialMOVMEntityView> IDLocationWarehouse { get; set; } 
        public IRPSTextBox<ImputationMaterialMOVMEntityView> Description { get; set; } 
        public IRPSTextBox<ImputationMaterialMOVMEntityView> CostPriceReal { get; set; } 
        public IRPSTextBox<ImputationMaterialMOVMEntityView> CostAmountReal { get; set; } 
        public IRPSComboBox<ImputationMaterialMOVMEntityView> SeriesEntryProduct { get; set; } 
        public IRPSTextBox<ImputationMaterialMOVMEntityView> IDOrderLine { get; set; } 
        public IRPSComboBox<ImputationMaterialMOVMEntityView> DeliveryNote { get; set; } 
        public IRPSTextBox<ImputationMaterialMOVMEntityView> DocumentNumber { get; set; } 
        public IRPSCheckbox<ImputationMaterialMOVMEntityView> IsPosting { get; set; } 
        public ImputationMaterialUpdate Screen { get; set; }
        public ImputationMaterialMOVMEntityView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class ImputationEntryProductView : View
    {
        public ImputationEntryProductView(ImputationMaterialUpdate screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            SaveButton = RPSControlFactory.RPSSaveButton<ImputationEntryProductView>( this);
 
            ImputationDate = RPSControlFactory.CreateRPSTextBox<ImputationEntryProductView>("f093ebf7-5df9-4c82-9d77-63df330cd064","","",true, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<ImputationEntryProductView>("e7661134-1d8d-42d4-b8f1-b4c0b26cf75c","","",false, this);
 
            IDSite = RPSControlFactory.CreateRPSComboBox<ImputationEntryProductView>("8573930e-d5ed-46b5-835e-900767b86448","","",true, this);
 
            Quantity = RPSControlFactory.CreateRPSFormattedTextBox<ImputationEntryProductView>("cfca2d47-d8ab-4c81-8076-7b0a955e2e51","","",true, this);
 
            QuantitySecondUnit = RPSControlFactory.CreateRPSFormattedTextBox<ImputationEntryProductView>("089add8e-3e9b-4e5f-9f05-4a8c954dfcec","","",true, this);
 
            IDWarehouse = RPSControlFactory.CreateRPSComboBox<ImputationEntryProductView>("e06d22e7-fe2d-4d46-ad55-fc2685e3f505","","",true, this);
 
            Series = RPSControlFactory.CreateRPSEnumComboBox<ImputationEntryProductView>("eff982af-7cc0-4d22-83d5-e05bf5d8f27c","","",false, this);
 
            IDLocationWarehouse = RPSControlFactory.CreateRPSComboBox<ImputationEntryProductView>("638d08ae-69a8-4b63-975a-55b1de12bd2f","","",false, this);
 
            Price = RPSControlFactory.CreateRPSFormattedTextBox<ImputationEntryProductView>("540b51cf-76f7-41f3-902a-d2fb232bef76","","",true, this);
 
            ExpiryDate = RPSControlFactory.CreateRPSTextBox<ImputationEntryProductView>("c4ed13a8-e19f-4db7-bc2d-90e5ea59e7e2","","",false, this);
 
            DocumentNumber = RPSControlFactory.CreateRPSTextBox<ImputationEntryProductView>("8f6f7d75-72b9-45d3-ac3a-044108899cc5","","",false, this);
 
            IDOrderLine = RPSControlFactory.CreateRPSEnumComboBox<ImputationEntryProductView>("322f0b29-32b2-4ddb-b6f7-8b39b078dcf3","","",false, this);
 
            IDDeliveryNoteLine = RPSControlFactory.CreateRPSEnumComboBox<ImputationEntryProductView>("97e6e2c6-7e1f-407a-b3ea-1c2ec4e3ccc0","","",false, this);
 
            IsRejectedQuantity = RPSControlFactory.CreateRPSCheckBox<ImputationEntryProductView>("dcfe5ac8-4180-4d0a-9591-39a3b1a835fc","","",true, this);
 

        }
        public IRPSSaveButton<ImputationEntryProductView> SaveButton { get; set; } 
        public IRPSTextBox<ImputationEntryProductView> ImputationDate { get; set; } 
        public IRPSTextBox<ImputationEntryProductView> Description { get; set; } 
        public IRPSComboBox<ImputationEntryProductView> IDSite { get; set; } 
        public IRPSTextBox<ImputationEntryProductView> Quantity { get; set; } 
        public IRPSTextBox<ImputationEntryProductView> QuantitySecondUnit { get; set; } 
        public IRPSComboBox<ImputationEntryProductView> IDWarehouse { get; set; } 
        public IRPSComboBox<ImputationEntryProductView> Series { get; set; } 
        public IRPSComboBox<ImputationEntryProductView> IDLocationWarehouse { get; set; } 
        public IRPSTextBox<ImputationEntryProductView> Price { get; set; } 
        public IRPSTextBox<ImputationEntryProductView> ExpiryDate { get; set; } 
        public IRPSTextBox<ImputationEntryProductView> DocumentNumber { get; set; } 
        public IRPSComboBox<ImputationEntryProductView> IDOrderLine { get; set; } 
        public IRPSComboBox<ImputationEntryProductView> IDDeliveryNoteLine { get; set; } 
        public IRPSCheckbox<ImputationEntryProductView> IsRejectedQuantity { get; set; } 
        public ImputationMaterialUpdate Screen { get; set; }
        public ImputationEntryProductView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}