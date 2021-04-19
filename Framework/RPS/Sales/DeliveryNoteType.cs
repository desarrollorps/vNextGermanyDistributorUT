    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.Sales.DeliveryNoteType
{
    //RPS VERSION 1.0.0.0
    public partial class DeliveryNoteType:Screen
    {
        public DeliveryNoteType():base()
        {
            this.URL = "sales.deliverynotetype";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            DeliveryNoteTypeSLCollectionView  = new DeliveryNoteTypeSLCollectionView(this); 
            DeliveryNoteTypeSLEntityView  = new DeliveryNoteTypeSLEntityView(this); 
            DeliveryNoteTypeSLCollectionView.InitializeControls(); 
            DeliveryNoteTypeSLEntityView.InitializeControls(); 
           
        }
      
            public DeliveryNoteTypeSLCollectionView DeliveryNoteTypeSLCollectionView {get; set; } 
            public DeliveryNoteTypeSLEntityView DeliveryNoteTypeSLEntityView {get; set; } 
    }
            
    public partial class DeliveryNoteTypeSLCollectionView : View
    {
        public DeliveryNoteTypeSLCollectionView(DeliveryNoteType screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            NewButton = RPSControlFactory.RPSNewButton<DeliveryNoteTypeSLCollectionView,DeliveryNoteTypeSLEntityView>( this,Screen.DeliveryNoteTypeSLEntityView);
 
            CollectionInit params_MainConsult = new CollectionInit(){IDDescriptor = "df71ac54-fe33-4019-9818-6cb47a52e416",CSSSelectorDescriptor = "",XPathDescriptor = ""};
            MainConsult = RPSControlFactory.RPSCreateCollection<DeliveryNoteTypeSLCollectionView,DeliveryNoteTypeSLEntityView>( params_MainConsult,this,Screen.DeliveryNoteTypeSLEntityView);
 

        }
        public IRPSButton<DeliveryNoteTypeSLCollectionView,DeliveryNoteTypeSLEntityView> NewButton { get; set; } 
        public IRPSCollectionEditor<DeliveryNoteTypeSLCollectionView,DeliveryNoteTypeSLEntityView> MainConsult { get; set; } 
        public DeliveryNoteType Screen { get; set; }
        public DeliveryNoteTypeSLCollectionView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class DeliveryNoteTypeSLEntityView : View
    {
        public DeliveryNoteTypeSLEntityView(DeliveryNoteType screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            SaveButton = RPSControlFactory.RPSSaveButton<DeliveryNoteTypeSLEntityView>( this);
 
            DeleteButton = RPSControlFactory.RPSDeleteButton<DeliveryNoteTypeSLEntityView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<DeliveryNoteTypeSLEntityView,DeliveryNoteTypeSLCollectionView>( this,Screen.DeliveryNoteTypeSLCollectionView);
 
            BackButton = RPSControlFactory.RPSBackButton<DeliveryNoteTypeSLEntityView,DeliveryNoteTypeSLCollectionView>( this,Screen.DeliveryNoteTypeSLCollectionView);
 
            CodDeliveryNoteType = RPSControlFactory.CreateRPSTextBox<DeliveryNoteTypeSLEntityView>("51226257-5f37-4b19-b973-d132f33e6df0","","",true, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<DeliveryNoteTypeSLEntityView>("9867c840-c2bd-4c85-b831-13e1f616674e","","",false, this);
 
            WarehouseMovement = RPSControlFactory.CreateRPSCheckBox<DeliveryNoteTypeSLEntityView>("fd84a9ba-e9c6-4144-881a-b26fb8557684","","",true, this);
 
            Transfer = RPSControlFactory.CreateRPSCheckBox<DeliveryNoteTypeSLEntityView>("794dfe47-2dae-4089-bd03-af5ed1dd3969","","",true, this);
 
            PriceError = RPSControlFactory.CreateRPSCheckBox<DeliveryNoteTypeSLEntityView>("a77ccc3b-ccca-4c42-81d5-8c80cf3e1de9","","",true, this);
 
            IDMovementTypeE = RPSControlFactory.CreateRPSComboBox<DeliveryNoteTypeSLEntityView>("5d9ae27c-8990-4f3b-bcee-d0fb72a6c01e","","",false, this);
 
            IDMovementTypeO = RPSControlFactory.CreateRPSComboBox<DeliveryNoteTypeSLEntityView>("1a460785-e65a-4bd8-aef3-1ee023e0f7f5","","",false, this);
 
            Invoice = RPSControlFactory.CreateRPSCheckBox<DeliveryNoteTypeSLEntityView>("511ccdcf-1b4d-4506-9aa6-e9efe5a868ef","","",true, this);
 
            Statistics = RPSControlFactory.CreateRPSCheckBox<DeliveryNoteTypeSLEntityView>("ff64e60e-62ca-4c77-8bed-6de5ed050920","","",true, this);
 
            QuantityZeroStatistics = RPSControlFactory.CreateRPSCheckBox<DeliveryNoteTypeSLEntityView>("363fc1d1-2c9a-4d63-abfa-8e97b567e450","","",false, this);
 
            IDIntegrationAccounting = RPSControlFactory.CreateRPSComboBox<DeliveryNoteTypeSLEntityView>("c9076751-636e-4003-83ba-857b3df60091","","",false, this);
 
            IDSiteTransfer = RPSControlFactory.CreateRPSComboBox<DeliveryNoteTypeSLEntityView>("6ccd240a-3929-4968-a518-4a2799b58e18","","",false, this);
 
            IDWarehouseTransfer = RPSControlFactory.CreateRPSComboBox<DeliveryNoteTypeSLEntityView>("bb9d2ba3-f448-4118-915d-f358c0ee782f","","",false, this);
 
            IDMovementTypeTransferE = RPSControlFactory.CreateRPSComboBox<DeliveryNoteTypeSLEntityView>("a4b6052b-b469-4de8-85a4-275fd0fd5902","","",false, this);
 
            IDMovementTypeTransferO = RPSControlFactory.CreateRPSComboBox<DeliveryNoteTypeSLEntityView>("9e198226-9e9b-4289-b18c-7b4e50fca992","","",false, this);
 
            EntryOutputAtTime = RPSControlFactory.CreateRPSCheckBox<DeliveryNoteTypeSLEntityView>("f541bae1-1502-44ea-ab78-1a4b69d8838a","","",true, this);
 
            CostPrice = RPSControlFactory.CreateRPSCheckBox<DeliveryNoteTypeSLEntityView>("66ed5093-31e6-4459-b3a5-91fd6ffbf340","","",true, this);
 

        }
        public IRPSSaveButton<DeliveryNoteTypeSLEntityView> SaveButton { get; set; } 
        public IRPSButton<DeliveryNoteTypeSLEntityView> DeleteButton { get; set; } 
        public IRPSButton<DeliveryNoteTypeSLEntityView,DeliveryNoteTypeSLCollectionView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<DeliveryNoteTypeSLEntityView,DeliveryNoteTypeSLCollectionView> BackButton { get; set; } 
        public IRPSTextBox<DeliveryNoteTypeSLEntityView> CodDeliveryNoteType { get; set; } 
        public IRPSTextBox<DeliveryNoteTypeSLEntityView> Description { get; set; } 
        public IRPSCheckbox<DeliveryNoteTypeSLEntityView> WarehouseMovement { get; set; } 
        public IRPSCheckbox<DeliveryNoteTypeSLEntityView> Transfer { get; set; } 
        public IRPSCheckbox<DeliveryNoteTypeSLEntityView> PriceError { get; set; } 
        public IRPSComboBox<DeliveryNoteTypeSLEntityView> IDMovementTypeE { get; set; } 
        public IRPSComboBox<DeliveryNoteTypeSLEntityView> IDMovementTypeO { get; set; } 
        public IRPSCheckbox<DeliveryNoteTypeSLEntityView> Invoice { get; set; } 
        public IRPSCheckbox<DeliveryNoteTypeSLEntityView> Statistics { get; set; } 
        public IRPSCheckbox<DeliveryNoteTypeSLEntityView> QuantityZeroStatistics { get; set; } 
        public IRPSComboBox<DeliveryNoteTypeSLEntityView> IDIntegrationAccounting { get; set; } 
        public IRPSComboBox<DeliveryNoteTypeSLEntityView> IDSiteTransfer { get; set; } 
        public IRPSComboBox<DeliveryNoteTypeSLEntityView> IDWarehouseTransfer { get; set; } 
        public IRPSComboBox<DeliveryNoteTypeSLEntityView> IDMovementTypeTransferE { get; set; } 
        public IRPSComboBox<DeliveryNoteTypeSLEntityView> IDMovementTypeTransferO { get; set; } 
        public IRPSCheckbox<DeliveryNoteTypeSLEntityView> EntryOutputAtTime { get; set; } 
        public IRPSCheckbox<DeliveryNoteTypeSLEntityView> CostPrice { get; set; } 
        public DeliveryNoteType Screen { get; set; }
        public DeliveryNoteTypeSLEntityView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}