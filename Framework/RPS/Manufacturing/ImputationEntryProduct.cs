    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.Manufacturing.ImputationEntryProduct
{
    //RPS VERSION 1.0.0.0
    public partial class ImputationEntryProduct:Screen
    {
        public ImputationEntryProduct():base()
        {
            this.URL = "manufacturing.imputationentryproduct";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            ImputationEntryProductVMQueryView  = new ImputationEntryProductVMQueryView(this); 
            ImputationEntryProductVMEntityView  = new ImputationEntryProductVMEntityView(this); 
            ImputationEntryProductVMQueryView.InitializeControls(); 
            ImputationEntryProductVMEntityView.InitializeControls(); 
           
        }
      
            public ImputationEntryProductVMQueryView ImputationEntryProductVMQueryView {get; set; } 
            public ImputationEntryProductVMEntityView ImputationEntryProductVMEntityView {get; set; } 
    }
            
    public partial class ImputationEntryProductVMQueryView : View
    {
        public ImputationEntryProductVMQueryView(ImputationEntryProduct screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            NewButton = RPSControlFactory.RPSNewButton<ImputationEntryProductVMQueryView,ImputationEntryProductVMEntityView>( this,Screen.ImputationEntryProductVMEntityView);
 
            ConsultButton = RPSControlFactory.RPSConsultButton<ImputationEntryProductVMQueryView>( this);
 
            Site = RPSControlFactory.CreateRPSComboBox<ImputationEntryProductVMQueryView>("b52b9766-dac7-44fc-9fe1-33259388b949","","",false, this);
 
            ManufacturingOrder = RPSControlFactory.CreateRPSCollectionComboBox<ImputationEntryProductVMQueryView>("0089a30a-0e51-4165-8ad2-9b78f0f0c806","","",false, this);
 
            MOTask = RPSControlFactory.CreateRPSCollectionComboBox<ImputationEntryProductVMQueryView>("46e6bdcb-c3f7-499e-bd9b-a864b9424637","","",false, this);
 
            DateFrom = RPSControlFactory.CreateRPSTextBox<ImputationEntryProductVMQueryView>("a6faf3e9-304f-46d8-9c2c-82a0bdc67372","","",false, this);
 
            DateTo = RPSControlFactory.CreateRPSTextBox<ImputationEntryProductVMQueryView>("367e925d-8145-4d85-ba08-d916dccce16f","","",false, this);
 
            Article = RPSControlFactory.CreateRPSCollectionComboBox<ImputationEntryProductVMQueryView>("f2d2a945-1b12-49bf-8043-b8d67db56c78","","",false, this);
 
            UIInternalCode = RPSControlFactory.CreateRPSTextBox<ImputationEntryProductVMQueryView>("f3477bf4-8564-4d6e-acfb-fbbf5bc3dd34","","",false, this);
 
            DeleteCommandButton = RPSControlFactory.CreateRPSButton<ImputationEntryProductVMQueryView>( "e0a213cb-ac3c-4452-ae5f-bce215e53a15","","",this);
 
            CollectionInit params_ImputationEntryProduct = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="3bcde7ae-afb3-48f5-8d3d-c666afbf906e",CSSSelectorGrid="",XPathGrid=""};
            ImputationEntryProduct = RPSControlFactory.RPSCreateCollectionWithGrid<ImputationEntryProductCollectionEditor<ImputationEntryProductVMQueryView,ImputationEntryProductVMEntityView>,ImputationEntryProductVMQueryView,ImputationEntryProductVMEntityView>( params_ImputationEntryProduct,this,Screen.ImputationEntryProductVMEntityView);
 

        }
        public IRPSButton<ImputationEntryProductVMQueryView,ImputationEntryProductVMEntityView> NewButton { get; set; } 
        public IRPSButton<ImputationEntryProductVMQueryView> ConsultButton { get; set; } 
        public IRPSComboBox<ImputationEntryProductVMQueryView> Site { get; set; } 
        public IRPSCollectionComboBox<ImputationEntryProductVMQueryView> ManufacturingOrder { get; set; } 
        public IRPSCollectionComboBox<ImputationEntryProductVMQueryView> MOTask { get; set; } 
        public IRPSTextBox<ImputationEntryProductVMQueryView> DateFrom { get; set; } 
        public IRPSTextBox<ImputationEntryProductVMQueryView> DateTo { get; set; } 
        public IRPSCollectionComboBox<ImputationEntryProductVMQueryView> Article { get; set; } 
        public IRPSTextBox<ImputationEntryProductVMQueryView> UIInternalCode { get; set; } 
        public IRPSButton<ImputationEntryProductVMQueryView> DeleteCommandButton { get; set; } 
        public ImputationEntryProductCollectionEditor<ImputationEntryProductVMQueryView,ImputationEntryProductVMEntityView> ImputationEntryProduct { get; set; } 
        public ImputationEntryProduct Screen { get; set; }
        public ImputationEntryProductVMQueryView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class ImputationEntryProductCollectionEditor<ImputationEntryProductVMQueryView,ImputationEntryProductVMEntityView>:RPSCollectionEditor<ImputationEntryProductVMQueryView,ImputationEntryProductVMEntityView> where ImputationEntryProductVMQueryView : class, IView where ImputationEntryProductVMEntityView : class, IView
    {
        public  ImputationEntryProductGridView<ImputationEntryProductVMQueryView,ImputationEntryProductVMEntityView> GridView {get;set;}
    }
    public partial class ImputationEntryProductGridView <ImputationEntryProductVMQueryView,ImputationEntryProductVMEntityView> :  RPSGridView<ImputationEntryProductVMQueryView,ImputationEntryProductVMEntityView> where ImputationEntryProductVMQueryView : class, IView where ImputationEntryProductVMEntityView : class, IView
    {
        public ImputationEntryProductGridView(ImputationEntryProductVMQueryView currentView,ImputationEntryProductVMEntityView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            ImputationEntryProduct_ImputationDate = RPSControlFactory.CreateRPSGridTextBox<ImputationEntryProductVMQueryView>("","#3bcde7ae-afb3-48f5-8d3d-c666afbf906e .ag-row[role='row']@ROWINDEX [col-id='cImputationEntryProduct_ImputationDate']","",false, this.CurrentView);
 
            ImputationEntryProduct_Quantity = RPSControlFactory.CreateRPSGridFormattedTextBox<ImputationEntryProductVMQueryView>("","#3bcde7ae-afb3-48f5-8d3d-c666afbf906e .ag-row[role='row']@ROWINDEX [col-id='cImputationEntryProduct_Quantity']","",false, this.CurrentView);
 
            ImputationEntryProduct_Series = RPSControlFactory.CreateRPSGridTextBox<ImputationEntryProductVMQueryView>("","#3bcde7ae-afb3-48f5-8d3d-c666afbf906e .ag-row[role='row']@ROWINDEX [col-id='cImputationEntryProduct_Series']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<ImputationEntryProductVMQueryView> ImputationEntryProduct_ImputationDate { get; set; } 
        public IRPSGridTextBox<ImputationEntryProductVMQueryView> ImputationEntryProduct_Quantity { get; set; } 
        public IRPSGridTextBox<ImputationEntryProductVMQueryView> ImputationEntryProduct_Series { get; set; } 
                     
    }
 
    }
  
            
    public partial class ImputationEntryProductVMEntityView : View
    {
        public ImputationEntryProductVMEntityView(ImputationEntryProduct screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            SaveButton = RPSControlFactory.RPSSaveButton<ImputationEntryProductVMEntityView>( this);
 
            DeleteButton = RPSControlFactory.RPSDeleteButton<ImputationEntryProductVMEntityView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<ImputationEntryProductVMEntityView,ImputationEntryProductVMQueryView>( this,Screen.ImputationEntryProductVMQueryView);
 
            BackButton = RPSControlFactory.RPSBackButton<ImputationEntryProductVMEntityView,ImputationEntryProductVMQueryView>( this,Screen.ImputationEntryProductVMQueryView);
 
            ImputationDate = RPSControlFactory.CreateRPSTextBox<ImputationEntryProductVMEntityView>("8e9c894e-ec80-4aaf-83d8-82343939a776","","",true, this);
 
            IDManufacturingOrder = RPSControlFactory.CreateRPSComboBox<ImputationEntryProductVMEntityView>("6bc4e2ef-4253-460d-a792-b748cf22a918","","",true, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<ImputationEntryProductVMEntityView>("1abf49f8-b39b-4c36-b9d6-e0864a849f78","","",false, this);
 
            IDSite = RPSControlFactory.CreateRPSComboBox<ImputationEntryProductVMEntityView>("ec32361b-6325-4ade-9ddf-6eae6f24fe7a","","",true, this);
 
            IDArticle = RPSControlFactory.CreateRPSComboBox<ImputationEntryProductVMEntityView>("9747699e-995b-473a-b5a6-e6feb061deb5","","",false, this);
 
            Quantity = RPSControlFactory.CreateRPSFormattedTextBox<ImputationEntryProductVMEntityView>("3f444c93-4af6-493a-92cd-1c7f56ca57bf","","",true, this);
 
            QuantitySecondUnit = RPSControlFactory.CreateRPSFormattedTextBox<ImputationEntryProductVMEntityView>("7a7c1fe8-c131-4bbb-a032-952da311917a","","",true, this);
 
            PotencyDefault = RPSControlFactory.CreateRPSFormattedTextBox<ImputationEntryProductVMEntityView>("7dcc2876-efec-48a3-995e-78c635190977","","",false, this);
 
            IDWarehouse = RPSControlFactory.CreateRPSComboBox<ImputationEntryProductVMEntityView>("bcb9bb58-9062-499a-aa50-93cc1acc03ef","","",true, this);
 
            Series = RPSControlFactory.CreateRPSEnumComboBox<ImputationEntryProductVMEntityView>("8466826c-c715-433f-8abf-4b0dc8d4f31c","","",false, this);
 
            ChgSerieComm = RPSControlFactory.CreateRPSButton<ImputationEntryProductVMEntityView>( "00205783-fef3-47cb-9809-a7a9616e3346","","",this);
 
            IDLocationWarehouse = RPSControlFactory.CreateRPSComboBox<ImputationEntryProductVMEntityView>("d8359211-4dc8-41a1-8ac0-abab17671949","","",false, this);
 
            Price = RPSControlFactory.CreateRPSFormattedTextBox<ImputationEntryProductVMEntityView>("bb6bd523-8c7c-4608-a35c-048762019fd9","","",true, this);
 
            ExpiryDate = RPSControlFactory.CreateRPSTextBox<ImputationEntryProductVMEntityView>("b0ab41f5-4cf7-4d3a-b568-a1968e90d1e8","","",false, this);
 
            DocumentNumber = RPSControlFactory.CreateRPSTextBox<ImputationEntryProductVMEntityView>("70626ffd-f0b5-4dcd-bbd1-6c9e9c65d265","","",false, this);
 
            IsRejectedQuantity = RPSControlFactory.CreateRPSCheckBox<ImputationEntryProductVMEntityView>("33d7873d-63e1-4111-8f81-313249248d4e","","",true, this);
 
            LinkNavigationCommandButton = RPSControlFactory.CreateRPSButton<ImputationEntryProductVMEntityView>( "f903a655-6618-4709-b02d-fd8257c75d55","","",this);
 

        }
        public IRPSSaveButton<ImputationEntryProductVMEntityView> SaveButton { get; set; } 
        public IRPSButton<ImputationEntryProductVMEntityView> DeleteButton { get; set; } 
        public IRPSButton<ImputationEntryProductVMEntityView,ImputationEntryProductVMQueryView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<ImputationEntryProductVMEntityView,ImputationEntryProductVMQueryView> BackButton { get; set; } 
        public IRPSTextBox<ImputationEntryProductVMEntityView> ImputationDate { get; set; } 
        public IRPSComboBox<ImputationEntryProductVMEntityView> IDManufacturingOrder { get; set; } 
        public IRPSTextBox<ImputationEntryProductVMEntityView> Description { get; set; } 
        public IRPSComboBox<ImputationEntryProductVMEntityView> IDSite { get; set; } 
        public IRPSComboBox<ImputationEntryProductVMEntityView> IDArticle { get; set; } 
        public IRPSTextBox<ImputationEntryProductVMEntityView> Quantity { get; set; } 
        public IRPSTextBox<ImputationEntryProductVMEntityView> QuantitySecondUnit { get; set; } 
        public IRPSTextBox<ImputationEntryProductVMEntityView> PotencyDefault { get; set; } 
        public IRPSComboBox<ImputationEntryProductVMEntityView> IDWarehouse { get; set; } 
        public IRPSComboBox<ImputationEntryProductVMEntityView> Series { get; set; } 
        public IRPSButton<ImputationEntryProductVMEntityView> ChgSerieComm { get; set; } 
        public IRPSComboBox<ImputationEntryProductVMEntityView> IDLocationWarehouse { get; set; } 
        public IRPSTextBox<ImputationEntryProductVMEntityView> Price { get; set; } 
        public IRPSTextBox<ImputationEntryProductVMEntityView> ExpiryDate { get; set; } 
        public IRPSTextBox<ImputationEntryProductVMEntityView> DocumentNumber { get; set; } 
        public IRPSCheckbox<ImputationEntryProductVMEntityView> IsRejectedQuantity { get; set; } 
        public IRPSButton<ImputationEntryProductVMEntityView> LinkNavigationCommandButton { get; set; } 
        public ImputationEntryProduct Screen { get; set; }
        public ImputationEntryProductVMEntityView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}