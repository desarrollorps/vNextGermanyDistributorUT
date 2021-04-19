    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.Purchase.DeliveryNoteType
{
    //RPS VERSION 1.0.0.0
    public partial class DeliveryNoteType:Screen
    {
        public DeliveryNoteType():base()
        {
            this.URL = "purchase.deliverynotetype";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            DeliveryNoteTypeCollectionView  = new DeliveryNoteTypeCollectionView(this); 
            DeliveryNoteTypeEntityView  = new DeliveryNoteTypeEntityView(this); 
            DeliveryNoteTypeCollectionView.InitializeControls(); 
            DeliveryNoteTypeEntityView.InitializeControls(); 
           
        }
      
            public DeliveryNoteTypeCollectionView DeliveryNoteTypeCollectionView {get; set; } 
            public DeliveryNoteTypeEntityView DeliveryNoteTypeEntityView {get; set; } 
    }
            
    public partial class DeliveryNoteTypeCollectionView : View
    {
        public DeliveryNoteTypeCollectionView(DeliveryNoteType screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            NewButton = RPSControlFactory.RPSNewButton<DeliveryNoteTypeCollectionView,DeliveryNoteTypeEntityView>( this,Screen.DeliveryNoteTypeEntityView);
 
            CollectionInit params_MainConsult = new CollectionInit(){IDDescriptor = "4e398a6c-1bbf-4f13-baa3-4d370a3d52b2",CSSSelectorDescriptor = "",XPathDescriptor = ""};
            MainConsult = RPSControlFactory.RPSCreateCollection<DeliveryNoteTypeCollectionView,DeliveryNoteTypeEntityView>( params_MainConsult,this,Screen.DeliveryNoteTypeEntityView);
 

        }
        public IRPSButton<DeliveryNoteTypeCollectionView,DeliveryNoteTypeEntityView> NewButton { get; set; } 
        public IRPSCollectionEditor<DeliveryNoteTypeCollectionView,DeliveryNoteTypeEntityView> MainConsult { get; set; } 
        public DeliveryNoteType Screen { get; set; }
        public DeliveryNoteTypeCollectionView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class DeliveryNoteTypeEntityView : View
    {
        public DeliveryNoteTypeEntityView(DeliveryNoteType screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            SaveButton = RPSControlFactory.RPSSaveButton<DeliveryNoteTypeEntityView>( this);
 
            DeleteButton = RPSControlFactory.RPSDeleteButton<DeliveryNoteTypeEntityView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<DeliveryNoteTypeEntityView,DeliveryNoteTypeCollectionView>( this,Screen.DeliveryNoteTypeCollectionView);
 
            BackButton = RPSControlFactory.RPSBackButton<DeliveryNoteTypeEntityView,DeliveryNoteTypeCollectionView>( this,Screen.DeliveryNoteTypeCollectionView);
 
            CodDeliveryNoteType = RPSControlFactory.CreateRPSTextBox<DeliveryNoteTypeEntityView>("efbe982f-58e7-4512-bd8f-da4fd5a26360","","",true, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<DeliveryNoteTypeEntityView>("a7404276-aa35-4232-8563-ea680767ac9f","","",false, this);
 
            WarehouseMovement = RPSControlFactory.CreateRPSCheckBox<DeliveryNoteTypeEntityView>("efbf86db-b604-45dd-b011-127ceb37209c","","",true, this);
 
            PriceError = RPSControlFactory.CreateRPSCheckBox<DeliveryNoteTypeEntityView>("f09a73da-3a5f-4535-8f68-90a4e8f0017c","","",true, this);
 
            Transfer = RPSControlFactory.CreateRPSCheckBox<DeliveryNoteTypeEntityView>("87c1d144-e39e-4af6-b15a-67d2304cb092","","",true, this);
 
            IDMovementTypePurchaseE = RPSControlFactory.CreateRPSComboBox<DeliveryNoteTypeEntityView>("74c14136-3768-42b4-8d1b-2c2dcc7d7645","","",false, this);
 
            IDMovementTypePurchaseO = RPSControlFactory.CreateRPSComboBox<DeliveryNoteTypeEntityView>("3564d459-e45c-4619-9e2e-5c266bf49c44","","",false, this);
 
            Invoice = RPSControlFactory.CreateRPSCheckBox<DeliveryNoteTypeEntityView>("208331fb-9125-46ca-8e41-c13271309f8f","","",true, this);
 
            Statistics = RPSControlFactory.CreateRPSCheckBox<DeliveryNoteTypeEntityView>("bfd5c957-7526-44e1-a806-5538af428973","","",true, this);
 
            QuantityZeroStatistics = RPSControlFactory.CreateRPSCheckBox<DeliveryNoteTypeEntityView>("e03c0444-7e6e-4f99-961e-e7bf027a89b3","","",false, this);
 
            IDIntegrationAccounting = RPSControlFactory.CreateRPSComboBox<DeliveryNoteTypeEntityView>("52c0f1dd-c3d0-4992-9f49-80c92cd61545","","",false, this);
 
            IDSiteTransfer = RPSControlFactory.CreateRPSComboBox<DeliveryNoteTypeEntityView>("6b6b78a5-3f58-47b5-9b4f-8399e342c5b1","","",false, this);
 
            IDWarehouseTransfer = RPSControlFactory.CreateRPSComboBox<DeliveryNoteTypeEntityView>("486d9e12-d1dc-4c8d-a36e-0fa66f23f3ca","","",false, this);
 
            IDMovementTypeTransferE = RPSControlFactory.CreateRPSComboBox<DeliveryNoteTypeEntityView>("3076cf2e-5607-4bc6-8962-407e35fa194a","","",false, this);
 
            IDMovementTypeTransferO = RPSControlFactory.CreateRPSComboBox<DeliveryNoteTypeEntityView>("255f1e9a-7b39-46a6-81b6-1e30e954d45f","","",false, this);
 
            CostPrice = RPSControlFactory.CreateRPSCheckBox<DeliveryNoteTypeEntityView>("8590cc58-3618-4282-b215-653533213374","","",true, this);
 

        }
        public IRPSSaveButton<DeliveryNoteTypeEntityView> SaveButton { get; set; } 
        public IRPSButton<DeliveryNoteTypeEntityView> DeleteButton { get; set; } 
        public IRPSButton<DeliveryNoteTypeEntityView,DeliveryNoteTypeCollectionView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<DeliveryNoteTypeEntityView,DeliveryNoteTypeCollectionView> BackButton { get; set; } 
        public IRPSTextBox<DeliveryNoteTypeEntityView> CodDeliveryNoteType { get; set; } 
        public IRPSTextBox<DeliveryNoteTypeEntityView> Description { get; set; } 
        public IRPSCheckbox<DeliveryNoteTypeEntityView> WarehouseMovement { get; set; } 
        public IRPSCheckbox<DeliveryNoteTypeEntityView> PriceError { get; set; } 
        public IRPSCheckbox<DeliveryNoteTypeEntityView> Transfer { get; set; } 
        public IRPSComboBox<DeliveryNoteTypeEntityView> IDMovementTypePurchaseE { get; set; } 
        public IRPSComboBox<DeliveryNoteTypeEntityView> IDMovementTypePurchaseO { get; set; } 
        public IRPSCheckbox<DeliveryNoteTypeEntityView> Invoice { get; set; } 
        public IRPSCheckbox<DeliveryNoteTypeEntityView> Statistics { get; set; } 
        public IRPSCheckbox<DeliveryNoteTypeEntityView> QuantityZeroStatistics { get; set; } 
        public IRPSComboBox<DeliveryNoteTypeEntityView> IDIntegrationAccounting { get; set; } 
        public IRPSComboBox<DeliveryNoteTypeEntityView> IDSiteTransfer { get; set; } 
        public IRPSComboBox<DeliveryNoteTypeEntityView> IDWarehouseTransfer { get; set; } 
        public IRPSComboBox<DeliveryNoteTypeEntityView> IDMovementTypeTransferE { get; set; } 
        public IRPSComboBox<DeliveryNoteTypeEntityView> IDMovementTypeTransferO { get; set; } 
        public IRPSCheckbox<DeliveryNoteTypeEntityView> CostPrice { get; set; } 
        public DeliveryNoteType Screen { get; set; }
        public DeliveryNoteTypeEntityView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}