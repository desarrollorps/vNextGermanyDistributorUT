    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.Warehouse.MovementType
{
    //RPS VERSION 1.0.0.0
    public partial class MovementType:Screen
    {
        public MovementType():base()
        {
            this.URL = "warehouse.movementtype";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            MovementTypeCollectionView  = new MovementTypeCollectionView(this); 
            MovementTypeEntityView  = new MovementTypeEntityView(this); 
            MovementTypeCollectionView.InitializeControls(); 
            MovementTypeEntityView.InitializeControls(); 
           
        }
      
            public MovementTypeCollectionView MovementTypeCollectionView {get; set; } 
            public MovementTypeEntityView MovementTypeEntityView {get; set; } 
    }
            
    public partial class MovementTypeCollectionView : View
    {
        public MovementTypeCollectionView(MovementType screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            NewButton = RPSControlFactory.RPSNewButton<MovementTypeCollectionView,MovementTypeEntityView>( this,Screen.MovementTypeEntityView);
 
            CollectionInit params_MainConsult = new CollectionInit(){IDDescriptor = "4fa0eb51-3b36-47e5-99fe-cde6bdd94606",CSSSelectorDescriptor = "",XPathDescriptor = ""};
            MainConsult = RPSControlFactory.RPSCreateCollection<MovementTypeCollectionView,MovementTypeEntityView>( params_MainConsult,this,Screen.MovementTypeEntityView);
 

        }
        public IRPSButton<MovementTypeCollectionView,MovementTypeEntityView> NewButton { get; set; } 
        public IRPSCollectionEditor<MovementTypeCollectionView,MovementTypeEntityView> MainConsult { get; set; } 
        public MovementType Screen { get; set; }
        public MovementTypeCollectionView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class MovementTypeEntityView : View
    {
        public MovementTypeEntityView(MovementType screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            SaveButton = RPSControlFactory.RPSSaveButton<MovementTypeEntityView>( this);
 
            DeleteButton = RPSControlFactory.RPSDeleteButton<MovementTypeEntityView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<MovementTypeEntityView,MovementTypeCollectionView>( this,Screen.MovementTypeCollectionView);
 
            BackButton = RPSControlFactory.RPSBackButton<MovementTypeEntityView,MovementTypeCollectionView>( this,Screen.MovementTypeCollectionView);
 
            CodMovementType = RPSControlFactory.CreateRPSTextBox<MovementTypeEntityView>("a06fb38e-ba2f-43a3-9e46-d1476a63034f","","",true, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<MovementTypeEntityView>("0336c1c9-1b5e-4b87-a425-4ec457ec463e","","",false, this);
 
            Type = RPSControlFactory.CreateRPSEnumComboBox<MovementTypeEntityView>("eb37b49c-0587-4c59-a594-0c3fc87ce6b9","","",true, this);
 
            Manual = RPSControlFactory.CreateRPSCheckBox<MovementTypeEntityView>("09914e89-7b51-48d2-833f-e5ac3c05842d","","",true, this);
 
            UpdateManufacturePrice = RPSControlFactory.CreateRPSCheckBox<MovementTypeEntityView>("36664c64-362e-4b1b-90f0-ef26f201be05","","",true, this);
 
            UpdatePurchasePrice = RPSControlFactory.CreateRPSCheckBox<MovementTypeEntityView>("f1f404ca-ee63-41c2-a7c5-9dfa3611559a","","",true, this);
 
            UpdateAveragePrice = RPSControlFactory.CreateRPSCheckBox<MovementTypeEntityView>("12e15cb2-5482-476c-945b-ed0bff4e4ad0","","",true, this);
 
            EntryPriceZero = RPSControlFactory.CreateRPSCheckBox<MovementTypeEntityView>("f9e9ddd7-806d-43d8-9ae1-1678466c5ba4","","",true, this);
 
            UpdateStandardPrice = RPSControlFactory.CreateRPSCheckBox<MovementTypeEntityView>("a87b73b2-e1c7-41da-b60d-23c617706c9a","","",true, this);
 
            UpdateValuationCost = RPSControlFactory.CreateRPSCheckBox<MovementTypeEntityView>("c2bd0bef-528a-4538-a08f-e4622d0b1740","","",true, this);
 
            ConsumePrevision = RPSControlFactory.CreateRPSCheckBox<MovementTypeEntityView>("9a5094a0-5845-4ea2-b40e-a19d72e14df0","","",true, this);
 
            RotationIndex = RPSControlFactory.CreateRPSCheckBox<MovementTypeEntityView>("4d67ea94-afea-4fd2-bb3c-378a7c6b13a6","","",true, this);
 
            DepositConsumption = RPSControlFactory.CreateRPSCheckBox<MovementTypeEntityView>("17d7e2d4-00fb-4997-9e04-12dbf2fb15a1","","",true, this);
 
            IDIntegrationAccounting = RPSControlFactory.CreateRPSComboBox<MovementTypeEntityView>("6d6f5853-9c97-4a51-aa69-6338ea691de7","","",false, this);
 
            IDIntegrationAccountingEntry = RPSControlFactory.CreateRPSComboBox<MovementTypeEntityView>("80d40945-2533-4d95-a194-e1994f5c712d","","",false, this);
 
            CollectionInit params_IntegrationAccountingWarehouse = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = ""};
            IntegrationAccountingWarehouse = RPSControlFactory.RPSCreateCollection<MovementTypeEntityView>( params_IntegrationAccountingWarehouse,this);
 

        }
        public IRPSSaveButton<MovementTypeEntityView> SaveButton { get; set; } 
        public IRPSButton<MovementTypeEntityView> DeleteButton { get; set; } 
        public IRPSButton<MovementTypeEntityView,MovementTypeCollectionView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<MovementTypeEntityView,MovementTypeCollectionView> BackButton { get; set; } 
        public IRPSTextBox<MovementTypeEntityView> CodMovementType { get; set; } 
        public IRPSTextBox<MovementTypeEntityView> Description { get; set; } 
        public IRPSComboBox<MovementTypeEntityView> Type { get; set; } 
        public IRPSCheckbox<MovementTypeEntityView> Manual { get; set; } 
        public IRPSCheckbox<MovementTypeEntityView> UpdateManufacturePrice { get; set; } 
        public IRPSCheckbox<MovementTypeEntityView> UpdatePurchasePrice { get; set; } 
        public IRPSCheckbox<MovementTypeEntityView> UpdateAveragePrice { get; set; } 
        public IRPSCheckbox<MovementTypeEntityView> EntryPriceZero { get; set; } 
        public IRPSCheckbox<MovementTypeEntityView> UpdateStandardPrice { get; set; } 
        public IRPSCheckbox<MovementTypeEntityView> UpdateValuationCost { get; set; } 
        public IRPSCheckbox<MovementTypeEntityView> ConsumePrevision { get; set; } 
        public IRPSCheckbox<MovementTypeEntityView> RotationIndex { get; set; } 
        public IRPSCheckbox<MovementTypeEntityView> DepositConsumption { get; set; } 
        public IRPSComboBox<MovementTypeEntityView> IDIntegrationAccounting { get; set; } 
        public IRPSComboBox<MovementTypeEntityView> IDIntegrationAccountingEntry { get; set; } 
        public IRPSCollectionEditor<MovementTypeEntityView> IntegrationAccountingWarehouse { get; set; } 
        public MovementType Screen { get; set; }
        public MovementTypeEntityView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}