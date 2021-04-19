    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.SalesDesk.CashMovementTypeSL
{
    //RPS VERSION 1.0.0.0
    public partial class CashMovementTypeSL:Screen
    {
        public CashMovementTypeSL():base()
        {
            this.URL = "salesdesk.cashmovementtypesl";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            CashMovementTypeSLCollectionView  = new CashMovementTypeSLCollectionView(this); 
            CashMovementTypeSLEntityView  = new CashMovementTypeSLEntityView(this); 
            CashMovementTypeSLCollectionView.InitializeControls(); 
            CashMovementTypeSLEntityView.InitializeControls(); 
           
        }
      
            public CashMovementTypeSLCollectionView CashMovementTypeSLCollectionView {get; set; } 
            public CashMovementTypeSLEntityView CashMovementTypeSLEntityView {get; set; } 
    }
            
    public partial class CashMovementTypeSLCollectionView : View
    {
        public CashMovementTypeSLCollectionView(CashMovementTypeSL screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            NewButton = RPSControlFactory.RPSNewButton<CashMovementTypeSLCollectionView,CashMovementTypeSLEntityView>( this,Screen.CashMovementTypeSLEntityView);
 
            CollectionInit params_MainConsult = new CollectionInit(){IDDescriptor = "4c0d0622-aa9d-488e-8f5d-fbe877863557",CSSSelectorDescriptor = "",XPathDescriptor = ""};
            MainConsult = RPSControlFactory.RPSCreateCollection<CashMovementTypeSLCollectionView,CashMovementTypeSLEntityView>( params_MainConsult,this,Screen.CashMovementTypeSLEntityView);
 

        }
        public IRPSButton<CashMovementTypeSLCollectionView,CashMovementTypeSLEntityView> NewButton { get; set; } 
        public IRPSCollectionEditor<CashMovementTypeSLCollectionView,CashMovementTypeSLEntityView> MainConsult { get; set; } 
        public CashMovementTypeSL Screen { get; set; }
        public CashMovementTypeSLCollectionView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class CashMovementTypeSLEntityView : View
    {
        public CashMovementTypeSLEntityView(CashMovementTypeSL screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            SaveButton = RPSControlFactory.RPSSaveButton<CashMovementTypeSLEntityView>( this);
 
            DeleteButton = RPSControlFactory.RPSDeleteButton<CashMovementTypeSLEntityView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<CashMovementTypeSLEntityView,CashMovementTypeSLCollectionView>( this,Screen.CashMovementTypeSLCollectionView);
 
            BackButton = RPSControlFactory.RPSBackButton<CashMovementTypeSLEntityView,CashMovementTypeSLCollectionView>( this,Screen.CashMovementTypeSLCollectionView);
 
            CodCashMovementType = RPSControlFactory.CreateRPSTextBox<CashMovementTypeSLEntityView>("2a35e660-5e5b-4558-9b58-4186098f6eb7","","",true, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<CashMovementTypeSLEntityView>("ae024743-c2cb-4cd3-8d39-ca63c7049e43","","",false, this);
 
            Type = RPSControlFactory.CreateRPSEnumComboBox<CashMovementTypeSLEntityView>("efbc6fc2-e521-4d26-904d-00b8a41e3b25","","",true, this);
 

        }
        public IRPSSaveButton<CashMovementTypeSLEntityView> SaveButton { get; set; } 
        public IRPSButton<CashMovementTypeSLEntityView> DeleteButton { get; set; } 
        public IRPSButton<CashMovementTypeSLEntityView,CashMovementTypeSLCollectionView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<CashMovementTypeSLEntityView,CashMovementTypeSLCollectionView> BackButton { get; set; } 
        public IRPSTextBox<CashMovementTypeSLEntityView> CodCashMovementType { get; set; } 
        public IRPSTextBox<CashMovementTypeSLEntityView> Description { get; set; } 
        public IRPSComboBox<CashMovementTypeSLEntityView> Type { get; set; } 
        public CashMovementTypeSL Screen { get; set; }
        public CashMovementTypeSLEntityView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}